using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26FAB20", Offset = "0x26F9F20", VA = "0x1826FAB20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FBOKFHKKMKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34638E0", Offset = "0x3462CE0", VA = "0x1834638E0")]
	public static JHLAGGIINPD<JAGIEGAIEJN<M>> AHOBLPKBKKJ<M>(this int KBBJDOAJMAF)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26F50D0", Offset = "0x26F44D0", VA = "0x1826F50D0")]
	public static JHLAGGIINPD<OFDLNEPEDGC> ICCNEBFEJBN(this int KBBJDOAJMAF)
	{
		return default(JHLAGGIINPD<OFDLNEPEDGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34638E0", Offset = "0x3462CE0", VA = "0x1834638E0")]
	public static JHLAGGIINPD<HCIGEGLFLDP<M>> FIMPDKFODID<M>(this int KBBJDOAJMAF)
	{
		return default(JHLAGGIINPD<HCIGEGLFLDP<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class JAGIEGAIEJN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BKHBAHEIAML
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AFKMBOJOOJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OFDLNEPEDGC
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class HHIPAMAGICL
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class AIOPOOGLOPK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum DKKNNGDAMAO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	AddF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	AddF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AddF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AddI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	AddI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	AddI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AndI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AndI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AndI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	BranchIfEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BranchIfEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	BranchIfEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	BranchIfEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	BranchIfEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	BranchIfEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	BranchIfGreaterF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	BranchIfGreaterF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	BranchIfGreaterF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	BranchIfGreaterI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	BranchIfGreaterI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	BranchIfGreaterI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BranchIfGreaterOrEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	BranchIfGreaterOrEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	BranchIfGreaterOrEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	BranchIfGreaterOrEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BranchIfGreaterOrEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BranchIfGreaterOrEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BranchIfLessF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BranchIfLessF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BranchIfLessF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BranchIfLessI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BranchIfLessI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BranchIfLessI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BranchIfLessOrEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BranchIfLessOrEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BranchIfLessOrEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BranchIfLessOrEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BranchIfLessOrEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BranchIfLessOrEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BranchIfNotEqualF32_F32i_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BranchIfNotEqualF32_F32i_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BranchIfNotEqualF32_F32r_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BranchIfNotEqualI32_I32i_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BranchIfNotEqualI32_I32i_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BranchIfNotEqualI32_I32r_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BranchIfNotZeroF32_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BranchIfNotZeroF32_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	BranchIfNotZeroI32_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	BranchIfNotZeroI32_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	BranchIfZeroF32_F32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	BranchIfZeroF32_F32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	BranchIfZeroI32_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	BranchIfZeroI32_I32r_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CallInternal_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CallInternal_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CallExternal_I32i_I32i,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CallExternal_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CallRuntime_I32i_I32i_Xi,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CopyI32_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CopyI32_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CopyX_Xr_I32i_Xi,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CopyX_Xr_Xr_I32i,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DivideF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	DivideF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	DivideF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DivideI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DivideI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	DivideI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	EqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	EqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	EqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	EqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	EqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	EqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	GreaterF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	GreaterF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	GreaterF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	GreaterI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	GreaterI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GreaterI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GreaterOrEqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	GreaterOrEqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	GreaterOrEqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	GreaterOrEqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	GreaterOrEqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	GreaterOrEqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Jump_I32i,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Jump_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	LessF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	LessF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	LessF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	LessI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	LessI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	LessI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	LessOrEqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	LessOrEqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	LessOrEqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	LessOrEqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	LessOrEqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LessOrEqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	ModI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	ModI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ModI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MultiplyF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	MultiplyF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MultiplyF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	MultiplyI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MultiplyI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MultiplyI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NegateF32_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NegateF32_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	NegateF32_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	NegateI32_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	NegateI32_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	NegateI32_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	NoOp,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	NotEqualF32_F32i_F32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	NotEqualF32_F32i_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	NotEqualF32_F32r_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	NotEqualI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	NotEqualI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	NotEqualI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	NotI32_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	NotI32_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	NotI32_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	OrI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	OrI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	OrI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Return,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	StaticCastF32I32_F32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	StaticCastI32F32_I32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	SubtractF32_F32i_F32i_F32r,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	SubtractF32_F32i_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	SubtractF32_F32r_F32r_F32r,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	SubtractI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	SubtractI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	SubtractI32_I32r_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	XorI32_I32i_I32i_I32r,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	XorI32_I32i_I32r_I32r,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	XorI32_I32r_I32r_I32r
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JGGFDLGDGNE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OCIGPLHOEFI<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr CHOIFCDJHJG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
		public OCIGPLHOEFI(IntPtr GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5330DA0", Offset = "0x53301A0", VA = "0x185330DA0")]
		public int HFGDGIKOIHK(TDeps BGLHIFBEGOD, TContext KKAHNGFLKHL, TCompileState IGMLJFJLIPB, [In] DNPCPJMGLMI<byte> EBGCCIAFCLK, int DFNNHOHBCCA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37517D0", Offset = "0x3750BD0", VA = "0x1837517D0")]
	public static void DFIDCHIOECH<TDeps, TContext, TCompileState>(TDeps BGLHIFBEGOD, TContext KKAHNGFLKHL, TCompileState IGMLJFJLIPB, [In] DNPCPJMGLMI<byte> BMJDDALHJHM, DNPCPJMGLMI<byte> MGDNHOHDHNM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HPHOHCAFOAN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? EAGPNNDKGHN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FODPMFMFGHF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GHLABMFIDLG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HNKKPCAJLLN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NMFKLJMANHM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DGGHKEGFKFM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BECMAKNJHFG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? COAKBMLMPLB, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JNKJIALKFKO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BGOPFMINGEL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? POLCGKCOPJP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DAJNNNLCCFP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KDEJGBEEIMK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HKCIOGBBPBE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DJJFMOMJMJN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HBBOMFCEGHM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BHHMPLJHGCP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IFMCAJHPJLP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IOBKJGCIHED, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? OENENIGMFDK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JIICKCOBCFH, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IKECBHPEKPE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? CMFMNPBONIB, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? LLAEHEJAFLN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DCAPEFEIEEH, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? ALGBNGPPGAO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? EFJEGBJKILI, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? ABBAGEPCEON, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BLIHFAICOIL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FCJDMJKGOIO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GONLMBAFCHH, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JKAKDDFFFEM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DCLGIGNFEIM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DINFHKENKPK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? CHMALBLPBCF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? LEHINGHPOPJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? PHAFEKBKFJJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? AHDNPGKFOON, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? OOFGDNAKFKN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FOKDBKLHPGB, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BEONFFMMDBB, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? LIEPHCIEFNG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BAPLIKDKCFP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FDANBDBACJH, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BAAKCOBOGEK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DHMPIDHKNAO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IALAGBKGMCO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? EEPKHHAACGE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NILGPCBBECE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? MGGPOOCMMNJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NJBAIPFNJAK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HJLEFBOKDFO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NNBFNLLECJO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DCDGMJIGGNF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? AJAICLBOHML, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IBPJDCOLBGN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KMBDEAGJGGJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KDGFBACHNOP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JFLBINLJJMD, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? LEGHPNLEFHN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GAEDCLPLFGK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IHJIPFKMOBA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BLIOIMFEPPL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GPCADBHKNGE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DBHMCKPJKEI, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KFOHJBADCBO, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? POCDJEOGOPC, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? CCAHBGGKLBF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HMAEICPICGJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KBLLAOEFDGG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DACPDLNOBEK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? PBENCPNNKOP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? EIGHFIACBCA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NGCBADEGOIE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? AHCHBKBKFEL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DLKIFKOODFF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HIKMGIJPFMH, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HEFIOLJBCBF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IOPEEMFKDLH, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? OKDKLBCJLJH, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? PKJOAOJABCD, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FJLEOMPIOIK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DNLLIKHHICJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FKJJPDHIIML, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JKBAPOBMFHL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GPJAIFNGKNP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? CKKPOCFICNG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GAAGGNBLAPE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GMKEDOGDOMA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? EGAFCDAMAIA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? ILOGEABKFHE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KGCNJAONLCG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? INCLBLJCLAC, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JKMDMAOBAOB, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? PCINAEAMGDL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? OEMIAAKLAGM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JDGHMFIOOOJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? IDHBDIANPHI, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KLGKILLBDJL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DOBMGOOKDPA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? MJAPMDBKBDP, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KKNKGGCAFIA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FABCLLCBKGF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GDBLOLJLJLE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? PPEGBPHKFEA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BOJDCFJCFMC, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HGKKAJGIFHG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? HCBLPCHBNAG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DPACHKGFAEN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NGAJAJCKPEA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FABKHBENGGN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? PMLPNDNEOMD, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? LKCLDGABHPD, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? EOIFCMANELM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GPMGBMPCFEI, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NFFJKKHFNGJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BPJBHDILMDM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? BOEJJIEPACK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KNLLCEEAONL, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? KMIEPHJGNCK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? MBLNCCDBMMA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? FOKCDILMONC, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? CDABOLNCFOK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? NADJPOOHMBA, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? AGAOEFKMMIN, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? ACJAFKJEAAJ, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? AMCEGIJFBEE, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DLBLHNNMNOK, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? JFFNAHDJAKM, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? GGJMOCGFHFG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? OAHLPCMNPPC, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? LLIMGGCDPEF, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? DIMHDKDKNAG, [Optional] OCIGPLHOEFI<TContext, TDeps, TCompileState>? PKCGFKBEEED) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x26F5100", Offset = "0x26F4500", VA = "0x1826F5100")]
	private static int KFKJCNIJMCO([In] DNPCPJMGLMI<byte> GKCLMOEIPKF, DNPCPJMGLMI<byte> BJFBLFCILOA, int KAHCMHKHPHM, int PCGLBCNIEAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ODJMKAHMPLK
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int EOHDGACMOMH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x388BB50", Offset = "0x388AF50", VA = "0x18388BB50")]
	public static JHLAGGIINPD<JAGIEGAIEJN<T>> OOEFKJJEBDE<T>([In] this DNPCPJMGLMI<byte> KBBJDOAJMAF)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x388B9C0", Offset = "0x388ADC0", VA = "0x18388B9C0")]
	public static JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<T>>> DCOALHNOCCF<T>(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<JAGIEGAIEJN<T>>? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26FAD70", Offset = "0x26FA170", VA = "0x1826FAD70")]
	public static JHLAGGIINPD<JAGIEGAIEJN<EOAOOBJMCIL>> MLDGLPGBIHA(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<EOAOOBJMCIL>? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<EOAOOBJMCIL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26FB110", Offset = "0x26FA510", VA = "0x1826FB110")]
	public static JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>> NLNKOFOOFKD(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] float? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x26FABA0", Offset = "0x26F9FA0", VA = "0x1826FABA0")]
	public static JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>> CAMJLPEAJNA(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26FB030", Offset = "0x26FA430", VA = "0x1826FB030")]
	public static JHLAGGIINPD<JAGIEGAIEJN<BCHEFFIGHHF>> NEAINEPKPMB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<BCHEFFIGHHF>? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<BCHEFFIGHHF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26FAF30", Offset = "0x26FA330", VA = "0x1826FAF30")]
	public static JHLAGGIINPD<JAGIEGAIEJN<AIOPOOGLOPK>> MNHBCPJCMBK(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] byte? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<AIOPOOGLOPK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26FAE50", Offset = "0x26FA250", VA = "0x1826FAE50")]
	public static JHLAGGIINPD<JAGIEGAIEJN<OFDLNEPEDGC>> MNBCGHNLCKD(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<OFDLNEPEDGC>? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<OFDLNEPEDGC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26FAC80", Offset = "0x26FA080", VA = "0x1826FAC80")]
	public static JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>> EKNHPCHOBPL(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] DKKNNGDAMAO? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x388BA90", Offset = "0x388AE90", VA = "0x18388BA90")]
	public static JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<T>>> MMPAAFPNGPD<T>(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<T>>? OOEMJLHLIHJ)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26F4F80", Offset = "0x26F4380", VA = "0x1826F4F80")]
	public static void OFDCOAEAJHO(this DNPCPJMGLMI<byte> KBBJDOAJMAF, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>> MOFACEGJLHG, int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x388BA80", Offset = "0x388AE80", VA = "0x18388BA80")]
	public static void HAEKBEIHMIA<T>(this DNPCPJMGLMI<byte> KBBJDOAJMAF, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<T>>> DFNNHOHBCCA, JHLAGGIINPD<JAGIEGAIEJN<T>> OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x388BA80", Offset = "0x388AE80", VA = "0x18388BA80")]
	public static void MAJBDHPEDOG<T>(this DNPCPJMGLMI<byte> KBBJDOAJMAF, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<T>>> MCHDENKICDC, JHLAGGIINPD<HCIGEGLFLDP<T>> OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AHHJKBCAHJF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26F4FC0", Offset = "0x26F43C0", VA = "0x1826F4FC0")]
	public static OOIBJIIIKPM COGLNIABDCA([In] this ReadOnlySpan<byte> FLIFCMNPFIN, int DAKGFMMPBKB)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26F5030", Offset = "0x26F4430", VA = "0x1826F5030")]
	public static OOIBJIIIKPM COGLNIABDCA([In] this DNPCPJMGLMI<byte> FLIFCMNPFIN, int DAKGFMMPBKB)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A320", Offset = "0x3E59720", VA = "0x183E5A320")]
	public static OOIBJIIIKPM COGLNIABDCA<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A030", Offset = "0x3E59430", VA = "0x183E5A030")]
	public static OOIBJIIIKPM COGLNIABDCA<M>([In] this NGBBKGEHELO<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A2C0", Offset = "0x3E596C0", VA = "0x183E5A2C0")]
	public static OOIBJIIIKPM COGLNIABDCA<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A250", Offset = "0x3E59650", VA = "0x183E5A250")]
	public static OOIBJIIIKPM COGLNIABDCA<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A190", Offset = "0x3E59590", VA = "0x183E5A190")]
	public static OOIBJIIIKPM COGLNIABDCA<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x26F4FC0", Offset = "0x26F43C0", VA = "0x1826F4FC0")]
	public static int FJMOPENKHBN([In] this ReadOnlySpan<byte> FLIFCMNPFIN, int DAKGFMMPBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26F4EB0", Offset = "0x26F42B0", VA = "0x1826F4EB0")]
	public static int FJMOPENKHBN([In] this DNPCPJMGLMI<byte> FLIFCMNPFIN, int DAKGFMMPBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3798350", Offset = "0x3797750", VA = "0x183798350")]
	public static int FJMOPENKHBN<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3798350", Offset = "0x3797750", VA = "0x183798350")]
	public static int FJMOPENKHBN<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3798350", Offset = "0x3797750", VA = "0x183798350")]
	public static int FJMOPENKHBN<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3798350", Offset = "0x3797750", VA = "0x183798350")]
	public static int FJMOPENKHBN<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A780", Offset = "0x3E59B80", VA = "0x183E5A780")]
	public static float JHPJNIJNANG<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A780", Offset = "0x3E59B80", VA = "0x183E5A780")]
	public static float JHPJNIJNANG<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A780", Offset = "0x3E59B80", VA = "0x183E5A780")]
	public static float JHPJNIJNANG<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A7C0", Offset = "0x3E59BC0", VA = "0x183E5A7C0")]
	public static byte PKPNJGGIFAB<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A8B0", Offset = "0x3E59CB0", VA = "0x183E5A8B0")]
	public static byte PKPNJGGIFAB<M>([In] this NGBBKGEHELO<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A2C0", Offset = "0x3E596C0", VA = "0x183E5A2C0")]
	public static byte PKPNJGGIFAB<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A250", Offset = "0x3E59650", VA = "0x183E5A250")]
	public static byte PKPNJGGIFAB<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A7F0", Offset = "0x3E59BF0", VA = "0x183E5A7F0")]
	public static byte PKPNJGGIFAB<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x26F4EB0", Offset = "0x26F42B0", VA = "0x1826F4EB0")]
	public static DKKNNGDAMAO BJEJEJNBMDM([In] this DNPCPJMGLMI<byte> FLIFCMNPFIN, int DAKGFMMPBKB)
	{
		return default(DKKNNGDAMAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3798350", Offset = "0x3797750", VA = "0x183798350")]
	public static DKKNNGDAMAO BJEJEJNBMDM<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(DKKNNGDAMAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A630", Offset = "0x3E59A30", VA = "0x183E5A630")]
	public static JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>> GOBCKOINHKE<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A5C0", Offset = "0x3E599C0", VA = "0x183E5A5C0")]
	public static JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>> GOBCKOINHKE<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A6A0", Offset = "0x3E59AA0", VA = "0x183E5A6A0")]
	public static JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>> GOBCKOINHKE<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E59FC0", Offset = "0x3E593C0", VA = "0x183E59FC0")]
	public static JHLAGGIINPD<HCIGEGLFLDP<OKCCELCEGCH>> CILMHALKJLI<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<HCIGEGLFLDP<OKCCELCEGCH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A470", Offset = "0x3E59870", VA = "0x183E5A470")]
	public static JHLAGGIINPD<OFDLNEPEDGC> FEKPOLCKCOJ<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<OFDLNEPEDGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A550", Offset = "0x3E59950", VA = "0x183E5A550")]
	public static JHLAGGIINPD<OFDLNEPEDGC> FEKPOLCKCOJ<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<OFDLNEPEDGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A4E0", Offset = "0x3E598E0", VA = "0x183E5A4E0")]
	public static JHLAGGIINPD<OFDLNEPEDGC> FEKPOLCKCOJ<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<OFDLNEPEDGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E59EE0", Offset = "0x3E592E0", VA = "0x183E59EE0")]
	public static JHLAGGIINPD<EOAOOBJMCIL> CDABINBEIFC<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<EOAOOBJMCIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E59F50", Offset = "0x3E59350", VA = "0x183E59F50")]
	public static JHLAGGIINPD<EOAOOBJMCIL> CDABINBEIFC<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<EOAOOBJMCIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A710", Offset = "0x3E59B10", VA = "0x183E5A710")]
	public static JHLAGGIINPD<BCHEFFIGHHF> HALBJHLENNN<M>(this OCNKOJALFOI<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB)
	{
		return default(JHLAGGIINPD<BCHEFFIGHHF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OEAMKGJOPEP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26FB240", Offset = "0x26FA640", VA = "0x1826FB240")]
	public static void FEKFCKMCAFA(this DNPCPJMGLMI<byte> FLIFCMNPFIN, int DAKGFMMPBKB, OOIBJIIIKPM OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x26FB300", Offset = "0x26FA700", VA = "0x1826FB300")]
	public static void FEKFCKMCAFA(this byte[] FLIFCMNPFIN, int DAKGFMMPBKB, OOIBJIIIKPM OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x26FB370", Offset = "0x26FA770", VA = "0x1826FB370")]
	public static void FEKFCKMCAFA([In] this Span<byte> FLIFCMNPFIN, int DAKGFMMPBKB, OOIBJIIIKPM OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x388C560", Offset = "0x388B960", VA = "0x18388C560")]
	public static void FEKFCKMCAFA<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, OOIBJIIIKPM OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x388C700", Offset = "0x388BB00", VA = "0x18388C700")]
	public static void FEKFCKMCAFA<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, OOIBJIIIKPM OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26F4F80", Offset = "0x26F4380", VA = "0x1826F4F80")]
	public static void OFDCOAEAJHO(this DNPCPJMGLMI<byte> FLIFCMNPFIN, int DAKGFMMPBKB, int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x26FB520", Offset = "0x26FA920", VA = "0x1826FB520")]
	public static void OFDCOAEAJHO(this byte[] FLIFCMNPFIN, int DAKGFMMPBKB, int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26FB4A0", Offset = "0x26FA8A0", VA = "0x1826FB4A0")]
	public static void OFDCOAEAJHO([In] this Span<byte> FLIFCMNPFIN, int DAKGFMMPBKB, int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x388CA00", Offset = "0x388BE00", VA = "0x18388CA00")]
	public static void OFDCOAEAJHO<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x388CA60", Offset = "0x388BE60", VA = "0x18388CA60")]
	public static void OFDCOAEAJHO<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, int OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26FB460", Offset = "0x26FA860", VA = "0x1826FB460")]
	public static void NGBFEAJPMNL(this DNPCPJMGLMI<byte> FLIFCMNPFIN, int DAKGFMMPBKB, float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x388C9A0", Offset = "0x388BDA0", VA = "0x18388C9A0")]
	public static void NGBFEAJPMNL<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x388C940", Offset = "0x388BD40", VA = "0x18388C940")]
	public static void NGBFEAJPMNL<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x26FB3F0", Offset = "0x26FA7F0", VA = "0x1826FB3F0")]
	public static void FFAFLKEHHAE(this DNPCPJMGLMI<byte> FLIFCMNPFIN, int DAKGFMMPBKB, byte OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x388C8F0", Offset = "0x388BCF0", VA = "0x18388C8F0")]
	public static void FFAFLKEHHAE<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, byte OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x388C8A0", Offset = "0x388BCA0", VA = "0x18388C8A0")]
	public static void FFAFLKEHHAE<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, byte OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3798320", Offset = "0x3797720", VA = "0x183798320")]
	public static void HAEKBEIHMIA<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>> OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3798320", Offset = "0x3797720", VA = "0x183798320")]
	public static void HAEKBEIHMIA<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, JHLAGGIINPD<JAGIEGAIEJN<OKCCELCEGCH>> OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3798320", Offset = "0x3797720", VA = "0x183798320")]
	public static void OGHECMDFLFC<M>(this JGMACDACEPK<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, JHLAGGIINPD<OFDLNEPEDGC> OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3798320", Offset = "0x3797720", VA = "0x183798320")]
	public static void OGHECMDFLFC<M>([In] this GLFCLOBFEKL<M, byte> FLIFCMNPFIN, JHLAGGIINPD<M> DAKGFMMPBKB, JHLAGGIINPD<OFDLNEPEDGC> OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MICEJCJNLFK
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x26F8090", Offset = "0x26F7490", VA = "0x1826F8090")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) IDAEGDKCBPM(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26FA740", Offset = "0x26F9B40", VA = "0x1826FA740")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) PGJDBLCIPFN(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26FA230", Offset = "0x26F9630", VA = "0x1826FA230")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) ONLICEMFBLM(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26F7B50", Offset = "0x26F6F50", VA = "0x1826F7B50")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) HCHGKHBDDOB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26F6660", Offset = "0x26F5A60", VA = "0x1826F6660")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) COLIGHFKHII(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26F8D00", Offset = "0x26F8100", VA = "0x1826F8D00")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) KOENDBHFILC(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26F9340", Offset = "0x26F8740", VA = "0x1826F9340")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) MIJBKFEFFCP(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26F63C0", Offset = "0x26F57C0", VA = "0x1826F63C0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) CKDMKKEDEFE(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26F7320", Offset = "0x26F6720", VA = "0x1826F7320")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) GFODJLFIBJD(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26F6E00", Offset = "0x26F6200", VA = "0x1826F6E00")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>) FEEPNIDMFBI(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? OOEMJLHLIHJ, [Optional] JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>? HFCCNFKNFFK)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26F7A30", Offset = "0x26F6E30", VA = "0x1826F7A30")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>) HAAJNEPGPDP(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? OOEMJLHLIHJ, [Optional] JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>? HFCCNFKNFFK)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26F9D00", Offset = "0x26F9100", VA = "0x1826F9D00")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>) OEKIMHJMFBM(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? OOEMJLHLIHJ, [Optional] JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>? HFCCNFKNFFK)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26F96F0", Offset = "0x26F8AF0", VA = "0x1826F96F0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>) NAONJBHKDFB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? OOEMJLHLIHJ, [Optional] JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>? HFCCNFKNFFK)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26F7180", Offset = "0x26F6580", VA = "0x1826F7180")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<EOAOOBJMCIL>>) GFJNFLPHBBP(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? BMFAGEIFJFH, [Optional] JHLAGGIINPD<EOAOOBJMCIL>? JMBBGOMJFAG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<EOAOOBJMCIL>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x26FAA10", Offset = "0x26F9E10", VA = "0x1826FAA10")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<EOAOOBJMCIL>>>) PJGLKAEFPDK(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? BMFAGEIFJFH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<EOAOOBJMCIL>>? JMBBGOMJFAG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<EOAOOBJMCIL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x26F5BA0", Offset = "0x26F4FA0", VA = "0x1826F5BA0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<OFDLNEPEDGC>>) BFGEHNCNGMD(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? BMFAGEIFJFH, [Optional] JHLAGGIINPD<OFDLNEPEDGC>? JMBBGOMJFAG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<OFDLNEPEDGC>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26F6930", Offset = "0x26F5D30", VA = "0x1826F6930")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<OFDLNEPEDGC>>>) DFKEJPGFICG(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? BMFAGEIFJFH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<OFDLNEPEDGC>>? JMBBGOMJFAG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<OFDLNEPEDGC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37C6A90", Offset = "0x37C5E90", VA = "0x1837C6A90")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BCHEFFIGHHF>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<TMarker>>) OJMAHFMFEGN<TMarker>(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<BCHEFFIGHHF>? JMBBGOMJFAG, [Optional][In] ReadOnlySpan<byte> AOFGGGKINCN)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BCHEFFIGHHF>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26FA4B0", Offset = "0x26F98B0", VA = "0x1826FA4B0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) OPEKNFBDBGG(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int GKCLMOEIPKF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? BJFBLFCILOA)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x26F6BA0", Offset = "0x26F5FA0", VA = "0x1826F6BA0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) ECJPAPJLLGL(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? GKCLMOEIPKF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? BJFBLFCILOA)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x37C68A0", Offset = "0x37C5CA0", VA = "0x1837C68A0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<TMarker>>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<TMarker>>) NMKJFAPPJEG<TMarker>(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<TMarker>>? BJFBLFCILOA, [Optional] int? LLBNOFGPNDN, [Optional][In] ReadOnlySpan<byte> GKCLMOEIPKF)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<TMarker>>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x37C6750", Offset = "0x37C5B50", VA = "0x1837C6750")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<TMarker>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<TMarker>>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>) FAJAAMMCBMC<TMarker>(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<TMarker>>? GKCLMOEIPKF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<TMarker>>? BJFBLFCILOA, [Optional] int? LLBNOFGPNDN)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<TMarker>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<TMarker>>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26F87A0", Offset = "0x26F7BA0", VA = "0x1826F87A0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) JBGMOFPNBCH(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26F6F10", Offset = "0x26F6310", VA = "0x1826F6F10")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) FIHOMGJPFHJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26F7440", Offset = "0x26F6840", VA = "0x1826F7440")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) GHCIEPNKEJP(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26F84E0", Offset = "0x26F78E0", VA = "0x1826F84E0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) INNCKHPINGB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26F5D40", Offset = "0x26F5140", VA = "0x1826F5D40")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) BFMLNIDCIFI(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26F9BE0", Offset = "0x26F8FE0", VA = "0x1826F9BE0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) OAJGIIDFDBE(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26F5A40", Offset = "0x26F4E40", VA = "0x1826F5A40")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) BDPFDIELBCM(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26F6110", Offset = "0x26F5510", VA = "0x1826F6110")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) CKAIAFJDFBJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26F57F0", Offset = "0x26F4BF0", VA = "0x1826F57F0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) ANODHINCEEM(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26F94A0", Offset = "0x26F88A0", VA = "0x1826F94A0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>) MNNDEEDBMEG(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>? DEGAGCJBDCI)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<JAGIEGAIEJN<HHIPAMAGICL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x26FA890", Offset = "0x26F9C90", VA = "0x1826FA890")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) PHOEELPLJEB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x26F52C0", Offset = "0x26F46C0", VA = "0x1826F52C0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) AHJAOOAKLPB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x26F5910", Offset = "0x26F4D10", VA = "0x1826F5910")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) APLPOCPGLJF(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26F6A40", Offset = "0x26F5E40", VA = "0x1826F6A40")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) DIGFFNJKJBJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26F6CB0", Offset = "0x26F60B0", VA = "0x1826F6CB0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) EMBCMGBNANC(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26F7670", Offset = "0x26F6A70", VA = "0x1826F7670")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) GNAMBAKNFIH(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26F91C0", Offset = "0x26F85C0", VA = "0x1826F91C0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) MCCFABPNDJB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26FA5E0", Offset = "0x26F99E0", VA = "0x1826FA5E0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) PGCGDDLKAMJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26F5FE0", Offset = "0x26F53E0", VA = "0x1826F5FE0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) CIECHGACDHJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26F9590", Offset = "0x26F8990", VA = "0x1826F9590")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) MOGCALLMNDK(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26F9F90", Offset = "0x26F9390", VA = "0x1826F9F90")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) OIOBHKOIJCD(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26F7060", Offset = "0x26F6460", VA = "0x1826F7060")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) FOPDGHMNPJB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26F9E10", Offset = "0x26F9210", VA = "0x1826F9E10")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) OFNCMKNOLIO(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x26F9A80", Offset = "0x26F8E80", VA = "0x1826F9A80")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) NOOMEIIBOKB(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26F8E20", Offset = "0x26F8220", VA = "0x1826F8E20")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) LEIJNDBKJAG(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x26F8640", Offset = "0x26F7A40", VA = "0x1826F8640")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) INODHOIJCGL(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x26F56A0", Offset = "0x26F4AA0", VA = "0x1826F56A0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) ALCDMLKDIDK(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26F51A0", Offset = "0x26F45A0", VA = "0x1826F51A0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) AGIDKOIBNLE(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26F8210", Offset = "0x26F7610", VA = "0x1826F8210")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) IFOCKPOPBAK(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26F8A40", Offset = "0x26F7E40", VA = "0x1826F8A40")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) JGHJJNAFEIJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x26F7DD0", Offset = "0x26F71D0", VA = "0x1826F7DD0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) HIFKHPCCOOG(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26FA350", Offset = "0x26F9750", VA = "0x1826FA350")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) ONOOGNHBOLH(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26F6510", Offset = "0x26F5910", VA = "0x1826F6510")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) CLAOBEBOMGP(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26F5580", Offset = "0x26F4980", VA = "0x1826F5580")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) AJPICLPPGLJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26F67B0", Offset = "0x26F5BB0", VA = "0x1826F67B0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) DEHIBFNCGNG(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26F9070", Offset = "0x26F8470", VA = "0x1826F9070")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) LPJAIFCJOJF(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26F8920", Offset = "0x26F7D20", VA = "0x1826F8920")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) JCCCMENFJEA(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26F5420", Offset = "0x26F4820", VA = "0x1826F5420")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) AIMFBGFPFED(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x26F5E90", Offset = "0x26F5290", VA = "0x1826F5E90")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) CFCODEPFIFJ(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x26F7CB0", Offset = "0x26F70B0", VA = "0x1826F7CB0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) HCHNGLHDEHG(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26F7560", Offset = "0x26F6960", VA = "0x1826F7560")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) GHPPIKGCAAA(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] int? BNDPOCLJCJL, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x26F7F00", Offset = "0x26F7300", VA = "0x1826F7F00")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) HNFNLBJEIGA(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? BNDPOCLJCJL, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26F8010", Offset = "0x26F7410", VA = "0x1826F8010")]
	public static JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>> IBBMKOPCMHG(this DNPCPJMGLMI<byte> KBBJDOAJMAF)
	{
		return default(JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26F78B0", Offset = "0x26F6CB0", VA = "0x1826F78B0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) GOOIHCFNLCA(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, float PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26F8390", Offset = "0x26F7790", VA = "0x1826F8390")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) IHOOKMFMNCF(this DNPCPJMGLMI<byte> KBBJDOAJMAF, float LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<BKHBAHEIAML>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x26F8F50", Offset = "0x26F8350", VA = "0x1826F8F50")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>) LMDKBGNMKKC(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<BKHBAHEIAML>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<BKHBAHEIAML>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x26F6260", Offset = "0x26F5660", VA = "0x1826F6260")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) CKBMBDOAAAN(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x26FA0E0", Offset = "0x26F94E0", VA = "0x1826FA0E0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) OLEFLEHDAEE(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x26F9810", Offset = "0x26F8C10", VA = "0x1826F9810")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) NBPCLKPIAAF(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26F8BA0", Offset = "0x26F7FA0", VA = "0x1826F8BA0")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) KHFNIJGNPNA(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, int PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26F9930", Offset = "0x26F8D30", VA = "0x1826F9930")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) NLGPHODAHGF(this DNPCPJMGLMI<byte> KBBJDOAJMAF, int LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<AFKMBOJOOJE>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26F7790", Offset = "0x26F6B90", VA = "0x1826F7790")]
	public static (JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>) GNEJJJGDFBP(this DNPCPJMGLMI<byte> KBBJDOAJMAF, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? LPOMAPNGMBH, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? PHIIMKBNFPK, [Optional] JHLAGGIINPD<HCIGEGLFLDP<AFKMBOJOOJE>>? MCDKGMJMEJG)
	{
		return default((JHLAGGIINPD<JAGIEGAIEJN<HHIPAMAGICL>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>, JHLAGGIINPD<JAGIEGAIEJN<HCIGEGLFLDP<AFKMBOJOOJE>>>));
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
