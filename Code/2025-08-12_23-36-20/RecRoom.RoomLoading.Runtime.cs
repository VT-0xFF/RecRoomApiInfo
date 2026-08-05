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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C10B90", Offset = "0x8C0F990", VA = "0x188C10B90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class JEFBCPNECJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<DGANFCBONGG> AAPBFNJDMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task IKGDBEBHFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal DLFNPGOAGLN KLGHHOAFHND;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JEFBCPNECJJ()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EBF0", Offset = "0x8C0D9F0", VA = "0x188C0EBF0", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C143F0", Offset = "0x8C131F0", VA = "0x188C143F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LIDLBDCHDHC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8C08C60", Offset = "0x8C07A60", VA = "0x188C08C60")]
	public LIDLBDCHDHC(string JDFCBBCKOGJ, Exception HDEBIKIKFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class GDDHCJIOCDE : BKOFHFHDLGC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CBKFJLCBEBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NMOAOAGEGEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<JILEDJOCGMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6E30", Offset = "0x8BF5C30", VA = "0x188BF6E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7070", Offset = "0x8BF5E70", VA = "0x188BF7070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BIMBNGDONDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MPPKGBDBLNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<MPPKGBDBLNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5E50", Offset = "0x8BF4C50", VA = "0x188BF5E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6060", Offset = "0x8BF4E60", VA = "0x188BF6060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[UnityEngine.Scripting.Preserve]
	public GDDHCJIOCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8BFD7F0", Offset = "0x8BFC5F0", VA = "0x188BFD7F0", Slot = "4")]
	[AsyncStateMachine(typeof(CBKFJLCBEBM))]
	public Task<IReadOnlyList<NMOAOAGEGEO>> KLHJEAGKENK(long MDNJLMOPJKG, long JDPEMOIFJMF, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8BFD6E0", Offset = "0x8BFC4E0", VA = "0x188BFD6E0", Slot = "5")]
	[AsyncStateMachine(typeof(BIMBNGDONDD))]
	public Task<IReadOnlyList<MPPKGBDBLNO>> JGOIFFOAFII(IReadOnlyList<int> MGPNGCCNFHA, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DNGDGMIPGJB : IEquatable<DNGDGMIPGJB>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MBDLDJCMMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MPPKGBDBLNO FIMCFNCCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime LKMAGFDALJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LGBPLMEOAKA? AJDCKCLKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ONMPCBKJNPC? BCOMBOLOPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	MDDCPOOGEND GOEEIICKHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NNJLPCOCOKC> LDGKIDHEANN();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum MDDCPOOGEND
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BKOFHFHDLGC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<NMOAOAGEGEO>> KLHJEAGKENK(long MDNJLMOPJKG, long JDPEMOIFJMF, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MPPKGBDBLNO>> JGOIFFOAFII(IReadOnlyList<int> MGPNGCCNFHA, [Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class COADLJJNNCL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class JCGMBNIKCDH : DNGDGMIPGJB, IEquatable<DNGDGMIPGJB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct PACGDKGCLLE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public JCGMBNIKCDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private FPFANPNLBJN <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<CPKIDEJABEO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<NNJLPCOCOKC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C11DC0", Offset = "0x8C10BC0", VA = "0x188C11DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8C12350", Offset = "0x8C11150", VA = "0x188C12350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly NMOAOAGEGEO IAPMPDIPMBO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int MBDLDJCMMCC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MPPKGBDBLNO FIMCFNCCDJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime BGEEIIJJKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8C060B0", Offset = "0x8C04EB0", VA = "0x188C060B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LGBPLMEOAKA? AJDCKCLKNAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2D61460", Offset = "0x2D60260", VA = "0x182D61460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ONMPCBKJNPC? BCOMBOLOPMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C05F90", Offset = "0x8C04D90", VA = "0x188C05F90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MDDCPOOGEND GOEEIICKHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "10")]
			get
			{
				return default(MDDCPOOGEND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C05FB0", Offset = "0x8C04DB0", VA = "0x188C05FB0", Slot = "9")]
		[AsyncStateMachine(typeof(PACGDKGCLLE))]
		public Task<NNJLPCOCOKC> LDGKIDHEANN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C060D0", Offset = "0x8C04ED0", VA = "0x188C060D0")]
		public JCGMBNIKCDH(int EFCAJHLBMAN, MPPKGBDBLNO ODCAAHNLIHB, NMOAOAGEGEO IAPMPDIPMBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8C05E80", Offset = "0x8C04C80", VA = "0x188C05E80", Slot = "11")]
		public bool Equals(DNGDGMIPGJB FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8C05DE0", Offset = "0x8C04BE0", VA = "0x188C05DE0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C05DA0", Offset = "0x8C04BA0", VA = "0x188C05DA0")]
		private bool EPEJKEOKDBC(JCGMBNIKCDH FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C05F10", Offset = "0x8C04D10", VA = "0x188C05F10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BDPJCFAIPHG : DNGDGMIPGJB, IEquatable<DNGDGMIPGJB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct GFOOOGOMOAH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public BDPJCFAIPHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<NNJLPCOCOKC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8BFDCE0", Offset = "0x8BFCAE0", VA = "0x188BFDCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8BFDF30", Offset = "0x8BFCD30", VA = "0x188BFDF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly KGMHFIJAHBM DOIDPIALMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LGBPLMEOAKA LCMMKFBCCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly ONMPCBKJNPC ILNDPBMNAKI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int MBDLDJCMMCC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5970", Offset = "0x8BF4770", VA = "0x188BF5970", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MPPKGBDBLNO FIMCFNCCDJI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5DC0", Offset = "0x8BF4BC0", VA = "0x188BF5DC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime BGEEIIJJKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5D70", Offset = "0x8BF4B70", VA = "0x188BF5D70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LGBPLMEOAKA? AJDCKCLKNAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5BE0", Offset = "0x8BF49E0", VA = "0x188BF5BE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ONMPCBKJNPC? BCOMBOLOPMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BF5C30", Offset = "0x8BF4A30", VA = "0x188BF5C30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MDDCPOOGEND GOEEIICKHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAEE190", Offset = "0xAECF90", VA = "0x180AEE190", Slot = "10")]
			get
			{
				return default(MDDCPOOGEND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2168F90", Offset = "0x2167D90", VA = "0x182168F90")]
		public BDPJCFAIPHG(KGMHFIJAHBM BIAIDCADKFG, LGBPLMEOAKA FJMJCKAPOGA, ONMPCBKJNPC CBLLOFJHGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C80", Offset = "0x8BF4A80", VA = "0x188BF5C80", Slot = "9")]
		[AsyncStateMachine(typeof(GFOOOGOMOAH))]
		public Task<NNJLPCOCOKC> LDGKIDHEANN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5A10", Offset = "0x8BF4810", VA = "0x188BF5A10", Slot = "11")]
		public bool Equals(DNGDGMIPGJB FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5AB0", Offset = "0x8BF48B0", VA = "0x188BF5AB0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BF59B0", Offset = "0x8BF47B0", VA = "0x188BF59B0")]
		private bool EPEJKEOKDBC(BDPJCFAIPHG FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5B60", Offset = "0x8BF4960", VA = "0x188BF5B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class EJNJIIJBOAA : DNGDGMIPGJB, IEquatable<DNGDGMIPGJB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct GBLMKNKDGEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<NNJLPCOCOKC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD410", Offset = "0x8BFC210", VA = "0x188BFD410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD670", Offset = "0x8BFC470", VA = "0x188BFD670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly MPPKGBDBLNO ONCBAKCIKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly LGBPLMEOAKA LCMMKFBCCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly ONMPCBKJNPC ILNDPBMNAKI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int MBDLDJCMMCC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA580", Offset = "0x8BF9380", VA = "0x188BFA580", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MPPKGBDBLNO FIMCFNCCDJI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime BGEEIIJJKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LGBPLMEOAKA? AJDCKCLKNAM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA800", Offset = "0x8BF9600", VA = "0x188BFA800", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ONMPCBKJNPC? BCOMBOLOPMI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA850", Offset = "0x8BF9650", VA = "0x188BFA850", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MDDCPOOGEND GOEEIICKHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "10")]
			get
			{
				return default(MDDCPOOGEND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2168F90", Offset = "0x2167D90", VA = "0x182168F90")]
		public EJNJIIJBOAA(MPPKGBDBLNO ODCAAHNLIHB, LGBPLMEOAKA FJMJCKAPOGA, ONMPCBKJNPC CBLLOFJHGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA8A0", Offset = "0x8BF96A0", VA = "0x188BFA8A0", Slot = "9")]
		[AsyncStateMachine(typeof(GBLMKNKDGEP))]
		public Task<NNJLPCOCOKC> LDGKIDHEANN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA680", Offset = "0x8BF9480", VA = "0x188BFA680", Slot = "11")]
		public bool Equals(DNGDGMIPGJB FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA6F0", Offset = "0x8BF94F0", VA = "0x188BFA6F0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA770", Offset = "0x8BF9570", VA = "0x188BFA770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA5A0", Offset = "0x8BF93A0", VA = "0x188BFA5A0")]
		private bool EPEJKEOKDBC(EJNJIIJBOAA FGAEAFBDBPK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HJAGHBJHMKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<DNGDGMIPGJB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public COADLJJNNCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<NMOAOAGEGEO> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<NMOAOAGEGEO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MPPKGBDBLNO account, NMOAOAGEGEO roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE720", Offset = "0x8BFD520", VA = "0x188BFE720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF560", Offset = "0x8BFE360", VA = "0x188BFF560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PJHJCEDLOPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MPPKGBDBLNO account, NMOAOAGEGEO roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<NMOAOAGEGEO> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public COADLJJNNCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<MPPKGBDBLNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8C12610", Offset = "0x8C11410", VA = "0x188C12610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8C12FF0", Offset = "0x8C11DF0", VA = "0x188C12FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NKFKONJEHCF CMBMNGCNEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BKOFHFHDLGC FBLLMNEEMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly KPOMBEACODE KCJBBFNEJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JHCBDKPEMLJ<(long, long), IReadOnlyList<NMOAOAGEGEO>> ADNNPHANALI;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9880", Offset = "0x8BF8680", VA = "0x188BF9880")]
	[UnityEngine.Scripting.Preserve]
	public COADLJJNNCL([POMNKOCGGBN(null)] BKOFHFHDLGC JEIAHALNMNH, [POMNKOCGGBN(null)] KPOMBEACODE LJMMLFAFIEK, [POMNKOCGGBN(null)] NKFKONJEHCF AECMGEPFPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9480", Offset = "0x8BF8280", VA = "0x188BF9480")]
	[AsyncStateMachine(typeof(HJAGHBJHMKF))]
	public Task<IList<DNGDGMIPGJB>> BLLGOOFDILI(long MDNJLMOPJKG, long IHNMKJEEFMK, bool GDDCMKAEHOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8BF95D0", Offset = "0x8BF83D0", VA = "0x188BF95D0")]
	private bool FGCDDLGJALM(DateTime? KJDADNJCDEG, long MDNJLMOPJKG, long IHNMKJEEFMK, [Out] KGMHFIJAHBM MPGGIHFBNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9770", Offset = "0x8BF8570", VA = "0x188BF9770")]
	[AsyncStateMachine(typeof(PJHJCEDLOPN))]
	private Task<IReadOnlyList<(int, MPPKGBDBLNO, NMOAOAGEGEO)>> JAMBHOMCNHJ(IReadOnlyList<NMOAOAGEGEO> AIBFPDJGHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KPOMBEACODE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KGMHFIJAHBM> AFMFAIHKJGH;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PGIHJDHJNED(long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA, AFPPAFDLPDP KBBJPPACKCH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HFIECNGEKKK(long MDNJLMOPJKG, long IHNMKJEEFMK, [Out] KGMHFIJAHBM MPGGIHFBNCF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GPEJAONCIDG(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, [Out] KGMHFIJAHBM MPGGIHFBNCF);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGCEHCLEMBA(long MDNJLMOPJKG, long IHNMKJEEFMK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface ONEFPPOEOKA : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IEABIKDDJED
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task JNGHGPGDOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIACJAIACPH(Task MGEGHBBNKMN, string NEICHPLNJKE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface HIBGCPDEADP : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NNJLPCOCOKC> IPPDBGBBDIB(KGMHFIJAHBM MPGGIHFBNCF);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EAGPHNJHAHC(CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface INAAMCKLIGL : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JJKJPMLPAEJ KJHPEJIHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDOKALLAGJA();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGAAKGELPKB();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface PACANJLKDOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface MKCNBLPKEJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan AGCLPOGNABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan ACJHGOPGKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LOFBNJNIEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan MAHIAOMMBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DJOIKFKECBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NDCPNFMOCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool INGJCLFEJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LBBPKFCJABC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool AAHNIPEAHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GBLFGIKLCMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool LEFIHOMKKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum MBFAPKHCGBM
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum LEGHDHACNFL
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct KMEBIHHKPIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long KLEHBHOCJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long JDPEMOIFJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly MBFAPKHCGBM ADGMECOLKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception BBPFBOHFKOB;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8C07560", Offset = "0x8C06360", VA = "0x188C07560")]
	public KMEBIHHKPIL(long KLEHBHOCJLK, long JDPEMOIFJMF, MBFAPKHCGBM ADGMECOLKNH, [CanBeNull] Exception BBPFBOHFKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8C07510", Offset = "0x8C06310", VA = "0x188C07510")]
	public static KMEBIHHKPIL BADAHKFBFDJ(LLDPOPPOJLA NGAIIHDMKAH, MBFAPKHCGBM ADGMECOLKNH, [Optional] Exception BBPFBOHFKOB)
	{
		return default(KMEBIHHKPIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void PAKLFDLCEJJ(KMEBIHHKPIL GHKJCAKPEIE);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface OCLKMIHCAHK : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PAKLFDLCEJJ BKJAAKPNNBB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PAKLFDLCEJJ MAJBDMOOKKH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event PAKLFDLCEJJ PGKBEBLNLKL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<LEGHDHACNFL, bool> GDOKPKKGBMD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODLMMAEKPLC(KMEBIHHKPIL GHKJCAKPEIE);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DFNHEFPIONA(KMEBIHHKPIL GHKJCAKPEIE);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HEOEJCGDDGA(KMEBIHHKPIL GHKJCAKPEIE);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HECJPOFDCKA(LEGHDHACNFL OODCGCPIBCE, bool GELGIOCPDPF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface IMENGCEMAJB : PACANJLKDOI, IDisposable, ELDLNLHNOJF
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EKDCNLPFIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNCCDLGKKEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface GENGDCGMPEK : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus MCBGFBIKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DJHPEPBMGDE(LLDPOPPOJLA LMJDCEMLMAN, IAGHGJELDIE GNPBJNJABPP, CancellationToken EGDCEEDDFBN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class PBCOPILLCHO
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8C123C0", Offset = "0x8C111C0", VA = "0x188C123C0")]
	public static bool NLDGHMMJBNF(this GENGDCGMPEK OHFMLAGLMCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task COCCHNMONLJ(CancellationToken OBGCPOCPFIJ, int JEGICDLHAME, DPLLHLFGGEJ NDAFINBIAGM);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface JEKFCFJJFHG : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ILFMEDMOPPC(COCCHNMONLJ AOCBOLBIGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface BKHBBNALJMN : FPFANPNLBJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken AIOEGFGALPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HJFNEHLLJBB MCKFJKLOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NLCNBLMKPKF MJCKKDBINKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MNCIJOJOHAA BHMGALMBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BCCBMBDKCFH CLFPBMBDJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BICJCAEOEKC IAOMMLKOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IGMEPLKOBCH CFLJFAOPIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HPNNPDPCEKD BMHHGMIIDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ONEFPPOEOKA DMLBABBMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HIBGCPDEADP KOGKAKFPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OCLKMIHCAHK KCHFBJHAPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IMENGCEMAJB LANJPMKGEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GENGDCGMPEK MIPADBCGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JEKFCFJJFHG AOCMLMADJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KJCDLHBHNNH IAKCKFAPEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	ENBNHDAFLDP JFLFPDDGHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LLBCPNNOOCL HPKGIHFNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ENGCPEENHKJ OKKAKKLCPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	ECNGILNHGCF HMGLLEJCJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ECPFGKALGBL ILNPBLKLLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	APCNMIFPBOE LCJGLHKFLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MBANBMMMEBF GHLMHBGPMND
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	HJIGKFACLAK BEIHCILGFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GLNAAPALNHF BPMIGOGHEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	INAAMCKLIGL IMECDPHMKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	MKCNBLPKEJJ NCGJILFJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	ICPAKBIFELN FJMNOHEMJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	KPOMBEACODE MOKACMFBIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	BBBGOICJMGJ BKIMKKJCGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	ABCKMKEECEK MOMOHGGBALH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AACGFKBPLDB MLMDDPPJHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	FDFKLLFNDOG ACIINALPKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool OGKPLBNHKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IBKEGPHGFFO(IAGHGJELDIE EJIPIBHNOPG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface KJCDLHBHNNH : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOGBGGJMGKJ DPHJBDIDPOG(Guid ECLLBKCDLFA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDNHCHGJFLC(Guid ECLLBKCDLFA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DJGHPOCBJAI(Guid ECLLBKCDLFA, Task IDLCAHPEJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FCFBGNOIJCC(Guid ECLLBKCDLFA, NNJLPCOCOKC DCGOOOIOJGK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(NNJLPCOCOKC, Task)> DJEEPDDLHHN(Guid ECLLBKCDLFA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NMBKBOHNGHD : PACANJLKDOI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface ENBNHDAFLDP : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDDLHJKBLKL(ILNIOCDMOKB JDFCBBCKOGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIMOAMJHIIB(ILNIOCDMOKB JDFCBBCKOGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<FLHPGIIOBFD> OKINLHEBMLO(CancellationToken CHOMEKPCGPM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface LLBCPNNOOCL : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOGBGGJMGKJ PEDIJKIIDBC(ILNIOCDMOKB DMHBAOAIEJN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAKKGGECDBP(Guid ECLLBKCDLFA, Task IDLCAHPEJJJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface ENGCPEENHKJ : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NNJLPCOCOKC> OKKAKKLCPMA(ILNIOCDMOKB LAHBGBIGJEE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface ECNGILNHGCF : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OHMMKMCFEGD> JLEBBJLBGMJ(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, LLDPOPPOJLA LMJDCEMLMAN, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface APCNMIFPBOE : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNJLPCOCOKC LOALCGCFGEK(AFLCFHLHEHB PIFHDCCNIPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JDCGCGOHHPL(string GHADMHNDJBK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface ECPFGKALGBL : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ILNIOCDMOKB> PKCMMGFKLBP(ILNIOCDMOKB FGKGCIHOGKN, CPDEBMGDJII NBFILLHKEPM, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ILNIOCDMOKB> EOMPDBJKCDA(CancellationToken BKHGNHANFKK, CPDEBMGDJII NBFILLHKEPM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PJFBPPKKEKB HGBCKEOJKDK(PCPABMKPHMB GLNNBBFIJKE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PJFBPPKKEKB BMFMGNIMAMJ(PCPABMKPHMB GLNNBBFIJKE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface MBANBMMMEBF : PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNJLPCOCOKC MCBHDALHIFO(AFLCFHLHEHB PIFHDCCNIPJ, FLHPGIIOBFD BIMCGLHMFPP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNJLPCOCOKC GECEGNJHKBC(AFLCFHLHEHB MBABEJBFODJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KCCDLLPMDJE
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int ADICJDHDJAB = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, NAKGCEKNOJJ> OEOAFEGKKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action PJKEFDOLPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> AIANHCHPMGG();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task EMJIOFLGCFJ([Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DKEMBCEKLMN([Optional] CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface HJIGKFACLAK
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPDNCOFBFCP(EGKFILNOONF GHCJOEECHGI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAAKDCGCDNB(EGKFILNOONF GHCJOEECHGI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBDAJNKHAHJ(EGKFILNOONF GHCJOEECHGI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONANLCKCGEF(EGKFILNOONF GHCJOEECHGI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EGKFILNOONF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly LLDPOPPOJLA LNPIFOLEEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> LOAJJBFFOHJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public GMHMEBHNAOE<string> DBMKIIADBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public EGKFILNOONF(LLDPOPPOJLA CIOKEJIGMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8BFA4B0", Offset = "0x8BF92B0", VA = "0x188BFA4B0")]
	public EGKFILNOONF EKJCPLLBDHN(string OPGJHIOADCK, string HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8BFA420", Offset = "0x8BF9220", VA = "0x188BFA420")]
	public bool CMHMOJCFGAF([Out] IEnumerable<KeyValuePair<string, string>> HEEEPGEGHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B04E80", Offset = "0x7B03C80", VA = "0x187B04E80")]
	public EGKFILNOONF OGEMACPBIBL(GMHMEBHNAOE<string> CIEPDNOLKJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ICPAKBIFELN
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DGJFLCJEIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string LHGCLMNBDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MCGOAONJPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMIDNNLGPEF();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MHEFMIEILGL GILBDFGLMNJ(long FMOODPJPGFG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KECBMBBFCMF<PEDNEEGBGKL, LFIMFEFFJLO> LMEEJFGEICN(long FMOODPJPGFG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KECBMBBFCMF<PEDNEEGBGKL, GJJFFFDCKLI> NGOIICJADNA(long FMOODPJPGFG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KECBMBBFCMF<long, GMPLNGBLHHL> IGLHGEKGPDM();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<NKAOJOEBCKL>> HBGEJMFFBNH(long FMOODPJPGFG, IReadOnlyCollection<NKAOJOEBCKL> ECELHJOFBGE, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IJCEJPOPCDN(long FMOODPJPGFG, [Out] bool HGNJNGPKCFL);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> AMAIGCDDNPG(byte[] JJDLOODFHIA, byte[] IKFFNBFABMM, IReadOnlyCollection<Guid> NGPMAHCGJGA, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CGKLOKJJAKM
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHMMKMCFEGD INIHOJCCLPM(long KLEHBHOCJLK, long JDPEMOIFJMF, string ELKCLIPKPIB);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OHMMKMCFEGD INIHOJCCLPM(long KLEHBHOCJLK, long JDPEMOIFJMF, PEDNEEGBGKL JJDLOODFHIA, Guid? GCNOKGEOIKL, long LAANHDPLMPH, bool ANFCDNEEAMP);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OHMMKMCFEGD INIHOJCCLPM(MAOJOMONGLP CMIKLJDNGLB);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OHMMKMCFEGD INIHOJCCLPM(CPKIDEJABEO MHNPPDDHPDN, NMOAOAGEGEO FJAEDAABDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface FPFANPNLBJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool NLDGHMMJBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool MJBJGILAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool OGKPLBNHKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	CGKLOKJJAKM EPJJGDMBEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	IAGHGJELDIE CJEPOLCABOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event PAKLFDLCEJJ BKJAAKPNNBB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event PAKLFDLCEJJ MAJBDMOOKKH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event PAKLFDLCEJJ PGKBEBLNLKL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LEGHDHACNFL, bool> GDOKPKKGBMD;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JNCCDLGKKEJ();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CDFCDLDPOPN KDEPKBEPNCO();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MMDDJNGOMEC JNJDONDBAIJ();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task EDGDJPENNNK(int KDAOGIDDFPA, AEEKNFEBJIC MJONPNHCEAJ, Func<BONMJCCGPMP, BONMJCCGPMP> LBCCPLMNFCL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<NNJLPCOCOKC> IPPDBGBBDIB(KGMHFIJAHBM BIAIDCADKFG);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task EAGPHNJHAHC(CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BCCBMBDKCFH
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HCEGGLCIHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GMCCKJEJMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? OGFKMCPCLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPMAIKBIGIP(Scene JCGPOMNMMEL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JLPFKAMNDAP(BCLIAPEMAFA BNAEDBGEMCM, IReadOnlyList<BCLIAPEMAFA> CNDOJACELNE, IReadOnlyList<BCLIAPEMAFA> CFKOILHKFAJ, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKKJLHEKOPD(Guid KBIMFOALPIJ, IReadOnlyList<Guid> NGPMAHCGJGA, DNCCPNAJGCH MMDFONGGHEE, [Optional] object KCNMMDHIPIF);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CIJCOIDHGPE(IReadOnlyList<Guid> CMPNOPFHKPK, CancellationToken AOMINCEPKOC);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ECLDCOKKIMI IOECAKNMMMP();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task GLKLNDDELGA();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AGLCMJOKEIF(GameObject OADMNNJGFJI);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task MBIKMPKOGGF();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface OEGPLBBEHEH
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool FLDGPELGGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool NKACBFIJOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool OKJBGFOAOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool GJGBDHCJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int GCMFMMFKKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool NHDHJMDHBGL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool MGOLLJBJKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int DNLPHICICEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int FEAEKNLONLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool GPEIDAGPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool NKAFDAFJEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool CIDEKGPEBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float LBNFODLDAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> HPLNJNIACPK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HJFNEHLLJBB HLEKNHAPJJG(HJFNEHLLJBB GNJEHMEOCCD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHFCAAAOPDO(HJFNEHLLJBB HPOMHCIJOHD);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNNOGCKNHBE();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task JMMFCPDKLBA(GMHMEBHNAOE<string>.HGELJMPBEBF HEILGGOBCHH, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIGFBJPCAOK(float JKBCNBCAOIC);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGAEADIJANK(string KCAHPOJKMFB);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<ECPGLILLNAG> CGNLNGMICBD();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable HKHMIGLNKKC(object KKBNGKDBMPF, ECPGLILLNAG PMJKNCNKPFJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<AKHHBPOFABD> EFLGONGPJMB();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LFIMFEFFJLO MEGPOHOCJFG(IEnumerable<NBHBELOMHAF> IFJJIKHPOHG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CIECHDNHJEB(int OIBEBELDBPO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task LKDJOBHJOED();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ECIHJEINJEB();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GNDNFAAMDAM();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task FFHFBKJEIFE(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task NJEICPCOCDH(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<KLIPGMNCEHI> JIMEGIFCPAI(DateTime CPMAEPDCJPP, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> PPCHIMMOANP(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OEFCNDPLOOE(string JDFCBBCKOGJ = "", float DFOOIFEDPMI = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KKMHEHMBILH PHIGPCICCHI(GAMMILDHGNJ FJJFOGPMEPG, GHBEDJAHBFG KPMIKLAENNK, GJJFFFDCKLI EHLMDPDLECO, IEnumerable<PersistenceView> EGKHKKEIBFB, MENBPLBKBNC NKIDENMICPE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MNAPLPOAODH(GJJFFFDCKLI EHLMDPDLECO);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ILOBKCILCJM(NBHBELOMHAF MLOICMPKKEC, [In] KKMHEHMBILH OHILBHJCCLG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task HMBJCLJEPEI(GJJFFFDCKLI MMJOLFLJNDE, bool BMGHDFOKENE, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task LOLHKHPOOJJ(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EAGBAPNBLGB(long MDNJLMOPJKG, long JDPEMOIFJMF, CPKIDEJABEO ENGKJAJBOCI, NMOAOAGEGEO OJJOEOBIJPB, BONMJCCGPMP LMPMNOIEEBA, AEEKNFEBJIC? MJONPNHCEAJ, IJBCPJDBMGJ? DLJBFCJMKNL);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FKHODFHCBLM(long MDNJLMOPJKG, long JDPEMOIFJMF, IJBCPJDBMGJ? DLJBFCJMKNL);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GPHNFPKBNNL(PersistenceView DNHGLDCOJEL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void DIGPIOJCMOB(string GHOFJAJGOEJ, LLDPOPPOJLA CIOKEJIGMAO, EBODNCFCALI GDJLELBOJDE, [Optional] string? ADJIANOKCJP, [Optional] string? MJEEDANMMNF, [Optional] string? IHLFCCGLHOG);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool PMODEAABNLJ(PersistenceView LNFCNKMMELP);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PNEAKGDCNNJ(NBHBELOMHAF MLOICMPKKEC, OENCDFMFFLF HPLBAKAECJN, [Out] PPPBAFINOPF LLDEJNOMKLB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task DINADAAEEEO(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void INLOMLCBNEN();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable IECCHCPKNNM();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void LKGDOGMGPPP(GJJFFFDCKLI MMJOLFLJNDE, OENCDFMFFLF HPLBAKAECJN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> DOFJOILCEKE(NLCNBLMKPKF LPOEOKNKAFK, CancellationToken BKHGNHANFKK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void OHHOOFFMPMG(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<MAOJOMONGLP> KKMODPIJCLJ(FENJKEMFFBB FGKGCIHOGKN);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<CPKIDEJABEO> NGLNJKEAJIM(long MDNJLMOPJKG, bool DJIMOEEPBMA, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<FGABJAJCODN> MFFEGPFEBGO(long MDNJLMOPJKG, long JDPEMOIFJMF, long LAANHDPLMPH, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<NMOAOAGEGEO> IIGIAKBKEKN(long MDNJLMOPJKG, long JDPEMOIFJMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<EKMIFMNPMNP> LOBEONJLCJH(long MDNJLMOPJKG, Guid DGCKAILPHJP, long? IHNMKJEEFMK, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	KECBMBBFCMF<EKMIFMNPMNP, IEnumerable<EOFGCLOEFFA>> CAOEKHKGKMF();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<FMCAFGCNOGM> JMIPJMAHDKL(string ELKCLIPKPIB, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<FMCAFGCNOGM> LDEKNODPNOE(string ELKCLIPKPIB, long MDNJLMOPJKG, long JDPEMOIFJMF, Guid? KBIMFOALPIJ, LNABKHPNKHD.KAIGKENNNKK OEACCCPPJMI, LNABKHPNKHD.KAIGKENNNKK IKFFNBFABMM, int KDAOGIDDFPA);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool EAABNLGLEFM();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool OMOPMAFMJDE();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool HJNANBFMAJE(IEnumerable<PPPBAFINOPF> GMDMJGIEPGC);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void LPCAJECCNFK(List<GameObject> EODOAGLPBMB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float LEPJHPOBBGC();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> LKGAPLEKFBA(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> ECKPKCPLGMG(string GOOLFDMIDOG, LoadSceneMode ELLPJLBMKGD, bool GONPPHHPMKG, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void PEJHBKFECPK(bool GDNKPNFMPCI);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void OMHEENHOHNP();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void GGAEEBHAHIC();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void KHHPLACKKCK(bool FPLCLFOIKEA);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<LNABKHPNKHD.KAIGKENNNKK> NOOPNNGCPCP(byte[] KANAIIDGHCH, LNABKHPNKHD.DLBBHJDDLFG GFDBDLKMOEN, DOCMGFAFKBE DPDAOJBIEFI, [Optional] IReadOnlyCollection<string>? CIFKKJPMMPM, [Optional] string? BNAAPGAGNBH);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void NEGDAAHMINH(LLDPOPPOJLA FPOKPILNHJL);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task HIFOAFBBNMJ(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task ADODGPDMPAA(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task CLKNODHALFD(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task JJKBCDIDINK(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable CDPLGCJEDHJ();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	OCHEPNOJHGL PMOFIEKMJON();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task MIGIEMEEPBP(CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface OCHEPNOJHGL
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PFPCKKANACO(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JCKMDCOENND(CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct KKMHEHMBILH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> OKADBJJBKCJ;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum KLIPGMNCEHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct GAMMILDHGNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? EJDIBFPKOEJ;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface LIJLGLDJKPB
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	LLDPOPPOJLA PCPJAANLNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	CPKIDEJABEO AGIBLJBFMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	COOMNKKPKFC FCOFGCNNMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool CPLEJLEDPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool GGPDINMCCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int NBMPGCPKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action KEODHPPDJPH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> MFDEDNLBGIH;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BINADFEHAOI();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.LHAKPEAOKAM> GAGOKPBIKGM(long FMOODPJPGFG, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CIHKKDAJFFI> ECKJLLGIBLD(LLDPOPPOJLA CIOKEJIGMAO, [Optional] IAGHGJELDIE GNPBJNJABPP);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<CIHKKDAJFFI> MJPGCGPKGEE();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task CAAIHLHLDFF();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(LLDPOPPOJLA, IAGHGJELDIE) MGOACCICADP();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OKDCCHNMBFL DCBEKBDGOKP();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DDLHPLHCKPO(long FMOODPJPGFG);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OMGGIHKEOJJ(LLDPOPPOJLA CIOKEJIGMAO, Matchmaking.DGCGHAIADGL MOBFLOHJOKJ, (int Major, int? Minor)? KAFEFLDOPOC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GLNAAPALNHF
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDNEIJOFKBB([Out] IEnumerable<int> IJGFDHIOMKN);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJLNPEJIGOE(NLFFFLJOFLP OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADLJNHHHPCM(NLFFFLJOFLP OBGCPOCPFIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JIIPKMIGMHL
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NMKLEPGPFGB(NNJLPCOCOKC IJLMDLOJGML);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface IJLHLAOFOOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOCCAGMEGFD(EIJKIGNEDPJ.GNFMBJHLOJJ FIBPAMJFNMA);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMMMHDKPHNG(EIJKIGNEDPJ.GNFMBJHLOJJ FIBPAMJFNMA);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BICJCAEOEKC : IJLHLAOFOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNJLPCOCOKC DANAIPIPBLA(AFLCFHLHEHB MBABEJBFODJ);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IGMEPLKOBCH : IJLHLAOFOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNJLPCOCOKC LOALCGCFGEK(AFLCFHLHEHB EAJPHPMCNGA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MHEFMIEILGL
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> LFPHPMDJODB(Guid? KBIMFOALPIJ, IReadOnlyCollection<NKAOJOEBCKL> OMELALCDCMK, IReadOnlyCollection<NKAOJOEBCKL> DEAPGADLLKL, GKKOJDBIHFD PANMJANNBHH, long? MDNJLMOPJKG, long? JDPEMOIFJMF, AINNPJEFJIL.GILMFJIONGI OADGFJMCDJL, CancellationToken BKHGNHANFKK, bool INNECAFJJFJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class LIPFNIMMLCA
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public BCLIAPEMAFA KAOJJCONJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<BCLIAPEMAFA> DCGPLLGPPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<BCLIAPEMAFA> OCBMILCBOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xDE3F00", Offset = "0xDE2D00", VA = "0x180DE3F00")]
	public LIPFNIMMLCA(BCLIAPEMAFA JKABJMNDDIJ, IReadOnlyList<BCLIAPEMAFA> GNMIAIIKIKK, IReadOnlyList<BCLIAPEMAFA> NPHBABHNMPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KECBMBBFCMF<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GECIHKBMECG<NOKKJCMJLPA<TData>, NILBFGOPNAM>> NAANFHOPGHP(TGetDataArg EIENELGOLAB, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class APJKMKJKOEI : BKHBBNALJMN, FPFANPNLBJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct JFBAOHIMPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public APJKMKJKOEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KGMHFIJAHBM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<NNJLPCOCOKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C06130", Offset = "0x8C04F30", VA = "0x188C06130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C063B0", Offset = "0x8C051B0", VA = "0x188C063B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct DAKAEBGECMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public APJKMKJKOEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9AE0", Offset = "0x8BF88E0", VA = "0x188BF9AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9D10", Offset = "0x8BF8B10", VA = "0x188BF9D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class GOAIJLCEKHI : IEnumerable<PACANJLKDOI>, IEnumerable, IEnumerator<PACANJLKDOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private PACANJLKDOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public APJKMKJKOEI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private PACANJLKDOI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public GOAIJLCEKHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BFDFA0", Offset = "0x8BFCDA0", VA = "0x188BFDFA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE400", Offset = "0x8BFD200", VA = "0x188BFE400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE350", Offset = "0x8BFD150", VA = "0x188BFE350", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PACANJLKDOI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE350", Offset = "0x8BFD150", VA = "0x188BFE350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource KDLJNFKKCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HJFNEHLLJBB HPOMHCIJOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private CCLNBEONIHD CEADFLMCMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool PNLFHPHNLAA;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NLCNBLMKPKF MJCKKDBINKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public MNCIJOJOHAA BHMGALMBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BCCBMBDKCFH CLFPBMBDJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA93200", Offset = "0xA92000", VA = "0x180A93200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public BICJCAEOEKC IAOMMLKOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA98250", Offset = "0xA97050", VA = "0x180A98250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IGMEPLKOBCH CFLJFAOPIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEB0", Offset = "0xA9DCB0", VA = "0x180A9EEB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE90", Offset = "0xA9DC90", VA = "0x180A9EE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public CGKLOKJJAKM EPJJGDMBEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDA0", Offset = "0xA9DBA0", VA = "0x180A9EDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public HPNNPDPCEKD BMHHGMIIDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDF0", Offset = "0xA9DBF0", VA = "0x180A9EDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public ONEFPPOEOKA DMLBABBMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB633E0", Offset = "0xB621E0", VA = "0x180B633E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HIBGCPDEADP KOGKAKFPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE60", Offset = "0xA9DC60", VA = "0x180A9EE60", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE40", Offset = "0xA9DC40", VA = "0x180A9EE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OCLKMIHCAHK KCHFBJHAPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xB631C0", Offset = "0xB61FC0", VA = "0x180B631C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB635F0", Offset = "0xB623F0", VA = "0x180B635F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IMENGCEMAJB LANJPMKGEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAA3060", Offset = "0xAA1E60", VA = "0x180AA3060", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA1F20", VA = "0x180AA3120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GENGDCGMPEK MIPADBCGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB631D0", Offset = "0xB61FD0", VA = "0x180B631D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB633B0", Offset = "0xB621B0", VA = "0x180B633B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JEKFCFJJFHG AOCMLMADJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xEB9C60", Offset = "0xEB8A60", VA = "0x180EB9C60", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xEB9C70", Offset = "0xEB8A70", VA = "0x180EB9C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KJCDLHBHNNH IAKCKFAPEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB63180", Offset = "0xB61F80", VA = "0x180B63180", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFE0", Offset = "0xB8CDE0", VA = "0x180B8DFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public NMBKBOHNGHD FCPFGLFBBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xB63620", Offset = "0xB62420", VA = "0x180B63620", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xB635C0", Offset = "0xB623C0", VA = "0x180B635C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public ENBNHDAFLDP JFLFPDDGHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xB23990", Offset = "0xB22790", VA = "0x180B23990", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xB26F70", Offset = "0xB25D70", VA = "0x180B26F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public LLBCPNNOOCL HPKGIHFNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xAA30F0", Offset = "0xAA1EF0", VA = "0x180AA30F0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xAA30D0", Offset = "0xAA1ED0", VA = "0x180AA30D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public ENGCPEENHKJ OKKAKKLCPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xB275F0", Offset = "0xB263F0", VA = "0x180B275F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xB26920", Offset = "0xB25720", VA = "0x180B26920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public ECNGILNHGCF HMGLLEJCJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB275E0", Offset = "0xB263E0", VA = "0x180B275E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB268D0", Offset = "0xB256D0", VA = "0x180B268D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public ECPFGKALGBL ILNPBLKLLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xB21D60", Offset = "0xB20B60", VA = "0x180B21D60", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB21FA0", Offset = "0xB20DA0", VA = "0x180B21FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public APCNMIFPBOE LCJGLHKFLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB2FB40", Offset = "0xB2E940", VA = "0x180B2FB40", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB2AF20", Offset = "0xB29D20", VA = "0x180B2AF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public MBANBMMMEBF GHLMHBGPMND
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xB23880", Offset = "0xB22680", VA = "0x180B23880", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xB2B690", Offset = "0xB2A490", VA = "0x180B2B690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public HJIGKFACLAK BEIHCILGFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xB25570", Offset = "0xB24370", VA = "0x180B25570", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xB242D0", Offset = "0xB230D0", VA = "0x180B242D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public GLNAAPALNHF BPMIGOGHEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xB25420", Offset = "0xB24220", VA = "0x180B25420", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xB24080", Offset = "0xB22E80", VA = "0x180B24080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public INAAMCKLIGL IMECDPHMKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAFA620", Offset = "0xAF9420", VA = "0x180AFA620", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xB25880", Offset = "0xB24680", VA = "0x180B25880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public MKCNBLPKEJJ NCGJILFJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xC0C380", Offset = "0xC0B180", VA = "0x180C0C380", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xC10B30", Offset = "0xC0F930", VA = "0x180C10B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public ICPAKBIFELN FJMNOHEMJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xB89730", Offset = "0xB88530", VA = "0x180B89730", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB7F940", Offset = "0xB7E740", VA = "0x180B7F940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public KPOMBEACODE MOKACMFBIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB893F0", Offset = "0xB881F0", VA = "0x180B893F0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public BBBGOICJMGJ BKIMKKJCGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xC0BB10", Offset = "0xC0A910", VA = "0x180C0BB10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public ABCKMKEECEK MOMOHGGBALH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xC0A400", Offset = "0xC09200", VA = "0x180C0A400", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public AACGFKBPLDB MLMDDPPJHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xC11470", Offset = "0xC10270", VA = "0x180C11470", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public FDFKLLFNDOG ACIINALPKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xC1CF50", Offset = "0xC1BD50", VA = "0x180C1CF50", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IAGHGJELDIE CJEPOLCABOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xC0FA30", Offset = "0xC0E830", VA = "0x180C0FA30", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xD8FF70", Offset = "0xD8ED70", VA = "0x180D8FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool BFICCCLAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5360", Offset = "0x8BF4160", VA = "0x188BF5360", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool MGNCOPEPIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4F20", Offset = "0x8BF3D20", VA = "0x188BF4F20", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool OCHKLFHKIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1F38E00", Offset = "0x1F37C00", VA = "0x181F38E00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken ADBEBNBIDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5480", Offset = "0x8BF4280", VA = "0x188BF5480", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private HJFNEHLLJBB PFFOGIJJDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool BMOBPNFMKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F38E00", Offset = "0x1F37C00", VA = "0x181F38E00", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F331F0", Offset = "0x1F31FF0", VA = "0x181F331F0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event PAKLFDLCEJJ BFLIECCPHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5020", Offset = "0x8BF3E20", VA = "0x188BF5020", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8BF45F0", Offset = "0x8BF33F0", VA = "0x188BF45F0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event PAKLFDLCEJJ FBONBHIHJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5420", Offset = "0x8BF4220", VA = "0x188BF5420", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4770", Offset = "0x8BF3570", VA = "0x188BF4770", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event PAKLFDLCEJJ EKGOKBGECDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5130", Offset = "0x8BF3F30", VA = "0x188BF5130", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF53C0", Offset = "0x8BF41C0", VA = "0x188BF53C0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<LEGHDHACNFL, bool> JGIPNDMIJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF3FF0", VA = "0x188BF51F0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF47D0", Offset = "0x8BF35D0", VA = "0x188BF47D0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xD8FF70", Offset = "0xD8ED70", VA = "0x180D8FF70", Slot = "39")]
	public void IBKEGPHGFFO(IAGHGJELDIE EJIPIBHNOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BF54A0", Offset = "0x8BF42A0", VA = "0x188BF54A0")]
	[UnityEngine.Scripting.Preserve]
	internal APJKMKJKOEI([POMNKOCGGBN(null)] HJFNEHLLJBB HPOMHCIJOHD, [POMNKOCGGBN(null)] NLCNBLMKPKF LPOEOKNKAFK, [POMNKOCGGBN(null)] MNCIJOJOHAA HGHPFIKEMHF, [POMNKOCGGBN(null)] OEGPLBBEHEH OLPMMDDOCOO, [POMNKOCGGBN(null)] BCCBMBDKCFH EJKAFEHPLAH, [POMNKOCGGBN(null)] BICJCAEOEKC AKAMNKBMAPF, [POMNKOCGGBN(null)] IGMEPLKOBCH MLMNKBBPKNB, [POMNKOCGGBN(null)] HPNNPDPCEKD OPEDACBIFAJ, [POMNKOCGGBN(null)] ONEFPPOEOKA FEMPPJOCFLI, [POMNKOCGGBN(null)] HIBGCPDEADP PKJCHFCMMJG, [POMNKOCGGBN(null)] OCLKMIHCAHK LEIEIBBJFFC, [POMNKOCGGBN(null)] IMENGCEMAJB DGGIHGMFBAP, [POMNKOCGGBN(null)] GENGDCGMPEK OHFMLAGLMCE, [POMNKOCGGBN(null)] JEKFCFJJFHG HFPEHEIGNJO, [POMNKOCGGBN(null)] KJCDLHBHNNH DACFPIGPEKO, [POMNKOCGGBN(null)] NMBKBOHNGHD HPCPAAGNKHK, [POMNKOCGGBN(null)] ENBNHDAFLDP OCKPINMPEHG, [POMNKOCGGBN(null)] LLBCPNNOOCL IAGOALOEDKN, [POMNKOCGGBN(null)] ENGCPEENHKJ NBODHDNPJLD, [POMNKOCGGBN(null)] ECNGILNHGCF HEOPEKAFEDE, [POMNKOCGGBN(null)] APCNMIFPBOE FEAIEGOABNN, [POMNKOCGGBN(null)] ECPFGKALGBL INIBCLEJJMF, [POMNKOCGGBN(null)] MBANBMMMEBF FJCJOGDFJGO, [POMNKOCGGBN(null)] HJIGKFACLAK FMDCEDPIGDM, [POMNKOCGGBN(null)] GLNAAPALNHF AANEPKJFGOH, [POMNKOCGGBN(null)] MKCNBLPKEJJ AFFIHAGMLBN, [POMNKOCGGBN(null)] ICPAKBIFELN KMMHONLOEOD, [POMNKOCGGBN(null)] KPOMBEACODE CFGBCDJEPMN, [POMNKOCGGBN(null)] BBBGOICJMGJ NDJNMFBBMKO, [POMNKOCGGBN(null)] ABCKMKEECEK IIINPBGJICL, [POMNKOCGGBN(null)] AACGFKBPLDB EBEMCJLPCDD, [POMNKOCGGBN(null)] FDFKLLFNDOG NHNDMEPANGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5080", Offset = "0x8BF3E80", VA = "0x188BF5080")]
	private void IEHCJBEIMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4940", Offset = "0x8BF3740", VA = "0x188BF4940", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4AD0", Offset = "0x8BF38D0", VA = "0x188BF4AD0", Slot = "51")]
	private void EAJBLPGLELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8BF46E0", Offset = "0x8BF34E0", VA = "0x188BF46E0", Slot = "52")]
	private CDFCDLDPOPN BDCEMEAHPNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4650", Offset = "0x8BF3450", VA = "0x188BF4650", Slot = "53")]
	private MMDDJNGOMEC ALBBGKCAFNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4C10", Offset = "0x8BF3A10", VA = "0x188BF4C10", Slot = "55")]
	public Task EDGDJPENNNK(int KDAOGIDDFPA, AEEKNFEBJIC MJONPNHCEAJ, Func<BONMJCCGPMP, BONMJCCGPMP> LBCCPLMNFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4830", Offset = "0x8BF3630", VA = "0x188BF4830")]
	private HMFMIOPGEHA DNPPLICOGFC(int KDAOGIDDFPA, AEEKNFEBJIC MJONPNHCEAJ, Func<BONMJCCGPMP, BONMJCCGPMP> LBCCPLMNFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5250", Offset = "0x8BF4050", VA = "0x188BF5250", Slot = "56")]
	[AsyncStateMachine(typeof(JFBAOHIMPPF))]
	private Task<NNJLPCOCOKC> KMCHBHHKFPN(KGMHFIJAHBM MPGGIHFBNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4B20", Offset = "0x8BF3920", VA = "0x188BF4B20", Slot = "57")]
	[AsyncStateMachine(typeof(DAKAEBGECMP))]
	private Task ECIOPAJFOOI(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4FA0", Offset = "0x8BF3DA0", VA = "0x188BF4FA0")]
	[IteratorStateMachine(typeof(GOAIJLCEKHI))]
	private IEnumerable<PACANJLKDOI> FKFHIHLAGGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5190", Offset = "0x8BF3F90", VA = "0x188BF5190")]
	[CompilerGenerated]
	private void KFNPPLLKFMI(PACANJLKDOI PGJHFGMMOON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class NAAPEHCIPAG : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1AC03B0", Offset = "0x1ABF1B0", VA = "0x181AC03B0")]
	public NAAPEHCIPAG(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class LJINCFLNCJM : ODPNDGHKAJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct INHGIEKKEHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<ODPNDGHKAJD.CPFJFGFPMGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<ELDLNLHNOJF.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LJINCFLNCJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C00D30", Offset = "0x8BFFB30", VA = "0x188C00D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C01030", Offset = "0x8BFFE30", VA = "0x188C01030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string BDGCMDOJJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C08CD0", Offset = "0x8C07AD0", VA = "0x188C08CD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public LJINCFLNCJM(BKHBBNALJMN HGNBPILIDCC, OEGPLBBEHEH OLPMMDDOCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8C08D00", Offset = "0x8C07B00", VA = "0x188C08D00", Slot = "5")]
	[AsyncStateMachine(typeof(INHGIEKKEHF))]
	public Task<ODPNDGHKAJD.CPFJFGFPMGB> LBJILENPIPN(HashSet<ELDLNLHNOJF.Reason> IEGJLMLFCLM, CancellationToken BKHGNHANFKK, ELDLNLHNOJF.Reason BCDABHDFJPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class AAFNIOBLMPB : NLEHPKGNJAH, ODPNDGHKAJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct IOBHMABFMGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<ODPNDGHKAJD.CPFJFGFPMGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AAFNIOBLMPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HashSet<ELDLNLHNOJF.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public ELDLNLHNOJF.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private LLDPOPPOJLA <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<ODPNDGHKAJD.CPFJFGFPMGB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C01860", Offset = "0x8C00660", VA = "0x188C01860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C02230", Offset = "0x8C01030", VA = "0x188C02230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly JKNHGMAKBCG NBMKMDBDJCC;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string BDGCMDOJJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF3620", Offset = "0x8BF2420", VA = "0x188BF3620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3820", Offset = "0x8BF2620", VA = "0x188BF3820")]
	public AAFNIOBLMPB([POMNKOCGGBN(null)] BKHBBNALJMN HGNBPILIDCC, [POMNKOCGGBN(null)] OEGPLBBEHEH OLPMMDDOCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3650", Offset = "0x8BF2450", VA = "0x188BF3650", Slot = "5")]
	[AsyncStateMachine(typeof(IOBHMABFMGD))]
	public Task<ODPNDGHKAJD.CPFJFGFPMGB> LBJILENPIPN(HashSet<ELDLNLHNOJF.Reason> IEGJLMLFCLM, CancellationToken BKHGNHANFKK, ELDLNLHNOJF.Reason BCDABHDFJPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class PGAAGNKPJEN : NLEHPKGNJAH, ODPNDGHKAJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KOOIBOJBLGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<ODPNDGHKAJD.CPFJFGFPMGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public PGAAGNKPJEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HashSet<ELDLNLHNOJF.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<CIHKKDAJFFI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<ODPNDGHKAJD.CPFJFGFPMGB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C07580", Offset = "0x8C06380", VA = "0x188C07580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C07F70", Offset = "0x8C06D70", VA = "0x188C07F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string BDGCMDOJJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C12410", Offset = "0x8C11210", VA = "0x188C12410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public PGAAGNKPJEN(BKHBBNALJMN HGNBPILIDCC, OEGPLBBEHEH OLPMMDDOCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8C12440", Offset = "0x8C11240", VA = "0x188C12440", Slot = "5")]
	[AsyncStateMachine(typeof(KOOIBOJBLGC))]
	public Task<ODPNDGHKAJD.CPFJFGFPMGB> LBJILENPIPN(HashSet<ELDLNLHNOJF.Reason> IEGJLMLFCLM, CancellationToken BKHGNHANFKK, ELDLNLHNOJF.Reason BCDABHDFJPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class HFAAIOECGFO : NLEHPKGNJAH, ODPNDGHKAJD
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EOLGLFMDHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CIHKKDAJFFI matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EOLGLFMDHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBA10", Offset = "0x8BFA810", VA = "0x188BFBA10")]
		internal object DKAGEKOINEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB950", Offset = "0x8BFA750", VA = "0x188BFB950")]
		internal object CEKKDFOHCEG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct APEIPMMFKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<ODPNDGHKAJD.CPFJFGFPMGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public HFAAIOECGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HashSet<ELDLNLHNOJF.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private EOLGLFMDHFE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public ELDLNLHNOJF.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<CIHKKDAJFFI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<ODPNDGHKAJD.CPFJFGFPMGB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BF38F0", Offset = "0x8BF26F0", VA = "0x188BF38F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF4580", Offset = "0x8BF3380", VA = "0x188BF4580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly JKNHGMAKBCG NBMKMDBDJCC;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string BDGCMDOJJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE450", Offset = "0x8BFD250", VA = "0x188BFE450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8BFE650", Offset = "0x8BFD450", VA = "0x188BFE650")]
	public HFAAIOECGFO([POMNKOCGGBN(null)] BKHBBNALJMN HGNBPILIDCC, [POMNKOCGGBN(null)] OEGPLBBEHEH OLPMMDDOCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8BFE480", Offset = "0x8BFD280", VA = "0x188BFE480", Slot = "5")]
	[AsyncStateMachine(typeof(APEIPMMFKJP))]
	public Task<ODPNDGHKAJD.CPFJFGFPMGB> LBJILENPIPN(HashSet<ELDLNLHNOJF.Reason> IEGJLMLFCLM, CancellationToken BKHGNHANFKK, ELDLNLHNOJF.Reason BCDABHDFJPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class NLEHPKGNJAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct FIJGPLMAJJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public ALMLLDBPKBM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HashSet<ELDLNLHNOJF.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public NLEHPKGNJAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<ELDLNLHNOJF.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBA90", Offset = "0x8BFA890", VA = "0x188BFBA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBFB0", Offset = "0x8BFADB0", VA = "0x188BFBFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected readonly BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected readonly OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C10410", Offset = "0x8C0F210", VA = "0x188C10410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public NLEHPKGNJAH(BKHBBNALJMN HGNBPILIDCC, OEGPLBBEHEH OLPMMDDOCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8C10460", Offset = "0x8C0F260", VA = "0x188C10460")]
	[AsyncStateMachine(typeof(FIJGPLMAJJO))]
	protected Task FCIFEMNKAHK(ALMLLDBPKBM IPEKLICENHF, HashSet<ELDLNLHNOJF.Reason> IEGJLMLFCLM, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NFOMGMIEMID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct POANGJMGOGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<ODPNDGHKAJD.CPFJFGFPMGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public OEGPLBBEHEH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C13060", Offset = "0x8C11E60", VA = "0x188C13060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C133E0", Offset = "0x8C121E0", VA = "0x188C133E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BPKONIFJPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public BKHBBNALJMN roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BPKONIFJPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6A00", Offset = "0x8BF5800", VA = "0x188BF6A00")]
		internal object EJIMNKDLEHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly float EJLJDPFENMH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal static readonly HashSet<ELDLNLHNOJF.Reason> EBFHKALGMFM;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FF70", Offset = "0x8C0ED70", VA = "0x188C0FF70")]
	[AsyncStateMachine(typeof(POANGJMGOGP))]
	internal static Task<ODPNDGHKAJD.CPFJFGFPMGB> NKKFLAKBMBE(OEGPLBBEHEH OLPMMDDOCOO, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FDF0", Offset = "0x8C0EBF0", VA = "0x188C0FDF0")]
	internal static void AGOCNHCIBFN(BKHBBNALJMN HGNBPILIDCC, ALMLLDBPKBM IPEKLICENHF, string GHOFJAJGOEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface ODPNDGHKAJD
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct CPFJFGFPMGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool GELGIOCPDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public ELDLNLHNOJF.Reason BCDABHDFJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Enum? IHLFCCGLHOG;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9AD0", Offset = "0x8BF88D0", VA = "0x188BF9AD0")]
		public static CPFJFGFPMGB PNPKBINCNBO()
		{
			return default(CPFJFGFPMGB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9AA0", Offset = "0x8BF88A0", VA = "0x188BF9AA0")]
		public static CPFJFGFPMGB IOHEPOPHMPG(ELDLNLHNOJF.Reason BCDABHDFJPD, [Optional] Enum? IHLFCCGLHOG)
		{
			return default(CPFJFGFPMGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string ABEGCGNNECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CPFJFGFPMGB> LBJILENPIPN(HashSet<ELDLNLHNOJF.Reason> IEGJLMLFCLM, CancellationToken BKHGNHANFKK, ELDLNLHNOJF.Reason BCDABHDFJPD);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct CMLHJHAIALM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class PPBNLMCCAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public BKHBBNALJMN manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PPBNLMCCAFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8C13450", Offset = "0x8C12250", VA = "0x188C13450")]
		internal Task CNKCNPAICEN(CancellationToken cancellationToken, int roomTotalVersion, DPLLHLFGGEJ localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct NPMBBFHANML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CMLHJHAIALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private KGMHFIJAHBM <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<KLIPGMNCEHI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<NNJLPCOCOKC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8C10590", Offset = "0x8C0F390", VA = "0x188C10590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8C10B20", Offset = "0x8C0F920", VA = "0x188C10B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct LMIKDDKGEPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public CMLHJHAIALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8C08E90", Offset = "0x8C07C90", VA = "0x188C08E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8C091B0", Offset = "0x8C07FB0", VA = "0x188C091B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CancellationToken BKHGNHANFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly BKHBBNALJMN EKOKCFOMOOD;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private NLCNBLMKPKF MJCKKDBINKL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8E10", Offset = "0x8BF7C10", VA = "0x188BF8E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8DC0", Offset = "0x8BF7BC0", VA = "0x188BF8DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8D40", Offset = "0x8BF7B40", VA = "0x188BF8D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private HIBGCPDEADP KOGKAKFPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9070", Offset = "0x8BF7E70", VA = "0x188BF9070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2680", Offset = "0x2AD1480", VA = "0x182AD2680")]
	public CMLHJHAIALM(CancellationToken BKHGNHANFKK, BKHBBNALJMN EKOKCFOMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8BF90C0", Offset = "0x8BF7EC0", VA = "0x188BF90C0")]
	public static COCCHNMONLJ JFDLBKDBGBJ(BKHBBNALJMN EKOKCFOMOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9370", Offset = "0x8BF8170", VA = "0x188BF9370")]
	[AsyncStateMachine(typeof(NPMBBFHANML))]
	public Task<bool> PLBGJCCDHGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8BF8E60", Offset = "0x8BF7C60", VA = "0x188BF8E60")]
	private bool FEPNMNOMJBH([Out] KGMHFIJAHBM MPGGIHFBNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9170", Offset = "0x8BF7F70", VA = "0x188BF9170")]
	[AsyncStateMachine(typeof(LMIKDDKGEPD))]
	private Task JHPMAMLNGFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8BF9240", Offset = "0x8BF8040", VA = "0x188BF9240")]
	private Task<KLIPGMNCEHI> MOGHNPJCCOI(KGMHFIJAHBM KGAPBGOOLOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct MOGBGGJMGKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly KJCDLHBHNNH DACFPIGPEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Guid ECLLBKCDLFA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(NNJLPCOCOKC, Task)> KBIGCNGAGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F760", Offset = "0x8C0E560", VA = "0x188C0F760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x566B2C0", Offset = "0x566A0C0", VA = "0x18566B2C0")]
	public MOGBGGJMGKJ(KJCDLHBHNNH DACFPIGPEKO, Guid ECLLBKCDLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F900", Offset = "0x8C0E700", VA = "0x188C0F900")]
	public TaskAwaiter<(NNJLPCOCOKC, Task)> MPIMODFPFBE()
	{
		return default(TaskAwaiter<(NNJLPCOCOKC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F830", Offset = "0x8C0E630", VA = "0x188C0F830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct GEPLMAALEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly TaskCompletionSource<(NNJLPCOCOKC, Task)> NBKEHFIPPMK;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(NNJLPCOCOKC, Task)> KBIGCNGAGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD9B0", Offset = "0x8BFC7B0", VA = "0x188BFD9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8BFDB60", Offset = "0x8BFC960", VA = "0x188BFDB60")]
	public GEPLMAALEOE(TimeSpan BCGOOMJHCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8BFD910", Offset = "0x8BFC710", VA = "0x188BFD910")]
	public void AJGEGONLDED(Task IDLCAHPEJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8BFD9F0", Offset = "0x8BFC7F0", VA = "0x188BFD9F0")]
	public void GJLILHBIHNC(NNJLPCOCOKC IJLMDLOJGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8BFDB10", Offset = "0x8BFC910", VA = "0x188BFDB10")]
	public void LLOJPDPOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8BFDA80", Offset = "0x8BFC880", VA = "0x188BFDA80")]
	internal void IDLBOODEBDK(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class CAIBGOBGHLH
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6B00", Offset = "0x8BF5900", VA = "0x188BF6B00")]
	public static OHMMKMCFEGD APJGCOIIHOD(this OHMMKMCFEGD OBBABGHFJAB, CPKIDEJABEO OLCEBLCGMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6CA0", Offset = "0x8BF5AA0", VA = "0x188BF6CA0")]
	public static OHMMKMCFEGD NJCCCCCDEBA(this OHMMKMCFEGD OBBABGHFJAB, NMOAOAGEGEO KBNLPFBJKDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class MEDAMPKKLNO : CGKLOKJJAKM
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class MAOFNKEIIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public NMOAOAGEGEO subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MAOFNKEIIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EFB0", Offset = "0x8C0DDB0", VA = "0x188C0EFB0")]
		internal bool JKMOKLGOAMA(COOMNKKPKFC s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly MKCNBLPKEJJ EFBENMHMCEM;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public MEDAMPKKLNO(MKCNBLPKEJJ AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F620", Offset = "0x8C0E420", VA = "0x188C0F620", Slot = "4")]
	public OHMMKMCFEGD INIHOJCCLPM(long KLEHBHOCJLK, long JDPEMOIFJMF, string ELKCLIPKPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8C0EFE0", Offset = "0x8C0DDE0", VA = "0x188C0EFE0", Slot = "5")]
	public OHMMKMCFEGD INIHOJCCLPM(long KLEHBHOCJLK, long JDPEMOIFJMF, PEDNEEGBGKL JJDLOODFHIA, Guid? GCNOKGEOIKL, long LAANHDPLMPH, bool ANFCDNEEAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F420", Offset = "0x8C0E220", VA = "0x188C0F420", Slot = "6")]
	public OHMMKMCFEGD INIHOJCCLPM(MAOJOMONGLP CMIKLJDNGLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F140", Offset = "0x8C0DF40", VA = "0x188C0F140", Slot = "7")]
	public OHMMKMCFEGD INIHOJCCLPM(CPKIDEJABEO MHNPPDDHPDN, NMOAOAGEGEO FJAEDAABDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F6B0", Offset = "0x8C0E4B0", VA = "0x188C0F6B0")]
	private Guid? JIGKMPIIDGE(CPKIDEJABEO HKMLHGGBCMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class KABKBJBHAJD : ONEFPPOEOKA, PACANJLKDOI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FLCBOPLIJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public KABKBJBHAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC010", Offset = "0x8BFAE10", VA = "0x188BFC010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC6A0", Offset = "0x8BFB4A0", VA = "0x188BFC6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly NLFFFLJOFLP EHDCLIEIIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string OIKMHKJPHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Task LGIODMDBJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool IEABIKDDJED
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8C07450", Offset = "0x8C06250", VA = "0x188C07450", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task JNGHGPGDOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8C07260", Offset = "0x8C06060", VA = "0x188C07260", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0", Slot = "7")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8C072F0", Offset = "0x8C060F0", VA = "0x188C072F0", Slot = "6")]
	public void EIACJAIACPH(Task MGEGHBBNKMN, string NEICHPLNJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8C07140", Offset = "0x8C05F40", VA = "0x188C07140")]
	[AsyncStateMachine(typeof(FLCBOPLIJOP))]
	private Task ALCNJKMAELP(Task OMDBMHNFEAH, string NEICHPLNJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8C07480", Offset = "0x8C06280", VA = "0x188C07480")]
	public KABKBJBHAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class NEEAJCPGMBE : INAAMCKLIGL, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool MKPJNHOFDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JJKJPMLPAEJ HFAPFAJHAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private MKCNBLPKEJJ AFFIHAGMLBN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JJKJPMLPAEJ KJHPEJIHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8C0FD80", Offset = "0x8C0EB80", VA = "0x188C0FD80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FA50", Offset = "0x8C0E850", VA = "0x188C0FA50", Slot = "7")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FBD0", Offset = "0x8C0E9D0", VA = "0x188C0FBD0", Slot = "5")]
	public void NDOKALLAGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F950", Offset = "0x8C0E750", VA = "0x188C0F950", Slot = "6")]
	public void DGAAKGELPKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F990", Offset = "0x8C0E790", VA = "0x188C0F990")]
	private Task EKMCDAFBFOA(EMKIIAKMNPE OGPILIPEPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F950", Offset = "0x8C0E750", VA = "0x188C0F950", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NEEAJCPGMBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class GADKGHOILAJ : MKCNBLPKEJJ
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class KPMGJOPLICH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly CEDIOCPLCGJ OOMNLGEDCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly string OPGJHIOADCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly T PGFMONBPOJI;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T DDHBFJGPDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB7BBD0", Offset = "0xB7A9D0", VA = "0x180B7BBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x55FDE20", Offset = "0x55FCC20", VA = "0x1855FDE20")]
		public KPMGJOPLICH(CEDIOCPLCGJ OOMNLGEDCIK, string OPGJHIOADCK, T PGFMONBPOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x55FD740", Offset = "0x55FC540", VA = "0x1855FD740")]
		private void POBKHFJGHCG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly CEDIOCPLCGJ OOMNLGEDCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly KPMGJOPLICH<TimeSpan> EKBJNHLJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly KPMGJOPLICH<TimeSpan> IEPJAALAKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly KPMGJOPLICH<TimeSpan> OCGDKBNBBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly KPMGJOPLICH<TimeSpan> KOJEPJGHOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly KPMGJOPLICH<bool> CNHEPCEDGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly KPMGJOPLICH<bool> LAKKIGFDJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly KPMGJOPLICH<bool> KOPHKNICBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly KPMGJOPLICH<int> JPCIMOCCOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly KPMGJOPLICH<bool> AONHHAEGIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly KPMGJOPLICH<bool> DPANGNOAMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly KPMGJOPLICH<MALLPKNKEKG> OIJMIGBBEBJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan AGCLPOGNABM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC780", Offset = "0x8BFB580", VA = "0x188BFC780", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan ACJHGOPGKOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC8D0", Offset = "0x8BFB6D0", VA = "0x188BFC8D0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan LOFBNJNIEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC7C0", Offset = "0x8BFB5C0", VA = "0x188BFC7C0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan MAHIAOMMBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC740", Offset = "0x8BFB540", VA = "0x188BFC740", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DJOIKFKECBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC700", Offset = "0x8BFB500", VA = "0x188BFC700", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NDCPNFMOCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC950", Offset = "0x8BFB750", VA = "0x188BFC950", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool INGJCLFEJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC910", Offset = "0x8BFB710", VA = "0x188BFC910", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int LBBPKFCJABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC800", Offset = "0x8BFB600", VA = "0x188BFC800", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool AAHNIPEAHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC990", Offset = "0x8BFB790", VA = "0x188BFC990", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool GBLFGIKLCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC890", Offset = "0x8BFB690", VA = "0x188BFC890", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LEFIHOMKKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC840", Offset = "0x8BFB640", VA = "0x188BFC840", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8BFC9D0", Offset = "0x8BFB7D0", VA = "0x188BFC9D0")]
	[UnityEngine.Scripting.Preserve]
	public GADKGHOILAJ([POMNKOCGGBN(null)] CEDIOCPLCGJ OOMNLGEDCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class IOAMBMHDAOJ : OCLKMIHCAHK, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class DGGNBMBLCJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public KMEBIHHKPIL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DGGNBMBLCJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA340", Offset = "0x8BF9140", VA = "0x188BFA340")]
		internal object AKPDGFCJNFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event PAKLFDLCEJJ BKJAAKPNNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8C01640", Offset = "0x8C00440", VA = "0x188C01640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8C010A0", Offset = "0x8BFFEA0", VA = "0x188C010A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event PAKLFDLCEJJ MAJBDMOOKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8C015A0", Offset = "0x8C003A0", VA = "0x188C015A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8C013D0", Offset = "0x8C001D0", VA = "0x188C013D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event PAKLFDLCEJJ PGKBEBLNLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8C01300", Offset = "0x8C00100", VA = "0x188C01300", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8C017C0", Offset = "0x8C005C0", VA = "0x188C017C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LEGHDHACNFL, bool> GDOKPKKGBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8C016E0", Offset = "0x8C004E0", VA = "0x188C016E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8C014F0", Offset = "0x8C002F0", VA = "0x188C014F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "16")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8C01790", Offset = "0x8C00590", VA = "0x188C01790", Slot = "12")]
	public void ODLMMAEKPLC(KMEBIHHKPIL GHKJCAKPEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8C013A0", Offset = "0x8C001A0", VA = "0x188C013A0", Slot = "13")]
	public void DFNHEFPIONA(KMEBIHHKPIL GHKJCAKPEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8C014C0", Offset = "0x8C002C0", VA = "0x188C014C0", Slot = "14")]
	public void HEOEJCGDDGA(KMEBIHHKPIL GHKJCAKPEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8C01470", Offset = "0x8C00270", VA = "0x188C01470", Slot = "15")]
	public void HECJPOFDCKA(LEGHDHACNFL OODCGCPIBCE, bool GELGIOCPDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8C01140", Offset = "0x8BFFF40", VA = "0x188C01140")]
	private void AHMKNKCPDKI(PAKLFDLCEJJ PMJKNCNKPFJ, KMEBIHHKPIL GHKJCAKPEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IOAMBMHDAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class ELCBILHDLEM : IMENGCEMAJB, PACANJLKDOI, IDisposable, ELDLNLHNOJF
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class CBKNDKGGBHI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct BLFPLLOCDBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public CBKNDKGGBHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public ELDLNLHNOJF.PGFNEINKDAG reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private OLBGEKIIFJE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private ODPNDGHKAJD[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private TaskAwaiter<ODPNDGHKAJD.CPFJFGFPMGB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF60D0", Offset = "0x8BF4ED0", VA = "0x188BF60D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x8BF6850", Offset = "0x8BF5650", VA = "0x188BF6850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct JFKEPLCLILD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AsyncTaskMethodBuilder<ODPNDGHKAJD.CPFJFGFPMGB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public ODPNDGHKAJD fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public CBKNDKGGBHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public ELDLNLHNOJF.PGFNEINKDAG reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private OLBGEKIIFJE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private GBDFGBOIKPK <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private TaskAwaiter<ODPNDGHKAJD.CPFJFGFPMGB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x8C06420", Offset = "0x8C05220", VA = "0x188C06420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8C070D0", Offset = "0x8C05ED0", VA = "0x188C070D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class NHKLGNDNNME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public ELDLNLHNOJF.PGFNEINKDAG reason;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public NHKLGNDNNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x8C101A0", Offset = "0x8C0EFA0", VA = "0x188C101A0")]
			internal object LNJBKGHMAOI((ELDLNLHNOJF.Reason fallbackReason, EBODNCFCALI roomDto, GBDFGBOIKPK state, string subReason) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class IOECJGOMGPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public ODPNDGHKAJD fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public IOECJGOMGPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8C022A0", Offset = "0x8C010A0", VA = "0x188C022A0")]
			internal object KGNNBECDEJP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Task MGEGHBBNKMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationTokenSource OBNLICOECJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GBDFGBOIKPK EHFBCNPHAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public OEGPLBBEHEH OLPMMDDOCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public EBODNCFCALI GDJLELBOJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public LLDPOPPOJLA CIOKEJIGMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public ODPNDGHKAJD[] NBKFDGNENOF;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool FCMNOCKJCIK
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF78B0", Offset = "0x8BF66B0", VA = "0x188BF78B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool DKEBLNILELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8690", Offset = "0x8BF7490", VA = "0x188BF8690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8C20", Offset = "0x8BF7A20", VA = "0x188BF8C20")]
		public CBKNDKGGBHI(OEGPLBBEHEH OLPMMDDOCOO, EBODNCFCALI GDJLELBOJDE, LLDPOPPOJLA CIOKEJIGMAO, ODPNDGHKAJD[] NBKFDGNENOF, CancellationToken BKHGNHANFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7470", Offset = "0x8BF6270", VA = "0x188BF7470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7A30", Offset = "0x8BF6830", VA = "0x188BF7A30")]
		public void JKMJNIJGOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8BF78D0", Offset = "0x8BF66D0", VA = "0x188BF78D0")]
		public void HPOMACHHLKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7AA0", Offset = "0x8BF68A0", VA = "0x188BF7AA0")]
		public void JMEFCFOOGDD(ELDLNLHNOJF.Reason PFIACOMABOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8BF77A0", Offset = "0x8BF65A0", VA = "0x188BF77A0")]
		[AsyncStateMachine(typeof(BLFPLLOCDBN))]
		public Task FJCFALDIOGE(ELDLNLHNOJF.PGFNEINKDAG BCDABHDFJPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8760", Offset = "0x8BF7560", VA = "0x188BF8760")]
		[AsyncStateMachine(typeof(JFKEPLCLILD))]
		private Task<ODPNDGHKAJD.CPFJFGFPMGB> PLIPKGAPINC(ELDLNLHNOJF.PGFNEINKDAG BCDABHDFJPD, ODPNDGHKAJD JLNDMEAAPFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8BF71F0", Offset = "0x8BF5FF0", VA = "0x188BF71F0")]
		private void DIOPHCDJGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8BF86B0", Offset = "0x8BF74B0", VA = "0x188BF86B0")]
		public bool PGKEENGJDBH(ELDLNLHNOJF.Reason CBFFAKNIOHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF83F0", Offset = "0x8BF71F0", VA = "0x188BF83F0")]
		private void PDGILKFAPLM(GBDFGBOIKPK GKGDEKNIOCH, ELDLNLHNOJF.PGFNEINKDAG BCDABHDFJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8110", Offset = "0x8BF6F10", VA = "0x188BF8110")]
		private void KCAMBKKKAFH(GBDFGBOIKPK GKGDEKNIOCH, ODPNDGHKAJD.CPFJFGFPMGB MOBFLOHJOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7600", Offset = "0x8BF6400", VA = "0x188BF7600")]
		private void FAANLDGCKKA(GBDFGBOIKPK GKGDEKNIOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7D50", Offset = "0x8BF6B50", VA = "0x188BF7D50")]
		private void JOMAIPEIIJF(GBDFGBOIKPK GKGDEKNIOCH, ODPNDGHKAJD.CPFJFGFPMGB MOBFLOHJOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7310", Offset = "0x8BF6110", VA = "0x188BF7310")]
		private void DKGKAJMOPDJ(GBDFGBOIKPK GKGDEKNIOCH, Exception AACEGADBPKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF82E0", Offset = "0x8BF70E0", VA = "0x188BF82E0")]
		private void OMMCMHAKLAK(ODPNDGHKAJD JLNDMEAAPFB, ELDLNLHNOJF.PGFNEINKDAG BCDABHDFJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8BF70E0", Offset = "0x8BF5EE0", VA = "0x188BF70E0")]
		private void AKLOIKMGDDD(ODPNDGHKAJD JLNDMEAAPFB, ELDLNLHNOJF.Reason BCDABHDFJPD, string IHLFCCGLHOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8BF88B0", Offset = "0x8BF76B0", VA = "0x188BF88B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class GBDFGBOIKPK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task<ODPNDGHKAJD.CPFJFGFPMGB> MGEGHBBNKMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CancellationTokenSource OBNLICOECJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public ODPNDGHKAJD JLNDMEAAPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public ELDLNLHNOJF.Reason PFIACOMABOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HashSet<ELDLNLHNOJF.Reason> IEGJLMLFCLM;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool FCMNOCKJCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8BF78B0", Offset = "0x8BF66B0", VA = "0x188BF78B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool DKEBLNILELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8BF8690", Offset = "0x8BF7490", VA = "0x188BF8690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCEC0", Offset = "0x8BFBCC0", VA = "0x188BFCEC0")]
		public void HHJCEDNCEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCEA0", Offset = "0x8BFBCA0", VA = "0x188BFCEA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD020", Offset = "0x8BFBE20", VA = "0x188BFD020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD380", Offset = "0x8BFC180", VA = "0x188BFD380")]
		public GBDFGBOIKPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class BNGBCDPFOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public ELDLNLHNOJF.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BNGBCDPFOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6990", Offset = "0x8BF5790", VA = "0x188BF6990")]
		internal object IBOAPCLAAJE(GBDFGBOIKPK x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF68B0", Offset = "0x8BF56B0", VA = "0x188BF68B0")]
		internal object GAAHLDODGMF(CBKNDKGGBHI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6920", Offset = "0x8BF5720", VA = "0x188BF6920")]
		internal object HKJFKKLAGNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct LDMOLDFEICP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public ELDLNLHNOJF.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ELCBILHDLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private BNGBCDPFOOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Exception exception;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C07FE0", Offset = "0x8C06DE0", VA = "0x188C07FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C08C00", Offset = "0x8C07A00", VA = "0x188C08C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct HKEMDOFJHIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ELCBILHDLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ELDLNLHNOJF.PGFNEINKDAG reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private CBKNDKGGBHI <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BFF5D0", Offset = "0x8BFE3D0", VA = "0x188BFF5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C00260", Offset = "0x8BFF060", VA = "0x188C00260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct DDIOFCOHOHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public ELCBILHDLEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9D70", Offset = "0x8BF8B70", VA = "0x188BF9D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA2E0", Offset = "0x8BF90E0", VA = "0x188BFA2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	internal static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	internal static readonly ALMLLDBPKBM NNCLEGHIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private CBKNDKGGBHI PHMFGNNENJK;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAE60", Offset = "0x8BF9C60", VA = "0x188BFAE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool EKDCNLPFIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2705C70", Offset = "0x2704A70", VA = "0x182705C70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool NBEJHLJLDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB500", Offset = "0x8BFA300", VA = "0x188BFB500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB6F0", Offset = "0x8BFA4F0", VA = "0x188BFB6F0", Slot = "6")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB4F0", Offset = "0x8BFA2F0", VA = "0x188BFB4F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB570", Offset = "0x8BFA370", VA = "0x188BFB570", Slot = "9")]
	public void HHJCEDNCEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB410", Offset = "0x8BFA210", VA = "0x188BFB410")]
	private bool DNBOIFODPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8BFAC70", Offset = "0x8BF9A70", VA = "0x188BFAC70", Slot = "5")]
	private void BJMCBCIHGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8BFAD40", Offset = "0x8BF9B40", VA = "0x188BFAD40", Slot = "8")]
	[AsyncStateMachine(typeof(LDMOLDFEICP))]
	public Task CHLBLFFKCLI(ELDLNLHNOJF.Reason BCDABHDFJPD, [Optional] Exception DDMPALIOLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8BFA970", Offset = "0x8BF9770", VA = "0x188BFA970")]
	private bool ALPGBAEDFNF(ELDLNLHNOJF.PGFNEINKDAG BCDABHDFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8BFAEB0", Offset = "0x8BF9CB0", VA = "0x188BFAEB0")]
	private ODPNDGHKAJD[] DCMJHKMCPAL(LLDPOPPOJLA FHHAJEHCPCJ, EBODNCFCALI HIAENDBDNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB770", Offset = "0x8BFA570", VA = "0x188BFB770")]
	[AsyncStateMachine(typeof(HKEMDOFJHIJ))]
	private Task OHBKKOCDNFH(ELDLNLHNOJF.PGFNEINKDAG BCDABHDFJPD, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8BFB340", Offset = "0x8BFA140", VA = "0x188BFB340")]
	[AsyncStateMachine(typeof(DDIOFCOHOHF))]
	private Task DHLOGDAFJNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ELCBILHDLEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class JAFEBJIEILO : GENGDCGMPEK, PACANJLKDOI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct ILPLDIFFMHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IAGHGJELDIE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C00370", Offset = "0x8BFF170", VA = "0x188C00370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C00CD0", Offset = "0x8BFFAD0", VA = "0x188C00CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct ONEGDIMOMLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public IAGHGJELDIE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private GMHMEBHNAOE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private OLBGEKIIFJE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private CPDEBMGDJII <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private EGKFILNOONF <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C10C10", Offset = "0x8C0FA10", VA = "0x188C10C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C11D60", Offset = "0x8C10B60", VA = "0x188C11D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class HNOMIFGKELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Matchmaking.DGCGHAIADGL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public JJIFMGEDAEE errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HNOMIFGKELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C002C0", Offset = "0x8BFF0C0", VA = "0x188C002C0")]
		internal object GIGIIBBLJNI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class CLIKOAGPNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Task<OHMMKMCFEGD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CLIKOAGPNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		internal Task<OHMMKMCFEGD> NNCHKCFMILO(GMHMEBHNAOE<string>.HGELJMPBEBF _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct LNCGEFOPLMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public IAGHGJELDIE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public CPDEBMGDJII joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CLIKOAGPNNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private BFHAMNHOGPE <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private OLBGEKIIFJE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private LJLABGKKKJJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Task<Matchmaking.LHAKPEAOKAM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private LJKJEHKEJNC <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<Matchmaking.LHAKPEAOKAM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<OHMMKMCFEGD> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C09210", Offset = "0x8C08010", VA = "0x188C09210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EB90", Offset = "0x8C0D990", VA = "0x188C0EB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FCDAABICEAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task<OHMMKMCFEGD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FCDAABICEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		internal Task<OHMMKMCFEGD> OABHOKBDMPM(GMHMEBHNAOE<string>.HGELJMPBEBF _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct JFHFMBPGLKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public IAGHGJELDIE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public CPDEBMGDJII joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private BFHAMNHOGPE <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private OLBGEKIIFJE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private LJLABGKKKJJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task<Matchmaking.LHAKPEAOKAM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private OHMMKMCFEGD <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private JEFBCPNECJJ <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter<OHMMKMCFEGD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private LJKJEHKEJNC <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private BMHDIAOPJHO <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private DLFNPGOAGLN <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private TaskAwaiter<DGANFCBONGG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<Matchmaking.LHAKPEAOKAM> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8C249E0", Offset = "0x8C237E0", VA = "0x188C249E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A070", Offset = "0x8C28E70", VA = "0x188C2A070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct IIIJLHPAFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C23260", Offset = "0x8C22060", VA = "0x188C23260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C23CC0", Offset = "0x8C22AC0", VA = "0x188C23CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct AKBPBEJKMEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private HJFNEHLLJBB <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C15840", Offset = "0x8C14640", VA = "0x188C15840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C15CD0", Offset = "0x8C14AD0", VA = "0x188C15CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct FMCIHJEGHKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<Matchmaking.LHAKPEAOKAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<Matchmaking.LHAKPEAOKAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E490", Offset = "0x8C1D290", VA = "0x188C1E490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E970", Offset = "0x8C1D770", VA = "0x188C1E970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct JCADJCICCKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Matchmaking.LHAKPEAOKAM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CPDEBMGDJII joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter<FIKDMABIOIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8C24340", Offset = "0x8C23140", VA = "0x188C24340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C24980", Offset = "0x8C23780", VA = "0x188C24980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JIOLLGLIKMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JIOLLGLIKMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A0D0", Offset = "0x8C28ED0", VA = "0x188C2A0D0")]
		internal object FCJJCJFMGJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A1D0", Offset = "0x8C28FD0", VA = "0x188C2A1D0")]
		internal string PEECFHPBNDJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct IHOKOGHIJLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private JIOLLGLIKMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C22670", Offset = "0x8C21470", VA = "0x188C22670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C23200", Offset = "0x8C22000", VA = "0x188C23200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct IBNCDLNMIMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CPDEBMGDJII joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public OHMMKMCFEGD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public LLDPOPPOJLA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public JEFBCPNECJJ preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public BFHAMNHOGPE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C216E0", Offset = "0x8C204E0", VA = "0x188C216E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C21ED0", Offset = "0x8C20CD0", VA = "0x188C21ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct NHANOEMBEHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private OLBGEKIIFJE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private OLBGEKIIFJE <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2E510", Offset = "0x8C2D310", VA = "0x188C2E510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FCF0", Offset = "0x8C2EAF0", VA = "0x188C2FCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct EBILOIBKBKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public DPLLHLFGGEJ localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public JAFEBJIEILO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private TaskAwaiter<NNJLPCOCOKC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C1CB80", Offset = "0x8C1B980", VA = "0x188C1CB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C1D380", Offset = "0x8C1C180", VA = "0x188C1D380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class FFJAFLEEMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FFJAFLEEMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E110", Offset = "0x8C1CF10", VA = "0x188C1E110")]
		internal object JOICBPOEJDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class GDCGKFJFGAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GDCGKFJFGAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C1EB30", Offset = "0x8C1D930", VA = "0x188C1EB30")]
		internal void HFKGKEPCMMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class CPMEDGEAIGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CPMEDGEAIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B1C0", Offset = "0x8C19FC0", VA = "0x188C1B1C0")]
		internal object AEPAABHLGIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class CCFBBPIDKLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CCFBBPIDKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8C190E0", Offset = "0x8C17EE0", VA = "0x188C190E0")]
		internal string MNKPFFGEANK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly ALMLLDBPKBM JCBJNFMAGPM;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly ALMLLDBPKBM BDHDEFJKEIL;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly ALMLLDBPKBM IDBLNBNBCKL;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly string DGKBPLFAEBA;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly string GLOLPPPKAJE;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly string GHDEOMGJAKN;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly Guid JIBGJKOGPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private HPNNPDPCEKD OPEDACBIFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private MNCIJOJOHAA HGHPFIKEMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private IMENGCEMAJB DGGIHGMFBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private ONEFPPOEOKA FEMPPJOCFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private OCLKMIHCAHK LEIEIBBJFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private ABCKMKEECEK IIINPBGJICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private BBBGOICJMGJ NDJNMFBBMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private IDisposable JPKGBGIAJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private FDFKLLFNDOG NHNDMEPANGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly NLFFFLJOFLP GBEONOAPNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private LJKJEHKEJNC MHBEDNHGGHG;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus MCBGFBIKGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xABC1F0", Offset = "0xABAFF0", VA = "0x180ABC1F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x15BB3B0", Offset = "0x15BA1B0", VA = "0x1815BB3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C02C80", Offset = "0x8C01A80", VA = "0x188C02C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C03FB0", Offset = "0x8C02DB0", VA = "0x188C03FB0", Slot = "6")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8C03000", Offset = "0x8C01E00", VA = "0x188C03000", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8C02CD0", Offset = "0x8C01AD0", VA = "0x188C02CD0", Slot = "5")]
	[AsyncStateMachine(typeof(ILPLDIFFMHL))]
	public Task DJHPEPBMGDE(LLDPOPPOJLA LMJDCEMLMAN, IAGHGJELDIE GNPBJNJABPP, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8C04FD0", Offset = "0x8C03DD0", VA = "0x188C04FD0")]
	[AsyncStateMachine(typeof(ONEGDIMOMLL))]
	private Task NBFHFDKDILK(LLDPOPPOJLA LMJDCEMLMAN, IAGHGJELDIE GNPBJNJABPP, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8C05120", Offset = "0x8C03F20", VA = "0x188C05120")]
	private void ODODIKAFDIL(ABCKMKEECEK IIINPBGJICL, LLDPOPPOJLA LMJDCEMLMAN, Exception AACEGADBPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8C04450", Offset = "0x8C03250", VA = "0x188C04450")]
	private static void JIDPNEFKDJO(EGKFILNOONF LHCGLFACKCF, Exception AACEGADBPKH, [Optional] List<int> LHJFFAOCLGA, int GKMFOGNBHBJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8C02320", Offset = "0x8C01120", VA = "0x188C02320")]
	[AsyncStateMachine(typeof(LNCGEFOPLMP))]
	private Task AFAPJDCOKKL(GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, LLDPOPPOJLA LMJDCEMLMAN, IAGHGJELDIE GNPBJNJABPP, CPDEBMGDJII KOGOFEMICBB, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8C02B20", Offset = "0x8C01920", VA = "0x188C02B20")]
	[AsyncStateMachine(typeof(JFHFMBPGLKN))]
	private Task BMMJEKMLKGE(GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, LLDPOPPOJLA LMJDCEMLMAN, IAGHGJELDIE GNPBJNJABPP, CPDEBMGDJII KOGOFEMICBB, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8C03630", Offset = "0x8C02430", VA = "0x188C03630")]
	private void FMJHGHFCHPA([CallerMemberName] string DFFBAIJKKDK = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8C057D0", Offset = "0x8C045D0", VA = "0x188C057D0")]
	[AsyncStateMachine(typeof(IIIJLHPAFDC))]
	private Task PMAACOCODJE(GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8C027F0", Offset = "0x8C015F0", VA = "0x188C027F0")]
	private void BBGJOMNKFMK(LLDPOPPOJLA LMJDCEMLMAN, CancellationToken EGDCEEDDFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8C02480", Offset = "0x8C01280", VA = "0x188C02480")]
	private void AFJJKFNNHNP(LLDPOPPOJLA LMJDCEMLMAN, TaskStatus BEGHOHJIGBF, string JDFCBBCKOGJ, CPDEBMGDJII KOGOFEMICBB, Exception DDMPALIOLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8C04E50", Offset = "0x8C03C50", VA = "0x188C04E50")]
	private void KKIMMEFMCBL(LLDPOPPOJLA LMJDCEMLMAN, CPDEBMGDJII KOGOFEMICBB, OperationCanceledException DFHPNFHIOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8C02770", Offset = "0x8C01570", VA = "0x188C02770")]
	private void BAIIELFMAHP(LLDPOPPOJLA LMJDCEMLMAN, CPDEBMGDJII KOGOFEMICBB, Exception AACEGADBPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C05900", Offset = "0x8C04700", VA = "0x188C05900")]
	private void POBNKIOOCCC(LLDPOPPOJLA LMJDCEMLMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8C042E0", Offset = "0x8C030E0", VA = "0x188C042E0")]
	private static KMEBIHHKPIL IELJLKEAFEP(LLDPOPPOJLA LMJDCEMLMAN)
	{
		return default(KMEBIHHKPIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8C03050", Offset = "0x8C01E50", VA = "0x188C03050")]
	[AsyncStateMachine(typeof(AKBPBEJKMEG))]
	private Task ECPNDLDCPKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8C038E0", Offset = "0x8C026E0", VA = "0x188C038E0")]
	[AsyncStateMachine(typeof(FMCIHJEGHKP))]
	private Task<Matchmaking.LHAKPEAOKAM> GAGOKPBIKGM(LLDPOPPOJLA LMJDCEMLMAN, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C033E0", Offset = "0x8C021E0", VA = "0x188C033E0")]
	private static FIKDMABIOIA FHOFGMDGKLE(Matchmaking.LHAKPEAOKAM MBCPNLMOFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8C04D00", Offset = "0x8C03B00", VA = "0x188C04D00")]
	[AsyncStateMachine(typeof(JCADJCICCKE))]
	private Task KFCEONPJHLB(Matchmaking.LHAKPEAOKAM MBCPNLMOFBG, CPDEBMGDJII KOGOFEMICBB, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken PANDMKHGBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C03120", Offset = "0x8C01F20", VA = "0x188C03120")]
	[AsyncStateMachine(typeof(IHOKOGHIJLO))]
	private Task EIOPLNHPNON(LLDPOPPOJLA LMJDCEMLMAN, CancellationTokenSource DPENEOEEFOH, Task JFMLEAGBHJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8C03260", Offset = "0x8C02060", VA = "0x188C03260")]
	[AsyncStateMachine(typeof(IBNCDLNMIMN))]
	private Task FFJLIEJNEOM(OHMMKMCFEGD BHGEHJJDMHN, BFHAMNHOGPE KILPJMGEMBP, LLDPOPPOJLA MOFMOPIDPGJ, CPDEBMGDJII BNLOPBNPPMN, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken DOAJMCELPKB, [Optional] JEFBCPNECJJ OHOOGJJFKII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8C02E10", Offset = "0x8C01C10", VA = "0x188C02E10")]
	private CPDEBMGDJII DNDBJEONPCE(CPDEBMGDJII BNLOPBNPPMN, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8C034F0", Offset = "0x8C022F0", VA = "0x188C034F0")]
	[AsyncStateMachine(typeof(NHANOEMBEHA))]
	private Task FJHCEPFEODG(GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8C037B0", Offset = "0x8C025B0", VA = "0x188C037B0")]
	[AsyncStateMachine(typeof(EBILOIBKBKN))]
	private Task FMNLDPCBHLP(CancellationToken BKHGNHANFKK, int JEGICDLHAME, DPLLHLFGGEJ NDAFINBIAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8C03BF0", Offset = "0x8C029F0", VA = "0x188C03BF0")]
	private static void GIJLEPFEHLO(LLDPOPPOJLA LMJDCEMLMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C05590", Offset = "0x8C04390", VA = "0x188C05590")]
	private void PDOHMJJJPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C026E0", Offset = "0x8C014E0", VA = "0x188C026E0")]
	private void AMDAHJFHLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C04C70", Offset = "0x8C03A70", VA = "0x188C04C70")]
	private void KEECLGKAODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C03E60", Offset = "0x8C02C60", VA = "0x188C03E60")]
	private void HMCHGOBBNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C03D70", Offset = "0x8C02B70", VA = "0x188C03D70")]
	private static void HALIFILEGNE(LLDPOPPOJLA LMJDCEMLMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C04340", Offset = "0x8C03140", VA = "0x188C04340")]
	private static CancellationTokenRegistration ILMECGLLECJ(LLDPOPPOJLA LMJDCEMLMAN, CancellationToken PANDMKHGBGO)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C04ED0", Offset = "0x8C03CD0", VA = "0x188C04ED0")]
	private static void MOOKCCGPCBD(LLDPOPPOJLA LMJDCEMLMAN, Exception AACEGADBPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C03A40", Offset = "0x8C02840", VA = "0x188C03A40")]
	private void GENFOJBHLLJ(LLDPOPPOJLA LMJDCEMLMAN, Task JFMLEAGBHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C03F50", Offset = "0x8C02D50", VA = "0x188C03F50")]
	private static void ICNEBIIBIEE(Func<string> FLNBBIAICOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8C05D10", Offset = "0x8C04B10", VA = "0x188C05D10")]
	public JAFEBJIEILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8C03EF0", Offset = "0x8C02CF0", VA = "0x188C03EF0")]
	[CompilerGenerated]
	internal static (int, int?) IBEILHMEKLC(JJIFMGEDAEE KAFEFLDOPOC)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RecRoom.NoEngine.Common.Preserve]
internal class BJFAKAJKPAM : JEKFCFJJFHG, PACANJLKDOI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct CHIMDOPGDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public BJFAKAJKPAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public DPLLHLFGGEJ localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8C192E0", Offset = "0x8C180E0", VA = "0x188C192E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8C197C0", Offset = "0x8C185C0", VA = "0x188C197C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class JAMJCMAFJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public BJFAKAJKPAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public DPLLHLFGGEJ localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JAMJCMAFJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8C24120", Offset = "0x8C22F20", VA = "0x188C24120")]
		internal List<Task> ECCDFKGLCCB(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct IMHOLMJBMGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public COCCHNMONLJ taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public DPLLHLFGGEJ localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8C23D20", Offset = "0x8C22B20", VA = "0x188C23D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8C240C0", Offset = "0x8C22EC0", VA = "0x188C240C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct JKOHMJIAKMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public BJFAKAJKPAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A2D0", Offset = "0x8C290D0", VA = "0x188C2A2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A5B0", Offset = "0x8C293B0", VA = "0x188C2A5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly HashSet<COCCHNMONLJ> GGPELMMLDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private MNCIJOJOHAA HGHPFIKEMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private ECPGLILLNAG CKGCJFBCNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private HEDIJELKNDA ANLEGKJMPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IDisposable JPKGBGIAJMH;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8C168F0", Offset = "0x8C156F0", VA = "0x188C168F0", Slot = "5")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8C16120", Offset = "0x8C14F20", VA = "0x188C16120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8C16BD0", Offset = "0x8C159D0", VA = "0x188C16BD0", Slot = "4")]
	public bool ILFMEDMOPPC(COCCHNMONLJ AOCBOLBIGAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8C16C30", Offset = "0x8C15A30", VA = "0x188C16C30")]
	private void JDFOLDMEONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8C16180", Offset = "0x8C14F80", VA = "0x188C16180")]
	private void GDOFMOBDKJN(CHNMCCPJHLL OEACCCPPJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8C16030", Offset = "0x8C14E30", VA = "0x188C16030")]
	[AsyncStateMachine(typeof(CHIMDOPGDPJ))]
	private Task CPICMJMAJCB(int JEGICDLHAME, DPLLHLFGGEJ NDAFINBIAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8C16EF0", Offset = "0x8C15CF0", VA = "0x188C16EF0")]
	private Func<CancellationToken, List<Task>> MJFJIFNPBGK(int JEGICDLHAME, DPLLHLFGGEJ NDAFINBIAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8C163A0", Offset = "0x8C151A0", VA = "0x188C163A0")]
	private List<Task> HGMEJPAJNJK(int JEGICDLHAME, DPLLHLFGGEJ NDAFINBIAGM, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8C16D00", Offset = "0x8C15B00", VA = "0x188C16D00")]
	[AsyncStateMachine(typeof(IMHOLMJBMGB))]
	private Task KFEBKIDKCKD(COCCHNMONLJ KAHFPEFBKKA, CancellationToken OBGCPOCPFIJ, int JEGICDLHAME, DPLLHLFGGEJ NDAFINBIAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8C16E20", Offset = "0x8C15C20", VA = "0x188C16E20")]
	[AsyncStateMachine(typeof(JKOHMJIAKMP))]
	private Task LAGIBNIIFLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8C16870", Offset = "0x8C15670", VA = "0x188C16870")]
	private void HHJCEDNCEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8C16FC0", Offset = "0x8C15DC0", VA = "0x188C16FC0")]
	public BJFAKAJKPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[UnityEngine.Scripting.Preserve]
internal sealed class PPIFAIHGLHM : KJCDLHBHNNH, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class FIOHIEEFKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FIOHIEEFKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E430", Offset = "0x8C1D230", VA = "0x188C1E430")]
		internal object OANKMLLLOGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class OBALGJGDBJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public OBALGJGDBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8C30E80", Offset = "0x8C2FC80", VA = "0x188C30E80")]
		internal object MHHMHEAKDHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class PJIJEEDAGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PJIJEEDAGMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class PCLCFIMBHJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PCLCFIMBHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8C30EE0", Offset = "0x8C2FCE0", VA = "0x188C30EE0")]
		internal object DANCMCLKDJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class LFBGFDCODLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LFBGFDCODLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8C2ADC0", Offset = "0x8C29BC0", VA = "0x188C2ADC0")]
		internal object AOMOHDMNNCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly Dictionary<Guid, GEPLMAALEOE> DACFPIGPEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private readonly TimeSpan PPNPOHBFEKH;

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "9")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8C33380", Offset = "0x8C32180", VA = "0x188C33380", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x8C33160", Offset = "0x8C31F60", VA = "0x188C33160", Slot = "4")]
	public MOGBGGJMGKJ DPHJBDIDPOG(Guid ECLLBKCDLFA)
	{
		return default(MOGBGGJMGKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x8C337A0", Offset = "0x8C325A0", VA = "0x188C337A0", Slot = "5")]
	public bool MDNHCHGJFLC(Guid ECLLBKCDLFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8C32E30", Offset = "0x8C31C30", VA = "0x188C32E30", Slot = "6")]
	public bool DJGHPOCBJAI(Guid ECLLBKCDLFA, Task IDLCAHPEJJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8C33390", Offset = "0x8C32190", VA = "0x188C33390", Slot = "7")]
	public bool FCFBGNOIJCC(Guid ECLLBKCDLFA, NNJLPCOCOKC IJLMDLOJGML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8C32DC0", Offset = "0x8C31BC0", VA = "0x188C32DC0", Slot = "8")]
	public Task<(NNJLPCOCOKC, Task)> DJEEPDDLHHN(Guid ECLLBKCDLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8C33570", Offset = "0x8C32370", VA = "0x188C33570")]
	private void IJCBHAKLJED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8C339B0", Offset = "0x8C327B0", VA = "0x188C339B0")]
	public PPIFAIHGLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.NoEngine.Common.Preserve]
internal class IBCJNNIHMPJ : NMBKBOHNGHD, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class HLCCHAJLHFF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly LLDPOPPOJLA FPOKPILNHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly CancellationTokenSource DPCAFKKKHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly CancellationToken BIKAJNDLCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool HGBAFMIFJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private bool PJLPIIDDCCN;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8C1F690", Offset = "0x8C1E490", VA = "0x188C1F690")]
		public HLCCHAJLHFF(LLDPOPPOJLA FPOKPILNHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8C1F540", Offset = "0x8C1E340", VA = "0x188C1F540")]
		public void HHJCEDNCEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8C1F510", Offset = "0x8C1E310", VA = "0x188C1F510", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class FMLNNGGAAAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public EMKIIAKMNPE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FMLNNGGAAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E9E0", Offset = "0x8C1D7E0", VA = "0x188C1E9E0")]
		internal object FKDKOJACFKM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct AGBOHBAGLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public EMKIIAKMNPE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public IBCJNNIHMPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8C15330", Offset = "0x8C14130", VA = "0x188C15330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8C15780", Offset = "0x8C14580", VA = "0x188C15780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class EKFCPNGNPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public IBCJNNIHMPJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EKFCPNGNPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8C1D3E0", Offset = "0x8C1C1E0", VA = "0x188C1D3E0")]
		internal object KPOAGIICMNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class GBEBDPAHJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public LLDPOPPOJLA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public EKFCPNGNPLB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GBEBDPAHJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8C1EA70", Offset = "0x8C1D870", VA = "0x188C1EA70")]
		internal object BGPMAFECFMB((LLDPOPPOJLA lastLocalPlayerRoomInstance, LLDPOPPOJLA newRoomInstance, IMENGCEMAJB fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct MGJJHECEJDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public IBCJNNIHMPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private OLBGEKIIFJE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2B540", Offset = "0x8C2A340", VA = "0x188C2B540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class DIKPOPLCKCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public LLDPOPPOJLA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DIKPOPLCKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B9A0", Offset = "0x8C1A7A0", VA = "0x188C1B9A0")]
		internal object IKALPGAEMNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B8A0", Offset = "0x8C1A6A0", VA = "0x188C1B8A0")]
		internal void BGIGALHBKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B960", Offset = "0x8C1A760", VA = "0x188C1B960")]
		internal object DPBEIBNAFHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B920", Offset = "0x8C1A720", VA = "0x188C1B920")]
		internal object DHNAOLLMLNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct BMDDLOJNJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public LLDPOPPOJLA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public IBCJNNIHMPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public IAGHGJELDIE customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private DIKPOPLCKCE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x8C17050", Offset = "0x8C15E50", VA = "0x188C17050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8C18010", Offset = "0x8C16E10", VA = "0x188C18010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly HDDOOAONMMO.CAJANKPPHEG JBPHJMDDBDB;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly LGHPLMCMDCB JGIKBKDOKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private MNCIJOJOHAA HGHPFIKEMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private IMENGCEMAJB DGGIHGMFBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private MKCNBLPKEJJ AFFIHAGMLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private GENGDCGMPEK OHFMLAGLMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private LLDPOPPOJLA DNHCHBDFAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private HLCCHAJLHFF HNCIOHMIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool EKABNALMFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private Task NBBDICANCPP;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8C20290", Offset = "0x8C1F090", VA = "0x188C20290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool HBPDNKEGPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xB1E4C0", Offset = "0xB1D2C0", VA = "0x180B1E4C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8C20550", Offset = "0x8C1F350", VA = "0x188C20550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8C208E0", Offset = "0x8C1F6E0", VA = "0x188C208E0", Slot = "4")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8C202E0", Offset = "0x8C1F0E0", VA = "0x188C202E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8C207F0", Offset = "0x8C1F5F0", VA = "0x188C207F0")]
	[AsyncStateMachine(typeof(AGBOHBAGLJC))]
	private Task GMMMJMBGFMK(EMKIIAKMNPE JGPHJLOLPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8C20B80", Offset = "0x8C1F980", VA = "0x188C20B80")]
	private void KEODHPPDJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8C20D10", Offset = "0x8C1FB10", VA = "0x188C20D10")]
	private void LINOFIBAODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8C21160", Offset = "0x8C1FF60", VA = "0x188C21160")]
	private void POHCHHJNAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8C210F0", Offset = "0x8C1FEF0", VA = "0x188C210F0")]
	private bool PEAPIEFBIID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8C20EF0", Offset = "0x8C1FCF0", VA = "0x188C20EF0")]
	[AsyncStateMachine(typeof(MGJJHECEJDB))]
	private void MFDEDNLBGIH(int GAILPBKIIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8C20560", Offset = "0x8C1F360", VA = "0x188C20560")]
	private void GGKMBJOLJJN([Out] IDisposable GCIELIKKNKE, [Out] IDisposable BJBNKPCCGNB, [Out] IDisposable BBHKFECPJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8C20450", Offset = "0x8C1F250", VA = "0x188C20450")]
	private bool GBJOBELBIKB(LLDPOPPOJLA FPOKPILNHJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8C20EA0", Offset = "0x8C1FCA0", VA = "0x188C20EA0")]
	private void LJHBINOFHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8C20FC0", Offset = "0x8C1FDC0", VA = "0x188C20FC0")]
	[AsyncStateMachine(typeof(BMDDLOJNJGG))]
	private Task NBFHFDKDILK(LLDPOPPOJLA FPOKPILNHJL, IAGHGJELDIE GNPBJNJABPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8C21670", Offset = "0x8C20470", VA = "0x188C21670")]
	public IBCJNNIHMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[UnityEngine.Scripting.Preserve]
internal sealed class CKMHLLKOFCN : ENBNHDAFLDP, PACANJLKDOI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct BBPBLEMLBAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<FLHPGIIOBFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CKMHLLKOFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<FLHPGIIOBFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8C15D30", Offset = "0x8C14B30", VA = "0x188C15D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8C15FC0", Offset = "0x8C14DC0", VA = "0x188C15FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class KICBMNAPHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public ILNIOCDMOKB message;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KICBMNAPHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A670", Offset = "0x8C29470", VA = "0x188C2A670")]
		internal object EBLJFDPPJEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class AGFEHGJIPJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public ILNIOCDMOKB messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AGFEHGJIPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8C157E0", Offset = "0x8C145E0", VA = "0x188C157E0")]
		internal object DANKCEOLHII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class NEAAFLJKPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NEAAFLJKPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8C2DED0", Offset = "0x8C2CCD0", VA = "0x188C2DED0")]
		internal object DOKPCIMJKDA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct NLNDDCMJLDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CKMHLLKOFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<PCPABMKPHMB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FD50", Offset = "0x8C2EB50", VA = "0x188C2FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8C30620", Offset = "0x8C2F420", VA = "0x188C30620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class KBMJADEBDJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public ILNIOCDMOKB operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KBMJADEBDJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A610", Offset = "0x8C29410", VA = "0x188C2A610")]
		internal object ICKINEJCNLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct MMNOAOFFIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public ILNIOCDMOKB operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CKMHLLKOFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private CPDEBMGDJII <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8C2D300", Offset = "0x8C2C100", VA = "0x188C2D300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2DE70", Offset = "0x8C2CC70", VA = "0x188C2DE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct HPIDNDKGJNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<PCPABMKPHMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public CKMHLLKOFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private CPGIKJIPMNG.EEGFCKNGPLJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private CPDEBMGDJII <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1FCF0", Offset = "0x8C1EAF0", VA = "0x188C1FCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8C20220", Offset = "0x8C1F020", VA = "0x188C20220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class LPCGNKBIFEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public PCPABMKPHMB operation;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LPCGNKBIFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8C2B4C0", Offset = "0x8C2A2C0", VA = "0x188C2B4C0")]
		internal object HMGBKFMGLHF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct LOPHDPBDFMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public PCPABMKPHMB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CKMHLLKOFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private GMHMEBHNAOE<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE20", Offset = "0x8C29C20", VA = "0x188C2AE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8C2B460", Offset = "0x8C2A260", VA = "0x188C2B460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class BNHEPCJOLLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BNHEPCJOLLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8C19080", Offset = "0x8C17E80", VA = "0x188C19080")]
		internal object HPCLIDMNGGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class COBDOLLJMJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public COBDOLLJMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B160", Offset = "0x8C19F60", VA = "0x188C1B160")]
		internal object GHLCAMGPNDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private ONEFPPOEOKA FEMPPJOCFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private LLBCPNNOOCL IAGOALOEDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private ECPFGKALGBL INIBCLEJJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private TaskCompletionSource<FLHPGIIOBFD> LGODFMFKIIK;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8C1A370", Offset = "0x8C19170", VA = "0x188C1A370", Slot = "7")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8C1A8D0", Offset = "0x8C196D0", VA = "0x188C1A8D0", Slot = "6")]
	[AsyncStateMachine(typeof(BBPBLEMLBAB))]
	public Task<FLHPGIIOBFD> OKINLHEBMLO(CancellationToken CHOMEKPCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8C1A000", Offset = "0x8C18E00", VA = "0x188C1A000", Slot = "4")]
	public void IDDLHJKBLKL(ILNIOCDMOKB JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8C19820", Offset = "0x8C18620", VA = "0x188C19820", Slot = "5")]
	public void AIMOAMJHIIB(ILNIOCDMOKB JDGKFPINJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x8C19B60", Offset = "0x8C18960", VA = "0x188C19B60")]
	[AsyncStateMachine(typeof(NLNDDCMJLDB))]
	private Task AKMOINEPBJG(ILNIOCDMOKB FGKGCIHOGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8C1A7C0", Offset = "0x8C195C0", VA = "0x188C1A7C0")]
	[AsyncStateMachine(typeof(MMNOAOFFIMD))]
	private Task NCFOMBOHCAF(ILNIOCDMOKB DMLBNHKPCNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x8C1A460", Offset = "0x8C19260", VA = "0x188C1A460")]
	[AsyncStateMachine(typeof(HPIDNDKGJNJ))]
	private Task<PCPABMKPHMB> IIMGJGLHLDB(ILNIOCDMOKB FGKGCIHOGKN, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8C1A9E0", Offset = "0x8C197E0", VA = "0x188C1A9E0")]
	private CPDEBMGDJII PEALJLGOMMH(ILNIOCDMOKB LAHBGBIGJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8C1AA70", Offset = "0x8C19870", VA = "0x188C1AA70")]
	[AsyncStateMachine(typeof(LOPHDPBDFMM))]
	private Task PEFBHOIEKHE(PCPABMKPHMB HOGFKMCBALA, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8C1A5B0", Offset = "0x8C193B0", VA = "0x188C1A5B0")]
	private PCPABMKPHMB LHNHJLCAEND(ILNIOCDMOKB FGKGCIHOGKN, CPDEBMGDJII NBFILLHKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D060", Offset = "0x3B0BE60", VA = "0x183B0D060")]
	private T EHCFCGOIPJB<T>(T HGMAIPELJHM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8C19C70", Offset = "0x8C18A70", VA = "0x188C19C70")]
	private PCPABMKPHMB CDCPFONFHBJ(ILNIOCDMOKB FGKGCIHOGKN, CPDEBMGDJII NBFILLHKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CKMHLLKOFCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class PIFBHGLLHNB : LLBCPNNOOCL, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class DOJCGNDLPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DOJCGNDLPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8C1CB10", Offset = "0x8C1B910", VA = "0x188C1CB10")]
		internal object EPKLMKOKHGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class LACDNEINPHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LACDNEINPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A6D0", Offset = "0x8C294D0", VA = "0x188C2A6D0")]
		internal object AAKBHJGEFMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private MBANBMMMEBF FJCJOGDFJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private ENBNHDAFLDP OCKPINMPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private KJCDLHBHNNH DACFPIGPEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private GLNAAPALNHF AANEPKJFGOH;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8C31FC0", Offset = "0x8C30DC0", VA = "0x188C31FC0", Slot = "6")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x8C31360", Offset = "0x8C30160", VA = "0x188C31360", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8C32930", Offset = "0x8C31730", VA = "0x188C32930", Slot = "4")]
	public MOGBGGJMGKJ PEDIJKIIDBC(ILNIOCDMOKB DMHBAOAIEJN)
	{
		return default(MOGBGGJMGKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x8C30F40", Offset = "0x8C2FD40", VA = "0x188C30F40", Slot = "5")]
	public void AAKKGGECDBP(Guid ECLLBKCDLFA, Task IDLCAHPEJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8C31EB0", Offset = "0x8C30CB0", VA = "0x188C31EB0")]
	private void HCLDICOLECF(HPHHANMLLNF HBOAEALHJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8C323B0", Offset = "0x8C311B0", VA = "0x188C323B0")]
	private void NEOEKGNLAFN(GGDPCFMOIBI PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8C32130", Offset = "0x8C30F30", VA = "0x188C32130")]
	private void KNACIPIDDKM(GGDPCFMOIBI PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8C31820", Offset = "0x8C30620", VA = "0x188C31820")]
	private void FEJLAIPAFJF(GGDPCFMOIBI PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8C31410", Offset = "0x8C30210", VA = "0x188C31410")]
	private NNJLPCOCOKC ECNEALPCPDH(ILNIOCDMOKB LAHBGBIGJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8C31CB0", Offset = "0x8C30AB0", VA = "0x188C31CB0")]
	private void GDMOMPMIDOO(ILNIOCDMOKB DMLBNHKPCNA, NNJLPCOCOKC IJLMDLOJGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8C31640", Offset = "0x8C30440", VA = "0x188C31640")]
	private bool EDAMMDKKGMJ(ILNIOCDMOKB DMLBNHKPCNA, NNJLPCOCOKC IJLMDLOJGML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8C31150", Offset = "0x8C2FF50", VA = "0x188C31150")]
	private bool DJEEHANAAIP(ILNIOCDMOKB MLLMHGDCFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8C31A60", Offset = "0x8C30860", VA = "0x188C31A60")]
	private bool FMIHDOHLKCL(byte CDMMDCMMPFA, ExitGames.Client.Photon.Hashtable PEKEABNFGOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PIFBHGLLHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class HLMHHHCEDAM : ENGCPEENHKJ, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class GGNFMJPLCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public FLHPGIIOBFD operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public HLMHHHCEDAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public ILNIOCDMOKB roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GGNFMJPLCMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8C1ED00", Offset = "0x8C1DB00", VA = "0x188C1ED00")]
		internal object IAMFNIJIFJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8C1EBD0", Offset = "0x8C1D9D0", VA = "0x188C1EBD0")]
		internal object IAAGBGKBCCJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct ADHNCOAHKPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public HLMHHHCEDAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public ILNIOCDMOKB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<NNJLPCOCOKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C14B70", Offset = "0x8C13970", VA = "0x188C14B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C15210", Offset = "0x8C14010", VA = "0x188C15210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class PKJFHPIFKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public FLHPGIIOBFD operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PKJFHPIFKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C32D50", Offset = "0x8C31B50", VA = "0x188C32D50")]
		internal object HKNIOJODOIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class FHLKPNBOKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FHLKPNBOKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E350", Offset = "0x8C1D150", VA = "0x188C1E350")]
		internal object KLFFDCADHDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E2E0", Offset = "0x8C1D0E0", VA = "0x188C1E2E0")]
		internal object AOGCKBLMLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E3C0", Offset = "0x8C1D1C0", VA = "0x188C1E3C0")]
		internal object KNNNCPCKAJC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct DINHADHKNIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public HLMHHHCEDAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private FHLKPNBOKDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private MOGBGGJMGKJ <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private NNJLPCOCOKC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<(NNJLPCOCOKC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C1BA40", Offset = "0x8C1A840", VA = "0x188C1BA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C1C440", Offset = "0x8C1B240", VA = "0x188C1C440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private MBANBMMMEBF FJCJOGDFJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private LLBCPNNOOCL IAGOALOEDKN;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8C1FA50", Offset = "0x8C1E850", VA = "0x188C1FA50", Slot = "5")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8C1F7F0", Offset = "0x8C1E5F0", VA = "0x188C1F7F0", Slot = "4")]
	[AsyncStateMachine(typeof(ADHNCOAHKPO))]
	private Task<NNJLPCOCOKC> DHMMLGCOJFO(ILNIOCDMOKB LAHBGBIGJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8C1FB00", Offset = "0x8C1E900", VA = "0x188C1FB00")]
	private bool LDEBLIBCBHB(FLHPGIIOBFD OODCGCPIBCE, [Out] NNJLPCOCOKC MOBFLOHJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8C1F910", Offset = "0x8C1E710", VA = "0x188C1F910")]
	[AsyncStateMachine(typeof(DINHADHKNIM))]
	private Task<NNJLPCOCOKC> EBAKPBGFIIC(ILNIOCDMOKB FGKGCIHOGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HLMHHHCEDAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class NOCNMAKIFNM : ECNGILNHGCF, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private struct BFLDFIDAMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public PEDNEEGBGKL NOBEOPDDDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long GKIIDPONFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public Guid? AKDKCMAONAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public bool NLLPLGDMDAL;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct MHFHKIEHLOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<OHMMKMCFEGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public NOCNMAKIFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<CPKIDEJABEO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<OHMMKMCFEGD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2CCC0", Offset = "0x8C2BAC0", VA = "0x188C2CCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2D290", Offset = "0x8C2C090", VA = "0x188C2D290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class HLMEGPEKACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HLMEGPEKACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C1F740", Offset = "0x8C1E540", VA = "0x188C1F740")]
		internal object KCLAEMKIAPK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct DDHKGFBPJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<CPKIDEJABEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NOCNMAKIFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private HLMEGPEKACM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<CPKIDEJABEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B240", Offset = "0x8C1A040", VA = "0x188C1B240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C1B830", Offset = "0x8C1A630", VA = "0x188C1B830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct NGEFKMEAHHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<OHMMKMCFEGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NOCNMAKIFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public CPKIDEJABEO roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<BFLDFIDAMFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2DF30", Offset = "0x8C2CD30", VA = "0x188C2DF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2E4A0", Offset = "0x8C2D2A0", VA = "0x188C2E4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class JBJEBPHKLMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CPKIDEJABEO roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JBJEBPHKLMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xFF25A0", Offset = "0xFF13A0", VA = "0x180FF25A0")]
		internal bool PLFNHEEPINN(COOMNKKPKFC sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C24280", Offset = "0x8C23080", VA = "0x188C24280")]
		internal object LBANLHLBINN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C24160", Offset = "0x8C22F60", VA = "0x188C24160")]
		internal object IFGLOAIPIHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C241F0", Offset = "0x8C22FF0", VA = "0x188C241F0")]
		internal object KGIKDGPJNIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class CFEFIKAEHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public JBJEBPHKLMJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CFEFIKAEHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C191E0", Offset = "0x8C17FE0", VA = "0x188C191E0")]
		internal object IGIDKCFFMFP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct BMFOMAAMAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<BFLDFIDAMFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CPKIDEJABEO roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public NOCNMAKIFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public LLDPOPPOJLA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private CFEFIKAEHBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<BFLDFIDAMFI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter<EKMIFMNPMNP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C18070", Offset = "0x8C16E70", VA = "0x188C18070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C19010", Offset = "0x8C17E10", VA = "0x188C19010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class AFEONABJKDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AFEONABJKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C15280", Offset = "0x8C14080", VA = "0x188C15280")]
		internal object MHJADFBBPLL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private struct ICKDENJMMDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public AsyncTaskMethodBuilder<BFLDFIDAMFI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public COOMNKKPKFC subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public NOCNMAKIFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public LLDPOPPOJLA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private AFEONABJKDP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<NMOAOAGEGEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C21F30", Offset = "0x8C20D30", VA = "0x188C21F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C22600", Offset = "0x8C21400", VA = "0x188C22600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private MKCNBLPKEJJ AFFIHAGMLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private AACGFKBPLDB EBEMCJLPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private CGKLOKJJAKM PNAFMPICLPG;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8C30AC0", Offset = "0x8C2F8C0", VA = "0x188C30AC0", Slot = "5")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8C30BB0", Offset = "0x8C2F9B0", VA = "0x188C30BB0", Slot = "4")]
	[AsyncStateMachine(typeof(MHFHKIEHLOG))]
	public Task<OHMMKMCFEGD> JLEBBJLBGMJ(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, LLDPOPPOJLA LMJDCEMLMAN, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8C307F0", Offset = "0x8C2F5F0", VA = "0x188C307F0")]
	[AsyncStateMachine(typeof(DDHKGFBPJPP))]
	private Task<CPKIDEJABEO> AIEDCAMFBCI(LLDPOPPOJLA LMJDCEMLMAN, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8C30950", Offset = "0x8C2F750", VA = "0x188C30950")]
	[AsyncStateMachine(typeof(NGEFKMEAHHC))]
	private Task<OHMMKMCFEGD> DBJDIMKHAMF(LLDPOPPOJLA LMJDCEMLMAN, CPKIDEJABEO KOGDCKHOGED, long IHNMKJEEFMK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8C30D10", Offset = "0x8C2FB10", VA = "0x188C30D10")]
	[AsyncStateMachine(typeof(BMFOMAAMAGL))]
	private Task<BFLDFIDAMFI> KMFAHGKPEIM(LLDPOPPOJLA LMJDCEMLMAN, CPKIDEJABEO KOGDCKHOGED, long IHNMKJEEFMK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C30680", Offset = "0x8C2F480", VA = "0x188C30680")]
	[AsyncStateMachine(typeof(ICKDENJMMDL))]
	private Task<BFLDFIDAMFI> ACFNALHPKOL(LLDPOPPOJLA FJAPIJLMKNI, COOMNKKPKFC ENMKJMAPPOB, long IHNMKJEEFMK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NOCNMAKIFNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[UnityEngine.Scripting.Preserve]
internal sealed class HBLAKDKFMLJ : ECPFGKALGBL, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class GOJMJPGMNIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GOJMJPGMNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C1ED70", Offset = "0x8C1DB70", VA = "0x188C1ED70")]
		internal object LNLOJFMCIHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct LBMBMKBDDDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public HBLAKDKFMLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CPDEBMGDJII pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2A740", Offset = "0x8C29540", VA = "0x188C2A740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AD50", Offset = "0x8C29B50", VA = "0x188C2AD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct DLFJEEMMABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public HBLAKDKFMLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CPDEBMGDJII pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<JODHOAGFNHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C1C4B0", Offset = "0x8C1B2B0", VA = "0x188C1C4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C1CAA0", Offset = "0x8C1B8A0", VA = "0x188C1CAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class ENKLDIKMIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ENKLDIKMIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C1D450", Offset = "0x8C1C250", VA = "0x188C1D450")]
		internal object NNAIKHAOLPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct EODBIAEALHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public ILNIOCDMOKB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public HBLAKDKFMLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public CPDEBMGDJII pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private JDOACMDDAFI <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private NHEJFICHIBM <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<JODHOAGFNHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C1D4B0", Offset = "0x8C1C2B0", VA = "0x188C1D4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C1E0A0", Offset = "0x8C1CEA0", VA = "0x188C1E0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private INAAMCKLIGL DJNJADBMCMC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private JJKJPMLPAEJ KJHPEJIHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C1F2F0", Offset = "0x8C1E0F0", VA = "0x188C1F2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x8C1F260", Offset = "0x8C1E060", VA = "0x188C1F260", Slot = "8")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C1F3B0", Offset = "0x8C1E1B0", VA = "0x188C1F3B0", Slot = "4")]
	[AsyncStateMachine(typeof(LBMBMKBDDDM))]
	public Task<ILNIOCDMOKB> PKCMMGFKLBP(ILNIOCDMOKB FGKGCIHOGKN, CPDEBMGDJII NBFILLHKEPM, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C1F060", Offset = "0x8C1DE60", VA = "0x188C1F060", Slot = "5")]
	[AsyncStateMachine(typeof(DLFJEEMMABO))]
	public Task<ILNIOCDMOKB> EOMPDBJKCDA(CancellationToken BKHGNHANFKK, CPDEBMGDJII NBFILLHKEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C1F1B0", Offset = "0x8C1DFB0", VA = "0x188C1F1B0", Slot = "6")]
	public PJFBPPKKEKB HGBCKEOJKDK(PCPABMKPHMB GLNNBBFIJKE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C1EF30", Offset = "0x8C1DD30", VA = "0x188C1EF30", Slot = "7")]
	public PJFBPPKKEKB BMFMGNIMAMJ(PCPABMKPHMB GLNNBBFIJKE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C1EDD0", Offset = "0x8C1DBD0", VA = "0x188C1EDD0")]
	[AsyncStateMachine(typeof(EODBIAEALHP))]
	private Task<ILNIOCDMOKB> AFIBNLJPKPN(ILNIOCDMOKB FGKGCIHOGKN, CPDEBMGDJII NBFILLHKEPM, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBA70", Offset = "0x3EFA870", VA = "0x183EFBA70")]
	private static byte[] KAFMEMAHHCI(ILNIOCDMOKB JDFCBBCKOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HBLAKDKFMLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class CNIBEMENGAK : MBANBMMMEBF, PACANJLKDOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private BICJCAEOEKC AKAMNKBMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private ONEFPPOEOKA FEMPPJOCFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private APCNMIFPBOE FEAIEGOABNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private GENGDCGMPEK OHFMLAGLMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private JEKFCFJJFHG HFPEHEIGNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private MKCNBLPKEJJ AFFIHAGMLBN;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C1AB90", Offset = "0x8C19990", VA = "0x188C1AB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static NNJLPCOCOKC PNPKBINCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C1AFE0", Offset = "0x8C19DE0", VA = "0x188C1AFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8C1AE70", Offset = "0x8C19C70", VA = "0x188C1AE70", Slot = "6")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8C1AFF0", Offset = "0x8C19DF0", VA = "0x188C1AFF0", Slot = "4")]
	public NNJLPCOCOKC MCBHDALHIFO(AFLCFHLHEHB PIFHDCCNIPJ, FLHPGIIOBFD BIMCGLHMFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8C1ABE0", Offset = "0x8C199E0", VA = "0x188C1ABE0", Slot = "5")]
	public NNJLPCOCOKC GECEGNJHKBC(AFLCFHLHEHB MBABEJBFODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C1AE60", Offset = "0x8C19C60", VA = "0x188C1AE60")]
	private static NNJLPCOCOKC GKHAOEMMFEP(KKAJILCJHNC BCDABHDFJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CNIBEMENGAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class NALOEGNPJNB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C464F0", Offset = "0x8C452F0", VA = "0x188C464F0")]
	public NALOEGNPJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7D39830", Offset = "0x7D38630", VA = "0x187D39830")]
	public NALOEGNPJNB(string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[UnityEngine.Scripting.Preserve]
internal sealed class EIDHHFOHCMI : HIBGCPDEADP, PACANJLKDOI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct ENPFGAGIPCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public KGMHFIJAHBM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private GMHMEBHNAOE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private PALAANNGDCH <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter<NNJLPCOCOKC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B5D0", Offset = "0x8C3A3D0", VA = "0x188C3B5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C3BFA0", Offset = "0x8C3ADA0", VA = "0x188C3BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct CLNNBJDGHIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C363C0", Offset = "0x8C351C0", VA = "0x188C363C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C36B00", Offset = "0x8C35900", VA = "0x188C36B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct EECKHKCGFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x8C38B50", Offset = "0x8C37950", VA = "0x188C38B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8C39060", Offset = "0x8C37E60", VA = "0x188C39060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct EAFFDEKDFLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8C38330", Offset = "0x8C37130", VA = "0x188C38330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8C38AF0", Offset = "0x8C378F0", VA = "0x188C38AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct DHIPGIDEEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x8C376C0", Offset = "0x8C364C0", VA = "0x188C376C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8C37860", Offset = "0x8C36660", VA = "0x188C37860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct IJNJJOIILLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8C43830", Offset = "0x8C42630", VA = "0x188C43830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8C43F40", Offset = "0x8C42D40", VA = "0x188C43F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct LPKBFOANEMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8C46020", Offset = "0x8C44E20", VA = "0x188C46020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8C46490", Offset = "0x8C45290", VA = "0x188C46490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct OKBJIBEFNKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public EIDHHFOHCMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AFPPAFDLPDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private GMHMEBHNAOE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8C49CC0", Offset = "0x8C48AC0", VA = "0x188C49CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A260", Offset = "0x8C49060", VA = "0x188C4A260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private NLCNBLMKPKF LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ECPFGKALGBL INIBCLEJJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private ONEFPPOEOKA FEMPPJOCFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private JEKFCFJJFHG HFPEHEIGNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private CancellationTokenSource ACCCNINNALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private Task DHAPMEGHLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private TaskCompletionSource<int> COABOOPJBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private int JGKCJMDJDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private int OBBMBOAPMME;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8C398C0", Offset = "0x8C386C0", VA = "0x188C398C0", Slot = "6")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x15764A0", Offset = "0x15752A0", VA = "0x1815764A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A2F0", Offset = "0x8C390F0", VA = "0x188C3A2F0")]
	private void NIPBDIPFAPA(float CBLIIGNGJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8C39B70", Offset = "0x8C38970", VA = "0x188C39B70", Slot = "4")]
	[AsyncStateMachine(typeof(ENPFGAGIPCL))]
	public Task<NNJLPCOCOKC> IPPDBGBBDIB(KGMHFIJAHBM MPGGIHFBNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x8C395A0", Offset = "0x8C383A0", VA = "0x188C395A0", Slot = "5")]
	[AsyncStateMachine(typeof(CLNNBJDGHIH))]
	public Task EAGPHNJHAHC([Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x15764A0", Offset = "0x15752A0", VA = "0x1815764A0")]
	public void PBNAOOPHLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8C39690", Offset = "0x8C38490", VA = "0x188C39690")]
	private PALAANNGDCH EEPAKDBLAOD(KGMHFIJAHBM MPGGIHFBNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8C39CA0", Offset = "0x8C38AA0", VA = "0x188C39CA0")]
	[AsyncStateMachine(typeof(EECKHKCGFDJ))]
	private Task JHFLGKHMCBE(CancellationToken EGDCEEDDFBN, int JEGICDLHAME, DPLLHLFGGEJ NDAFINBIAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8C39A70", Offset = "0x8C38870", VA = "0x188C39A70")]
	[AsyncStateMachine(typeof(EAFFDEKDFLA))]
	private Task IPHFIMJJMON(CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8C39D90", Offset = "0x8C38B90", VA = "0x188C39D90")]
	[AsyncStateMachine(typeof(DHIPGIDEEMO))]
	private Task KGAPELDBCEO([Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A100", Offset = "0x8C38F00", VA = "0x188C3A100")]
	[AsyncStateMachine(typeof(IJNJJOIILLJ))]
	private Task MBKLKGEMMLD(CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A1F0", Offset = "0x8C38FF0", VA = "0x188C3A1F0")]
	[AsyncStateMachine(typeof(LPKBFOANEMH))]
	private Task MFEEOEPMBIE(CancellationToken JFKDMHODOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8C39300", Offset = "0x8C38100", VA = "0x188C39300")]
	private Task AIIGDEGLHNL(AFPPAFDLPDP KBBJPPACKCH, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8C39490", Offset = "0x8C38290", VA = "0x188C39490")]
	[AsyncStateMachine(typeof(OKBJIBEFNKI))]
	private Task DFNIKEHNDOA(AFPPAFDLPDP KBBJPPACKCH, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8C39E80", Offset = "0x8C38C80", VA = "0x188C39E80")]
	private bool LOALCGCFGEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EIDHHFOHCMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[UnityEngine.Scripting.Preserve]
internal class GLJEBKIGODN : APCNMIFPBOE, PACANJLKDOI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct OFNLKGNAFOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public GLJEBKIGODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private GMHMEBHNAOE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8C496A0", Offset = "0x8C484A0", VA = "0x188C496A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8C49C60", Offset = "0x8C48A60", VA = "0x188C49C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private IGMEPLKOBCH MLMNKBBPKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private MBANBMMMEBF FJCJOGDFJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private ECPFGKALGBL INIBCLEJJMF;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F8F0", Offset = "0x8C3E6F0", VA = "0x188C3F8F0", Slot = "6")]
	public void IEHCJBEIMLK(BKHBBNALJMN HGNBPILIDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F760", Offset = "0x8C3E560", VA = "0x188C3F760", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x8C3FBD0", Offset = "0x8C3E9D0", VA = "0x188C3FBD0", Slot = "5")]
	[AsyncStateMachine(typeof(OFNLKGNAFOK))]
	public Task JDCGCGOHHPL(string GHADMHNDJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x8C3FCD0", Offset = "0x8C3EAD0", VA = "0x188C3FCD0", Slot = "4")]
	public NNJLPCOCOKC LOALCGCFGEK(AFLCFHLHEHB PIFHDCCNIPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F7B0", Offset = "0x8C3E5B0", VA = "0x188C3F7B0")]
	private KJCNDGHDGAP IBOFPFJKJCP(string GHADMHNDJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GLJEBKIGODN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class ILPGFDOCFPH
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8C45110", Offset = "0x8C43F10", VA = "0x188C45110")]
	public static void JDPDPNFJKBE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8C44AA0", Offset = "0x8C438A0", VA = "0x188C44AA0")]
	internal static void BOABOLALLEA(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8C45030", Offset = "0x8C43E30", VA = "0x188C45030")]
	internal static void HEGAFHOFAIB(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8C44C00", Offset = "0x8C43A00", VA = "0x188C44C00")]
	internal static void CGCLILFELHF(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3D50660", Offset = "0x3D4F460", VA = "0x183D50660")]
	private static void PIFFFGBMAPE<Interface, Impl, Interface>(HJFNEHLLJBB HPOMHCIJOHD) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class FMCDLMDDBDC : IDPJODOLHNK<ILNIOCDMOKB>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class HBMILGGLDMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public ILNIOCDMOKB message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HBMILGGLDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8C40530", Offset = "0x8C3F330", VA = "0x188C40530")]
		internal object DEKAJCBELNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly FMCDLMDDBDC MOIOIMEFPHA;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8C3C6F0", Offset = "0x8C3B4F0", VA = "0x188C3C6F0")]
	public ExitGames.Client.Photon.Hashtable OFACCHGGJAP(ILNIOCDMOKB JDFCBBCKOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8C3C320", Offset = "0x8C3B120", VA = "0x188C3C320", Slot = "5")]
	protected override void LNBPOMNGPFP(ILNIOCDMOKB JDFCBBCKOGJ, IDictionary<object, object> KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x8C3C780", Offset = "0x8C3B580", VA = "0x188C3C780", Slot = "6")]
	public override ILNIOCDMOKB PPEAGMPJINO(IDictionary<object, object> KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8C3C210", Offset = "0x8C3B010", VA = "0x188C3C210")]
	private static void ICNEBIIBIEE(string LADFHENPJPN, ILNIOCDMOKB JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8C3CA40", Offset = "0x8C3B840", VA = "0x188C3CA40")]
	public FMCDLMDDBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8C3C450", Offset = "0x8C3B250", VA = "0x188C3C450")]
	[CompilerGenerated]
	internal static string NIBPCKIMJAH(OHMMKMCFEGD OBBABGHFJAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class BOBGPOAPHEB
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static NNJLPCOCOKC PNPKBINCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B60", Offset = "0x8C34960", VA = "0x188C35B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8C35E10", Offset = "0x8C34C10", VA = "0x188C35E10")]
	public static bool MOHCCOCDICH(this NNJLPCOCOKC IJLMDLOJGML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8C35910", Offset = "0x8C34710", VA = "0x188C35910")]
	public static NNJLPCOCOKC GKHAOEMMFEP(KKAJILCJHNC HOIOHNBMHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8C35970", Offset = "0x8C34770", VA = "0x188C35970")]
	public static NNJLPCOCOKC IBPKJGFBHLJ(IEnumerable<NNJLPCOCOKC> DKBOIIPDKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8C35BC0", Offset = "0x8C349C0", VA = "0x188C35BC0")]
	public static string MAJFICFAALD(this NNJLPCOCOKC MOBFLOHJOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public abstract class EIJKIGNEDPJ : IJLHLAOFOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public delegate NNJLPCOCOKC GNFMBJHLOJJ([NotNull] AFLCFHLHEHB LOAAAANIAKD);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class AACOFAPOPOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public AFLCFHLHEHB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AACOFAPOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x182B2D0", Offset = "0x182A0D0", VA = "0x18182B2D0")]
		internal NNJLPCOCOKC AMIJGEEPCKH(GNFMBJHLOJJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	protected readonly HashSet<GNFMBJHLOJJ> LBBNNFOFDFG;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A420", Offset = "0x8C39220", VA = "0x188C3A420", Slot = "4")]
	public void GOCCAGMEGFD(GNFMBJHLOJJ FIBPAMJFNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A480", Offset = "0x8C39280", VA = "0x188C3A480", Slot = "5")]
	public void HMMMHDKPHNG(GNFMBJHLOJJ FIBPAMJFNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A3D0", Offset = "0x8C391D0", VA = "0x188C3A3D0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A4E0", Offset = "0x8C392E0", VA = "0x188C3A4E0")]
	protected NNJLPCOCOKC NOENAKIMFMI(AFLCFHLHEHB MBABEJBFODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x8C3A770", Offset = "0x8C39570", VA = "0x188C3A770")]
	protected EIJKIGNEDPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class BBNFFIJMDEJ : EIJKIGNEDPJ, BICJCAEOEKC, IJLHLAOFOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class DABEODJKCLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public NNJLPCOCOKC result;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DABEODJKCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8C36B60", Offset = "0x8C35960", VA = "0x188C36B60")]
		internal object CJCCKKGDHPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8C35290", Offset = "0x8C34090", VA = "0x188C35290")]
	[UnityEngine.Scripting.Preserve]
	public BBNFFIJMDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x8C35180", Offset = "0x8C33F80", VA = "0x188C35180", Slot = "8")]
	public NNJLPCOCOKC DANAIPIPBLA(AFLCFHLHEHB MBABEJBFODJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class FLLOJMBDKIJ : EIJKIGNEDPJ, IGMEPLKOBCH, IJLHLAOFOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class BPJBKDKFKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public NNJLPCOCOKC result;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BPJBKDKFKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x8C36170", Offset = "0x8C34F70", VA = "0x188C36170")]
		internal object HMDLLDNOGBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x8C35290", Offset = "0x8C34090", VA = "0x188C35290")]
	[UnityEngine.Scripting.Preserve]
	public FLLOJMBDKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8C3C100", Offset = "0x8C3AF00", VA = "0x188C3C100", Slot = "8")]
	public NNJLPCOCOKC LOALCGCFGEK(AFLCFHLHEHB EAJPHPMCNGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class BKCLOLLHNLG
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class FDPNGDPAKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public GMHMEBHNAOE<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FDPNGDPAKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8C3C080", Offset = "0x8C3AE80", VA = "0x188C3C080")]
		internal object MGEOGDIOEFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8C35770", Offset = "0x8C34570", VA = "0x188C35770")]
	public static GMHMEBHNAOE<string> AIIHOOCBOHM(ALMLLDBPKBM IPEKLICENHF, [Optional] string HJOJJGLGNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8C356B0", Offset = "0x8C344B0", VA = "0x188C356B0")]
	public static void AECILAFIACK(GMHMEBHNAOE<string> CIEPDNOLKJK, ALMLLDBPKBM IPEKLICENHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8C35850", Offset = "0x8C34650", VA = "0x188C35850")]
	public static string PDFDIHELAMM(ILNIOCDMOKB LAHBGBIGJEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal static class FNJOLEFGIBC
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8C3CA90", Offset = "0x8C3B890", VA = "0x188C3CA90")]
	public static void JFMINCIMBIC(this NLCNBLMKPKF LPOEOKNKAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8C3CA80", Offset = "0x8C3B880", VA = "0x188C3CA80")]
	public static void AMNAMMBGDND(this NLCNBLMKPKF LPOEOKNKAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8C3CAA0", Offset = "0x8C3B8A0", VA = "0x188C3CAA0")]
	private static void LEDNGBKOCKG(this NLCNBLMKPKF LPOEOKNKAFK, bool HPJCOOKBDFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class GIOLHMGOIOJ : MGDCAHCFMMF, HMDAFGGNDFC, LLMMPAKGJMN, BPOIBPGJDJG
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[DefaultMember("Item")]
	private class PGCOKEOGHIH : HPHHANMLLNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly byte OIBEBELDBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly int JFKPMDJNDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly object LNMBMPDNOJM;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte OBIGNCNHICG
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int PEDHJHMKLLK
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object NNIGOOOKOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object ABJADGGNFCH
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E4C0", Offset = "0x8C4D2C0", VA = "0x188C4E4C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7D40E60", Offset = "0x7D3FC60", VA = "0x187D40E60")]
		public PGCOKEOGHIH(byte OIBEBELDBPO, int JFKPMDJNDHF, object LNMBMPDNOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E510", Offset = "0x8C4D310", VA = "0x188C4E510", Slot = "8")]
		public bool CFOKPIKBEGL(byte OPGJHIOADCK, [Out] object HGMAIPELJHM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly HMDAFGGNDFC IILKNNDCMEL;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public AFLCFHLHEHB LLFFNMNNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EA00", Offset = "0x8C3D800", VA = "0x188C3EA00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int KJJAAJICBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8C3F180", Offset = "0x8C3DF80", VA = "0x188C3F180", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int KEMCLDIOFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E9B0", Offset = "0x8C3D7B0", VA = "0x188C3E9B0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public AFLCFHLHEHB GBPKACELCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EE90", Offset = "0x8C3DC90", VA = "0x188C3EE90", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int OFGMNCCDFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string MLHDKEKENJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EC10", Offset = "0x8C3DA10", VA = "0x188C3EC10", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> PECHNFFHEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EFD0", Offset = "0x8C3DDD0", VA = "0x188C3EFD0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> LCICAKAMKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<HPHHANMLLNF> DPPGNIKKINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EB60", Offset = "0x8C3D960", VA = "0x188C3EB60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E900", Offset = "0x8C3D700", VA = "0x188C3E900", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> LNBIJIBBFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AFLCFHLHEHB> FAAGDJAINLF
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action DBHDIMDHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EF30", Offset = "0x8C3DD30", VA = "0x188C3EF30", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E780", Offset = "0x8C3D580", VA = "0x188C3E780", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x8C3ED50", Offset = "0x8C3DB50", VA = "0x188C3ED50", Slot = "19")]
	public void FIKDJMLDJEK(string PFLDDMDPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xE90980", Offset = "0xE8F780", VA = "0x180E90980")]
	public GIOLHMGOIOJ(HMDAFGGNDFC IILKNNDCMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x8C3EA50", Offset = "0x8C3D850", VA = "0x188C3EA50", Slot = "8")]
	public bool DFNJACBFCIL(byte CDMMDCMMPFA, object BAMFGHFDFMO, ACKMCIEAMDG OMCPCACMNHH, CANGACEEHHC DANENCHEPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F0E0", Offset = "0x8C3DEE0", VA = "0x188C3F0E0", Slot = "20")]
	public AFLCFHLHEHB NHKJACLGLBP(int OACBKGLNCKI, bool LIOBEKCLDLB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8C3E820", Offset = "0x8C3D620", VA = "0x188C3E820", Slot = "21")]
	public AFLCFHLHEHB BDOICIGCHOM(int OCHPGIEAOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8C3EDB0", Offset = "0x8C3DBB0", VA = "0x188C3EDB0", Slot = "22")]
	public AFLCFHLHEHB HPNFNHAFEJI(int OACBKGLNCKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8C3EC70", Offset = "0x8C3DA70", VA = "0x188C3EC70", Slot = "23")]
	public IReadOnlyList<AFLCFHLHEHB> FIHBDBDCIIO(bool LIOBEKCLDLB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F0A0", Offset = "0x8C3DEA0", VA = "0x188C3F0A0", Slot = "24")]
	public IReadOnlyList<AFLCFHLHEHB> LJJEBABBJBL(bool LIOBEKCLDLB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "25")]
	public bool LKGINGHOAAF(AFLCFHLHEHB IDIOGGMAPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "28")]
	public void BGGLDMMIFAJ(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "29")]
	public void AALCPEGHMPL(object OBGCPOCPFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "30")]
	public void EBAILAJJOKI(object OBGCPOCPFIJ, bool DFFKDOKNAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x8C3EEE0", Offset = "0x8C3DCE0", VA = "0x188C3EEE0", Slot = "31")]
	public IDisposable JMKFFNADIFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "32")]
	private bool KDBIJAPCMPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "33")]
	public void JKBMPJALBFH(StringBuilder KDOJJJNNDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x10F5030", Offset = "0x10F3E30", VA = "0x1810F5030", Slot = "34")]
	public bool LOIMNJGJAHJ(bool KKCOCFHKAKC, [Out] string DFOJBJDIKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x1067590", Offset = "0x1066390", VA = "0x181067590", Slot = "37")]
	public void CMDNLDIMMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct GGDPCFMOIBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly IDictionary<object, object> PEKEABNFGOF;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
	public GGDPCFMOIBI(IDictionary<object, object> PEKEABNFGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8C3DDF0", Offset = "0x8C3CBF0", VA = "0x188C3DDF0")]
	public bool NDHIIJNAPPI([Out] ILNIOCDMOKB JDFCBBCKOGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8C3DB20", Offset = "0x8C3C920", VA = "0x188C3DB20")]
	public Guid FLPGJIGHFCF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x8C3DCC0", Offset = "0x8C3CAC0", VA = "0x188C3DCC0")]
	public NNJLPCOCOKC JKBJFLPPEEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8C3DBD0", Offset = "0x8C3C9D0", VA = "0x188C3DBD0")]
	public static ExitGames.Client.Photon.Hashtable INIHOJCCLPM(ILNIOCDMOKB JDFCBBCKOGJ, NNJLPCOCOKC IJLMDLOJGML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal static class INBBGPANNEP
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x8C45350", Offset = "0x8C44150", VA = "0x188C45350")]
	public static bool POPMLPCEFHK(this LLDPOPPOJLA CIOKEJIGMAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct HEDIJELKNDA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct EEMLBMDPMNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public HEDIJELKNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8C390C0", Offset = "0x8C37EC0", VA = "0x188C390C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8C392A0", Offset = "0x8C380A0", VA = "0x188C392A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly CancellationTokenSource DPCAFKKKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private Task MGEGHBBNKMN;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool HCIMLNOEIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8C40A50", Offset = "0x8C3F850", VA = "0x188C40A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A80", Offset = "0x8C3F880", VA = "0x188C40A80")]
	public HEDIJELKNDA(CancellationToken BKHGNHANFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8C408F0", Offset = "0x8C3F6F0", VA = "0x188C408F0")]
	[AsyncStateMachine(typeof(EEMLBMDPMNK))]
	public Task ADMELMNFLLE(Func<CancellationToken, List<Task>> LMLLOHDGODE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A00", Offset = "0x8C3F800", VA = "0x188C40A00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public readonly struct KEBNJPGFEGD<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct JNHLCDBJMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<NOKKJCMJLPA<TData>, NILBFGOPNAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public KEBNJPGFEGD<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<GECIHKBMECG<NOKKJCMJLPA<TData>, NILBFGOPNAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x54B73A0", Offset = "0x54B61A0", VA = "0x1854B73A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x4A7BDB0", Offset = "0x4A7ABB0", VA = "0x184A7BDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly KECBMBBFCMF<TGetDataArg, TData> BFCDJMDIFNA;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
	internal KEBNJPGFEGD(KECBMBBFCMF<TGetDataArg, TData> OPJFEEDOIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x55CAF20", Offset = "0x55C9D20", VA = "0x1855CAF20")]
	[AsyncStateMachine(typeof(KEBNJPGFEGD<, >.JNHLCDBJMGC))]
	public Task<GECIHKBMECG<NOKKJCMJLPA<TData>, NILBFGOPNAM>> PMADGBPPDIF(TGetDataArg EIENELGOLAB, string OMGMAECPFCI, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public static class CNDAAADNFBI
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C780", Offset = "0x3A9B580", VA = "0x183A9C780")]
	public static KEBNJPGFEGD<TGetDataArg, TData> ELDPFIHNJDG<TGetDataArg, TData>(KECBMBBFCMF<TGetDataArg, TData> OPJFEEDOIEH)
	{
		return default(KEBNJPGFEGD<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct JJIFMGEDAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly int OBIGNCNHICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly int? LGGGMEEONFF;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5665020", Offset = "0x5663E20", VA = "0x185665020")]
	public JJIFMGEDAEE(int OIBEBELDBPO, [Optional] int? DABJDLBPOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8C454F0", Offset = "0x8C442F0", VA = "0x188C454F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface BKMIFGKOIKH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HONLLHFALGH();

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BKMIFGKOIKH<T> DDEIJJBDJGA(string DJGEKLOBKLO);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BKMIFGKOIKH<T> BPKCEAHAPCG(AEDCHLAKJNL<T> IKKCGJGLPNC);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKMIFGKOIKH<T> IIPMGAIDHLL(int KAFEFLDOPOC);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BKMIFGKOIKH<T> LNNILAKBJPP(int KAFEFLDOPOC, KHBHCIJDIKC<T> AKCKGDMBEJC);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface ABCKMKEECEK
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKMIFGKOIKH<T> GLFPHPBCPFK<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CIBGNGKOIPG PBIJJJPPANB(Exception AACEGADBPKH);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JJIFMGEDAEE KKJAPOCLFED(Exception AACEGADBPKH);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate string AEDCHLAKJNL<in T>(T AACEGADBPKH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public delegate int KHBHCIJDIKC<in T>(T AACEGADBPKH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class PDLJLKNKDJJ : ABCKMKEECEK
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate string DHGFBFCBNJO(Exception AACEGADBPKH);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private delegate int DFFLOJBGCKN(Exception AACEGADBPKH);

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class NABPPAKHFHD<T> : BKMIFGKOIKH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class JGIIAMLJAEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public JGIIAMLJAEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
			internal string IGIMCEOMJHA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class IKDGJMLMKKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public AEDCHLAKJNL<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public IKDGJMLMKKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x5220B00", Offset = "0x521F900", VA = "0x185220B00")]
			internal string HLCHJNPODHG(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[CompilerGenerated]
		private sealed class KJOLPINALML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public KHBHCIJDIKC<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public KJOLPINALML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5220B00", Offset = "0x521F900", VA = "0x185220B00")]
			internal int OJDFDPEDJGN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly PDLJLKNKDJJ IIINPBGJICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly Type HINLHIBIILO;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x5957610", Offset = "0x5956410", VA = "0x185957610")]
		internal NABPPAKHFHD(PDLJLKNKDJJ IIINPBGJICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x5957480", Offset = "0x5956280", VA = "0x185957480", Slot = "4")]
		public void HONLLHFALGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5957370", Offset = "0x5956170", VA = "0x185957370", Slot = "5")]
		public BKMIFGKOIKH<T> DDEIJJBDJGA(string DJGEKLOBKLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5957260", Offset = "0x5956060", VA = "0x185957260", Slot = "6")]
		public BKMIFGKOIKH<T> BPKCEAHAPCG(AEDCHLAKJNL<T> IKKCGJGLPNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x59574B0", Offset = "0x59562B0", VA = "0x1859574B0", Slot = "7")]
		public BKMIFGKOIKH<T> IIPMGAIDHLL(int KAFEFLDOPOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x59574F0", Offset = "0x59562F0", VA = "0x1859574F0", Slot = "8")]
		public BKMIFGKOIKH<T> LNNILAKBJPP(int KAFEFLDOPOC, KHBHCIJDIKC<T> AKCKGDMBEJC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class BONPICOMOHN<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private bool KIAOJDDNKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly List<Type> BKGGKNPCIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private readonly Dictionary<Type, TVal> BBOCEFPLDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private readonly Dictionary<Type, int> AOLHCLPIBDH;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> DCMBHMPHHGI
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x68CEBB0", Offset = "0x68CD9B0", VA = "0x1868CEBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x68CEF00", Offset = "0x68CDD00", VA = "0x1868CEF00")]
		public BONPICOMOHN(Dictionary<Type, int> AOLHCLPIBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x68CEA50", Offset = "0x68CD850", VA = "0x1868CEA50")]
		public void DPHJBDIDPOG(Type OPGJHIOADCK, TVal DOMECMGKIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x68CE970", Offset = "0x68CD770", VA = "0x1868CE970")]
		public bool DCNKPKKNGMI(Type HINLHIBIILO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x68CEDB0", Offset = "0x68CDBB0", VA = "0x1868CEDB0")]
		public bool OIHJPAHBJDE(TVal HGMAIPELJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x45D16F0", Offset = "0x45D04F0", VA = "0x1845D16F0")]
		public TVal DPMBHNJHJDJ(Type ADGMECOLKNH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x68CEC70", Offset = "0x68CDA70", VA = "0x1868CEC70")]
		[CompilerGenerated]
		private int LFJKKNGEJPD(Type BOMFCGODOKN, Type ILNKEIFNJJF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class GHJDLJMKFOC : IEnumerable<JJIFMGEDAEE>, IEnumerable, IEnumerator<JJIFMGEDAEE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private JJIFMGEDAEE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public PDLJLKNKDJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private IEnumerator<JJIFMGEDAEE> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private JJIFMGEDAEE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x4A383B0", Offset = "0x4A371B0", VA = "0x184A383B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JJIFMGEDAEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x8C3E500", Offset = "0x8C3D300", VA = "0x188C3E500", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public GHJDLJMKFOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E550", Offset = "0x8C3D350", VA = "0x188C3E550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DEF0", Offset = "0x8C3CCF0", VA = "0x188C3DEF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E3A0", Offset = "0x8C3D1A0", VA = "0x188C3E3A0")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DEA0", Offset = "0x8C3CCA0", VA = "0x188C3DEA0")]
		private void DFGOGGAACMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E4B0", Offset = "0x8C3D2B0", VA = "0x188C3E4B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E3F0", Offset = "0x8C3D1F0", VA = "0x188C3E3F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JJIFMGEDAEE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E3F0", Offset = "0x8C3D1F0", VA = "0x188C3E3F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private static readonly JJIFMGEDAEE NBCBFDJMJGH;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private static readonly Dictionary<Type, int> HFJAEPEANEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly HashSet<Type> EGGCEIMEPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly BONPICOMOHN<int> MJKDKFGGKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly BONPICOMOHN<DFFLOJBGCKN> JMNHHFPJELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly BONPICOMOHN<DHGFBFCBNJO> GAMNEMCPNGH;

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D6C0", Offset = "0x8C4C4C0", VA = "0x188C4D6C0")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void DKLHNMBDELP(HJFNEHLLJBB NPHHLLEFMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E120", Offset = "0x8C4CF20", VA = "0x188C4E120")]
	[RecRoom.NoEngine.Common.Preserve]
	public PDLJLKNKDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5C50", Offset = "0x3AA4A50", VA = "0x183AA5C50", Slot = "4")]
	public BKMIFGKOIKH<T> GLFPHPBCPFK<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DFD0", Offset = "0x8C4CDD0", VA = "0x188C4DFD0", Slot = "5")]
	public CIBGNGKOIPG PBIJJJPPANB(Exception AACEGADBPKH)
	{
		return default(CIBGNGKOIPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DCF0", Offset = "0x8C4CAF0", VA = "0x188C4DCF0", Slot = "6")]
	public JJIFMGEDAEE KKJAPOCLFED(Exception? AACEGADBPKH)
	{
		return default(JJIFMGEDAEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DC50", Offset = "0x8C4CA50", VA = "0x188C4DC50", Slot = "7")]
	[IteratorStateMachine(typeof(GHJDLJMKFOC))]
	public IEnumerable<JJIFMGEDAEE> IJELPDKEAFG(Exception AACEGADBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DB00", Offset = "0x8C4C900", VA = "0x188C4DB00", Slot = "8")]
	public string GBLIBEAIDLO(Exception? AACEGADBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D010", Offset = "0x8C4BE10", VA = "0x188C4D010")]
	private string CMGOGJHGHNP(AggregateException FKKFCLHOEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D310", Offset = "0x8C4C110", VA = "0x188C4D310")]
	private void CMMOBMBDKGI(Type HINLHIBIILO, int KAFEFLDOPOC, DFFLOJBGCKN? ICPAACHFEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D730", Offset = "0x8C4C530", VA = "0x188C4D730")]
	private void FAMNAGDGAJJ(Type HINLHIBIILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8C4CD40", Offset = "0x8C4BB40", VA = "0x188C4CD40")]
	private void AJCJLJJPKED(Type HINLHIBIILO, DHGFBFCBNJO OEKKGGHKBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4D980", Offset = "0x8C4C780", VA = "0x188C4D980")]
	private static int FLGKMLJCHIL(Type HINLHIBIILO, Dictionary<Type, int> AOLHCLPIBDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF49F0", Offset = "0x3EF37F0", VA = "0x183EF49F0")]
	private static bool LFJMABAGHMP<TVal>(BONPICOMOHN<TVal> OOFDDMCKJPA, Type HINLHIBIILO, [Out] TVal HGMAIPELJHM) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4DEF0", Offset = "0x8C4CCF0", VA = "0x188C4DEF0")]
	[CompilerGenerated]
	internal static int MBGKLNMBAEH(Type FIJBBOMCDKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct CIBGNGKOIPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public readonly JJIFMGEDAEE MJPDMKNICAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public readonly string HBCMCMNPLLI;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8C363A0", Offset = "0x8C351A0", VA = "0x188C363A0")]
	public CIBGNGKOIPG(string GDBJKKMLMMM, JJIFMGEDAEE KAFEFLDOPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C36300", Offset = "0x8C35100", VA = "0x188C36300")]
	public string HBJDMDPIGID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class HPNNPDPCEKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly DPCFCLHFNMK LIDPDOBCEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private string NENOLIGFGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? KIOJGNIDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private long? DHODDHBMFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private long? ENFMLCJFANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private string AGHADDAGAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private NEDOGNOPDGH MJEFKDDJJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private long? HCMLDFIPGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private bool FJPFNFJNAID;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string MCMADGMPLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long LNNOJIBPMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C42860", Offset = "0x8C41660", VA = "0x188C42860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long GFHEODNGCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C428C0", Offset = "0x8C416C0", VA = "0x188C428C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long FEIMGLOAHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C430E0", Offset = "0x8C41EE0", VA = "0x188C430E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string BKGFBLHFMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C431C0", Offset = "0x8C41FC0", VA = "0x188C431C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NEDOGNOPDGH GOHKNMPDFAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAF8A80", Offset = "0xAF7880", VA = "0x180AF8A80")]
		get
		{
			return default(NEDOGNOPDGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C42FF0", Offset = "0x8C41DF0", VA = "0x188C42FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long POCILIENFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C42EF0", Offset = "0x8C41CF0", VA = "0x188C42EF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C43200", Offset = "0x8C42000", VA = "0x188C43200")]
	[UnityEngine.Scripting.Preserve]
	public HPNNPDPCEKD([POMNKOCGGBN(null)] DPCFCLHFNMK LIDPDOBCEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C42CA0", Offset = "0x8C41AA0", VA = "0x188C42CA0")]
	private void DFMEKJGNLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C423D0", Offset = "0x8C411D0", VA = "0x188C423D0")]
	public void CGDAIHAEDIK(long MDNJLMOPJKG, long IHNMKJEEFMK, [Optional] long? FMOODPJPGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C42F50", Offset = "0x8C41D50", VA = "0x188C42F50")]
	public void KAFMAEIIJGG(long FMOODPJPGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C43140", Offset = "0x8C41F40", VA = "0x188C43140")]
	public void NEEDENKCFAO(string KJMFCHCEJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C42920", Offset = "0x8C41720", VA = "0x188C42920")]
	public void DBIJABINCGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class PJFBPPKKEKB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct GMENLEIBAHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public ILNIOCDMOKB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public PJFBPPKKEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter<JJKJPMLPAEJ.CAMOFBPEEOO<ILNIOCDMOKB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C3FD30", Offset = "0x8C3EB30", VA = "0x188C3FD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C40270", Offset = "0x8C3F070", VA = "0x188C40270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct KMCJLHBCOCJ<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class GIDJOIPCPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public ILNIOCDMOKB roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GIDJOIPCPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C3E6A0", Offset = "0x8C3D4A0", VA = "0x188C3E6A0")]
		internal ILNIOCDMOKB FLHLOGPEIJN(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct DNPDMPCJJNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder<JJKJPMLPAEJ.CAMOFBPEEOO<ILNIOCDMOKB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public ILNIOCDMOKB roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public PJFBPPKKEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private JDOACMDDAFI <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter<JJKJPMLPAEJ.CAMOFBPEEOO<ILNIOCDMOKB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C37A10", Offset = "0x8C36810", VA = "0x188C37A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C38020", Offset = "0x8C36E20", VA = "0x188C38020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct EOKPPJDMNBN<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public PJFBPPKKEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x4A7B830", Offset = "0x4A7A630", VA = "0x184A7B830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x4A7BDB0", Offset = "0x4A7ABB0", VA = "0x184A7BDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct HNGDIIHNLFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public PJFBPPKKEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C417B0", Offset = "0x8C405B0", VA = "0x188C417B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C41A90", Offset = "0x8C40890", VA = "0x188C41A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class HNHOMMEJPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HNHOMMEJPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8C41BB0", Offset = "0x8C409B0", VA = "0x188C41BB0")]
		internal object NFJNCHPFAFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x8C41AF0", Offset = "0x8C408F0", VA = "0x188C41AF0")]
		internal bool BOMMNDHAADC(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class NOPCDNGEADH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NOPCDNGEADH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x8C49640", Offset = "0x8C48440", VA = "0x188C49640")]
		internal object DHNAJOGFKPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class HDCPEALNNNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HDCPEALNNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8C40880", Offset = "0x8C3F680", VA = "0x188C40880")]
		internal object GHGFCBNFLCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class EOKJGNKENHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EOKJGNKENHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8C3C010", Offset = "0x8C3AE10", VA = "0x188C3C010")]
		internal object AOCCFCOKMIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class KHENABHAOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public PJFBPPKKEKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KHENABHAOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8C45A70", Offset = "0x8C44870", VA = "0x188C45A70")]
		internal object DEKAJCBELNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly Guid LHPNOPOGEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public readonly PCPABMKPHMB OHCGKIIBCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly JJKJPMLPAEJ PLCPPDBIEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private readonly LLMMPAKGJMN LPOEOKNKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private readonly BPOIBPGJDJG DJAHJBNAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private bool ABCCNHBAIMG;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x8C50A40", Offset = "0x8C4F840", VA = "0x188C50A40")]
	public PJFBPPKKEKB(PCPABMKPHMB HOGFKMCBALA, JJKJPMLPAEJ PLCPPDBIEJH, LLMMPAKGJMN LPOEOKNKAFK, BPOIBPGJDJG DJAHJBNAJBK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8C4FD50", Offset = "0x8C4EB50", VA = "0x188C4FD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8C505F0", Offset = "0x8C4F3F0", VA = "0x188C505F0")]
	public void LLFILGCGEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8C50920", Offset = "0x8C4F720", VA = "0x188C50920")]
	public void PCMLHMIJHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8C4FD60", Offset = "0x8C4EB60", VA = "0x188C4FD60")]
	public void EHHJDDNKEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C4FAE0", Offset = "0x8C4E8E0", VA = "0x188C4FAE0")]
	[AsyncStateMachine(typeof(GMENLEIBAHG))]
	internal Task<ILNIOCDMOKB> DDFOLCHMCAJ(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, ILNIOCDMOKB LAHBGBIGJEE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBA70", Offset = "0x3EFA870", VA = "0x183EFBA70")]
	private static byte[] IFIHDAIGJPP<T>(T JDFCBBCKOGJ) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB590", Offset = "0x3EFA390", VA = "0x183EFB590")]
	private static T BIOMDBHOKBH<T>(MessageParser<T> EGCGNJNFGNA, byte[] JDFCBBCKOGJ, T KNFECMPGFJF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8C50710", Offset = "0x8C4F510", VA = "0x188C50710")]
	[AsyncStateMachine(typeof(DNPDMPCJJNE))]
	private Task<JJKJPMLPAEJ.CAMOFBPEEOO<ILNIOCDMOKB>> MKCKCHJMMPP(ILNIOCDMOKB LAHBGBIGJEE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB310", Offset = "0x3EFA110", VA = "0x183EFB310")]
	[AsyncStateMachine(typeof(EOKPPJDMNBN<>))]
	internal Task<T> AFENPOAAHCO<T>(CancellationToken EGDCEEDDFBN, Func<CancellationToken, Task<T>> LKDKOHINJDF, int KJCLGEPHLLJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F850", Offset = "0x8C4E650", VA = "0x188C4F850")]
	[AsyncStateMachine(typeof(HNGDIIHNLFB))]
	internal Task AFENPOAAHCO(CancellationToken EGDCEEDDFBN, Func<CancellationToken, Task> LKDKOHINJDF, int KJCLGEPHLLJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8C508A0", Offset = "0x8C4F6A0", VA = "0x188C508A0")]
	public GFJBIPLAKCN ONMAFLLFNAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8C50320", Offset = "0x8C4F120", VA = "0x188C50320")]
	public NCEMPNNFHDO HLACMNELDFP([Optional] JEFBCPNECJJ OHOOGJJFKII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8C500B0", Offset = "0x8C4EEB0", VA = "0x188C500B0")]
	public NDLAIMOKOAJ HBOMEOOKCCP([Optional] ALMLLDBPKBM? IPEKLICENHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x8C4F980", Offset = "0x8C4E780", VA = "0x188C4F980")]
	public void CIKECJDEGON(Func<Guid, bool> LBCPPCLGJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8C4FE20", Offset = "0x8C4EC20", VA = "0x188C4FE20")]
	public void EMEIDOMOAHB(Func<Guid, bool> CPCMEPAKHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C4FF30", Offset = "0x8C4ED30", VA = "0x188C4FF30")]
	public Guid GCNPHGDCJOI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C4FC40", Offset = "0x8C4EA40", VA = "0x188C4FC40")]
	public void DFJKFOJCHML(Guid AFMILMGPOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C504C0", Offset = "0x8C4F2C0", VA = "0x188C504C0")]
	public void KHBDLGMILMA(ILNIOCDMOKB JKKBPCFBJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C503B0", Offset = "0x8C4F1B0", VA = "0x188C503B0")]
	public void ICNEBIIBIEE(string NHJMLPBHFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB6E0", Offset = "0x3EFA4E0", VA = "0x183EFB6E0")]
	private T EHCFCGOIPJB<T>(T HGMAIPELJHM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x8C50850", Offset = "0x8C4F650", VA = "0x188C50850")]
	public void MPHEAGBKEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB7D0", Offset = "0x3EFA5D0", VA = "0x183EFB7D0")]
	[CompilerGenerated]
	internal static string FHFCCCOLPGG<T>(byte[] JICDOIHAMGB, int JLNDIGIGKPL, KMCJLHBCOCJ<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal sealed class HPCIDOHCGDE : PCPABMKPHMB
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class KMGJJCLKGOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KMGJJCLKGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8C45E70", Offset = "0x8C44C70", VA = "0x188C45E70")]
		internal object LHBPIFBKPOF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct GECNFCKIMLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public HPCIDOHCGDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private OKDCCHNMBFL <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private NCEMPNNFHDO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter<CDHKJLHNMAG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8C3CBC0", Offset = "0x8C3B9C0", VA = "0x188C3CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DAC0", Offset = "0x8C3C8C0", VA = "0x188C3DAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct BAJNMIGHIII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public HPCIDOHCGDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<CPKIDEJABEO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8C34980", Offset = "0x8C33780", VA = "0x188C34980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x8C35120", Offset = "0x8C33F20", VA = "0x188C35120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct NHHKACHGJAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public HPCIDOHCGDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter<FGABJAJCODN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8C492C0", Offset = "0x8C480C0", VA = "0x188C492C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8C495D0", Offset = "0x8C483D0", VA = "0x188C495D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class LAPBMPECOCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public OKDCCHNMBFL presence;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LAPBMPECOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8C45EE0", Offset = "0x8C44CE0", VA = "0x188C45EE0")]
		internal object GPPEJOOPFJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static readonly ALMLLDBPKBM OPEFCHHOAHA;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private static readonly ALMLLDBPKBM EJGDMKDDJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly OHMMKMCFEGD BHGEHJJDMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly LLDPOPPOJLA HNIKCHJLJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly JEFBCPNECJJ OHOOGJJFKII;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8C42220", Offset = "0x8C41020", VA = "0x188C42220")]
	public HPCIDOHCGDE(OHMMKMCFEGD BHGEHJJDMHN, LLDPOPPOJLA HNIKCHJLJFH, Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, CPDEBMGDJII BDLBHDJIFGM, JEFBCPNECJJ OHOOGJJFKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8C41F00", Offset = "0x8C40D00", VA = "0x188C41F00", Slot = "7")]
	[AsyncStateMachine(typeof(GECNFCKIMLH))]
	protected override Task OBCBLOACAKG(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8C42050", Offset = "0x8C40E50", VA = "0x188C42050")]
	[AsyncStateMachine(typeof(BAJNMIGHIII))]
	private Task PEJHBKFECPK(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x8C41DF0", Offset = "0x8C40BF0", VA = "0x188C41DF0")]
	[AsyncStateMachine(typeof(NHHKACHGJAH))]
	private Task<int> MOKJJJBDCED(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x8C41C10", Offset = "0x8C40A10", VA = "0x188C41C10")]
	private OKDCCHNMBFL DCBEKBDGOKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal class PALAANNGDCH : PCPABMKPHMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct HJNAFAIDGKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public PALAANNGDCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter<MAOJOMONGLP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8C40BB0", Offset = "0x8C3F9B0", VA = "0x188C40BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8C41560", Offset = "0x8C40360", VA = "0x188C41560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly int HMKFJKGPGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly KGMHFIJAHBM BIAIDCADKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly long PCLKEPGGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public readonly long JEANMHLMJNB;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public MAOJOMONGLP DOCCNHAPBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xA9EDF0", Offset = "0xA9DBF0", VA = "0x180A9EDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B940", Offset = "0x8C4A740", VA = "0x188C4B940")]
	public PALAANNGDCH(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, CPDEBMGDJII BDLBHDJIFGM, int HMKFJKGPGDM, KGMHFIJAHBM BIAIDCADKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4B820", Offset = "0x8C4A620", VA = "0x188C4B820", Slot = "7")]
	[AsyncStateMachine(typeof(HJNAFAIDGKP))]
	protected override Task OBCBLOACAKG(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal abstract class BPCEGNGNNGH : PCPABMKPHMB
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class AAPFAEEJHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public BPCEGNGNNGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public OCHEPNOJHGL playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AAPFAEEJHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8C34690", Offset = "0x8C33490", VA = "0x188C34690")]
		internal Task CDNDBDFOEEJ(GMHMEBHNAOE<string>.HGELJMPBEBF postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8C346D0", Offset = "0x8C334D0", VA = "0x188C346D0")]
		internal object EKKENNEPIBP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct DENLPDIACOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public BPCEGNGNNGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private AAPFAEEJHHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x8C36BC0", Offset = "0x8C359C0", VA = "0x188C36BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8C37520", Offset = "0x8C36320", VA = "0x188C37520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct PBKEOJNEKJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public OCHEPNOJHGL playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public BPCEGNGNNGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BA70", Offset = "0x8C4A870", VA = "0x188C4BA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C030", Offset = "0x8C4AE30", VA = "0x188C4C030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x8C36120", Offset = "0x8C34F20", VA = "0x188C36120")]
	public BPCEGNGNNGH(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, CPDEBMGDJII BDLBHDJIFGM, string GPGAMGGMJKP, LEGHDHACNFL OODCGCPIBCE, bool ELJBCGMMDJI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x8C35E30", Offset = "0x8C34C30", VA = "0x188C35E30", Slot = "7")]
	[AsyncStateMachine(typeof(DENLPDIACOO))]
	protected override Task OBCBLOACAKG(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task MKHOBLLCLAL(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x8C35F70", Offset = "0x8C34D70", VA = "0x188C35F70")]
	[AsyncStateMachine(typeof(PBKEOJNEKJA))]
	private Task PLCMPJGNLOB(IDisposable DNHLGNININL, OCHEPNOJHGL KECCBIAOLOE, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal class DPBBMBIFGFL : PCPABMKPHMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct IEAAIDJAALA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public DPBBMBIFGFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter<BONMJCCGPMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8C43240", Offset = "0x8C42040", VA = "0x188C43240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8C437D0", Offset = "0x8C425D0", VA = "0x188C437D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private readonly AFPPAFDLPDP KBBJPPACKCH;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8C38290", Offset = "0x8C37090", VA = "0x188C38290")]
	public DPBBMBIFGFL(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, CPDEBMGDJII BDLBHDJIFGM, AFPPAFDLPDP KBBJPPACKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x8C38090", Offset = "0x8C36E90", VA = "0x188C38090", Slot = "6")]
	protected override string GCKDKIMNKFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x8C38170", Offset = "0x8C36F70", VA = "0x188C38170", Slot = "7")]
	[AsyncStateMachine(typeof(IEAAIDJAALA))]
	protected override Task OBCBLOACAKG(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal abstract class PCPABMKPHMB : BHPGFHAPOHB
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public delegate Task DLNDKGGDMMO(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class CGIPJPPEPJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public PCPABMKPHMB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CGIPJPPEPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x8C361D0", Offset = "0x8C34FD0", VA = "0x188C361D0")]
		internal Task BBHNEHBFLOB(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class OLMBGIOMMID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CGIPJPPEPJL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public OLMBGIOMMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A2C0", Offset = "0x8C490C0", VA = "0x188C4A2C0")]
		internal object AHJIOJFDNCN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct PHGMHEKMAFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public PCPABMKPHMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Func<PCPABMKPHMB, GMHMEBHNAOE<string>.HGELJMPBEBF, PJFBPPKKEKB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private CGIPJPPEPJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private PJFBPPKKEKB <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E560", Offset = "0x8C4D360", VA = "0x188C4E560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F7F0", Offset = "0x8C4E5F0", VA = "0x188C4F7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct IKJPOPADLNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8C43FA0", Offset = "0x8C42DA0", VA = "0x188C43FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8C44A40", Offset = "0x8C43840", VA = "0x188C44A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct AADFPKGJGHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public PCPABMKPHMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8C342D0", Offset = "0x8C330D0", VA = "0x188C342D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8C34630", Offset = "0x8C33430", VA = "0x188C34630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public readonly Guid NOAOIACHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public readonly ByteString BPIEIKOEMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public readonly CPDEBMGDJII HJJPFHIEPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	protected readonly string LMKHPMOHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly bool ELJBCGMMDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly Queue<DLNDKGGDMMO> LMKEMGKMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private readonly LJLABGKKKJJ HJJKLNOPJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly LEGHDHACNFL OODCGCPIBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private bool DJFLMEJOLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public NEDOGNOPDGH GJICIPDMJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public NEDOGNOPDGH NMKLFMIOFHA;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public BKHBBNALJMN ALDEHMGMJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C2C0", Offset = "0x8C4B0C0", VA = "0x188C4C2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public BCCBMBDKCFH CLFPBMBDJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C810", Offset = "0x8C4B610", VA = "0x188C4C810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C240", Offset = "0x8C4B040", VA = "0x188C4C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PDCLDPIMMNG POIGHBCIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C7F0", Offset = "0x8C4B5F0", VA = "0x188C4C7F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C950", Offset = "0x8C4B750", VA = "0x188C4C950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x8C4CBE0", Offset = "0x8C4B9E0", VA = "0x188C4CBE0")]
	protected PCPABMKPHMB(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, CPDEBMGDJII BDLBHDJIFGM, string GPGAMGGMJKP, LEGHDHACNFL OODCGCPIBCE, bool ELJBCGMMDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C3B0", Offset = "0x8C4B1B0", VA = "0x188C4C3B0", Slot = "6")]
	protected virtual string GCKDKIMNKFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C610", Offset = "0x8C4B410", VA = "0x188C4C610")]
	public void IHFMGEKMLAP(DLNDKGGDMMO KAHFPEFBKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C310", Offset = "0x8C4B110", VA = "0x188C4C310")]
	protected void EHNKEPEPJBN(float EFDFIDCNFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4CA90", Offset = "0x8C4B890", VA = "0x188C4CA90")]
	[AsyncStateMachine(typeof(PHGMHEKMAFO))]
	public Task PLBGJCCDHGP(CancellationToken BKHGNHANFKK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, [Optional] Func<PCPABMKPHMB, GMHMEBHNAOE<string>.HGELJMPBEBF, PJFBPPKKEKB> EECLJHCLALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C090", Offset = "0x8C4AE90", VA = "0x188C4C090")]
	[AsyncStateMachine(typeof(IKJPOPADLNI))]
	private static Task BDNPPMCFNJL(Func<CancellationToken, Task> JGPNLDDMPAF, Func<CancellationToken, Task> BPAJBNPNGJI, CancellationToken EGDCEEDDFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C670", Offset = "0x8C4B470", VA = "0x188C4C670")]
	private void IKFIEIDOMED(bool GELGIOCPDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C3F0", Offset = "0x8C4B1F0", VA = "0x188C4C3F0")]
	private void HHAOCFOKBDC(PJFBPPKKEKB CMNNOKDIHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task OBCBLOACAKG(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C970", Offset = "0x8C4B770", VA = "0x188C4C970")]
	[AsyncStateMachine(typeof(AADFPKGJGHC))]
	private Task LBGDHDNJDFJ(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C330", Offset = "0x8C4B130", VA = "0x188C4C330")]
	public ILNIOCDMOKB FDCLCPKFJBE(JDOACMDDAFI LEPMBLIEAHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C860", Offset = "0x8C4B660", VA = "0x188C4C860")]
	[CompilerGenerated]
	private Task KIBKNNLIGPN(CancellationToken DDCPKPIHIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C1C0", Offset = "0x8C4AFC0", VA = "0x188C4C1C0")]
	[CompilerGenerated]
	private object COOCNELBLLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal sealed class AGNJCKIPNDF : BPCEGNGNNGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct ELEPLMDPHHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public AGNJCKIPNDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private KMEBIHHKPIL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private NCEMPNNFHDO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A800", Offset = "0x8C39600", VA = "0x188C3A800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x8C3AF70", Offset = "0x8C39D70", VA = "0x188C3AF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private readonly OHMMKMCFEGD BHOIINMACPE;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x8C348B0", Offset = "0x8C336B0", VA = "0x188C348B0")]
	public AGNJCKIPNDF(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, OHMMKMCFEGD BHOIINMACPE, CPDEBMGDJII BDLBHDJIFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x8C34760", Offset = "0x8C33560", VA = "0x188C34760", Slot = "8")]
	[AsyncStateMachine(typeof(ELEPLMDPHHA))]
	protected override Task MKHOBLLCLAL(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class KJCNDGHDGAP : PCPABMKPHMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct BHHBJMBOAJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public KJCNDGHDGAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<BONMJCCGPMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x8C352A0", Offset = "0x8C340A0", VA = "0x188C352A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x8C35650", Offset = "0x8C34450", VA = "0x188C35650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private readonly string GLIMJFLPLJE;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x8C45DC0", Offset = "0x8C44BC0", VA = "0x188C45DC0")]
	public KJCNDGHDGAP(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, CPDEBMGDJII BDLBHDJIFGM, string GLIMJFLPLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x8C45CB0", Offset = "0x8C44AB0", VA = "0x188C45CB0", Slot = "7")]
	[AsyncStateMachine(typeof(BHHBJMBOAJP))]
	protected override Task OBCBLOACAKG(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class GJLGBPJOFND : BPCEGNGNNGH
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class JALODFCAPJP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			public JALODFCAPJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private TaskAwaiter<BONMJCCGPMP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			private TaskAwaiter<ILNIOCDMOKB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x8C50C70", Offset = "0x8C4FA70", VA = "0x188C50C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x8C51160", Offset = "0x8C4FF60", VA = "0x188C51160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GJLGBPJOFND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public NDLAIMOKOAJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GAMMILDHGNJ roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GFJBIPLAKCN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public IJBCPJDBMGJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JALODFCAPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8C453D0", Offset = "0x8C441D0", VA = "0x188C453D0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<ILNIOCDMOKB> MLOKENEHIEL(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct NGKOPGHGCNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public GJLGBPJOFND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private JALODFCAPJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private KMEBIHHKPIL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private NCEMPNNFHDO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private ILNIOCDMOKB <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8C483E0", Offset = "0x8C471E0", VA = "0x188C483E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8C49260", Offset = "0x8C48060", VA = "0x188C49260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private static readonly ALMLLDBPKBM OPEFCHHOAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int KDAOGIDDFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	[CanBeNull]
	private readonly AEEKNFEBJIC MJONPNHCEAJ;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F690", Offset = "0x8C3E490", VA = "0x188C3F690")]
	public GJLGBPJOFND(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, int KDAOGIDDFPA, AEEKNFEBJIC MJONPNHCEAJ, CPDEBMGDJII BDLBHDJIFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F2D0", Offset = "0x8C3E0D0", VA = "0x188C3F2D0", Slot = "8")]
	[AsyncStateMachine(typeof(NGKOPGHGCNB))]
	protected override Task MKHOBLLCLAL(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F1D0", Offset = "0x8C3DFD0", VA = "0x188C3F1D0")]
	private void BOABONPMFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F410", Offset = "0x8C3E210", VA = "0x188C3F410")]
	private void NJCBJPNMLCD(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, KMEBIHHKPIL GHKJCAKPEIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class HMFMIOPGEHA : PCPABMKPHMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct ONHAILKKKHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public HMFMIOPGEHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private KMEBIHHKPIL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private FGABJAJCODN <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private HNDICJJKNNH<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<FGABJAJCODN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter<MAOJOMONGLP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A380", Offset = "0x8C49180", VA = "0x188C4A380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B7C0", Offset = "0x8C4A5C0", VA = "0x188C4B7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly int KDAOGIDDFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private readonly AEEKNFEBJIC MJONPNHCEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private Func<BONMJCCGPMP, BONMJCCGPMP> LBCCPLMNFCL;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x8C416F0", Offset = "0x8C404F0", VA = "0x188C416F0")]
	public HMFMIOPGEHA(Guid ECLLBKCDLFA, BKHBBNALJMN HGNBPILIDCC, int KDAOGIDDFPA, AEEKNFEBJIC MJONPNHCEAJ, Func<BONMJCCGPMP, BONMJCCGPMP> LBCCPLMNFCL, CPDEBMGDJII BDLBHDJIFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x8C415C0", Offset = "0x8C403C0", VA = "0x188C415C0", Slot = "7")]
	[AsyncStateMachine(typeof(ONHAILKKKHA))]
	protected override Task OBCBLOACAKG(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal abstract class GNALPIJHMMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public readonly PCPABMKPHMB OHCGKIIBCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public readonly PJFBPPKKEKB BIEAKFJIBGO;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x8C40370", Offset = "0x8C3F170", VA = "0x188C40370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8C402E0", Offset = "0x8C3F0E0", VA = "0x188C402E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8C404D0", Offset = "0x8C3F2D0", VA = "0x188C404D0")]
	protected GNALPIJHMMO(PJFBPPKKEKB CMNNOKDIHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8C403C0", Offset = "0x8C3F1C0", VA = "0x188C403C0")]
	protected void ICNEBIIBIEE(string NHJMLPBHFBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct ELPCKFLADGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public Dictionary<Guid, List<HHADGHAIIGC>> EPJCKBLEEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public Dictionary<Guid, List<HHADGHAIIGC>> BOIAOFNPIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public Dictionary<Guid, List<HHADGHAIIGC>> PIEBGEBHGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public List<Guid> EFLEEHKHNHI;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x8C3AFD0", Offset = "0x8C39DD0", VA = "0x188C3AFD0")]
	public static ELPCKFLADGM DPMBHNJHJDJ(OEGPLBBEHEH OLPMMDDOCOO, NEDOGNOPDGH JLGDLLOKKDK, CHNMCCPJHLL JBGCPMPEICN)
	{
		return default(ELPCKFLADGM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct PPDJLIJPIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	public static PPDJLIJPIOP INIHOJCCLPM()
	{
		return default(PPDJLIJPIOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct DGANFCBONGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly CPKIDEJABEO ENGKJAJBOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly COOMNKKPKFC DEKEGPIKAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly Guid? KBIMFOALPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public readonly IReadOnlyCollection<NKAOJOEBCKL> OMELALCDCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public readonly IReadOnlyCollection<NKAOJOEBCKL> DEAPGADLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly PEDNEEGBGKL JJDLOODFHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public readonly PEDNEEGBGKL IKFFNBFABMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public readonly EKMIFMNPMNP LJAHOOFJNAN;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool NENJGDHJJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8C37580", Offset = "0x8C36380", VA = "0x188C37580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8C37610", Offset = "0x8C36410", VA = "0x188C37610")]
	public DGANFCBONGG(CPKIDEJABEO ENGKJAJBOCI, COOMNKKPKFC DEKEGPIKAKO, Guid? KBIMFOALPIJ, IReadOnlyList<NKAOJOEBCKL> OMELALCDCMK, IReadOnlyCollection<NKAOJOEBCKL> DEAPGADLLKL, PEDNEEGBGKL JJDLOODFHIA, PEDNEEGBGKL IKFFNBFABMM, EKMIFMNPMNP LJAHOOFJNAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct JLBFAPLBDMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly PJFBPPKKEKB CMNNOKDIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly Guid AFMILMGPOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private bool GELGIOCPDPF;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8C458B0", Offset = "0x8C446B0", VA = "0x188C458B0")]
	public static JLBFAPLBDMB GCNPHGDCJOI(PJFBPPKKEKB CMNNOKDIHPK)
	{
		return default(JLBFAPLBDMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x13884F0", Offset = "0x13872F0", VA = "0x1813884F0")]
	public void PGBBMINBOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8C458A0", Offset = "0x8C446A0", VA = "0x188C458A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8C458E0", Offset = "0x8C446E0", VA = "0x188C458E0")]
	private JLBFAPLBDMB(PJFBPPKKEKB CMNNOKDIHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8C45670", Offset = "0x8C44470", VA = "0x188C45670")]
	private void DFJKFOJCHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8C455D0", Offset = "0x8C443D0", VA = "0x188C455D0")]
	private Func<Guid, bool> CMFLEBNHGIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal class NCEMPNNFHDO : GNALPIJHMMO, BHPGFHAPOHB
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate Task<NEDOGNOPDGH> HHIFNNMGNIM(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ PJCEELFHGMM, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct KELFGDJEKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public OHMMKMCFEGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private JLBFAPLBDMB <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C5ECC0", Offset = "0x8C5DAC0", VA = "0x188C5ECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F410", Offset = "0x8C5E210", VA = "0x188C5F410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct FIJIDOJKCPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public OHMMKMCFEGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C58790", Offset = "0x8C57590", VA = "0x188C58790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C58BC0", Offset = "0x8C579C0", VA = "0x188C58BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct CKBOMPPEDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public OHMMKMCFEGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C54DA0", Offset = "0x8C53BA0", VA = "0x188C54DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C55260", Offset = "0x8C54060", VA = "0x188C55260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class ADBBNPFBDIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public AsyncTaskMethodBuilder<DGANFCBONGG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public ADBBNPFBDIE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private DGANFCBONGG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private TaskAwaiter<NEDOGNOPDGH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<DGANFCBONGG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x8C67220", Offset = "0x8C66020", VA = "0x188C67220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C67AE0", Offset = "0x8C668E0", VA = "0x188C67AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public AsyncTaskMethodBuilder<CHNMCCPJHLL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public ADBBNPFBDIE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			private CHNMCCPJHLL <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			private TaskAwaiter<NEDOGNOPDGH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			private TaskAwaiter<CHNMCCPJHLL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x8C67B50", Offset = "0x8C66950", VA = "0x188C67B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x8C681A0", Offset = "0x8C66FA0", VA = "0x188C681A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public OHMMKMCFEGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public LJLABGKKKJJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public LJLABGKKKJJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public DGANFCBONGG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public LJLABGKKKJJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CHNMCCPJHLL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public AINNPJEFJIL.GILMFJIONGI <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ADBBNPFBDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C517F0", Offset = "0x8C505F0", VA = "0x188C517F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<DGANFCBONGG> AADCGKPKKJF(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C51940", Offset = "0x8C50740", VA = "0x188C51940")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<CHNMCCPJHLL> ELFODEEEPBC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C51AE0", Offset = "0x8C508E0", VA = "0x188C51AE0")]
		internal void NBJMDKANEMI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A60", Offset = "0x8C50860", VA = "0x188C51A60")]
		internal Task GFMJKJKCEHM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C51AA0", Offset = "0x8C508A0", VA = "0x188C51AA0")]
		internal Task IPAGFLHHKCC(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct BJGFCNHBNIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public OHMMKMCFEGD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private ADBBNPFBDIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<DGANFCBONGG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter<CHNMCCPJHLL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C520B0", Offset = "0x8C50EB0", VA = "0x188C520B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C52D60", Offset = "0x8C51B60", VA = "0x188C52D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct KBNHFBOEAPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public CHNMCCPJHLL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public LJLABGKKKJJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private FLBILAKLEAJ <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5DE00", Offset = "0x8C5CC00", VA = "0x188C5DE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C5EC60", Offset = "0x8C5DA60", VA = "0x188C5EC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct FBJMOILCNPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C56790", Offset = "0x8C55590", VA = "0x188C56790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C56F70", Offset = "0x8C55D70", VA = "0x188C56F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct CFFKAIFPBCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C54500", Offset = "0x8C53300", VA = "0x188C54500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C54D40", Offset = "0x8C53B40", VA = "0x188C54D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct IJHGFGPKMLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B8C0", Offset = "0x8C5A6C0", VA = "0x188C5B8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5C880", Offset = "0x8C5B680", VA = "0x188C5C880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct FBHAOHOFJBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public FLBILAKLEAJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C55610", Offset = "0x8C54410", VA = "0x188C55610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C56720", Offset = "0x8C55520", VA = "0x188C56720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct JNLDCINPGCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public NEDOGNOPDGH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CHNMCCPJHLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D680", Offset = "0x8C5C480", VA = "0x188C5D680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D8D0", Offset = "0x8C5C6D0", VA = "0x188C5D8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class IDKGOBFMHCH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public IDKGOBFMHCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			private OLBGEKIIFJE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private TaskAwaiter<NEDOGNOPDGH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8C68210", Offset = "0x8C67010", VA = "0x188C68210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C686D0", Offset = "0x8C674D0", VA = "0x188C686D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public HHIFNNMGNIM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public FLBILAKLEAJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public NEDOGNOPDGH initialState;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IDKGOBFMHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B7A0", Offset = "0x8C5A5A0", VA = "0x188C5B7A0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<NEDOGNOPDGH> CMGDPJLEGFD(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct BHIILFLKOAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public HHIFNNMGNIM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public FLBILAKLEAJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C51B20", Offset = "0x8C50920", VA = "0x188C51B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C52040", Offset = "0x8C50E40", VA = "0x188C52040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct LPKCJOPCOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private NEDOGNOPDGH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private IEnumerator<NEDOGNOPDGH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C606F0", Offset = "0x8C5F4F0", VA = "0x188C606F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C60C50", Offset = "0x8C5FA50", VA = "0x188C60C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct PHEMFOGCNKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C660C0", Offset = "0x8C64EC0", VA = "0x188C660C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C663B0", Offset = "0x8C651B0", VA = "0x188C663B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct FEIEFKPEMED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C58510", Offset = "0x8C57310", VA = "0x188C58510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8C58730", Offset = "0x8C57530", VA = "0x188C58730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class JIJJNDLOCGN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public JIJJNDLOCGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public CHNMCCPJHLL data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public LJLABGKKKJJ progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			private TaskAwaiter<NEDOGNOPDGH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter<LDDOIOOEBFD> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C68740", Offset = "0x8C67540", VA = "0x188C68740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C69210", Offset = "0x8C68010", VA = "0x188C69210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public NLDCIMGIALO mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JIJJNDLOCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D520", Offset = "0x8C5C320", VA = "0x188C5D520")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<NEDOGNOPDGH> OHMNLNCFJCH(CHNMCCPJHLL data, FLBILAKLEAJ _, LJLABGKKKJJ progressTracker, GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct FCPIDGDCCGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CHNMCCPJHLL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public LJLABGKKKJJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private JIJJNDLOCGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private FLBILAKLEAJ <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C56FD0", Offset = "0x8C55DD0", VA = "0x188C56FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C57E20", Offset = "0x8C56C20", VA = "0x188C57E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct FOHNCJLOHJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C58C30", Offset = "0x8C57A30", VA = "0x188C58C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C59030", Offset = "0x8C57E30", VA = "0x188C59030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct FDHNLMFCEGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public NCEMPNNFHDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public LJLABGKKKJJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C57E80", Offset = "0x8C56C80", VA = "0x188C57E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C584A0", Offset = "0x8C572A0", VA = "0x188C584A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly NLFFFLJOFLP MMIJFHCKEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly NLFFFLJOFLP GONGOAPPPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly HPNNPDPCEKD OPEDACBIFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly IAGPFEBJGFJ GBPLINHFDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly LOIAKJJLJDF KDFNLGGDDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private ProfilerCounterValue<int> IIBEFIJHCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private readonly BFHAMNHOGPE DAGCHELOEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private readonly JEFBCPNECJJ OHOOGJJFKII;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private BKHBBNALJMN ALDEHMGMJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8C47000", Offset = "0x8C45E00", VA = "0x188C47000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PDCLDPIMMNG POIGHBCIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8C47440", Offset = "0x8C46240", VA = "0x188C47440", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8C47800", Offset = "0x8C46600", VA = "0x188C47800", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x8C480F0", Offset = "0x8C46EF0", VA = "0x188C480F0")]
	public NCEMPNNFHDO(PJFBPPKKEKB CMNNOKDIHPK, JEFBCPNECJJ OHOOGJJFKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8C47C50", Offset = "0x8C46A50", VA = "0x188C47C50")]
	[AsyncStateMachine(typeof(KELFGDJEKPE))]
	public Task MLLLJNFDMID(OHMMKMCFEGD FGKGCIHOGKN, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8C47820", Offset = "0x8C46620", VA = "0x188C47820")]
	[AsyncStateMachine(typeof(FIJIDOJKCPH))]
	private Task<ILNIOCDMOKB> LGJLGHBCNGJ(OHMMKMCFEGD FGKGCIHOGKN, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x8C47460", Offset = "0x8C46260", VA = "0x188C47460")]
	[AsyncStateMachine(typeof(CKBOMPPEDJC))]
	private Task JJFKAOAKLIM(OHMMKMCFEGD FGKGCIHOGKN, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x8C47050", Offset = "0x8C45E50", VA = "0x188C47050")]
	[AsyncStateMachine(typeof(BJGFCNHBNIP))]
	private Task GKCIMOJGJFO(OHMMKMCFEGD FGKGCIHOGKN, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken ENPCILAEMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x8C47B00", Offset = "0x8C46900", VA = "0x188C47B00")]
	[AsyncStateMachine(typeof(KBNHFBOEAPD))]
	private Task MHGJCEHKAHG(CHNMCCPJHLL AJHLKOAAGEC, LJLABGKKKJJ IOOFLJKMILP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken EMAFMPFDHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8C472F0", Offset = "0x8C460F0", VA = "0x188C472F0")]
	[AsyncStateMachine(typeof(FBJMOILCNPI))]
	private Task HIFOAFBBNMJ(GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x8C47FA0", Offset = "0x8C46DA0", VA = "0x188C47FA0")]
	[AsyncStateMachine(typeof(CFFKAIFPBCM))]
	private Task PPFJANONNOI(CHNMCCPJHLL KANAIIDGHCH, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x8C47190", Offset = "0x8C45F90", VA = "0x188C47190")]
	[AsyncStateMachine(typeof(IJHGFGPKMLD))]
	private Task<NEDOGNOPDGH> GPMGHGGMHFD(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x8C47980", Offset = "0x8C46780", VA = "0x188C47980")]
	[AsyncStateMachine(typeof(FBHAOHOFJBL))]
	private Task<NEDOGNOPDGH> LJHGEAPMAOH(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x8C46E80", Offset = "0x8C45C80", VA = "0x188C46E80")]
	[AsyncStateMachine(typeof(JNLDCINPGCB))]
	private Task<NEDOGNOPDGH> FOOHOCMPOAH(NEDOGNOPDGH JLGDLLOKKDK, CHNMCCPJHLL JBGCPMPEICN, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK, bool FIDBCEJLBOM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8C46530", Offset = "0x8C45330", VA = "0x188C46530")]
	private bool AEMBKECNCIL(CHNMCCPJHLL AJHLKOAAGEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x8C46BA0", Offset = "0x8C459A0", VA = "0x188C46BA0")]
	[AsyncStateMachine(typeof(BHIILFLKOAP))]
	protected Task<NEDOGNOPDGH> ELNLLGFIHJI(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK, HHIFNNMGNIM BKBEPCMLLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8C47670", Offset = "0x8C46470", VA = "0x188C47670")]
	[AsyncStateMachine(typeof(LPKCJOPCOEO))]
	private Task KNBACGPAIOJ(CHNMCCPJHLL KANAIIDGHCH, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x8C47F30", Offset = "0x8C46D30", VA = "0x188C47F30")]
	private void OGMPGFANAIF(NEDOGNOPDGH FPLHPIIKIHN, LJLABGKKKJJ KILPJMGEMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8C467B0", Offset = "0x8C455B0", VA = "0x188C467B0")]
	private void CKMLAOOIIGE(NEDOGNOPDGH KADJPGLJEGN, [Out] NEDOGNOPDGH FPLOMEOFAHI, [Out] NEDOGNOPDGH KKPNLBBDDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8C477C0", Offset = "0x8C465C0", VA = "0x188C477C0")]
	private Task<DGANFCBONGG> KNNNOBMJCEG(OHMMKMCFEGD FGKGCIHOGKN, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8C47400", Offset = "0x8C46200", VA = "0x188C47400")]
	private Task<CHNMCCPJHLL> IAMPAEKJKDL(DGANFCBONGG KANAIIDGHCH, AINNPJEFJIL.GILMFJIONGI OADGFJMCDJL, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x8C46D30", Offset = "0x8C45B30", VA = "0x188C46D30")]
	[AsyncStateMachine(typeof(PHEMFOGCNKJ))]
	private Task FLOAEAKDFLL(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK, bool AILJLCGDHON = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x8C467F0", Offset = "0x8C455F0", VA = "0x188C467F0")]
	[AsyncStateMachine(typeof(FEIEFKPEMED))]
	private Task CLJEHIJKAHK(CHNMCCPJHLL KANAIIDGHCH, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8C47DA0", Offset = "0x8C46BA0", VA = "0x188C47DA0")]
	private Task NLLEDPEMNHI(CHNMCCPJHLL KANAIIDGHCH, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x8C47F80", Offset = "0x8C46D80", VA = "0x188C47F80")]
	private Task OJLDCCIEMFH(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8C47650", Offset = "0x8C46450", VA = "0x188C47650")]
	private Task KGBMEONGBKB(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x8C46630", Offset = "0x8C45430", VA = "0x188C46630")]
	private Task AJAFLGMLALE(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x8C46620", Offset = "0x8C45420", VA = "0x188C46620")]
	private static Task AGHNBPANOOM(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8C46650", Offset = "0x8C45450", VA = "0x188C46650")]
	private Task BGCJPDCFOLB(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x8C47030", Offset = "0x8C45E30", VA = "0x188C47030")]
	private Task GILEFNPLPKN(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x8C468E0", Offset = "0x8C456E0", VA = "0x188C468E0")]
	private void CLJOJADAADO(OHMMKMCFEGD FGKGCIHOGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x8C475A0", Offset = "0x8C463A0", VA = "0x188C475A0")]
	public void KDPOKMMGINB(long FMOODPJPGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void AFCOPNIMIBH(CPKIDEJABEO ENGKJAJBOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x8C46A50", Offset = "0x8C45850", VA = "0x188C46A50")]
	[AsyncStateMachine(typeof(FCPIDGDCCGF))]
	private Task DLCEDACPNPI(CHNMCCPJHLL AJHLKOAAGEC, LJLABGKKKJJ IOOFLJKMILP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken EMAFMPFDHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x8C46670", Offset = "0x8C45470", VA = "0x188C46670")]
	[AsyncStateMachine(typeof(FOHNCJLOHJO))]
	private Task CCKMJGFGEIO(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x8C46930", Offset = "0x8C45730", VA = "0x188C46930")]
	private static IHELAIDILBO DDDMJCLDNBB(CHNMCCPJHLL JBGCPMPEICN)
	{
		return default(IHELAIDILBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x8C47DD0", Offset = "0x8C46BD0", VA = "0x188C47DD0")]
	[AsyncStateMachine(typeof(FDHNLMFCEGM))]
	private Task<NEDOGNOPDGH> OCCMJMBKNMN(CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, LJLABGKKKJJ KILPJMGEMBP, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private void JCCAGFJMKPN(NEDOGNOPDGH FJIOGPHDADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct EADMABDGNID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private CHNMCCPJHLL KANAIIDGHCH;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C552C0", Offset = "0x8C540C0", VA = "0x188C552C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x8C55530", Offset = "0x8C54330", VA = "0x188C55530")]
	public static Task PLBGJCCDHGP(BKHBBNALJMN HGNBPILIDCC, CHNMCCPJHLL KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x8C55310", Offset = "0x8C54110", VA = "0x188C55310")]
	private void PLBGJCCDHGP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct LEFAGPMMELC
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x8C5FED0", Offset = "0x8C5ECD0", VA = "0x188C5FED0")]
	public static Task PLBGJCCDHGP(CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct KJKNDEODLBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct MCFHFNJLJEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C60CB0", Offset = "0x8C5FAB0", VA = "0x188C60CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C611E0", Offset = "0x8C5FFE0", VA = "0x188C611E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F710", Offset = "0x8C5E510", VA = "0x188C5F710")]
	[AsyncStateMachine(typeof(MCFHFNJLJEJ))]
	public static Task PLBGJCCDHGP(PJFBPPKKEKB CMNNOKDIHPK, CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct OKMLPLJDFEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct MKCJMEIJPMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public FLBILAKLEAJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private BKHBBNALJMN <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private OEGPLBBEHEH <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private NEDOGNOPDGH <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private OLBGEKIIFJE <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private List<(PersistenceView, NBHBELOMHAF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private NBHBELOMHAF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C620F0", Offset = "0x8C60EF0", VA = "0x188C620F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C62DC0", Offset = "0x8C61BC0", VA = "0x188C62DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8C65860", Offset = "0x8C64660", VA = "0x188C65860")]
	[AsyncStateMachine(typeof(MKCJMEIJPMH))]
	public static Task PLBGJCCDHGP(PJFBPPKKEKB CMNNOKDIHPK, CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C65670", Offset = "0x8C64470", VA = "0x188C65670")]
	private static void FCPEDMFPHMJ(PersistenceView LNFCNKMMELP, NBHBELOMHAF MLOICMPKKEC, CHNMCCPJHLL KANAIIDGHCH, NEDOGNOPDGH JLGDLLOKKDK, bool BMGHDFOKENE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct LNBLHOBNONN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct BKGMODGAAKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public BKHBBNALJMN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private OLBGEKIIFJE <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C53030", Offset = "0x8C51E30", VA = "0x188C53030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C53650", Offset = "0x8C52450", VA = "0x188C53650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8C5FFB0", Offset = "0x8C5EDB0", VA = "0x188C5FFB0")]
	[AsyncStateMachine(typeof(BKGMODGAAKH))]
	public static Task PLBGJCCDHGP(BKHBBNALJMN HGNBPILIDCC, CHNMCCPJHLL KANAIIDGHCH, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct HCDACFKOBPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct BKDFKAKBDBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public BKHBBNALJMN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C52DC0", Offset = "0x8C51BC0", VA = "0x188C52DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C52FD0", Offset = "0x8C51DD0", VA = "0x188C52FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class PKDPNHKLBDA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public PKDPNHKLBDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x8C69280", Offset = "0x8C68080", VA = "0x188C69280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8C69610", Offset = "0x8C68410", VA = "0x188C69610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PKDPNHKLBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C66410", Offset = "0x8C65210", VA = "0x188C66410")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task BJBCAMHHABL(GMHMEBHNAOE<string>.HGELJMPBEBF timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct MPGKPCFPPIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public HCDACFKOBPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private OLBGEKIIFJE <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C634F0", Offset = "0x8C622F0", VA = "0x188C634F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C64100", Offset = "0x8C62F00", VA = "0x188C64100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class KMINNBDCIAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public OENCDFMFFLF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KMINNBDCIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C5FD40", Offset = "0x8C5EB40", VA = "0x188C5FD40")]
		internal object GMKEKGCLNPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5FE20", Offset = "0x8C5EC20", VA = "0x188C5FE20")]
		internal object KGICCOIKCMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private CHNMCCPJHLL KANAIIDGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private PJFBPPKKEKB CMNNOKDIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private bool AILJLCGDHON;

	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private static readonly ByteString FICCFEMENIF;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B400", Offset = "0x8C5A200", VA = "0x188C5B400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private LIJLGLDJKPB JHMCAIMPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B360", Offset = "0x8C5A160", VA = "0x188C5B360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x8C5B450", Offset = "0x8C5A250", VA = "0x188C5B450")]
	[AsyncStateMachine(typeof(BKDFKAKBDBB))]
	public static Task PLBGJCCDHGP(BKHBBNALJMN HGNBPILIDCC, CHNMCCPJHLL KANAIIDGHCH, PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK, bool AILJLCGDHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x8C5B5A0", Offset = "0x8C5A3A0", VA = "0x188C5B5A0")]
	[AsyncStateMachine(typeof(MPGKPCFPPIE))]
	private Task PLBGJCCDHGP(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x8C5AB90", Offset = "0x8C59990", VA = "0x188C5AB90")]
	private void CGHBHGCINHJ([NotNull] GJJFFFDCKLI MMJOLFLJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x8C5B6D0", Offset = "0x8C5A4D0", VA = "0x188C5B6D0")]
	private bool PMNOBBHELNC(OENCDFMFFLF HNEGIKALKJG, GJJFFFDCKLI MMJOLFLJNDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct MGNNDNFKBLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct BNEDBGDPCAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public AsyncTaskMethodBuilder<CHNMCCPJHLL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public MGNNDNFKBLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public AINNPJEFJIL.GILMFJIONGI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<IReadOnlyCollection<NKAOJOEBCKL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter<(GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>, GECIHKBMECG<NOKKJCMJLPA<GJJFFFDCKLI>, NILBFGOPNAM>, GECIHKBMECG<NOKKJCMJLPA<LFIMFEFFJLO>, NILBFGOPNAM>, GECIHKBMECG<NOKKJCMJLPA<IEnumerable<EOFGCLOEFFA>>, NILBFGOPNAM>, GECIHKBMECG<NOKKJCMJLPA<GMPLNGBLHHL>, NILBFGOPNAM>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8C536B0", Offset = "0x8C524B0", VA = "0x188C536B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8C54490", Offset = "0x8C53290", VA = "0x188C54490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct MNDNIDDLBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public MGNNDNFKBLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public IReadOnlyCollection<NKAOJOEBCKL> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public IReadOnlyCollection<NKAOJOEBCKL> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public AINNPJEFJIL.GILMFJIONGI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private TaskAwaiter<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8C62E20", Offset = "0x8C61C20", VA = "0x188C62E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8C63480", Offset = "0x8C62280", VA = "0x188C63480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private KEBNJPGFEGD<PEDNEEGBGKL, LFIMFEFFJLO> FMPAHCMJIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private KEBNJPGFEGD<PEDNEEGBGKL, GJJFFFDCKLI> LAGKKJKBOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private KEBNJPGFEGD<EKMIFMNPMNP, IEnumerable<EOFGCLOEFFA>> EOLMKIDLFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private KEBNJPGFEGD<long, GMPLNGBLHHL> GEGIDLGODFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private MHEFMIEILGL DPFGIDKPKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private CPKIDEJABEO ENGKJAJBOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private COOMNKKPKFC DEKEGPIKAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private Guid? KBIMFOALPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private IReadOnlyCollection<NKAOJOEBCKL> OMELALCDCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private Task<IReadOnlyCollection<NKAOJOEBCKL>> HAGEELCMDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private PEDNEEGBGKL JJDLOODFHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private PEDNEEGBGKL IKFFNBFABMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private PEDNEEGBGKL? IHEHBFNEGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private EKMIFMNPMNP LJAHOOFJNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8C61240", Offset = "0x8C60040", VA = "0x188C61240")]
	public static Task<CHNMCCPJHLL> EJILGIOANFJ(BKHBBNALJMN HGNBPILIDCC, [In] DGANFCBONGG KANAIIDGHCH, AINNPJEFJIL.GILMFJIONGI OADGFJMCDJL, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x8C61910", Offset = "0x8C60710", VA = "0x188C61910")]
	[AsyncStateMachine(typeof(BNEDBGDPCAI))]
	private Task<CHNMCCPJHLL> PLBGJCCDHGP(AINNPJEFJIL.GILMFJIONGI OADGFJMCDJL, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x8C616E0", Offset = "0x8C604E0", VA = "0x188C616E0")]
	[AsyncStateMachine(typeof(MNDNIDDLBBJ))]
	private Task<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> FPLHINCBHDN(Guid? KBIMFOALPIJ, IReadOnlyCollection<NKAOJOEBCKL> OMELALCDCMK, IReadOnlyCollection<NKAOJOEBCKL> DEAPGADLLKL, long? MDNJLMOPJKG, long? JDPEMOIFJMF, AINNPJEFJIL.GILMFJIONGI OADGFJMCDJL, GMHMEBHNAOE<string>.HGELJMPBEBF OHMIBDPCDPA, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct PBDFKNFCBDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct KBEMNMEHPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<DGANFCBONGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public PBDFKNFCBDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<DGANFCBONGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D940", Offset = "0x8C5C740", VA = "0x188C5D940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5DD90", Offset = "0x8C5CB90", VA = "0x188C5DD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct KMIFCLFKMMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder<DGANFCBONGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public PBDFKNFCBDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private TaskAwaiter<DGANFCBONGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5F850", Offset = "0x8C5E650", VA = "0x188C5F850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5FCD0", Offset = "0x8C5EAD0", VA = "0x188C5FCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class PPDBBDDHEKD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016F")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			public PPDBBDDHEKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			private TaskAwaiter<FMCAFGCNOGM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			private TaskAwaiter<FGABJAJCODN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x8C66800", Offset = "0x8C65600", VA = "0x188C66800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8C671C0", Offset = "0x8C65FC0", VA = "0x188C671C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public ICPAKBIFELN roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public OEGPLBBEHEH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public PEDNEEGBGKL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public PEDNEEGBGKL subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public IReadOnlyList<NKAOJOEBCKL> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public IReadOnlyList<NKAOJOEBCKL> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public CPKIDEJABEO roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PPDBBDDHEKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xFF25A0", Offset = "0xFF13A0", VA = "0x180FF25A0")]
		internal bool LNPACCADDAF(COOMNKKPKFC sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8C66530", Offset = "0x8C65330", VA = "0x188C66530")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task MMFLHMJHNEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8C66600", Offset = "0x8C65400", VA = "0x188C66600")]
		internal Task<EKMIFMNPMNP> MNHKNCGEOMH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct GHJGMAFBBIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public AsyncTaskMethodBuilder<DGANFCBONGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public ICPAKBIFELN roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public OEGPLBBEHEH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public PEDNEEGBGKL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private PPDBBDDHEKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private COOMNKKPKFC <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private Task<EKMIFMNPMNP> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<CPKIDEJABEO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<EKMIFMNPMNP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8C59090", Offset = "0x8C57E90", VA = "0x188C59090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A040", Offset = "0x8C58E40", VA = "0x188C5A040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private HPNNPDPCEKD OPEDACBIFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private ICPAKBIFELN KMMHONLOEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private long MDNJLMOPJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private long IHNMKJEEFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private long LAANHDPLMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private string ELKCLIPKPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private PEDNEEGBGKL CDLECJJPIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private Guid LACBMKPFNNH;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8C659E0", Offset = "0x8C647E0", VA = "0x188C659E0")]
	public static Task<DGANFCBONGG> EJILGIOANFJ(BKHBBNALJMN HGNBPILIDCC, OHMMKMCFEGD FGKGCIHOGKN, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8C65F70", Offset = "0x8C64D70", VA = "0x188C65F70")]
	[AsyncStateMachine(typeof(KBEMNMEHPLE))]
	private Task<DGANFCBONGG> PLBGJCCDHGP(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8C65C30", Offset = "0x8C64A30", VA = "0x188C65C30")]
	[AsyncStateMachine(typeof(KMIFCLFKMMB))]
	private Task<DGANFCBONGG> KNNNOBMJCEG(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x8C65DA0", Offset = "0x8C64BA0", VA = "0x188C65DA0")]
	[AsyncStateMachine(typeof(GHJGMAFBBIB))]
	private static Task<DGANFCBONGG> KNNNOBMJCEG(OEGPLBBEHEH OLPMMDDOCOO, ICPAKBIFELN KMMHONLOEOD, long MDNJLMOPJKG, long IHNMKJEEFMK, long LAANHDPLMPH, string ELKCLIPKPIB, PEDNEEGBGKL CDLECJJPIJI, Guid LACBMKPFNNH, CancellationToken BKHGNHANFKK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x8C659B0", Offset = "0x8C647B0", VA = "0x188C659B0")]
	private void ECPJNAAFCDM(CPKIDEJABEO ENGKJAJBOCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct MJNCGCBJFJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct GMEJPPABCNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public MJNCGCBJFJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A5A0", Offset = "0x8C593A0", VA = "0x188C5A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5AB30", Offset = "0x8C59930", VA = "0x188C5AB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private CHNMCCPJHLL KANAIIDGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private float ABCNILELCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private float KIDEOJEHECI;

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x8C61AC0", Offset = "0x8C608C0", VA = "0x188C61AC0")]
	public static Task ANMHOMAPMKO(BKHBBNALJMN HGNBPILIDCC, CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x8C61FD0", Offset = "0x8C60DD0", VA = "0x188C61FD0")]
	[AsyncStateMachine(typeof(GMEJPPABCNG))]
	public Task PLBGJCCDHGP(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x8C61D40", Offset = "0x8C60B40", VA = "0x188C61D40")]
	private static void HKIHEPKPFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x8C61E70", Offset = "0x8C60C70", VA = "0x188C61E70")]
	private void MEDHELHBFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x8C61C80", Offset = "0x8C60A80", VA = "0x188C61C80")]
	private static float FIPICCCIPCK(OEGPLBBEHEH OLPMMDDOCOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x8C61C60", Offset = "0x8C60A60", VA = "0x188C61C60")]
	private static float EHJFNCMBFBE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct NIMOHHKPFMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct JGFPBKJOJBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public PJFBPPKKEKB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private PCPABMKPHMB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private BKHBBNALJMN <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private FJJKDOJGCDD.HKODPFKNFAO <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8C5C940", Offset = "0x8C5B740", VA = "0x188C5C940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D130", Offset = "0x8C5BF30", VA = "0x188C5D130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct JGMBOHBHKDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D190", Offset = "0x8C5BF90", VA = "0x188C5D190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x8C5D4C0", Offset = "0x8C5C2C0", VA = "0x188C5D4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8C64FE0", Offset = "0x8C63DE0", VA = "0x188C64FE0")]
	[AsyncStateMachine(typeof(JGFPBKJOJBD))]
	public static Task PLBGJCCDHGP(PJFBPPKKEKB CMNNOKDIHPK, CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x8C64F70", Offset = "0x8C63D70", VA = "0x188C64F70")]
	private static Task<ILNIOCDMOKB> DGCDFDJDPEN(PJFBPPKKEKB CMNNOKDIHPK, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x8C64EB0", Offset = "0x8C63CB0", VA = "0x188C64EB0")]
	[AsyncStateMachine(typeof(JGMBOHBHKDH))]
	private static Task ABLNMICDEGG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct LONNALAIJKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct NDBLPGNPPFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public LONNALAIJKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x8C646C0", Offset = "0x8C634C0", VA = "0x188C646C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8C64E50", Offset = "0x8C63C50", VA = "0x188C64E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class NCLCPEMFGDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NCLCPEMFGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8C64640", Offset = "0x8C63440", VA = "0x188C64640")]
		internal object DAKAALIFFDD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct NBBJDKADEKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public LONNALAIJKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x8C64160", Offset = "0x8C62F60", VA = "0x188C64160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x8C645E0", Offset = "0x8C633E0", VA = "0x188C645E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private bool ELHLHGABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private CancellationToken BKHGNHANFKK;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8C60460", Offset = "0x8C5F260", VA = "0x188C60460")]
	public static Task DJAHLHHMEAO(BKHBBNALJMN HGNBPILIDCC, bool ELHLHGABOFB, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken PANDMKHGBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x8C60600", Offset = "0x8C5F400", VA = "0x188C60600")]
	[AsyncStateMachine(typeof(NDBLPGNPPFL))]
	private Task PLBGJCCDHGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x8C604D0", Offset = "0x8C5F2D0", VA = "0x188C604D0")]
	[AsyncStateMachine(typeof(NBBJDKADEKM))]
	private Task HKCMCDHKBHO(bool GONPPHHPMKG, string GOOLFDMIDOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	private bool KIPDAIPPNLO(bool ELHLHGABOFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct KJEPDGJGKLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct NLALNEGCOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public KJEPDGJGKLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x8C65120", Offset = "0x8C63F20", VA = "0x188C65120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8C65600", Offset = "0x8C64400", VA = "0x188C65600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class JEJKMPMFHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JEJKMPMFHHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8C5C8F0", Offset = "0x8C5B6F0", VA = "0x188C5C8F0")]
		internal object DAKAALIFFDD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct GHLACJPOBIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public KJEPDGJGKLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A0B0", Offset = "0x8C58EB0", VA = "0x188C5A0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5A530", Offset = "0x8C59330", VA = "0x188C5A530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private PKNIILKKCIH NJOBBAHMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F470", Offset = "0x8C5E270", VA = "0x188C5F470")]
	public static Task<Scene> BMOJLLLKEKL(BKHBBNALJMN HGNBPILIDCC, PKNIILKKCIH JMMHIEADJDA, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F600", Offset = "0x8C5E400", VA = "0x188C5F600")]
	[AsyncStateMachine(typeof(NLALNEGCOLE))]
	private Task<Scene> PLBGJCCDHGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F4C0", Offset = "0x8C5E2C0", VA = "0x188C5F4C0")]
	[AsyncStateMachine(typeof(GHLACJPOBIN))]
	private Task<Scene> HKCMCDHKBHO(string GOOLFDMIDOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct LOIAKJJLJDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct JMEDEAOLAJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public LOIAKJJLJDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public NEDOGNOPDGH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public CHNMCCPJHLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter<NEDOGNOPDGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8C747E0", Offset = "0x8C735E0", VA = "0x188C747E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8C75280", Offset = "0x8C74080", VA = "0x188C75280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct DAFLEKMHHEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public AsyncTaskMethodBuilder<NEDOGNOPDGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public LOIAKJJLJDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public NEDOGNOPDGH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C9B0", Offset = "0x8C6B7B0", VA = "0x188C6C9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8C6CC90", Offset = "0x8C6BA90", VA = "0x188C6CC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly PJFBPPKKEKB CMNNOKDIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly HPNNPDPCEKD OPEDACBIFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private readonly IAGPFEBJGFJ GBPLINHFDOM;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private PCPABMKPHMB OHCGKIIBCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x7059E90", Offset = "0x7058C90", VA = "0x187059E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x8C60400", Offset = "0x8C5F200", VA = "0x188C60400")]
	public LOIAKJJLJDF(PJFBPPKKEKB CMNNOKDIHPK, HPNNPDPCEKD OPEDACBIFAJ, IAGPFEBJGFJ GBPLINHFDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8C60280", Offset = "0x8C5F080", VA = "0x188C60280")]
	[AsyncStateMachine(typeof(JMEDEAOLAJM))]
	public Task<NEDOGNOPDGH> MDHCPLOOMGC(NEDOGNOPDGH BLJFGCENGKD, CHNMCCPJHLL JBGCPMPEICN, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK, bool FIDBCEJLBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8C600D0", Offset = "0x8C5EED0", VA = "0x188C600D0")]
	[AsyncStateMachine(typeof(DAFLEKMHHEF))]
	private Task<NEDOGNOPDGH> FFIFOBOECLL(GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, NEDOGNOPDGH GKGDEKNIOCH, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x8C60230", Offset = "0x8C5F030", VA = "0x188C60230")]
	private bool FPGGJHMLBBO(NEDOGNOPDGH FJJDMEEIFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x8C60260", Offset = "0x8C5F060", VA = "0x188C60260")]
	private void ICNEBIIBIEE(string FLNBBIAICOK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct NMJEGCGDCEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct OFABLJJLBEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public PCPABMKPHMB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FLBILAKLEAJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private OLBGEKIIFJE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private List<(PersistenceView, NBHBELOMHAF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private (PersistenceView, NBHBELOMHAF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x8C7CB00", Offset = "0x8C7B900", VA = "0x188C7CB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D1C0", Offset = "0x8C7BFC0", VA = "0x188C7D1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8C7C0C0", Offset = "0x8C7AEC0", VA = "0x188C7C0C0")]
	[AsyncStateMachine(typeof(OFABLJJLBEF))]
	public static Task PLBGJCCDHGP(PCPABMKPHMB HOGFKMCBALA, CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct DLKJBANEFCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct DBGFIFOPCDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public PCPABMKPHMB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public FLBILAKLEAJ timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private OENCDFMFFLF <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private OLBGEKIIFJE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private List<(PersistenceView, NBHBELOMHAF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private NBHBELOMHAF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6CD00", Offset = "0x8C6BB00", VA = "0x188C6CD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D5E0", Offset = "0x8C6C3E0", VA = "0x188C6D5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8C6DE10", Offset = "0x8C6CC10", VA = "0x188C6DE10")]
	[AsyncStateMachine(typeof(DBGFIFOPCDA))]
	public static Task PLBGJCCDHGP(PCPABMKPHMB HOGFKMCBALA, CHNMCCPJHLL KANAIIDGHCH, FLBILAKLEAJ EAHNHNALCCE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public struct PDLOJKEPFFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private struct MNIHJNEGBAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public PDLOJKEPFFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AINNPJEFJIL.GILMFJIONGI preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8C799B0", Offset = "0x8C787B0", VA = "0x188C799B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8C7A030", Offset = "0x8C78E30", VA = "0x188C7A030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private long KEGIKLDJHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private long IJMHKICLLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private Guid? DLHEAKDNPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private IReadOnlyCollection<NKAOJOEBCKL> IFOGAHNKGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private IReadOnlyCollection<NKAOJOEBCKL> KHEFJDLNHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private MHEFMIEILGL MILMDNEEKNO;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D290", Offset = "0x8C7C090", VA = "0x188C7D290")]
	public static Task<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> EJILGIOANFJ(long MDNJLMOPJKG, long IHNMKJEEFMK, FGABJAJCODN FCFGKGHNBKH, AINNPJEFJIL.GILMFJIONGI CNJIGOIOAGH, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D3F0", Offset = "0x8C7C1F0", VA = "0x188C7D3F0")]
	[AsyncStateMachine(typeof(MNIHJNEGBAD))]
	private Task<GECIHKBMECG<LIPFNIMMLCA, NILBFGOPNAM>> PLBGJCCDHGP(AINNPJEFJIL.GILMFJIONGI CNJIGOIOAGH, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct FJJKDOJGCDD
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public struct HKODPFKNFAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public List<PPPBAFINOPF> OFIFEJCEIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public List<NBHBELOMHAF> NDLHGHDLEBK;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
		public HKODPFKNFAO(List<PPPBAFINOPF> OFIFEJCEIFE, List<NBHBELOMHAF> NDLHGHDLEBK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class GMOBGKOEFAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public IEnumerable<PPPBAFINOPF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GMOBGKOEFAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8C72D00", Offset = "0x8C71B00", VA = "0x188C72D00")]
		internal object NBAOBMDGLND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private BKHBBNALJMN HGNBPILIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private CHNMCCPJHLL KANAIIDGHCH;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private OEGPLBBEHEH NFPBHLMLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8C6F450", Offset = "0x8C6E250", VA = "0x188C6F450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8C6FC20", Offset = "0x8C6EA20", VA = "0x188C6FC20")]
	public static HKODPFKNFAO PLBGJCCDHGP(BKHBBNALJMN HGNBPILIDCC, CHNMCCPJHLL KANAIIDGHCH)
	{
		return default(HKODPFKNFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8C6FC80", Offset = "0x8C6EA80", VA = "0x188C6FC80")]
	private HKODPFKNFAO PLBGJCCDHGP()
	{
		return default(HKODPFKNFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F670", Offset = "0x8C6E470", VA = "0x188C6F670")]
	private HKODPFKNFAO MEKDJFPMFLN(GJJFFFDCKLI MMJOLFLJNDE, OENCDFMFFLF HPLBAKAECJN)
	{
		return default(HKODPFKNFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F4A0", Offset = "0x8C6E2A0", VA = "0x188C6F4A0")]
	private bool KMBOGNPKMDD(IEnumerable<PPPBAFINOPF> OFIFEJCEIFE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct NOIDCKBNMBJ
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class ADCJEEPNIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public FJJKDOJGCDD.HKODPFKNFAO instantiations;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ADCJEEPNIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A030", Offset = "0x8C68E30", VA = "0x188C6A030")]
		internal object BJBCAMHHABL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class CLFHGBLHJPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CLFHGBLHJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C8D0", Offset = "0x8C6B6D0", VA = "0x188C6C8D0")]
		internal object BBHNEHBFLOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x8C7C550", Offset = "0x8C7B350", VA = "0x188C7C550")]
	public static void PLBGJCCDHGP(PCPABMKPHMB HOGFKMCBALA, CHNMCCPJHLL KANAIIDGHCH, FJJKDOJGCDD.HKODPFKNFAO IABHCNIFBNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class IAGPFEBJGFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct DIGNBOEJNLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public NEDOGNOPDGH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CHNMCCPJHLL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D640", Offset = "0x8C6C440", VA = "0x188C6D640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6DDB0", Offset = "0x8C6CBB0", VA = "0x188C6DDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class BEGELCNGNMJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			public BEGELCNGNMJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x8C7EA70", Offset = "0x8C7D870", VA = "0x188C7EA70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8C7ED30", Offset = "0x8C7DB30", VA = "0x188C7ED30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BEGELCNGNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A700", Offset = "0x8C69500", VA = "0x188C6A700")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task KGKBEKLEPGF(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct GEMAKDAIKFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private BEGELCNGNMJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8C701C0", Offset = "0x8C6EFC0", VA = "0x188C701C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8C706F0", Offset = "0x8C6F4F0", VA = "0x188C706F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct LADBANKJNGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Dictionary<Guid, List<HHADGHAIIGC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8C77FF0", Offset = "0x8C76DF0", VA = "0x188C77FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8C78600", Offset = "0x8C77400", VA = "0x188C78600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct DMIGJHPADCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private Dictionary<Guid, List<HHADGHAIIGC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8C6DF50", Offset = "0x8C6CD50", VA = "0x188C6DF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E5F0", Offset = "0x8C6D3F0", VA = "0x188C6E5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class NOGDLGPOHDN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			public HHADGHAIIGC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public NOGDLGPOHDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private OLBGEKIIFJE <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7E5B0", Offset = "0x8C7D3B0", VA = "0x188C7E5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7EA10", Offset = "0x8C7D810", VA = "0x188C7EA10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public NOOHFCFLEMD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public List<HHADGHAIIGC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NOGDLGPOHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8C7C460", Offset = "0x8C7B260", VA = "0x188C7C460")]
		internal object LEEGEPGOLDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7C270", Offset = "0x8C7B070", VA = "0x188C7C270")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task APHHOFEILDB(HHADGHAIIGC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8C7C370", Offset = "0x8C7B170", VA = "0x188C7C370")]
		internal object KLFNFPIKOMF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct LOMAHIPKEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public NOOHFCFLEMD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public List<HHADGHAIIGC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private NOGDLGPOHDN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8C78790", Offset = "0x8C77590", VA = "0x188C78790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8C78C60", Offset = "0x8C77A60", VA = "0x188C78C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct GHDMKMMKOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x8C71940", Offset = "0x8C70740", VA = "0x188C71940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8C71F00", Offset = "0x8C70D00", VA = "0x188C71F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class OJILKDMJPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public OJILKDMJPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D220", Offset = "0x8C7C020", VA = "0x188C7D220")]
		internal object IOBNOIHGAHB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct KCAENCBPLFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public CHNMCCPJHLL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x8C76CF0", Offset = "0x8C75AF0", VA = "0x188C76CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8C771B0", Offset = "0x8C75FB0", VA = "0x188C771B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class PMGJGMAFPFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PMGJGMAFPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8C7E540", Offset = "0x8C7D340", VA = "0x188C7E540")]
		internal object HAKMGHJJPDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct BIGEDEAFJFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public IAGPFEBJGFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private OLBGEKIIFJE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8C6ACB0", Offset = "0x8C69AB0", VA = "0x188C6ACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B2E0", Offset = "0x8C6A0E0", VA = "0x188C6B2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class MOFHHMHHCOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MOFHHMHHCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7A0A0", Offset = "0x8C78EA0", VA = "0x188C7A0A0")]
		internal object AOKHPMIDEOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private readonly PJFBPPKKEKB CMNNOKDIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private ELPCKFLADGM GBPLINHFDOM;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private PCPABMKPHMB OHCGKIIBCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x12B0670", Offset = "0x12AF470", VA = "0x1812B0670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public IAGPFEBJGFJ(PJFBPPKKEKB CMNNOKDIHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8C73B40", Offset = "0x8C72940", VA = "0x188C73B40")]
	[AsyncStateMachine(typeof(DIGNBOEJNLG))]
	public Task PLBGJCCDHGP(NEDOGNOPDGH JLGDLLOKKDK, CHNMCCPJHLL JBGCPMPEICN, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x8C73640", Offset = "0x8C72440", VA = "0x188C73640")]
	[AsyncStateMachine(typeof(GEMAKDAIKFJ))]
	private Task KLIKNIKDCDK(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8C72D80", Offset = "0x8C71B80", VA = "0x188C72D80")]
	[AsyncStateMachine(typeof(LADBANKJNGC))]
	private Task AKFKJEPJNMG(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8C72EC0", Offset = "0x8C71CC0", VA = "0x188C72EC0")]
	[AsyncStateMachine(typeof(DMIGJHPADCK))]
	private Task BBKIGLEDFIN(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8C73000", Offset = "0x8C71E00", VA = "0x188C73000")]
	[AsyncStateMachine(typeof(LOMAHIPKEAK))]
	private Task BGAGCCKPABL(Guid COHLMABABDN, List<HHADGHAIIGC> LAGBDOOENDP, NOOHFCFLEMD NPDDPGCPBLA, CHNMCCPJHLL KANAIIDGHCH, CancellationToken OBGCPOCPFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8C73780", Offset = "0x8C72580", VA = "0x188C73780")]
	[AsyncStateMachine(typeof(GHDMKMMKOJL))]
	private Task LLMLMPHFEEI(CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x8C738C0", Offset = "0x8C726C0", VA = "0x188C738C0")]
	[AsyncStateMachine(typeof(KCAENCBPLFA))]
	private Task MLNAIPPOELO(Guid MONMBJCJFGJ, CHNMCCPJHLL KANAIIDGHCH, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x8C73A00", Offset = "0x8C72800", VA = "0x188C73A00")]
	[AsyncStateMachine(typeof(BIGEDEAFJFD))]
	private Task OMOMMKLIKCD(Guid MONMBJCJFGJ, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x8C73200", Offset = "0x8C72000", VA = "0x188C73200")]
	private void GNKIECAMLBD(Guid MONMBJCJFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x8C73150", Offset = "0x8C71F50", VA = "0x188C73150")]
	private void CDMNMHFFPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x8C734E0", Offset = "0x8C722E0", VA = "0x188C734E0")]
	public Guid JAKPAGFDGIK(NEDOGNOPDGH FPLHPIIKIHN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x8C73310", Offset = "0x8C72110", VA = "0x188C73310")]
	[CompilerGenerated]
	private object HBFLIHGCDJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal struct AOFMLNFACNG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct PJJKOLGEELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public AOFMLNFACNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private IEnumerator<AKHHBPOFABD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DE40", Offset = "0x8C7CC40", VA = "0x188C7DE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8C7E4E0", Offset = "0x8C7D2E0", VA = "0x188C7E4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private OEGPLBBEHEH OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private CancellationToken BKHGNHANFKK;

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A5A0", Offset = "0x8C693A0", VA = "0x188C6A5A0")]
	public static Task ADMELMNFLLE(OEGPLBBEHEH OLPMMDDOCOO, GMHMEBHNAOE<string>.HGELJMPBEBF CIEPDNOLKJK, CancellationToken PANDMKHGBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A610", Offset = "0x8C69410", VA = "0x188C6A610")]
	[AsyncStateMachine(typeof(PJJKOLGEELI))]
	private Task PLBGJCCDHGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct IJBCPJDBMGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	public readonly bool GAFJIKAMJMO;

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2D58AB0", Offset = "0x2D578B0", VA = "0x182D58AB0")]
	public IJBCPJDBMGJ(bool EEEPOOGHLCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public readonly struct BONMJCCGPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	public readonly GJJFFFDCKLI? IKNGCGGKMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	public readonly OIKODFOEFPF MKBHCHPKPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	public readonly Guid? EJDIBFPKOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	public readonly IReadOnlyList<Guid> OEOAFEGKKIF;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> BJGNEEJCMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BA30", Offset = "0x8C6A830", VA = "0x188C6BA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> PJIHNEPPDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BA10", Offset = "0x8C6A810", VA = "0x188C6BA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BA50", Offset = "0x8C6A850", VA = "0x188C6BA50")]
	public BONMJCCGPMP(GJJFFFDCKLI? OEACCCPPJMI, OIKODFOEFPF KBIHGOOANIK, Guid? KBIMFOALPIJ, [Optional] IReadOnlyList<Guid>? IPGHOCGMPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class NDLAIMOKOAJ : GNALPIJHMMO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct JNPGHKJFCJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public AsyncTaskMethodBuilder<BONMJCCGPMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public NDLAIMOKOAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public GHBEDJAHBFG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public GAMMILDHGNJ roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private OLBGEKIIFJE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C752F0", Offset = "0x8C740F0", VA = "0x188C752F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C75990", Offset = "0x8C74790", VA = "0x188C75990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class NNLDGBKJJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NNLDGBKJJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C7C200", Offset = "0x8C7B000", VA = "0x188C7C200")]
		internal object JKJJEMPBAFM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct NKGLABIHKAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public NDLAIMOKOAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public GHBEDJAHBFG serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private NNLDGBKJJEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private OLBGEKIIFJE <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private LIJJHMMHNOE<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B4A0", Offset = "0x8C7A2A0", VA = "0x188C7B4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C7C060", Offset = "0x8C7AE60", VA = "0x188C7C060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private static readonly TimeSpan AHGHNBFPFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private readonly GMAEBIALDHG IFLCNCHHDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private readonly BAOBNKCADNJ EJBPKBDICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private readonly KCCDLLPMDJE MJDAJCHLEPI;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8C7B430", Offset = "0x8C7A230", VA = "0x188C7B430")]
	public NDLAIMOKOAJ(PJFBPPKKEKB CMNNOKDIHPK, GMAEBIALDHG IFLCNCHHDBK, BAOBNKCADNJ HEBJOKNHCIA, KCCDLLPMDJE MJDAJCHLEPI, ALMLLDBPKBM IPEKLICENHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8C7B270", Offset = "0x8C7A070", VA = "0x188C7B270")]
	[AsyncStateMachine(typeof(JNPGHKJFCJB))]
	public Task<BONMJCCGPMP> OFACCHGGJAP(long IHNMKJEEFMK, GAMMILDHGNJ FJJFOGPMEPG, GHBEDJAHBFG KPMIKLAENNK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8C7AF30", Offset = "0x8C79D30", VA = "0x188C7AF30")]
	private static bool HNLLCPCLHPD(PersistenceView LNFCNKMMELP, [Out] GAIGFCPEKCF MPEAFNEFBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8C7ADF0", Offset = "0x8C79BF0", VA = "0x188C7ADF0")]
	[AsyncStateMachine(typeof(NKGLABIHKAP))]
	private Task HHPBAFMKBEL(GHBEDJAHBFG KPMIKLAENNK, PersistenceView[] EGKHKKEIBFB, StringBuilder BHOBEDIGACH, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x8C7A7E0", Offset = "0x8C795E0", VA = "0x188C7A7E0")]
	private BONMJCCGPMP FJHIJCAEMPF(long IHNMKJEEFMK, GAMMILDHGNJ FJJFOGPMEPG, GHBEDJAHBFG KPMIKLAENNK, IEnumerable<PersistenceView> EGKHKKEIBFB, StringBuilder BHOBEDIGACH)
	{
		return default(BONMJCCGPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x8C7A190", Offset = "0x8C78F90", VA = "0x188C7A190")]
	private GJJFFFDCKLI AAEGNKIAMPN(long IHNMKJEEFMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x8C7B020", Offset = "0x8C79E20", VA = "0x188C7B020")]
	private void KEJGGBJFNFN(GJJFFFDCKLI EHLMDPDLECO, StringBuilder BHOBEDIGACH, IEnumerable<PersistenceView> EGKHKKEIBFB, [In] KKMHEHMBILH OHILBHJCCLG, MENBPLBKBNC NKIDENMICPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8C7A350", Offset = "0x8C79150", VA = "0x188C7A350")]
	private void DDELEFCAONJ(GJJFFFDCKLI EHLMDPDLECO, StringBuilder BHOBEDIGACH, PersistenceView LNFCNKMMELP, MENBPLBKBNC NKIDENMICPE, [In] KKMHEHMBILH OHILBHJCCLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class GFJBIPLAKCN : GNALPIJHMMO
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class COOPHFAKLPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public LNABKHPNKHD.KAIGKENNNKK roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public COOPHFAKLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C960", Offset = "0x8C6B760", VA = "0x188C6C960")]
		internal object DNGFDBDIIOF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct FDGLNEDOECK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public AsyncTaskMethodBuilder<(LNABKHPNKHD.KAIGKENNNKK roomDataUpload, LNABKHPNKHD.KAIGKENNNKK subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public BONMJCCGPMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public OEGPLBBEHEH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private COOPHFAKLPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private TaskAwaiter<LNABKHPNKHD.KAIGKENNNKK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C6EB60", Offset = "0x8C6D960", VA = "0x188C6EB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C6F3E0", Offset = "0x8C6E1E0", VA = "0x188C6F3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct MCFEPHMBHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public AsyncTaskMethodBuilder<MAOJOMONGLP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public GFJBIPLAKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public AEEKNFEBJIC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public BONMJCCGPMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<MAOJOMONGLP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C78CC0", Offset = "0x8C77AC0", VA = "0x188C78CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C78F60", Offset = "0x8C77D60", VA = "0x188C78F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct IPINJOOLMLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public AsyncTaskMethodBuilder<MAOJOMONGLP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public OEGPLBBEHEH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public BONMJCCGPMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public FEECGLCDNNH ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public AEEKNFEBJIC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<(LNABKHPNKHD.KAIGKENNNKK roomDataUpload, LNABKHPNKHD.KAIGKENNNKK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private TaskAwaiter<MAOJOMONGLP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C73C90", Offset = "0x8C72A90", VA = "0x188C73C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C742F0", Offset = "0x8C730F0", VA = "0x188C742F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct MIOFBLBECCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public AsyncTaskMethodBuilder<FMCAFGCNOGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public GFJBIPLAKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public BONMJCCGPMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private TaskAwaiter<(LNABKHPNKHD.KAIGKENNNKK roomDataUpload, LNABKHPNKHD.KAIGKENNNKK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private TaskAwaiter<FMCAFGCNOGM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C78FD0", Offset = "0x8C77DD0", VA = "0x188C78FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C79490", Offset = "0x8C78290", VA = "0x188C79490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private sealed class LBGPJGCHCHC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public LBGPJGCHCHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private ILNIOCDMOKB <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private TaskAwaiter<FMCAFGCNOGM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private TaskAwaiter<MAOJOMONGLP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private TaskAwaiter<ILNIOCDMOKB> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8C7ED90", Offset = "0x8C7DB90", VA = "0x188C7ED90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C7FFA0", Offset = "0x8C7EDA0", VA = "0x188C7FFA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public GFJBIPLAKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public BONMJCCGPMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public AEEKNFEBJIC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public IJBCPJDBMGJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LBGPJGCHCHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C78660", Offset = "0x8C77460", VA = "0x188C78660")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<ILNIOCDMOKB> KAEHGFACMIK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private struct BNCMABCHIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public AsyncTaskMethodBuilder<ILNIOCDMOKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public GFJBIPLAKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public BONMJCCGPMP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public AEEKNFEBJIC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public IJBCPJDBMGJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private TaskAwaiter<ILNIOCDMOKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B670", Offset = "0x8C6A470", VA = "0x188C6B670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B9A0", Offset = "0x8C6A7A0", VA = "0x188C6B9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private static readonly ALMLLDBPKBM OPEFCHHOAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400077F")]
	private readonly ECNGILNHGCF HEOPEKAFEDE;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private BKHBBNALJMN ALDEHMGMJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C47000", Offset = "0x8C45E00", VA = "0x188C47000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8C712B0", Offset = "0x8C700B0", VA = "0x188C712B0")]
	public GFJBIPLAKCN(PJFBPPKKEKB CMNNOKDIHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x8C710D0", Offset = "0x8C6FED0", VA = "0x188C710D0")]
	[AsyncStateMachine(typeof(FDGLNEDOECK))]
	private static Task<(LNABKHPNKHD.KAIGKENNNKK, LNABKHPNKHD.KAIGKENNNKK)> NNIPNBHJENL(OEGPLBBEHEH OLPMMDDOCOO, BONMJCCGPMP LMPMNOIEEBA, long MDNJLMOPJKG, long JDPEMOIFJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x8C70C30", Offset = "0x8C6FA30", VA = "0x188C70C30")]
	[AsyncStateMachine(typeof(MCFEPHMBHAG))]
	public Task<MAOJOMONGLP> EPHAEMOFIII(int KDAOGIDDFPA, [CanBeNull] AEEKNFEBJIC MJONPNHCEAJ, BONMJCCGPMP LMPMNOIEEBA, long MDNJLMOPJKG, long JDPEMOIFJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x8C70750", Offset = "0x8C6F550", VA = "0x188C70750")]
	public static Task<MAOJOMONGLP> EPHAEMOFIII(OEGPLBBEHEH OLPMMDDOCOO, int KDAOGIDDFPA, [CanBeNull] AEEKNFEBJIC MJONPNHCEAJ, BONMJCCGPMP LMPMNOIEEBA, long MDNJLMOPJKG, long JDPEMOIFJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x8C70AA0", Offset = "0x8C6F8A0", VA = "0x188C70AA0")]
	[AsyncStateMachine(typeof(IPINJOOLMLK))]
	public static Task<MAOJOMONGLP> EPHAEMOFIII(OEGPLBBEHEH OLPMMDDOCOO, int KDAOGIDDFPA, [CanBeNull] AEEKNFEBJIC MJONPNHCEAJ, BONMJCCGPMP LMPMNOIEEBA, long MDNJLMOPJKG, long JDPEMOIFJMF, FEECGLCDNNH BOCMFDDCHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C70DA0", Offset = "0x8C6FBA0", VA = "0x188C70DA0")]
	[AsyncStateMachine(typeof(MIOFBLBECCH))]
	private Task<FMCAFGCNOGM> GMECLPIJEKI(string ELKCLIPKPIB, int KDAOGIDDFPA, BONMJCCGPMP LMPMNOIEEBA, long MDNJLMOPJKG, long JDPEMOIFJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x8C70F20", Offset = "0x8C6FD20", VA = "0x188C70F20")]
	[AsyncStateMachine(typeof(BNCMABCHIKF))]
	public Task<ILNIOCDMOKB> NLKLGPKIPGJ(int KDAOGIDDFPA, AEEKNFEBJIC? MJONPNHCEAJ, BONMJCCGPMP LMPMNOIEEBA, long MDNJLMOPJKG, long JDPEMOIFJMF, IJBCPJDBMGJ DLJBFCJMKNL, GMHMEBHNAOE<string>.HGELJMPBEBF NJAFLFFJAMF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public abstract class EHCGFNHDFKH<T> where T : EHCGFNHDFKH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	internal readonly BKHBBNALJMN NIHMACNDMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	private int? MLOLEDFJFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	protected readonly Guid NOAOIACHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	protected readonly FLHPGIIOBFD LLCLIELMNAB;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T FPMCALMGODL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x4A57750", Offset = "0x4A56550", VA = "0x184A57750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A577B0", Offset = "0x4A565B0", VA = "0x184A577B0")]
	internal EHCGFNHDFKH(BKHBBNALJMN KPCOPNGLJNH, FLHPGIIOBFD BIMCGLHMFPP, [Optional] Guid? ECLLBKCDLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A57430", Offset = "0x4A56230", VA = "0x184A57430")]
	private ILNIOCDMOKB AFDIGPBGMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	protected virtual void IJHJDKGNBCB(ILNIOCDMOKB JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A576C0", Offset = "0x4A564C0", VA = "0x184A576C0")]
	public T GJNLOPHKBDE(AFLCFHLHEHB EAJPHPMCNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A57630", Offset = "0x4A56430", VA = "0x184A57630")]
	public T FEBFMHBNDDE(int PPGAGPBBEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x4A57510", Offset = "0x4A56310", VA = "0x184A57510", Slot = "5")]
	public virtual Task<NNJLPCOCOKC> CKAPDOLBELH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class CDFCDLDPOPN : EHCGFNHDFKH<CDFCDLDPOPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private OHMMKMCFEGD OBBABGHFJAB;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BC20", Offset = "0x8C6AA20", VA = "0x188C6BC20")]
	internal CDFCDLDPOPN(BKHBBNALJMN KPCOPNGLJNH, FLHPGIIOBFD BIMCGLHMFPP, [Optional] Guid? ECLLBKCDLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2B20", Offset = "0x7DF1920", VA = "0x187DF2B20")]
	public CDFCDLDPOPN OCPGPIMMIJK(OHMMKMCFEGD OBBABGHFJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB50", Offset = "0x8C6A950", VA = "0x188C6BB50", Slot = "4")]
	protected override void IJHJDKGNBCB(ILNIOCDMOKB JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class MMDDJNGOMEC : EHCGFNHDFKH<MMDDJNGOMEC>
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	internal enum DMOKMMEDPLE
	{
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[CompilerGenerated]
	private struct AFIGNBLFGNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public AsyncTaskMethodBuilder<NNJLPCOCOKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public MMDDJNGOMEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private TaskAwaiter<NNJLPCOCOKC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A0E0", Offset = "0x8C68EE0", VA = "0x188C6A0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A490", Offset = "0x8C69290", VA = "0x188C6A490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private DMOKMMEDPLE NBJNOHHJEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private string CPENMEANHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private AEEKNFEBJIC OBBABGHFJAB;

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C79840", Offset = "0x8C78640", VA = "0x188C79840")]
	internal MMDDJNGOMEC(BKHBBNALJMN KPCOPNGLJNH, FLHPGIIOBFD BIMCGLHMFPP, [Optional] Guid? ECLLBKCDLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C79640", Offset = "0x8C78440", VA = "0x188C79640")]
	public MMDDJNGOMEC FILCIECPIIG(string CDEPGINEGKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C79820", Offset = "0x8C78620", VA = "0x188C79820")]
	public MMDDJNGOMEC KNFOPMHBPFD(bool GCFPMNAOPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C79500", Offset = "0x8C78300", VA = "0x188C79500")]
	public MMDDJNGOMEC AJEOAFKBKDC(bool DGCDOMGBCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C79520", Offset = "0x8C78320", VA = "0x188C79520")]
	public MMDDJNGOMEC CAGFCHGAEFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C79670", Offset = "0x8C78470", VA = "0x188C79670", Slot = "4")]
	protected override void IJHJDKGNBCB(ILNIOCDMOKB JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x8C79550", Offset = "0x8C78350", VA = "0x188C79550", Slot = "5")]
	[AsyncStateMachine(typeof(AFIGNBLFGNP))]
	public override Task<NNJLPCOCOKC> CKAPDOLBELH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x8C797E0", Offset = "0x8C785E0", VA = "0x188C797E0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<NNJLPCOCOKC> IPCDEMHAEDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal static class EKANICFECGI
{
	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8C6E990", Offset = "0x8C6D790", VA = "0x188C6E990")]
	public static void BMADDKPBCPN(this OKDCCHNMBFL HPHALDJNLGO, LLDPOPPOJLA HNIKCHJLJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C6EAE0", Offset = "0x8C6D8E0", VA = "0x188C6EAE0")]
	public static void GIJLEPFEHLO(this LLDPOPPOJLA CIOKEJIGMAO, [Optional] string JDFCBBCKOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class GIHECIENEOM
{
	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8C71F60", Offset = "0x8C70D60", VA = "0x188C71F60")]
	public static PEDNEEGBGKL DOMNAENLLOC(this GMCIGPMGCNH BPPLENMMKDA)
	{
		return default(PEDNEEGBGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8C72000", Offset = "0x8C70E00", VA = "0x188C72000")]
	public static GMCIGPMGCNH KCHAFNFFANJ(this PEDNEEGBGKL EPGGKIMGIAI)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B9")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public KKAJILCJHNC ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public KKAJILCJHNC HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private static KKAJILCJHNC[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private Dictionary<KKAJILCJHNC, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C80560", Offset = "0x8C7F360", VA = "0x188C80560")]
		public bool IMHIGMJNIOH(KKAJILCJHNC HOIOHNBMHAI, [Out] ResultConfig AFFIHAGMLBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C805D0", Offset = "0x8C7F3D0", VA = "0x188C805D0")]
		public ResultConfig OMEDIJOECEH(KKAJILCJHNC BCDABHDFJPD, [Optional] HashSet<KKAJILCJHNC> EIAMOIPLDAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C80C40", Offset = "0x8C7FA40", VA = "0x188C80C40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C80710", Offset = "0x8C7F510", VA = "0x188C80710", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public class DNPNIIHPAJB : FDFKLLFNDOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct GAEPBAKJOCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public DNPNIIHPAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8C6FED0", Offset = "0x8C6ECD0", VA = "0x188C6FED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C70160", Offset = "0x8C6EF60", VA = "0x188C70160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private struct ACMLKHGEIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public GMHMEBHNAOE<string>.HGELJMPBEBF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public FDFKLLFNDOG preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private GMHMEBHNAOE<string>.HGELJMPBEBF <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C69B20", Offset = "0x8C68920", VA = "0x188C69B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C69FD0", Offset = "0x8C68DD0", VA = "0x188C69FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	private readonly JABEOLGBIAM EDFJELFKJBP;

	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string MCNFMNCEHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E7E0", Offset = "0x8C6D5E0", VA = "0x188C6E7E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x8C6E770", Offset = "0x8C6D570", VA = "0x188C6E770")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void NCFBCDNFMCP(HJFNEHLLJBB NPHHLLEFMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	[RecRoom.NoEngine.Common.Preserve]
	public DNPNIIHPAJB([POMNKOCGGBN(null)] JABEOLGBIAM EDFJELFKJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x8C6E810", Offset = "0x8C6D610", VA = "0x188C6E810", Slot = "5")]
	[AsyncStateMachine(typeof(GAEPBAKJOCF))]
	public Task PLBGJCCDHGP(GMHMEBHNAOE<string>.HGELJMPBEBF CFNBNFAEHIP, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8C6E650", Offset = "0x8C6D450", VA = "0x188C6E650")]
	[AsyncStateMachine(typeof(ACMLKHGEIOD))]
	private Task KNLAICJMAKP(FDFKLLFNDOG NHNDMEPANGH, GMHMEBHNAOE<string>.HGELJMPBEBF CFNBNFAEHIP, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface JABEOLGBIAM : FDFKLLFNDOG
{
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface FDFKLLFNDOG
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string MCNFMNCEHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PLBGJCCDHGP(GMHMEBHNAOE<string>.HGELJMPBEBF CFNBNFAEHIP, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public static class JAKGKCHDNPP
{
	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x8C74360", Offset = "0x8C73160", VA = "0x188C74360")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void ODAPPKPCBLD(HJFNEHLLJBB NPHHLLEFMPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public interface KGMHFIJAHBM : IEquatable<KGMHFIJAHBM>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime CNCPPNBLGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPKMMMHPFBF();

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPOPONNIGBC(long MDNJLMOPJKG, long IHNMKJEEFMK, [Out] BONMJCCGPMP LMPMNOIEEBA);
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal class CIAJIDBFHCD : KPOMBEACODE
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class JLJEBOFPKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public AFPPAFDLPDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JLJEBOFPKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x8C74770", Offset = "0x8C73570", VA = "0x188C74770")]
		internal object FEEAOCEBLGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly KFKMKMKDDPH BPECNMMPDLA;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<KGMHFIJAHBM> AFMFAIHKJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BFC0", Offset = "0x8C6ADC0", VA = "0x188C6BFC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BF10", Offset = "0x8C6AD10", VA = "0x188C6BF10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	[UnityEngine.Scripting.Preserve]
	public CIAJIDBFHCD([POMNKOCGGBN(null)] KFKMKMKDDPH BPECNMMPDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C5D0", Offset = "0x8C6B3D0", VA = "0x188C6C5D0", Slot = "6")]
	public bool PGIHJDHJNED(long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA, AFPPAFDLPDP KBBJPPACKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0xF5D270", Offset = "0xF5C070", VA = "0x180F5D270")]
	private void DMBFFIOJBAL(KGMHFIJAHBM BIAIDCADKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BDA0", Offset = "0x8C6ABA0", VA = "0x188C6BDA0", Slot = "7")]
	public bool HFIECNGEKKK(long MDNJLMOPJKG, long IHNMKJEEFMK, [Out] KGMHFIJAHBM MPGGIHFBNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BCF0", Offset = "0x8C6AAF0", VA = "0x188C6BCF0", Slot = "8")]
	public bool GPEJAONCIDG(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, [Out] KGMHFIJAHBM MPGGIHFBNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C070", Offset = "0x8C6AE70", VA = "0x188C6C070")]
	private void MAMFEDPDCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C4A0", Offset = "0x8C6B2A0", VA = "0x188C6C4A0", Slot = "9")]
	public void OGCEHCLEMBA(long MDNJLMOPJKG, long IHNMKJEEFMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal abstract class KIJBBKFALIE : KFKMKMKDDPH
{
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	protected enum MEOIGLKKIKE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class BKMEANENNBL : IEnumerable<KGMHFIJAHBM>, IEnumerable, IEnumerator<KGMHFIJAHBM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private KGMHFIJAHBM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public KIJBBKFALIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private AFPPAFDLPDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public AFPPAFDLPDP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private KGMHFIJAHBM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public BKMEANENNBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B340", Offset = "0x8C6A140", VA = "0x188C6B340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B620", Offset = "0x8C6A420", VA = "0x188C6B620", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B570", Offset = "0x8C6A370", VA = "0x188C6B570", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KGMHFIJAHBM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B570", Offset = "0x8C6A370", VA = "0x188C6B570", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class AIFGFJOCJMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public AFPPAFDLPDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AIFGFJOCJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A500", Offset = "0x8C69300", VA = "0x188C6A500")]
		internal object PGINJNJMPLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	private sealed class MOLALLPKNHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		public KIJBBKFALIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MOLALLPKNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7A110", Offset = "0x8C78F10", VA = "0x188C7A110")]
		internal void JLILMJDKOEF(JMHIBBLCPKM.DEOBAGKCNBH ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly object JNLKAJNPGHI;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string FICFNKOFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x8C77C70", Offset = "0x8C76A70", VA = "0x188C77C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract DILGLKOJCHC PLCGLBIGLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8C77F70", Offset = "0x8C76D70", VA = "0x188C77F70")]
	protected KIJBBKFALIE([CanBeNull] string CKEIPIJJMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x8C77D10", Offset = "0x8C76B10", VA = "0x188C77D10", Slot = "5")]
	public bool JDFLJBPCECE(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, [Out] KGMHFIJAHBM BIAIDCADKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8C77C80", Offset = "0x8C76A80", VA = "0x188C77C80", Slot = "6")]
	[IteratorStateMachine(typeof(BKMEANENNBL))]
	public IEnumerable<KGMHFIJAHBM> ICJIBOACMEK(AFPPAFDLPDP KBBJPPACKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void GHGKJOLLCBE(Stream FNPDAGGCDOE, long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BCGKCNLIJKP(Stream KFFMHPPPDJA, long MDNJLMOPJKG, long IHNMKJEEFMK, OCBCIOIDDOG MIJMJPCEGKH, [Out] BONMJCCGPMP LMPMNOIEEBA);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x8C778F0", Offset = "0x8C766F0", VA = "0x188C778F0", Slot = "7")]
	public KGMHFIJAHBM CGMHAMFGMJA(long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA, AFPPAFDLPDP KBBJPPACKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo DOPFMKPNMMJ(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, MEOIGLKKIKE PLHFMNDPPLM);

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo PICBBGPJOGC(AFPPAFDLPDP KBBJPPACKCH, MEOIGLKKIKE PLHFMNDPPLM);

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8C77F00", Offset = "0x8C76D00", VA = "0x188C77F00")]
	protected void NAKNPDKELIJ(JMHIBBLCPKM.DEOBAGKCNBH JDLMPMIINGF, string FLNBBIAICOK, FileInfo JELGJMCEDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x8C77530", Offset = "0x8C76330", VA = "0x188C77530")]
	internal bool BODJENIMJJG(FileInfo GFFADEHBPKN, long MDNJLMOPJKG, long IHNMKJEEFMK, [Out] BONMJCCGPMP LMPMNOIEEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private void AFHBGHNOLNF(Exception DDMPALIOLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal class GMGIDJMAMIO : KIJBBKFALIE
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override DILGLKOJCHC PLCGLBIGLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x14FBD40", Offset = "0x14FAB40", VA = "0x1814FBD40", Slot = "8")]
		get
		{
			return default(DILGLKOJCHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8C72CC0", Offset = "0x8C71AC0", VA = "0x188C72CC0")]
	public GMGIDJMAMIO([Optional] string CKEIPIJJMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8C727A0", Offset = "0x8C715A0", VA = "0x188C727A0")]
	private void CIANEIMKNDD(AFPPAFDLPDP KBBJPPACKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8C72910", Offset = "0x8C71710", VA = "0x188C72910", Slot = "9")]
	internal override void GHGKJOLLCBE(Stream FNPDAGGCDOE, long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8C720B0", Offset = "0x8C70EB0", VA = "0x188C720B0", Slot = "10")]
	internal override bool BCGKCNLIJKP(Stream KFFMHPPPDJA, long MDNJLMOPJKG, long IHNMKJEEFMK, OCBCIOIDDOG MIJMJPCEGKH, [Out] BONMJCCGPMP LMPMNOIEEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x8C72820", Offset = "0x8C71620", VA = "0x188C72820", Slot = "11")]
	protected override FileInfo DOPFMKPNMMJ(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, MEOIGLKKIKE PLHFMNDPPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8C72BC0", Offset = "0x8C719C0", VA = "0x188C72BC0", Slot = "12")]
	protected override DirectoryInfo PICBBGPJOGC(AFPPAFDLPDP KBBJPPACKCH, MEOIGLKKIKE PLHFMNDPPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal sealed class KACBNINPHNO : KIJBBKFALIE
{
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private static readonly byte[] OPGJHIOADCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private readonly byte[] JIMHKMGHPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	private readonly byte[] CGPFAEHEFHM;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override DILGLKOJCHC PLCGLBIGLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1AA5E50", Offset = "0x1AA4C50", VA = "0x181AA5E50", Slot = "8")]
		get
		{
			return default(DILGLKOJCHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x8C76C00", Offset = "0x8C75A00", VA = "0x188C76C00")]
	public KACBNINPHNO([Optional] string CKEIPIJJMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8C76590", Offset = "0x8C75390", VA = "0x188C76590", Slot = "9")]
	internal override void GHGKJOLLCBE(Stream FNPDAGGCDOE, long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8C75A00", Offset = "0x8C74800", VA = "0x188C75A00", Slot = "10")]
	internal override bool BCGKCNLIJKP(Stream KFFMHPPPDJA, long MDNJLMOPJKG, long IHNMKJEEFMK, OCBCIOIDDOG MIJMJPCEGKH, [Out] BONMJCCGPMP LMPMNOIEEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x8C769A0", Offset = "0x8C757A0", VA = "0x188C769A0")]
	private void JKPFPBEDIAN(byte[] JICDOIHAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x8C76460", Offset = "0x8C75260", VA = "0x188C76460", Slot = "11")]
	protected override FileInfo DOPFMKPNMMJ(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, MEOIGLKKIKE PLHFMNDPPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8C76A60", Offset = "0x8C75860", VA = "0x188C76A60", Slot = "12")]
	protected override DirectoryInfo PICBBGPJOGC(AFPPAFDLPDP KBBJPPACKCH, MEOIGLKKIKE PLHFMNDPPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public enum DILGLKOJCHC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal class PIHPOAOFFPI : KFKMKMKDDPH
{
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[CompilerGenerated]
	private sealed class BHEOLHLPKLB : IEnumerable<KGMHFIJAHBM>, IEnumerable, IEnumerator<KGMHFIJAHBM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private KGMHFIJAHBM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public PIHPOAOFFPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private AFPPAFDLPDP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		public AFPPAFDLPDP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private DILGLKOJCHC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private IEnumerator<KGMHFIJAHBM> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private KGMHFIJAHBM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public BHEOLHLPKLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AC20", Offset = "0x8C69A20", VA = "0x188C6AC20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6A7F0", Offset = "0x8C695F0", VA = "0x188C6A7F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AAD0", Offset = "0x8C698D0", VA = "0x188C6AAD0")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8C6ABD0", Offset = "0x8C699D0", VA = "0x188C6ABD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AB20", Offset = "0x8C69920", VA = "0x188C6AB20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KGMHFIJAHBM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AB20", Offset = "0x8C69920", VA = "0x188C6AB20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly DILGLKOJCHC[] BHCELDDBGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private readonly Dictionary<DILGLKOJCHC, KFKMKMKDDPH> ONOIKKOPKLC;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public DILGLKOJCHC PLCGLBIGLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D5D0", Offset = "0x8C7C3D0", VA = "0x188C7D5D0", Slot = "4")]
		get
		{
			return default(DILGLKOJCHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8C7DB10", Offset = "0x8C7C910", VA = "0x188C7DB10")]
	[UnityEngine.Scripting.Preserve]
	public PIHPOAOFFPI(params KFKMKMKDDPH[] HPLMEDMIEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D9C0", Offset = "0x8C7C7C0", VA = "0x188C7D9C0", Slot = "5")]
	public bool JDFLJBPCECE(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, [Out] KGMHFIJAHBM BIAIDCADKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D6F0", Offset = "0x8C7C4F0", VA = "0x188C7D6F0")]
	private void COBFMHMMNMA(int PGJGPBGJLJE, long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D930", Offset = "0x8C7C730", VA = "0x188C7D930", Slot = "6")]
	[IteratorStateMachine(typeof(BHEOLHLPKLB))]
	public IEnumerable<KGMHFIJAHBM> ICJIBOACMEK(AFPPAFDLPDP KBBJPPACKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D600", Offset = "0x8C7C400", VA = "0x188C7D600", Slot = "7")]
	public KGMHFIJAHBM CGMHAMFGMJA(long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA, AFPPAFDLPDP KBBJPPACKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal static class KGGDJBEJGIO
{
	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x8C77290", Offset = "0x8C76090", VA = "0x188C77290")]
	internal static byte[] GMAINCIMIFI(byte[] JICDOIHAMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x8C77210", Offset = "0x8C76010", VA = "0x188C77210")]
	public static void AENOONFBLMC(Stream NHGEKAGHMLN, byte[] LJMFIOEPOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8C77350", Offset = "0x8C76150", VA = "0x188C77350")]
	public static bool OPBFHCJLAID(Stream NHGEKAGHMLN, long AMKPLHIKKLD, OCBCIOIDDOG CKDOOAFMIHD, [Out] byte[] IHAENLEHGLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal sealed class GGBNIAHLDAM : KGMHFIJAHBM, IEquatable<KGMHFIJAHBM>, IEquatable<GGBNIAHLDAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000821")]
	private readonly KIJBBKFALIE AHBFPEAPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000822")]
	public readonly FileInfo LGNHEABNLGM;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public DILGLKOJCHC PLCGLBIGLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x84E3320", Offset = "0x84E2120", VA = "0x1884E3320", Slot = "9")]
		get
		{
			return default(DILGLKOJCHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime CNCPPNBLGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x8C71620", Offset = "0x8C70420", VA = "0x188C71620", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8C71830", Offset = "0x8C70630", VA = "0x188C71830")]
	public GGBNIAHLDAM(KIJBBKFALIE AONBJMDDKBH, FileInfo GFFADEHBPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8C71780", Offset = "0x8C70580", VA = "0x188C71780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8C71560", Offset = "0x8C70360", VA = "0x188C71560", Slot = "5")]
	public void GPKMMMHPFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8C71740", Offset = "0x8C70540", VA = "0x188C71740", Slot = "6")]
	public bool MPOPONNIGBC(long MDNJLMOPJKG, long IHNMKJEEFMK, [Out] BONMJCCGPMP LMPMNOIEEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8C714F0", Offset = "0x8C702F0", VA = "0x188C714F0", Slot = "7")]
	public bool Equals(KGMHFIJAHBM FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x8C71340", Offset = "0x8C70140", VA = "0x188C71340", Slot = "8")]
	public bool Equals(GGBNIAHLDAM FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x8C71400", Offset = "0x8C70200", VA = "0x188C71400", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x8C716B0", Offset = "0x8C704B0", VA = "0x188C716B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public delegate void OCBCIOIDDOG(JMHIBBLCPKM.DEOBAGKCNBH IIKKBMBOAAI, string JDFCBBCKOGJ);
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal interface KFKMKMKDDPH
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	DILGLKOJCHC PLCGLBIGLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDFLJBPCECE(long MDNJLMOPJKG, long IHNMKJEEFMK, AFPPAFDLPDP KBBJPPACKCH, [Out] KGMHFIJAHBM BIAIDCADKFG);

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KGMHFIJAHBM> ICJIBOACMEK(AFPPAFDLPDP KBBJPPACKCH);

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KGMHFIJAHBM CGMHAMFGMJA(long MDNJLMOPJKG, long IHNMKJEEFMK, BONMJCCGPMP LMPMNOIEEBA, AFPPAFDLPDP KBBJPPACKCH);
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
