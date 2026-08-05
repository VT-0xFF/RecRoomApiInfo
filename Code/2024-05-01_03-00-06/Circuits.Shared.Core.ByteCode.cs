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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E2AAF0", Offset = "0x1E298F0", VA = "0x181E2AAF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CNEJDJDOPJO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x269FAE0", Offset = "0x269E8E0", VA = "0x18269FAE0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<M>> ODFAOEEOHKD<M>(this int ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<M>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E247D0", Offset = "0x1E235D0", VA = "0x181E247D0")]
	public static FCLFMGJFDHI<JNJEBJHPFKK> EJAIPOJFPOF(this int ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<JNJEBJHPFKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x269FAE0", Offset = "0x269E8E0", VA = "0x18269FAE0")]
	public static FCLFMGJFDHI<NBCPCEFHAEB<M>> EBKAMMLAKGJ<M>(this int ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<NBCPCEFHAEB<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BBGNJJIAHOD<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PKIMBAADPGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MCGEGMFELIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class JNJEBJHPFKK
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NMPFACAPKKC
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class AIPIHCFKDGL
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BDOHGDIBECI
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
public static class PEBGJCMEHDN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct ENIFPBNGEKE<TContext, TDeps, TCompileState>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IntPtr HIBKNIHOKEI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
		public ENIFPBNGEKE(IntPtr LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x34C3760", Offset = "0x34C2560", VA = "0x1834C3760")]
		public int HEPNPPEJLJB(TDeps GLJEJHKFIBB, TContext LGCLICFOKFI, TCompileState CEJCCNJMOCF, [In] NGFOIHIBELM<byte> NNGJECDGPGA, int ALLHDEFACBC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D8A0", Offset = "0x2A4C6A0", VA = "0x182A4D8A0")]
	public static void KOCCAAHAMFF<TDeps, TContext, TCompileState>(TDeps GLJEJHKFIBB, TContext LGCLICFOKFI, TCompileState CEJCCNJMOCF, [In] NGFOIHIBELM<byte> DHLDHPEINJD, NGFOIHIBELM<byte> EMJOMCACEFN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KNABOKPNDLA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LDJPMHFOIOF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? PEJAIFMGIJC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? OOHGLHDJKMG, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FCCGHDMDFJN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JIOKMJGOPOC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? PHNNAEHEPPJ, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? MHFPFPOPDLG, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LDIMLLCPOLB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JFFNIBGHFCI, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? POCAGLJIILI, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KEIFDFDHHNJ, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? ANIABIGCOGP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CGNOMPLIMEP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GMMBCGKIJHE, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LMEDIDEMBFF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? IGLAKMFFLKA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BIKAINCMMCL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JLAAAEKIONF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BMIIODEFNDA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HBLANOIKHNP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? NAFPBKIOCLJ, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? AMMEPKCDPMP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? IACELKMBCLF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KJDHBJFAKMK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? OGBPDJJIPPB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? MCKNBEOLEJC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? DPJJFIFLBEM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JOHAFOFPPDN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? NPAENJPKEHB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KADFIDJIDKK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FMBECNJBDKM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? OBEFCNAKEEA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CHPFJGEGEJO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FEAGIIHENPN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HJCJMKEMFOC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? NBEMHALJCFL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CJJMDABLLCC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? COIPELCJIEJ, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? POBBDDIKDOH, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? OHMDMMBNEBM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? EGCBMOCCHDP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? DHCNJLNLPJB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? ABKOFHBCOJM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FFIFEMAHAID, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? EJPNLJOINIM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BHDFLIDDIAE, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FKGCOOEKPHO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CANKLMDPALD, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? EOEKMHIAIHB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LIDPPKMOEHA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KJIFHMMIKDK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? MLNDCNDLPCH, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HHDFNHEGEMN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? EBFGAJLPDCN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? AGBFGPELFBG, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? AADJFFLKBGK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? OGFLMEHPJHC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? OIFHHJNDMII, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LMIGBLDBHBF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BPKMFJELMCM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BLGBFFCKEKO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BCFHAHMFPOF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HPBHNJNGAKA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GHBHMNFCGHC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CFENLCPNEKJ, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? DOCMBNGEDFO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? AKNBOEBJOHM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GEIAEIPLACK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? AKIJEGNMJHH, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LHGMPLAGJIE, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JLBBGHMIDAE, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? PCLLLKHAAFL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? IOKDDEHJDFB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GOBJHKODAEG, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KGALGMDNKHO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KBDLGJEBOGJ, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? NACKJOKDMMK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GHCKFHNIJLL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GFEICNFEDBD, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HDOPHNHADKH, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KKOGJDFNKEC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HNPHBPMKHHB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JIMPKMMCBIC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HKFOANGDGGL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GCGJILOEOBO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? PPFLLPIKKID, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? EHEDNGJJJBL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? MIGPPFCKAHO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LAPAGEBLFHB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? DLHEMJLDBFH, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GMLACAGIGMD, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GBFFCCIPPPJ, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CFDCBEOHDAE, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CEDOMDOPHIO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GFEJGEKECCK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? MPEBCFIFFGN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KLGKOKCKAHL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? ALDANPOLFLK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BEBCINEFFMA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HNMBKKGEPBI, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HPGABCCBLJF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BGHBDBNLGEN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? PMPIIGOFEHH, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JCKNJKKKBEC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BJGAEFDHDKP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BKFBBDEGCLB, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? KPHNAOINOFA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? DPKPPHCJAAN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? IEDOFCAPFKO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? CJPJBHJPFDG, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FLBCJHHAANE, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? PCOLFGMIFOF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FAJEEJPLAFM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JMADHNHFDAI, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? BHIMAMCLNFK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? NDHMEGEDPLA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? DKKKNBDOICM, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? NGMFIENDBJF, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? FBAPBFFBGIO, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GNJNMLDMICG, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GMNDKKHFKAD, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? JKIHHAEACNL, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? ELLOCDHMHID, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? NGDIMMNCLNA, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HLGHIJINLBI, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? ABKJFCPJJGP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? LGIOKLFKKKG, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? OMGDHICMOFC, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? ADNKJINFNOP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? MJKFNPHNHBP, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? MLMKAMCJBOI, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? GDFINPEMPIN, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? HDLJDMEBKNK, [Optional] ENIFPBNGEKE<TContext, TDeps, TCompileState>? IOKHHAPCAKL) where TDeps : notnull where TContext : notnull where TCompileState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AB70", Offset = "0x1E29970", VA = "0x181E2AB70")]
	private static int PIFOFJMHMAG([In] NGFOIHIBELM<byte> FEAFHENKEAJ, NGFOIHIBELM<byte> CALLEFILHJM, int GJACDHHHCDB, int NJKDAMEBDBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LEKBIHOPDCA
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly int INPAIMCBCIE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x295E090", Offset = "0x295CE90", VA = "0x18295E090")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<T>> PHBAAOLEJDM<T>([In] this NGFOIHIBELM<byte> ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<T>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x295DFC0", Offset = "0x295CDC0", VA = "0x18295DFC0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<T>>> HPKIOBECIEL<T>(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<BBGNJJIAHOD<T>>? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E25060", Offset = "0x1E23E60", VA = "0x181E25060")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<HHDPBMHOJPK>> NKJFDGCADCC(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<HHDPBMHOJPK>? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<HHDPBMHOJPK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E24B60", Offset = "0x1E23960", VA = "0x181E24B60")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>> BBBGLEGPDOO(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] float? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E24C30", Offset = "0x1E23A30", VA = "0x181E24C30")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>> BNDJEGJIADF(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E24EA0", Offset = "0x1E23CA0", VA = "0x181E24EA0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<EKPIIADOODM>> GBDIHOBIACN(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<EKPIIADOODM>? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<EKPIIADOODM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E24F70", Offset = "0x1E23D70", VA = "0x181E24F70")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<AIPIHCFKDGL>> IEPOJFICPIK(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] byte? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<AIPIHCFKDGL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E24DD0", Offset = "0x1E23BD0", VA = "0x181E24DD0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<JNJEBJHPFKK>> DOBOLPHPDMI(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<JNJEBJHPFKK>? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<JNJEBJHPFKK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E24D00", Offset = "0x1E23B00", VA = "0x181E24D00")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> DKKOJBNNAHJ(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] BDOHGDIBECI? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x295DF00", Offset = "0x295CD00", VA = "0x18295DF00")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<T>>> DMJBJFEIDHK<T>(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<T>>? DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<T>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E246E0", Offset = "0x1E234E0", VA = "0x181E246E0")]
	public static void NANFNBIOIFC(this NGFOIHIBELM<byte> ILACEKALGJH, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>> IAMCEGAGEHI, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x295E080", Offset = "0x295CE80", VA = "0x18295E080")]
	public static void JLLLHAEJFOL<T>(this NGFOIHIBELM<byte> ILACEKALGJH, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<T>>> ALLHDEFACBC, FCLFMGJFDHI<BBGNJJIAHOD<T>> DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x295E080", Offset = "0x295CE80", VA = "0x18295E080")]
	public static void KDOGMAKHJFL<T>(this NGFOIHIBELM<byte> ILACEKALGJH, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<T>>> NOIGFJEEIEK, FCLFMGJFDHI<NBCPCEFHAEB<T>> DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PMBCPIJOLCN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AC10", Offset = "0x1E29A10", VA = "0x181E2AC10")]
	public static CNLMJLLGIPI OMIIIPKGJIN([In] this ReadOnlySpan<byte> KKAMOMBNLOJ, int IMHFEJALMMA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AC80", Offset = "0x1E29A80", VA = "0x181E2AC80")]
	public static CNLMJLLGIPI OMIIIPKGJIN([In] this NGFOIHIBELM<byte> KKAMOMBNLOJ, int IMHFEJALMMA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2A57E40", Offset = "0x2A56C40", VA = "0x182A57E40")]
	public static CNLMJLLGIPI OMIIIPKGJIN<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2A57CC0", Offset = "0x2A56AC0", VA = "0x182A57CC0")]
	public static CNLMJLLGIPI OMIIIPKGJIN<M>([In] this ONCBGINPOLD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2A57BF0", Offset = "0x2A569F0", VA = "0x182A57BF0")]
	public static CNLMJLLGIPI OMIIIPKGJIN<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2A57B00", Offset = "0x2A56900", VA = "0x182A57B00")]
	public static CNLMJLLGIPI OMIIIPKGJIN<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2A57DD0", Offset = "0x2A56BD0", VA = "0x182A57DD0")]
	public static CNLMJLLGIPI OMIIIPKGJIN<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AC10", Offset = "0x1E29A10", VA = "0x181E2AC10")]
	public static int NBCJNEPHKGH([In] this ReadOnlySpan<byte> KKAMOMBNLOJ, int IMHFEJALMMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E24720", Offset = "0x1E23520", VA = "0x181E24720")]
	public static int NBCJNEPHKGH([In] this NGFOIHIBELM<byte> KKAMOMBNLOJ, int IMHFEJALMMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static int NBCJNEPHKGH<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static int NBCJNEPHKGH<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static int NBCJNEPHKGH<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static int NBCJNEPHKGH<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A57CA0", Offset = "0x2A56AA0", VA = "0x182A57CA0")]
	public static float NBFNECBHCDO<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A57CA0", Offset = "0x2A56AA0", VA = "0x182A57CA0")]
	public static float NBFNECBHCDO<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A57CA0", Offset = "0x2A56AA0", VA = "0x182A57CA0")]
	public static float NBFNECBHCDO<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A57AD0", Offset = "0x2A568D0", VA = "0x182A57AD0")]
	public static byte JBCKCEOJLLK<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A57BD0", Offset = "0x2A569D0", VA = "0x182A57BD0")]
	public static byte JBCKCEOJLLK<M>([In] this ONCBGINPOLD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A57BF0", Offset = "0x2A569F0", VA = "0x182A57BF0")]
	public static byte JBCKCEOJLLK<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A57B00", Offset = "0x2A56900", VA = "0x182A57B00")]
	public static byte JBCKCEOJLLK<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A57B60", Offset = "0x2A56960", VA = "0x182A57B60")]
	public static byte JBCKCEOJLLK<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E24720", Offset = "0x1E23520", VA = "0x181E24720")]
	public static BDOHGDIBECI FIHMBIDLPJN([In] this NGFOIHIBELM<byte> KKAMOMBNLOJ, int IMHFEJALMMA)
	{
		return default(BDOHGDIBECI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x269FF90", Offset = "0x269ED90", VA = "0x18269FF90")]
	public static BDOHGDIBECI FIHMBIDLPJN<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(BDOHGDIBECI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A578F0", Offset = "0x2A566F0", VA = "0x182A578F0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> FFCLCNNIKFD<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A57890", Offset = "0x2A56690", VA = "0x182A57890")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> FFCLCNNIKFD<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A57950", Offset = "0x2A56750", VA = "0x182A57950")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> FFCLCNNIKFD<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A57F50", Offset = "0x2A56D50", VA = "0x182A57F50")]
	public static FCLFMGJFDHI<NBCPCEFHAEB<INDJOPDPNLB>> PAOCAIKDGCM<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<NBCPCEFHAEB<INDJOPDPNLB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A579B0", Offset = "0x2A567B0", VA = "0x182A579B0")]
	public static FCLFMGJFDHI<JNJEBJHPFKK> HOMGOOGJMFH<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<JNJEBJHPFKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A57A10", Offset = "0x2A56810", VA = "0x182A57A10")]
	public static FCLFMGJFDHI<JNJEBJHPFKK> HOMGOOGJMFH<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<JNJEBJHPFKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A57A70", Offset = "0x2A56870", VA = "0x182A57A70")]
	public static FCLFMGJFDHI<JNJEBJHPFKK> HOMGOOGJMFH<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<JNJEBJHPFKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A577D0", Offset = "0x2A565D0", VA = "0x182A577D0")]
	public static FCLFMGJFDHI<HHDPBMHOJPK> FBGKIBOFNFC<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<HHDPBMHOJPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A57830", Offset = "0x2A56630", VA = "0x182A57830")]
	public static FCLFMGJFDHI<HHDPBMHOJPK> FBGKIBOFNFC<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<HHDPBMHOJPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A57C40", Offset = "0x2A56A40", VA = "0x182A57C40")]
	public static FCLFMGJFDHI<EKPIIADOODM> JEKAMCAMOFA<M>(this DCEBPAMIEJI<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA)
	{
		return default(FCLFMGJFDHI<EKPIIADOODM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IFJGNNNEJHK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E24840", Offset = "0x1E23640", VA = "0x181E24840")]
	public static void COHNODAGNEI(this NGFOIHIBELM<byte> KKAMOMBNLOJ, int IMHFEJALMMA, CNLMJLLGIPI DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E24900", Offset = "0x1E23700", VA = "0x181E24900")]
	public static void COHNODAGNEI(this byte[] KKAMOMBNLOJ, int IMHFEJALMMA, CNLMJLLGIPI DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E24970", Offset = "0x1E23770", VA = "0x181E24970")]
	public static void COHNODAGNEI([In] this Span<byte> KKAMOMBNLOJ, int IMHFEJALMMA, CNLMJLLGIPI DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2900A00", Offset = "0x28FF800", VA = "0x182900A00")]
	public static void COHNODAGNEI<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, CNLMJLLGIPI DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2900AF0", Offset = "0x28FF8F0", VA = "0x182900AF0")]
	public static void COHNODAGNEI<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, CNLMJLLGIPI DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E246E0", Offset = "0x1E234E0", VA = "0x181E246E0")]
	public static void NANFNBIOIFC(this NGFOIHIBELM<byte> KKAMOMBNLOJ, int IMHFEJALMMA, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1E24AE0", Offset = "0x1E238E0", VA = "0x181E24AE0")]
	public static void NANFNBIOIFC(this byte[] KKAMOMBNLOJ, int IMHFEJALMMA, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E24A60", Offset = "0x1E23860", VA = "0x181E24A60")]
	public static void NANFNBIOIFC([In] this Span<byte> KKAMOMBNLOJ, int IMHFEJALMMA, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2900C50", Offset = "0x28FFA50", VA = "0x182900C50")]
	public static void NANFNBIOIFC<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2900CA0", Offset = "0x28FFAA0", VA = "0x182900CA0")]
	public static void NANFNBIOIFC<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E24800", Offset = "0x1E23600", VA = "0x181E24800")]
	public static void BHLFGCGMPMA(this NGFOIHIBELM<byte> KKAMOMBNLOJ, int IMHFEJALMMA, float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2900960", Offset = "0x28FF760", VA = "0x182900960")]
	public static void BHLFGCGMPMA<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29009B0", Offset = "0x28FF7B0", VA = "0x1829009B0")]
	public static void BHLFGCGMPMA<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1E249F0", Offset = "0x1E237F0", VA = "0x181E249F0")]
	public static void FPDBJDFNCDD(this NGFOIHIBELM<byte> KKAMOMBNLOJ, int IMHFEJALMMA, byte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2900C20", Offset = "0x28FFA20", VA = "0x182900C20")]
	public static void FPDBJDFNCDD<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, byte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2900BF0", Offset = "0x28FF9F0", VA = "0x182900BF0")]
	public static void FPDBJDFNCDD<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, byte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2900BE0", Offset = "0x28FF9E0", VA = "0x182900BE0")]
	public static void JLLLHAEJFOL<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2900BE0", Offset = "0x28FF9E0", VA = "0x182900BE0")]
	public static void JLLLHAEJFOL<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2900BE0", Offset = "0x28FF9E0", VA = "0x182900BE0")]
	public static void CPAMDJDLDEE<M>(this NLPKJMHJNPH<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, FCLFMGJFDHI<JNJEBJHPFKK> DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2900BE0", Offset = "0x28FF9E0", VA = "0x182900BE0")]
	public static void CPAMDJDLDEE<M>([In] this MHGMEJPPHMD<M, byte> KKAMOMBNLOJ, FCLFMGJFDHI<M> IMHFEJALMMA, FCLFMGJFDHI<JNJEBJHPFKK> DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MFFBELGLCPC
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E27990", Offset = "0x1E26790", VA = "0x181E27990")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) GLHOLGCLGGF(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A9A0", Offset = "0x1E297A0", VA = "0x181E2A9A0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) PGENNACMCFJ(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1E28110", Offset = "0x1E26F10", VA = "0x181E28110")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) HHJKJBIMMGK(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E293B0", Offset = "0x1E281B0", VA = "0x181E293B0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) LLBJEEIPBBP(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E270D0", Offset = "0x1E25ED0", VA = "0x181E270D0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) FIKBKLDIGPD(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E26B70", Offset = "0x1E25970", VA = "0x181E26B70")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) ELDGDHLGMGL(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E28A80", Offset = "0x1E27880", VA = "0x181E28A80")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) JEDKCIEBLKH(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E27D10", Offset = "0x1E26B10", VA = "0x181E27D10")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) HAKAECFIADI(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E29140", Offset = "0x1E27F40", VA = "0x181E29140")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) LHEPCMILCFE(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E26560", Offset = "0x1E25360", VA = "0x181E26560")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>) DPHPEOOGEKF(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? DIBNBLEEFNN, [Optional] FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>? ALLCDDJIPKP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E26440", Offset = "0x1E25240", VA = "0x181E26440")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>) DGICDCBCOEM(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? DIBNBLEEFNN, [Optional] FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>? ALLCDDJIPKP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E25C10", Offset = "0x1E24A10", VA = "0x181E25C10")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>) CHOILDBFNCH(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? DIBNBLEEFNN, [Optional] FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>? ALLCDDJIPKP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E28230", Offset = "0x1E27030", VA = "0x181E28230")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>) HIHMMLGGHLP(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? DIBNBLEEFNN, [Optional] FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>? ALLCDDJIPKP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A190", Offset = "0x1E28F90", VA = "0x181E2A190")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<HHDPBMHOJPK>>) OMBPIMIAFAI(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? MPAAKMDJNGI, [Optional] FCLFMGJFDHI<HHDPBMHOJPK>? HAEHEOGNGAP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<HHDPBMHOJPK>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E27C00", Offset = "0x1E26A00", VA = "0x181E27C00")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<HHDPBMHOJPK>>>) HAHDBCADEKE(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? MPAAKMDJNGI, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<HHDPBMHOJPK>>? HAEHEOGNGAP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<HHDPBMHOJPK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E26F30", Offset = "0x1E25D30", VA = "0x181E26F30")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<JNJEBJHPFKK>>) FCNKHJFIOIN(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? MPAAKMDJNGI, [Optional] FCLFMGJFDHI<JNJEBJHPFKK>? HAEHEOGNGAP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<JNJEBJHPFKK>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E28720", Offset = "0x1E27520", VA = "0x181E28720")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<JNJEBJHPFKK>>>) ICDIFIPOIDH(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? MPAAKMDJNGI, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<JNJEBJHPFKK>>? HAEHEOGNGAP)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<JNJEBJHPFKK>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x297CCC0", Offset = "0x297BAC0", VA = "0x18297CCC0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<EKPIIADOODM>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<TMarker>>) MMOHHBMBEGF<TMarker>(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<EKPIIADOODM>? HAEHEOGNGAP, [Optional][In] ReadOnlySpan<byte> LHODDAGAJKC)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<EKPIIADOODM>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E28950", Offset = "0x1E27750", VA = "0x181E28950")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) JCBLIJJCNLC(this NGFOIHIBELM<byte> ILACEKALGJH, int FEAFHENKEAJ, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CALLEFILHJM)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E28350", Offset = "0x1E27150", VA = "0x181E28350")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) HKICCJCJOLD(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? FEAFHENKEAJ, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CALLEFILHJM)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x297CAE0", Offset = "0x297B8E0", VA = "0x18297CAE0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<TMarker>>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<TMarker>>) KODBIHEKGAE<TMarker>(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<TMarker>>? CALLEFILHJM, [Optional] int? CGDBKIJPKOF, [Optional][In] ReadOnlySpan<byte> FEAFHENKEAJ)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<TMarker>>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<TMarker>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x297C9C0", Offset = "0x297B7C0", VA = "0x18297C9C0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<TMarker>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<TMarker>>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>) AGEIKHDKEJL<TMarker>(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<TMarker>>? FEAFHENKEAJ, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<TMarker>>? CALLEFILHJM, [Optional] int? CGDBKIJPKOF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<TMarker>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<TMarker>>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1E253E0", Offset = "0x1E241E0", VA = "0x181E253E0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) BCOPKLEPIJK(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E25560", Offset = "0x1E24360", VA = "0x181E25560")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) BGFCIBCPDEB(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E29A10", Offset = "0x1E28810", VA = "0x181E29A10")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) NKIFJNHMEAN(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E267C0", Offset = "0x1E255C0", VA = "0x181E267C0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) EFLEBBJKCGN(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E26670", Offset = "0x1E25470", VA = "0x181E26670")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) EAPBMCNOMPP(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1E26200", Offset = "0x1E25000", VA = "0x181E26200")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) CPELPIPLCEB(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1E28D40", Offset = "0x1E27B40", VA = "0x181E28D40")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) KDPCFAMGMHO(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1E256B0", Offset = "0x1E244B0", VA = "0x181E256B0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) BMJIJMAJNIL(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A730", Offset = "0x1E29530", VA = "0x181E2A730")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) PDOAFPFMDBP(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E27B10", Offset = "0x1E26910", VA = "0x181E27B10")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>) GPGCAIEGCNK(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>? OJKJFPFODCM)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E27810", Offset = "0x1E26610", VA = "0x181E27810")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) GJGFLLMBMAG(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E27590", Offset = "0x1E26390", VA = "0x181E27590")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) GGBCAIKDOKO(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1E29660", Offset = "0x1E28460", VA = "0x181E29660")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) NALJHPEKOON(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A330", Offset = "0x1E29130", VA = "0x181E2A330")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) OOGAPFJKKOI(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A5E0", Offset = "0x1E293E0", VA = "0x181E2A5E0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) PCEILFDPBOE(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1E29DC0", Offset = "0x1E28BC0", VA = "0x181E29DC0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) NOPMFPKLJJL(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E25930", Offset = "0x1E24730", VA = "0x181E25930")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) CDBHDPIBCNM(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E28BE0", Offset = "0x1E279E0", VA = "0x181E28BE0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) JKEBJAKJHCB(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E25800", Offset = "0x1E24600", VA = "0x181E25800")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) BNOLEOMHMGE(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E260A0", Offset = "0x1E24EA0", VA = "0x181E260A0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) COONMFLPAKA(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1E25290", Offset = "0x1E24090", VA = "0x181E25290")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) AHIJAMKCGAD(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1E26320", Offset = "0x1E25120", VA = "0x181E26320")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) DENIBLFFLDB(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1E26DB0", Offset = "0x1E25BB0", VA = "0x181E26DB0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) ENDKOFKBADG(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1E25AB0", Offset = "0x1E248B0", VA = "0x181E25AB0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) CEHBOCMCPGA(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1E26A40", Offset = "0x1E25840", VA = "0x181E26A40")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) EHFNDKIPKDG(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1E27FB0", Offset = "0x1E26DB0", VA = "0x181E27FB0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) HFAOLGNIBBK(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1E29EE0", Offset = "0x1E28CE0", VA = "0x181E29EE0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) OEDBJEHEGAA(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1E26920", Offset = "0x1E25720", VA = "0x181E26920")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) EHAHBIADONE(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E28FC0", Offset = "0x1E27DC0", VA = "0x181E28FC0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) LGPCHBGDEPH(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E298B0", Offset = "0x1E286B0", VA = "0x181E298B0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) NJJJFJLODNA(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E29B30", Offset = "0x1E28930", VA = "0x181E29B30")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) NMIFFJNJAAF(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E29C60", Offset = "0x1E28A60", VA = "0x181E29C60")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) NOEDGCLKLHP(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E29260", Offset = "0x1E28060", VA = "0x181E29260")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) LIBAMEDMNGF(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1E25170", Offset = "0x1E23F70", VA = "0x181E25170")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) AHGMFHBEACN(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1E25DA0", Offset = "0x1E24BA0", VA = "0x181E25DA0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) CKCPAPGKBOB(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A850", Offset = "0x1E29650", VA = "0x181E2A850")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) PFJCKCGGABA(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1E29790", Offset = "0x1E28590", VA = "0x181E29790")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) NJAHFEJMGFA(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A030", Offset = "0x1E28E30", VA = "0x181E2A030")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) OHGAKPLFMKL(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1E27E60", Offset = "0x1E26C60", VA = "0x181E27E60")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) HEJBAAKMIMK(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1E28EA0", Offset = "0x1E27CA0", VA = "0x181E28EA0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) KJNKIGOEAII(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1E27480", Offset = "0x1E26280", VA = "0x181E27480")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) GFCOFELLFCJ(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] int? KDPEBFOFJEJ, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1E27220", Offset = "0x1E26020", VA = "0x181E27220")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) FJJNPFOMFAL(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? KDPEBFOFJEJ, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1E25D20", Offset = "0x1E24B20", VA = "0x181E25D20")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> CJFAECLGIBG(this NGFOIHIBELM<byte> ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1E25F20", Offset = "0x1E24D20", VA = "0x181E25F20")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) CLKHLGCCDFO(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1E29510", Offset = "0x1E28310", VA = "0x181E29510")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) MBPJNBNAENM(this NGFOIHIBELM<byte> ILACEKALGJH, float ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<PKIMBAADPGL>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1E28830", Offset = "0x1E27630", VA = "0x181E28830")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>) ICHAGDPPCEN(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<PKIMBAADPGL>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<PKIMBAADPGL>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1E285C0", Offset = "0x1E273C0", VA = "0x181E285C0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) IACPDIBLDFK(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A490", Offset = "0x1E29290", VA = "0x181E2A490")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) PBMJJPDHFLB(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1E276F0", Offset = "0x1E264F0", VA = "0x181E276F0")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) GIOHMMBHOGI(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1E28460", Offset = "0x1E27260", VA = "0x181E28460")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) HPCEJIDOEGC(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1E27330", Offset = "0x1E26130", VA = "0x181E27330")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) GBNCPBMMKJO(this NGFOIHIBELM<byte> ILACEKALGJH, int ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1E26C90", Offset = "0x1E25A90", VA = "0x181E26C90")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>) ELMLLMGPDHC(this NGFOIHIBELM<byte> ILACEKALGJH, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? ENBPDIJHKJG, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? CFFNBDCKFPB, [Optional] FCLFMGJFDHI<NBCPCEFHAEB<MCGEGMFELIF>>? NJIFPADKBNF)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<MCGEGMFELIF>>>));
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
