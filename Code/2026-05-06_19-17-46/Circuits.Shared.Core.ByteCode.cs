using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B72920", Offset = "0x2B71320", VA = "0x182B72920")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class YANHZHOKSRP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x41245B0", Offset = "0x4122FB0", VA = "0x1841245B0")]
		public static Id32<GAIDVDAKGEP<a>> YYDIPXDRFYV<a>(this int a)
		{
			return default(Id32<GAIDVDAKGEP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B78340", Offset = "0x2B76D40", VA = "0x182B78340")]
		public static Id32<BHDVXGKWBTW> FGSUEEQVGFA(this int a)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x41245B0", Offset = "0x4122FB0", VA = "0x1841245B0")]
		public static Id32<WHMLTPZNLLH<b>> VVBTJWXNTOX<b>(this int a)
		{
			return default(Id32<WHMLTPZNLLH<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class GAIDVDAKGEP<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class WJTJAHYOHYU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class KEENRFCLFXX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BHDVXGKWBTW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class JWUJAMRKFPU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class YFTZEIZNQPO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum Op
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
}
namespace Circuits.Shared.Core.ByteCode.IO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class GSOQWKTGQBB
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x76B7D10", Offset = "0x76B6710", VA = "0x1876B7D10")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCF30", Offset = "0x3ACB930", VA = "0x183ACCF30")]
		public static void DERJIBQBGFO<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B72520", Offset = "0x2B70F20", VA = "0x182B72520")]
		private static int XTUIAMREIBU([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CSBZLAHHBQK
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int XQETTMXXMUU;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37E46F0", Offset = "0x37E30F0", VA = "0x1837E46F0")]
		public static Id32<GAIDVDAKGEP<a>> VEKILUBJACW<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<GAIDVDAKGEP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37E45B0", Offset = "0x37E2FB0", VA = "0x1837E45B0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<b>>> FVAJQTTNJIV<b>(this UnsafeList<byte> a, [Optional] Id32<GAIDVDAKGEP<b>>? b)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B71F40", Offset = "0x2B70940", VA = "0x182B71F40")]
		public static Id32<GAIDVDAKGEP<KXFBWSJODNE>> DPCPMNWUHRX(this UnsafeList<byte> a, [Optional] Id32<KXFBWSJODNE>? b)
		{
			return default(Id32<GAIDVDAKGEP<KXFBWSJODNE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B72120", Offset = "0x2B70B20", VA = "0x182B72120")]
		public static Id32<GAIDVDAKGEP<WJTJAHYOHYU>> OVDERQXAIZT(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<GAIDVDAKGEP<WJTJAHYOHYU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B72400", Offset = "0x2B70E00", VA = "0x182B72400")]
		public static Id32<GAIDVDAKGEP<KEENRFCLFXX>> UVEYSYORLWM(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<GAIDVDAKGEP<KEENRFCLFXX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B71E50", Offset = "0x2B70850", VA = "0x182B71E50")]
		public static Id32<GAIDVDAKGEP<UXTEGGEVDNB>> CWDXMVMUQZE(this UnsafeList<byte> a, [Optional] Id32<UXTEGGEVDNB>? b)
		{
			return default(Id32<GAIDVDAKGEP<UXTEGGEVDNB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B72210", Offset = "0x2B70C10", VA = "0x182B72210")]
		public static Id32<GAIDVDAKGEP<YFTZEIZNQPO>> SZZPTAJZUZF(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<GAIDVDAKGEP<YFTZEIZNQPO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B72310", Offset = "0x2B70D10", VA = "0x182B72310")]
		public static Id32<GAIDVDAKGEP<BHDVXGKWBTW>> TPWNSIZPTBB(this UnsafeList<byte> a, [Optional] Id32<BHDVXGKWBTW>? b)
		{
			return default(Id32<GAIDVDAKGEP<BHDVXGKWBTW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B72030", Offset = "0x2B70A30", VA = "0x182B72030")]
		public static Id32<GAIDVDAKGEP<JWUJAMRKFPU>> DRNKPVAWFZX(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37E45B0", Offset = "0x37E2FB0", VA = "0x1837E45B0")]
		public static Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>> QULFBTHCCHZ<c>(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<c>>? b)
		{
			return default(Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B71D00", Offset = "0x2B70700", VA = "0x182B71D00")]
		public static void YFWLWGXMIFX(this UnsafeList<byte> a, Id32<GAIDVDAKGEP<KEENRFCLFXX>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37E4690", Offset = "0x37E3090", VA = "0x1837E4690")]
		public static void NARWQDUFKKY<d>(this UnsafeList<byte> a, Id32<GAIDVDAKGEP<GAIDVDAKGEP<d>>> b, Id32<GAIDVDAKGEP<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x37E4690", Offset = "0x37E3090", VA = "0x1837E4690")]
		public static void TVYOVRGFEDA<e>(this UnsafeList<byte> a, Id32<GAIDVDAKGEP<WHMLTPZNLLH<e>>> b, Id32<WHMLTPZNLLH<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class BKBNJDOCTSX
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B71D40", Offset = "0x2B70740", VA = "0x182B71D40")]
		public static Union32 GOIUCXRLLPJ([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B71DB0", Offset = "0x2B707B0", VA = "0x182B71DB0")]
		public static Union32 GOIUCXRLLPJ([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3720E40", Offset = "0x371F840", VA = "0x183720E40")]
		public static Union32 GOIUCXRLLPJ<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3721090", Offset = "0x371FA90", VA = "0x183721090")]
		public static Union32 GOIUCXRLLPJ<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3720FC0", Offset = "0x371F9C0", VA = "0x183720FC0")]
		public static Union32 GOIUCXRLLPJ<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3721020", Offset = "0x371FA20", VA = "0x183721020")]
		public static Union32 GOIUCXRLLPJ<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3721210", Offset = "0x371FC10", VA = "0x183721210")]
		public static Union32 GOIUCXRLLPJ<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B71D40", Offset = "0x2B70740", VA = "0x182B71D40")]
		public static int VGQLAJHDHAM([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B71C30", Offset = "0x2B70630", VA = "0x182B71C30")]
		public static int VGQLAJHDHAM([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3722040", Offset = "0x3720A40", VA = "0x183722040")]
		public static int VGQLAJHDHAM<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3721F70", Offset = "0x3720970", VA = "0x183721F70")]
		public static int VGQLAJHDHAM<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3721F20", Offset = "0x3720920", VA = "0x183721F20")]
		public static int VGQLAJHDHAM<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3721FF0", Offset = "0x37209F0", VA = "0x183721FF0")]
		public static int VGQLAJHDHAM<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3721820", Offset = "0x3720220", VA = "0x183721820")]
		public static float LYCCTNMFSIZ<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37218A0", Offset = "0x37202A0", VA = "0x1837218A0")]
		public static float LYCCTNMFSIZ<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x37218F0", Offset = "0x37202F0", VA = "0x1837218F0")]
		public static float LYCCTNMFSIZ<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3722470", Offset = "0x3720E70", VA = "0x183722470")]
		public static byte ZIWNBYZTEML<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3722350", Offset = "0x3720D50", VA = "0x183722350")]
		public static byte ZIWNBYZTEML<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37222D0", Offset = "0x3720CD0", VA = "0x1837222D0")]
		public static byte ZIWNBYZTEML<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37224C0", Offset = "0x3720EC0", VA = "0x1837224C0")]
		public static byte ZIWNBYZTEML<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37223A0", Offset = "0x3720DA0", VA = "0x1837223A0")]
		public static byte ZIWNBYZTEML<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B71C30", Offset = "0x2B70630", VA = "0x182B71C30")]
		public static Op FJAOEKAIDRT([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3720A10", Offset = "0x371F410", VA = "0x183720A10")]
		public static Op FJAOEKAIDRT<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37215F0", Offset = "0x371FFF0", VA = "0x1837215F0")]
		public static Id32<GAIDVDAKGEP<JPZFXDVMDNP>> JIULMEWYNTT<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3721560", Offset = "0x371FF60", VA = "0x183721560")]
		public static Id32<GAIDVDAKGEP<JPZFXDVMDNP>> JIULMEWYNTT<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3721670", Offset = "0x3720070", VA = "0x183721670")]
		public static Id32<GAIDVDAKGEP<JPZFXDVMDNP>> JIULMEWYNTT<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3721350", Offset = "0x371FD50", VA = "0x183721350")]
		public static Id32<WHMLTPZNLLH<JPZFXDVMDNP>> HEFGQAUGPIX<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<WHMLTPZNLLH<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3721B50", Offset = "0x3720550", VA = "0x183721B50")]
		public static Id32<BHDVXGKWBTW> OQLGSUOJYPB<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3721AC0", Offset = "0x37204C0", VA = "0x183721AC0")]
		public static Id32<BHDVXGKWBTW> OQLGSUOJYPB<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3721BD0", Offset = "0x37205D0", VA = "0x183721BD0")]
		public static Id32<BHDVXGKWBTW> OQLGSUOJYPB<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3721D60", Offset = "0x3720760", VA = "0x183721D60")]
		public static Id32<KXFBWSJODNE> UAETHLPYRIN<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<KXFBWSJODNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3721DF0", Offset = "0x37207F0", VA = "0x183721DF0")]
		public static Id32<KXFBWSJODNE> UAETHLPYRIN<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<KXFBWSJODNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3722110", Offset = "0x3720B10", VA = "0x183722110")]
		public static Id32<UXTEGGEVDNB> YTLSZGDWYTW<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<UXTEGGEVDNB>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IEHYLHFFZWD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B726F0", Offset = "0x2B710F0", VA = "0x182B726F0")]
		public static void LFRLLIXXLRA(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B727B0", Offset = "0x2B711B0", VA = "0x182B727B0")]
		public static void LFRLLIXXLRA(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B72670", Offset = "0x2B71070", VA = "0x182B72670")]
		public static void LFRLLIXXLRA([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B02650", Offset = "0x3B01050", VA = "0x183B02650")]
		public static void LFRLLIXXLRA<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3B02500", Offset = "0x3B00F00", VA = "0x183B02500")]
		public static void LFRLLIXXLRA<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B71D00", Offset = "0x2B70700", VA = "0x182B71D00")]
		public static void YFWLWGXMIFX(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B72820", Offset = "0x2B71220", VA = "0x182B72820")]
		public static void YFWLWGXMIFX(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B728A0", Offset = "0x2B712A0", VA = "0x182B728A0")]
		public static void YFWLWGXMIFX([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B02AA0", Offset = "0x3B014A0", VA = "0x183B02AA0")]
		public static void YFWLWGXMIFX<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B02A40", Offset = "0x3B01440", VA = "0x183B02A40")]
		public static void YFWLWGXMIFX<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B725C0", Offset = "0x2B70FC0", VA = "0x182B725C0")]
		public static void ACJDLSSIFOA(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B020C0", Offset = "0x3B00AC0", VA = "0x183B020C0")]
		public static void ACJDLSSIFOA<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B02130", Offset = "0x3B00B30", VA = "0x183B02130")]
		public static void ACJDLSSIFOA<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B72600", Offset = "0x2B71000", VA = "0x182B72600")]
		public static void KBJEFZGEEMU(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B02250", Offset = "0x3B00C50", VA = "0x183B02250")]
		public static void KBJEFZGEEMU<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3B022A0", Offset = "0x3B00CA0", VA = "0x183B022A0")]
		public static void KBJEFZGEEMU<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3B02860", Offset = "0x3B01260", VA = "0x183B02860")]
		public static void NARWQDUFKKY<q>(this IdArray<q, byte> a, Id32<q> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3B028E0", Offset = "0x3B012E0", VA = "0x183B028E0")]
		public static void NARWQDUFKKY<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3B02860", Offset = "0x3B01260", VA = "0x183B02860")]
		public static void YWXCXKRAAJO<t>(this IdArray<t, byte> a, Id32<t> b, Id32<BHDVXGKWBTW> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3B028E0", Offset = "0x3B012E0", VA = "0x183B028E0")]
		public static void YWXCXKRAAJO<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<BHDVXGKWBTW> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class XQDVYTKVPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B760E0", Offset = "0x2B74AE0", VA = "0x182B760E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) PACIOOPDWKU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B73010", Offset = "0x2B71A10", VA = "0x182B73010")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) BEKKIAMWXKX(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B75B40", Offset = "0x2B74540", VA = "0x182B75B40")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) NLDJGNEAMBE(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B74A10", Offset = "0x2B73410", VA = "0x182B74A10")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) IUGOVAGPBZI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B73160", Offset = "0x2B71B60", VA = "0x182B73160")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) BHVKVYJTEJX(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B72EF0", Offset = "0x2B718F0", VA = "0x182B72EF0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) AWSFDEJEZME(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B759E0", Offset = "0x2B743E0", VA = "0x182B759E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) NEOJDPPBNMM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B77220", Offset = "0x2B75C20", VA = "0x182B77220")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) UBLDHOCHAAH(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B74500", Offset = "0x2B72F00", VA = "0x182B74500")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) GZZBMHJIKYK(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B743F0", Offset = "0x2B72DF0", VA = "0x182B743F0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) GCQIBQABWQW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B77D30", Offset = "0x2B76730", VA = "0x182B77D30")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) YVQOSZMUAHX(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B75C60", Offset = "0x2B74660", VA = "0x182B75C60")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) NQEEFYCWQGX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B74770", Offset = "0x2B73170", VA = "0x182B74770")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) HWDLEDWRRQM(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B76E10", Offset = "0x2B75810", VA = "0x182B76E10")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KXFBWSJODNE>>) SPPRYPVPTUV(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<KXFBWSJODNE>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KXFBWSJODNE>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B76FC0", Offset = "0x2B759C0", VA = "0x182B76FC0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KXFBWSJODNE>>>) SQQAKXRCOZO(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WHMLTPZNLLH<KXFBWSJODNE>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KXFBWSJODNE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B73C40", Offset = "0x2B72640", VA = "0x182B73C40")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<BHDVXGKWBTW>>) EKPUXYAPKNF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BHDVXGKWBTW>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<BHDVXGKWBTW>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B73DF0", Offset = "0x2B727F0", VA = "0x182B73DF0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<BHDVXGKWBTW>>>) EMLEZGXRRLI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WHMLTPZNLLH<BHDVXGKWBTW>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<BHDVXGKWBTW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x411BB00", Offset = "0x411A500", VA = "0x18411BB00")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<a>>) LJHELQBJJQU<a>(this UnsafeList<byte> a, [Optional] Id32<UXTEGGEVDNB>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B764E0", Offset = "0x2B74EE0", VA = "0x182B764E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) PYRFRXKBAOW(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B77E50", Offset = "0x2B76850", VA = "0x182B77E50")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZCEFQAVAKKZ(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x411B6F0", Offset = "0x411A0F0", VA = "0x18411B6F0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<b>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<b>>) KZOHGYVLZDE<b>(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<b>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x411B3C0", Offset = "0x4119DC0", VA = "0x18411B3C0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>) KHCJDNYGDGV<c>(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<c>>? b, [Optional] Id32<WHMLTPZNLLH<c>>? c, [Optional] int? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B729A0", Offset = "0x2B713A0", VA = "0x182B729A0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) AEZOYBXNNOO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B770D0", Offset = "0x2B75AD0", VA = "0x182B770D0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) TKHPXNGUSKV(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B76610", Offset = "0x2B75010", VA = "0x182B76610")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) PZJFBOFCROU(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B77BD0", Offset = "0x2B765D0", VA = "0x182B77BD0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) XTEBSCUQYHO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B777A0", Offset = "0x2B761A0", VA = "0x182B777A0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) WFENAOWXBDJ(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B74C90", Offset = "0x2B73690", VA = "0x182B74C90")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) KAKGANAYBJI(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B74010", Offset = "0x2B72A10", VA = "0x182B74010")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EYXATNRJMJL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B76CC0", Offset = "0x2B756C0", VA = "0x182B76CC0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) SLMTEHFVWAS(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B742D0", Offset = "0x2B72CD0", VA = "0x182B742D0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) FTZMNOIEUYP(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B75FF0", Offset = "0x2B749F0", VA = "0x182B75FF0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) OWTLTYNEEDQ(this UnsafeList<byte> a, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? b)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B74890", Offset = "0x2B73290", VA = "0x182B74890")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) IGZUJMDZOKC(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B769E0", Offset = "0x2B753E0", VA = "0x182B769E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) RXKGHSBCULD(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B758B0", Offset = "0x2B742B0", VA = "0x182B758B0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) MJNMNJYZTAE(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B77A70", Offset = "0x2B76470", VA = "0x182B77A70")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) XOGMGSHYMZF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B77F60", Offset = "0x2B76960", VA = "0x182B77F60")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZEIVDXIYVMU(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B767B0", Offset = "0x2B751B0", VA = "0x182B767B0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) QPXOSOHWDDP(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B77620", Offset = "0x2B76020", VA = "0x182B77620")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) VRSFDWJMYNX(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B73830", Offset = "0x2B72230", VA = "0x182B73830")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) CYTTZOAWPJY(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B780B0", Offset = "0x2B76AB0", VA = "0x182B780B0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZKEBVGWCMLN(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B73990", Offset = "0x2B72390", VA = "0x182B73990")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EBCGFYWFHAY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B73AF0", Offset = "0x2B724F0", VA = "0x182B73AF0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EDSMBUEUJHB(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B75630", Offset = "0x2B74030", VA = "0x182B75630")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) MCRZAUJQQPY(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B73400", Offset = "0x2B71E00", VA = "0x182B73400")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) CESFMDUXKSJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B76380", Offset = "0x2B74D80", VA = "0x182B76380")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) PRHXWXJJUJQ(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B72DC0", Offset = "0x2B717C0", VA = "0x182B72DC0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) AVOZDIQNSBF(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B74170", Offset = "0x2B72B70", VA = "0x182B74170")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) FTGJAIREGEI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B74620", Offset = "0x2B73020", VA = "0x182B74620")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) HMROASLTTYT(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B75ED0", Offset = "0x2B748D0", VA = "0x182B75ED0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) OHGCJDXLKAK(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B76B40", Offset = "0x2B75540", VA = "0x182B76B40")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) SCBHZTDZKTK(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B75D70", Offset = "0x2B74770", VA = "0x182B75D70")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) OFLZSZZGJWX(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B73700", Offset = "0x2B72100", VA = "0x182B73700")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) CYJJLWZTBOC(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B77370", Offset = "0x2B75D70", VA = "0x182B77370")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) UMZPZKUZBKF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B75260", Offset = "0x2B73C60", VA = "0x182B75260")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) LJMQBHJZROC(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B76260", Offset = "0x2B74C60", VA = "0x182B76260")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) PBUUOROZQRF(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B73580", Offset = "0x2B71F80", VA = "0x182B73580")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) CEYLNTHUITN(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B774D0", Offset = "0x2B75ED0", VA = "0x182B774D0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) URBQNMVISCA(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B75510", Offset = "0x2B73F10", VA = "0x182B75510")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) LUWSTIIVFCJ(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B781E0", Offset = "0x2B76BE0", VA = "0x182B781E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZOVIKPBIOHT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B732B0", Offset = "0x2B71CB0", VA = "0x182B732B0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) BQQJFQQBTXM(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B75020", Offset = "0x2B73A20", VA = "0x182B75020")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) KYKDDLKVGID(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B73F00", Offset = "0x2B72900", VA = "0x182B73F00")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EXIOXQLBTQW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B768D0", Offset = "0x2B752D0", VA = "0x182B768D0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) RMMVKWIYHUB(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B76730", Offset = "0x2B75130", VA = "0x182B76730")]
		public static Id32<GAIDVDAKGEP<JWUJAMRKFPU>> QJLRSWNIJCE(this UnsafeList<byte> a)
		{
			return default(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B778F0", Offset = "0x2B762F0", VA = "0x182B778F0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) WZMPPIRGXUD(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B74ED0", Offset = "0x2B738D0", VA = "0x182B74ED0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) KVENVWTNWUA(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B75140", Offset = "0x2B73B40", VA = "0x182B75140")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) LBYRFZCEJAR(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B753B0", Offset = "0x2B73DB0", VA = "0x182B753B0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) LRDXSOQSXTT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B72B20", Offset = "0x2B71520", VA = "0x182B72B20")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ALLPOZDLJKC(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B74B70", Offset = "0x2B73570", VA = "0x182B74B70")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) JFUOHSEQCTJ(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B75750", Offset = "0x2B74150", VA = "0x182B75750")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) MCXVKGPQNNK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B72C70", Offset = "0x2B71670", VA = "0x182B72C70")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ARAZXKKXKRV(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B74DB0", Offset = "0x2B737B0", VA = "0x182B74DB0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) KLNTLWHIYKO(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}
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
