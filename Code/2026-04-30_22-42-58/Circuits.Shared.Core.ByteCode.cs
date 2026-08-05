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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B72E30", Offset = "0x2B72230", VA = "0x182B72E30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4118EA0", Offset = "0x41182A0", VA = "0x184118EA0")]
		public static Id32<GAIDVDAKGEP<a>> YYDIPXDRFYV<a>(this int a)
		{
			return default(Id32<GAIDVDAKGEP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B78850", Offset = "0x2B77C50", VA = "0x182B78850")]
		public static Id32<BHDVXGKWBTW> FGSUEEQVGFA(this int a)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4118EA0", Offset = "0x41182A0", VA = "0x184118EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x76217E0", Offset = "0x7620BE0", VA = "0x1876217E0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3AC10C0", Offset = "0x3AC04C0", VA = "0x183AC10C0")]
		public static void DERJIBQBGFO<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B72A30", Offset = "0x2B71E30", VA = "0x182B72A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D7C20", Offset = "0x37D7020", VA = "0x1837D7C20")]
		public static Id32<GAIDVDAKGEP<a>> VEKILUBJACW<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<GAIDVDAKGEP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37D7AE0", Offset = "0x37D6EE0", VA = "0x1837D7AE0")]
		public static Id32<GAIDVDAKGEP<GAIDVDAKGEP<b>>> FVAJQTTNJIV<b>(this UnsafeList<byte> a, [Optional] Id32<GAIDVDAKGEP<b>>? b)
		{
			return default(Id32<GAIDVDAKGEP<GAIDVDAKGEP<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B72450", Offset = "0x2B71850", VA = "0x182B72450")]
		public static Id32<GAIDVDAKGEP<KXFBWSJODNE>> DPCPMNWUHRX(this UnsafeList<byte> a, [Optional] Id32<KXFBWSJODNE>? b)
		{
			return default(Id32<GAIDVDAKGEP<KXFBWSJODNE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B72630", Offset = "0x2B71A30", VA = "0x182B72630")]
		public static Id32<GAIDVDAKGEP<WJTJAHYOHYU>> OVDERQXAIZT(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<GAIDVDAKGEP<WJTJAHYOHYU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B72910", Offset = "0x2B71D10", VA = "0x182B72910")]
		public static Id32<GAIDVDAKGEP<KEENRFCLFXX>> UVEYSYORLWM(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<GAIDVDAKGEP<KEENRFCLFXX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B72360", Offset = "0x2B71760", VA = "0x182B72360")]
		public static Id32<GAIDVDAKGEP<UXTEGGEVDNB>> CWDXMVMUQZE(this UnsafeList<byte> a, [Optional] Id32<UXTEGGEVDNB>? b)
		{
			return default(Id32<GAIDVDAKGEP<UXTEGGEVDNB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B72720", Offset = "0x2B71B20", VA = "0x182B72720")]
		public static Id32<GAIDVDAKGEP<YFTZEIZNQPO>> SZZPTAJZUZF(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<GAIDVDAKGEP<YFTZEIZNQPO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B72820", Offset = "0x2B71C20", VA = "0x182B72820")]
		public static Id32<GAIDVDAKGEP<BHDVXGKWBTW>> TPWNSIZPTBB(this UnsafeList<byte> a, [Optional] Id32<BHDVXGKWBTW>? b)
		{
			return default(Id32<GAIDVDAKGEP<BHDVXGKWBTW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B72540", Offset = "0x2B71940", VA = "0x182B72540")]
		public static Id32<GAIDVDAKGEP<JWUJAMRKFPU>> DRNKPVAWFZX(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37D7AE0", Offset = "0x37D6EE0", VA = "0x1837D7AE0")]
		public static Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>> QULFBTHCCHZ<c>(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<c>>? b)
		{
			return default(Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B72210", Offset = "0x2B71610", VA = "0x182B72210")]
		public static void YFWLWGXMIFX(this UnsafeList<byte> a, Id32<GAIDVDAKGEP<KEENRFCLFXX>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37D7BC0", Offset = "0x37D6FC0", VA = "0x1837D7BC0")]
		public static void NARWQDUFKKY<d>(this UnsafeList<byte> a, Id32<GAIDVDAKGEP<GAIDVDAKGEP<d>>> b, Id32<GAIDVDAKGEP<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x37D7BC0", Offset = "0x37D6FC0", VA = "0x1837D7BC0")]
		public static void TVYOVRGFEDA<e>(this UnsafeList<byte> a, Id32<GAIDVDAKGEP<WHMLTPZNLLH<e>>> b, Id32<WHMLTPZNLLH<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class BKBNJDOCTSX
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B72250", Offset = "0x2B71650", VA = "0x182B72250")]
		public static Union32 GOIUCXRLLPJ([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B722C0", Offset = "0x2B716C0", VA = "0x182B722C0")]
		public static Union32 GOIUCXRLLPJ([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3715360", Offset = "0x3714760", VA = "0x183715360")]
		public static Union32 GOIUCXRLLPJ<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x37155B0", Offset = "0x37149B0", VA = "0x1837155B0")]
		public static Union32 GOIUCXRLLPJ<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37154E0", Offset = "0x37148E0", VA = "0x1837154E0")]
		public static Union32 GOIUCXRLLPJ<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3715540", Offset = "0x3714940", VA = "0x183715540")]
		public static Union32 GOIUCXRLLPJ<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3715730", Offset = "0x3714B30", VA = "0x183715730")]
		public static Union32 GOIUCXRLLPJ<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B72250", Offset = "0x2B71650", VA = "0x182B72250")]
		public static int VGQLAJHDHAM([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B72140", Offset = "0x2B71540", VA = "0x182B72140")]
		public static int VGQLAJHDHAM([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3716560", Offset = "0x3715960", VA = "0x183716560")]
		public static int VGQLAJHDHAM<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3716490", Offset = "0x3715890", VA = "0x183716490")]
		public static int VGQLAJHDHAM<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3716440", Offset = "0x3715840", VA = "0x183716440")]
		public static int VGQLAJHDHAM<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3716510", Offset = "0x3715910", VA = "0x183716510")]
		public static int VGQLAJHDHAM<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3715D40", Offset = "0x3715140", VA = "0x183715D40")]
		public static float LYCCTNMFSIZ<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3715DC0", Offset = "0x37151C0", VA = "0x183715DC0")]
		public static float LYCCTNMFSIZ<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3715E10", Offset = "0x3715210", VA = "0x183715E10")]
		public static float LYCCTNMFSIZ<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3716990", Offset = "0x3715D90", VA = "0x183716990")]
		public static byte ZIWNBYZTEML<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3716870", Offset = "0x3715C70", VA = "0x183716870")]
		public static byte ZIWNBYZTEML<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37167F0", Offset = "0x3715BF0", VA = "0x1837167F0")]
		public static byte ZIWNBYZTEML<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37169E0", Offset = "0x3715DE0", VA = "0x1837169E0")]
		public static byte ZIWNBYZTEML<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37168C0", Offset = "0x3715CC0", VA = "0x1837168C0")]
		public static byte ZIWNBYZTEML<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B72140", Offset = "0x2B71540", VA = "0x182B72140")]
		public static Op FJAOEKAIDRT([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3714F30", Offset = "0x3714330", VA = "0x183714F30")]
		public static Op FJAOEKAIDRT<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3715B10", Offset = "0x3714F10", VA = "0x183715B10")]
		public static Id32<GAIDVDAKGEP<JPZFXDVMDNP>> JIULMEWYNTT<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3715A80", Offset = "0x3714E80", VA = "0x183715A80")]
		public static Id32<GAIDVDAKGEP<JPZFXDVMDNP>> JIULMEWYNTT<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3715B90", Offset = "0x3714F90", VA = "0x183715B90")]
		public static Id32<GAIDVDAKGEP<JPZFXDVMDNP>> JIULMEWYNTT<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<GAIDVDAKGEP<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3715870", Offset = "0x3714C70", VA = "0x183715870")]
		public static Id32<WHMLTPZNLLH<JPZFXDVMDNP>> HEFGQAUGPIX<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<WHMLTPZNLLH<JPZFXDVMDNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3716070", Offset = "0x3715470", VA = "0x183716070")]
		public static Id32<BHDVXGKWBTW> OQLGSUOJYPB<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3715FE0", Offset = "0x37153E0", VA = "0x183715FE0")]
		public static Id32<BHDVXGKWBTW> OQLGSUOJYPB<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x37160F0", Offset = "0x37154F0", VA = "0x1837160F0")]
		public static Id32<BHDVXGKWBTW> OQLGSUOJYPB<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<BHDVXGKWBTW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3716280", Offset = "0x3715680", VA = "0x183716280")]
		public static Id32<KXFBWSJODNE> UAETHLPYRIN<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<KXFBWSJODNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3716310", Offset = "0x3715710", VA = "0x183716310")]
		public static Id32<KXFBWSJODNE> UAETHLPYRIN<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<KXFBWSJODNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3716630", Offset = "0x3715A30", VA = "0x183716630")]
		public static Id32<UXTEGGEVDNB> YTLSZGDWYTW<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<UXTEGGEVDNB>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IEHYLHFFZWD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B72C00", Offset = "0x2B72000", VA = "0x182B72C00")]
		public static void LFRLLIXXLRA(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B72CC0", Offset = "0x2B720C0", VA = "0x182B72CC0")]
		public static void LFRLLIXXLRA(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B72B80", Offset = "0x2B71F80", VA = "0x182B72B80")]
		public static void LFRLLIXXLRA([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6A00", Offset = "0x3AF5E00", VA = "0x183AF6A00")]
		public static void LFRLLIXXLRA<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF68B0", Offset = "0x3AF5CB0", VA = "0x183AF68B0")]
		public static void LFRLLIXXLRA<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B72210", Offset = "0x2B71610", VA = "0x182B72210")]
		public static void YFWLWGXMIFX(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B72D30", Offset = "0x2B72130", VA = "0x182B72D30")]
		public static void YFWLWGXMIFX(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B72DB0", Offset = "0x2B721B0", VA = "0x182B72DB0")]
		public static void YFWLWGXMIFX([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6E50", Offset = "0x3AF6250", VA = "0x183AF6E50")]
		public static void YFWLWGXMIFX<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6DF0", Offset = "0x3AF61F0", VA = "0x183AF6DF0")]
		public static void YFWLWGXMIFX<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B72AD0", Offset = "0x2B71ED0", VA = "0x182B72AD0")]
		public static void ACJDLSSIFOA(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6470", Offset = "0x3AF5870", VA = "0x183AF6470")]
		public static void ACJDLSSIFOA<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3AF64E0", Offset = "0x3AF58E0", VA = "0x183AF64E0")]
		public static void ACJDLSSIFOA<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B72B10", Offset = "0x2B71F10", VA = "0x182B72B10")]
		public static void KBJEFZGEEMU(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6600", Offset = "0x3AF5A00", VA = "0x183AF6600")]
		public static void KBJEFZGEEMU<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6650", Offset = "0x3AF5A50", VA = "0x183AF6650")]
		public static void KBJEFZGEEMU<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6C10", Offset = "0x3AF6010", VA = "0x183AF6C10")]
		public static void NARWQDUFKKY<q>(this IdArray<q, byte> a, Id32<q> b, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6C90", Offset = "0x3AF6090", VA = "0x183AF6C90")]
		public static void NARWQDUFKKY<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<GAIDVDAKGEP<JPZFXDVMDNP>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6C10", Offset = "0x3AF6010", VA = "0x183AF6C10")]
		public static void YWXCXKRAAJO<t>(this IdArray<t, byte> a, Id32<t> b, Id32<BHDVXGKWBTW> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6C90", Offset = "0x3AF6090", VA = "0x183AF6C90")]
		public static void YWXCXKRAAJO<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<BHDVXGKWBTW> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class XQDVYTKVPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B765F0", Offset = "0x2B759F0", VA = "0x182B765F0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) PACIOOPDWKU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B73520", Offset = "0x2B72920", VA = "0x182B73520")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) BEKKIAMWXKX(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B76050", Offset = "0x2B75450", VA = "0x182B76050")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) NLDJGNEAMBE(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B74F20", Offset = "0x2B74320", VA = "0x182B74F20")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) IUGOVAGPBZI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B73670", Offset = "0x2B72A70", VA = "0x182B73670")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) BHVKVYJTEJX(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B73400", Offset = "0x2B72800", VA = "0x182B73400")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) AWSFDEJEZME(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B75EF0", Offset = "0x2B752F0", VA = "0x182B75EF0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) NEOJDPPBNMM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B77730", Offset = "0x2B76B30", VA = "0x182B77730")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) UBLDHOCHAAH(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B74A10", Offset = "0x2B73E10", VA = "0x182B74A10")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) GZZBMHJIKYK(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B74900", Offset = "0x2B73D00", VA = "0x182B74900")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) GCQIBQABWQW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B78240", Offset = "0x2B77640", VA = "0x182B78240")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) YVQOSZMUAHX(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B76170", Offset = "0x2B75570", VA = "0x182B76170")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) NQEEFYCWQGX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B74C80", Offset = "0x2B74080", VA = "0x182B74C80")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) HWDLEDWRRQM(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B77320", Offset = "0x2B76720", VA = "0x182B77320")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KXFBWSJODNE>>) SPPRYPVPTUV(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<KXFBWSJODNE>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KXFBWSJODNE>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B774D0", Offset = "0x2B768D0", VA = "0x182B774D0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KXFBWSJODNE>>>) SQQAKXRCOZO(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WHMLTPZNLLH<KXFBWSJODNE>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KXFBWSJODNE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B74150", Offset = "0x2B73550", VA = "0x182B74150")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<BHDVXGKWBTW>>) EKPUXYAPKNF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BHDVXGKWBTW>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<BHDVXGKWBTW>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B74300", Offset = "0x2B73700", VA = "0x182B74300")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<BHDVXGKWBTW>>>) EMLEZGXRRLI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WHMLTPZNLLH<BHDVXGKWBTW>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<BHDVXGKWBTW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x41103C0", Offset = "0x410F7C0", VA = "0x1841103C0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<a>>) LJHELQBJJQU<a>(this UnsafeList<byte> a, [Optional] Id32<UXTEGGEVDNB>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<UXTEGGEVDNB>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B769F0", Offset = "0x2B75DF0", VA = "0x182B769F0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) PYRFRXKBAOW(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B78360", Offset = "0x2B77760", VA = "0x182B78360")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZCEFQAVAKKZ(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x410FFB0", Offset = "0x410F3B0", VA = "0x18410FFB0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<b>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<b>>) KZOHGYVLZDE<b>(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<b>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x410FC80", Offset = "0x410F080", VA = "0x18410FC80")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>) KHCJDNYGDGV<c>(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<c>>? b, [Optional] Id32<WHMLTPZNLLH<c>>? c, [Optional] int? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<c>>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B72EB0", Offset = "0x2B722B0", VA = "0x182B72EB0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) AEZOYBXNNOO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B775E0", Offset = "0x2B769E0", VA = "0x182B775E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) TKHPXNGUSKV(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B76B20", Offset = "0x2B75F20", VA = "0x182B76B20")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) PZJFBOFCROU(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B780E0", Offset = "0x2B774E0", VA = "0x182B780E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) XTEBSCUQYHO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B77CB0", Offset = "0x2B770B0", VA = "0x182B77CB0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) WFENAOWXBDJ(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B751A0", Offset = "0x2B745A0", VA = "0x182B751A0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) KAKGANAYBJI(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B74520", Offset = "0x2B73920", VA = "0x182B74520")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EYXATNRJMJL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B771D0", Offset = "0x2B765D0", VA = "0x182B771D0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) SLMTEHFVWAS(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B747E0", Offset = "0x2B73BE0", VA = "0x182B747E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) FTZMNOIEUYP(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B76500", Offset = "0x2B75900", VA = "0x182B76500")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>) OWTLTYNEEDQ(this UnsafeList<byte> a, [Optional] Id32<GAIDVDAKGEP<JWUJAMRKFPU>>? b)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<GAIDVDAKGEP<JWUJAMRKFPU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B74DA0", Offset = "0x2B741A0", VA = "0x182B74DA0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) IGZUJMDZOKC(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B76EF0", Offset = "0x2B762F0", VA = "0x182B76EF0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) RXKGHSBCULD(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B75DC0", Offset = "0x2B751C0", VA = "0x182B75DC0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) MJNMNJYZTAE(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B77F80", Offset = "0x2B77380", VA = "0x182B77F80")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) XOGMGSHYMZF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B78470", Offset = "0x2B77870", VA = "0x182B78470")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZEIVDXIYVMU(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B76CC0", Offset = "0x2B760C0", VA = "0x182B76CC0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) QPXOSOHWDDP(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B77B30", Offset = "0x2B76F30", VA = "0x182B77B30")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) VRSFDWJMYNX(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B73D40", Offset = "0x2B73140", VA = "0x182B73D40")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) CYTTZOAWPJY(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B785C0", Offset = "0x2B779C0", VA = "0x182B785C0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZKEBVGWCMLN(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B73EA0", Offset = "0x2B732A0", VA = "0x182B73EA0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EBCGFYWFHAY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B74000", Offset = "0x2B73400", VA = "0x182B74000")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EDSMBUEUJHB(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B75B40", Offset = "0x2B74F40", VA = "0x182B75B40")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) MCRZAUJQQPY(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B73910", Offset = "0x2B72D10", VA = "0x182B73910")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) CESFMDUXKSJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B76890", Offset = "0x2B75C90", VA = "0x182B76890")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) PRHXWXJJUJQ(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B732D0", Offset = "0x2B726D0", VA = "0x182B732D0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) AVOZDIQNSBF(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B74680", Offset = "0x2B73A80", VA = "0x182B74680")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) FTGJAIREGEI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B74B30", Offset = "0x2B73F30", VA = "0x182B74B30")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) HMROASLTTYT(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B763E0", Offset = "0x2B757E0", VA = "0x182B763E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) OHGCJDXLKAK(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B77050", Offset = "0x2B76450", VA = "0x182B77050")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) SCBHZTDZKTK(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B76280", Offset = "0x2B75680", VA = "0x182B76280")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) OFLZSZZGJWX(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B73C10", Offset = "0x2B73010", VA = "0x182B73C10")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) CYJJLWZTBOC(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B77880", Offset = "0x2B76C80", VA = "0x182B77880")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) UMZPZKUZBKF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B75770", Offset = "0x2B74B70", VA = "0x182B75770")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) LJMQBHJZROC(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B76770", Offset = "0x2B75B70", VA = "0x182B76770")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) PBUUOROZQRF(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B73A90", Offset = "0x2B72E90", VA = "0x182B73A90")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) CEYLNTHUITN(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B779E0", Offset = "0x2B76DE0", VA = "0x182B779E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) URBQNMVISCA(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B75A20", Offset = "0x2B74E20", VA = "0x182B75A20")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) LUWSTIIVFCJ(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B786F0", Offset = "0x2B77AF0", VA = "0x182B786F0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ZOVIKPBIOHT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B737C0", Offset = "0x2B72BC0", VA = "0x182B737C0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) BQQJFQQBTXM(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B75530", Offset = "0x2B74930", VA = "0x182B75530")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) KYKDDLKVGID(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B74410", Offset = "0x2B73810", VA = "0x182B74410")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) EXIOXQLBTQW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B76DE0", Offset = "0x2B761E0", VA = "0x182B76DE0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) RMMVKWIYHUB(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B76C40", Offset = "0x2B76040", VA = "0x182B76C40")]
		public static Id32<GAIDVDAKGEP<JWUJAMRKFPU>> QJLRSWNIJCE(this UnsafeList<byte> a)
		{
			return default(Id32<GAIDVDAKGEP<JWUJAMRKFPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B77E00", Offset = "0x2B77200", VA = "0x182B77E00")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) WZMPPIRGXUD(this UnsafeList<byte> a, float b, float c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B753E0", Offset = "0x2B747E0", VA = "0x182B753E0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) KVENVWTNWUA(this UnsafeList<byte> a, float b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WJTJAHYOHYU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B75650", Offset = "0x2B74A50", VA = "0x182B75650")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>) LBYRFZCEJAR(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? b, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? c, [Optional] Id32<WHMLTPZNLLH<WJTJAHYOHYU>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<WJTJAHYOHYU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B758C0", Offset = "0x2B74CC0", VA = "0x182B758C0")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) LRDXSOQSXTT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B73030", Offset = "0x2B72430", VA = "0x182B73030")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ALLPOZDLJKC(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B75080", Offset = "0x2B74480", VA = "0x182B75080")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) JFUOHSEQCTJ(this UnsafeList<byte> a, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B75C60", Offset = "0x2B75060", VA = "0x182B75C60")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) MCXVKGPQNNK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B73180", Offset = "0x2B72580", VA = "0x182B73180")]
		public static (Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>) ARAZXKKXKRV(this UnsafeList<byte> a, int b, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? c, [Optional] Id32<WHMLTPZNLLH<KEENRFCLFXX>>? d)
		{
			return default((Id32<GAIDVDAKGEP<JWUJAMRKFPU>>, Id32<GAIDVDAKGEP<KEENRFCLFXX>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>, Id32<GAIDVDAKGEP<WHMLTPZNLLH<KEENRFCLFXX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B752C0", Offset = "0x2B746C0", VA = "0x182B752C0")]
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
