using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using UnityEngine;

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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62C4410", Offset = "0x62C3010", VA = "0x1862C4410")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_Images
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62C4500", Offset = "0x62C3100", VA = "0x1862C4500", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HKBGOEFPCBL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MGEGMLPKNPK<Texture2D> GCFMFJPCNAB(string NMALPFABKBF, [Optional] uint? ELOMKDKGNAD, bool MEPLGOPIIAK = false, OFAIJPNINJM ONGNJGAJNIH = OFAIJPNINJM.Default);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGEGMLPKNPK<Texture2D> IJLKAKBBOCM(EKHCBLLPBBB LHKGOBANHNI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MGEGMLPKNPK<Texture2D> KEEAPKDDHLJ(GJLANJLOIAD ABFHEEBDGGH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MGEGMLPKNPK<Texture2D> JPFGMPEKAHP(ILKPFMBHNJM HFMBBCPPOHA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MGEGMLPKNPK<Texture2D> APFPKDPCJDK(ENCCMNNKPDI JKANPJMHAGJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MGEGMLPKNPK<Texture2D> COKKIMFPLLL(ICLENIMKNDA BMKCBKGENJD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class AIGLCAFAAKC : HKBGOEFPCBL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct LNDFELDFDNM : IEquatable<LNDFELDFDNM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string MOAEFANAIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? PIBJOHIECHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool KPFGLKHFCNF;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62C3BC0", Offset = "0x62C27C0", VA = "0x1862C3BC0")]
		public LNDFELDFDNM(string NMALPFABKBF, uint? ELOMKDKGNAD, bool MEPLGOPIIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x62C38D0", Offset = "0x62C24D0", VA = "0x1862C38D0", Slot = "4")]
		public bool Equals(LNDFELDFDNM FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62C3990", Offset = "0x62C2590", VA = "0x1862C3990", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62C3A30", Offset = "0x62C2630", VA = "0x1862C3A30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62C3AB0", Offset = "0x62C26B0", VA = "0x1862C3AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MNOKKJCMKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public LNDFELDFDNM imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62C3C00", Offset = "0x62C2800", VA = "0x1862C3C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62C3EA0", Offset = "0x62C2AA0", VA = "0x1862C3EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct FLIEGCJFJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<MGEGMLPKNPK<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public uint? resizeWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AIGLCAFAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OFAIJPNINJM textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x62C2B80", Offset = "0x62C1780", VA = "0x1862C2B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62C2D70", Offset = "0x62C1970", VA = "0x1862C2D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LAHFHMFGGAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<MGEGMLPKNPK<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EKHCBLLPBBB room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AIGLCAFAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<MGEGMLPKNPK<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62C3180", Offset = "0x62C1D80", VA = "0x1862C3180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62C34B0", Offset = "0x62C20B0", VA = "0x1862C34B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JNEADDIFKEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<MGEGMLPKNPK<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GJLANJLOIAD invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AIGLCAFAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<MGEGMLPKNPK<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62C2DE0", Offset = "0x62C19E0", VA = "0x1862C2DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62C3110", Offset = "0x62C1D10", VA = "0x1862C3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct NMBHMMLGOEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<MGEGMLPKNPK<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ILKPFMBHNJM playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AIGLCAFAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<EKHCBLLPBBB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<MGEGMLPKNPK<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62C3F10", Offset = "0x62C2B10", VA = "0x1862C3F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62C43A0", Offset = "0x62C2FA0", VA = "0x1862C43A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LJADAKBDDFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<MGEGMLPKNPK<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public ENCCMNNKPDI account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AIGLCAFAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<MGEGMLPKNPK<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62C3520", Offset = "0x62C2120", VA = "0x1862C3520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62C3860", Offset = "0x62C2460", VA = "0x1862C3860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DLJLIDAOLIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<MGEGMLPKNPK<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ICLENIMKNDA announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AIGLCAFAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<MGEGMLPKNPK<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62C2850", Offset = "0x62C1450", VA = "0x1862C2850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x62C2B10", Offset = "0x62C1710", VA = "0x1862C2B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly EAPHNCOENHH.Resolution HPLGMLHEILH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly EAPHNCOENHH.Resolution MCOPIBPKOBB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly EAPHNCOENHH.Resolution EPKLHMIJDIG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly EAPHNCOENHH.Resolution GFLKPKILCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly COGMCEGLEKH<LNDFELDFDNM> CKIJFLLJNCJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62C2140", Offset = "0x62C0D40", VA = "0x1862C2140")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void JIEKEBODNGC(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62C26A0", Offset = "0x62C12A0", VA = "0x1862C26A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AIGLCAFAAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62C1BF0", Offset = "0x62C07F0", VA = "0x1862C1BF0", Slot = "4")]
	public MGEGMLPKNPK<Texture2D> GCFMFJPCNAB(string NMALPFABKBF, [Optional] uint? ELOMKDKGNAD, bool MEPLGOPIIAK = false, OFAIJPNINJM ONGNJGAJNIH = OFAIJPNINJM.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62C1D90", Offset = "0x62C0990", VA = "0x1862C1D90", Slot = "5")]
	public MGEGMLPKNPK<Texture2D> IJLKAKBBOCM(EKHCBLLPBBB LHKGOBANHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62C24A0", Offset = "0x62C10A0", VA = "0x1862C24A0", Slot = "6")]
	public MGEGMLPKNPK<Texture2D> KEEAPKDDHLJ(GJLANJLOIAD ABFHEEBDGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62C2240", Offset = "0x62C0E40", VA = "0x1862C2240", Slot = "7")]
	public MGEGMLPKNPK<Texture2D> JPFGMPEKAHP(ILKPFMBHNJM HFMBBCPPOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62C1720", Offset = "0x62C0320", VA = "0x1862C1720", Slot = "8")]
	public MGEGMLPKNPK<Texture2D> APFPKDPCJDK(ENCCMNNKPDI JKANPJMHAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62C1860", Offset = "0x62C0460", VA = "0x1862C1860", Slot = "9")]
	public MGEGMLPKNPK<Texture2D> COKKIMFPLLL(ICLENIMKNDA BMKCBKGENJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62C1AC0", Offset = "0x62C06C0", VA = "0x1862C1AC0")]
	[AsyncStateMachine(typeof(MNOKKJCMKJP))]
	private Task<byte[]> FHADMFJBJNP(LNDFELDFDNM PHGKANOANOB, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62C1ED0", Offset = "0x62C0AD0", VA = "0x1862C1ED0")]
	[AsyncStateMachine(typeof(FLIEGCJFJEA))]
	private Task<MGEGMLPKNPK<Texture2D>> IMDHPDNAOJK(string NMALPFABKBF, [Optional] uint? ELOMKDKGNAD, bool MEPLGOPIIAK = false, OFAIJPNINJM ONGNJGAJNIH = OFAIJPNINJM.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62C2030", Offset = "0x62C0C30", VA = "0x1862C2030")]
	[AsyncStateMachine(typeof(LAHFHMFGGAI))]
	private Task<MGEGMLPKNPK<Texture2D>> JBIAIMDFDBE(EKHCBLLPBBB LHKGOBANHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62C2390", Offset = "0x62C0F90", VA = "0x1862C2390")]
	[AsyncStateMachine(typeof(JNEADDIFKEJ))]
	private Task<MGEGMLPKNPK<Texture2D>> KCNCDBODBPK(GJLANJLOIAD ABFHEEBDGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62C19A0", Offset = "0x62C05A0", VA = "0x1862C19A0")]
	[AsyncStateMachine(typeof(NMBHMMLGOEH))]
	private Task<MGEGMLPKNPK<Texture2D>> EGNDJJJEGLP(ILKPFMBHNJM HFMBBCPPOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62C1610", Offset = "0x62C0210", VA = "0x1862C1610")]
	[AsyncStateMachine(typeof(LJADAKBDDFI))]
	private Task<MGEGMLPKNPK<Texture2D>> ANKJEIDOEAG(ENCCMNNKPDI JKANPJMHAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62C1C80", Offset = "0x62C0880", VA = "0x1862C1C80")]
	[AsyncStateMachine(typeof(DLJLIDAOLIF))]
	private Task<MGEGMLPKNPK<Texture2D>> HCDGMLPPKFE(ICLENIMKNDA BMKCBKGENJD)
	{
		return null;
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
