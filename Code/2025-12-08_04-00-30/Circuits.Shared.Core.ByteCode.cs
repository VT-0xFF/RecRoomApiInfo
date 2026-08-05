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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B0720", Offset = "0x28AEF20", VA = "0x1828B0720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3965B70", Offset = "0x3964370", VA = "0x183965B70")]
		public static Id32<DNQUXCYLSXY<a>> ZAVWNRFYATI<a>(this int a)
		{
			return default(Id32<DNQUXCYLSXY<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B0B00", Offset = "0x28AF300", VA = "0x1828B0B00")]
		public static Id32<JQFETOMIQRN> ZIXEVUAKDIL(this int a)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3965B70", Offset = "0x3964370", VA = "0x183965B70")]
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
			[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5B44270", Offset = "0x5B42A70", VA = "0x185B44270")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF400", Offset = "0x3BFDC00", VA = "0x183BFF400")]
		public static void RQZZPFYBFTV<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28B1320", Offset = "0x28AFB20", VA = "0x1828B1320")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A25B70", Offset = "0x3A24370", VA = "0x183A25B70")]
		public static Id32<DNQUXCYLSXY<a>> CIXEQXFSWTL<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<DNQUXCYLSXY<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A25CD0", Offset = "0x3A244D0", VA = "0x183A25CD0")]
		public static Id32<DNQUXCYLSXY<DNQUXCYLSXY<b>>> NWNSUWVKEOW<b>(this UnsafeList<byte> a, [Optional] Id32<DNQUXCYLSXY<b>>? b)
		{
			return default(Id32<DNQUXCYLSXY<DNQUXCYLSXY<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28B0B40", Offset = "0x28AF340", VA = "0x1828B0B40")]
		public static Id32<DNQUXCYLSXY<TTSTDRWIEBX>> CACRNXDCNDG(this UnsafeList<byte> a, [Optional] Id32<TTSTDRWIEBX>? b)
		{
			return default(Id32<DNQUXCYLSXY<TTSTDRWIEBX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28B0FF0", Offset = "0x28AF7F0", VA = "0x1828B0FF0")]
		public static Id32<DNQUXCYLSXY<WGZMTKKWGOB>> JKDWATPVMZQ(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<DNQUXCYLSXY<WGZMTKKWGOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28B0D20", Offset = "0x28AF520", VA = "0x1828B0D20")]
		public static Id32<DNQUXCYLSXY<EIZFQRKEDAI>> EMNTYMIYNPF(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<DNQUXCYLSXY<EIZFQRKEDAI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28B0E00", Offset = "0x28AF600", VA = "0x1828B0E00")]
		public static Id32<DNQUXCYLSXY<MLQMNZEWPGO>> FBVXDORXIQB(this UnsafeList<byte> a, [Optional] Id32<MLQMNZEWPGO>? b)
		{
			return default(Id32<DNQUXCYLSXY<MLQMNZEWPGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28B0EF0", Offset = "0x28AF6F0", VA = "0x1828B0EF0")]
		public static Id32<DNQUXCYLSXY<TBMXMETRNBZ>> GLVEZYNCEOS(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<DNQUXCYLSXY<TBMXMETRNBZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28B0C30", Offset = "0x28AF430", VA = "0x1828B0C30")]
		public static Id32<DNQUXCYLSXY<JQFETOMIQRN>> EJWNSTOLWVU(this UnsafeList<byte> a, [Optional] Id32<JQFETOMIQRN>? b)
		{
			return default(Id32<DNQUXCYLSXY<JQFETOMIQRN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28B10E0", Offset = "0x28AF8E0", VA = "0x1828B10E0")]
		public static Id32<DNQUXCYLSXY<HNSTYFIETBH>> QDLBJLEYDTC(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<DNQUXCYLSXY<HNSTYFIETBH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A25CD0", Offset = "0x3A244D0", VA = "0x183A25CD0")]
		public static Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>> KLIKQPOOSGM<c>(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<c>>? b)
		{
			return default(Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28AABD0", Offset = "0x28A93D0", VA = "0x1828AABD0")]
		public static void HJSHFJKRWEA(this UnsafeList<byte> a, Id32<DNQUXCYLSXY<EIZFQRKEDAI>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3A25DB0", Offset = "0x3A245B0", VA = "0x183A25DB0")]
		public static void NCCWTUYZXYJ<d>(this UnsafeList<byte> a, Id32<DNQUXCYLSXY<DNQUXCYLSXY<d>>> b, Id32<DNQUXCYLSXY<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3A25DB0", Offset = "0x3A245B0", VA = "0x183A25DB0")]
		public static void NUOLUXHBVHJ<e>(this UnsafeList<byte> a, Id32<DNQUXCYLSXY<ASDRXZXCACQ<e>>> b, Id32<ASDRXZXCACQ<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WKEWQTFFYAS
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28B1210", Offset = "0x28AFA10", VA = "0x1828B1210")]
		public static Union32 EXLTWJBTTNS([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28B1280", Offset = "0x28AFA80", VA = "0x1828B1280")]
		public static Union32 EXLTWJBTTNS([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB1B0", Offset = "0x3BC99B0", VA = "0x183BCB1B0")]
		public static Union32 EXLTWJBTTNS<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAEA0", Offset = "0x3BC96A0", VA = "0x183BCAEA0")]
		public static Union32 EXLTWJBTTNS<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB0E0", Offset = "0x3BC98E0", VA = "0x183BCB0E0")]
		public static Union32 EXLTWJBTTNS<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB140", Offset = "0x3BC9940", VA = "0x183BCB140")]
		public static Union32 EXLTWJBTTNS<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB020", Offset = "0x3BC9820", VA = "0x183BCB020")]
		public static Union32 EXLTWJBTTNS<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28B1210", Offset = "0x28AFA10", VA = "0x1828B1210")]
		public static int XKIXCUKIHBV([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28AAD70", Offset = "0x28A9570", VA = "0x1828AAD70")]
		public static int XKIXCUKIHBV([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBF20", Offset = "0x3BCA720", VA = "0x183BCBF20")]
		public static int XKIXCUKIHBV<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBFC0", Offset = "0x3BCA7C0", VA = "0x183BCBFC0")]
		public static int XKIXCUKIHBV<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBED0", Offset = "0x3BCA6D0", VA = "0x183BCBED0")]
		public static int XKIXCUKIHBV<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBF70", Offset = "0x3BCA770", VA = "0x183BCBF70")]
		public static int XKIXCUKIHBV<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC1B0", Offset = "0x3BCA9B0", VA = "0x183BCC1B0")]
		public static float ZYDYVDBJDWW<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC230", Offset = "0x3BCAA30", VA = "0x183BCC230")]
		public static float ZYDYVDBJDWW<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC160", Offset = "0x3BCA960", VA = "0x183BCC160")]
		public static float ZYDYVDBJDWW<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBCD0", Offset = "0x3BCA4D0", VA = "0x183BCBCD0")]
		public static byte ROCIGOJDOWO<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBC80", Offset = "0x3BCA480", VA = "0x183BCBC80")]
		public static byte ROCIGOJDOWO<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBDB0", Offset = "0x3BCA5B0", VA = "0x183BCBDB0")]
		public static byte ROCIGOJDOWO<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBD20", Offset = "0x3BCA520", VA = "0x183BCBD20")]
		public static byte ROCIGOJDOWO<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBBB0", Offset = "0x3BCA3B0", VA = "0x183BCBBB0")]
		public static byte ROCIGOJDOWO<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28AAD70", Offset = "0x28A9570", VA = "0x1828AAD70")]
		public static Op BFSEQBAZOAY([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA740", Offset = "0x3BC8F40", VA = "0x183BCA740")]
		public static Op BFSEQBAZOAY<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB540", Offset = "0x3BC9D40", VA = "0x183BCB540")]
		public static Id32<DNQUXCYLSXY<WBZFYOYOFGY>> JQYHHMYXJJY<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB5C0", Offset = "0x3BC9DC0", VA = "0x183BCB5C0")]
		public static Id32<DNQUXCYLSXY<WBZFYOYOFGY>> JQYHHMYXJJY<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB4B0", Offset = "0x3BC9CB0", VA = "0x183BCB4B0")]
		public static Id32<DNQUXCYLSXY<WBZFYOYOFGY>> JQYHHMYXJJY<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<DNQUXCYLSXY<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB6D0", Offset = "0x3BC9ED0", VA = "0x183BCB6D0")]
		public static Id32<ASDRXZXCACQ<WBZFYOYOFGY>> LAOZYFYMRLS<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<ASDRXZXCACQ<WBZFYOYOFGY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB8E0", Offset = "0x3BCA0E0", VA = "0x183BCB8E0")]
		public static Id32<JQFETOMIQRN> MDWEJSZRHVW<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB9F0", Offset = "0x3BCA1F0", VA = "0x183BCB9F0")]
		public static Id32<JQFETOMIQRN> MDWEJSZRHVW<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB960", Offset = "0x3BCA160", VA = "0x183BCB960")]
		public static Id32<JQFETOMIQRN> MDWEJSZRHVW<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<JQFETOMIQRN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA8A0", Offset = "0x3BC90A0", VA = "0x183BCA8A0")]
		public static Id32<TTSTDRWIEBX> BVLTLGVYYAK<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<TTSTDRWIEBX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA930", Offset = "0x3BC9130", VA = "0x183BCA930")]
		public static Id32<TTSTDRWIEBX> BVLTLGVYYAK<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<TTSTDRWIEBX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAA40", Offset = "0x3BC9240", VA = "0x183BCAA40")]
		public static Id32<MLQMNZEWPGO> ETMYNVZRIKR<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<MLQMNZEWPGO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class QJDHBAVXTBQ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28B0A00", Offset = "0x28AF200", VA = "0x1828B0A00")]
		public static void PUKDFQTUNJN(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28B0990", Offset = "0x28AF190", VA = "0x1828B0990")]
		public static void PUKDFQTUNJN(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28B0910", Offset = "0x28AF110", VA = "0x1828B0910")]
		public static void PUKDFQTUNJN([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x394FFE0", Offset = "0x394E7E0", VA = "0x18394FFE0")]
		public static void PUKDFQTUNJN<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3950130", Offset = "0x394E930", VA = "0x183950130")]
		public static void PUKDFQTUNJN<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28AABD0", Offset = "0x28A93D0", VA = "0x1828AABD0")]
		public static void HJSHFJKRWEA(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28B0890", Offset = "0x28AF090", VA = "0x1828B0890")]
		public static void HJSHFJKRWEA(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28B0810", Offset = "0x28AF010", VA = "0x1828B0810")]
		public static void HJSHFJKRWEA([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x394FBC0", Offset = "0x394E3C0", VA = "0x18394FBC0")]
		public static void HJSHFJKRWEA<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x394FB60", Offset = "0x394E360", VA = "0x18394FB60")]
		public static void HJSHFJKRWEA<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28B0AC0", Offset = "0x28AF2C0", VA = "0x1828B0AC0")]
		public static void WDFRJLXQYOF(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3950360", Offset = "0x394EB60", VA = "0x183950360")]
		public static void WDFRJLXQYOF<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x39503D0", Offset = "0x394EBD0", VA = "0x1839503D0")]
		public static void WDFRJLXQYOF<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28B07A0", Offset = "0x28AEFA0", VA = "0x1828B07A0")]
		public static void BHAQTWPGQNR(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x394FA30", Offset = "0x394E230", VA = "0x18394FA30")]
		public static void BHAQTWPGQNR<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x394F9D0", Offset = "0x394E1D0", VA = "0x18394F9D0")]
		public static void BHAQTWPGQNR<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x394FD60", Offset = "0x394E560", VA = "0x18394FD60")]
		public static void NCCWTUYZXYJ<q>(this IdArray<q, byte> a, Id32<q> b, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x394FCE0", Offset = "0x394E4E0", VA = "0x18394FCE0")]
		public static void NCCWTUYZXYJ<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<DNQUXCYLSXY<WBZFYOYOFGY>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x394FD60", Offset = "0x394E560", VA = "0x18394FD60")]
		public static void ZWJABZJOQGP<t>(this IdArray<t, byte> a, Id32<t> b, Id32<JQFETOMIQRN> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x394FCE0", Offset = "0x394E4E0", VA = "0x18394FCE0")]
		public static void ZWJABZJOQGP<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<JQFETOMIQRN> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class HXOXOEAPEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28AECB0", Offset = "0x28AD4B0", VA = "0x1828AECB0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) RCFAQZHMYVV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28AB220", Offset = "0x28A9A20", VA = "0x1828AB220")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) CAWLVGIOKMI(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28ABCC0", Offset = "0x28AA4C0", VA = "0x1828ABCC0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) FERCHPSKKCJ(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28AC040", Offset = "0x28AA840", VA = "0x1828AC040")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) FTWIUFGYYVL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28AFE70", Offset = "0x28AE670", VA = "0x1828AFE70")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) UOEAQPTRKLU(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28AAD80", Offset = "0x28A9580", VA = "0x1828AAD80")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) ALMMHBTQQLR(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28AFAA0", Offset = "0x28AE2A0", VA = "0x1828AFAA0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TTJHYEPXGRB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28AF950", Offset = "0x28AE150", VA = "0x1828AF950")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TQTCCJHIEKY(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28AB5D0", Offset = "0x28A9DD0", VA = "0x1828AB5D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) CZWVUBKNGND(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28AD8C0", Offset = "0x28AC0C0", VA = "0x1828AD8C0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) LQGGOHDPWAP(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28B0230", Offset = "0x28AEA30", VA = "0x1828B0230")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) VNXONKXCYWI(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28B0610", Offset = "0x28AEE10", VA = "0x1828B0610")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) ZVAMBQWEMGY(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28AEB90", Offset = "0x28AD390", VA = "0x1828AEB90")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) QVEGGFFJQHB(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28AD430", Offset = "0x28ABC30", VA = "0x1828AD430")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TTSTDRWIEBX>>) KTIMUZVTKCE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<TTSTDRWIEBX>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<TTSTDRWIEBX>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28ACF20", Offset = "0x28AB720", VA = "0x1828ACF20")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<TTSTDRWIEBX>>>) KPBYANTWTXX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<ASDRXZXCACQ<TTSTDRWIEBX>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<TTSTDRWIEBX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28AF4E0", Offset = "0x28ADCE0", VA = "0x1828AF4E0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<JQFETOMIQRN>>) STKPGVKNZAO(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<JQFETOMIQRN>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<JQFETOMIQRN>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28AF3D0", Offset = "0x28ADBD0", VA = "0x1828AF3D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<JQFETOMIQRN>>>) SOIYXIHBXCX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<ASDRXZXCACQ<JQFETOMIQRN>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<JQFETOMIQRN>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x36AD670", Offset = "0x36ABE70", VA = "0x1836AD670")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<a>>) HHHAWQAIHHL<a>(this UnsafeList<byte> a, [Optional] Id32<MLQMNZEWPGO>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<MLQMNZEWPGO>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28ACA10", Offset = "0x28AB210", VA = "0x1828ACA10")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) IXGNPXDMYAN(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28AB370", Offset = "0x28A9B70", VA = "0x1828AB370")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) CFGILDWUDCC(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x36ADA70", Offset = "0x36AC270", VA = "0x1836ADA70")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<b>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<b>>) NGNRYRXSNLJ<b>(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<b>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x36AD320", Offset = "0x36ABB20", VA = "0x1836AD320")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>) AOUXTGGZSII<c>(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<c>>? b, [Optional] Id32<ASDRXZXCACQ<c>>? c, [Optional] int? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<c>>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28AC320", Offset = "0x28AAB20", VA = "0x1828AC320")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) GPRUDZOHMBR(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28AB6F0", Offset = "0x28A9EF0", VA = "0x1828AB6F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) DMSWTFXXQCI(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28AB840", Offset = "0x28AA040", VA = "0x1828AB840")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) DOWKJHGGMMJ(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28AAEA0", Offset = "0x28A96A0", VA = "0x1828AAEA0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) ANZGGKMPWWN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28AD190", Offset = "0x28AB990", VA = "0x1828AD190")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KSBIEJFFBBY(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28B0110", Offset = "0x28AE910", VA = "0x1828B0110")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) VDYXZMYMURR(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28B0350", Offset = "0x28AEB50", VA = "0x1828B0350")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) WIZMYEGEAXI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28AE140", Offset = "0x28AC940", VA = "0x1828AE140")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) NVPAWUSYCTT(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28ACB40", Offset = "0x28AB340", VA = "0x1828ACB40")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) JQOVOEPOWGM(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28AB130", Offset = "0x28A9930", VA = "0x1828AB130")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>) BVSRKAPFBIZ(this UnsafeList<byte> a, [Optional] Id32<DNQUXCYLSXY<HNSTYFIETBH>>? b)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<DNQUXCYLSXY<HNSTYFIETBH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28AC1A0", Offset = "0x28AA9A0", VA = "0x1828AC1A0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) GLWSPGPQMSV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28ACDC0", Offset = "0x28AB5C0", VA = "0x1828ACDC0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KIVRKRSWNMC(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28AB000", Offset = "0x28A9800", VA = "0x1828AB000")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) AYKESWGADFN(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28AD030", Offset = "0x28AB830", VA = "0x1828AD030")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KPQUPGISZJO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28AD2E0", Offset = "0x28ABAE0", VA = "0x1828AD2E0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KSSXSHYPYVR(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28AC600", Offset = "0x28AAE00", VA = "0x1828AC600")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) GVFRZKWEHAC(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28AD740", Offset = "0x28ABF40", VA = "0x1828AD740")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KYZHLQAQTTS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28AE670", Offset = "0x28ACE70", VA = "0x1828AE670")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) PMPHURGXQPN(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28ABDE0", Offset = "0x28AA5E0", VA = "0x1828ABDE0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) FJBFBBJZETY(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28AD5E0", Offset = "0x28ABDE0", VA = "0x1828AD5E0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KUJWMOVTYFX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28AEE30", Offset = "0x28AD630", VA = "0x1828AEE30")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) SAQRSQJEDHU(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28AC870", Offset = "0x28AB070", VA = "0x1828AC870")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) IMAVIDTZKSP(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28AE8F0", Offset = "0x28AD0F0", VA = "0x1828AE8F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) QBDPPWPNVSQ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28B04B0", Offset = "0x28AECB0", VA = "0x1828B04B0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) WYAJTVCTIGL(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28AD9D0", Offset = "0x28AC1D0", VA = "0x1828AD9D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) MAUABKEZUKW(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28AFD10", Offset = "0x28AE510", VA = "0x1828AFD10")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TYGUNVQQAMF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28ADFF0", Offset = "0x28AC7F0", VA = "0x1828ADFF0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) NGGPJCJXFNU(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28ABBA0", Offset = "0x28AA3A0", VA = "0x1828ABBA0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) EZFLRKWZLHF(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28AF100", Offset = "0x28AD900", VA = "0x1828AF100")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) SMNVKYNIRQT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC20", Offset = "0x28AC420", VA = "0x1828ADC20")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) MQUPULYUJSQ(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28ABF10", Offset = "0x28AA710", VA = "0x1828ABF10")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) FKREYSCRUKF(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28AF7F0", Offset = "0x28ADFF0", VA = "0x1828AF7F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) THXHKGYQHIK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28AB480", Offset = "0x28A9C80", VA = "0x1828AB480")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) CYHTIMVTNJL(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28ABA80", Offset = "0x28AA280", VA = "0x1828ABA80")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) EKJQSHWOKUY(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28AEF80", Offset = "0x28AD780", VA = "0x1828AEF80")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) SCDRCGBILVM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28AFFC0", Offset = "0x28AE7C0", VA = "0x1828AFFC0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) UWLJKKUPTJX(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28ADB00", Offset = "0x28AC300", VA = "0x1828ADB00")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) MAZSEYPPUBW(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28AC4A0", Offset = "0x28AACA0", VA = "0x1828AC4A0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) GSOEBPMFBHG(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28AF280", Offset = "0x28ADA80", VA = "0x1828AF280")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) SMWRYIULJWP(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28AB960", Offset = "0x28AA160", VA = "0x1828AB960")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) EJXPBFGZFQO(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28AE290", Offset = "0x28ACA90", VA = "0x1828AE290")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) NYHOBEDASOT(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28AFC00", Offset = "0x28AE400", VA = "0x1828AFC00")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TUSTINFURDW(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28AC990", Offset = "0x28AB190", VA = "0x1828AC990")]
		public static Id32<DNQUXCYLSXY<HNSTYFIETBH>> IVELIJNDJDH(this UnsafeList<byte> a)
		{
			return default(Id32<DNQUXCYLSXY<HNSTYFIETBH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28AE4F0", Offset = "0x28ACCF0", VA = "0x1828AE4F0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) PKWUMEXYOEO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28AC720", Offset = "0x28AAF20", VA = "0x1828AC720")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) HALLINOKVQF(this UnsafeList<byte> a, float b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<WGZMTKKWGOB>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28ADD80", Offset = "0x28AC580", VA = "0x1828ADD80")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>) MQZIFLRZQOY(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? b, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? c, [Optional] Id32<ASDRXZXCACQ<WGZMTKKWGOB>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<WGZMTKKWGOB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28AF690", Offset = "0x28ADE90", VA = "0x1828AF690")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) TFAIDSCFBBW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28ADEA0", Offset = "0x28AC6A0", VA = "0x1828ADEA0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) MYRVKDECNZN(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28AE7D0", Offset = "0x28ACFD0", VA = "0x1828AE7D0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) PQHXBMAUJZA(this UnsafeList<byte> a, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28ACC60", Offset = "0x28AB460", VA = "0x1828ACC60")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) KHRQORSDPIT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28AE3A0", Offset = "0x28ACBA0", VA = "0x1828AE3A0")]
		public static (Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>) OEGYVKWWQFG(this UnsafeList<byte> a, int b, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? c, [Optional] Id32<ASDRXZXCACQ<EIZFQRKEDAI>>? d)
		{
			return default((Id32<DNQUXCYLSXY<HNSTYFIETBH>>, Id32<DNQUXCYLSXY<EIZFQRKEDAI>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>, Id32<DNQUXCYLSXY<ASDRXZXCACQ<EIZFQRKEDAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28AEA70", Offset = "0x28AD270", VA = "0x1828AEA70")]
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
