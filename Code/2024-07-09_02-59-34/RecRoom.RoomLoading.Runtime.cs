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
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x706BAF0", Offset = "0x706A6F0", VA = "0x18706BAF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
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
	public class LogRegistrationIndex : NNAGAKKCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7066930", Offset = "0x7065530", VA = "0x187066930", Slot = "4")]
		public override void NGMFPPEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KHBHEKFFCLH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7062010", Offset = "0x7060C10", VA = "0x187062010")]
	public KHBHEKFFCLH(string NKAJDDICLFH, Exception PJELPOAIABL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class LOGIBFOKONL : MKBNDIFGLEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IMCMIKCEELP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BCBONPLPCBB>> <>t__builder;

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
		private TaskAwaiter<AGIBHFBABDL<BCBONPLPCBB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7061A10", Offset = "0x7060610", VA = "0x187061A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7061C50", Offset = "0x7060850", VA = "0x187061C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FFJFABIOMKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IOJJPOGCODG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<IOJJPOGCODG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x705D760", Offset = "0x705C360", VA = "0x18705D760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x705D970", Offset = "0x705C570", VA = "0x18705D970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	[UnityEngine.Scripting.Preserve]
	public LOGIBFOKONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7065E80", Offset = "0x7064A80", VA = "0x187065E80", Slot = "4")]
	[AsyncStateMachine(typeof(IMCMIKCEELP))]
	public Task<IReadOnlyList<BCBONPLPCBB>> MIPPGECDBGI(long ACIHEOIHPAO, long GPDLAAEANOD, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7065D70", Offset = "0x7064970", VA = "0x187065D70", Slot = "5")]
	[AsyncStateMachine(typeof(FFJFABIOMKB))]
	public Task<IReadOnlyList<IOJJPOGCODG>> GILKIOBKOBP(IReadOnlyList<int> MFMGIEPALKI, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HAIDHEDGBCJ : IEquatable<HAIDHEDGBCJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IIJIMMBMEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	IOJJPOGCODG JMKENBDPFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime DNIGLKBDKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FEPOFBMICJP? FMIEMBOCLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BHJBCLNDPNA? LLOHMEALJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	MODDGLFMBOD LBDFFIOFNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MPFBHKIJKJP> FMNEJPEDNKF();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum MODDGLFMBOD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MKBNDIFGLEA
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BCBONPLPCBB>> MIPPGECDBGI(long ACIHEOIHPAO, long GPDLAAEANOD, [Optional] CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<IOJJPOGCODG>> GILKIOBKOBP(IReadOnlyList<int> MFMGIEPALKI, [Optional] CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DICJHMCNNOJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class KCJLBKEHNMN : HAIDHEDGBCJ, IEquatable<HAIDHEDGBCJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct NMPFIPINEIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public KCJLBKEHNMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private BEEFMGNOPPE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<PFJIJEDBGEL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MPFBHKIJKJP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7069F50", Offset = "0x7068B50", VA = "0x187069F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x706A3F0", Offset = "0x7068FF0", VA = "0x18706A3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BCBONPLPCBB HCLAHKBILCO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IIJIMMBMEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IOJJPOGCODG JMKENBDPFJG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime PPFKFOFLCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5C029C0", Offset = "0x5C015C0", VA = "0x185C029C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FEPOFBMICJP? FMIEMBOCLGN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A1A0", Offset = "0x1C28DA0", VA = "0x181C2A1A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BHJBCLNDPNA? LLOHMEALJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5C02AA0", Offset = "0x5C016A0", VA = "0x185C02AA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MODDGLFMBOD LBDFFIOFNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "10")]
			get
			{
				return default(MODDGLFMBOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7061E30", Offset = "0x7060A30", VA = "0x187061E30", Slot = "9")]
		[AsyncStateMachine(typeof(NMPFIPINEIO))]
		public Task<MPFBHKIJKJP> FMNEJPEDNKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7061FB0", Offset = "0x7060BB0", VA = "0x187061FB0")]
		public KCJLBKEHNMN(int KJAAOPDBOCG, IOJJPOGCODG EBPEGOONELO, BCBONPLPCBB HCLAHKBILCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7061DA0", Offset = "0x70609A0", VA = "0x187061DA0", Slot = "11")]
		public bool Equals(HAIDHEDGBCJ HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7061D00", Offset = "0x7060900", VA = "0x187061D00", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7061CC0", Offset = "0x70608C0", VA = "0x187061CC0")]
		private bool BNPOKEAFGMB(KCJLBKEHNMN HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7061F30", Offset = "0x7060B30", VA = "0x187061F30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class GNGIJHMECGI : HAIDHEDGBCJ, IEquatable<HAIDHEDGBCJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct BFOHGJKEFAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public GNGIJHMECGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<MPFBHKIJKJP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7059F90", Offset = "0x7058B90", VA = "0x187059F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x705A1C0", Offset = "0x7058DC0", VA = "0x18705A1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly ECJJPIPOFMP PDHGLMOFEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly FEPOFBMICJP MICKIOLGHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly BHJBCLNDPNA CAPOGAHFLFE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IIJIMMBMEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x705FE60", Offset = "0x705EA60", VA = "0x18705FE60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IOJJPOGCODG JMKENBDPFJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x705FEA0", Offset = "0x705EAA0", VA = "0x18705FEA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime PPFKFOFLCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x705FA50", Offset = "0x705E650", VA = "0x18705FA50", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FEPOFBMICJP? FMIEMBOCLGN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x705FD40", Offset = "0x705E940", VA = "0x18705FD40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BHJBCLNDPNA? LLOHMEALJGP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x705FE10", Offset = "0x705EA10", VA = "0x18705FE10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MODDGLFMBOD LBDFFIOFNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8E1570", Offset = "0x8E0170", VA = "0x1808E1570", Slot = "10")]
			get
			{
				return default(MODDGLFMBOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10ED770", Offset = "0x10EC370", VA = "0x1810ED770")]
		public GNGIJHMECGI(ECJJPIPOFMP INHGMJFCGBK, FEPOFBMICJP OIJKOCEBEMF, BHJBCLNDPNA DLDDMHOPBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x705FC50", Offset = "0x705E850", VA = "0x18705FC50", Slot = "9")]
		[AsyncStateMachine(typeof(BFOHGJKEFAE))]
		public Task<MPFBHKIJKJP> FMNEJPEDNKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x705FBB0", Offset = "0x705E7B0", VA = "0x18705FBB0", Slot = "11")]
		public bool Equals(HAIDHEDGBCJ HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x705FB00", Offset = "0x705E700", VA = "0x18705FB00", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x705FAA0", Offset = "0x705E6A0", VA = "0x18705FAA0")]
		private bool BNPOKEAFGMB(GNGIJHMECGI HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x705FD90", Offset = "0x705E990", VA = "0x18705FD90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PFHFOOMACLM : HAIDHEDGBCJ, IEquatable<HAIDHEDGBCJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct LJKEONKBHDG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<MPFBHKIJKJP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7065A70", Offset = "0x7064670", VA = "0x187065A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7065CB0", Offset = "0x70648B0", VA = "0x187065CB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly IOJJPOGCODG KNEGDNLKGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly FEPOFBMICJP MICKIOLGHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly BHJBCLNDPNA CAPOGAHFLFE;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IIJIMMBMEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7075280", Offset = "0x7073E80", VA = "0x187075280", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public IOJJPOGCODG JMKENBDPFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime PPFKFOFLCAI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FEPOFBMICJP? FMIEMBOCLGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7075150", Offset = "0x7073D50", VA = "0x187075150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BHJBCLNDPNA? LLOHMEALJGP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7075230", Offset = "0x7073E30", VA = "0x187075230", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MODDGLFMBOD LBDFFIOFNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "10")]
			get
			{
				return default(MODDGLFMBOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10ED770", Offset = "0x10EC370", VA = "0x1810ED770")]
		public PFHFOOMACLM(IOJJPOGCODG EBPEGOONELO, FEPOFBMICJP OIJKOCEBEMF, BHJBCLNDPNA DLDDMHOPBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7075080", Offset = "0x7073C80", VA = "0x187075080", Slot = "9")]
		[AsyncStateMachine(typeof(LJKEONKBHDG))]
		public Task<MPFBHKIJKJP> FMNEJPEDNKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7074E50", Offset = "0x7073A50", VA = "0x187074E50", Slot = "11")]
		public bool Equals(HAIDHEDGBCJ HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7074F60", Offset = "0x7073B60", VA = "0x187074F60", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70751A0", Offset = "0x7073DA0", VA = "0x1870751A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7074D70", Offset = "0x7073970", VA = "0x187074D70")]
		private bool BNPOKEAFGMB(PFHFOOMACLM HEIGABGMPLJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BAADCMPMCEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<HAIDHEDGBCJ>> <>t__builder;

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
		public DICJHMCNNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BCBONPLPCBB> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BCBONPLPCBB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, IOJJPOGCODG account, BCBONPLPCBB roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7058B80", Offset = "0x7057780", VA = "0x187058B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x70599B0", Offset = "0x70585B0", VA = "0x1870599B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MAFDBMOLBHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, IOJJPOGCODG account, BCBONPLPCBB roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BCBONPLPCBB> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DICJHMCNNOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<IOJJPOGCODG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7066B10", Offset = "0x7065710", VA = "0x187066B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x70674F0", Offset = "0x70660F0", VA = "0x1870674F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FPEMJEGFPFN ECLJDEENFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MKBNDIFGLEA AFPLBDPDEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JFHNOOMNJEI EOJPLBEDMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FBOJOKLNJJM<(long, long), IReadOnlyList<BCBONPLPCBB>> BJPIEDPCMBL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x705B6C0", Offset = "0x705A2C0", VA = "0x18705B6C0")]
	[UnityEngine.Scripting.Preserve]
	public DICJHMCNNOJ([POJODGKFIMO(null)] MKBNDIFGLEA HFNIANPCNLH, [POJODGKFIMO(null)] JFHNOOMNJEI COLOGNFPFJM, [POJODGKFIMO(null)] FPEMJEGFPFN MDEFGAIJKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x705B460", Offset = "0x705A060", VA = "0x18705B460")]
	[AsyncStateMachine(typeof(BAADCMPMCEE))]
	public Task<IList<HAIDHEDGBCJ>> KIHLKENBJJK(long ACIHEOIHPAO, long EPCPKKDEADD, bool FFOGGKFJKHK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x705B2C0", Offset = "0x7059EC0", VA = "0x18705B2C0")]
	private bool GALCIEINJOL(DateTime? OCMAJDFBCOI, long ACIHEOIHPAO, long EPCPKKDEADD, [Out] ECJJPIPOFMP KDFNCJHIKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x705B5B0", Offset = "0x705A1B0", VA = "0x18705B5B0")]
	[AsyncStateMachine(typeof(MAFDBMOLBHA))]
	private Task<IReadOnlyList<(int, IOJJPOGCODG, BCBONPLPCBB)>> OJDLPDPFGAN(IReadOnlyList<BCBONPLPCBB> OHIMGJMMJHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JFHNOOMNJEI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ECJJPIPOFMP> FKPNNAGOMFO;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPHPJJNFMMG(long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO, JGCKGNBCBHH GOPLAELIJFH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FBOJDIJAGGO(long ACIHEOIHPAO, long EPCPKKDEADD, [Out] ECJJPIPOFMP KDFNCJHIKEE);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EDGMPHNAHFK(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, [Out] ECJJPIPOFMP KDFNCJHIKEE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LICCBEBAJKG(long ACIHEOIHPAO, long EPCPKKDEADD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface OINFNBOPCLC : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MIJALPAFDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task DFADAHODNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMODNKKMODM(Task LJPOAIPEHGB, string GPDCOBKBDCA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface KFJMFMLAOBL : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MPFBHKIJKJP> LCBJAGHFHFO(ECJJPIPOFMP KDFNCJHIKEE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LKFEEMPKKLL(CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface MBAHKNOPOHL : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CBPBLOCHIAA OBPMDHCICON
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDNOJJDHGNH();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONCBGNBJMGN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface IAKAONBBDGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface AADKOFCNMIA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BLBPKDNGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan GAOOAMEOHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan MFJBPAAAKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NDKLMFPLOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MHGBMFNLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FMLJIEMBGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool BLOLDEFHAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int EBFMGGAHFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ADIMAHINGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NBGOOELNGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool EGPEBKMBDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum ECOOAMIMAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PLCGGJDBLPO
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
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LEDBKEPMGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long FDODEMBCPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long GPDLAAEANOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly ECOOAMIMAMI HGPIKDLKBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception DOHPCGPAFGN;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70620D0", Offset = "0x7060CD0", VA = "0x1870620D0")]
	public LEDBKEPMGME(long FDODEMBCPLL, long GPDLAAEANOD, ECOOAMIMAMI HGPIKDLKBHO, [CanBeNull] Exception DOHPCGPAFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7062080", Offset = "0x7060C80", VA = "0x187062080")]
	public static LEDBKEPMGME ABOMBKDKOLM(MEEJEPKLPKH IMBBGDNCFHM, ECOOAMIMAMI HGPIKDLKBHO, [Optional] Exception DOHPCGPAFGN)
	{
		return default(LEDBKEPMGME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void KMCANHLACNM(LEDBKEPMGME LKKADIAOGCG);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface GJNCAINFMDB : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EBNGAGJJOFP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KMCANHLACNM BPKMCLHOIAC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KMCANHLACNM AGLADNEDLKJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KMCANHLACNM AKCIGMGLCGH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PLCGGJDBLPO, bool> GJPKPGNAGPB;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FGHAFFOIJEI();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LLFOAPKCNMB(LEDBKEPMGME LKKADIAOGCG);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ACCCHOKHLIP(LEDBKEPMGME LKKADIAOGCG);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HMNAJODCAJC(LEDBKEPMGME LKKADIAOGCG);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IHLKNEDJNJL(PLCGGJDBLPO CIANIJNKGHA, bool OBJBDHJNFNO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface FJJCCCDIGDF : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FGJCCEABFKC();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFPGONGBLBL();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface BDKHOGEIDMK : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TaskStatus BBDLBKJDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AJBJJGDPGLL(MEEJEPKLPKH GFLPMJJNNHA, AHHJNEMBLEG LBIJBENADAC, CancellationToken OADLPMIOAJN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class LNCBIHOAJDC
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7065D20", Offset = "0x7064920", VA = "0x187065D20")]
	public static bool AMIONKPPODI(this BDKHOGEIDMK JPAFJOENBOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task OPGHOJOJHDC(CancellationToken GBENACPKFNA, int IOHDDPEAOIC, CDDOIGKGONH CJKDJFKICDF);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface MEALNJKKLNK : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBLIEEGKLHK(OPGHOJOJHDC MJNFPFCIEBG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface CJIDFPHHKMP : BEEFMGNOPPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CancellationToken JCCDGGBNMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IMEOEBHKJNP OOOIPIFJPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	LNOBPBGOOIO JMLHLNDEFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AODBHPFKBMI PDDMAMLAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BOEFEBEHKHL MGJFEDPKAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PDIHFKFJPBI OADGIOLLMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NNAPICGMCIC LHOGAIBBOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DNMCGKCDFPB JOHBPBJMBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OINFNBOPCLC GJBJPDHHGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KFJMFMLAOBL FHLKOMNBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GJNCAINFMDB NHBEAHNDAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FJJCCCDIGDF FIPEAGOLEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	BDKHOGEIDMK HENJGHGFIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MEALNJKKLNK EJNMCMJIHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BHPFLHPLOKA MMAFMEKJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IAFFALHFFID IJEJCMMBLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EJFPALBBJFC FJHGPHFHABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KIPCHPEMFOC GDHKBHJPLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DGLICIJBPIP HFFNNDBFBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CJOIIEBJJHD FONCILLDAII
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OALJJAGILGN HBKFBGPLNGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GLIFLBJDJKL IFKNLOGCEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FLNJBKCKBJD BAEFONDGAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FGOMPOJJPAE KKAJGPIENIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	MBAHKNOPOHL PJDHEHCJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AADKOFCNMIA EFBGDKJFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	MFCLJJEJGJM KMPIKFBAAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JFHNOOMNJEI HJJFDAFKGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	NFDNMKKJCKI NCAAGOKEDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	ACJCNKIMHHO LLKKFFLGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	DBNFAKLLPMO FBCNBPFBHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PGGFLOJHJFG(AHHJNEMBLEG JMKBNEINFOD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BHPFLHPLOKA : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFGAONAEGFJ LKPJOLMECIF(Guid FEHGEPPCEAL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ECLBFOFCOFL(Guid FEHGEPPCEAL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FGLMAGAKNKK(Guid FEHGEPPCEAL, Task JHHOGHJOILL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNAEHFHLLAM(Guid FEHGEPPCEAL, MPFBHKIJKJP KECJNGBFAFP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(MPFBHKIJKJP, Task)> DBCGNIKNEIP(Guid FEHGEPPCEAL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface EOKHJDOHENH : IAKAONBBDGH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface IAFFALHFFID : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMMOCLCAKAI(LJGJBLECALO NKAJDDICLFH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POLIOBLAKGF(LJGJBLECALO NKAJDDICLFH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BKDLNBFPHDL> ODLDCHKGNIL(CancellationToken GCLNJHMJEIF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface EJFPALBBJFC : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFGAONAEGFJ EAHKCKJDENI(LJGJBLECALO FIHOALOLKNP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJLLIDGPJAE(Guid FEHGEPPCEAL, Task JHHOGHJOILL);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface KIPCHPEMFOC : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MPFBHKIJKJP> GDHKBHJPLIM(LJGJBLECALO COCEJHGOBBC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface DGLICIJBPIP : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LDKNGEJJMKB> DICCGGDODNO(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, MEEJEPKLPKH GFLPMJJNNHA, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface OALJJAGILGN : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFBHKIJKJP LDKLILCDKMM(MLFBKPIOFCD OGPHJGPEMCM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AGEIAKKJDNF(string BPMIFKHAMKI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface CJOIIEBJJHD : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LJGJBLECALO> POIDAIKKPLP(LJGJBLECALO KAIGMLIOMBJ, LMPPFDJJNDM HCAMFOCLHJP, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LJGJBLECALO> HLMHKPPEDFC(CancellationToken PPKBAEMFIMG, LMPPFDJJNDM HCAMFOCLHJP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNBHHFEPHJK POIJEJBAHAA(HFKGHGOGEPA CEOBDGJPBEK, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MNBHHFEPHJK LAGBCJMOAIE(HFKGHGOGEPA CEOBDGJPBEK, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface GLIFLBJDJKL : IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFBHKIJKJP COPGMDLACPF(MLFBKPIOFCD OGPHJGPEMCM, BKDLNBFPHDL PNANBJBKPCG);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPFBHKIJKJP KLCCHAJPHCJ(MLFBKPIOFCD APLIOENMKHP);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FLNJBKCKBJD
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDENFJDKDCN(GPIHDIPGECD OJBAICDEHLP);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFMLEAMAJDB(GPIHDIPGECD OJBAICDEHLP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDGBJAHEFNM(GPIHDIPGECD OJBAICDEHLP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAIPCEIMJGK(GPIHDIPGECD OJBAICDEHLP);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GPIHDIPGECD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MEEJEPKLPKH JEBIHLCKADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> AKFLKOGIIAH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public BILFBGGHINK<string> BLEJPGHMDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public GPIHDIPGECD(MEEJEPKLPKH MGEDBJHLFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x70606B0", Offset = "0x705F2B0", VA = "0x1870606B0")]
	public GPIHDIPGECD PBFFHFJDMII(string NCMHANGAILD, string IIPLJLPCLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7060620", Offset = "0x705F220", VA = "0x187060620")]
	public bool AMFDNNMCFEM([Out] IEnumerable<KeyValuePair<string, string>> GIFAEBCMCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x62D4690", Offset = "0x62D3290", VA = "0x1862D4690")]
	public GPIHDIPGECD IGEOLDFIAHI(BILFBGGHINK<string> IFGCIHPEHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MFCLJJEJGJM
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool GJOOGHCEEII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string ENGGIIPJKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FAHDJJHEHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FJJMFBDMIEC();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ICJKGANAPPC IGOGIPHLCPM(long PGCBOFIMNFK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ADLAMOLFKJD<OHEPJFMFHIA, ONEEHEFMPOC> HBKLNBBKDMP(long PGCBOFIMNFK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ADLAMOLFKJD<OHEPJFMFHIA, KDDAPCIFEMM> CHKKLHPIJJI(long PGCBOFIMNFK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ADLAMOLFKJD<long, HMLFEFILMLH> AGDBALJHEDO();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PNFANEGKFJP(long PGCBOFIMNFK, [Out] bool PJBKEAAPJHL);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> GCNJDOKNPHC(byte[] BJKFDJBGPCA, byte[] AKHAPOCCMLF, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BEEFMGNOPPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool AMIONKPPODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool MHGNPMPOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	AHHJNEMBLEG APMOPAPNPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action EBNGAGJJOFP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KMCANHLACNM BPKMCLHOIAC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KMCANHLACNM AGLADNEDLKJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KMCANHLACNM AKCIGMGLCGH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PLCGGJDBLPO, bool> GJPKPGNAGPB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IFPGONGBLBL();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FPPLDNNKFDF IHOIEFFAABI();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AELCJGIHAMM KOJPDKMEINE();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<MPFBHKIJKJP> LCBJAGHFHFO(ECJJPIPOFMP INHGMJFCGBK);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task LKFEEMPKKLL(CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BOEFEBEHKHL
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool JJLAMGMGKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string MAAPKBCNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDNFPEJKLBJ(Scene HGEGDKIBNDE);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HFOMFHDMGGA(PIHPEOKKDFC LLEEBCEHFIO, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DCBJDPKGMOL();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IFNGAIHEBCF();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NOIFJHBLDNB
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool ELCIAOMCKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool KLJDJLDJHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool IGFJLKJCOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool AOLNAMGNJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int PHLJKFEGMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool DNJAAIGABDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool NKFBPJPDKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte ICMOGALEGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte NJOPJFNBBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool HIPLOPIKFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool EDNMHDCKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool OGBHIKHJBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float PBDJHBJBLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> LKBEDLMPFFK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMEOEBHKJNP GAEJNLCNNPD(IMEOEBHKJNP OKGJNNFLBCE);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFHDKPNEOBP(IMEOEBHKJNP MLGAMJFBMDB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHMCKHOEDMI();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task JIDLGNNHDKJ(BILFBGGHINK<string>.OADHIEPGLKH HEJKAPJMBIN, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKLCGFJEJEI(float NGAMHGHMCHP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PLAPPHOEBKM(string AIFLFFEHDCG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<JIGCBJLDEBD> JFHOFMJEFEO();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable OLGFBHGKBEN(object NGDLPEOFMHL, JIGCBJLDEBD CEELIFFGBFO);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<OAKHCAFPAND> DJENKIJKBBI();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ONEEHEFMPOC MJEJOFGOAOF(IEnumerable<KPIIJEHPKNN> DOGMEMACJGE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BIIIICBNDIP(int GNNOHLIDBFM);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task IJKAEBNFEDK();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BMJCPLFMDGP();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MOCAHNBHEAA();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DFOBDBKADEN(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task LMFFEEECMCP(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<MOCJCNACIDI> NCNAHBAGPIG(DateTime HHKHKPMNNCF, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> AIIEPDPGNHP(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GPLICDBEFDD(string NKAJDDICLFH = "", float CNHHDPPEEFN = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KGEECBBCBNK FDEFJJAIFHE(GJPJKPDEMOM JOEEKMPCLDM, OMNKEAGFBHA MAPNCLDEJPP, KDDAPCIFEMM OFNKNACPCHJ, IEnumerable<PersistenceView> DNPALHFCCGD, OFBAJKALOEC NGNNKJJMMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JEKKOPAKIAJ(KDDAPCIFEMM OFNKNACPCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PBJMBLBNPAH(KPIIJEHPKNN GLDBNLEBGAB, [In] KGEECBBCBNK PMKGPOKBHEN);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task BFCILPPLMFG(KDDAPCIFEMM KDOIJJFLEJM, bool JEDEDJKFPJN, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task CIMELBPDPGM(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IAFBGHHEEMD(long ACIHEOIHPAO, long GPDLAAEANOD, PFJIJEDBGEL LMMFGIBEDHB, BCBONPLPCBB EABIOAJDJPA, PJDBEJLAAGG JICPAADAAKO, NFDGGMAMIAG? DDNEDFLHLJM, DOFPGBMFAOA? ECCDOIOGMEG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BPGINALAAJK(long ACIHEOIHPAO, long GPDLAAEANOD, DOFPGBMFAOA? ECCDOIOGMEG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CIHGILGPMCD(PersistenceView DKGHAJMLLEA);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool IKAFBBGIPIE(PersistenceView MJEDEOCFGKA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool ENMADKLKMOC(KPIIJEHPKNN GLDBNLEBGAB, OPBPGNGHMAL CCMHBLOOHPJ, [Out] KIHBGLDLAMF PCONOKAOJKA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task OIMMMMBPNGK(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FBLHFKKDLDC();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable KAONANPFFCA();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void OEKIKMJOACB(KDDAPCIFEMM KDOIJJFLEJM, OPBPGNGHMAL CCMHBLOOHPJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> JLEMOFEFJFC(LNOBPBGOOIO IBCBIOCIMNL, CancellationToken PPKBAEMFIMG, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void LHCFLFMCOOP(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<KGPHKHBNANK> CKNAKKGDCFM(MBEDBABLIOL KAIGMLIOMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PFJIJEDBGEL> IBOKHNDKCNA(long ACIHEOIHPAO, bool PHFGJOHPJHP, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BCBONPLPCBB> LJBLGCEBFPK(long ACIHEOIHPAO, long GPDLAAEANOD, long PKBFBDMOBEE, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<BCBONPLPCBB> MMNIIMPEKAF(long ACIHEOIHPAO, long GPDLAAEANOD, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<EICFOOOCNLM> FECOLBELMNE(string OJBGLCHEJIB, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<EICFOOOCNLM> OLICBIHEGPP(string OJBGLCHEJIB, long ACIHEOIHPAO, long GPDLAAEANOD, string NAAIFMFBNFA, FLNHHEENHAO.HLCFKLFLLDB ABJNEIDNHBL, FLNHHEENHAO.HLCFKLFLLDB AKHAPOCCMLF, int CJKKEGNGHEM);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool BJJPKFKMHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool LFAEINLPBBG();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool ALJBLBDGDHE(IEnumerable<KIHBGLDLAMF> KBFKGDEFJDL);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NNGEMJELHEG(List<GameObject> NFGAKGHHDJH);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float JNIGCFNBFPK();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> NIIDJPHNBDN(string NBBJMMGJPJE, LoadSceneMode FBBBLFAAFFE, bool FDDFPCHCEPO, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void HCONCPPGLMD();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void KPPPEEDOGOF(bool NODMMGDBLME);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LEEFAJDICFP();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void MKNGLHNDFMN();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void MDONLKNMJNH(MEEJEPKLPKH NADNNHOPJPC);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task LKCNADHKOGJ(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task CDEMPEGFIIO(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task HEAOEOBFNIO(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task AHJLOCGKKGN(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable IOMAMCPEDNH();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "73")]
	BHOIANONIAI HNEFDPFBDIC();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task EFBMDGACPBI(CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BHOIANONIAI
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FGEOLPFOCPI(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IECCIDBBAHF(CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct KGEECBBCBNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> IMBJHELBLOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum MOCJCNACIDI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GJPJKPDEMOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string EFGFNCJCAJN;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ICMEFODLEGE
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	MEEJEPKLPKH PDMBNHKFHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	PFJIJEDBGEL LBHKNFDHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	BDNCLMIKGDE BOPHPHGAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool OEHDPFMGBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool BELDNNDHFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int KDDCKOIDFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HHHDGFPFAMG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> IAILMEBJDHC;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GACPBPECNHJ();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.DANMFCOEBCL> EKKADIHGHGK(long PGCBOFIMNFK, [Optional] CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<BEMGNJGGCED> FPJBGIJHMIA();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DNJJONEBJBD();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MEEJEPKLPKH, AHHJNEMBLEG) MJFDNIJIECF();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EMPEJCIGLJJ MBALLAIOGCG();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MOOKAGFPNHA(long PGCBOFIMNFK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FGOMPOJJPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOMHELAMLOA([Out] IEnumerable<int> AJOEDCOCIFD);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOOOPBCCLMG(EPIDMNHCALL GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPJKGLKFMMH(EPIDMNHCALL GBENACPKFNA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GPNPNMGHPLD
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DGILAMFKPLJ(MPFBHKIJKJP HOJIFPKEILN);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HOMNDJOLGIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKMGIPIHAKM(DFOOOBCFABC.CEGNKAPHDHH HEKPHJKPFKK);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCFIPFGJOGJ(DFOOOBCFABC.CEGNKAPHDHH HEKPHJKPFKK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PDIHFKFJPBI : HOMNDJOLGIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFBHKIJKJP PINBNKCLKMB(MLFBKPIOFCD APLIOENMKHP);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NNAPICGMCIC : HOMNDJOLGIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPFBHKIJKJP LDKLILCDKMM(MLFBKPIOFCD FNNNADILIEG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface ICJKGANAPPC
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NLDGPBPIIJN<PIHPEOKKDFC, LGLBGBDJHMM>> EPDHAAJBCBO(string NAAIFMFBNFA, long PGCBOFIMNFK, long? ACIHEOIHPAO, long? GPDLAAEANOD, GIKOGMFDNKG.PJEBEAMJHKL KOJNIOJEBAB, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface ADLAMOLFKJD<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NLDGPBPIIJN<PGFHMCKFNEA<TData>, LGLBGBDJHMM>> HIOPDKLGCBJ(TGetDataArg OKLJLMJMKDA, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class EJAOKBOCEAA : CJIDFPHHKMP, BEEFMGNOPPE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EOPMLLGLPPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EJAOKBOCEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public ECJJPIPOFMP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<MPFBHKIJKJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x705D1E0", Offset = "0x705BDE0", VA = "0x18705D1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x705D460", Offset = "0x705C060", VA = "0x18705D460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct EPPAHCOGAJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public EJAOKBOCEAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x705D4D0", Offset = "0x705C0D0", VA = "0x18705D4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x705D700", Offset = "0x705C300", VA = "0x18705D700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GCNAOFEJNPE : IEnumerable<IAKAONBBDGH>, IEnumerable, IEnumerator<IAKAONBBDGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IAKAONBBDGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EJAOKBOCEAA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private IAKAONBBDGH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB210", Offset = "0x8B9E10", VA = "0x1808BB210")]
		[DebuggerHidden]
		public GCNAOFEJNPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x705F180", Offset = "0x705DD80", VA = "0x18705F180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x705F5E0", Offset = "0x705E1E0", VA = "0x18705F5E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x705F530", Offset = "0x705E130", VA = "0x18705F530", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IAKAONBBDGH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x705F530", Offset = "0x705E130", VA = "0x18705F530", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource EOCAKAJHBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IMEOEBHKJNP MLGAMJFBMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool KLBJCIGNEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private OOLGBDJMLOM GIOFIHADOOJ;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public LNOBPBGOOIO JMLHLNDEFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x86C590", Offset = "0x86B190", VA = "0x18086C590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AODBHPFKBMI PDDMAMLAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x86B550", Offset = "0x86A150", VA = "0x18086B550", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x86B4E0", Offset = "0x86A0E0", VA = "0x18086B4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x86B4F0", Offset = "0x86A0F0", VA = "0x18086B4F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86B530", Offset = "0x86A130", VA = "0x18086B530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public BOEFEBEHKHL MGJFEDPKAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x86B540", Offset = "0x86A140", VA = "0x18086B540", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x86B510", Offset = "0x86A110", VA = "0x18086B510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PDIHFKFJPBI OADGIOLLMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x86B520", Offset = "0x86A120", VA = "0x18086B520", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86B500", Offset = "0x86A100", VA = "0x18086B500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public NNAPICGMCIC LHOGAIBBOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x86DF40", Offset = "0x86CB40", VA = "0x18086DF40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86DF30", Offset = "0x86CB30", VA = "0x18086DF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DNMCGKCDFPB JOHBPBJMBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x872470", Offset = "0x871070", VA = "0x180872470", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x872420", Offset = "0x871020", VA = "0x180872420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public OINFNBOPCLC GJBJPDHHGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870FD0", VA = "0x1808723D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8723A0", Offset = "0x870FA0", VA = "0x1808723A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public KFJMFMLAOBL FHLKOMNBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x872460", Offset = "0x871060", VA = "0x180872460", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x872360", Offset = "0x870F60", VA = "0x180872360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public GJNCAINFMDB NHBEAHNDAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9D34F0", Offset = "0x9D20F0", VA = "0x1809D34F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA063A0", Offset = "0xA04FA0", VA = "0x180A063A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FJJCCCDIGDF FIPEAGOLEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x872380", Offset = "0x870F80", VA = "0x180872380", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8724D0", Offset = "0x8710D0", VA = "0x1808724D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public BDKHOGEIDMK HENJGHGFIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A50", Offset = "0x9F8650", VA = "0x1809F9A50", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9D84C0", Offset = "0x9D70C0", VA = "0x1809D84C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public MEALNJKKLNK EJNMCMJIHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x86BD00", Offset = "0x86A900", VA = "0x18086BD00", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86BCB0", Offset = "0x86A8B0", VA = "0x18086BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BHPFLHPLOKA MMAFMEKJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB9E440", Offset = "0xB9D040", VA = "0x180B9E440", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xBA63C0", Offset = "0xBA4FC0", VA = "0x180BA63C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public EOKHJDOHENH IIKKMLLPIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x95A750", Offset = "0x959350", VA = "0x18095A750", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x950B70", Offset = "0x94F770", VA = "0x180950B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IAFFALHFFID IJEJCMMBLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x959F20", Offset = "0x958B20", VA = "0x180959F20", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x95B490", Offset = "0x95A090", VA = "0x18095B490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EJFPALBBJFC FJHGPHFHABF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8E3BD0", Offset = "0x8E27D0", VA = "0x1808E3BD0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xBA6400", Offset = "0xBA5000", VA = "0x180BA6400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public KIPCHPEMFOC GDHKBHJPLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DF0", Offset = "0x8D09F0", VA = "0x1808D1DF0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA35880", Offset = "0xA34480", VA = "0x180A35880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public DGLICIJBPIP HFFNNDBFBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x86BCF0", Offset = "0x86A8F0", VA = "0x18086BCF0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x86BC70", Offset = "0x86A870", VA = "0x18086BC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public CJOIIEBJJHD FONCILLDAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8CE440", Offset = "0x8CD040", VA = "0x1808CE440", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9D6800", Offset = "0x9D5400", VA = "0x1809D6800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public OALJJAGILGN HBKFBGPLNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5DFA0", VA = "0x180A5F3A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3B0", Offset = "0xA5DFB0", VA = "0x180A5F3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public GLIFLBJDJKL IFKNLOGCEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E10", Offset = "0x8D0A10", VA = "0x1808D1E10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xBA63E0", Offset = "0xBA4FE0", VA = "0x180BA63E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FLNJBKCKBJD BAEFONDGAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E20", Offset = "0x8D0A20", VA = "0x1808D1E20", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9D4E30", Offset = "0x9D3A30", VA = "0x1809D4E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public FGOMPOJJPAE KKAJGPIENIF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D70", Offset = "0x8D0970", VA = "0x1808D1D70", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xBA63A0", Offset = "0xBA4FA0", VA = "0x180BA63A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MBAHKNOPOHL PJDHEHCJAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D80", Offset = "0x8D0980", VA = "0x1808D1D80", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xBA65E0", Offset = "0xBA51E0", VA = "0x180BA65E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public AADKOFCNMIA EFBGDKJFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C50", Offset = "0x8D0850", VA = "0x1808D1C50", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xBA65C0", Offset = "0xBA51C0", VA = "0x180BA65C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public MFCLJJEJGJM KMPIKFBAAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C20", Offset = "0x8D0820", VA = "0x1808D1C20", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xBA6500", Offset = "0xBA5100", VA = "0x180BA6500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JFHNOOMNJEI HJJFDAFKGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B80", Offset = "0x8D0780", VA = "0x1808D1B80", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NFDNMKKJCKI NCAAGOKEDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA73060", Offset = "0xA71C60", VA = "0x180A73060", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public ACJCNKIMHHO LLKKFFLGPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E00", Offset = "0x8D0A00", VA = "0x1808D1E00", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DBNFAKLLPMO FBCNBPFBHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xB0DDB0", Offset = "0xB0C9B0", VA = "0x180B0DDB0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public AHHJNEMBLEG APMOPAPNPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB0DBD0", Offset = "0xB0C7D0", VA = "0x180B0DBD0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xBA6560", Offset = "0xBA5160", VA = "0x180BA6560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private bool MDIAFHHLDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x705BE30", Offset = "0x705AA30", VA = "0x18705BE30", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool EGFPBCKBNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x705C0F0", Offset = "0x705ACF0", VA = "0x18705C0F0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private CancellationToken NMNFBIBIELM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x705C230", Offset = "0x705AE30", VA = "0x18705C230", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private IMEOEBHKJNP ODIJBAMFFGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action CGLELHCODLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x705C1D0", Offset = "0x705ADD0", VA = "0x18705C1D0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x705BEF0", Offset = "0x705AAF0", VA = "0x18705BEF0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event KMCANHLACNM GBHDMICFEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x705C250", Offset = "0x705AE50", VA = "0x18705C250", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x705C560", Offset = "0x705B160", VA = "0x18705C560", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event KMCANHLACNM LMDOMAPCACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x705BE90", Offset = "0x705AA90", VA = "0x18705BE90", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x705C300", Offset = "0x705AF00", VA = "0x18705C300", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event KMCANHLACNM CFADPPLPAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x705C620", Offset = "0x705B220", VA = "0x18705C620", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x705C5C0", Offset = "0x705B1C0", VA = "0x18705C5C0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<PLCGGJDBLPO, bool> BPDBNGCJAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x705C170", Offset = "0x705AD70", VA = "0x18705C170", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x705BD50", Offset = "0x705A950", VA = "0x18705BD50", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xBA6560", Offset = "0xBA5160", VA = "0x180BA6560", Slot = "36")]
	public void PGGFLOJHJFG(AHHJNEMBLEG JMKBNEINFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x705C820", Offset = "0x705B420", VA = "0x18705C820")]
	[UnityEngine.Scripting.Preserve]
	internal EJAOKBOCEAA([POJODGKFIMO(null)] IMEOEBHKJNP MLGAMJFBMDB, [POJODGKFIMO(null)] LNOBPBGOOIO IBCBIOCIMNL, [POJODGKFIMO(null)] AODBHPFKBMI CADADMHCBFE, [POJODGKFIMO(null)] NOIFJHBLDNB JMKPKEHPNLL, [POJODGKFIMO(null)] BOEFEBEHKHL AOEKMJDMKKP, [POJODGKFIMO(null)] PDIHFKFJPBI KBDBGMICGNI, [POJODGKFIMO(null)] NNAPICGMCIC DIHBOGHFHFL, [POJODGKFIMO(null)] DNMCGKCDFPB DCEGKJJJGME, [POJODGKFIMO(null)] OINFNBOPCLC KGMNCABNNPA, [POJODGKFIMO(null)] KFJMFMLAOBL IDFEDAHHCFN, [POJODGKFIMO(null)] GJNCAINFMDB EFAGMEAKGKG, [POJODGKFIMO(null)] FJJCCCDIGDF DCFAFEBEKBA, [POJODGKFIMO(null)] BDKHOGEIDMK JPAFJOENBOJ, [POJODGKFIMO(null)] MEALNJKKLNK CICDDDEDOKH, [POJODGKFIMO(null)] BHPFLHPLOKA BFEAMDEGBOM, [POJODGKFIMO(null)] EOKHJDOHENH CDCCEKDAPPO, [POJODGKFIMO(null)] IAFFALHFFID KCMDCKDPIBN, [POJODGKFIMO(null)] EJFPALBBJFC HKEIDLGAKNK, [POJODGKFIMO(null)] KIPCHPEMFOC OMJJEBLHNBG, [POJODGKFIMO(null)] DGLICIJBPIP EHGFHALJNBF, [POJODGKFIMO(null)] OALJJAGILGN IIIJMOOBPMA, [POJODGKFIMO(null)] CJOIIEBJJHD GCEEPFOCGJD, [POJODGKFIMO(null)] GLIFLBJDJKL JCEKBAFBDPO, [POJODGKFIMO(null)] FLNJBKCKBJD FOLPEMGMFAM, [POJODGKFIMO(null)] FGOMPOJJPAE KOEKIENBDLC, [POJODGKFIMO(null)] AADKOFCNMIA JOKNJOHCHIH, [POJODGKFIMO(null)] MFCLJJEJGJM ABNGIIMBEMA, [POJODGKFIMO(null)] JFHNOOMNJEI NIFKEDHIMPP, [POJODGKFIMO(null)] NFDNMKKJCKI EDPHDNHONJL, [POJODGKFIMO(null)] ACJCNKIMHHO JGALMKNMLBM, [POJODGKFIMO(null)] DBNFAKLLPMO JELPLEDAFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x705C680", Offset = "0x705B280", VA = "0x18705C680")]
	private void NJFEGHENHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x705BF50", Offset = "0x705AB50", VA = "0x18705BF50", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x705C2B0", Offset = "0x705AEB0", VA = "0x18705C2B0", Slot = "49")]
	private void HFKIBOOPKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x705BCC0", Offset = "0x705A8C0", VA = "0x18705BCC0", Slot = "50")]
	private FPPLDNNKFDF BLEPAIHPACG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x705C730", Offset = "0x705B330", VA = "0x18705C730", Slot = "51")]
	private AELCJGIHAMM NMEALAHGDME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x705C450", Offset = "0x705B050", VA = "0x18705C450", Slot = "52")]
	[AsyncStateMachine(typeof(EOPMLLGLPPK))]
	private Task<MPFBHKIJKJP> LDGJKJONICJ(ECJJPIPOFMP KDFNCJHIKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x705C360", Offset = "0x705AF60", VA = "0x18705C360", Slot = "53")]
	[AsyncStateMachine(typeof(EPPAHCOGAJL))]
	private Task IHPENJMCDEM(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x705BDB0", Offset = "0x705A9B0", VA = "0x18705BDB0")]
	[IteratorStateMachine(typeof(GCNAOFEJNPE))]
	private IEnumerable<IAKAONBBDGH> CCOOBOGIOON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x705C7C0", Offset = "0x705B3C0", VA = "0x18705C7C0")]
	[CompilerGenerated]
	private void PKEMFJJOLIH(IAKAONBBDGH BFLHJMMHBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OOEFGHBODED : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xF06320", Offset = "0xF04F20", VA = "0x180F06320")]
	public OOEFGHBODED(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class AIHOAIPNNJA : LJOJLFILBHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GAGNNCDJPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AIHOAIPNNJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x705EDD0", Offset = "0x705D9D0", VA = "0x18705EDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x705F110", Offset = "0x705DD10", VA = "0x18705F110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool NBJMHJKDABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
	public AIHOAIPNNJA(CJIDFPHHKMP NLLMJKJPILF, NOIFJHBLDNB JMKPKEHPNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7058070", Offset = "0x7056C70", VA = "0x187058070", Slot = "4")]
	[AsyncStateMachine(typeof(GAGNNCDJPPF))]
	public Task<bool> DCHKOEAPLHK(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7058160", Offset = "0x7056D60", VA = "0x187058160")]
	[CompilerGenerated]
	private object FGEFMHIGFOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class PGEIKPKOGJC : LJOJLFILBHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct MDDAJGIMFLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public PGEIKPKOGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7067560", Offset = "0x7066160", VA = "0x187067560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7067C70", Offset = "0x7066870", VA = "0x187067C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7075310", Offset = "0x7073F10", VA = "0x187075310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool NBJMHJKDABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
	public PGEIKPKOGJC(CJIDFPHHKMP NLLMJKJPILF, NOIFJHBLDNB JMKPKEHPNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7075360", Offset = "0x7073F60", VA = "0x187075360", Slot = "4")]
	[AsyncStateMachine(typeof(MDDAJGIMFLH))]
	public Task<bool> DCHKOEAPLHK(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7075490", Offset = "0x7074090", VA = "0x187075490")]
	[CompilerGenerated]
	private object OGPIDELGMGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class HILDMEKEOKB : LJOJLFILBHK
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class AOKCNOGIPNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HILDMEKEOKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BEMGNJGGCED result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MEEJEPKLPKH newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public AOKCNOGIPNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x70582B0", Offset = "0x7056EB0", VA = "0x1870582B0")]
		internal object LIDFHEJNOMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7058240", Offset = "0x7056E40", VA = "0x187058240")]
		internal object KCGCKNJOKGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x70583A0", Offset = "0x7056FA0", VA = "0x1870583A0")]
		internal object PBABLLLNEII()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LPLMMDPBHGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public HILDMEKEOKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private AOKCNOGIPNG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<BEMGNJGGCED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7065FA0", Offset = "0x7064BA0", VA = "0x187065FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x70668C0", Offset = "0x70654C0", VA = "0x1870668C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7061870", Offset = "0x7060470", VA = "0x187061870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool NBJMHJKDABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
	public HILDMEKEOKB(CJIDFPHHKMP NLLMJKJPILF, NOIFJHBLDNB JMKPKEHPNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x70618C0", Offset = "0x70604C0", VA = "0x1870618C0", Slot = "4")]
	[AsyncStateMachine(typeof(LPLMMDPBHGF))]
	public Task<bool> DCHKOEAPLHK(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface LJOJLFILBHK
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool NBJMHJKDABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> DCHKOEAPLHK(CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct APOOKIIDNKM
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GGMAADIBHME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CJIDFPHHKMP manager;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GGMAADIBHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x705FA00", Offset = "0x705E600", VA = "0x18705FA00")]
		internal Task HNDKKHBCJKF(CancellationToken cancellationToken, int roomTotalVersion, CDDOIGKGONH localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct NLNFBOHCAEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public APOOKIIDNKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private ECJJPIPOFMP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<MOCJCNACIDI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<MPFBHKIJKJP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7069950", Offset = "0x7068550", VA = "0x187069950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7069EE0", Offset = "0x7068AE0", VA = "0x187069EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct BDKGLEHDPHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public APOOKIIDNKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7059A20", Offset = "0x7058620", VA = "0x187059A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7059D40", Offset = "0x7058940", VA = "0x187059D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken PPKBAEMFIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CJIDFPHHKMP DMMHPLIIKDJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private LNOBPBGOOIO JMLHLNDEFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7058950", Offset = "0x7057550", VA = "0x187058950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x70584F0", Offset = "0x70570F0", VA = "0x1870584F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7058540", Offset = "0x7057140", VA = "0x187058540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private KFJMFMLAOBL FHLKOMNBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x70587D0", Offset = "0x70573D0", VA = "0x1870587D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC240", Offset = "0x1FDAE40", VA = "0x181FDC240")]
	public APOOKIIDNKM(CancellationToken PPKBAEMFIMG, CJIDFPHHKMP DMMHPLIIKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7058440", Offset = "0x7057040", VA = "0x187058440")]
	public static OPGHOJOJHDC AIAHLDPFPOF(CJIDFPHHKMP DMMHPLIIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x70589A0", Offset = "0x70575A0", VA = "0x1870589A0")]
	[AsyncStateMachine(typeof(NLNFBOHCAEK))]
	public Task<bool> MGFNPLKOLEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x70585C0", Offset = "0x70571C0", VA = "0x1870585C0")]
	private bool DNFBBKIKDBD([Out] ECJJPIPOFMP KDFNCJHIKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7058AB0", Offset = "0x70576B0", VA = "0x187058AB0")]
	[AsyncStateMachine(typeof(BDKGLEHDPHC))]
	private Task PNMDBDBMBKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7058820", Offset = "0x7057420", VA = "0x187058820")]
	private Task<MOCJCNACIDI> GENNGDCPFPD(ECJJPIPOFMP HFFJNPLGMLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct BFGAONAEGFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly BHPFLHPLOKA BFEAMDEGBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid FEHGEPPCEAL;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private Task<(MPFBHKIJKJP, Task)> OGCKIIIPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7059EC0", Offset = "0x7058AC0", VA = "0x187059EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x423E140", Offset = "0x423CD40", VA = "0x18423E140")]
	public BFGAONAEGFJ(BHPFLHPLOKA BFEAMDEGBOM, Guid FEHGEPPCEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7059E70", Offset = "0x7058A70", VA = "0x187059E70")]
	public TaskAwaiter<(MPFBHKIJKJP, Task)> GBDFPBKCPFK()
	{
		return default(TaskAwaiter<(MPFBHKIJKJP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7059DA0", Offset = "0x70589A0", VA = "0x187059DA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct DAPAFMACEMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(MPFBHKIJKJP, Task)> PHEKHGNIOAH;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task<(MPFBHKIJKJP, Task)> OGCKIIIPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x705AEF0", Offset = "0x7059AF0", VA = "0x18705AEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x705AF30", Offset = "0x7059B30", VA = "0x18705AF30")]
	public DAPAFMACEMH(TimeSpan PLJAGHNHKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x705AE00", Offset = "0x7059A00", VA = "0x18705AE00")]
	public void IKNCPOCKMNF(Task JHHOGHJOILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x705AD70", Offset = "0x7059970", VA = "0x18705AD70")]
	public void EPBHCNFPHAA(MPFBHKIJKJP HOJIFPKEILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x705AEA0", Offset = "0x7059AA0", VA = "0x18705AEA0")]
	public void MIKEDEJCLPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x705ACE0", Offset = "0x70598E0", VA = "0x18705ACE0")]
	internal void AADOIHNBIKO(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class PDEFCFANLCD
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class IHLLDKJJJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public BCBONPLPCBB subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public IHLLDKJJJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x70619E0", Offset = "0x70605E0", VA = "0x1870619E0")]
		internal bool IGMFCMDMKCM(BDNCLMIKGDE s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7073C40", Offset = "0x7072840", VA = "0x187073C40")]
	public static LDKNGEJJMKB NCPDNLLGMJA(long FDODEMBCPLL, long GPDLAAEANOD, string OJBGLCHEJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7073E60", Offset = "0x7072A60", VA = "0x187073E60")]
	public static LDKNGEJJMKB NCPDNLLGMJA(long FDODEMBCPLL, long GPDLAAEANOD, OHEPJFMFHIA BJKFDJBGPCA, long PKBFBDMOBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7073CD0", Offset = "0x70728D0", VA = "0x187073CD0")]
	public static LDKNGEJJMKB NCPDNLLGMJA(KGPHKHBNANK OKDCCGCIIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7073F20", Offset = "0x7072B20", VA = "0x187073F20")]
	public static LDKNGEJJMKB NCPDNLLGMJA(PFJIJEDBGEL DMGOMABHAEJ, BCBONPLPCBB PBOJPPAIKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7073B50", Offset = "0x7072750", VA = "0x187073B50")]
	public static LDKNGEJJMKB BACECHABFIP(this LDKNGEJJMKB BHGBMMFNCAD, PFJIJEDBGEL NIFDOLPKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x70739C0", Offset = "0x70725C0", VA = "0x1870739C0")]
	public static LDKNGEJJMKB AMLECKKIJMD(this LDKNGEJJMKB BHGBMMFNCAD, BCBONPLPCBB GJDFFNCKHBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class GECCLCGFEEO : OINFNBOPCLC, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct GNONNJCPDKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GECCLCGFEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x705FF30", Offset = "0x705EB30", VA = "0x18705FF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x70605C0", Offset = "0x705F1C0", VA = "0x1870605C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly EPIDMNHCALL MGMCHEJAIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string KMIFJMIOJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task JKAAENCGHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MIJALPAFDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x705F630", Offset = "0x705E230", VA = "0x18705F630", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Task DFADAHODNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x705F8E0", Offset = "0x705E4E0", VA = "0x18705F8E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x869EF0", Offset = "0x868AF0", VA = "0x180869EF0", Slot = "7")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x705F780", Offset = "0x705E380", VA = "0x18705F780", Slot = "6")]
	public void JMODNKKMODM(Task LJPOAIPEHGB, string GPDCOBKBDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x705F660", Offset = "0x705E260", VA = "0x18705F660")]
	[AsyncStateMachine(typeof(GNONNJCPDKB))]
	private Task ELMOPOCPLPO(Task LHLFKHODEHB, string GPDCOBKBDCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x705F970", Offset = "0x705E570", VA = "0x18705F970")]
	public GECCLCGFEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class ODDBBJNHGDM : MBAHKNOPOHL, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool EIAEPJPJBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private CBPBLOCHIAA DBPONOFPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private AADKOFCNMIA JOKNJOHCHIH;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public CBPBLOCHIAA OBPMDHCICON
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7072C70", Offset = "0x7071870", VA = "0x187072C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7072F90", Offset = "0x7071B90", VA = "0x187072F90", Slot = "7")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7072D20", Offset = "0x7071920", VA = "0x187072D20", Slot = "5")]
	public void HDNOJJDHGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7072CE0", Offset = "0x70718E0", VA = "0x187072CE0", Slot = "6")]
	public void ONCBGNBJMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7072ED0", Offset = "0x7071AD0", VA = "0x187072ED0")]
	private Task HLFAILDEDKG(DGBKDNLFHEN LDAADCAOFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7072CE0", Offset = "0x70718E0", VA = "0x187072CE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ODDBBJNHGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HDDAHGBHHKN : AADKOFCNMIA
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class PHJCFOLNALK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly OHCDAFPPAJP GJDMIAOEPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string NCMHANGAILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T APDNGABBFBA;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T JCMGPEFMEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E10", Offset = "0x8B6A10", VA = "0x1808B7E10")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9C2470", Offset = "0x9C1070", VA = "0x1809C2470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x478EBE0", Offset = "0x478D7E0", VA = "0x18478EBE0")]
		public PHJCFOLNALK(OHCDAFPPAJP GJDMIAOEPFD, string NCMHANGAILD, T APDNGABBFBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x478E5D0", Offset = "0x478D1D0", VA = "0x18478E5D0")]
		private void OKGFAEHBBIO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly OHCDAFPPAJP GJDMIAOEPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly PHJCFOLNALK<TimeSpan> ODCLGIGPKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly PHJCFOLNALK<TimeSpan> MODMLGMAJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly PHJCFOLNALK<TimeSpan> MGNKAGKGCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly PHJCFOLNALK<TimeSpan> GCMANEAKFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly PHJCFOLNALK<bool> MOBEDIDBLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly PHJCFOLNALK<bool> NEPPCEKKHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly PHJCFOLNALK<bool> HMMHACAFONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly PHJCFOLNALK<int> EGDMANGJPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly PHJCFOLNALK<bool> MCNPMGCCBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly PHJCFOLNALK<bool> MBMDMOKKOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly PHJCFOLNALK<bool> BHEBPBJJOMF;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan BLBPKDNGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x70608C0", Offset = "0x705F4C0", VA = "0x1870608C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan GAOOAMEOHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7060900", Offset = "0x705F500", VA = "0x187060900", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan MFJBPAAAKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x70609C0", Offset = "0x705F5C0", VA = "0x1870609C0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan NDKLMFPLOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7060940", Offset = "0x705F540", VA = "0x187060940", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool MHGBMFNLNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7060980", Offset = "0x705F580", VA = "0x187060980", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool FMLJIEMBGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7060800", Offset = "0x705F400", VA = "0x187060800", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool BLOLDEFHAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7060780", Offset = "0x705F380", VA = "0x187060780", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int EBFMGGAHFIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7060880", Offset = "0x705F480", VA = "0x187060880", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool ADIMAHINGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7060840", Offset = "0x705F440", VA = "0x187060840", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool NBGOOELNGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x70607C0", Offset = "0x705F3C0", VA = "0x1870607C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool EGPEBKMBDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7060A00", Offset = "0x705F600", VA = "0x187060A00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7060A40", Offset = "0x705F640", VA = "0x187060A40")]
	[UnityEngine.Scripting.Preserve]
	public HDDAHGBHHKN([POJODGKFIMO(null)] OHCDAFPPAJP GJDMIAOEPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class MKDMDOGFMMJ : GJNCAINFMDB, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PLEBFBDGEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LEDBKEPMGME roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PLEBFBDGEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7075570", Offset = "0x7074170", VA = "0x187075570")]
		internal object AEGEMKAMDPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action EBNGAGJJOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7069110", Offset = "0x7067D10", VA = "0x187069110", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7068810", Offset = "0x7067410", VA = "0x187068810", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event KMCANHLACNM BPKMCLHOIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x70686D0", Offset = "0x70672D0", VA = "0x1870686D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7068AB0", Offset = "0x70676B0", VA = "0x187068AB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event KMCANHLACNM AGLADNEDLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7068F30", Offset = "0x7067B30", VA = "0x187068F30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7068FD0", Offset = "0x7067BD0", VA = "0x187068FD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KMCANHLACNM AKCIGMGLCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7069070", Offset = "0x7067C70", VA = "0x187069070", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7068770", Offset = "0x7067370", VA = "0x187068770", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<PLCGGJDBLPO, bool> GJPKPGNAGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7068E50", Offset = "0x7067A50", VA = "0x187068E50", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7068DA0", Offset = "0x70679A0", VA = "0x187068DA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "19")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x70688B0", Offset = "0x70674B0", VA = "0x1870688B0", Slot = "14")]
	public void FGHAFFOIJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7068F00", Offset = "0x7067B00", VA = "0x187068F00", Slot = "15")]
	public void LLFOAPKCNMB(LEDBKEPMGME LKKADIAOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x70686A0", Offset = "0x70672A0", VA = "0x1870686A0", Slot = "16")]
	public void ACCCHOKHLIP(LEDBKEPMGME LKKADIAOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7068D20", Offset = "0x7067920", VA = "0x187068D20", Slot = "17")]
	public void HMNAJODCAJC(LEDBKEPMGME LKKADIAOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7068D50", Offset = "0x7067950", VA = "0x187068D50", Slot = "18")]
	public void IHLKNEDJNJL(PLCGGJDBLPO CIANIJNKGHA, bool OBJBDHJNFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7068B50", Offset = "0x7067750", VA = "0x187068B50")]
	private void HEONFGBJNMF(KMCANHLACNM CEELIFFGBFO, LEDBKEPMGME LKKADIAOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public MKDMDOGFMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class OBINADNGKIG : FJJCCCDIGDF, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct NCKHHFBKJIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public OBINADNGKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x70691B0", Offset = "0x7067DB0", VA = "0x1870691B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7069840", Offset = "0x7068440", VA = "0x187069840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct OAGOGNNJPHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public OBINADNGKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private Task<bool> <fallbackTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x706BB70", Offset = "0x706A770", VA = "0x18706BB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x706C690", Offset = "0x706B290", VA = "0x18706C690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class FNOLFLCLDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FNOLFLCLDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x705ED60", Offset = "0x705D960", VA = "0x18705ED60")]
		internal object IMPLIIABHDJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct ADPGJKNLFOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public OBINADNGKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private FNOLFLCLDEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x70578B0", Offset = "0x70564B0", VA = "0x1870578B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7058000", Offset = "0x7056C00", VA = "0x187058000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PFOPFHMGGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PFOPFHMGGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x70752A0", Offset = "0x7073EA0", VA = "0x1870752A0")]
		internal object PCLOFLCEKFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private LJOJLFILBHK[] DBNEPHFIFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource FFLGPIGMANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource OAPJHLHINJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Task PCCOFFANLAF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool NLJIDBOIKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x706C6F0", Offset = "0x706B2F0", VA = "0x18706C6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x706D130", Offset = "0x706BD30", VA = "0x18706D130", Slot = "6")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x706C720", Offset = "0x706B320", VA = "0x18706C720", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x706D1B0", Offset = "0x706BDB0", VA = "0x18706D1B0", Slot = "8")]
	public void OCHLBECONCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x706CA20", Offset = "0x706B620", VA = "0x18706CA20", Slot = "5")]
	public void IFPGONGBLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x706C730", Offset = "0x706B330", VA = "0x18706C730", Slot = "4")]
	[AsyncStateMachine(typeof(NCKHHFBKJIK))]
	public Task FGJCCEABFKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x706CF40", Offset = "0x706BB40", VA = "0x18706CF40")]
	[AsyncStateMachine(typeof(OAGOGNNJPHL))]
	private Task LHGFFNNNKEF(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x706CC20", Offset = "0x706B820", VA = "0x18706CC20")]
	private void KOBLFBKJNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x706C800", Offset = "0x706B400", VA = "0x18706C800")]
	[AsyncStateMachine(typeof(ADPGJKNLFOO))]
	private Task<bool> GLLGPLGEIGB(int BAEBMIBABAE, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x706C940", Offset = "0x706B540", VA = "0x18706C940")]
	private void GNLKCFLPLFM(int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x706D050", Offset = "0x706BC50", VA = "0x18706D050")]
	private void LKAINAHHKHO(int BAEBMIBABAE, bool OBJBDHJNFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x706CAF0", Offset = "0x706B6F0", VA = "0x18706CAF0")]
	private void IPNBDFKIFJN(int BAEBMIBABAE, Exception GKFNJIBGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public OBINADNGKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class LENFBJEDGHG : BDKHOGEIDMK, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct MFJAIGMPHEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AHHJNEMBLEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7067CE0", Offset = "0x70668E0", VA = "0x187067CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7068640", Offset = "0x7067240", VA = "0x187068640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct PEHCLBOOMKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AHHJNEMBLEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private BILFBGGHINK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private ICAIGABDHPB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private LMPPFDJJNDM <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private GPIHDIPGECD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7074150", Offset = "0x7072D50", VA = "0x187074150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7074D10", Offset = "0x7073910", VA = "0x187074D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class NIFGEEFHHEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Matchmaking.EJIOIFMMCEB result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public MBPGMFLLLIC errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NIFGEEFHHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x70698A0", Offset = "0x70684A0", VA = "0x1870698A0")]
		internal object IEAMIFDLNIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class AINLGIEENNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Task<LDKNGEJJMKB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public AINLGIEENNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		internal Task<LDKNGEJJMKB> AJNGPKLIGEM(BILFBGGHINK<string>.OADHIEPGLKH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct OCHHKKAHNHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AHHJNEMBLEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public LMPPFDJJNDM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private AINLGIEENNK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private OPCJIBBMPKM <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private ICAIGABDHPB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private BILFBGGHINK<string>.OADHIEPGLKH <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private GIHGFNFLHKF <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Task<Matchmaking.DANMFCOEBCL> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private JCIOLCPALDC <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter<Matchmaking.DANMFCOEBCL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<LDKNGEJJMKB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x706D360", Offset = "0x706BF60", VA = "0x18706D360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7072C10", Offset = "0x7071810", VA = "0x187072C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct CJDNOKOCBBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private BILFBGGHINK<string>.OADHIEPGLKH <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x705A230", Offset = "0x7058E30", VA = "0x18705A230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x705AC80", Offset = "0x7059880", VA = "0x18705AC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct DKIDBNCGOID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private IMEOEBHKJNP <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x705B7F0", Offset = "0x705A3F0", VA = "0x18705B7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x705BC60", Offset = "0x705A860", VA = "0x18705BC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct EJMALNKNEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder<Matchmaking.DANMFCOEBCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter<Matchmaking.DANMFCOEBCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x705CC80", Offset = "0x705B880", VA = "0x18705CC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x705D170", Offset = "0x705BD70", VA = "0x18705D170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct FHHKNBABGLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Matchmaking.DANMFCOEBCL serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public LMPPFDJJNDM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<HMDHKNLMCGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x705D9E0", Offset = "0x705C5E0", VA = "0x18705D9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x705E0D0", Offset = "0x705CCD0", VA = "0x18705E0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class DHEHAILLKHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public DHEHAILLKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x705B0C0", Offset = "0x7059CC0", VA = "0x18705B0C0")]
		internal object AKPHNEJJFDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x705B1C0", Offset = "0x7059DC0", VA = "0x18705B1C0")]
		internal string HCFCPHHMNFP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct FIPBHFNFMHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private DHEHAILLKHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x705E130", Offset = "0x705CD30", VA = "0x18705E130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x705ED00", Offset = "0x705D900", VA = "0x18705ED00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct HFIMFBLGIBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public LMPPFDJJNDM joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public LDKNGEJJMKB initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public MEEJEPKLPKH targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public OPCJIBBMPKM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private BILFBGGHINK<string>.OADHIEPGLKH <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7060F00", Offset = "0x705FB00", VA = "0x187060F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7061810", Offset = "0x7060410", VA = "0x187061810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct NNHCLICOKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private BILFBGGHINK<string>.OADHIEPGLKH <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private ICAIGABDHPB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x706A460", Offset = "0x7069060", VA = "0x18706A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x706BA90", Offset = "0x706A690", VA = "0x18706BA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct OJAOKKAADBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CDDOIGKGONH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public LENFBJEDGHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<MPFBHKIJKJP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7073110", Offset = "0x7071D10", VA = "0x187073110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7073870", Offset = "0x7072470", VA = "0x187073870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class LKBNBBIDHPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LKBNBBIDHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x708D5D0", Offset = "0x708C1D0", VA = "0x18708D5D0")]
		internal object GKJBHAPKNDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class CFDALJGDBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CFDALJGDBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7079D30", Offset = "0x7078930", VA = "0x187079D30")]
		internal void HMCJBKMFGKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JLEBCKMJOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JLEBCKMJOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x708C190", Offset = "0x708AD90", VA = "0x18708C190")]
		internal object CGEEMPPBDCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class EOKPOCFJJNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EOKPOCFJJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x707E0B0", Offset = "0x707CCB0", VA = "0x18707E0B0")]
		internal string KIFKEPKJCIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly EEGEMFOKJOP HBGALHMIOCJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly EEGEMFOKJOP LLEOBDKNHKD;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly EEGEMFOKJOP HKFKGFAPAHO;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly string GCCNIJPJFBC;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly string DEHLNPAHIIF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly string LGPPDCNLDCO;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly Guid AHDJGNLFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private DNMCGKCDFPB DCEGKJJJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private AODBHPFKBMI CADADMHCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private FJJCCCDIGDF DCFAFEBEKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private OINFNBOPCLC KGMNCABNNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private GJNCAINFMDB EFAGMEAKGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private ACJCNKIMHHO JGALMKNMLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NFDNMKKJCKI EDPHDNHONJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IDisposable AKDFDDFBMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly EPIDMNHCALL BDLJAJAPDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private JCIOLCPALDC BGGGDPNHFAJ;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TaskStatus BBDLBKJDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D00", Offset = "0x8D0900", VA = "0x1808D1D00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xB723A0", Offset = "0xB70FA0", VA = "0x180B723A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x70623E0", Offset = "0x7060FE0", VA = "0x1870623E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7065100", Offset = "0x7063D00", VA = "0x187065100", Slot = "6")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7062930", Offset = "0x7061530", VA = "0x187062930", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x70620F0", Offset = "0x7060CF0", VA = "0x1870620F0", Slot = "5")]
	[AsyncStateMachine(typeof(MFJAIGMPHEH))]
	public Task AJBJJGDPGLL(MEEJEPKLPKH GFLPMJJNNHA, AHHJNEMBLEG LBIJBENADAC, CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7062230", Offset = "0x7060E30", VA = "0x187062230")]
	[AsyncStateMachine(typeof(PEHCLBOOMKA))]
	private Task BBLPCOBDOMK(MEEJEPKLPKH GFLPMJJNNHA, AHHJNEMBLEG LBIJBENADAC, CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x70639A0", Offset = "0x70625A0", VA = "0x1870639A0")]
	private static void HCNAFDOMOEF(ACJCNKIMHHO JGALMKNMLBM, MEEJEPKLPKH GFLPMJJNNHA, Exception GKFNJIBGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x70630E0", Offset = "0x7061CE0", VA = "0x1870630E0")]
	private static void FIFBBDAPPNN(GPIHDIPGECD DEFIIMLBKMH, Exception GKFNJIBGPDM, [Optional] List<int> POFCAELAGGP, int ADBPMLFMCBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7062620", Offset = "0x7061220", VA = "0x187062620")]
	[AsyncStateMachine(typeof(OCHHKKAHNHO))]
	private Task DMEABHDNGNC(BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, MEEJEPKLPKH GFLPMJJNNHA, AHHJNEMBLEG LBIJBENADAC, LMPPFDJJNDM KGNNHBBMOEB, CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7064BE0", Offset = "0x70637E0", VA = "0x187064BE0")]
	private void LGBBGOBPLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7064D30", Offset = "0x7063930", VA = "0x187064D30")]
	[AsyncStateMachine(typeof(CJDNOKOCBBG))]
	private Task LHFFBJFELAK(BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7062D20", Offset = "0x7061920", VA = "0x187062D20")]
	private void EOOFECNOFJL(MEEJEPKLPKH GFLPMJJNNHA, CancellationToken OADLPMIOAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7063D50", Offset = "0x7062950", VA = "0x187063D50")]
	private void HDBDEJMHAPO(MEEJEPKLPKH GFLPMJJNNHA, LMPPFDJJNDM KGNNHBBMOEB, OperationCanceledException NDLLJHHNEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7065400", Offset = "0x7064000", VA = "0x187065400")]
	private void PANLABOKCHM(MEEJEPKLPKH GFLPMJJNNHA, LMPPFDJJNDM KGNNHBBMOEB, Exception GKFNJIBGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7064880", Offset = "0x7063480", VA = "0x187064880")]
	private void KNALOOOIBDB(MEEJEPKLPKH GFLPMJJNNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7062380", Offset = "0x7060F80", VA = "0x187062380")]
	private static LEDBKEPMGME BOFMHMFBIAK(MEEJEPKLPKH GFLPMJJNNHA)
	{
		return default(LEDBKEPMGME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7064E60", Offset = "0x7063A60", VA = "0x187064E60")]
	[AsyncStateMachine(typeof(DKIDBNCGOID))]
	private Task LJCLFJCBMGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7062BC0", Offset = "0x70617C0", VA = "0x187062BC0")]
	[AsyncStateMachine(typeof(EJMALNKNEDP))]
	private Task<Matchmaking.DANMFCOEBCL> EKKADIHGHGK(MEEJEPKLPKH GFLPMJJNNHA, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x70656B0", Offset = "0x70642B0", VA = "0x1870656B0")]
	private static HMDHKNLMCGD PMIDOGGHCHC(Matchmaking.DANMFCOEBCL LHJJKAPKONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7064A90", Offset = "0x7063690", VA = "0x187064A90")]
	[AsyncStateMachine(typeof(FHHKNBABGLE))]
	private Task LEEPOMJIDMG(Matchmaking.DANMFCOEBCL LHJJKAPKONM, LMPPFDJJNDM KGNNHBBMOEB, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken BLBAEPMDGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7064FC0", Offset = "0x7063BC0", VA = "0x187064FC0")]
	[AsyncStateMachine(typeof(FIPBHFNFMHN))]
	private Task NGLNBDOAFIC(MEEJEPKLPKH GFLPMJJNNHA, CancellationTokenSource GONMGBMCFEJ, Task LOFDALJLNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7064710", Offset = "0x7063310", VA = "0x187064710")]
	[AsyncStateMachine(typeof(HFIMFBLGIBO))]
	private Task IPICLKMCHDK(LDKNGEJJMKB NOMIODMHGKP, OPCJIBBMPKM BIDLOCGENIB, MEEJEPKLPKH GKGJLAOHNCJ, LMPPFDJJNDM BNOFFEADHIA, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken KMIGLNEPFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7064280", Offset = "0x7062E80", VA = "0x187064280")]
	private LMPPFDJJNDM IFIONMAOJDE(LMPPFDJJNDM BNOFFEADHIA, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7062980", Offset = "0x7061580", VA = "0x187062980")]
	[AsyncStateMachine(typeof(NNHCLICOKIJ))]
	private Task EDMOGCCGLCK(BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7063F70", Offset = "0x7062B70", VA = "0x187063F70")]
	[AsyncStateMachine(typeof(OJAOKKAADBA))]
	private Task HEONNAEEPAI(CancellationToken PPKBAEMFIMG, int IOHDDPEAOIC, CDDOIGKGONH CJKDJFKICDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x70640A0", Offset = "0x7062CA0", VA = "0x1870640A0")]
	private static void HICEEOOGJHP(MEEJEPKLPKH GFLPMJJNNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7064470", Offset = "0x7063070", VA = "0x187064470")]
	private void IMMFELNDJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7063050", Offset = "0x7061C50", VA = "0x187063050")]
	private void FAIKPHLLHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7064F30", Offset = "0x7063B30", VA = "0x187064F30")]
	private void NGGGCONFHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7065620", Offset = "0x7064220", VA = "0x187065620")]
	private void PJAGMFKIFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7062530", Offset = "0x7061130", VA = "0x187062530")]
	private static void COEFFMJPBMB(MEEJEPKLPKH GFLPMJJNNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7062AB0", Offset = "0x70616B0", VA = "0x187062AB0")]
	private static CancellationTokenRegistration EEODGFIMDKD(MEEJEPKLPKH GFLPMJJNNHA, CancellationToken BLBAEPMDGMD)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7062430", Offset = "0x7061030", VA = "0x187062430")]
	private static void CDKFFBEBNGD(MEEJEPKLPKH GFLPMJJNNHA, Exception GKFNJIBGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7062780", Offset = "0x7061380", VA = "0x187062780")]
	private void DNPLBANEOOA(MEEJEPKLPKH GFLPMJJNNHA, Task LOFDALJLNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x70646B0", Offset = "0x70632B0", VA = "0x1870646B0")]
	private static void IOIJAALEDGI(Func<string> NPDAJLMKBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x70659E0", Offset = "0x70645E0", VA = "0x1870659E0")]
	public LENFBJEDGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7064220", Offset = "0x7062E20", VA = "0x187064220")]
	[CompilerGenerated]
	internal static (int, int?) ICNFFJDEHCG(MBPGMFLLLIC INPPILAHLCC)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class IKEPGNJOCKO : MEALNJKKLNK, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct ICCGLEALLAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public IKEPGNJOCKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CDDOIGKGONH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7087B50", Offset = "0x7086750", VA = "0x187087B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7087FC0", Offset = "0x7086BC0", VA = "0x187087FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class BBMIIGGFGJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public IKEPGNJOCKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public CDDOIGKGONH localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BBMIIGGFGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7079300", Offset = "0x7077F00", VA = "0x187079300")]
		internal List<Task> PGNPDGMEKOG(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct BGONDNBNDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public OPGHOJOJHDC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public CDDOIGKGONH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7079340", Offset = "0x7077F40", VA = "0x187079340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x70796D0", Offset = "0x70782D0", VA = "0x1870796D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct MBFBGDHPLFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public IKEPGNJOCKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x708E9A0", Offset = "0x708D5A0", VA = "0x18708E9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x708EC60", Offset = "0x708D860", VA = "0x18708EC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly HashSet<OPGHOJOJHDC> FJEGLCELIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private AODBHPFKBMI CADADMHCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private JIGCBJLDEBD ABHOBOIBEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private KPHPLOJKMAK IKANGFHACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private IDisposable AKDFDDFBMGA;

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7088DC0", Offset = "0x70879C0", VA = "0x187088DC0", Slot = "5")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7088BA0", Offset = "0x70877A0", VA = "0x187088BA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7088A70", Offset = "0x7087670", VA = "0x187088A70", Slot = "4")]
	public bool CBLIEEGKLHK(OPGHOJOJHDC MJNFPFCIEBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7088AD0", Offset = "0x70876D0", VA = "0x187088AD0")]
	private void DKLLHKNBEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7088850", Offset = "0x7087450", VA = "0x187088850")]
	private void AGJMOCMPJDO(FMPKCMJJJBG ABJNEIDNHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x70890C0", Offset = "0x7087CC0", VA = "0x1870890C0")]
	[AsyncStateMachine(typeof(ICCGLEALLAA))]
	private Task NPFMGEBDHLJ(int IOHDDPEAOIC, CDDOIGKGONH CJKDJFKICDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7088C20", Offset = "0x7087820", VA = "0x187088C20")]
	private Func<CancellationToken, List<Task>> EIFOCPMODLE(int IOHDDPEAOIC, CDDOIGKGONH CJKDJFKICDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7089260", Offset = "0x7087E60", VA = "0x187089260")]
	private List<Task> PDBNIBIDFEK(int IOHDDPEAOIC, CDDOIGKGONH CJKDJFKICDF, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7088730", Offset = "0x7087330", VA = "0x187088730")]
	[AsyncStateMachine(typeof(BGONDNBNDNL))]
	private Task AADJHPALMIC(OPGHOJOJHDC AAKBHKDBNEK, CancellationToken GBENACPKFNA, int IOHDDPEAOIC, CDDOIGKGONH CJKDJFKICDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7088CF0", Offset = "0x70878F0", VA = "0x187088CF0")]
	[AsyncStateMachine(typeof(MBFBGDHPLFN))]
	private Task JBLOBJOLBMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x70891B0", Offset = "0x7087DB0", VA = "0x1870891B0")]
	private void OCHLBECONCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7089740", Offset = "0x7088340", VA = "0x187089740")]
	public IKEPGNJOCKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class PGHKOMPFFAN : BHPFLHPLOKA, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class EDFCHLAFLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EDFCHLAFLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x707C630", Offset = "0x707B230", VA = "0x18707C630")]
		internal object FEPKHCHIILO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class ILCPGJNOHNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ILCPGJNOHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x70897D0", Offset = "0x70883D0", VA = "0x1870897D0")]
		internal object MLOCKEBBLAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class IKCEMFMHNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public IKCEMFMHNNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class ENFOIDHAGPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ENFOIDHAGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x707D730", Offset = "0x707C330", VA = "0x18707D730")]
		internal object LJNPPJKMPPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class OJGANAEPOBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public OJGANAEPOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7092070", Offset = "0x7090C70", VA = "0x187092070")]
		internal object NGOCPMCJJAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly Dictionary<Guid, DAPAFMACEMH> BFEAMDEGBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly TimeSpan GCNOFCBGHAK;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "9")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7092C60", Offset = "0x7091860", VA = "0x187092C60", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7093390", Offset = "0x7091F90", VA = "0x187093390", Slot = "4")]
	public BFGAONAEGFJ LKPJOLMECIF(Guid FEHGEPPCEAL)
	{
		return default(BFGAONAEGFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7092C70", Offset = "0x7091870", VA = "0x187092C70", Slot = "5")]
	public bool ECLBFOFCOFL(Guid FEHGEPPCEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7092E80", Offset = "0x7091A80", VA = "0x187092E80", Slot = "6")]
	public bool FGLMAGAKNKK(Guid FEHGEPPCEAL, Task JHHOGHJOILL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x70931B0", Offset = "0x7091DB0", VA = "0x1870931B0", Slot = "7")]
	public bool FNAEHFHLLAM(Guid FEHGEPPCEAL, MPFBHKIJKJP HOJIFPKEILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7092BF0", Offset = "0x70917F0", VA = "0x187092BF0", Slot = "8")]
	public Task<(MPFBHKIJKJP, Task)> DBCGNIKNEIP(Guid FEHGEPPCEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x70929C0", Offset = "0x70915C0", VA = "0x1870929C0")]
	private void CNCPIMGLIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x70935B0", Offset = "0x70921B0", VA = "0x1870935B0")]
	public PGHKOMPFFAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class FFJHPMOFCIG : EOKHJDOHENH, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class LEACMOBEJMM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly MEEJEPKLPKH NADNNHOPJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly CancellationTokenSource GJNGFDIEBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public readonly CancellationToken LBCCJNPCCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private bool NJMCIPOFHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool KFHJMPBIANF;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x708D520", Offset = "0x708C120", VA = "0x18708D520")]
		public LEACMOBEJMM(MEEJEPKLPKH NADNNHOPJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x708D3D0", Offset = "0x708BFD0", VA = "0x18708D3D0")]
		public void OCHLBECONCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x708D3A0", Offset = "0x708BFA0", VA = "0x18708D3A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class LDHDGKDLICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public DGBKDNLFHEN disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LDHDGKDLICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x708D310", Offset = "0x708BF10", VA = "0x18708D310")]
		internal object AKJDMOOPJMB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct NMDBFEANMJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public DGBKDNLFHEN disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public FFJHPMOFCIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7091540", Offset = "0x7090140", VA = "0x187091540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x70918F0", Offset = "0x70904F0", VA = "0x1870918F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class KJPBGDEAAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KJPBGDEAAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x708C380", Offset = "0x708AF80", VA = "0x18708C380")]
		internal object BIJFOKPKKHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct FOBKIDKLPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public FFJHPMOFCIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private ICAIGABDHPB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7080E90", Offset = "0x707FA90", VA = "0x187080E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class NDAPHPDBAPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public MEEJEPKLPKH newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NDAPHPDBAPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7090860", Offset = "0x708F460", VA = "0x187090860")]
		internal object BJCDEGMBBIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7090900", Offset = "0x708F500", VA = "0x187090900")]
		internal object GBFJELOEHIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7090940", Offset = "0x708F540", VA = "0x187090940")]
		internal object NBFLHCKBKNI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class HMNMHOEBEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public HMNMHOEBEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7087AB0", Offset = "0x70866B0", VA = "0x187087AB0")]
		internal void HCLIJFNHODJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct PJHIMMKJHHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public MEEJEPKLPKH newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public FFJHPMOFCIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public AHHJNEMBLEG customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private NDAPHPDBAPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7093670", Offset = "0x7092270", VA = "0x187093670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x70945F0", Offset = "0x70931F0", VA = "0x1870945F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly LLKEDAOFODN.JEJCGCEELPP IDCBBLPLCPL;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly NKBAFBNNNFO OBBCGAABAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private AODBHPFKBMI CADADMHCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private FJJCCCDIGDF DCFAFEBEKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private AADKOFCNMIA JOKNJOHCHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private BDKHOGEIDMK JPAFJOENBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private MEEJEPKLPKH FONOHHHPFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private LEACMOBEJMM PKCBNADBNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private bool JDCOAMDJAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private Task ENLOFFHOBIP;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x707F330", Offset = "0x707DF30", VA = "0x18707F330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool NKCCEMOKHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x932C70", Offset = "0x931870", VA = "0x180932C70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x707F4F0", Offset = "0x707E0F0", VA = "0x18707F4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x707FCD0", Offset = "0x707E8D0", VA = "0x18707FCD0", Slot = "4")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x707F380", Offset = "0x707DF80", VA = "0x18707F380", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x707FB90", Offset = "0x707E790", VA = "0x18707FB90")]
	[AsyncStateMachine(typeof(NMDBFEANMJE))]
	private Task LGLHAKEMONG(DGBKDNLFHEN HOPKELINOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x707F790", Offset = "0x707E390", VA = "0x18707F790")]
	private void HHHDGFPFAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x707FF70", Offset = "0x707EB70", VA = "0x18707FF70")]
	private void OGNKGJHPJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x707F080", Offset = "0x707DC80", VA = "0x18707F080")]
	private void ACDJMGMDHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x707F920", Offset = "0x707E520", VA = "0x18707F920")]
	private bool HJPJDBILECD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x707F9A0", Offset = "0x707E5A0", VA = "0x18707F9A0")]
	[AsyncStateMachine(typeof(FOBKIDKLPKH))]
	private void IAILMEBJDHC(int OAINFFFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x707F500", Offset = "0x707E100", VA = "0x18707F500")]
	private void FBGFFMLJKKI([Out] IDisposable IBECBFPCCHH, [Out] IDisposable LLOENPPCCGH, [Out] IDisposable DELHIJNGEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x707FA70", Offset = "0x707E670", VA = "0x18707FA70")]
	private bool KDMAKIGPMKE(MEEJEPKLPKH NADNNHOPJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x707FC80", Offset = "0x707E880", VA = "0x18707FC80")]
	private void MOGAPEJOGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x707F200", Offset = "0x707DE00", VA = "0x18707F200")]
	[AsyncStateMachine(typeof(PJHIMMKJHHH))]
	private Task BBLPCOBDOMK(MEEJEPKLPKH NADNNHOPJPC, AHHJNEMBLEG LBIJBENADAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x70804D0", Offset = "0x707F0D0", VA = "0x1870804D0")]
	public FFJHPMOFCIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class ALDJMOJLOOB : IAFFALHFFID, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct JDANAMCCEEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public AsyncTaskMethodBuilder<BKDLNBFPHDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public ALDJMOJLOOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<BKDLNBFPHDL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7089FE0", Offset = "0x7088BE0", VA = "0x187089FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x708A270", Offset = "0x7088E70", VA = "0x18708A270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class BLFOEDFBPDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public LJGJBLECALO message;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BLFOEDFBPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x70798D0", Offset = "0x70784D0", VA = "0x1870798D0")]
		internal object BAJNNGDHPCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class DHLCBPNEKDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public LJGJBLECALO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public DHLCBPNEKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x707AF00", Offset = "0x7079B00", VA = "0x18707AF00")]
		internal object DLFMFKGJEBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class EIBEDEIAGCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EIBEDEIAGCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x707CE40", Offset = "0x707BA40", VA = "0x18707CE40")]
		internal object HFGBACNOFEH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct ENKAAFLNEFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public ALDJMOJLOOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<HFKGHGOGEPA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x707D790", Offset = "0x707C390", VA = "0x18707D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x707E050", Offset = "0x707CC50", VA = "0x18707E050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class BBCDIFGIKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public LJGJBLECALO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BBCDIFGIKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x70792A0", Offset = "0x7077EA0", VA = "0x1870792A0")]
		internal object IAHMPBMJFMA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct NJBPNLDGLNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public LJGJBLECALO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public ALDJMOJLOOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private LMPPFDJJNDM <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7090980", Offset = "0x708F580", VA = "0x187090980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x70914E0", Offset = "0x70900E0", VA = "0x1870914E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct MJKAHEBJAAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public AsyncTaskMethodBuilder<HFKGHGOGEPA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public ALDJMOJLOOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private DKNNIJDIAEF.FFMIIHENOFL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private LMPPFDJJNDM <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x708F5C0", Offset = "0x708E1C0", VA = "0x18708F5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x708FAE0", Offset = "0x708E6E0", VA = "0x18708FAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class BABNOBFLJGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public HFKGHGOGEPA operation;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BABNOBFLJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7079220", Offset = "0x7077E20", VA = "0x187079220")]
		internal object DEOHPNBMIEF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct APEOCFBNIGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public HFKGHGOGEPA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public ALDJMOJLOOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private BILFBGGHINK<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x70785D0", Offset = "0x70771D0", VA = "0x1870785D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7078C00", Offset = "0x7077800", VA = "0x187078C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class JMCGABFJENM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JMCGABFJENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x708C210", Offset = "0x708AE10", VA = "0x18708C210")]
		internal object KLMHEFGIBEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class OPILPAIOMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public OPILPAIOMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x70925D0", Offset = "0x70911D0", VA = "0x1870925D0")]
		internal object EOLLIHFEFJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private OINFNBOPCLC KGMNCABNNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private EJFPALBBJFC HKEIDLGAKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private CJOIIEBJJHD GCEEPFOCGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private TaskCompletionSource<BKDLNBFPHDL> BENGGCFMCBJ;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7077660", Offset = "0x7076260", VA = "0x187077660", Slot = "7")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7077750", Offset = "0x7076350", VA = "0x187077750", Slot = "6")]
	[AsyncStateMachine(typeof(JDANAMCCEEI))]
	public Task<BKDLNBFPHDL> ODLDCHKGNIL(CancellationToken GCLNJHMJEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7076E20", Offset = "0x7075A20", VA = "0x187076E20", Slot = "4")]
	public void GMMOCLCAKAI(LJGJBLECALO NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7077970", Offset = "0x7076570", VA = "0x187077970", Slot = "5")]
	public void POLIOBLAKGF(LJGJBLECALO FKCIBFHHGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7077860", Offset = "0x7076460", VA = "0x187077860")]
	[AsyncStateMachine(typeof(ENKAAFLNEFN))]
	private Task PHBMDOKEJLF(LJGJBLECALO KAIGMLIOMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7077CD0", Offset = "0x70768D0", VA = "0x187077CD0")]
	[AsyncStateMachine(typeof(NJBPNLDGLNC))]
	private Task PPFKLCPAPFD(LJGJBLECALO DJHFJEPEKGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7076A30", Offset = "0x7075630", VA = "0x187076A30")]
	[AsyncStateMachine(typeof(MJKAHEBJAAN))]
	private Task<HFKGHGOGEPA> BJPLCCDHCBJ(LJGJBLECALO KAIGMLIOMBJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7076B80", Offset = "0x7075780", VA = "0x187076B80")]
	private LMPPFDJJNDM FLAJFLJENHE(LJGJBLECALO COCEJHGOBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7077540", Offset = "0x7076140", VA = "0x187077540")]
	[AsyncStateMachine(typeof(APEOCFBNIGA))]
	private Task LAEPAHGLJLL(HFKGHGOGEPA NBPBNEMNBCH, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7076C10", Offset = "0x7075810", VA = "0x187076C10")]
	private HFKGHGOGEPA GBDOBMMFADH(LJGJBLECALO KAIGMLIOMBJ, LMPPFDJJNDM HCAMFOCLHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x31FED00", Offset = "0x31FD900", VA = "0x1831FED00")]
	private T OFGMELJMAFA<T>(T IIPLJLPCLBC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x70771B0", Offset = "0x7075DB0", VA = "0x1870771B0")]
	private HFKGHGOGEPA HPCCGAIFHNN(LJGJBLECALO KAIGMLIOMBJ, LMPPFDJJNDM HCAMFOCLHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ALDJMOJLOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class HHLEMKLAMCM : EJFPALBBJFC, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class MLKOPPKBDGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public MLKOPPKBDGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x708FB50", Offset = "0x708E750", VA = "0x18708FB50")]
		internal object DPPAGONANOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JGEDKAEJOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JGEDKAEJOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x708A960", Offset = "0x7089560", VA = "0x18708A960")]
		internal object DAAFCEBJBLG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private GLIFLBJDJKL JCEKBAFBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private IAFFALHFFID KCMDCKDPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private BHPFLHPLOKA BFEAMDEGBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private FGOMPOJJPAE KOEKIENBDLC;

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7086D70", Offset = "0x7085970", VA = "0x187086D70", Slot = "6")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7085B10", Offset = "0x7084710", VA = "0x187085B10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7085BC0", Offset = "0x70847C0", VA = "0x187085BC0", Slot = "4")]
	public BFGAONAEGFJ EAHKCKJDENI(LJGJBLECALO FIHOALOLKNP)
	{
		return default(BFGAONAEGFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7085670", Offset = "0x7084270", VA = "0x187085670", Slot = "5")]
	public void BJLLIDGPJAE(Guid FEHGEPPCEAL, Task JHHOGHJOILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7087370", Offset = "0x7085F70", VA = "0x187087370")]
	private void OJJEMLPILJD(byte INJNDNCLLIE, int AHCALNILMPH, object MEPPHMANCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7085FF0", Offset = "0x7084BF0", VA = "0x187085FF0")]
	private void GHPGAPMNKLJ(PEBINCEGBKG JBAJGONDFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7086830", Offset = "0x7085430", VA = "0x187086830")]
	private void JOGMBDBALMC(PEBINCEGBKG JBAJGONDFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7086B30", Offset = "0x7085730", VA = "0x187086B30")]
	private void KOBIDDIINOJ(PEBINCEGBKG JBAJGONDFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7085430", Offset = "0x7084030", VA = "0x187085430")]
	private MPFBHKIJKJP APJIGNOAICL(LJGJBLECALO COCEJHGOBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7087160", Offset = "0x7085D60", VA = "0x187087160")]
	private void ODKGHCFIFIH(LJGJBLECALO DJHFJEPEKGI, MPFBHKIJKJP HOJIFPKEILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7086580", Offset = "0x7085180", VA = "0x187086580")]
	private bool JCGELIBPCHE(LJGJBLECALO DJHFJEPEKGI, MPFBHKIJKJP HOJIFPKEILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7086EE0", Offset = "0x7085AE0", VA = "0x187086EE0")]
	private bool NNLDPGDKPII(LJGJBLECALO CEKNPJPIOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7085880", Offset = "0x7084480", VA = "0x187085880")]
	private bool DIDBICEFPMK(byte INJNDNCLLIE, ExitGames.Client.Photon.Hashtable JBAJGONDFIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public HHLEMKLAMCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class OMMCFNJOFBM : KIPCHPEMFOC, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class BLELPKEKGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public BKDLNBFPHDL operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public OMMCFNJOFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public LJGJBLECALO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BLELPKEKGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7079730", Offset = "0x7078330", VA = "0x187079730")]
		internal object AKMJKHHEJLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x70797A0", Offset = "0x70783A0", VA = "0x1870797A0")]
		internal object HADBLECOGEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct HCKLHKNKOBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public OMMCFNJOFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public LJGJBLECALO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<MPFBHKIJKJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x70833A0", Offset = "0x7081FA0", VA = "0x1870833A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7083A30", Offset = "0x7082630", VA = "0x187083A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class MHHMDBLOKJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public BKDLNBFPHDL operationType;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public MHHMDBLOKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x708F550", Offset = "0x708E150", VA = "0x18708F550")]
		internal object IIIDPAIALOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class HGIPLCGGJDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public HGIPLCGGJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x70853C0", Offset = "0x7083FC0", VA = "0x1870853C0")]
		internal object PJDIALGGPDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7085350", Offset = "0x7083F50", VA = "0x187085350")]
		internal object IHILPFODECM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x70852E0", Offset = "0x7083EE0", VA = "0x1870852E0")]
		internal object BJAPEBALEPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct LKIILMCLCPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public OMMCFNJOFBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private HGIPLCGGJDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private BFGAONAEGFJ <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private MPFBHKIJKJP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<(MPFBHKIJKJP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x708D7A0", Offset = "0x708C3A0", VA = "0x18708D7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x708E050", Offset = "0x708CC50", VA = "0x18708E050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private GLIFLBJDJKL JCEKBAFBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private EJFPALBBJFC HKEIDLGAKNK;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7092520", Offset = "0x7091120", VA = "0x187092520", Slot = "5")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x70920D0", Offset = "0x7090CD0", VA = "0x1870920D0", Slot = "4")]
	[AsyncStateMachine(typeof(HCKLHKNKOBF))]
	private Task<MPFBHKIJKJP> AEDBNEIHEHF(LJGJBLECALO COCEJHGOBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7092330", Offset = "0x7090F30", VA = "0x187092330")]
	private bool LMJHBAACMLF(BKDLNBFPHDL CIANIJNKGHA, [Out] MPFBHKIJKJP KKIOBLFFGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x70921F0", Offset = "0x7090DF0", VA = "0x1870921F0")]
	[AsyncStateMachine(typeof(LKIILMCLCPC))]
	private Task<MPFBHKIJKJP> JJHAPLEMOGK(LJGJBLECALO KAIGMLIOMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public OMMCFNJOFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class ADJIAKKOCMJ : DGLICIJBPIP, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct OIIHGOCPFCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder<LDKNGEJJMKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public ADJIAKKOCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<PFJIJEDBGEL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<LDKNGEJJMKB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x70919D0", Offset = "0x70905D0", VA = "0x1870919D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7091FA0", Offset = "0x7090BA0", VA = "0x187091FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MONNIIHBAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public MONNIIHBAMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x70907B0", Offset = "0x708F3B0", VA = "0x1870907B0")]
		internal object HMCHLJMKKBA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct FPPHODCBOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<PFJIJEDBGEL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public ADJIAKKOCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private MONNIIHBAMC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private TaskAwaiter<PFJIJEDBGEL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7082070", Offset = "0x7080C70", VA = "0x187082070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7082660", Offset = "0x7081260", VA = "0x187082660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct FBHPNLLOACM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public AsyncTaskMethodBuilder<LDKNGEJJMKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public ADJIAKKOCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public PFJIJEDBGEL roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<(OHEPJFMFHIA superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x707E1B0", Offset = "0x707CDB0", VA = "0x18707E1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x707E610", Offset = "0x707D210", VA = "0x18707E610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class ECGMPBHPBOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ECGMPBHPBOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9499C0", Offset = "0x9485C0", VA = "0x1809499C0")]
		internal bool KIGDLFKFBCI(BDNCLMIKGDE sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct IIACPMKHPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public AsyncTaskMethodBuilder<(OHEPJFMFHIA superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public PFJIJEDBGEL roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public ADJIAKKOCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public MEEJEPKLPKH targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<(OHEPJFMFHIA superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7088020", Offset = "0x7086C20", VA = "0x187088020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x70886C0", Offset = "0x70872C0", VA = "0x1870886C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class KFGDFOELHKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KFGDFOELHKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x708C2D0", Offset = "0x708AED0", VA = "0x18708C2D0")]
		internal object PLLHFEHBCKO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct LLNJJHADLGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<(OHEPJFMFHIA superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public BDNCLMIKGDE subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public ADJIAKKOCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public MEEJEPKLPKH dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private KFGDFOELHKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<BCBONPLPCBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x708E0C0", Offset = "0x708CCC0", VA = "0x18708E0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x708E7F0", Offset = "0x708D3F0", VA = "0x18708E7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static readonly (OHEPJFMFHIA superRoomData, long subRoomDataSaveId) FEDECCIDACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private DBNFAKLLPMO JELPLEDAFHF;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x70768D0", Offset = "0x70754D0", VA = "0x1870768D0", Slot = "5")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7076330", Offset = "0x7074F30", VA = "0x187076330", Slot = "4")]
	[AsyncStateMachine(typeof(OIIHGOCPFCE))]
	public Task<LDKNGEJJMKB> DICCGGDODNO(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, MEEJEPKLPKH GFLPMJJNNHA, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7076490", Offset = "0x7075090", VA = "0x187076490")]
	[AsyncStateMachine(typeof(FPPHODCBOMP))]
	private Task<PFJIJEDBGEL> EHDGGNEJDJE(MEEJEPKLPKH GFLPMJJNNHA, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x70765F0", Offset = "0x70751F0", VA = "0x1870765F0")]
	[AsyncStateMachine(typeof(FBHPNLLOACM))]
	private Task<LDKNGEJJMKB> HHJMHAAKLCC(MEEJEPKLPKH GFLPMJJNNHA, PFJIJEDBGEL DBGEDMHOIDK, long EPCPKKDEADD, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x70761C0", Offset = "0x7074DC0", VA = "0x1870761C0")]
	[AsyncStateMachine(typeof(IIACPMKHPIM))]
	private Task<(OHEPJFMFHIA, long)> AJDKGMHOBNP(MEEJEPKLPKH GFLPMJJNNHA, PFJIJEDBGEL DBGEDMHOIDK, long EPCPKKDEADD, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7076760", Offset = "0x7075360", VA = "0x187076760")]
	[AsyncStateMachine(typeof(LLNJJHADLGM))]
	private Task<(OHEPJFMFHIA, long)> LABGDJCANPI(MEEJEPKLPKH PALHIIFDLJO, BDNCLMIKGDE EBJIGCAOHEI, long EPCPKKDEADD, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ADJIAKKOCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[UnityEngine.Scripting.Preserve]
internal sealed class DOGLINCJABE : CJOIIEBJJHD, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class OIJPKOAACOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public OIJPKOAACOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7092010", Offset = "0x7090C10", VA = "0x187092010")]
		internal object GLJFBEKEGKJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct JDHPGFDMJAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public DOGLINCJABE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public LMPPFDJJNDM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x708A2E0", Offset = "0x7088EE0", VA = "0x18708A2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x708A8F0", Offset = "0x70894F0", VA = "0x18708A8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct HMJPDCNELNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public DOGLINCJABE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public LMPPFDJJNDM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<PBPFEPDGLPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7087440", Offset = "0x7086040", VA = "0x187087440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7087A40", Offset = "0x7086640", VA = "0x187087A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class PJHLJCOJIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PJHLJCOJIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7094650", Offset = "0x7093250", VA = "0x187094650")]
		internal object KBDFGPGHCHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct LBODBHLMFBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public LJGJBLECALO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public DOGLINCJABE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public LMPPFDJJNDM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private OKKNFPMHCCL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private GGEKANKFBGE <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<PBPFEPDGLPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x708C6B0", Offset = "0x708B2B0", VA = "0x18708C6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x708D2A0", Offset = "0x708BEA0", VA = "0x18708D2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private MBAHKNOPOHL JOGBCLEIPJO;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private CBPBLOCHIAA OBPMDHCICON
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x707BDC0", Offset = "0x707A9C0", VA = "0x18707BDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x707C270", Offset = "0x707AE70", VA = "0x18707C270", Slot = "8")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x707C300", Offset = "0x707AF00", VA = "0x18707C300", Slot = "4")]
	[AsyncStateMachine(typeof(JDHPGFDMJAD))]
	public Task<LJGJBLECALO> POIDAIKKPLP(LJGJBLECALO KAIGMLIOMBJ, LMPPFDJJNDM HCAMFOCLHJP, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x707BFE0", Offset = "0x707ABE0", VA = "0x18707BFE0", Slot = "5")]
	[AsyncStateMachine(typeof(HMJPDCNELNH))]
	public Task<LJGJBLECALO> HLMHKPPEDFC(CancellationToken PPKBAEMFIMG, LMPPFDJJNDM HCAMFOCLHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x707C460", Offset = "0x707B060", VA = "0x18707C460", Slot = "6")]
	public MNBHHFEPHJK POIJEJBAHAA(HFKGHGOGEPA CEOBDGJPBEK, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x707C130", Offset = "0x707AD30", VA = "0x18707C130", Slot = "7")]
	public MNBHHFEPHJK LAGBCJMOAIE(HFKGHGOGEPA CEOBDGJPBEK, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x707BE80", Offset = "0x707AA80", VA = "0x18707BE80")]
	[AsyncStateMachine(typeof(LBODBHLMFBC))]
	private Task<LJGJBLECALO> GGJEEFNLMLI(LJGJBLECALO KAIGMLIOMBJ, LMPPFDJJNDM HCAMFOCLHJP, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2C44340", Offset = "0x2C42F40", VA = "0x182C44340")]
	private static byte[] ICHMOGMDMMB(LJGJBLECALO NKAJDDICLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public DOGLINCJABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class EDOGFHHAPHF : GLIFLBJDJKL, IAKAONBBDGH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private PDIHFKFJPBI KBDBGMICGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private OINFNBOPCLC KGMNCABNNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private OALJJAGILGN IIIJMOOBPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private BDKHOGEIDMK JPAFJOENBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private MEALNJKKLNK CICDDDEDOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private AADKOFCNMIA JOKNJOHCHIH;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x707C690", Offset = "0x707B290", VA = "0x18707C690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private static MPFBHKIJKJP EAKLNBLDIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x707C850", Offset = "0x707B450", VA = "0x18707C850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x707CC10", Offset = "0x707B810", VA = "0x18707CC10", Slot = "6")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x707C6E0", Offset = "0x707B2E0", VA = "0x18707C6E0", Slot = "4")]
	public MPFBHKIJKJP COPGMDLACPF(MLFBKPIOFCD OGPHJGPEMCM, BKDLNBFPHDL PNANBJBKPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x707C8B0", Offset = "0x707B4B0", VA = "0x18707C8B0", Slot = "5")]
	public MPFBHKIJKJP KLCCHAJPHCJ(MLFBKPIOFCD APLIOENMKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x707CBB0", Offset = "0x707B7B0", VA = "0x18707CBB0")]
	private static MPFBHKIJKJP LFFOOJGFFDL(INOFHHNFADO GLMDIHNLEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public EDOGFHHAPHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class CBNGPGMBKPA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7079990", Offset = "0x7078590", VA = "0x187079990")]
	public CBNGPGMBKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x650DC70", Offset = "0x650C870", VA = "0x18650DC70")]
	public CBNGPGMBKPA(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class JJABPGNICPL : KFJMFMLAOBL, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MMMLPENIDMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public ECJJPIPOFMP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private BILFBGGHINK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private BILFBGGHINK<string>.OADHIEPGLKH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private NLCFGGCDBHH <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter<MPFBHKIJKJP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x708FBC0", Offset = "0x708E7C0", VA = "0x18708FBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7090740", Offset = "0x708F340", VA = "0x187090740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct JCDDJLKJEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7089830", Offset = "0x7088430", VA = "0x187089830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7089F80", Offset = "0x7088B80", VA = "0x187089F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CMIAAJJKANM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7079DD0", Offset = "0x70789D0", VA = "0x187079DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x707A2E0", Offset = "0x7078EE0", VA = "0x18707A2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MFDGBAKFDLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x708EDA0", Offset = "0x708D9A0", VA = "0x18708EDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x708F4F0", Offset = "0x708E0F0", VA = "0x18708F4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct PMLBMIEGHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x70946B0", Offset = "0x70932B0", VA = "0x1870946B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7094850", Offset = "0x7093450", VA = "0x187094850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct CPBEKKFAIHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x707A340", Offset = "0x7078F40", VA = "0x18707A340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x707AA60", Offset = "0x7079660", VA = "0x18707AA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct GACFANANJDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x70826D0", Offset = "0x70812D0", VA = "0x1870826D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7082B40", Offset = "0x7081740", VA = "0x187082B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct HBGMFNMGKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public JJABPGNICPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public JGCKGNBCBHH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private BILFBGGHINK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7082BA0", Offset = "0x70817A0", VA = "0x187082BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7083100", Offset = "0x7081D00", VA = "0x187083100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private LNOBPBGOOIO IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private CJOIIEBJJHD GCEEPFOCGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private OINFNBOPCLC KGMNCABNNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private MEALNJKKLNK CICDDDEDOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private CancellationTokenSource NMEEHCJKMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private Task BPMKDMMKFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private TaskCompletionSource<int> MOGGLLBLNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private int LCBPNNLFDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private int HIANBCFFOKG;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x708BDF0", Offset = "0x708A9F0", VA = "0x18708BDF0", Slot = "6")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xA932A0", Offset = "0xA91EA0", VA = "0x180A932A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x708B420", Offset = "0x708A020", VA = "0x18708B420")]
	private void FDJKNAOHJGK(float MCDOENHDOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x708B600", Offset = "0x708A200", VA = "0x18708B600", Slot = "4")]
	[AsyncStateMachine(typeof(MMMLPENIDMA))]
	public Task<MPFBHKIJKJP> LCBJAGHFHFO(ECJJPIPOFMP KDFNCJHIKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x708B990", Offset = "0x708A590", VA = "0x18708B990", Slot = "5")]
	[AsyncStateMachine(typeof(JCDDJLKJEME))]
	public Task LKFEEMPKKLL([Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0xA932A0", Offset = "0xA91EA0", VA = "0x180A932A0")]
	public void EIEFOPFGOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x708BA80", Offset = "0x708A680", VA = "0x18708BA80")]
	private NLCFGGCDBHH MKEGJIMEBJG(ECJJPIPOFMP KDFNCJHIKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x708B330", Offset = "0x7089F30", VA = "0x18708B330")]
	[AsyncStateMachine(typeof(CMIAAJJKANM))]
	private Task CMDONKHIIAK(CancellationToken OADLPMIOAJN, int IOHDDPEAOIC, CDDOIGKGONH CJKDJFKICDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x708BFA0", Offset = "0x708ABA0", VA = "0x18708BFA0")]
	[AsyncStateMachine(typeof(MFDGBAKFDLP))]
	private Task NMNAEEAGOAG(CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x708C0A0", Offset = "0x708ACA0", VA = "0x18708C0A0")]
	[AsyncStateMachine(typeof(PMLBMIEGHKJ))]
	private Task PIKOKDGIDHI([Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x708BD00", Offset = "0x708A900", VA = "0x18708BD00")]
	[AsyncStateMachine(typeof(CPBEKKFAIHM))]
	private Task NHMBFPHONEI(CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x708B500", Offset = "0x708A100", VA = "0x18708B500")]
	[AsyncStateMachine(typeof(GACFANANJDP))]
	private Task LBKBADHILAH(CancellationToken LFNIGCGFNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x708B1A0", Offset = "0x7089DA0", VA = "0x18708B1A0")]
	private Task AIPHOJNCFOK(JGCKGNBCBHH GOPLAELIJFH, CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x708BBF0", Offset = "0x708A7F0", VA = "0x18708BBF0")]
	[AsyncStateMachine(typeof(HBGMFNMGKDA))]
	private Task NHBILJKDCCI(JGCKGNBCBHH GOPLAELIJFH, CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x708B730", Offset = "0x708A330", VA = "0x18708B730")]
	private bool LDKLILCDKMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public JJABPGNICPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class FELMDNNGGGP : OALJJAGILGN, IAKAONBBDGH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct APHGAPLCOBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public FELMDNNGGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private BILFBGGHINK<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7078C60", Offset = "0x7077860", VA = "0x187078C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x70791C0", Offset = "0x7077DC0", VA = "0x1870791C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private NNAPICGMCIC DIHBOGHFHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private GLIFLBJDJKL JCEKBAFBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private CJOIIEBJJHD GCEEPFOCGJD;

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x707E920", Offset = "0x707D520", VA = "0x18707E920", Slot = "6")]
	public void NJFEGHENHFC(CJIDFPHHKMP NLLMJKJPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x707E780", Offset = "0x707D380", VA = "0x18707E780", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x707E680", Offset = "0x707D280", VA = "0x18707E680", Slot = "5")]
	[AsyncStateMachine(typeof(APHGAPLCOBI))]
	public Task AGEIAKKJDNF(string BPMIFKHAMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x707E8C0", Offset = "0x707D4C0", VA = "0x18707E8C0", Slot = "4")]
	public MPFBHKIJKJP LDKLILCDKMM(MLFBKPIOFCD OGPHJGPEMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x707E7D0", Offset = "0x707D3D0", VA = "0x18707E7D0")]
	private CLDOFIAJKBF JJEEECFMFFE(string BPMIFKHAMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public FELMDNNGGGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class FLGAMCJEKLE
{
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7080990", Offset = "0x707F590", VA = "0x187080990")]
	public static void ELDNFNJMJGP(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7080CB0", Offset = "0x707F8B0", VA = "0x187080CB0")]
	internal static void LIPJIGFADJO(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7080BD0", Offset = "0x707F7D0", VA = "0x187080BD0")]
	internal static void KNFKGBLCAJH(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7080540", Offset = "0x707F140", VA = "0x187080540")]
	internal static void EADDJLOPJFN(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class EJEAIEIIKNK : ANOJMELKDFA<LJGJBLECALO>
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class CEHOGMEDMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public LJGJBLECALO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CEHOGMEDMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x70799D0", Offset = "0x70785D0", VA = "0x1870799D0")]
		internal object GPKOIENOGEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly EJEAIEIIKNK NKKNEDDGFMP;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x707D150", Offset = "0x707BD50", VA = "0x18707D150")]
	public ExitGames.Client.Photon.Hashtable CJJBNJOFCID(LJGJBLECALO NKAJDDICLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x707D410", Offset = "0x707C010", VA = "0x18707D410", Slot = "5")]
	protected override void HHFIHMPJNNH(LJGJBLECALO NKAJDDICLFH, IDictionary<object, object> JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x707D1E0", Offset = "0x707BDE0", VA = "0x18707D1E0", Slot = "6")]
	public override LJGJBLECALO GCPIDJEBGBI(IDictionary<object, object> JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x707D540", Offset = "0x707C140", VA = "0x18707D540")]
	private static void IOIJAALEDGI(string NPALNKANGEN, LJGJBLECALO NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x707D6F0", Offset = "0x707C2F0", VA = "0x18707D6F0")]
	public EJEAIEIIKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x707CEA0", Offset = "0x707BAA0", VA = "0x18707CEA0")]
	[CompilerGenerated]
	internal static string AGLNJKLEGAP(LDKNGEJJMKB BHGBMMFNCAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class FFECJEMBIKN
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public static MPFBHKIJKJP EAKLNBLDIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x707C850", Offset = "0x707B450", VA = "0x18707C850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x707EC00", Offset = "0x707D800", VA = "0x18707EC00")]
	public static bool FEAJEPODDJO(this MPFBHKIJKJP HOJIFPKEILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x707CBB0", Offset = "0x707B7B0", VA = "0x18707CBB0")]
	public static MPFBHKIJKJP LFFOOJGFFDL(INOFHHNFADO DENDOGBJGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x707EE80", Offset = "0x707DA80", VA = "0x18707EE80")]
	public static MPFBHKIJKJP GOFOMPMGDDI(IEnumerable<MPFBHKIJKJP> AIJCAEKFPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x707EC20", Offset = "0x707D820", VA = "0x18707EC20")]
	public static string FKIADDKONKN(this MPFBHKIJKJP KKIOBLFFGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public abstract class DFOOOBCFABC : HOMNDJOLGIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public delegate MPFBHKIJKJP CEGNKAPHDHH([NotNull] MLFBKPIOFCD KBGAPCPGPIE);

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class HHDDICBFPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public MLFBKPIOFCD photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public HHDDICBFPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x67292F0", Offset = "0x6727EF0", VA = "0x1867292F0")]
		internal MPFBHKIJKJP OPLDPPKJCIN(CEGNKAPHDHH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private bool KLBJCIGNEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	protected readonly HashSet<CEGNKAPHDHH> JOJJGDNIJPJ;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x707AAC0", Offset = "0x70796C0", VA = "0x18707AAC0", Slot = "4")]
	public void BKMGIPIHAKM(CEGNKAPHDHH HEKPHJKPFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x707AB70", Offset = "0x7079770", VA = "0x18707AB70", Slot = "5")]
	public void GCFIPFGJOGJ(CEGNKAPHDHH HEKPHJKPFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x707AB20", Offset = "0x7079720", VA = "0x18707AB20", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x707ABD0", Offset = "0x70797D0", VA = "0x18707ABD0")]
	protected MPFBHKIJKJP JBMLPMDEIHK(MLFBKPIOFCD APLIOENMKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x707AE70", Offset = "0x7079A70", VA = "0x18707AE70")]
	protected DFOOOBCFABC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class HCMCHGIPJOP : DFOOOBCFABC, PDIHFKFJPBI, HOMNDJOLGIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class JMJAMBEAIMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public MPFBHKIJKJP result;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JMJAMBEAIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x708C270", Offset = "0x708AE70", VA = "0x18708C270")]
		internal object DLPBDMLCHHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x707C620", Offset = "0x707B220", VA = "0x18707C620")]
	[UnityEngine.Scripting.Preserve]
	public HCMCHGIPJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7083AA0", Offset = "0x70826A0", VA = "0x187083AA0", Slot = "8")]
	public MPFBHKIJKJP PINBNKCLKMB(MLFBKPIOFCD APLIOENMKHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class EBJFJCDNOPB : DFOOOBCFABC, NNAPICGMCIC, HOMNDJOLGIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class CANLFEPAKGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public MPFBHKIJKJP result;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CANLFEPAKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7079930", Offset = "0x7078530", VA = "0x187079930")]
		internal object FBHBEJCEBHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x707C620", Offset = "0x707B220", VA = "0x18707C620")]
	[UnityEngine.Scripting.Preserve]
	public EBJFJCDNOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x707C510", Offset = "0x707B110", VA = "0x18707C510", Slot = "8")]
	public MPFBHKIJKJP LDKLILCDKMM(MLFBKPIOFCD FNNNADILIEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class JHOINAHJJMI
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class NOBHGAIKLPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public BILFBGGHINK<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NOBHGAIKLPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7091950", Offset = "0x7090550", VA = "0x187091950")]
		internal object LNCNALGDCBB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x708B000", Offset = "0x7089C00", VA = "0x18708B000")]
	public static BILFBGGHINK<string> HMEIEPODLBL(EEGEMFOKJOP IGMINGONOGN, [Optional] string LPINOKMCMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x708B0E0", Offset = "0x7089CE0", VA = "0x18708B0E0")]
	public static void LCHDEFJAONN(BILFBGGHINK<string> IFGCIHPEHMO, EEGEMFOKJOP IGMINGONOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x708AF40", Offset = "0x7089B40", VA = "0x18708AF40")]
	public static string DKBMDJJALHF(LJGJBLECALO COCEJHGOBBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class MAKGICHPOMD
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x708E990", Offset = "0x708D590", VA = "0x18708E990")]
	public static void KJOIEGHLKFD(this LNOBPBGOOIO IBCBIOCIMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x708E980", Offset = "0x708D580", VA = "0x18708E980")]
	public static void DNMFOHPPIOP(this LNOBPBGOOIO IBCBIOCIMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x708E860", Offset = "0x708D460", VA = "0x18708E860")]
	private static void COEECJMOJLK(this LNOBPBGOOIO IBCBIOCIMNL, bool HNOOADONKJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class JHNBMNPAIJI : KBMNBMIJCON, OCHHHIDLNCF, HBNFDPLNIPP, GHBJCBEFCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly OCHHHIDLNCF MJCLLOKDEBC;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public MLFBKPIOFCD CJDPMHBENLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x708AC60", Offset = "0x7089860", VA = "0x18708AC60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int MINDBLDNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x708A9D0", Offset = "0x70895D0", VA = "0x18708A9D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int GCCLMKCPFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x708AAC0", Offset = "0x70896C0", VA = "0x18708AAC0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool EIFGBLGGAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int KLCLBODHANA
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE40", Offset = "0x8DBA40", VA = "0x1808DCE40", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OOAHIFPHOGI.KHEJCLBEAID PIIFHAKDBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KKHPEIPCDNC DNPPEGJDICC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x708ABC0", Offset = "0x70897C0", VA = "0x18708ABC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x708AD70", Offset = "0x7089970", VA = "0x18708AD70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> NCNBNLDCODM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<MLFBKPIOFCD> MKJOLOIGLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action CPODMKAFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x708ACB0", Offset = "0x70898B0", VA = "0x18708ACB0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x708AA20", Offset = "0x7089620", VA = "0x18708AA20", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xCBE090", Offset = "0xCBCC90", VA = "0x180CBE090")]
	public JHNBMNPAIJI(OCHHHIDLNCF MJCLLOKDEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x708AB10", Offset = "0x7089710", VA = "0x18708AB10", Slot = "8")]
	public bool EDJOOEKHDEB(byte INJNDNCLLIE, ExitGames.Client.Photon.Hashtable JIEKNJMCGFP, OEGNPGMBLHF MOFCHHGCFLB, SendOptions CCCOJKFMICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x708AE10", Offset = "0x7089A10", VA = "0x18708AE10", Slot = "16")]
	public MLFBKPIOFCD OFDEAIFOHKH(int DBNMHEADMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "19")]
	public void HMCOGODNNJJ(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "20")]
	public void GGJOFHGONMF(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "21")]
	public void APJJAOHNBEK(object GBENACPKFNA, bool KFFCPJKPHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x708AEF0", Offset = "0x7089AF0", VA = "0x18708AEF0", Slot = "22")]
	public IDisposable OHFCDHAGMID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "23")]
	private bool JJGBENFBJIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "24")]
	public void AEJBCHAAMKJ(StringBuilder GFJGLBPCJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x708AD50", Offset = "0x7089950", VA = "0x18708AD50", Slot = "25")]
	public bool HGPMEHFDDMC(bool AGAOAILDEME, [Out] string JMMBJIBOIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x998E60", Offset = "0x997A60", VA = "0x180998E60", Slot = "28")]
	public void LPAPMNPJGMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct PEBINCEGBKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private readonly IDictionary<object, object> JBAJGONDFIO;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	public PEBINCEGBKG(IDictionary<object, object> JBAJGONDFIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7092910", Offset = "0x7091510", VA = "0x187092910")]
	public bool PACPIPPJJJL([Out] LJGJBLECALO NKAJDDICLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7092630", Offset = "0x7091230", VA = "0x187092630")]
	public Guid BCEHLOPEGBE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x70926E0", Offset = "0x70912E0", VA = "0x1870926E0")]
	public MPFBHKIJKJP FKHLAHAFOCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7092820", Offset = "0x7091420", VA = "0x187092820")]
	public static ExitGames.Client.Photon.Hashtable NCPDNLLGMJA(LJGJBLECALO NKAJDDICLFH, MPFBHKIJKJP HOJIFPKEILN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal static class FNFBKLLOPAG
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7080E10", Offset = "0x707FA10", VA = "0x187080E10")]
	public static bool MAAPHKPKHOI(this MEEJEPKLPKH MGEDBJHLFAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct KPHPLOJKMAK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct HBMEFOJIBEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public KPHPLOJKMAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7083160", Offset = "0x7081D60", VA = "0x187083160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7083340", Offset = "0x7081F40", VA = "0x187083340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private readonly CancellationTokenSource GJNGFDIEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private bool KLBJCIGNEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private Task LJPOAIPEHGB;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool PHIOAAOKLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x708C550", Offset = "0x708B150", VA = "0x18708C550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x708C580", Offset = "0x708B180", VA = "0x18708C580")]
	public KPHPLOJKMAK(CancellationToken PPKBAEMFIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x708C440", Offset = "0x708B040", VA = "0x18708C440")]
	[AsyncStateMachine(typeof(HBMEFOJIBEE))]
	public Task ODOJAKAGBNK(Func<CancellationToken, List<Task>> CPHPNOFKKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x708C3F0", Offset = "0x708AFF0", VA = "0x18708C3F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct MIFAOFJNDND<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct DIGGHAEBKMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<PGFHMCKFNEA<TData>, LGLBGBDJHMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public MIFAOFJNDND<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private TaskAwaiter<NLDGPBPIIJN<PGFHMCKFNEA<TData>, LGLBGBDJHMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x58A6A60", Offset = "0x58A5660", VA = "0x1858A6A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3DB4A60", Offset = "0x3DB3660", VA = "0x183DB4A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private readonly ADLAMOLFKJD<TGetDataArg, TData> PLLBOMGPHPP;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	internal MIFAOFJNDND(ADLAMOLFKJD<TGetDataArg, TData> EIDBKEEIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x448DDF0", Offset = "0x448C9F0", VA = "0x18448DDF0")]
	[AsyncStateMachine(typeof(MIFAOFJNDND<, >.DIGGHAEBKMC))]
	public Task<NLDGPBPIIJN<PGFHMCKFNEA<TData>, LGLBGBDJHMM>> GDJFBEOMOHJ(TGetDataArg OKLJLMJMKDA, string CIJAIDKIHMH, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class LJDIDOGFDJD
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x29E1420", Offset = "0x29E0020", VA = "0x1829E1420")]
	public static MIFAOFJNDND<TGetDataArg, TData> FCDPFGJNKNI<TGetDataArg, TData>(ADLAMOLFKJD<TGetDataArg, TData> EIDBKEEIBKK)
	{
		return default(MIFAOFJNDND<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct MBPGMFLLLIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public readonly int MMNPOHPFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public readonly int? MCEKOPHNFAJ;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x423A530", Offset = "0x4239130", VA = "0x18423A530")]
	public MBPGMFLLLIC(int GNNOHLIDBFM, [Optional] int? CACNCLOMFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x708ECC0", Offset = "0x708D8C0", VA = "0x18708ECC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface NKAMOJBKHAM<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKAIHOFMLCC();

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKAMOJBKHAM<T> BGFEPICEKME(string EKMKGBJIPDB);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NKAMOJBKHAM<T> DKAIFPBACNA(CBMMEPNNINO<T> GKDBFFCJJIC);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKAMOJBKHAM<T> DEKHMKLPMFI(int INPPILAHLCC);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NKAMOJBKHAM<T> IAEFMAMIFHD(int INPPILAHLCC, DGBNBPGBPJN<T> PAKCAGLOAEO);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface ACJCNKIMHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKAMOJBKHAM<T> EJAIEMBLCOH<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGHHHJKNGEI HPODAADHHHL(Exception GKFNJIBGPDM);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MBPGMFLLLIC ILEONEOKNJG(Exception GKFNJIBGPDM);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public delegate string CBMMEPNNINO<in T>(T GKFNJIBGPDM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate int DGBNBPGBPJN<in T>(T GKFNJIBGPDM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal class HDNFGLKFMJL : ACJCNKIMHHO
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private delegate string ALEHKJIJECE(Exception GKFNJIBGPDM);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate int GCKFLOEJJKP(Exception GKFNJIBGPDM);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class GLNMPFEMNLE<T> : NKAMOJBKHAM<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class DCDILDKLHHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public DCDILDKLHHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			internal string EHMIFPHLHEB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class CIEHNEGEAFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public CBMMEPNNINO<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public CIEHNEGEAFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x55886C0", Offset = "0x55872C0", VA = "0x1855886C0")]
			internal string EDDGCELEICL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class CMOPNCPIHNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public DGBNBPGBPJN<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public CMOPNCPIHNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x55886C0", Offset = "0x55872C0", VA = "0x1855886C0")]
			internal int FNFHJABKEAG(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private readonly HDNFGLKFMJL JGALMKNMLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly Type AOLEAFOGOGP;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3D69D10", Offset = "0x3D68910", VA = "0x183D69D10")]
		internal GLNMPFEMNLE(HDNFGLKFMJL JGALMKNMLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3D69CE0", Offset = "0x3D688E0", VA = "0x183D69CE0", Slot = "4")]
		public void JKAIHOFMLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x3D69920", Offset = "0x3D68520", VA = "0x183D69920", Slot = "5")]
		public NKAMOJBKHAM<T> BGFEPICEKME(string EKMKGBJIPDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3D69A80", Offset = "0x3D68680", VA = "0x183D69A80", Slot = "6")]
		public NKAMOJBKHAM<T> DKAIFPBACNA(CBMMEPNNINO<T> GKDBFFCJJIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x3D69A40", Offset = "0x3D68640", VA = "0x183D69A40", Slot = "7")]
		public NKAMOJBKHAM<T> DEKHMKLPMFI(int INPPILAHLCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x3D69BA0", Offset = "0x3D687A0", VA = "0x183D69BA0", Slot = "8")]
		public NKAMOJBKHAM<T> IAEFMAMIFHD(int INPPILAHLCC, DGBNBPGBPJN<T> PAKCAGLOAEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class JAGBNIJKPON<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private bool FMOFHDABJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private readonly List<Type> GCPOBDJGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private readonly Dictionary<Type, TVal> FGLGJHGLNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private readonly Dictionary<Type, int> LDEBOLIFOHL;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public IReadOnlyList<Type> JDHJFMCBLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x4074140", Offset = "0x4072D40", VA = "0x184074140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x4074380", Offset = "0x4072F80", VA = "0x184074380")]
		public JAGBNIJKPON(Dictionary<Type, int> LDEBOLIFOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x4074080", Offset = "0x4072C80", VA = "0x184074080")]
		public void LKPJOLMECIF(Type NCMHANGAILD, TVal BMEHNBDMOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x40742C0", Offset = "0x4072EC0", VA = "0x1840742C0")]
		public bool OIBKCMFDGCI(Type AOLEAFOGOGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x4073F60", Offset = "0x4072B60", VA = "0x184073F60")]
		public bool KEKFCKEBLAB(TVal IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4074320", Offset = "0x4072F20", VA = "0x184074320")]
		public TVal OIPGNBHOLEB(Type HGPIKDLKBHO)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x4073EC0", Offset = "0x4072AC0", VA = "0x184073EC0")]
		[CompilerGenerated]
		private int COJFFCNJBGF(Type ONONPJJAOCM, Type MJKELKDDFNG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class ANOOICEANIN : IEnumerable<MBPGMFLLLIC>, IEnumerable, IEnumerator<MBPGMFLLLIC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private MBPGMFLLLIC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public HDNFGLKFMJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private IEnumerator<MBPGMFLLLIC> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private MBPGMFLLLIC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x38B2700", Offset = "0x38B1300", VA = "0x1838B2700", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MBPGMFLLLIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x7078430", Offset = "0x7077030", VA = "0x187078430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB210", Offset = "0x8B9E10", VA = "0x1808BB210")]
		[DebuggerHidden]
		public ANOOICEANIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7078480", Offset = "0x7077080", VA = "0x187078480", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7077E30", Offset = "0x7076A30", VA = "0x187077E30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x70782D0", Offset = "0x7076ED0", VA = "0x1870782D0")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7077DE0", Offset = "0x70769E0", VA = "0x187077DE0")]
		private void JMPEPBOJIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x70783E0", Offset = "0x7076FE0", VA = "0x1870783E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x7078320", Offset = "0x7076F20", VA = "0x187078320", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MBPGMFLLLIC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x7078320", Offset = "0x7076F20", VA = "0x187078320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly MBPGMFLLLIC JDHHNMEOKIF;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly Dictionary<Type, int> CFNJFCJNANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly HashSet<Type> DFEAJLKAGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private readonly JAGBNIJKPON<int> IIPGIFIMIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly JAGBNIJKPON<GCKFLOEJJKP> HGIIIEPGALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly JAGBNIJKPON<ALEHKJIJECE> KDEPMGFNCLD;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7084E70", Offset = "0x7083A70", VA = "0x187084E70")]
	[DHOHFCLMOGD(IDHBAGABJJA.GameOnly)]
	private static void NOFLNPHPAAG(IMEOEBHKJNP DAOJEFNFNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7084FB0", Offset = "0x7083BB0", VA = "0x187084FB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HDNFGLKFMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2996690", Offset = "0x2995290", VA = "0x182996690", Slot = "4")]
	public NKAMOJBKHAM<T> EJAIEMBLCOH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7084750", Offset = "0x7083350", VA = "0x187084750", Slot = "5")]
	public EGHHHJKNGEI HPODAADHHHL(Exception GKFNJIBGPDM)
	{
		return default(EGHHHJKNGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x70847E0", Offset = "0x70833E0", VA = "0x1870847E0", Slot = "6")]
	public MBPGMFLLLIC ILEONEOKNJG(Exception? GKFNJIBGPDM)
	{
		return default(MBPGMFLLLIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x70843E0", Offset = "0x7082FE0", VA = "0x1870843E0", Slot = "7")]
	[IteratorStateMachine(typeof(ANOOICEANIN))]
	public IEnumerable<MBPGMFLLLIC> HEOGHJLOLBH(Exception GKFNJIBGPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7084110", Offset = "0x7082D10", VA = "0x187084110", Slot = "8")]
	public string ENCBHPNDHEF(Exception? GKFNJIBGPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7083E00", Offset = "0x7082A00", VA = "0x187083E00")]
	private string CFIOLBGGIIN(AggregateException KPOAOJBFNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7084AC0", Offset = "0x70836C0", VA = "0x187084AC0")]
	private void KKBLOEIFBOA(Type AOLEAFOGOGP, int INPPILAHLCC, GCKFLOEJJKP? JOHILBPKLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7083BB0", Offset = "0x70827B0", VA = "0x187083BB0")]
	private void BKIFBHMLCPG(Type AOLEAFOGOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7084480", Offset = "0x7083080", VA = "0x187084480")]
	private void HLLAACHCAAO(Type AOLEAFOGOGP, ALEHKJIJECE EJPDOEKDDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7084260", Offset = "0x7082E60", VA = "0x187084260")]
	private static int GIFHOJMIFIA(Type AOLEAFOGOGP, Dictionary<Type, int> LDEBOLIFOHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2B3D470", Offset = "0x2B3C070", VA = "0x182B3D470")]
	private static bool FPMFMBMDPEE<TVal>(JAGBNIJKPON<TVal> COOBAOCKFHD, Type AOLEAFOGOGP, [Out] TVal IIPLJLPCLBC) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x70849E0", Offset = "0x70835E0", VA = "0x1870849E0")]
	[CompilerGenerated]
	internal static int KFDFBPHCIIB(Type AJGGDBGNPJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct EGHHHJKNGEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public readonly MBPGMFLLLIC MCOEAEDPPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public readonly string BBPAPAKPIGK;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x707CE20", Offset = "0x707BA20", VA = "0x18707CE20")]
	public EGHHHJKNGEI(string IJPFDIGFNAD, MBPGMFLLLIC INPPILAHLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x707CD80", Offset = "0x707B980", VA = "0x18707CD80")]
	public string CICKIMCFMLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class DNMCGKCDFPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private readonly CCFJHECDIBO MCGBFBBANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private string NPIHFAEMCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? NGOGFCDCLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private long? FOLJAGMILHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? ELFFKJGKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private string LGGCHMDGKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private NCHCAFBDJHO NCOFMAJGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private long? ODMIKAKNELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private bool MNCDHFIOMJN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string EAPPPEHPKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long OJMLNGHHHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x707B890", Offset = "0x707A490", VA = "0x18707B890")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long OJBAEDAPCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x707B370", Offset = "0x7079F70", VA = "0x18707B370")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public long DIDEDJPPHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x707AFA0", Offset = "0x7079BA0", VA = "0x18707AFA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string MDKJDLGGILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x707AF60", Offset = "0x7079B60", VA = "0x18707AF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public NCHCAFBDJHO LCLCGPDJKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA75390", Offset = "0xA73F90", VA = "0x180A75390")]
		get
		{
			return default(NCHCAFBDJHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x707B3D0", Offset = "0x7079FD0", VA = "0x18707B3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long DFKDGMMLDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x707B830", Offset = "0x707A430", VA = "0x18707B830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x707BD80", Offset = "0x707A980", VA = "0x18707BD80")]
	[UnityEngine.Scripting.Preserve]
	public DNMCGKCDFPB([POJODGKFIMO(null)] CCFJHECDIBO MCGBFBBANFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x707B4C0", Offset = "0x707A0C0", VA = "0x18707B4C0")]
	private void INGELFHALAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x707B8F0", Offset = "0x707A4F0", VA = "0x18707B8F0")]
	public void NKHEFMADKAI(long ACIHEOIHPAO, long EPCPKKDEADD, [Optional] long? PGCBOFIMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x707B790", Offset = "0x707A390", VA = "0x18707B790")]
	public void KBMMDEBEDAN(long PGCBOFIMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x707B710", Offset = "0x707A310", VA = "0x18707B710")]
	public void JCINDMEAFAK(string MJAJMIHCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x707B000", Offset = "0x7079C00", VA = "0x18707B000")]
	public void FKHPCBHHKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class MNBHHFEPHJK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct NJBHKIPFJPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public LJGJBLECALO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public MNBHHFEPHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private TaskAwaiter<CBPBLOCHIAA.ALDPHMMOAAA<LJGJBLECALO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x70A7F50", Offset = "0x70A6B50", VA = "0x1870A7F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x70A8480", Offset = "0x70A7080", VA = "0x1870A8480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct MHMKIACNJAK<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class FALBJLMMAKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public LJGJBLECALO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FALBJLMMAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7099480", Offset = "0x7098080", VA = "0x187099480")]
		internal LJGJBLECALO KFGCHFKBKGD(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct IODLFHOJNOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public AsyncTaskMethodBuilder<CBPBLOCHIAA.ALDPHMMOAAA<LJGJBLECALO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public LJGJBLECALO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public MNBHHFEPHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private OKKNFPMHCCL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private TaskAwaiter<CBPBLOCHIAA.ALDPHMMOAAA<LJGJBLECALO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x70A0D50", Offset = "0x709F950", VA = "0x1870A0D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x70A1360", Offset = "0x709FF60", VA = "0x1870A1360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct DOAPOMAMNEM<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public MNBHHFEPHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x58DEAE0", Offset = "0x58DD6E0", VA = "0x1858DEAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x357A250", Offset = "0x3578E50", VA = "0x18357A250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct NACHCCPKEHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public MNBHHFEPHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x70A6D40", Offset = "0x70A5940", VA = "0x1870A6D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x70A6F00", Offset = "0x70A5B00", VA = "0x1870A6F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class KMEAJDLPEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KMEAJDLPEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x70A3970", Offset = "0x70A2570", VA = "0x1870A3970")]
		internal object FNFBOHOEFBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x70A39D0", Offset = "0x70A25D0", VA = "0x1870A39D0")]
		internal bool KBIBAGNEAHO(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class FAEBHDDLABG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FAEBHDDLABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7099420", Offset = "0x7098020", VA = "0x187099420")]
		internal object ENCMNOOHHPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class LKIEAAFFJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LKIEAAFFJKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x70A49F0", Offset = "0x70A35F0", VA = "0x1870A49F0")]
		internal object HBOMLNGLHLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class KHHNCLNPCPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KHHNCLNPCPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x70A3900", Offset = "0x70A2500", VA = "0x1870A3900")]
		internal object DDNKKFOGGHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class GEECBGCIFJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public MNBHHFEPHJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GEECBGCIFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x709CE30", Offset = "0x709BA30", VA = "0x18709CE30")]
		internal object GPKOIENOGEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private static readonly Guid CBNJCLDALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public readonly HFKGHGOGEPA IHCMBAJLKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly CBPBLOCHIAA NCOADNKAGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private readonly HBNFDPLNIPP IBCBIOCIMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly GHBJCBEFCGI IGHLAODCKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private bool NENGOPKDHIL;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x70A6B10", Offset = "0x70A5710", VA = "0x1870A6B10")]
	public MNBHHFEPHJK(HFKGHGOGEPA NBPBNEMNBCH, CBPBLOCHIAA NCOADNKAGLO, HBNFDPLNIPP IBCBIOCIMNL, GHBJCBEFCGI IGHLAODCKOE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x70A5CE0", Offset = "0x70A48E0", VA = "0x1870A5CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x70A5B70", Offset = "0x70A4770", VA = "0x1870A5B70")]
	public void AOJGPLNNBPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x70A5F10", Offset = "0x70A4B10", VA = "0x1870A5F10")]
	public void HNHPDECIACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x70A63E0", Offset = "0x70A4FE0", VA = "0x1870A63E0")]
	public void KDMPNIPJFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x70A6940", Offset = "0x70A5540", VA = "0x1870A6940")]
	[AsyncStateMachine(typeof(NJBHKIPFJPD))]
	internal Task<LJGJBLECALO> MPNMOFHBGFE(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, LJGJBLECALO COCEJHGOBBC, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2C44340", Offset = "0x2C42F40", VA = "0x182C44340")]
	private static byte[] BMNLAHBEADE<T>(T NKAJDDICLFH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2C44350", Offset = "0x2C42F50", VA = "0x182C44350")]
	private static T FNBFPCGNCBB<T>(MessageParser<T> MJBJGOMNEJC, byte[] NKAJDDICLFH, T FDJEFDFGBFA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x70A5A30", Offset = "0x70A4630", VA = "0x1870A5A30")]
	[AsyncStateMachine(typeof(IODLFHOJNOB))]
	private Task<CBPBLOCHIAA.ALDPHMMOAAA<LJGJBLECALO>> AEDDCHOPDEP(LJGJBLECALO COCEJHGOBBC, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2C444A0", Offset = "0x2C430A0", VA = "0x182C444A0")]
	[AsyncStateMachine(typeof(DOAPOMAMNEM<>))]
	internal Task<T> IIGMHGMEEPB<T>(CancellationToken OADLPMIOAJN, Func<CancellationToken, Task<T>> BNDENCKMJPI, int JBMFKPLJOKK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x70A6050", Offset = "0x70A4C50", VA = "0x1870A6050")]
	[AsyncStateMachine(typeof(NACHCCPKEHB))]
	internal Task IIGMHGMEEPB(CancellationToken OADLPMIOAJN, Func<CancellationToken, Task> BNDENCKMJPI, int JBMFKPLJOKK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x70A5FD0", Offset = "0x70A4BD0", VA = "0x1870A5FD0")]
	public KNAMKLMJIGG HPLHAPDEDHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x70A6760", Offset = "0x70A5360", VA = "0x1870A6760")]
	public NNBCMEIMDBN MILNOOFMEOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x70A6290", Offset = "0x70A4E90", VA = "0x1870A6290")]
	public FNIHEEHHJFG KANOFFPCELJ([Optional] EEGEMFOKJOP? IGMINGONOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x70A67E0", Offset = "0x70A53E0", VA = "0x1870A67E0")]
	public void MOHOGJNGHPM(Func<Guid, bool> GBNKGFNJMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x70A5E00", Offset = "0x70A4A00", VA = "0x1870A5E00")]
	public void ECLIFGCFDKJ(Func<Guid, bool> GOIKIHAEDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x70A65E0", Offset = "0x70A51E0", VA = "0x1870A65E0")]
	public Guid MBOAHIPPIGN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x70A5CF0", Offset = "0x70A48F0", VA = "0x1870A5CF0")]
	public void EBPIPGOMECK(Guid OCPFIICCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x70A64A0", Offset = "0x70A50A0", VA = "0x1870A64A0")]
	public void KJAEKBODAIO(LJGJBLECALO BLNGHBEABCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x70A6180", Offset = "0x70A4D80", VA = "0x1870A6180")]
	public void IOIJAALEDGI(string JJJOBBAHKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2C449F0", Offset = "0x2C435F0", VA = "0x182C449F0")]
	private T OFGMELJMAFA<T>(T IIPLJLPCLBC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x70A5C90", Offset = "0x70A4890", VA = "0x1870A5C90")]
	public void DGLEAECNMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2C44740", Offset = "0x2C43340", VA = "0x182C44740")]
	[CompilerGenerated]
	internal static string JMCKHHKBPLL<T>(byte[] GABEBEKDBIP, int IJGENGGMLKK, MHMKIACNJAK<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal sealed class LHNFNPCFJDC : HFKGHGOGEPA
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class GLPJACJGJHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GLPJACJGJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x709D540", Offset = "0x709C140", VA = "0x18709D540")]
		internal object DOBNEHIALON()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct FHFLDAAJAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public LHNFNPCFJDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EMPEJCIGLJJ <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private NNBCMEIMDBN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x709B770", Offset = "0x709A370", VA = "0x18709B770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x709C040", Offset = "0x709AC40", VA = "0x18709C040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct BBJAFOMAEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public LHNFNPCFJDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter<PFJIJEDBGEL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7096240", Offset = "0x7094E40", VA = "0x187096240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x70969D0", Offset = "0x70955D0", VA = "0x1870969D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct IGBFPJCIJFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public LHNFNPCFJDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter<BCBONPLPCBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x70A0190", Offset = "0x709ED90", VA = "0x1870A0190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x70A04A0", Offset = "0x709F0A0", VA = "0x1870A04A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class GBNDEHFCLAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public EMPEJCIGLJJ presence;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GBNDEHFCLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x709C860", Offset = "0x709B460", VA = "0x18709C860")]
		internal object KKEDEEADLDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private static readonly EEGEMFOKJOP GKJBHEJKION;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private static readonly EEGEMFOKJOP DMGBPIGMPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly LDKNGEJJMKB NOMIODMHGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private readonly MEEJEPKLPKH INELBGFBDKG;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x70A4090", Offset = "0x70A2C90", VA = "0x1870A4090")]
	public LHNFNPCFJDC(LDKNGEJJMKB NOMIODMHGKP, MEEJEPKLPKH INELBGFBDKG, Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, LMPPFDJJNDM NGAIIMAHPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x70A3E70", Offset = "0x70A2A70", VA = "0x1870A3E70", Slot = "7")]
	[AsyncStateMachine(typeof(FHFLDAAJAKL))]
	protected override Task MJLPEKHLDHF(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x70A3BA0", Offset = "0x70A27A0", VA = "0x1870A3BA0")]
	[AsyncStateMachine(typeof(BBJAFOMAEKD))]
	private Task KPPPEEDOGOF(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x70A3A90", Offset = "0x70A2690", VA = "0x1870A3A90")]
	[AsyncStateMachine(typeof(IGBFPJCIJFN))]
	private Task<byte> GOJLCHEFDLL(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x70A3CA0", Offset = "0x70A28A0", VA = "0x1870A3CA0")]
	private EMPEJCIGLJJ MBALLAIOGCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class NLCFGGCDBHH : HFKGHGOGEPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct MCCNDNDNJJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public NLCFGGCDBHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter<KGPHKHBNANK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x70A4A60", Offset = "0x70A3660", VA = "0x1870A4A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x70A53D0", Offset = "0x70A3FD0", VA = "0x1870A53D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private readonly int OCPDKJAJANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly ECJJPIPOFMP INHGMJFCGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly long NGKIPDLAOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly long IEOKOIICKLE;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public KGPHKHBNANK HHADGLJKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x872460", Offset = "0x871060", VA = "0x180872460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x872360", Offset = "0x870F60", VA = "0x180872360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x70A8610", Offset = "0x70A7210", VA = "0x1870A8610")]
	public NLCFGGCDBHH(Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, LMPPFDJJNDM NGAIIMAHPMJ, int OCPDKJAJANC, ECJJPIPOFMP INHGMJFCGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x70A84F0", Offset = "0x70A70F0", VA = "0x1870A84F0", Slot = "7")]
	[AsyncStateMachine(typeof(MCCNDNDNJJF))]
	protected override Task MJLPEKHLDHF(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal abstract class FINKKACCJLJ : HFKGHGOGEPA
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class KDINGEKBGDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public FINKKACCJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public BHOIANONIAI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KDINGEKBGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x70A3830", Offset = "0x70A2430", VA = "0x1870A3830")]
		internal Task NILJILNCJHE(BILFBGGHINK<string>.OADHIEPGLKH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x70A3870", Offset = "0x70A2470", VA = "0x1870A3870")]
		internal object NPFBCHLINCJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct AOFFIDHIDLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public FINKKACCJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KDINGEKBGDM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x7095A20", Offset = "0x7094620", VA = "0x187095A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x70961E0", Offset = "0x7094DE0", VA = "0x1870961E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct AJJHIDMKJBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public BHOIANONIAI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public FINKKACCJLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7095430", Offset = "0x7094030", VA = "0x187095430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x70959C0", Offset = "0x70945C0", VA = "0x1870959C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x709C320", Offset = "0x709AF20", VA = "0x18709C320")]
	public FINKKACCJLJ(Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, LMPPFDJJNDM NGAIIMAHPMJ, string DLFNLALHMEG, PLCGGJDBLPO CIANIJNKGHA, bool JAHLMPCHPKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x709C1E0", Offset = "0x709ADE0", VA = "0x18709C1E0", Slot = "7")]
	[AsyncStateMachine(typeof(AOFFIDHIDLE))]
	protected override Task MJLPEKHLDHF(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OFKCELENHNA(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x709C0A0", Offset = "0x709ACA0", VA = "0x18709C0A0")]
	[AsyncStateMachine(typeof(AJJHIDMKJBM))]
	private Task ICOEMBAHFMK(IDisposable KPKKOODLFDJ, BHOIANONIAI KJKGOBDOLMA, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class POJMIKPBDCB : HFKGHGOGEPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct IKKJGDKHBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public POJMIKPBDCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private TaskAwaiter<PJDBEJLAAGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x70A0790", Offset = "0x709F390", VA = "0x1870A0790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x70A0CF0", Offset = "0x709F8F0", VA = "0x1870A0CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly JGCKGNBCBHH GOPLAELIJFH;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x70AC920", Offset = "0x70AB520", VA = "0x1870AC920")]
	public POJMIKPBDCB(Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, LMPPFDJJNDM NGAIIMAHPMJ, JGCKGNBCBHH GOPLAELIJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x70AC840", Offset = "0x70AB440", VA = "0x1870AC840", Slot = "6")]
	protected override string PJIEDGMHPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x70AC720", Offset = "0x70AB320", VA = "0x1870AC720", Slot = "7")]
	[AsyncStateMachine(typeof(IKKJGDKHBAJ))]
	protected override Task MJLPEKHLDHF(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal abstract class HFKGHGOGEPA : CCMLBAANCBG
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public delegate Task CALOFNBIIOI(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class ACHEPNAJOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public BILFBGGHINK<string>.OADHIEPGLKH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public HFKGHGOGEPA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ACHEPNAJOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x70951E0", Offset = "0x7093DE0", VA = "0x1870951E0")]
		internal Task APDMOALJLCP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class BHNCHBMGNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public ACHEPNAJOKM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BHNCHBMGNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x7096A30", Offset = "0x7095630", VA = "0x187096A30")]
		internal object JFDPCECCABL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct NOKFBNDDNJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public HFKGHGOGEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public Func<HFKGHGOGEPA, BILFBGGHINK<string>.OADHIEPGLKH, MNBHHFEPHJK> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private ACHEPNAJOKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private MNBHHFEPHJK <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<LJGJBLECALO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x70AA2B0", Offset = "0x70A8EB0", VA = "0x1870AA2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x70AB470", Offset = "0x70AA070", VA = "0x1870AB470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct CNBGKMFGPDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x7097F60", Offset = "0x7096B60", VA = "0x187097F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x70989F0", Offset = "0x70975F0", VA = "0x1870989F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct ONNPGPAJIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public HFKGHGOGEPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x70AC100", Offset = "0x70AAD00", VA = "0x1870AC100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x70AC460", Offset = "0x70AB060", VA = "0x1870AC460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public readonly Guid GECIONPEKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public readonly ByteString FHEHKMKACOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly LMPPFDJJNDM CJDMBBLIJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	protected readonly string PADHJGPDLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly bool JAHLMPCHPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly Queue<CALOFNBIIOI> BBCHLEGEGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private readonly GIHGFNFLHKF AEDLMPPBHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private readonly PLCGGJDBLPO CIANIJNKGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private bool MELINELJEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public NCHCAFBDJHO HKKGIMKBHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public NCHCAFBDJHO HFEHLKCCIDF;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CJIDFPHHKMP NHOIHAIKBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x709EBD0", Offset = "0x709D7D0", VA = "0x18709EBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public BOEFEBEHKHL MGJFEDPKAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x709ECC0", Offset = "0x709D8C0", VA = "0x18709ECC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x709EC40", Offset = "0x709D840", VA = "0x18709EC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PBMPNMINHOB LGDNHOHICAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x709EE00", Offset = "0x709DA00", VA = "0x18709EE00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x709EC20", Offset = "0x709D820", VA = "0x18709EC20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x709F720", Offset = "0x709E320", VA = "0x18709F720")]
	protected HFKGHGOGEPA(Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, LMPPFDJJNDM NGAIIMAHPMJ, string DLFNLALHMEG, PLCGGJDBLPO CIANIJNKGHA, bool JAHLMPCHPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x709F6E0", Offset = "0x709E2E0", VA = "0x18709F6E0", Slot = "6")]
	protected virtual string PJIEDGMHPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x709F600", Offset = "0x709E200", VA = "0x18709F600")]
	public void NIJHGGAIOED(CALOFNBIIOI AAKBHKDBNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x709F350", Offset = "0x709DF50", VA = "0x18709F350")]
	protected void NCOMOMMIOHC(float GJCPBEAOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x709F200", Offset = "0x709DE00", VA = "0x18709F200")]
	[AsyncStateMachine(typeof(NOKFBNDDNJM))]
	public Task MGFNPLKOLEC(CancellationToken PPKBAEMFIMG, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, [Optional] Func<HFKGHGOGEPA, BILFBGGHINK<string>.OADHIEPGLKH, MNBHHFEPHJK> ACLKNIIKBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x709F050", Offset = "0x709DC50", VA = "0x18709F050")]
	[AsyncStateMachine(typeof(CNBGKMFGPDO))]
	private static Task MAHCCMBOGAF(Func<CancellationToken, Task> LMJCDOHEKLN, Func<CancellationToken, Task> PBPMECLGBNN, CancellationToken OADLPMIOAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x709F490", Offset = "0x709E090", VA = "0x18709F490")]
	private void NHDMDOCCBMK(bool OBJBDHJNFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x709EE20", Offset = "0x709DA20", VA = "0x18709EE20")]
	private void JIFIMANDKNF(MNBHHFEPHJK MMHDADPGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task MJLPEKHLDHF(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x709F370", Offset = "0x709DF70", VA = "0x18709F370")]
	[AsyncStateMachine(typeof(ONNPGPAJIDM))]
	private Task NHCAPODJENL(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x709F180", Offset = "0x709DD80", VA = "0x18709F180")]
	public LJGJBLECALO MBGABOPBLME(OKKNFPMHCCL KJPNKFOBGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x709ED10", Offset = "0x709D910", VA = "0x18709ED10")]
	[CompilerGenerated]
	private Task EGKMIJJFIOM(CancellationToken GLMCDBEDNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x709F660", Offset = "0x709E260", VA = "0x18709F660")]
	[CompilerGenerated]
	private object ODPBGNOPMGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal sealed class DPFPDCIEJJF : FINKKACCJLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct DLHPJDDNMIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public DPFPDCIEJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private LEDBKEPMGME <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private NNBCMEIMDBN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x7098A50", Offset = "0x7097650", VA = "0x187098A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x70991C0", Offset = "0x7097DC0", VA = "0x1870991C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly LDKNGEJJMKB GJCKGAIGJLP;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x7099370", Offset = "0x7097F70", VA = "0x187099370")]
	public DPFPDCIEJJF(Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, LDKNGEJJMKB GJCKGAIGJLP, LMPPFDJJNDM NGAIIMAHPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x7099220", Offset = "0x7097E20", VA = "0x187099220", Slot = "8")]
	[AsyncStateMachine(typeof(DLHPJDDNMIK))]
	protected override Task OFKCELENHNA(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal class CLDOFIAJKBF : HFKGHGOGEPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct GPEAJPBFFIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CLDOFIAJKBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<PJDBEJLAAGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x709E7C0", Offset = "0x709D3C0", VA = "0x18709E7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x709EB70", Offset = "0x709D770", VA = "0x18709EB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly string ACFDCBFCDCH;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x7097EB0", Offset = "0x7096AB0", VA = "0x187097EB0")]
	public CLDOFIAJKBF(Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, LMPPFDJJNDM NGAIIMAHPMJ, string ACFDCBFCDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x7097DA0", Offset = "0x70969A0", VA = "0x187097DA0", Slot = "7")]
	[AsyncStateMachine(typeof(GPEAJPBFFIN))]
	protected override Task MJLPEKHLDHF(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal class FGMOFBPLHCO : FINKKACCJLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class OACHILKHDKI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public OACHILKHDKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			private TaskAwaiter<PJDBEJLAAGG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			private TaskAwaiter<LJGJBLECALO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x70ADEC0", Offset = "0x70ACAC0", VA = "0x1870ADEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x70AE380", Offset = "0x70ACF80", VA = "0x1870AE380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public FGMOFBPLHCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public FNIHEEHHJFG serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public GJPJKPDEMOM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public KNAMKLMJIGG uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public DOFPGBMFAOA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public OACHILKHDKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x70AB4D0", Offset = "0x70AA0D0", VA = "0x1870AB4D0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<LJGJBLECALO> LPHMANFHNLP(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct KCDFEBFHCGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public FGMOFBPLHCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private OACHILKHDKI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private LEDBKEPMGME <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private NNBCMEIMDBN <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private LJGJBLECALO <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x70A2880", Offset = "0x70A1480", VA = "0x1870A2880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x70A37D0", Offset = "0x70A23D0", VA = "0x1870A37D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private static readonly EEGEMFOKJOP GKJBHEJKION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly int CJKKEGNGHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	[CanBeNull]
	private readonly NFDGGMAMIAG DDNEDFLHLJM;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x709B6C0", Offset = "0x709A2C0", VA = "0x18709B6C0")]
	public FGMOFBPLHCO(Guid FEHGEPPCEAL, CJIDFPHHKMP NLLMJKJPILF, int CJKKEGNGHEM, NFDGGMAMIAG DDNEDFLHLJM, LMPPFDJJNDM NGAIIMAHPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x709B4D0", Offset = "0x709A0D0", VA = "0x18709B4D0", Slot = "8")]
	[AsyncStateMachine(typeof(KCDFEBFHCGE))]
	protected override Task OFKCELENHNA(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x709B200", Offset = "0x7099E00", VA = "0x18709B200")]
	private void CFHMIEHOPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x709B300", Offset = "0x7099F00", VA = "0x18709B300")]
	private void GADJGAMHEJI(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, LEDBKEPMGME LKKADIAOGCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal abstract class PJLMCOBICGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public readonly HFKGHGOGEPA IHCMBAJLKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public readonly MNBHHFEPHJK MKABOBAECJH;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x70AC4C0", Offset = "0x70AB0C0", VA = "0x1870AC4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x70AC510", Offset = "0x70AB110", VA = "0x1870AC510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x70AC6C0", Offset = "0x70AB2C0", VA = "0x1870AC6C0")]
	protected PJLMCOBICGK(MNBHHFEPHJK MMHDADPGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x70AC5A0", Offset = "0x70AB1A0", VA = "0x1870AC5A0")]
	protected void IOIJAALEDGI(string JJJOBBAHKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct OIJMIDCCAOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public Dictionary<Guid, List<IPNJHAFAMON>> FEFFMDOEMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public Dictionary<Guid, List<IPNJHAFAMON>> KGCBAPBKEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Dictionary<Guid, List<IPNJHAFAMON>> DCLIJOAAAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public List<Guid> AICEEFGIIIL;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x70AB5F0", Offset = "0x70AA1F0", VA = "0x1870AB5F0")]
	public static OIJMIDCCAOM OIPGNBHOLEB(NOIFJHBLDNB JMKPKEHPNLL, NCHCAFBDJHO FFMMCOIOJKL, FMPKCMJJJBG ILFFINKGJLM)
	{
		return default(OIJMIDCCAOM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct HIAAMOMGJHM
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	public static HIAAMOMGJHM NCPDNLLGMJA()
	{
		return default(HIAAMOMGJHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct MLMNMELPJNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly PFJIJEDBGEL LMMFGIBEDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly BDNCLMIKGDE AJHGJCFJGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public readonly string NAAIFMFBNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public readonly OHEPJFMFHIA BJKFDJBGPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public readonly OHEPJFMFHIA AKHAPOCCMLF;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x70A59B0", Offset = "0x70A45B0", VA = "0x1870A59B0")]
	public MLMNMELPJNG(PFJIJEDBGEL LMMFGIBEDHB, BDNCLMIKGDE AJHGJCFJGEA, string NAAIFMFBNFA, OHEPJFMFHIA BJKFDJBGPCA, OHEPJFMFHIA AKHAPOCCMLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct GGDIEMOFOIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly MNBHHFEPHJK MMHDADPGDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly Guid OCPFIICCALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private bool OBJBDHJNFNO;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x709D370", Offset = "0x709BF70", VA = "0x18709D370")]
	public static GGDIEMOFOIK MBOAHIPPIGN(MNBHHFEPHJK MMHDADPGDPE)
	{
		return default(GGDIEMOFOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x9AAB80", Offset = "0x9A9780", VA = "0x1809AAB80")]
	public void FAINBAPBNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x709D080", Offset = "0x709BC80", VA = "0x18709D080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x709D3A0", Offset = "0x709BFA0", VA = "0x18709D3A0")]
	private GGDIEMOFOIK(MNBHHFEPHJK MMHDADPGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x709D090", Offset = "0x709BC90", VA = "0x18709D090")]
	private void EBPIPGOMECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x709D2D0", Offset = "0x709BED0", VA = "0x18709D2D0")]
	private Func<Guid, bool> HCGDDMIGMLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class NNBCMEIMDBN : PJLMCOBICGK, CCMLBAANCBG
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public delegate Task<NCHCAFBDJHO> NEGCPCOIDGH(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD LMGEFDALHFM, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct LJHPMMDHDID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public LDKNGEJJMKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private GGDIEMOFOIK <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x70A4220", Offset = "0x70A2E20", VA = "0x1870A4220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x70A4990", Offset = "0x70A3590", VA = "0x1870A4990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct GDPMKBPFBMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public LDKNGEJJMKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private BILFBGGHINK<string>.OADHIEPGLKH <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x709C9A0", Offset = "0x709B5A0", VA = "0x18709C9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x709CDC0", Offset = "0x709B9C0", VA = "0x18709CDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct FMDLDIGLMBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public LDKNGEJJMKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private BILFBGGHINK<string>.OADHIEPGLKH <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x709C370", Offset = "0x709AF70", VA = "0x18709C370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x709C800", Offset = "0x709B400", VA = "0x18709C800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class JPJKOJFFPKF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public AsyncTaskMethodBuilder<MLMNMELPJNG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public JPJKOJFFPKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private MLMNMELPJNG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private TaskAwaiter<NCHCAFBDJHO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private TaskAwaiter<MLMNMELPJNG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x70AC9C0", Offset = "0x70AB5C0", VA = "0x1870AC9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x70AD120", Offset = "0x70ABD20", VA = "0x1870AD120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public AsyncTaskMethodBuilder<FMPKCMJJJBG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public JPJKOJFFPKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			private FMPKCMJJJBG <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			private TaskAwaiter<NCHCAFBDJHO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			private TaskAwaiter<FMPKCMJJJBG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x70AD190", Offset = "0x70ABD90", VA = "0x1870AD190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x70AD7C0", Offset = "0x70AC3C0", VA = "0x1870AD7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public LDKNGEJJMKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public GIHGFNFLHKF preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public GIHGFNFLHKF downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public MLMNMELPJNG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public GIHGFNFLHKF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public FMPKCMJJJBG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public GIKOGMFDNKG.PJEBEAMJHKL <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JPJKOJFFPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x70A2320", Offset = "0x70A0F20", VA = "0x1870A2320")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<MLMNMELPJNG> AFECBHGDEJG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x70A2760", Offset = "0x70A1360", VA = "0x1870A2760")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<FMPKCMJJJBG> PJCIIMFMOIL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x70A2460", Offset = "0x70A1060", VA = "0x1870A2460")]
		internal void KAEJBGOLIKI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x70A24A0", Offset = "0x70A10A0", VA = "0x1870A24A0")]
		internal Task KEKIGEHFENF(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x70A2600", Offset = "0x70A1200", VA = "0x1870A2600")]
		internal Task KLKLDLMGBPJ(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct FDGAANGPJBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public LDKNGEJJMKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private JPJKOJFFPKF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter<MLMNMELPJNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<FMPKCMJJJBG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7099560", Offset = "0x7098160", VA = "0x187099560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x709A2B0", Offset = "0x7098EB0", VA = "0x18709A2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct NDDLAIHMOFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public FMPKCMJJJBG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public GIHGFNFLHKF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private EBAJMIFAHFD <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x70A6F60", Offset = "0x70A5B60", VA = "0x1870A6F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x70A7DF0", Offset = "0x70A69F0", VA = "0x1870A7DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct HJHIEHLJGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x709F880", Offset = "0x709E480", VA = "0x18709F880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x70A0130", Offset = "0x709ED30", VA = "0x1870A0130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct IPNLCBCHGNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private BILFBGGHINK<string>.OADHIEPGLKH <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x70A13D0", Offset = "0x709FFD0", VA = "0x1870A13D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x70A1D50", Offset = "0x70A0950", VA = "0x1870A1D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct GPBJAOLNMEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private BILFBGGHINK<string>.OADHIEPGLKH <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x709D5B0", Offset = "0x709C1B0", VA = "0x18709D5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x709E750", Offset = "0x709D350", VA = "0x18709E750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct CBBPGGGBKLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public EBAJMIFAHFD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private BILFBGGHINK<string>.OADHIEPGLKH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7096C40", Offset = "0x7095840", VA = "0x187096C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7097D30", Offset = "0x7096930", VA = "0x187097D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct OMJBAICJLMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public NCHCAFBDJHO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public FMPKCMJJJBG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x70ABE00", Offset = "0x70AAA00", VA = "0x1870ABE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x70AC090", Offset = "0x70AAC90", VA = "0x1870AC090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class AIOINLMMJEK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			public AIOINLMMJEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			private ICAIGABDHPB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			private TaskAwaiter<NCHCAFBDJHO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x70AD830", Offset = "0x70AC430", VA = "0x1870AD830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x70ADE50", Offset = "0x70ACA50", VA = "0x1870ADE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public NEGCPCOIDGH masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public EBAJMIFAHFD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public NCHCAFBDJHO originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public AIOINLMMJEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7095310", Offset = "0x7093F10", VA = "0x187095310")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<NCHCAFBDJHO> HMEKPOHIPDO(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct JDAGHNJJLEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public NEGCPCOIDGH masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public EBAJMIFAHFD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x70A1DB0", Offset = "0x70A09B0", VA = "0x1870A1DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x70A22B0", Offset = "0x70A0EB0", VA = "0x1870A22B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct MCHJOGDEADC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private NCHCAFBDJHO <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private IEnumerator<NCHCAFBDJHO> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x70A5430", Offset = "0x70A4030", VA = "0x1870A5430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x70A5950", Offset = "0x70A4550", VA = "0x1870A5950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct IIKPNEKJCHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x70A0510", Offset = "0x709F110", VA = "0x1870A0510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x70A0730", Offset = "0x709F330", VA = "0x1870A0730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct OINJJJOAFBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x70ABC00", Offset = "0x70AA800", VA = "0x1870ABC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x70ABDA0", Offset = "0x70AA9A0", VA = "0x1870ABDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct FELHPEJKJFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public FMPKCMJJJBG phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public GIHGFNFLHKF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private EBAJMIFAHFD <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x709A310", Offset = "0x7098F10", VA = "0x18709A310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x709B1A0", Offset = "0x7099DA0", VA = "0x18709B1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct OJIOLEOLMBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public NNBCMEIMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public GIHGFNFLHKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x70C4D10", Offset = "0x70C3910", VA = "0x1870C4D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x70C5770", Offset = "0x70C4370", VA = "0x1870C5770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly EPIDMNHCALL MICIKIOMOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly EPIDMNHCALL OFBHILBHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly DNMCGKCDFPB DCEGKJJJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly IHJOLHHMIJA IGEANLGBCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly GPGMPGCEMOA FOMALFJHIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly OPCJIBBMPKM FOEAEALGFNC;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private CJIDFPHHKMP NHOIHAIKBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x70A8740", Offset = "0x70A7340", VA = "0x1870A8740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PBMPNMINHOB LGDNHOHICAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x70A8FF0", Offset = "0x70A7BF0", VA = "0x1870A8FF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x70A88D0", Offset = "0x70A74D0", VA = "0x1870A88D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x70AA010", Offset = "0x70A8C10", VA = "0x1870AA010")]
	public NNBCMEIMDBN(MNBHHFEPHJK MMHDADPGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x70A8D50", Offset = "0x70A7950", VA = "0x1870A8D50")]
	[AsyncStateMachine(typeof(LJHPMMDHDID))]
	public Task EMDEOIHOKJG(LDKNGEJJMKB KAIGMLIOMBJ, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x70A9D20", Offset = "0x70A8920", VA = "0x1870A9D20")]
	[AsyncStateMachine(typeof(GDPMKBPFBMM))]
	private Task<LJGJBLECALO> OKMBICLDPOD(LDKNGEJJMKB KAIGMLIOMBJ, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x70A9430", Offset = "0x70A8030", VA = "0x1870A9430")]
	[AsyncStateMachine(typeof(FMDLDIGLMBE))]
	private Task LFHCICFGHNO(LDKNGEJJMKB KAIGMLIOMBJ, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x70A8AC0", Offset = "0x70A76C0", VA = "0x1870A8AC0")]
	[AsyncStateMachine(typeof(FDGAANGPJBJ))]
	private Task ECIADIJHMLP(LDKNGEJJMKB KAIGMLIOMBJ, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken BAGPBGMHIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x70A92E0", Offset = "0x70A7EE0", VA = "0x1870A92E0")]
	[AsyncStateMachine(typeof(NDDLAIHMOFK))]
	private Task LAMLOMOCKPF(FMPKCMJJJBG GOJMIDCHKIF, GIHGFNFLHKF PIGLLFPPOMI, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken JACNHEKPBHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x70A96F0", Offset = "0x70A82F0", VA = "0x1870A96F0")]
	[AsyncStateMachine(typeof(HJHIEHLJGJI))]
	private Task LKCNADHKOGJ(BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x70A8C00", Offset = "0x70A7800", VA = "0x1870A8C00")]
	[AsyncStateMachine(typeof(IPNLCBCHGNN))]
	private Task EEJKCACHJNF(FMPKCMJJJBG JGFKFMMOAJO, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x70A9140", Offset = "0x70A7D40", VA = "0x1870A9140")]
	[AsyncStateMachine(typeof(GPBJAOLNMEL))]
	private Task<NCHCAFBDJHO> JIDJKHLCLFE(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x70A9E80", Offset = "0x70A8A80", VA = "0x1870A9E80")]
	[AsyncStateMachine(typeof(CBBPGGGBKLJ))]
	private Task<NCHCAFBDJHO> OPEHPGNPNPF(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x70A9570", Offset = "0x70A8170", VA = "0x1870A9570")]
	[AsyncStateMachine(typeof(OMJBAICJLMB))]
	private Task<NCHCAFBDJHO> LHDACJAIDJH(NCHCAFBDJHO FFMMCOIOJKL, FMPKCMJJJBG ILFFINKGJLM, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG, bool MBMIPLHHJKA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x70A8F00", Offset = "0x70A7B00", VA = "0x1870A8F00")]
	private bool HBBABHJOLPJ(FMPKCMJJJBG GOJMIDCHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x70A9800", Offset = "0x70A8400", VA = "0x1870A9800")]
	[AsyncStateMachine(typeof(JDAGHNJJLEE))]
	protected Task<NCHCAFBDJHO> MPJONBIKICC(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG, NEGCPCOIDGH BBKANMGMBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x70A8930", Offset = "0x70A7530", VA = "0x1870A8930")]
	[AsyncStateMachine(typeof(MCHJOGDEADC))]
	private Task DHGJEAKHLNI(FMPKCMJJJBG JGFKFMMOAJO, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x70A9CD0", Offset = "0x70A88D0", VA = "0x1870A9CD0")]
	private void OJCAMJLEAJN(NCHCAFBDJHO AFCJOJKPIFG, GIHGFNFLHKF BIDLOCGENIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x70A8A80", Offset = "0x70A7680", VA = "0x1870A8A80")]
	private void DLOALKAFAHN(NCHCAFBDJHO NIMFCDFLOMJ, [Out] NCHCAFBDJHO PJMDBAJDOFN, [Out] NCHCAFBDJHO NJHJMELADND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x70A9100", Offset = "0x70A7D00", VA = "0x1870A9100")]
	private Task<MLMNMELPJNG> IOAFCIKEDMA(LDKNGEJJMKB KAIGMLIOMBJ, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x70A92A0", Offset = "0x70A7EA0", VA = "0x1870A92A0")]
	private Task<FMPKCMJJJBG> JPHAGAMPKPH(MLMNMELPJNG JGFKFMMOAJO, GIKOGMFDNKG.PJEBEAMJHKL KOJNIOJEBAB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x70A9B10", Offset = "0x70A8710", VA = "0x1870A9B10")]
	[AsyncStateMachine(typeof(IIKPNEKJCHN))]
	private Task NLIBPHDBEIH(FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG, bool ACLIMNOBFIL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x70A9010", Offset = "0x70A7C10", VA = "0x1870A9010")]
	[AsyncStateMachine(typeof(OINJJJOAFBA))]
	private Task IDCAHMNPNMP(FMPKCMJJJBG JGFKFMMOAJO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x70A9AE0", Offset = "0x70A86E0", VA = "0x1870A9AE0")]
	private Task NCMLAMMCFMA(FMPKCMJJJBG JGFKFMMOAJO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x70A8EA0", Offset = "0x70A7AA0", VA = "0x1870A8EA0")]
	private Task FEKAIDHHEJL(FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x70A9C60", Offset = "0x70A8860", VA = "0x1870A9C60")]
	private Task NNJJKLNDBBF(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x70A8910", Offset = "0x70A7510", VA = "0x1870A8910")]
	private Task CKJLJAEIHFG(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x70AA000", Offset = "0x70A8C00", VA = "0x1870AA000")]
	private static Task PFMPJKJJNGJ(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x70A8EE0", Offset = "0x70A7AE0", VA = "0x1870A8EE0")]
	private Task GLPOGMMLKIM(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x70A8EC0", Offset = "0x70A7AC0", VA = "0x1870A8EC0")]
	private Task FOEEGLMGGKF(FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x70A9C80", Offset = "0x70A8880", VA = "0x1870A9C80")]
	private void OAFMDLKJPPB(LDKNGEJJMKB KAIGMLIOMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x70A88F0", Offset = "0x70A74F0", VA = "0x1870A88F0")]
	public void CGJPFCMPNKJ(long PGCBOFIMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void FAGAAAKGMBP(PFJIJEDBGEL LMMFGIBEDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x70A9990", Offset = "0x70A8590", VA = "0x1870A9990")]
	[AsyncStateMachine(typeof(FELHPEJKJFP))]
	private Task NBAACPDLIGJ(FMPKCMJJJBG GOJMIDCHKIF, GIHGFNFLHKF PIGLLFPPOMI, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken JACNHEKPBHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x70A8770", Offset = "0x70A7370", VA = "0x1870A8770")]
	[AsyncStateMachine(typeof(OJIOLEOLMBA))]
	[CompilerGenerated]
	private Task<NCHCAFBDJHO> BIBJPINHDLF(FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, GIHGFNFLHKF BIDLOCGENIB, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct DIOGIDKPEHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private FMPKCMJJJBG JGFKFMMOAJO;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x70B3850", Offset = "0x70B2450", VA = "0x1870B3850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x70B3AB0", Offset = "0x70B26B0", VA = "0x1870B3AB0")]
	public static Task MGFNPLKOLEC(CJIDFPHHKMP NLLMJKJPILF, FMPKCMJJJBG JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x70B38A0", Offset = "0x70B24A0", VA = "0x1870B38A0")]
	private void MGFNPLKOLEC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct HLBHLMKKEDL
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x70B8940", Offset = "0x70B7540", VA = "0x1870B8940")]
	public static Task MGFNPLKOLEC(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct CNIGNNDGLFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct CMPIPDCEDCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private BILFBGGHINK<string>.OADHIEPGLKH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x70B3120", Offset = "0x70B1D20", VA = "0x1870B3120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x70B3640", Offset = "0x70B2240", VA = "0x1870B3640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x70B36A0", Offset = "0x70B22A0", VA = "0x1870B36A0")]
	[AsyncStateMachine(typeof(CMPIPDCEDCJ))]
	public static Task MGFNPLKOLEC(MNBHHFEPHJK MMHDADPGDPE, FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct HAGOGMEHBKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct AKFACJHBDDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public EBAJMIFAHFD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private NCHCAFBDJHO <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private CJIDFPHHKMP <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private NOIFJHBLDNB <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private ICAIGABDHPB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private List<(PersistenceView, KPIIJEHPKNN)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private KPIIJEHPKNN <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x70B0360", Offset = "0x70AEF60", VA = "0x1870B0360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x70B0FE0", Offset = "0x70AFBE0", VA = "0x1870B0FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x70B7AA0", Offset = "0x70B66A0", VA = "0x1870B7AA0")]
	[AsyncStateMachine(typeof(AKFACJHBDDH))]
	public static Task MGFNPLKOLEC(MNBHHFEPHJK MMHDADPGDPE, FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x70B78A0", Offset = "0x70B64A0", VA = "0x1870B78A0")]
	private static void HJJJGIHOPFC(PersistenceView MJEDEOCFGKA, KPIIJEHPKNN GLDBNLEBGAB, FMPKCMJJJBG JGFKFMMOAJO, NCHCAFBDJHO FFMMCOIOJKL, bool JEDEDJKFPJN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct MMIFMDILFNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct MIGCLCOJMOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CJIDFPHHKMP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x70C1CD0", Offset = "0x70C08D0", VA = "0x1870C1CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x70C2100", Offset = "0x70C0D00", VA = "0x1870C2100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x70C2160", Offset = "0x70C0D60", VA = "0x1870C2160")]
	[AsyncStateMachine(typeof(MIGCLCOJMOC))]
	public static Task MGFNPLKOLEC(CJIDFPHHKMP NLLMJKJPILF, FMPKCMJJJBG JGFKFMMOAJO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct PABPDJCKBIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct MDHKGIKBCLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public CJIDFPHHKMP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x70C1A60", Offset = "0x70C0660", VA = "0x1870C1A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x70C1C70", Offset = "0x70C0870", VA = "0x1870C1C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class AIEHNFAJBOK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public BILFBGGHINK<string>.OADHIEPGLKH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public AIEHNFAJBOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x70C7450", Offset = "0x70C6050", VA = "0x1870C7450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x70C77E0", Offset = "0x70C63E0", VA = "0x1870C77E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public AIEHNFAJBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x70AFC90", Offset = "0x70AE890", VA = "0x1870AFC90")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task JPMJLIFAGGH(BILFBGGHINK<string>.OADHIEPGLKH timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct CKOKGNNNNAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public PABPDJCKBIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x70B2700", Offset = "0x70B1300", VA = "0x1870B2700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x70B30C0", Offset = "0x70B1CC0", VA = "0x1870B30C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class LFNNICDPPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public OPBPGNGHMAL version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LFNNICDPPMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x70C0240", Offset = "0x70BEE40", VA = "0x1870C0240")]
		internal object IMJDBJIPGJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x70C0190", Offset = "0x70BED90", VA = "0x1870C0190")]
		internal object FDDCLHFHFIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private FMPKCMJJJBG JGFKFMMOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private MNBHHFEPHJK MMHDADPGDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private bool ACLIMNOBFIL;

	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private static readonly ByteString CBCMMIOADKB;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x70C5940", Offset = "0x70C4540", VA = "0x1870C5940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private ICMEFODLEGE LPLNHMHNAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x70C5990", Offset = "0x70C4590", VA = "0x1870C5990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x70C6200", Offset = "0x70C4E00", VA = "0x1870C6200")]
	[AsyncStateMachine(typeof(MDHKGIKBCLA))]
	public static Task MGFNPLKOLEC(CJIDFPHHKMP NLLMJKJPILF, FMPKCMJJJBG JGFKFMMOAJO, MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG, bool ACLIMNOBFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x70C60C0", Offset = "0x70C4CC0", VA = "0x1870C60C0")]
	[AsyncStateMachine(typeof(CKOKGNNNNAF))]
	private Task MGFNPLKOLEC(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x70C5A30", Offset = "0x70C4630", VA = "0x1870C5A30")]
	private void DLLDBJOKELI([NotNull] KDDAPCIFEMM KDOIJJFLEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x70C6350", Offset = "0x70C4F50", VA = "0x1870C6350")]
	private bool NMLGNGIHHKI(OPBPGNGHMAL FAEMFOKJHDK, KDDAPCIFEMM KDOIJJFLEJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct EKBMCFNEEAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct OEGELIKHFBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<FMPKCMJJJBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public EKBMCFNEEAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public GIKOGMFDNKG.PJEBEAMJHKL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private BILFBGGHINK<string>.OADHIEPGLKH <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<(NLDGPBPIIJN<PIHPEOKKDFC, LGLBGBDJHMM>, NLDGPBPIIJN<PGFHMCKFNEA<KDDAPCIFEMM>, LGLBGBDJHMM>, NLDGPBPIIJN<PGFHMCKFNEA<ONEEHEFMPOC>, LGLBGBDJHMM>, NLDGPBPIIJN<PGFHMCKFNEA<HMLFEFILMLH>, LGLBGBDJHMM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x70C3370", Offset = "0x70C1F70", VA = "0x1870C3370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x70C3E20", Offset = "0x70C2A20", VA = "0x1870C3E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct JPACGHBAKNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<PIHPEOKKDFC, LGLBGBDJHMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public BILFBGGHINK<string>.OADHIEPGLKH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public EKBMCFNEEAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public GIKOGMFDNKG.PJEBEAMJHKL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<NLDGPBPIIJN<PIHPEOKKDFC, LGLBGBDJHMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x70BC0D0", Offset = "0x70BACD0", VA = "0x1870BC0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x70BC6E0", Offset = "0x70BB2E0", VA = "0x1870BC6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private MIFAOFJNDND<OHEPJFMFHIA, ONEEHEFMPOC> DOMLMMOOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private MIFAOFJNDND<OHEPJFMFHIA, KDDAPCIFEMM> LNCAIFCNBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private MIFAOFJNDND<long, HMLFEFILMLH> CFGIDPCAMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private ICJKGANAPPC EJDJCIJEAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private PFJIJEDBGEL LMMFGIBEDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private BDNCLMIKGDE AJHGJCFJGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private string NAAIFMFBNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private OHEPJFMFHIA BJKFDJBGPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private OHEPJFMFHIA AKHAPOCCMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private long PGCBOFIMNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x70B4410", Offset = "0x70B3010", VA = "0x1870B4410")]
	public static Task<FMPKCMJJJBG> OAAEIMAEMMC(CJIDFPHHKMP NLLMJKJPILF, [In] MLMNMELPJNG JGFKFMMOAJO, GIKOGMFDNKG.PJEBEAMJHKL KOJNIOJEBAB, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x70B4280", Offset = "0x70B2E80", VA = "0x1870B4280")]
	[AsyncStateMachine(typeof(OEGELIKHFBM))]
	private Task<FMPKCMJJJBG> MGFNPLKOLEC(GIKOGMFDNKG.PJEBEAMJHKL KOJNIOJEBAB, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x70B40C0", Offset = "0x70B2CC0", VA = "0x1870B40C0")]
	[AsyncStateMachine(typeof(JPACGHBAKNJ))]
	private Task<NLDGPBPIIJN<PIHPEOKKDFC, LGLBGBDJHMM>> FLPFCIHLJMB(string NAAIFMFBNFA, long PGCBOFIMNFK, long? ACIHEOIHPAO, long? GPDLAAEANOD, GIKOGMFDNKG.PJEBEAMJHKL KOJNIOJEBAB, BILFBGGHINK<string>.OADHIEPGLKH PLFLEMHLEMN, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct LHJPOMJOIIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct ADHGBJFMOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<MLMNMELPJNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public LHJPOMJOIIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private BILFBGGHINK<string>.OADHIEPGLKH <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<MLMNMELPJNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x70AE760", Offset = "0x70AD360", VA = "0x1870AE760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x70AEB60", Offset = "0x70AD760", VA = "0x1870AEB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct POOJHICLIPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<MLMNMELPJNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public LHJPOMJOIIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<MLMNMELPJNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x70C6A90", Offset = "0x70C5690", VA = "0x1870C6A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x70C6EC0", Offset = "0x70C5AC0", VA = "0x1870C6EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class HAOCIHNBGGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public HAOCIHNBGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x9499C0", Offset = "0x9485C0", VA = "0x1809499C0")]
		internal bool CAFAKBPOIKD(BDNCLMIKGDE sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct KMGJNFKOMIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder<MLMNMELPJNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public OHEPJFMFHIA superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public NOIFJHBLDNB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private HAOCIHNBGGC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public MFCLJJEJGJM roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private PFJIJEDBGEL <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private BDNCLMIKGDE <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private OHEPJFMFHIA <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private OHEPJFMFHIA <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<PFJIJEDBGEL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<EICFOOOCNLM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter<BCBONPLPCBB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x70BDC80", Offset = "0x70BC880", VA = "0x1870BDC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x70BEDB0", Offset = "0x70BD9B0", VA = "0x1870BEDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private DNMCGKCDFPB DCEGKJJJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private MFCLJJEJGJM ABNGIIMBEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private long ACIHEOIHPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private long EPCPKKDEADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private long PKBFBDMOBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private string OJBGLCHEJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private OHEPJFMFHIA OGOPJNDHIDM;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x70C07A0", Offset = "0x70BF3A0", VA = "0x1870C07A0")]
	public static Task<MLMNMELPJNG> OAAEIMAEMMC(CJIDFPHHKMP NLLMJKJPILF, LDKNGEJJMKB KAIGMLIOMBJ, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x70C0650", Offset = "0x70BF250", VA = "0x1870C0650")]
	[AsyncStateMachine(typeof(ADHGBJFMOGM))]
	private Task<MLMNMELPJNG> MGFNPLKOLEC(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x70C04F0", Offset = "0x70BF0F0", VA = "0x1870C04F0")]
	[AsyncStateMachine(typeof(POOJHICLIPE))]
	private Task<MLMNMELPJNG> IOAFCIKEDMA(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x70C0350", Offset = "0x70BEF50", VA = "0x1870C0350")]
	[AsyncStateMachine(typeof(KMGJNFKOMIG))]
	private static Task<MLMNMELPJNG> IOAFCIKEDMA(NOIFJHBLDNB JMKPKEHPNLL, MFCLJJEJGJM ABNGIIMBEMA, long ACIHEOIHPAO, long EPCPKKDEADD, long PKBFBDMOBEE, string OJBGLCHEJIB, OHEPJFMFHIA OGOPJNDHIDM, CancellationToken PPKBAEMFIMG, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x70C0320", Offset = "0x70BEF20", VA = "0x1870C0320")]
	private void BDJNFONCGNC(PFJIJEDBGEL LMMFGIBEDHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct FGBKOIKPNDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct GKFKAPGFEHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public FGBKOIKPNDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x70B6B90", Offset = "0x70B5790", VA = "0x1870B6B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x70B7120", Offset = "0x70B5D20", VA = "0x1870B7120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private FMPKCMJJJBG JGFKFMMOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private float HHNHKKOHGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private float BEIOOLHCEOC;

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x70B4D00", Offset = "0x70B3900", VA = "0x1870B4D00")]
	public static Task CCLAMDBLCPP(CJIDFPHHKMP NLLMJKJPILF, FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x70B50C0", Offset = "0x70B3CC0", VA = "0x1870B50C0")]
	[AsyncStateMachine(typeof(GKFKAPGFEHG))]
	public Task MGFNPLKOLEC(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x70B4F80", Offset = "0x70B3B80", VA = "0x1870B4F80")]
	private static void EJKIIODDEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x70B51E0", Offset = "0x70B3DE0", VA = "0x1870B51E0")]
	private void PLMMOLOLIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x70B4EA0", Offset = "0x70B3AA0", VA = "0x1870B4EA0")]
	private static float CGNAADAEHFD(NOIFJHBLDNB JMKPKEHPNLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x70B4F60", Offset = "0x70B3B60", VA = "0x1870B4F60")]
	private static float EAEMOIBAAPM()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct CHJLAKOIGKO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct IIGJGJPNIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public MNBHHFEPHJK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private HFKGHGOGEPA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private CJIDFPHHKMP <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private LJGEMBBNDJM.NCELDEMJFHL <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x70B9980", Offset = "0x70B8580", VA = "0x1870B9980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x70BA1A0", Offset = "0x70B8DA0", VA = "0x1870BA1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct CACOMDNJFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x70B2140", Offset = "0x70B0D40", VA = "0x1870B2140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x70B2430", Offset = "0x70B1030", VA = "0x1870B2430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x70B2500", Offset = "0x70B1100", VA = "0x1870B2500")]
	[AsyncStateMachine(typeof(IIGJGJPNIDM))]
	public static Task MGFNPLKOLEC(MNBHHFEPHJK MMHDADPGDPE, FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x70B2490", Offset = "0x70B1090", VA = "0x1870B2490")]
	private static Task<LJGJBLECALO> FAMCFHMFCOH(MNBHHFEPHJK MMHDADPGDPE, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x70B2640", Offset = "0x70B1240", VA = "0x1870B2640")]
	[AsyncStateMachine(typeof(CACOMDNJFDC))]
	private static Task PCEODDHPELK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct OJDINHCGECJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct JPPLGHKJJAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public OJDINHCGECJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x70BC750", Offset = "0x70BB350", VA = "0x1870BC750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x70BCE00", Offset = "0x70BBA00", VA = "0x1870BCE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class HBPAECOFDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public HBPAECOFDPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x70B7BF0", Offset = "0x70B67F0", VA = "0x1870B7BF0")]
		internal object IFKLCEDIMJN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct KGLOMBGGGOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public OJDINHCGECJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x70BD770", Offset = "0x70BC370", VA = "0x1870BD770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x70BDBD0", Offset = "0x70BC7D0", VA = "0x1870BDBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private bool PMGJPIDKKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private CancellationToken PPKBAEMFIMG;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x70C4CA0", Offset = "0x70C38A0", VA = "0x1870C4CA0")]
	public static Task MHOGJINCEMI(CJIDFPHHKMP NLLMJKJPILF, bool PMGJPIDKKPF, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken BLBAEPMDGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x70C4BB0", Offset = "0x70C37B0", VA = "0x1870C4BB0")]
	[AsyncStateMachine(typeof(JPPLGHKJJAD))]
	private Task MGFNPLKOLEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x70C4A80", Offset = "0x70C3680", VA = "0x1870C4A80")]
	[AsyncStateMachine(typeof(KGLOMBGGGOJ))]
	private Task CDANNHKOMIO(bool FDDFPCHCEPO, string NBBJMMGJPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	private bool MDIANAJNHJO(bool PMGJPIDKKPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct GPEINIKGFAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct LCBCPIONAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public GPEINIKGFAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x70BF510", Offset = "0x70BE110", VA = "0x1870BF510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x70BFA80", Offset = "0x70BE680", VA = "0x1870BFA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class FHEDKKJEELE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FHEDKKJEELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x70B5340", Offset = "0x70B3F40", VA = "0x1870B5340")]
		internal object IFKLCEDIMJN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct OHMINANPEMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public GPEINIKGFAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x70C4580", Offset = "0x70C3180", VA = "0x1870C4580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x70C4A10", Offset = "0x70C3610", VA = "0x1870C4A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private MLBOJMFALEE BOPJEOIADGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool HHCOBBDBCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private FMPKCMJJJBG JGFKFMMOAJO;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x70B7340", Offset = "0x70B5F40", VA = "0x1870B7340")]
	public static Task<Scene> JAAKOABELBD(CJIDFPHHKMP NLLMJKJPILF, MLBOJMFALEE NPOKHKADDOE, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x70B73F0", Offset = "0x70B5FF0", VA = "0x1870B73F0")]
	[AsyncStateMachine(typeof(LCBCPIONAAM))]
	private Task<Scene> MGFNPLKOLEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x70B73C0", Offset = "0x70B5FC0", VA = "0x1870B73C0")]
	private bool KEICIOCNLFP(FMPKCMJJJBG JGFKFMMOAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x70B72D0", Offset = "0x70B5ED0", VA = "0x1870B72D0")]
	private void HCONCPPGLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x70B7180", Offset = "0x70B5D80", VA = "0x1870B7180")]
	[AsyncStateMachine(typeof(OHMINANPEMC))]
	private Task<Scene> CDANNHKOMIO(string NBBJMMGJPJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct GPGMPGCEMOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct IIMMKBAHHJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public GPGMPGCEMOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public NCHCAFBDJHO nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public FMPKCMJJJBG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private BILFBGGHINK<string>.OADHIEPGLKH <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<NCHCAFBDJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x70BA200", Offset = "0x70B8E00", VA = "0x1870BA200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x70BACE0", Offset = "0x70B98E0", VA = "0x1870BACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct DOABIBFKACG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AsyncTaskMethodBuilder<NCHCAFBDJHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public GPGMPGCEMOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public NCHCAFBDJHO state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x70B3B90", Offset = "0x70B2790", VA = "0x1870B3B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x70B3E70", Offset = "0x70B2A70", VA = "0x1870B3E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly MNBHHFEPHJK MMHDADPGDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly DNMCGKCDFPB DCEGKJJJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private readonly IHJOLHHMIJA IGEANLGBCMI;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private HFKGHGOGEPA IHCMBAJLKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x57C2560", Offset = "0x57C1160", VA = "0x1857C2560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x70B7840", Offset = "0x70B6440", VA = "0x1870B7840")]
	public GPGMPGCEMOA(MNBHHFEPHJK MMHDADPGDPE, DNMCGKCDFPB DCEGKJJJGME, IHJOLHHMIJA IGEANLGBCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x70B76A0", Offset = "0x70B62A0", VA = "0x1870B76A0")]
	[AsyncStateMachine(typeof(IIMMKBAHHJN))]
	public Task<NCHCAFBDJHO> IJJCCJOMJCC(NCHCAFBDJHO BONCDMCHHMA, FMPKCMJJJBG ILFFINKGJLM, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG, bool MBMIPLHHJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x70B7540", Offset = "0x70B6140", VA = "0x1870B7540")]
	[AsyncStateMachine(typeof(DOABIBFKACG))]
	private Task<NCHCAFBDJHO> DMCCEKIJMCB(BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, NCHCAFBDJHO FFBJIDDDHKC, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x70B7510", Offset = "0x70B6110", VA = "0x1870B7510")]
	private bool AFOLLBLMCKF(NCHCAFBDJHO AFIHAHJEFJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x70B7820", Offset = "0x70B6420", VA = "0x1870B7820")]
	private void IOIJAALEDGI(string NPDAJLMKBPH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct FONOIMPCHKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct HDNHJCDOBEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public HFKGHGOGEPA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public EBAJMIFAHFD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private ICAIGABDHPB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private List<(PersistenceView, KPIIJEHPKNN)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private (PersistenceView, KPIIJEHPKNN) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x70B7C70", Offset = "0x70B6870", VA = "0x1870B7C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x70B8280", Offset = "0x70B6E80", VA = "0x1870B8280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x70B64F0", Offset = "0x70B50F0", VA = "0x1870B64F0")]
	[AsyncStateMachine(typeof(HDNHJCDOBEO))]
	public static Task MGFNPLKOLEC(HFKGHGOGEPA NBPBNEMNBCH, FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct HIBCNKCHAPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct AFMEAMNDMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public HFKGHGOGEPA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public EBAJMIFAHFD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private OPBPGNGHMAL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private ICAIGABDHPB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private List<(PersistenceView, KPIIJEHPKNN)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private KPIIJEHPKNN <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x70AF060", Offset = "0x70ADC60", VA = "0x1870AF060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x70AF8B0", Offset = "0x70AE4B0", VA = "0x1870AF8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x70B8800", Offset = "0x70B7400", VA = "0x1870B8800")]
	[AsyncStateMachine(typeof(AFMEAMNDMOK))]
	public static Task MGFNPLKOLEC(HFKGHGOGEPA NBPBNEMNBCH, FMPKCMJJJBG JGFKFMMOAJO, EBAJMIFAHFD CANEMHBBHML, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct LJGEMBBNDJM
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public struct NCELDEMJFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<KIHBGLDLAMF> BBNNFDJCGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<KPIIJEHPKNN> DLIJBFNKBFE;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
		public NCELDEMJFHL(List<KIHBGLDLAMF> BBNNFDJCGLI, List<KPIIJEHPKNN> DLIJBFNKBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class BANIIHIFNFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IEnumerable<KIHBGLDLAMF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BANIIHIFNFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x70B1040", Offset = "0x70AFC40", VA = "0x1870B1040")]
		internal object IHLLEAKNOFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private CJIDFPHHKMP NLLMJKJPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private FMPKCMJJJBG JGFKFMMOAJO;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private NOIFJHBLDNB PMNBJNPINMP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x70C09C0", Offset = "0x70BF5C0", VA = "0x1870C09C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x70C13E0", Offset = "0x70BFFE0", VA = "0x1870C13E0")]
	public static NCELDEMJFHL MGFNPLKOLEC(CJIDFPHHKMP NLLMJKJPILF, FMPKCMJJJBG JGFKFMMOAJO)
	{
		return default(NCELDEMJFHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x70C1190", Offset = "0x70BFD90", VA = "0x1870C1190")]
	private NCELDEMJFHL MGFNPLKOLEC()
	{
		return default(NCELDEMJFHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x70C0A10", Offset = "0x70BF610", VA = "0x1870C0A10")]
	private NCELDEMJFHL GIPFCNHBJOH(KDDAPCIFEMM KDOIJJFLEJM, OPBPGNGHMAL CCMHBLOOHPJ)
	{
		return default(NCELDEMJFHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x70C0FC0", Offset = "0x70BFBC0", VA = "0x1870C0FC0")]
	private bool HMPPGKNDNMM(IEnumerable<KIHBGLDLAMF> BBNNFDJCGLI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct AJPNDCPLJGE
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class EEGMJINMFGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public LJGEMBBNDJM.NCELDEMJFHL instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EEGMJINMFGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x70B3EE0", Offset = "0x70B2AE0", VA = "0x1870B3EE0")]
		internal object JPMJLIFAGGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class JHGEHLCJCMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JHGEHLCJCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x70BB960", Offset = "0x70BA560", VA = "0x1870BB960")]
		internal object APDMOALJLCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x70AFDB0", Offset = "0x70AE9B0", VA = "0x1870AFDB0")]
	public static void MGFNPLKOLEC(HFKGHGOGEPA NBPBNEMNBCH, FMPKCMJJJBG JGFKFMMOAJO, LJGEMBBNDJM.NCELDEMJFHL HEJGPHCJMGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal class IHJOLHHMIJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct NCAKIGCJMLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public NCHCAFBDJHO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public FMPKCMJJJBG deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x70C2270", Offset = "0x70C0E70", VA = "0x1870C2270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x70C29E0", Offset = "0x70C15E0", VA = "0x1870C29E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class GHMKOFAADDG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public GHMKOFAADDG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x70C7130", Offset = "0x70C5D30", VA = "0x1870C7130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x70C73F0", Offset = "0x70C5FF0", VA = "0x1870C73F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public BILFBGGHINK<string>.OADHIEPGLKH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GHMKOFAADDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x70B6AA0", Offset = "0x70B56A0", VA = "0x1870B6AA0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task DBIEOAKANIN(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct FBLOKFMFGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private GHMKOFAADDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x70B4770", Offset = "0x70B3370", VA = "0x1870B4770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x70B4CA0", Offset = "0x70B38A0", VA = "0x1870B4CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct KALOEOOGACL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Guid, List<IPNJHAFAMON>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x70BCE60", Offset = "0x70BBA60", VA = "0x1870BCE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x70BD410", Offset = "0x70BC010", VA = "0x1870BD410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct JIFOFKLFMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Dictionary<Guid, List<IPNJHAFAMON>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x70BB9F0", Offset = "0x70BA5F0", VA = "0x1870BB9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x70BC070", Offset = "0x70BAC70", VA = "0x1870BC070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class GBOHNOLBMMC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000172")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public IPNJHAFAMON handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public GBOHNOLBMMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x70C6F30", Offset = "0x70C5B30", VA = "0x1870C6F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x70C70D0", Offset = "0x70C5CD0", VA = "0x1870C70D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public MIEINJBBCJL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public List<IPNJHAFAMON> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GBOHNOLBMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x70B68C0", Offset = "0x70B54C0", VA = "0x1870B68C0")]
		internal object HPFNHGJMHIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x70B69B0", Offset = "0x70B55B0", VA = "0x1870B69B0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task JCJIINEMGBM(IPNJHAFAMON handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x70B67D0", Offset = "0x70B53D0", VA = "0x1870B67D0")]
		internal object HILLFLANBFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct JBIEMDKNGJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public MIEINJBBCJL runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public List<IPNJHAFAMON> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private GBOHNOLBMMC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x70BAD50", Offset = "0x70B9950", VA = "0x1870BAD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x70BB220", Offset = "0x70B9E20", VA = "0x1870BB220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct LNKEHLFFHEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public BILFBGGHINK<string>.OADHIEPGLKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x70C1440", Offset = "0x70C0040", VA = "0x1870C1440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x70C1A00", Offset = "0x70C0600", VA = "0x1870C1A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class DFOPAJHCCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public DFOPAJHCCMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x70B37E0", Offset = "0x70B23E0", VA = "0x1870B37E0")]
		internal object DPGIBINILEG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct HEIJPMPAMPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public FMPKCMJJJBG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x70B82E0", Offset = "0x70B6EE0", VA = "0x1870B82E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x70B87A0", Offset = "0x70B73A0", VA = "0x1870B87A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class BDNFDAPEIPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BDNFDAPEIPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x70B10C0", Offset = "0x70AFCC0", VA = "0x1870B10C0")]
		internal object LALBAIKDGCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct LEBILOEFEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public IHJOLHHMIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x70BFAF0", Offset = "0x70BE6F0", VA = "0x1870BFAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x70C0130", Offset = "0x70BED30", VA = "0x1870C0130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class PDENJNLAAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PDENJNLAAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x70C6420", Offset = "0x70C5020", VA = "0x1870C6420")]
		internal object GDHNKLJPKII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private readonly MNBHHFEPHJK MMHDADPGDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private OIJMIDCCAOM IGEANLGBCMI;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private HFKGHGOGEPA IHCMBAJLKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x927050", Offset = "0x925C50", VA = "0x180927050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public IHJOLHHMIJA(MNBHHFEPHJK MMHDADPGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x70B9640", Offset = "0x70B8240", VA = "0x1870B9640")]
	[AsyncStateMachine(typeof(NCAKIGCJMLF))]
	public Task MGFNPLKOLEC(NCHCAFBDJHO FFMMCOIOJKL, FMPKCMJJJBG ILFFINKGJLM, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x70B8CA0", Offset = "0x70B78A0", VA = "0x1870B8CA0")]
	[AsyncStateMachine(typeof(FBLOKFMFGJO))]
	private Task BJDMDGHPNOP(FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x70B9840", Offset = "0x70B8440", VA = "0x1870B9840")]
	[AsyncStateMachine(typeof(KALOEOOGACL))]
	private Task PKIFIOKKLDA(FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x70B8F70", Offset = "0x70B7B70", VA = "0x1870B8F70")]
	[AsyncStateMachine(typeof(JIFOFKLFMGC))]
	private Task DMMJDAHAOGG(FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x70B94F0", Offset = "0x70B80F0", VA = "0x1870B94F0")]
	[AsyncStateMachine(typeof(JBIEMDKNGJK))]
	private Task LLEBMOCIDFA(Guid DBGBDGKNKDI, List<IPNJHAFAMON> OFPMICNACAN, MIEINJBBCJL PFCACFKMCCB, FMPKCMJJJBG JGFKFMMOAJO, CancellationToken GBENACPKFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x70B93B0", Offset = "0x70B7FB0", VA = "0x1870B93B0")]
	[AsyncStateMachine(typeof(LNKEHLFFHEC))]
	private Task KNJAJFNKCFP(FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x70B8B60", Offset = "0x70B7760", VA = "0x1870B8B60")]
	[AsyncStateMachine(typeof(HEIJPMPAMPE))]
	private Task BCEEPOALMKP(Guid JNJPCJBJHIN, FMPKCMJJJBG JGFKFMMOAJO, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x70B8A20", Offset = "0x70B7620", VA = "0x1870B8A20")]
	[AsyncStateMachine(typeof(LEBILOEFEAO))]
	private Task ANHLOCDHAFJ(Guid JNJPCJBJHIN, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x70B9290", Offset = "0x70B7E90", VA = "0x1870B9290")]
	private void IIBHADJIHAP(Guid JNJPCJBJHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x70B9790", Offset = "0x70B8390", VA = "0x1870B9790")]
	private void MLOKHPOIGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x70B8DE0", Offset = "0x70B79E0", VA = "0x1870B8DE0")]
	public Guid CNMFILHIJIL(NCHCAFBDJHO AFCJOJKPIFG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x70B90B0", Offset = "0x70B7CB0", VA = "0x1870B90B0")]
	[CompilerGenerated]
	private object FONFLLMDNIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct OMODGOHKONN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct BPPHGNLCLBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public OMODGOHKONN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private BILFBGGHINK<string>.OADHIEPGLKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private IEnumerator<OAKHCAFPAND> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x70B1A00", Offset = "0x70B0600", VA = "0x1870B1A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x70B20E0", Offset = "0x70B0CE0", VA = "0x1870B20E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private NOIFJHBLDNB JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private CancellationToken PPKBAEMFIMG;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x70C58D0", Offset = "0x70C44D0", VA = "0x1870C58D0")]
	public static Task ODOJAKAGBNK(NOIFJHBLDNB JMKPKEHPNLL, BILFBGGHINK<string>.OADHIEPGLKH IFGCIHPEHMO, CancellationToken BLBAEPMDGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x70C57E0", Offset = "0x70C43E0", VA = "0x1870C57E0")]
	[AsyncStateMachine(typeof(BPPHGNLCLBF))]
	private Task MGFNPLKOLEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public readonly struct DOFPGBMFAOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	public readonly bool AFJEPJLBCNI;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x217CC00", Offset = "0x217B800", VA = "0x18217CC00")]
	public DOFPGBMFAOA(bool IEKNDGNCPGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct PJDBEJLAAGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	public readonly KDDAPCIFEMM? FIAOEMNAGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly DDAFNPBNNBK LAJEHFCHPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	public readonly string? EFGFNCJCAJN;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyCollection<string> GAOMPJNBMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x70C6950", Offset = "0x70C5550", VA = "0x1870C6950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IReadOnlyDictionary<long, int> GONDFHOJKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x70C6970", Offset = "0x70C5570", VA = "0x1870C6970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x70C6990", Offset = "0x70C5590", VA = "0x1870C6990")]
	public PJDBEJLAAGG(KDDAPCIFEMM? ABJNEIDNHBL, DDAFNPBNNBK KHHFJEAEMBA, string? NAAIFMFBNFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal class FNIHEEHHJFG : PJLMCOBICGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct JFCOCHGJHBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public AsyncTaskMethodBuilder<PJDBEJLAAGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public FNIHEEHHJFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public OMNKEAGFBHA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public GJPJKPDEMOM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private ICAIGABDHPB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x70BB280", Offset = "0x70B9E80", VA = "0x1870BB280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x70BB8F0", Offset = "0x70BA4F0", VA = "0x1870BB8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class KFJMPBBHJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public OMNKEAGFBHA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public FNIHEEHHJFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KFJMPBBHJHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x70BD470", Offset = "0x70BC070", VA = "0x1870BD470")]
		internal Task LICAJJAAIMK(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x70BD690", Offset = "0x70BC290", VA = "0x1870BD690")]
		internal Task PPMEIBMIAAP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class NDPPJEHBFKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public KFJMPBBHJHF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NDPPJEHBFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x70C3300", Offset = "0x70C1F00", VA = "0x1870C3300")]
		internal object BEENNEOPHGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class PHFLDKNGGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public KFJMPBBHJHF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PHFLDKNGGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x70C6490", Offset = "0x70C5090", VA = "0x1870C6490")]
		internal Task HECBCKBJOJF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct BNIAGNIIJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public OMNKEAGFBHA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public FNIHEEHHJFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private NDPPJEHBFKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private ICAIGABDHPB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x70B1130", Offset = "0x70AFD30", VA = "0x1870B1130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x70B19A0", Offset = "0x70B05A0", VA = "0x1870B19A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private static readonly TimeSpan GHLGAFMKHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly POPKKJHEMII FBAPGDNHAAF;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x70B64A0", Offset = "0x70B50A0", VA = "0x1870B64A0")]
	public FNIHEEHHJFG(MNBHHFEPHJK MMHDADPGDPE, POPKKJHEMII FBAPGDNHAAF, EEGEMFOKJOP IGMINGONOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x70B5390", Offset = "0x70B3F90", VA = "0x1870B5390")]
	[AsyncStateMachine(typeof(JFCOCHGJHBA))]
	public Task<PJDBEJLAAGG> CJJBNJOFCID(long EPCPKKDEADD, GJPJKPDEMOM JOEEKMPCLDM, OMNKEAGFBHA MAPNCLDEJPP, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x70B5AA0", Offset = "0x70B46A0", VA = "0x1870B5AA0")]
	[AsyncStateMachine(typeof(BNIAGNIIJAF))]
	private Task IIGPPGHAJMJ(OMNKEAGFBHA MAPNCLDEJPP, IEnumerable<PersistenceView> DNPALHFCCGD, StringBuilder OBJPBONEMNI, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x70B54F0", Offset = "0x70B40F0", VA = "0x1870B54F0")]
	private PJDBEJLAAGG DIPLPJLOJMO(long EPCPKKDEADD, GJPJKPDEMOM JOEEKMPCLDM, OMNKEAGFBHA MAPNCLDEJPP, IEnumerable<PersistenceView> DNPALHFCCGD, StringBuilder OBJPBONEMNI)
	{
		return default(PJDBEJLAAGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x70B5BE0", Offset = "0x70B47E0", VA = "0x1870B5BE0")]
	private KDDAPCIFEMM LPEMFEBKHKK(long EPCPKKDEADD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x70B5D40", Offset = "0x70B4940", VA = "0x1870B5D40")]
	private void MEFBLGGFFFN(KDDAPCIFEMM OFNKNACPCHJ, StringBuilder OBJPBONEMNI, IEnumerable<PersistenceView> DNPALHFCCGD, [In] KGEECBBCBNK PMKGPOKBHEN, OFBAJKALOEC NGNNKJJMMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x70B5F90", Offset = "0x70B4B90", VA = "0x1870B5F90")]
	private void MFDPEPIENLP(KDDAPCIFEMM OFNKNACPCHJ, StringBuilder OBJPBONEMNI, PersistenceView MJEDEOCFGKA, OFBAJKALOEC NGNNKJJMMFJ, [In] KGEECBBCBNK PMKGPOKBHEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class KNAMKLMJIGG : PJLMCOBICGK
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class KKPIDOMJJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public FLNHHEENHAO.HLCFKLFLLDB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KKPIDOMJJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x70BDC30", Offset = "0x70BC830", VA = "0x1870BDC30")]
		internal object JKNDIAKJKCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct NCNDDAPDFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public AsyncTaskMethodBuilder<(FLNHHEENHAO.HLCFKLFLLDB roomDataUpload, FLNHHEENHAO.HLCFKLFLLDB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public PJDBEJLAAGG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public KNAMKLMJIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private KKPIDOMJJLE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private TaskAwaiter<FLNHHEENHAO.HLCFKLFLLDB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x70C2A40", Offset = "0x70C1640", VA = "0x1870C2A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x70C3290", Offset = "0x70C1E90", VA = "0x1870C3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct OGOAHOFLGNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public AsyncTaskMethodBuilder<KGPHKHBNANK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public KNAMKLMJIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public PJDBEJLAAGG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public NFDGGMAMIAG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private TaskAwaiter<(FLNHHEENHAO.HLCFKLFLLDB roomDataUpload, FLNHHEENHAO.HLCFKLFLLDB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private TaskAwaiter<KGPHKHBNANK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x70C3E90", Offset = "0x70C2A90", VA = "0x1870C3E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x70C4510", Offset = "0x70C3110", VA = "0x1870C4510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct PIIDLLNBGIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public AsyncTaskMethodBuilder<EICFOOOCNLM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public KNAMKLMJIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public PJDBEJLAAGG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter<(FLNHHEENHAO.HLCFKLFLLDB roomDataUpload, FLNHHEENHAO.HLCFKLFLLDB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private TaskAwaiter<EICFOOOCNLM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x70C64D0", Offset = "0x70C50D0", VA = "0x1870C64D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x70C68E0", Offset = "0x70C54E0", VA = "0x1870C68E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class EHIFDCNKEPP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public EHIFDCNKEPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private LJGJBLECALO <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			private TaskAwaiter<EICFOOOCNLM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private TaskAwaiter<KGPHKHBNANK> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter<LJGJBLECALO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x70C7840", Offset = "0x70C6440", VA = "0x1870C7840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x70C87B0", Offset = "0x70C73B0", VA = "0x1870C87B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public KNAMKLMJIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public PJDBEJLAAGG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public NFDGGMAMIAG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public DOFPGBMFAOA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EHIFDCNKEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x70B3F90", Offset = "0x70B2B90", VA = "0x1870B3F90")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<LJGJBLECALO> NHMEGPEDIJP(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct AGKMHLPONIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder<LJGJBLECALO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public KNAMKLMJIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public PJDBEJLAAGG roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public NFDGGMAMIAG roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public DOFPGBMFAOA roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public BILFBGGHINK<string>.OADHIEPGLKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private TaskAwaiter<LJGJBLECALO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x70AF910", Offset = "0x70AE510", VA = "0x1870AF910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x70AFC20", Offset = "0x70AE820", VA = "0x1870AFC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private static readonly EEGEMFOKJOP GKJBHEJKION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private readonly DGLICIJBPIP EHGFHALJNBF;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private CJIDFPHHKMP NHOIHAIKBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x70A8740", Offset = "0x70A7340", VA = "0x1870A8740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x70BF480", Offset = "0x70BE080", VA = "0x1870BF480")]
	public KNAMKLMJIGG(MNBHHFEPHJK MMHDADPGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x70BF130", Offset = "0x70BDD30", VA = "0x1870BF130")]
	[AsyncStateMachine(typeof(NCNDDAPDFMH))]
	private Task<(FLNHHEENHAO.HLCFKLFLLDB, FLNHHEENHAO.HLCFKLFLLDB)> NNNJFMMGIHH(PJDBEJLAAGG JICPAADAAKO, long ACIHEOIHPAO, long GPDLAAEANOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x70BF270", Offset = "0x70BDE70", VA = "0x1870BF270")]
	[AsyncStateMachine(typeof(OGOAHOFLGNB))]
	public Task<KGPHKHBNANK> OMLLGCDLBCN(int CJKKEGNGHEM, [CanBeNull] NFDGGMAMIAG DDNEDFLHLJM, PJDBEJLAAGG JICPAADAAKO, long ACIHEOIHPAO, long GPDLAAEANOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x70BEE20", Offset = "0x70BDA20", VA = "0x1870BEE20")]
	[AsyncStateMachine(typeof(PIIDLLNBGIH))]
	private Task<EICFOOOCNLM> COIKEFPHGLM(string OJBGLCHEJIB, int CJKKEGNGHEM, PJDBEJLAAGG JICPAADAAKO, long ACIHEOIHPAO, long GPDLAAEANOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x70BEF90", Offset = "0x70BDB90", VA = "0x1870BEF90")]
	[AsyncStateMachine(typeof(AGKMHLPONIL))]
	public Task<LJGJBLECALO> EHOANHEOCKB(int CJKKEGNGHEM, NFDGGMAMIAG? DDNEDFLHLJM, PJDBEJLAAGG JICPAADAAKO, long ACIHEOIHPAO, long GPDLAAEANOD, DOFPGBMFAOA ECCDOIOGMEG, BILFBGGHINK<string>.OADHIEPGLKH AJGFNIHFIIJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public abstract class GKEPGEBNNJG<T> where T : GKEPGEBNNJG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	internal readonly CJIDFPHHKMP FFBDKAELOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private int? KKNAMJEHPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	protected readonly Guid GECIONPEKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	protected readonly BKDLNBFPHDL GDAHBKCFDCD;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	protected T CEGMGNLKOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x3D563A0", Offset = "0x3D54FA0", VA = "0x183D563A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x3D56400", Offset = "0x3D55000", VA = "0x183D56400")]
	internal GKEPGEBNNJG(CJIDFPHHKMP KCHGIAPLBLB, BKDLNBFPHDL PNANBJBKPCG, [Optional] Guid? FEHGEPPCEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x3D562C0", Offset = "0x3D54EC0", VA = "0x183D562C0")]
	private LJGJBLECALO NPJMFEHCGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
	protected virtual void NJJKLFGEALO(LJGJBLECALO NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x3D55FD0", Offset = "0x3D54BD0", VA = "0x183D55FD0")]
	public T DMELMJAHLON(MLFBKPIOFCD FNNNADILIEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x3D56210", Offset = "0x3D54E10", VA = "0x183D56210")]
	public T LGGKHJBCHDD(int NAKOJNPBFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x3D560E0", Offset = "0x3D54CE0", VA = "0x183D560E0", Slot = "5")]
	public virtual Task<MPFBHKIJKJP> EJPKLIJDMGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class FPPLDNNKFDF : GKEPGEBNNJG<FPPLDNNKFDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private LDKNGEJJMKB BHGBMMFNCAD;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x70B6700", Offset = "0x70B5300", VA = "0x1870B6700")]
	internal FPPLDNNKFDF(CJIDFPHHKMP KCHGIAPLBLB, BKDLNBFPHDL PNANBJBKPCG, [Optional] Guid? FEHGEPPCEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x65E4590", Offset = "0x65E3190", VA = "0x1865E4590")]
	public FPPLDNNKFDF CMIEILKMIAB(LDKNGEJJMKB BHGBMMFNCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x70B6630", Offset = "0x70B5230", VA = "0x1870B6630", Slot = "4")]
	protected override void NJJKLFGEALO(LJGJBLECALO NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class AELCJGIHAMM : GKEPGEBNNJG<AELCJGIHAMM>
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	internal enum IIMCHKELJBF
	{
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct LLAPOAPMDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public AsyncTaskMethodBuilder<MPFBHKIJKJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public AELCJGIHAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private TaskAwaiter<MPFBHKIJKJP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x70CD040", Offset = "0x70CBC40", VA = "0x1870CD040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x70CD3C0", Offset = "0x70CBFC0", VA = "0x1870CD3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private IIMCHKELJBF NIEABNKDDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private string HIBONBGCKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private NFDGGMAMIAG BHGBMMFNCAD;

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x70AEEF0", Offset = "0x70ADAF0", VA = "0x1870AEEF0")]
	internal AELCJGIHAMM(CJIDFPHHKMP KCHGIAPLBLB, BKDLNBFPHDL PNANBJBKPCG, [Optional] Guid? FEHGEPPCEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x70AEBF0", Offset = "0x70AD7F0", VA = "0x1870AEBF0")]
	public AELCJGIHAMM BIIOMOIOBOK(string JCKPDENNIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x70AEBD0", Offset = "0x70AD7D0", VA = "0x1870AEBD0")]
	public AELCJGIHAMM AAGHDLCHKMB(bool DMANLIKKHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x70AEEC0", Offset = "0x70ADAC0", VA = "0x1870AEEC0")]
	public AELCJGIHAMM OIKHKOOKAEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x70AED50", Offset = "0x70AD950", VA = "0x1870AED50", Slot = "4")]
	protected override void NJJKLFGEALO(LJGJBLECALO NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x70AEC60", Offset = "0x70AD860", VA = "0x1870AEC60", Slot = "5")]
	[AsyncStateMachine(typeof(LLAPOAPMDGJ))]
	public override Task<MPFBHKIJKJP> EJPKLIJDMGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x70AEC20", Offset = "0x70AD820", VA = "0x1870AEC20")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<MPFBHKIJKJP> EEOBBKDGDMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal static class KJBPLDELAII
{
	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x70CCE70", Offset = "0x70CBA70", VA = "0x1870CCE70")]
	public static void FCLJIICALPF(this EMPEJCIGLJJ PIGAKNAOAPJ, MEEJEPKLPKH INELBGFBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x70CCFC0", Offset = "0x70CBBC0", VA = "0x1870CCFC0")]
	public static void HICEEOOGJHP(this MEEJEPKLPKH MGEDBJHLFAM, [Optional] string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class FIBCFDIEOHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x70CA490", Offset = "0x70C9090", VA = "0x1870CA490")]
	public static OHEPJFMFHIA JLEODDGMCHG(this OMMKGEPEGON BPHJOELJOKB)
	{
		return default(OHEPJFMFHIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x70CA3E0", Offset = "0x70C8FE0", VA = "0x1870CA3E0")]
	public static OMMKGEPEGON BLBOBOCJHBB(this OHEPJFMFHIA MGLDHNEMOBF)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public INOFHHNFADO ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public INOFHHNFADO HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private static INOFHHNFADO[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private Dictionary<INOFHHNFADO, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x70CE710", Offset = "0x70CD310", VA = "0x1870CE710")]
		public bool MEKCCCLGHNH(INOFHHNFADO DENDOGBJGMD, [Out] ResultConfig JOKNJOHCHIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x70CEF40", Offset = "0x70CDB40", VA = "0x1870CEF40")]
		public ResultConfig PHADFNHNOFC(INOFHHNFADO GLMDIHNLEBJ, [Optional] HashSet<INOFHHNFADO> HHLLAHGHDNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x70CED50", Offset = "0x70CD950", VA = "0x1870CED50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x70CE780", Offset = "0x70CD380", VA = "0x1870CE780", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8D15E0", Offset = "0x8D01E0", VA = "0x1808D15E0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public static class MFOGJKGHNNP
{
	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x70CD430", Offset = "0x70CC030", VA = "0x1870CD430")]
	[DHOHFCLMOGD(IDHBAGABJJA.GameOnly)]
	private static void MHPOAGMJOPB(IMEOEBHKJNP DAOJEFNFNPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public interface ECJJPIPOFMP : IEquatable<ECJJPIPOFMP>
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	DateTime NCMKJDIMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODPNFOLHNAG();

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FBNIJAJBJCN(long ACIHEOIHPAO, long EPCPKKDEADD, [Out] PJDBEJLAAGG JICPAADAAKO);
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class FAPJHNDPEIN : JFHNOOMNJEI
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class HFLOAIKNIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public JGCKGNBCBHH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public HFLOAIKNIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x70CBEF0", Offset = "0x70CAAF0", VA = "0x1870CBEF0")]
		internal object HLHMHCGAEPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private readonly NCEAFHKPPFK AFDNKIKEALA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<ECJJPIPOFMP> FKPNNAGOMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x70C9AE0", Offset = "0x70C86E0", VA = "0x1870C9AE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x70C9530", Offset = "0x70C8130", VA = "0x1870C9530", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	[UnityEngine.Scripting.Preserve]
	public FAPJHNDPEIN([POJODGKFIMO(null)] NCEAFHKPPFK AFDNKIKEALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x70C9800", Offset = "0x70C8400", VA = "0x1870C9800", Slot = "6")]
	public bool GPHPJJNFMMG(long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO, JGCKGNBCBHH GOPLAELIJFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x1C54690", Offset = "0x1C53290", VA = "0x181C54690")]
	private void IEKEMOOCNGA(ECJJPIPOFMP INHGMJFCGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x70C9690", Offset = "0x70C8290", VA = "0x1870C9690", Slot = "7")]
	public bool FBOJDIJAGGO(long ACIHEOIHPAO, long EPCPKKDEADD, [Out] ECJJPIPOFMP KDFNCJHIKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x70C95E0", Offset = "0x70C81E0", VA = "0x1870C95E0", Slot = "8")]
	public bool EDGMPHNAHFK(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, [Out] ECJJPIPOFMP KDFNCJHIKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x70C9CA0", Offset = "0x70C88A0", VA = "0x1870C9CA0")]
	private void OMKKAOCKCKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x70C9B90", Offset = "0x70C8790", VA = "0x1870C9B90", Slot = "9")]
	public void LICCBEBAJKG(long ACIHEOIHPAO, long EPCPKKDEADD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal abstract class HCHOEHMFOCG : NCEAFHKPPFK
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	protected enum GLLAOIEECHH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class DEPALOELJLD : IEnumerable<ECJJPIPOFMP>, IEnumerable, IEnumerator<ECJJPIPOFMP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private ECJJPIPOFMP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public HCHOEHMFOCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private JGCKGNBCBHH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public JGCKGNBCBHH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private ECJJPIPOFMP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8BB210", Offset = "0x8B9E10", VA = "0x1808BB210")]
		[DebuggerHidden]
		public DEPALOELJLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x70C8D40", Offset = "0x70C7940", VA = "0x1870C8D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x70C9020", Offset = "0x70C7C20", VA = "0x1870C9020", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x70C8F70", Offset = "0x70C7B70", VA = "0x1870C8F70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ECJJPIPOFMP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x70C8F70", Offset = "0x70C7B70", VA = "0x1870C8F70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class PLFAEDPFCFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public JGCKGNBCBHH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PLFAEDPFCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x70CE360", Offset = "0x70CCF60", VA = "0x1870CE360")]
		internal object MOEMJFGEJCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class PONKFKNNDEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public HCHOEHMFOCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PONKFKNNDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x70CE400", Offset = "0x70CD000", VA = "0x1870CE400")]
		internal void BEDABDPGGLK(NLLOCIDGDEI.BLOABCAOCEK ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private readonly object ANMGGPCJOJN;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	protected string FCHILOGECFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x70CBAD0", Offset = "0x70CA6D0", VA = "0x1870CBAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public abstract JBNMNCLEGBG PLKEDHNDFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x70CBE70", Offset = "0x70CAA70", VA = "0x1870CBE70")]
	protected HCHOEHMFOCG([CanBeNull] string FAMIDIBJOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x70CB880", Offset = "0x70CA480", VA = "0x1870CB880", Slot = "5")]
	public bool IBCGCCKJGAE(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, [Out] ECJJPIPOFMP INHGMJFCGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x70CB470", Offset = "0x70CA070", VA = "0x1870CB470", Slot = "6")]
	[IteratorStateMachine(typeof(DEPALOELJLD))]
	public IEnumerable<ECJJPIPOFMP> BBCLEHLMFGK(JGCKGNBCBHH GOPLAELIJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void ELDBKJDJNIF(Stream JKDPIEGNFNC, long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool HPMOBMECOBF(Stream HGCECKKJONC, long ACIHEOIHPAO, long EPCPKKDEADD, PCPEKJOPJCG DNBIIOKEPMD, [Out] PJDBEJLAAGG JICPAADAAKO);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x70CB500", Offset = "0x70CA100", VA = "0x1870CB500", Slot = "7")]
	public ECJJPIPOFMP FPLBNGKCCGB(long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO, JGCKGNBCBHH GOPLAELIJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo KCFGFGEDCEO(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, GLLAOIEECHH EHCLHICBAJG);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo COFCDCADLIF(JGCKGNBCBHH GOPLAELIJFH, GLLAOIEECHH EHCLHICBAJG);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x70CBA60", Offset = "0x70CA660", VA = "0x1870CBA60")]
	protected void KAJPPMBGGIG(NLLOCIDGDEI.BLOABCAOCEK GFMOCEAOIGP, string NPDAJLMKBPH, FileInfo KDKBDACAALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x70CBAE0", Offset = "0x70CA6E0", VA = "0x1870CBAE0")]
	internal bool MMADGGLFPKC(FileInfo CDNFMGFLBFB, long ACIHEOIHPAO, long EPCPKKDEADD, [Out] PJDBEJLAAGG JICPAADAAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private void LKKFGKEGODP(Exception EHPDFDGNBIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class MJOBBAKHGPN : HCHOEHMFOCG
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public override JBNMNCLEGBG PLKEDHNDFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xCC3EC0", Offset = "0xCC2AC0", VA = "0x180CC3EC0", Slot = "8")]
		get
		{
			return default(JBNMNCLEGBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x70CE320", Offset = "0x70CCF20", VA = "0x1870CE320")]
	public MJOBBAKHGPN([Optional] string FAMIDIBJOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x70CE1B0", Offset = "0x70CCDB0", VA = "0x1870CE1B0")]
	private void IGPJCBGBDFN(JGCKGNBCBHH GOPLAELIJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x70CD940", Offset = "0x70CC540", VA = "0x1870CD940", Slot = "9")]
	internal override void ELDBKJDJNIF(Stream JKDPIEGNFNC, long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x70CDBD0", Offset = "0x70CC7D0", VA = "0x1870CDBD0", Slot = "10")]
	internal override bool HPMOBMECOBF(Stream HGCECKKJONC, long ACIHEOIHPAO, long EPCPKKDEADD, PCPEKJOPJCG DNBIIOKEPMD, [Out] PJDBEJLAAGG JICPAADAAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x70CE230", Offset = "0x70CCE30", VA = "0x1870CE230", Slot = "11")]
	protected override FileInfo KCFGFGEDCEO(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, GLLAOIEECHH EHCLHICBAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x70CD840", Offset = "0x70CC440", VA = "0x1870CD840", Slot = "12")]
	protected override DirectoryInfo COFCDCADLIF(JGCKGNBCBHH GOPLAELIJFH, GLLAOIEECHH EHCLHICBAJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal sealed class IKIAJEECGFJ : HCHOEHMFOCG
{
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private static readonly byte[] NCMHANGAILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private readonly byte[] JICNKAEOMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private readonly byte[] JMKNFFIJAEM;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override JBNMNCLEGBG PLKEDHNDFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E910", Offset = "0x5E7D510", VA = "0x185E7E910", Slot = "8")]
		get
		{
			return default(JBNMNCLEGBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x70CCD80", Offset = "0x70CB980", VA = "0x1870CCD80")]
	public IKIAJEECGFJ([Optional] string FAMIDIBJOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x70CC070", Offset = "0x70CAC70", VA = "0x1870CC070", Slot = "9")]
	internal override void ELDBKJDJNIF(Stream JKDPIEGNFNC, long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x70CC3F0", Offset = "0x70CAFF0", VA = "0x1870CC3F0", Slot = "10")]
	internal override bool HPMOBMECOBF(Stream HGCECKKJONC, long ACIHEOIHPAO, long EPCPKKDEADD, PCPEKJOPJCG DNBIIOKEPMD, [Out] PJDBEJLAAGG JICPAADAAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x70CC330", Offset = "0x70CAF30", VA = "0x1870CC330")]
	private void EPLGGDELFPA(byte[] GABEBEKDBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x70CCBC0", Offset = "0x70CB7C0", VA = "0x1870CCBC0", Slot = "11")]
	protected override FileInfo KCFGFGEDCEO(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, GLLAOIEECHH EHCLHICBAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x70CBF60", Offset = "0x70CAB60", VA = "0x1870CBF60", Slot = "12")]
	protected override DirectoryInfo COFCDCADLIF(JGCKGNBCBHH GOPLAELIJFH, GLLAOIEECHH EHCLHICBAJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public enum JBNMNCLEGBG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal class GHDILBOHDMC : NCEAFHKPPFK
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class EKLFAEBMCBG : IEnumerable<ECJJPIPOFMP>, IEnumerable, IEnumerator<ECJJPIPOFMP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private ECJJPIPOFMP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public GHDILBOHDMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private JGCKGNBCBHH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public JGCKGNBCBHH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private JBNMNCLEGBG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private IEnumerator<ECJJPIPOFMP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		private ECJJPIPOFMP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB210", Offset = "0x8B9E10", VA = "0x1808BB210")]
		[DebuggerHidden]
		public EKLFAEBMCBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x70C94A0", Offset = "0x70C80A0", VA = "0x1870C94A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x70C9070", Offset = "0x70C7C70", VA = "0x1870C9070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x70C9350", Offset = "0x70C7F50", VA = "0x1870C9350")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x70C9450", Offset = "0x70C8050", VA = "0x1870C9450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x70C93A0", Offset = "0x70C7FA0", VA = "0x1870C93A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ECJJPIPOFMP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x70C93A0", Offset = "0x70C7FA0", VA = "0x1870C93A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private readonly JBNMNCLEGBG[] HJEBGJGKLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private readonly Dictionary<JBNMNCLEGBG, NCEAFHKPPFK> PBIDEPEOFKP;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public JBNMNCLEGBG PLKEDHNDFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x70CAC30", Offset = "0x70C9830", VA = "0x1870CAC30", Slot = "4")]
		get
		{
			return default(JBNMNCLEGBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x70CB120", Offset = "0x70C9D20", VA = "0x1870CB120")]
	[UnityEngine.Scripting.Preserve]
	public GHDILBOHDMC(params NCEAFHKPPFK[] GJHFJAADMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x70CAFD0", Offset = "0x70C9BD0", VA = "0x1870CAFD0", Slot = "5")]
	public bool IBCGCCKJGAE(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, [Out] ECJJPIPOFMP INHGMJFCGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x70CAC60", Offset = "0x70C9860", VA = "0x1870CAC60")]
	private void ECIJBHADNPF(int KHAGOCDGPHI, long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x70CABA0", Offset = "0x70C97A0", VA = "0x1870CABA0", Slot = "6")]
	[IteratorStateMachine(typeof(EKLFAEBMCBG))]
	public IEnumerable<ECJJPIPOFMP> BBCLEHLMFGK(JGCKGNBCBHH GOPLAELIJFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x70CAE80", Offset = "0x70C9A80", VA = "0x1870CAE80", Slot = "7")]
	public ECJJPIPOFMP FPLBNGKCCGB(long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO, JGCKGNBCBHH GOPLAELIJFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal static class FEECEINKLEF
{
	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x70CA0C0", Offset = "0x70C8CC0", VA = "0x1870CA0C0")]
	internal static byte[] KBKMBJLCCFO(byte[] GABEBEKDBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x70CA180", Offset = "0x70C8D80", VA = "0x1870CA180")]
	public static void LKNFGFBHPCC(Stream GKBJLEBFJKE, byte[] OBALAPLLADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x70CA200", Offset = "0x70C8E00", VA = "0x1870CA200")]
	public static bool MHAILPGLKCB(Stream GKBJLEBFJKE, long DKEMFMPALAP, PCPEKJOPJCG NKNNANMHGGI, [Out] byte[] JFLJJGHEDAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class GEIOBOGDICI : ECJJPIPOFMP, IEquatable<ECJJPIPOFMP>, IEquatable<GEIOBOGDICI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private readonly HCHOEHMFOCG JJGGFAGMPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	public readonly FileInfo ONDFLPCIPHO;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public JBNMNCLEGBG PLKEDHNDFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x6A95090", Offset = "0x6A93C90", VA = "0x186A95090", Slot = "9")]
		get
		{
			return default(JBNMNCLEGBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DateTime NCMKJDIMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x70CA890", Offset = "0x70C9490", VA = "0x1870CA890", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x70CAA90", Offset = "0x70C9690", VA = "0x1870CAA90")]
	public GEIOBOGDICI(HCHOEHMFOCG FOOHFPAFKEF, FileInfo CDNFMGFLBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x70CA9E0", Offset = "0x70C95E0", VA = "0x1870CA9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x70CA920", Offset = "0x70C9520", VA = "0x1870CA920", Slot = "5")]
	public void ODPNFOLHNAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x70CA7C0", Offset = "0x70C93C0", VA = "0x1870CA7C0", Slot = "6")]
	public bool FBNIJAJBJCN(long ACIHEOIHPAO, long EPCPKKDEADD, [Out] PJDBEJLAAGG JICPAADAAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x70CA530", Offset = "0x70C9130", VA = "0x1870CA530", Slot = "7")]
	public bool Equals(ECJJPIPOFMP HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x70CA610", Offset = "0x70C9210", VA = "0x1870CA610", Slot = "8")]
	public bool Equals(GEIOBOGDICI HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x70CA6D0", Offset = "0x70C92D0", VA = "0x1870CA6D0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x70CA800", Offset = "0x70C9400", VA = "0x1870CA800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public delegate void PCPEKJOPJCG(NLLOCIDGDEI.BLOABCAOCEK FMBELJBIBPM, string NKAJDDICLFH);
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal interface NCEAFHKPPFK
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	JBNMNCLEGBG PLKEDHNDFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IBCGCCKJGAE(long ACIHEOIHPAO, long EPCPKKDEADD, JGCKGNBCBHH GOPLAELIJFH, [Out] ECJJPIPOFMP INHGMJFCGBK);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ECJJPIPOFMP> BBCLEHLMFGK(JGCKGNBCBHH GOPLAELIJFH);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ECJJPIPOFMP FPLBNGKCCGB(long ACIHEOIHPAO, long EPCPKKDEADD, PJDBEJLAAGG JICPAADAAKO, JGCKGNBCBHH GOPLAELIJFH);
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
