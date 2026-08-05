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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DC7F10", Offset = "0x2DC6B10", VA = "0x182DC7F10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QUFGXHZWYWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F0D8B0", Offset = "0x3F0C4B0", VA = "0x183F0D8B0")]
		public static Id32<URLPKZCBIQI<a>> JRPVVLTIQSM<a>(this int a)
		{
			return default(Id32<URLPKZCBIQI<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7F90", Offset = "0x2DC6B90", VA = "0x182DC7F90")]
		public static Id32<KZBLUFSWXZT> XAULRCFQNMV(this int a)
		{
			return default(Id32<KZBLUFSWXZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F0D8B0", Offset = "0x3F0C4B0", VA = "0x183F0D8B0")]
		public static Id32<NZMKZPVTOGO<b>> YUTSCTEFKQC<b>(this int a)
		{
			return default(Id32<NZMKZPVTOGO<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class URLPKZCBIQI<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class TNGDSOZSJYX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class JUWNCHNHAOC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class KZBLUFSWXZT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class JTNRDUJMXAD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class CXDHKEOHOUV
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
	public static class CDRLJPXUKHE
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x61CD3A0", Offset = "0x61CBFA0", VA = "0x1861CD3A0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x39A6B80", Offset = "0x39A5780", VA = "0x1839A6B80")]
		public static void TNWQHLCRJBP<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7A00", Offset = "0x2DC6600", VA = "0x182DC7A00")]
		private static int GMPOFDMPNLN([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class BAVSOYMAXLX
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int PXHGIGHWUAN;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x38F62B0", Offset = "0x38F4EB0", VA = "0x1838F62B0")]
		public static Id32<URLPKZCBIQI<a>> OZWVZOEOPOT<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<URLPKZCBIQI<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x38F6180", Offset = "0x38F4D80", VA = "0x1838F6180")]
		public static Id32<URLPKZCBIQI<URLPKZCBIQI<b>>> TPZSIFIKCJK<b>(this UnsafeList<byte> a, [Optional] Id32<URLPKZCBIQI<b>>? b)
		{
			return default(Id32<URLPKZCBIQI<URLPKZCBIQI<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7700", Offset = "0x2DC6300", VA = "0x182DC7700")]
		public static Id32<URLPKZCBIQI<KQWRYFZVYKT>> LYGIQQKPLWS(this UnsafeList<byte> a, [Optional] Id32<KQWRYFZVYKT>? b)
		{
			return default(Id32<URLPKZCBIQI<KQWRYFZVYKT>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2DC78D0", Offset = "0x2DC64D0", VA = "0x182DC78D0")]
		public static Id32<URLPKZCBIQI<TNGDSOZSJYX>> UYLJDINHDEE(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<URLPKZCBIQI<TNGDSOZSJYX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DC77F0", Offset = "0x2DC63F0", VA = "0x182DC77F0")]
		public static Id32<URLPKZCBIQI<JUWNCHNHAOC>> TBYRNWSLFWB(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<URLPKZCBIQI<JUWNCHNHAOC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7610", Offset = "0x2DC6210", VA = "0x182DC7610")]
		public static Id32<URLPKZCBIQI<GEBYEJADWWU>> GZCDPWYSODB(this UnsafeList<byte> a, [Optional] Id32<GEBYEJADWWU>? b)
		{
			return default(Id32<URLPKZCBIQI<GEBYEJADWWU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7510", Offset = "0x2DC6110", VA = "0x182DC7510")]
		public static Id32<URLPKZCBIQI<CXDHKEOHOUV>> FOWOHHRKKUM(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<URLPKZCBIQI<CXDHKEOHOUV>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7420", Offset = "0x2DC6020", VA = "0x182DC7420")]
		public static Id32<URLPKZCBIQI<KZBLUFSWXZT>> BFVLKWLPISA(this UnsafeList<byte> a, [Optional] Id32<KZBLUFSWXZT>? b)
		{
			return default(Id32<URLPKZCBIQI<KZBLUFSWXZT>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7330", Offset = "0x2DC5F30", VA = "0x182DC7330")]
		public static Id32<URLPKZCBIQI<JTNRDUJMXAD>> AOQLSEPVXLM(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<URLPKZCBIQI<JTNRDUJMXAD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38F6180", Offset = "0x38F4D80", VA = "0x1838F6180")]
		public static Id32<URLPKZCBIQI<NZMKZPVTOGO<c>>> ALGKNSUJWBM<c>(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<c>>? b)
		{
			return default(Id32<URLPKZCBIQI<NZMKZPVTOGO<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7180", Offset = "0x2DC5D80", VA = "0x182DC7180")]
		public static void EBNCKMNOGPE(this UnsafeList<byte> a, Id32<URLPKZCBIQI<JUWNCHNHAOC>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38F6320", Offset = "0x38F4F20", VA = "0x1838F6320")]
		public static void YVMBRVGMLAL<d>(this UnsafeList<byte> a, Id32<URLPKZCBIQI<URLPKZCBIQI<d>>> b, Id32<URLPKZCBIQI<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38F6320", Offset = "0x38F4F20", VA = "0x1838F6320")]
		public static void YDVIIRCVTGZ<e>(this UnsafeList<byte> a, Id32<URLPKZCBIQI<NZMKZPVTOGO<e>>> b, Id32<NZMKZPVTOGO<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class EMEPNYGNSGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7EA0", Offset = "0x2DC6AA0", VA = "0x182DC7EA0")]
		public static Union32 ARWXFOPXHKS([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7E00", Offset = "0x2DC6A00", VA = "0x182DC7E00")]
		public static Union32 ARWXFOPXHKS([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9400", Offset = "0x3AD8000", VA = "0x183AD9400")]
		public static Union32 ARWXFOPXHKS<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9220", Offset = "0x3AD7E20", VA = "0x183AD9220")]
		public static Union32 ARWXFOPXHKS<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD93A0", Offset = "0x3AD7FA0", VA = "0x183AD93A0")]
		public static Union32 ARWXFOPXHKS<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9580", Offset = "0x3AD8180", VA = "0x183AD9580")]
		public static Union32 ARWXFOPXHKS<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9160", Offset = "0x3AD7D60", VA = "0x183AD9160")]
		public static Union32 ARWXFOPXHKS<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7EA0", Offset = "0x2DC6AA0", VA = "0x182DC7EA0")]
		public static int KVBKOFOGQQF([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7320", Offset = "0x2DC5F20", VA = "0x182DC7320")]
		public static int KVBKOFOGQQF([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9980", Offset = "0x3AD8580", VA = "0x183AD9980")]
		public static int KVBKOFOGQQF<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9900", Offset = "0x3AD8500", VA = "0x183AD9900")]
		public static int KVBKOFOGQQF<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AD99D0", Offset = "0x3AD85D0", VA = "0x183AD99D0")]
		public static int KVBKOFOGQQF<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9A20", Offset = "0x3AD8620", VA = "0x183AD9A20")]
		public static int KVBKOFOGQQF<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9FC0", Offset = "0x3AD8BC0", VA = "0x183AD9FC0")]
		public static float SXBDLMNONCM<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA040", Offset = "0x3AD8C40", VA = "0x183ADA040")]
		public static float SXBDLMNONCM<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA090", Offset = "0x3AD8C90", VA = "0x183ADA090")]
		public static float SXBDLMNONCM<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA6A0", Offset = "0x3AD92A0", VA = "0x183ADA6A0")]
		public static byte YUUXJPBEESU<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA8D0", Offset = "0x3AD94D0", VA = "0x183ADA8D0")]
		public static byte YUUXJPBEESU<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA7C0", Offset = "0x3AD93C0", VA = "0x183ADA7C0")]
		public static byte YUUXJPBEESU<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA840", Offset = "0x3AD9440", VA = "0x183ADA840")]
		public static byte YUUXJPBEESU<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA6F0", Offset = "0x3AD92F0", VA = "0x183ADA6F0")]
		public static byte YUUXJPBEESU<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7320", Offset = "0x2DC5F20", VA = "0x182DC7320")]
		public static Op SXXCPIGZANA([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA0E0", Offset = "0x3AD8CE0", VA = "0x183ADA0E0")]
		public static Op SXXCPIGZANA<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9D10", Offset = "0x3AD8910", VA = "0x183AD9D10")]
		public static Id32<URLPKZCBIQI<PCOBNQTLDEG>> NXZIBHSXKEQ<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9C80", Offset = "0x3AD8880", VA = "0x183AD9C80")]
		public static Id32<URLPKZCBIQI<PCOBNQTLDEG>> NXZIBHSXKEQ<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9BF0", Offset = "0x3AD87F0", VA = "0x183AD9BF0")]
		public static Id32<URLPKZCBIQI<PCOBNQTLDEG>> NXZIBHSXKEQ<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<URLPKZCBIQI<PCOBNQTLDEG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA4E0", Offset = "0x3AD90E0", VA = "0x183ADA4E0")]
		public static Id32<NZMKZPVTOGO<PCOBNQTLDEG>> UINITGGSXYO<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<NZMKZPVTOGO<PCOBNQTLDEG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA3E0", Offset = "0x3AD8FE0", VA = "0x183ADA3E0")]
		public static Id32<KZBLUFSWXZT> TFGZEMVIOUO<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<KZBLUFSWXZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA2C0", Offset = "0x3AD8EC0", VA = "0x183ADA2C0")]
		public static Id32<KZBLUFSWXZT> TFGZEMVIOUO<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<KZBLUFSWXZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA350", Offset = "0x3AD8F50", VA = "0x183ADA350")]
		public static Id32<KZBLUFSWXZT> TFGZEMVIOUO<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<KZBLUFSWXZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3AD96F0", Offset = "0x3AD82F0", VA = "0x183AD96F0")]
		public static Id32<KQWRYFZVYKT> DQYWPPXCBIU<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<KQWRYFZVYKT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9780", Offset = "0x3AD8380", VA = "0x183AD9780")]
		public static Id32<KQWRYFZVYKT> DQYWPPXCBIU<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<KQWRYFZVYKT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9E10", Offset = "0x3AD8A10", VA = "0x183AD9E10")]
		public static Id32<GEBYEJADWWU> SUCEJBJSDJR<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<GEBYEJADWWU>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class DYBGYKNBGDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7BA0", Offset = "0x2DC67A0", VA = "0x182DC7BA0")]
		public static void OLECJLYRFTT(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7C60", Offset = "0x2DC6860", VA = "0x182DC7C60")]
		public static void OLECJLYRFTT(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7CD0", Offset = "0x2DC68D0", VA = "0x182DC7CD0")]
		public static void OLECJLYRFTT([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E1B0", Offset = "0x3A8CDB0", VA = "0x183A8E1B0")]
		public static void OLECJLYRFTT<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E300", Offset = "0x3A8CF00", VA = "0x183A8E300")]
		public static void OLECJLYRFTT<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7180", Offset = "0x2DC5D80", VA = "0x182DC7180")]
		public static void EBNCKMNOGPE(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7B20", Offset = "0x2DC6720", VA = "0x182DC7B20")]
		public static void EBNCKMNOGPE(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7AA0", Offset = "0x2DC66A0", VA = "0x182DC7AA0")]
		public static void EBNCKMNOGPE([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A8DF50", Offset = "0x3A8CB50", VA = "0x183A8DF50")]
		public static void EBNCKMNOGPE<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A8DEF0", Offset = "0x3A8CAF0", VA = "0x183A8DEF0")]
		public static void EBNCKMNOGPE<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7DC0", Offset = "0x2DC69C0", VA = "0x182DC7DC0")]
		public static void ZDXAIFGRHET(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E8C0", Offset = "0x3A8D4C0", VA = "0x183A8E8C0")]
		public static void ZDXAIFGRHET<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E850", Offset = "0x3A8D450", VA = "0x183A8E850")]
		public static void ZDXAIFGRHET<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7D50", Offset = "0x2DC6950", VA = "0x182DC7D50")]
		public static void WWSLYGQVGTL(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E6C0", Offset = "0x3A8D2C0", VA = "0x183A8E6C0")]
		public static void WWSLYGQVGTL<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E710", Offset = "0x3A8D310", VA = "0x183A8E710")]
		public static void WWSLYGQVGTL<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E510", Offset = "0x3A8D110", VA = "0x183A8E510")]
		public static void YVMBRVGMLAL<q>(this IdArray<q, byte> a, Id32<q> b, Id32<URLPKZCBIQI<PCOBNQTLDEG>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E590", Offset = "0x3A8D190", VA = "0x183A8E590")]
		public static void YVMBRVGMLAL<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<URLPKZCBIQI<PCOBNQTLDEG>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E510", Offset = "0x3A8D110", VA = "0x183A8E510")]
		public static void PVTVNAVSQNT<t>(this IdArray<t, byte> a, Id32<t> b, Id32<KZBLUFSWXZT> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E590", Offset = "0x3A8D190", VA = "0x183A8E590")]
		public static void PVTVNAVSQNT<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<KZBLUFSWXZT> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class VAUCSRDXNDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD7F0", Offset = "0x2DCC3F0", VA = "0x182DCD7F0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) ZTRMRFRXHNT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD290", Offset = "0x2DCBE90", VA = "0x182DCD290")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) YRTKSUKHBYS(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8970", Offset = "0x2DC7570", VA = "0x182DC8970")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) ENMATPOKDXF(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2DCAB80", Offset = "0x2DC9780", VA = "0x182DCAB80")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) OJATHXHRULR(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB8C0", Offset = "0x2DCA4C0", VA = "0x182DCB8C0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) SFQBOQMKVIE(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBF50", Offset = "0x2DCAB50", VA = "0x182DCBF50")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) UEHNJGWYITD(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2DCACE0", Offset = "0x2DC98E0", VA = "0x182DCACE0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) OWLEPGZDFAN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB770", Offset = "0x2DCA370", VA = "0x182DCB770")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) RVPBGZZQYXY(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC2E0", Offset = "0x2DCAEE0", VA = "0x182DCC2E0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) VTCGZXCCQTN(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9290", Offset = "0x2DC7E90", VA = "0x182DC9290")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>) HULIIHWMOAN(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<URLPKZCBIQI<JTNRDUJMXAD>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8130", Offset = "0x2DC6D30", VA = "0x182DC8130")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>) CDUDZZMPXQK(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<URLPKZCBIQI<JTNRDUJMXAD>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8250", Offset = "0x2DC6E50", VA = "0x182DC8250")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>) CRAVTJRGRJI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<URLPKZCBIQI<JTNRDUJMXAD>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2DCCC40", Offset = "0x2DCB840", VA = "0x182DCCC40")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>) YHBPNAFEIJT(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<URLPKZCBIQI<JTNRDUJMXAD>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9D20", Offset = "0x2DC8920", VA = "0x182DC9D20")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<KQWRYFZVYKT>>) KYMZVARUXPA(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<KQWRYFZVYKT>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<KQWRYFZVYKT>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9ED0", Offset = "0x2DC8AD0", VA = "0x182DC9ED0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<KQWRYFZVYKT>>>) LDECKAHMGPZ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<NZMKZPVTOGO<KQWRYFZVYKT>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<KQWRYFZVYKT>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2DCA250", Offset = "0x2DC8E50", VA = "0x182DCA250")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<KZBLUFSWXZT>>) LWUHNFAMLRC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<KZBLUFSWXZT>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<KZBLUFSWXZT>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2DCA140", Offset = "0x2DC8D40", VA = "0x182DCA140")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<KZBLUFSWXZT>>>) LSNSSSYPVMV(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<NZMKZPVTOGO<KZBLUFSWXZT>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<KZBLUFSWXZT>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4193110", Offset = "0x4191D10", VA = "0x184193110")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<GEBYEJADWWU>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<a>>) WVLPTYPJMNR<a>(this UnsafeList<byte> a, [Optional] Id32<GEBYEJADWWU>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<GEBYEJADWWU>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9AE0", Offset = "0x2DC86E0", VA = "0x182DC9AE0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) JZIPRPMMASP(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8ED0", Offset = "0x2DC7AD0", VA = "0x182DC8ED0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) GXFRFAUAFEY(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4192D00", Offset = "0x4191900", VA = "0x184192D00")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<b>>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<b>>) HIAUBCBFBTP<b>(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<b>>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4193450", Offset = "0x4192050", VA = "0x184193450")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<c>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<c>>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>) YPESIINXSEC<c>(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<c>>? b, [Optional] Id32<NZMKZPVTOGO<c>>? c, [Optional] int? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<c>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<c>>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB370", Offset = "0x2DC9F70", VA = "0x182DCB370")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) QZEIGNMQBFP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2DCA580", Offset = "0x2DC9180", VA = "0x182DCA580")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) NEYPVIKFXSC(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2DC95E0", Offset = "0x2DC81E0", VA = "0x182DC95E0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) JNZIBPOMAQD(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD690", Offset = "0x2DCC290", VA = "0x182DCD690")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) ZOPDTVWVMHV(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBB60", Offset = "0x2DCA760", VA = "0x182DCBB60")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) SYSCLLGXTIA(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBE30", Offset = "0x2DCAA30", VA = "0x182DCBE30")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) TKTOPJXRGJD(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8810", Offset = "0x2DC7410", VA = "0x182DC8810")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) ELYBNQZOOEI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB620", Offset = "0x2DCA220", VA = "0x182DCB620")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) RUEVFQHFWNF(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2DCA910", Offset = "0x2DC9510", VA = "0x182DCA910")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) OBWQSGCFXKC(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8480", Offset = "0x2DC7080", VA = "0x182DC8480")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>) DBOYBVGWMAP(this UnsafeList<byte> a, [Optional] Id32<URLPKZCBIQI<JTNRDUJMXAD>>? b)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<URLPKZCBIQI<JTNRDUJMXAD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8570", Offset = "0x2DC7170", VA = "0x182DC8570")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) DDJQCUPBCTV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7FD0", Offset = "0x2DC6BD0", VA = "0x182DC7FD0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) ABGRQFWPHGE(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB4F0", Offset = "0x2DCA0F0", VA = "0x182DCB4F0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) RGOKWEWYNVX(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9FE0", Offset = "0x2DC8BE0", VA = "0x182DC9FE0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) LKMJNZVLKQK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC9A0", Offset = "0x2DCB5A0", VA = "0x182DCC9A0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) XZQQBFTHYTP(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8360", Offset = "0x2DC6F60", VA = "0x182DC8360")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) CUMGIRZMLWU(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2DCA400", Offset = "0x2DC9000", VA = "0x182DCA400")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) NEFIGZEBFVM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC550", Offset = "0x2DCB150", VA = "0x182DCC550")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) WHSIFCPAPRP(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB240", Offset = "0x2DC9E40", VA = "0x182DCB240")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) QJZKBHBMGIU(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC180", Offset = "0x2DCAD80", VA = "0x182DCC180")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) UOFYPNZWXLB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC6B0", Offset = "0x2DCB2B0", VA = "0x182DCC6B0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) XEMUAPGBIAU(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC86F0", Offset = "0x2DC72F0", VA = "0x182DC86F0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) ECGBRLQVUDP(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBCB0", Offset = "0x2DCA8B0", VA = "0x182DCBCB0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) TAUHZSIPILU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8C10", Offset = "0x2DC7810", VA = "0x182DC8C10")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) FZCXDUXMMND(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9700", Offset = "0x2DC8300", VA = "0x182DC9700")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) JPCEBBZAMEE(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB0E0", Offset = "0x2DC9CE0", VA = "0x182DCB0E0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) QBSKIMZZNLR(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBA10", Offset = "0x2DCA610", VA = "0x182DCBA10")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) SRZFTOGDYBK(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2DCA6D0", Offset = "0x2DC92D0", VA = "0x182DCA6D0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) NNVSBGVXFVX(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2DCAE40", Offset = "0x2DC9A40", VA = "0x182DCAE40")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) PDKMMJLORWF(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2DCCFE0", Offset = "0x2DCBBE0", VA = "0x182DCCFE0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) YRBBPTDRKCG(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2DC99B0", Offset = "0x2DC85B0", VA = "0x182DC99B0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) JYDRWWDESLB(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2DCCE80", Offset = "0x2DCBA80", VA = "0x182DCCE80")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) YLYBQTGPVVC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD540", Offset = "0x2DCC140", VA = "0x182DCD540")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) ZNKTKEPAMYP(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2DC94C0", Offset = "0x2DC80C0", VA = "0x182DC94C0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) IIKZTOLXAQK(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9830", Offset = "0x2DC8430", VA = "0x182DC9830")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) JQDNZOTEAUA(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD140", Offset = "0x2DCBD40", VA = "0x182DCD140")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) YRMCVHSCPDN(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2DC93A0", Offset = "0x2DC7FA0", VA = "0x182DC93A0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) IBEORNIAQKK(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8D70", Offset = "0x2DC7970", VA = "0x182DC8D70")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) GHIHIHLUTRY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC400", Offset = "0x2DCB000", VA = "0x182DCC400")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) VXWQGYNTITD(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2DCCD60", Offset = "0x2DCB960", VA = "0x182DCCD60")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) YJTXQLOKREU(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC070", Offset = "0x2DCAC70", VA = "0x182DCC070")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) UHFLNALUQWF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9C10", Offset = "0x2DC8810", VA = "0x182DC9C10")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) KQUZOUORKVE(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC800", Offset = "0x2DCB400", VA = "0x182DCC800")]
		public static Id32<URLPKZCBIQI<JTNRDUJMXAD>> XKVBEVEASOX(this UnsafeList<byte> a)
		{
			return default(Id32<URLPKZCBIQI<JTNRDUJMXAD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8A90", Offset = "0x2DC7690", VA = "0x182DC8A90")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) ERVZFCPHUYE(this UnsafeList<byte> a, float b, float c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2DCAA30", Offset = "0x2DC9630", VA = "0x182DCAA30")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) OFORFYZUJIH(this UnsafeList<byte> a, float b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<TNGDSOZSJYX>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2DCAFC0", Offset = "0x2DC9BC0", VA = "0x182DCAFC0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>) PQWCIAIYWRA(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? b, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? c, [Optional] Id32<NZMKZPVTOGO<TNGDSOZSJYX>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<TNGDSOZSJYX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD3E0", Offset = "0x2DCBFE0", VA = "0x182DCD3E0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) ZEVTWXHLUFI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2DCCAF0", Offset = "0x2DCB6F0", VA = "0x182DCCAF0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) YBPZQNLIWAV(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2DCC880", Offset = "0x2DCB480", VA = "0x182DCC880")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) XPONMOUPIZS(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8FE0", Offset = "0x2DC7BE0", VA = "0x182DC8FE0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) HCNFKNPGSCN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9140", Offset = "0x2DC7D40", VA = "0x182DC9140")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) HEQOZZOOYQO(this UnsafeList<byte> a, int b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<JUWNCHNHAOC>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2DCA7F0", Offset = "0x2DC93F0", VA = "0x182DCA7F0")]
		public static (Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>) NZEHVDSGDVN(this UnsafeList<byte> a, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? b, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? c, [Optional] Id32<NZMKZPVTOGO<JUWNCHNHAOC>>? d)
		{
			return default((Id32<URLPKZCBIQI<JTNRDUJMXAD>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>, Id32<URLPKZCBIQI<NZMKZPVTOGO<JUWNCHNHAOC>>>));
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
