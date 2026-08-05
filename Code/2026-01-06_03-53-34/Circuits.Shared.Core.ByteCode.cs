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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C2EE0", Offset = "0x28C18E0", VA = "0x1828C2EE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class RIWZDSOFQWI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3981DD0", Offset = "0x39807D0", VA = "0x183981DD0")]
		public static Id32<DNQUXCYLSXY<a>> ZAVWNRFYATI<a>(this int a)
		{
			return default(Id32<DNQUXCYLSXY<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28C32C0", Offset = "0x28C1CC0", VA = "0x1828C32C0")]
		public static Id32<JQFETOMIQRN> ZIXEVUAKDIL(this int a)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3981DD0", Offset = "0x39807D0", VA = "0x183981DD0")]
		public static Id32<ASDRXZXCACQ<b>> CKDZJLECYSI<b>(this int a)
		{
			return default(Id32<ASDRXZXCACQ<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class DNQUXCYLSXY<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class WGZMTKKWGOB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class EIZFQRKEDAI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class JQFETOMIQRN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class HNSTYFIETBH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class TBMXMETRNBZ
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
	public static class ZFYJPFTBHEY
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5C0E130", Offset = "0x5C0CB30", VA = "0x185C0E130")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C16700", Offset = "0x3C15100", VA = "0x183C16700")]
		public static void RQZZPFYBFTV<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28C3AE0", Offset = "0x28C24E0", VA = "0x1828C3AE0")]
		private static int NVBIEMPQUDL([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class SREYGRDOJED
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int VFMHNLBIGAL;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E310", Offset = "0x3A3CD10", VA = "0x183A3E310")]
		public static Id32<DNQUXCYLSXY<a>> CIXEQXFSWTL<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<DNQUXCYLSXY<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E470", Offset = "0x3A3CE70", VA = "0x183A3E470")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<b>>> NWNSUWVKEOW<b>(this UnsafeList<byte> a, [Optional] Id32<DNQUXCYLSXY<b>>? b)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28C3300", Offset = "0x28C1D00", VA = "0x1828C3300")]
		public static Id32<DNQUXCYLSXY<TTSTDRWIEBX>> CACRNXDCNDG(this UnsafeList<byte> a, [Optional] Id32<TTSTDRWIEBX>? b)
		{
			return default(Id32<DNQUXCYLSXY<TTSTDRWIEBX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28C37B0", Offset = "0x28C21B0", VA = "0x1828C37B0")]
		public static Id32<DNQUXCYLSXY<WGZMTKKWGOB>> JKDWATPVMZQ(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<DNQUXCYLSXY<WGZMTKKWGOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28C34E0", Offset = "0x28C1EE0", VA = "0x1828C34E0")]
		public static Id32<DNQUXCYLSXY<EIZFQRKEDAI>> EMNTYMIYNPF(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<DNQUXCYLSXY<EIZFQRKEDAI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28C35C0", Offset = "0x28C1FC0", VA = "0x1828C35C0")]
		public static Id32<DNQUXCYLSXY<MLQMNZEWPGO>> FBVXDORXIQB(this UnsafeList<byte> a, [Optional] Id32<MLQMNZEWPGO>? b)
		{
			return default(Id32<DNQUXCYLSXY<MLQMNZEWPGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28C36B0", Offset = "0x28C20B0", VA = "0x1828C36B0")]
		public static Id32<DNQUXCYLSXY<TBMXMETRNBZ>> GLVEZYNCEOS(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<DNQUXCYLSXY<TBMXMETRNBZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28C33F0", Offset = "0x28C1DF0", VA = "0x1828C33F0")]
		public static Id32<DNQUXCYLSXY<JQFETOMIQRN>> EJWNSTOLWVU(this UnsafeList<byte> a, [Optional] Id32<JQFETOMIQRN>? b)
		{
			return default(Id32<DNQUXCYLSXY<JQFETOMIQRN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28C38A0", Offset = "0x28C22A0", VA = "0x1828C38A0")]
		public static Id32<DNQUXCYLSXY<HNSTYFIETBH>> QDLBJLEYDTC(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<DNQUXCYLSXY<HNSTYFIETBH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E470", Offset = "0x3A3CE70", VA = "0x183A3E470")]
		public static Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>> KLIKQPOOSGM<c>(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<c>>? b)
		{
			return default(Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28BD390", Offset = "0x28BBD90", VA = "0x1828BD390")]
		public static void HJSHFJKRWEA(this UnsafeList<byte> a, Id32<DNQUXCYLSXY<EIZFQRKEDAI>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E550", Offset = "0x3A3CF50", VA = "0x183A3E550")]
		public static void NCCWTUYZXYJ<d>(this UnsafeList<byte> a, Id32<DNQUXCYLSXY<DNQUXCYLSXY<d>>> b, Id32<DNQUXCYLSXY<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E550", Offset = "0x3A3CF50", VA = "0x183A3E550")]
		public static void NUOLUXHBVHJ<e>(this UnsafeList<byte> a, Id32<DNQUXCYLSXY<ASDRXZXCACQ<e>>> b, Id32<ASDRXZXCACQ<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WKEWQTFFYAS
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28C39D0", Offset = "0x28C23D0", VA = "0x1828C39D0")]
		public static Union32 EXLTWJBTTNS([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28C3A40", Offset = "0x28C2440", VA = "0x1828C3A40")]
		public static Union32 EXLTWJBTTNS([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2570", Offset = "0x3BE0F70", VA = "0x183BE2570")]
		public static Union32 EXLTWJBTTNS<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2260", Offset = "0x3BE0C60", VA = "0x183BE2260")]
		public static Union32 EXLTWJBTTNS<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE24A0", Offset = "0x3BE0EA0", VA = "0x183BE24A0")]
		public static Union32 EXLTWJBTTNS<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2500", Offset = "0x3BE0F00", VA = "0x183BE2500")]
		public static Union32 EXLTWJBTTNS<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BE23E0", Offset = "0x3BE0DE0", VA = "0x183BE23E0")]
		public static Union32 EXLTWJBTTNS<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28C39D0", Offset = "0x28C23D0", VA = "0x1828C39D0")]
		public static int XKIXCUKIHBV([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28BD530", Offset = "0x28BBF30", VA = "0x1828BD530")]
		public static int XKIXCUKIHBV([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BE32E0", Offset = "0x3BE1CE0", VA = "0x183BE32E0")]
		public static int XKIXCUKIHBV<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3380", Offset = "0x3BE1D80", VA = "0x183BE3380")]
		public static int XKIXCUKIHBV<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3290", Offset = "0x3BE1C90", VA = "0x183BE3290")]
		public static int XKIXCUKIHBV<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3330", Offset = "0x3BE1D30", VA = "0x183BE3330")]
		public static int XKIXCUKIHBV<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3570", Offset = "0x3BE1F70", VA = "0x183BE3570")]
		public static float ZYDYVDBJDWW<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BE35F0", Offset = "0x3BE1FF0", VA = "0x183BE35F0")]
		public static float ZYDYVDBJDWW<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3520", Offset = "0x3BE1F20", VA = "0x183BE3520")]
		public static float ZYDYVDBJDWW<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3090", Offset = "0x3BE1A90", VA = "0x183BE3090")]
		public static byte ROCIGOJDOWO<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3040", Offset = "0x3BE1A40", VA = "0x183BE3040")]
		public static byte ROCIGOJDOWO<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3170", Offset = "0x3BE1B70", VA = "0x183BE3170")]
		public static byte ROCIGOJDOWO<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BE30E0", Offset = "0x3BE1AE0", VA = "0x183BE30E0")]
		public static byte ROCIGOJDOWO<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2F70", Offset = "0x3BE1970", VA = "0x183BE2F70")]
		public static byte ROCIGOJDOWO<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28BD530", Offset = "0x28BBF30", VA = "0x1828BD530")]
		public static Op BFSEQBAZOAY([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1B00", Offset = "0x3BE0500", VA = "0x183BE1B00")]
		public static Op BFSEQBAZOAY<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2900", Offset = "0x3BE1300", VA = "0x183BE2900")]
		public static Id32<DNQUXCYLSXY<WBZFYOYOFGY>> JQYHHMYXJJY<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2980", Offset = "0x3BE1380", VA = "0x183BE2980")]
		public static Id32<DNQUXCYLSXY<WBZFYOYOFGY>> JQYHHMYXJJY<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2870", Offset = "0x3BE1270", VA = "0x183BE2870")]
		public static Id32<DNQUXCYLSXY<WBZFYOYOFGY>> JQYHHMYXJJY<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2A90", Offset = "0x3BE1490", VA = "0x183BE2A90")]
		public static Id32<ASDRXZXCACQ<WBZFYOYOFGY>> LAOZYFYMRLS<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<ASDRXZXCACQ<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2CA0", Offset = "0x3BE16A0", VA = "0x183BE2CA0")]
		public static Id32<JQFETOMIQRN> MDWEJSZRHVW<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2DB0", Offset = "0x3BE17B0", VA = "0x183BE2DB0")]
		public static Id32<JQFETOMIQRN> MDWEJSZRHVW<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BE2D20", Offset = "0x3BE1720", VA = "0x183BE2D20")]
		public static Id32<JQFETOMIQRN> MDWEJSZRHVW<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1C60", Offset = "0x3BE0660", VA = "0x183BE1C60")]
		public static Id32<TTSTDRWIEBX> BVLTLGVYYAK<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<TTSTDRWIEBX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1CF0", Offset = "0x3BE06F0", VA = "0x183BE1CF0")]
		public static Id32<TTSTDRWIEBX> BVLTLGVYYAK<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<TTSTDRWIEBX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1E00", Offset = "0x3BE0800", VA = "0x183BE1E00")]
		public static Id32<MLQMNZEWPGO> ETMYNVZRIKR<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<MLQMNZEWPGO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class QJDHBAVXTBQ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28C31C0", Offset = "0x28C1BC0", VA = "0x1828C31C0")]
		public static void PUKDFQTUNJN(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28C3150", Offset = "0x28C1B50", VA = "0x1828C3150")]
		public static void PUKDFQTUNJN(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28C30D0", Offset = "0x28C1AD0", VA = "0x1828C30D0")]
		public static void PUKDFQTUNJN([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x396C250", Offset = "0x396AC50", VA = "0x18396C250")]
		public static void PUKDFQTUNJN<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x396C3A0", Offset = "0x396ADA0", VA = "0x18396C3A0")]
		public static void PUKDFQTUNJN<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28BD390", Offset = "0x28BBD90", VA = "0x1828BD390")]
		public static void HJSHFJKRWEA(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28C3050", Offset = "0x28C1A50", VA = "0x1828C3050")]
		public static void HJSHFJKRWEA(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28C2FD0", Offset = "0x28C19D0", VA = "0x1828C2FD0")]
		public static void HJSHFJKRWEA([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x396BE30", Offset = "0x396A830", VA = "0x18396BE30")]
		public static void HJSHFJKRWEA<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x396BDD0", Offset = "0x396A7D0", VA = "0x18396BDD0")]
		public static void HJSHFJKRWEA<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28C3280", Offset = "0x28C1C80", VA = "0x1828C3280")]
		public static void WDFRJLXQYOF(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x396C5D0", Offset = "0x396AFD0", VA = "0x18396C5D0")]
		public static void WDFRJLXQYOF<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x396C640", Offset = "0x396B040", VA = "0x18396C640")]
		public static void WDFRJLXQYOF<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28C2F60", Offset = "0x28C1960", VA = "0x1828C2F60")]
		public static void BHAQTWPGQNR(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x396BCA0", Offset = "0x396A6A0", VA = "0x18396BCA0")]
		public static void BHAQTWPGQNR<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x396BC40", Offset = "0x396A640", VA = "0x18396BC40")]
		public static void BHAQTWPGQNR<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x396BFD0", Offset = "0x396A9D0", VA = "0x18396BFD0")]
		public static void NCCWTUYZXYJ<q>(this IdArray<q, byte> a, Id32<q> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x396BF50", Offset = "0x396A950", VA = "0x18396BF50")]
		public static void NCCWTUYZXYJ<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x396BFD0", Offset = "0x396A9D0", VA = "0x18396BFD0")]
		public static void ZWJABZJOQGP<t>(this IdArray<t, byte> a, Id32<t> b, Id32<JQFETOMIQRN> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x396BF50", Offset = "0x396A950", VA = "0x18396BF50")]
		public static void ZWJABZJOQGP<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<JQFETOMIQRN> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class HXOXOEAPEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28C1470", Offset = "0x28BFE70", VA = "0x1828C1470")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) RCFAQZHMYVV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28BD9E0", Offset = "0x28BC3E0", VA = "0x1828BD9E0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) CAWLVGIOKMI(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28BE480", Offset = "0x28BCE80", VA = "0x1828BE480")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) FERCHPSKKCJ(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28BE800", Offset = "0x28BD200", VA = "0x1828BE800")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) FTWIUFGYYVL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28C2630", Offset = "0x28C1030", VA = "0x1828C2630")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) UOEAQPTRKLU(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28BD540", Offset = "0x28BBF40", VA = "0x1828BD540")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) ALMMHBTQQLR(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28C2260", Offset = "0x28C0C60", VA = "0x1828C2260")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TTJHYEPXGRB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28C2110", Offset = "0x28C0B10", VA = "0x1828C2110")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TQTCCJHIEKY(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28BDD90", Offset = "0x28BC790", VA = "0x1828BDD90")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) CZWVUBKNGND(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28C0080", Offset = "0x28BEA80", VA = "0x1828C0080")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) LQGGOHDPWAP(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28C29F0", Offset = "0x28C13F0", VA = "0x1828C29F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) VNXONKXCYWI(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28C2DD0", Offset = "0x28C17D0", VA = "0x1828C2DD0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) ZVAMBQWEMGY(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28C1350", Offset = "0x28BFD50", VA = "0x1828C1350")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) QVEGGFFJQHB(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28BFBF0", Offset = "0x28BE5F0", VA = "0x1828BFBF0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TTSTDRWIEBX>>) KTIMUZVTKCE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<TTSTDRWIEBX>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TTSTDRWIEBX>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28BF6E0", Offset = "0x28BE0E0", VA = "0x1828BF6E0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<TTSTDRWIEBX>>>) KPBYANTWTXX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<ASDRXZXCACQ<TTSTDRWIEBX>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<TTSTDRWIEBX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28C1CA0", Offset = "0x28C06A0", VA = "0x1828C1CA0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<JQFETOMIQRN>>) STKPGVKNZAO(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<JQFETOMIQRN>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<JQFETOMIQRN>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28C1B90", Offset = "0x28C0590", VA = "0x1828C1B90")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<JQFETOMIQRN>>>) SOIYXIHBXCX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<ASDRXZXCACQ<JQFETOMIQRN>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<JQFETOMIQRN>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x36C7890", Offset = "0x36C6290", VA = "0x1836C7890")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<a>>) HHHAWQAIHHL<a>(this UnsafeList<byte> a, [Optional] Id32<MLQMNZEWPGO>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28BF1D0", Offset = "0x28BDBD0", VA = "0x1828BF1D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) IXGNPXDMYAN(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28BDB30", Offset = "0x28BC530", VA = "0x1828BDB30")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) CFGILDWUDCC(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x36C7C90", Offset = "0x36C6690", VA = "0x1836C7C90")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<b>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<b>>) NGNRYRXSNLJ<b>(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<b>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x36C7540", Offset = "0x36C5F40", VA = "0x1836C7540")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>) AOUXTGGZSII<c>(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<c>>? b, [Optional] Id32<ASDRXZXCACQ<c>>? c, [Optional] int? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28BEAE0", Offset = "0x28BD4E0", VA = "0x1828BEAE0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) GPRUDZOHMBR(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28BDEB0", Offset = "0x28BC8B0", VA = "0x1828BDEB0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) DMSWTFXXQCI(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28BE000", Offset = "0x28BCA00", VA = "0x1828BE000")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) DOWKJHGGMMJ(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28BD660", Offset = "0x28BC060", VA = "0x1828BD660")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) ANZGGKMPWWN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28BF950", Offset = "0x28BE350", VA = "0x1828BF950")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KSBIEJFFBBY(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28C28D0", Offset = "0x28C12D0", VA = "0x1828C28D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) VDYXZMYMURR(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28C2B10", Offset = "0x28C1510", VA = "0x1828C2B10")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) WIZMYEGEAXI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28C0900", Offset = "0x28BF300", VA = "0x1828C0900")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) NVPAWUSYCTT(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28BF300", Offset = "0x28BDD00", VA = "0x1828BF300")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) JQOVOEPOWGM(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28BD8F0", Offset = "0x28BC2F0", VA = "0x1828BD8F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) BVSRKAPFBIZ(this UnsafeList<byte> a, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? b)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28BE960", Offset = "0x28BD360", VA = "0x1828BE960")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) GLWSPGPQMSV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28BF580", Offset = "0x28BDF80", VA = "0x1828BF580")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KIVRKRSWNMC(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28BD7C0", Offset = "0x28BC1C0", VA = "0x1828BD7C0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) AYKESWGADFN(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28BF7F0", Offset = "0x28BE1F0", VA = "0x1828BF7F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KPQUPGISZJO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28BFAA0", Offset = "0x28BE4A0", VA = "0x1828BFAA0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KSSXSHYPYVR(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28BEDC0", Offset = "0x28BD7C0", VA = "0x1828BEDC0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) GVFRZKWEHAC(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28BFF00", Offset = "0x28BE900", VA = "0x1828BFF00")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KYZHLQAQTTS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28C0E30", Offset = "0x28BF830", VA = "0x1828C0E30")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) PMPHURGXQPN(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28BE5A0", Offset = "0x28BCFA0", VA = "0x1828BE5A0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) FJBFBBJZETY(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28BFDA0", Offset = "0x28BE7A0", VA = "0x1828BFDA0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KUJWMOVTYFX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28C15F0", Offset = "0x28BFFF0", VA = "0x1828C15F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) SAQRSQJEDHU(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28BF030", Offset = "0x28BDA30", VA = "0x1828BF030")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) IMAVIDTZKSP(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28C10B0", Offset = "0x28BFAB0", VA = "0x1828C10B0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) QBDPPWPNVSQ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28C2C70", Offset = "0x28C1670", VA = "0x1828C2C70")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) WYAJTVCTIGL(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28C0190", Offset = "0x28BEB90", VA = "0x1828C0190")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) MAUABKEZUKW(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28C24D0", Offset = "0x28C0ED0", VA = "0x1828C24D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TYGUNVQQAMF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28C07B0", Offset = "0x28BF1B0", VA = "0x1828C07B0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) NGGPJCJXFNU(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28BE360", Offset = "0x28BCD60", VA = "0x1828BE360")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) EZFLRKWZLHF(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28C18C0", Offset = "0x28C02C0", VA = "0x1828C18C0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) SMNVKYNIRQT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28C03E0", Offset = "0x28BEDE0", VA = "0x1828C03E0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) MQUPULYUJSQ(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28BE6D0", Offset = "0x28BD0D0", VA = "0x1828BE6D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) FKREYSCRUKF(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28C1FB0", Offset = "0x28C09B0", VA = "0x1828C1FB0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) THXHKGYQHIK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28BDC40", Offset = "0x28BC640", VA = "0x1828BDC40")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) CYHTIMVTNJL(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28BE240", Offset = "0x28BCC40", VA = "0x1828BE240")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) EKJQSHWOKUY(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28C1740", Offset = "0x28C0140", VA = "0x1828C1740")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) SCDRCGBILVM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28C2780", Offset = "0x28C1180", VA = "0x1828C2780")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) UWLJKKUPTJX(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28C02C0", Offset = "0x28BECC0", VA = "0x1828C02C0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) MAZSEYPPUBW(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28BEC60", Offset = "0x28BD660", VA = "0x1828BEC60")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) GSOEBPMFBHG(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28C1A40", Offset = "0x28C0440", VA = "0x1828C1A40")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) SMWRYIULJWP(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28BE120", Offset = "0x28BCB20", VA = "0x1828BE120")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) EJXPBFGZFQO(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28C0A50", Offset = "0x28BF450", VA = "0x1828C0A50")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) NYHOBEDASOT(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28C23C0", Offset = "0x28C0DC0", VA = "0x1828C23C0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TUSTINFURDW(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28BF150", Offset = "0x28BDB50", VA = "0x1828BF150")]
		public static Id32<DNQUXCYLSXY<HNSTYFIETBH>> IVELIJNDJDH(this UnsafeList<byte> a)
		{
			return default(Id32<DNQUXCYLSXY<HNSTYFIETBH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28C0CB0", Offset = "0x28BF6B0", VA = "0x1828C0CB0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) PKWUMEXYOEO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28BEEE0", Offset = "0x28BD8E0", VA = "0x1828BEEE0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) HALLINOKVQF(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28C0540", Offset = "0x28BEF40", VA = "0x1828C0540")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) MQZIFLRZQOY(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28C1E50", Offset = "0x28C0850", VA = "0x1828C1E50")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TFAIDSCFBBW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28C0660", Offset = "0x28BF060", VA = "0x1828C0660")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) MYRVKDECNZN(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28C0F90", Offset = "0x28BF990", VA = "0x1828C0F90")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) PQHXBMAUJZA(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28BF420", Offset = "0x28BDE20", VA = "0x1828BF420")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KHRQORSDPIT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28C0B60", Offset = "0x28BF560", VA = "0x1828C0B60")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) OEGYVKWWQFG(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28C1230", Offset = "0x28BFC30", VA = "0x1828C1230")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) QCYKQBHKDQF(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
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
