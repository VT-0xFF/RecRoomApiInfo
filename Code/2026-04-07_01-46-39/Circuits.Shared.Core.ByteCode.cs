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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6FE00", Offset = "0x2B6EE00", VA = "0x182B6FE00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class PAGEXXEQJIV
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D72070", Offset = "0x3D71070", VA = "0x183D72070")]
		public static Id32<IUSFABQMYST<a>> AYHIINKNERH<a>(this int a)
		{
			return default(Id32<IUSFABQMYST<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FE80", Offset = "0x2B6EE80", VA = "0x182B6FE80")]
		public static Id32<RGDVWPILPWQ> SPIESATJREW(this int a)
		{
			return default(Id32<RGDVWPILPWQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D72070", Offset = "0x3D71070", VA = "0x183D72070")]
		public static Id32<LFNQUYKKBAN<b>> SUMJOFYXBVB<b>(this int a)
		{
			return default(Id32<LFNQUYKKBAN<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class IUSFABQMYST<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class QTADGVCPVHW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class XDHGRWMIQRX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class RGDVWPILPWQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class KSOYRRRMEVU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class VNIZWQOSKWA
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
	public static class WRLRCEJGUBZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7700620", Offset = "0x76FF620", VA = "0x187700620")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x40F93F0", Offset = "0x40F83F0", VA = "0x1840F93F0")]
		public static void CLDEWJFIPKY<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B70590", Offset = "0x2B6F590", VA = "0x182B70590")]
		private static int WCBURESPEWS([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class VKQFDJEUWRM
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int QMBREQXLPXC;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4099710", Offset = "0x4098710", VA = "0x184099710")]
		public static Id32<IUSFABQMYST<a>> MQOVJUIEKLU<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<IUSFABQMYST<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x40995D0", Offset = "0x40985D0", VA = "0x1840995D0")]
		public static Id32<IUSFABQMYST<IUSFABQMYST<b>>> ADYQDESPGEB<b>(this UnsafeList<byte> a, [Optional] Id32<IUSFABQMYST<b>>? b)
		{
			return default(Id32<IUSFABQMYST<IUSFABQMYST<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FFB0", Offset = "0x2B6EFB0", VA = "0x182B6FFB0")]
		public static Id32<IUSFABQMYST<CINWVLLIKQC>> IHRVIPXKMFT(this UnsafeList<byte> a, [Optional] Id32<CINWVLLIKQC>? b)
		{
			return default(Id32<IUSFABQMYST<CINWVLLIKQC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B70180", Offset = "0x2B6F180", VA = "0x182B70180")]
		public static Id32<IUSFABQMYST<QTADGVCPVHW>> LHBRDKHNCSR(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<IUSFABQMYST<QTADGVCPVHW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B700A0", Offset = "0x2B6F0A0", VA = "0x182B700A0")]
		public static Id32<IUSFABQMYST<XDHGRWMIQRX>> JZXEUIEOGIM(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<IUSFABQMYST<XDHGRWMIQRX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FEC0", Offset = "0x2B6EEC0", VA = "0x182B6FEC0")]
		public static Id32<IUSFABQMYST<ASCDINNYFPF>> HFPEJAUJTZY(this UnsafeList<byte> a, [Optional] Id32<ASCDINNYFPF>? b)
		{
			return default(Id32<IUSFABQMYST<ASCDINNYFPF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B70360", Offset = "0x2B6F360", VA = "0x182B70360")]
		public static Id32<IUSFABQMYST<VNIZWQOSKWA>> QYNVRWOKRJR(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<IUSFABQMYST<VNIZWQOSKWA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B70270", Offset = "0x2B6F270", VA = "0x182B70270")]
		public static Id32<IUSFABQMYST<RGDVWPILPWQ>> OSYWJWADLTF(this UnsafeList<byte> a, [Optional] Id32<RGDVWPILPWQ>? b)
		{
			return default(Id32<IUSFABQMYST<RGDVWPILPWQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B70460", Offset = "0x2B6F460", VA = "0x182B70460")]
		public static Id32<IUSFABQMYST<KSOYRRRMEVU>> XBYDCLVJLON(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<IUSFABQMYST<KSOYRRRMEVU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x40995D0", Offset = "0x40985D0", VA = "0x1840995D0")]
		public static Id32<IUSFABQMYST<LFNQUYKKBAN<c>>> KCXXUJPUGUP<c>(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<c>>? b)
		{
			return default(Id32<IUSFABQMYST<LFNQUYKKBAN<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F950", Offset = "0x2B6E950", VA = "0x182B6F950")]
		public static void WDCPOJUNFKB(this UnsafeList<byte> a, Id32<IUSFABQMYST<XDHGRWMIQRX>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x40996B0", Offset = "0x40986B0", VA = "0x1840996B0")]
		public static void HQKOPPRIUJK<d>(this UnsafeList<byte> a, Id32<IUSFABQMYST<IUSFABQMYST<d>>> b, Id32<IUSFABQMYST<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x40996B0", Offset = "0x40986B0", VA = "0x1840996B0")]
		public static void GGMFTWUGXZI<e>(this UnsafeList<byte> a, Id32<IUSFABQMYST<LFNQUYKKBAN<e>>> b, Id32<LFNQUYKKBAN<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class CHOCWVIJAST
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F990", Offset = "0x2B6E990", VA = "0x182B6F990")]
		public static Union32 LJCJKKUJHJN([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FA00", Offset = "0x2B6EA00", VA = "0x182B6FA00")]
		public static Union32 LJCJKKUJHJN([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37E1B30", Offset = "0x37E0B30", VA = "0x1837E1B30")]
		public static Union32 LJCJKKUJHJN<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x37E1820", Offset = "0x37E0820", VA = "0x1837E1820")]
		public static Union32 LJCJKKUJHJN<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37E1AD0", Offset = "0x37E0AD0", VA = "0x1837E1AD0")]
		public static Union32 LJCJKKUJHJN<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37E19A0", Offset = "0x37E09A0", VA = "0x1837E19A0")]
		public static Union32 LJCJKKUJHJN<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37E1A10", Offset = "0x37E0A10", VA = "0x1837E1A10")]
		public static Union32 LJCJKKUJHJN<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F990", Offset = "0x2B6E990", VA = "0x182B6F990")]
		public static int CYKNKDLGQEA([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F7E0", Offset = "0x2B6E7E0", VA = "0x182B6F7E0")]
		public static int CYKNKDLGQEA([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37E0BB0", Offset = "0x37DFBB0", VA = "0x1837E0BB0")]
		public static int CYKNKDLGQEA<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37E0B30", Offset = "0x37DFB30", VA = "0x1837E0B30")]
		public static int CYKNKDLGQEA<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x37E0C00", Offset = "0x37DFC00", VA = "0x1837E0C00")]
		public static int CYKNKDLGQEA<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37E0C50", Offset = "0x37DFC50", VA = "0x1837E0C50")]
		public static int CYKNKDLGQEA<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x37E1FF0", Offset = "0x37E0FF0", VA = "0x1837E1FF0")]
		public static float RRXXOFYFSOF<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37E20C0", Offset = "0x37E10C0", VA = "0x1837E20C0")]
		public static float RRXXOFYFSOF<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x37E2070", Offset = "0x37E1070", VA = "0x1837E2070")]
		public static float RRXXOFYFSOF<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x37E24F0", Offset = "0x37E14F0", VA = "0x1837E24F0")]
		public static byte ZBFXLAYPRAH<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37E24A0", Offset = "0x37E14A0", VA = "0x1837E24A0")]
		public static byte ZBFXLAYPRAH<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37E2350", Offset = "0x37E1350", VA = "0x1837E2350")]
		public static byte ZBFXLAYPRAH<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37E2540", Offset = "0x37E1540", VA = "0x1837E2540")]
		public static byte ZBFXLAYPRAH<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37E23D0", Offset = "0x37E13D0", VA = "0x1837E23D0")]
		public static byte ZBFXLAYPRAH<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F7E0", Offset = "0x2B6E7E0", VA = "0x182B6F7E0")]
		public static Op IWCACRWVLEF([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37E10D0", Offset = "0x37E00D0", VA = "0x1837E10D0")]
		public static Op IWCACRWVLEF<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37E0F40", Offset = "0x37DFF40", VA = "0x1837E0F40")]
		public static Id32<IUSFABQMYST<BJYQQFZJRSF>> GELBNYACOSB<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37E0E20", Offset = "0x37DFE20", VA = "0x1837E0E20")]
		public static Id32<IUSFABQMYST<BJYQQFZJRSF>> GELBNYACOSB<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x37E0EB0", Offset = "0x37DFEB0", VA = "0x1837E0EB0")]
		public static Id32<IUSFABQMYST<BJYQQFZJRSF>> GELBNYACOSB<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<IUSFABQMYST<BJYQQFZJRSF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37E1040", Offset = "0x37E0040", VA = "0x1837E1040")]
		public static Id32<LFNQUYKKBAN<BJYQQFZJRSF>> GWWQPAIEMBB<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<LFNQUYKKBAN<BJYQQFZJRSF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37E12B0", Offset = "0x37E02B0", VA = "0x1837E12B0")]
		public static Id32<RGDVWPILPWQ> LAAPARWLEYP<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<RGDVWPILPWQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37E1330", Offset = "0x37E0330", VA = "0x1837E1330")]
		public static Id32<RGDVWPILPWQ> LAAPARWLEYP<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<RGDVWPILPWQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x37E13C0", Offset = "0x37E03C0", VA = "0x1837E13C0")]
		public static Id32<RGDVWPILPWQ> LAAPARWLEYP<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<RGDVWPILPWQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37E1DB0", Offset = "0x37E0DB0", VA = "0x1837E1DB0")]
		public static Id32<CINWVLLIKQC> OXVGFWZRKXD<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<CINWVLLIKQC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37E1E40", Offset = "0x37E0E40", VA = "0x1837E1E40")]
		public static Id32<CINWVLLIKQC> OXVGFWZRKXD<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<CINWVLLIKQC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37E2190", Offset = "0x37E1190", VA = "0x1837E2190")]
		public static Id32<ASCDINNYFPF> YCOERAHHKUE<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<ASCDINNYFPF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MWKUQIZVSJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FAE0", Offset = "0x2B6EAE0", VA = "0x182B6FAE0")]
		public static void OLDRNIHLRUS(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FBA0", Offset = "0x2B6EBA0", VA = "0x182B6FBA0")]
		public static void OLDRNIHLRUS(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FC10", Offset = "0x2B6EC10", VA = "0x182B6FC10")]
		public static void OLDRNIHLRUS([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B020", Offset = "0x3C1A020", VA = "0x183C1B020")]
		public static void OLDRNIHLRUS<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AED0", Offset = "0x3C19ED0", VA = "0x183C1AED0")]
		public static void OLDRNIHLRUS<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F950", Offset = "0x2B6E950", VA = "0x182B6F950")]
		public static void WDCPOJUNFKB(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FD00", Offset = "0x2B6ED00", VA = "0x182B6FD00")]
		public static void WDCPOJUNFKB(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FD80", Offset = "0x2B6ED80", VA = "0x182B6FD80")]
		public static void WDCPOJUNFKB([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B3B0", Offset = "0x3C1A3B0", VA = "0x183C1B3B0")]
		public static void WDCPOJUNFKB<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B410", Offset = "0x3C1A410", VA = "0x183C1B410")]
		public static void WDCPOJUNFKB<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FAA0", Offset = "0x2B6EAA0", VA = "0x182B6FAA0")]
		public static void EMOSIAGIPQM(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AAA0", Offset = "0x3C19AA0", VA = "0x183C1AAA0")]
		public static void EMOSIAGIPQM<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AA30", Offset = "0x3C19A30", VA = "0x183C1AA30")]
		public static void EMOSIAGIPQM<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FC90", Offset = "0x2B6EC90", VA = "0x182B6FC90")]
		public static void TBBOXYYJVEA(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B220", Offset = "0x3C1A220", VA = "0x183C1B220")]
		public static void TBBOXYYJVEA<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B270", Offset = "0x3C1A270", VA = "0x183C1B270")]
		public static void TBBOXYYJVEA<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AC50", Offset = "0x3C19C50", VA = "0x183C1AC50")]
		public static void HQKOPPRIUJK<q>(this IdArray<q, byte> a, Id32<q> b, Id32<IUSFABQMYST<BJYQQFZJRSF>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C1ABD0", Offset = "0x3C19BD0", VA = "0x183C1ABD0")]
		public static void HQKOPPRIUJK<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<IUSFABQMYST<BJYQQFZJRSF>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AC50", Offset = "0x3C19C50", VA = "0x183C1AC50")]
		public static void KXOOXTCETIU<t>(this IdArray<t, byte> a, Id32<t> b, Id32<RGDVWPILPWQ> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3C1ABD0", Offset = "0x3C19BD0", VA = "0x183C1ABD0")]
		public static void KXOOXTCETIU<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<RGDVWPILPWQ> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class YPPYGFDOCQO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B70FF0", Offset = "0x2B6FFF0", VA = "0x182B70FF0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) BLCNICWVPNK(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B71410", Offset = "0x2B70410", VA = "0x182B71410")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) BWQUNVHLZAT(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B737F0", Offset = "0x2B727F0", VA = "0x182B737F0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) KISCRBAGRSO(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B73420", Offset = "0x2B72420", VA = "0x182B73420")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) IXUYIYIXLLU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B74480", Offset = "0x2B73480", VA = "0x182B74480")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) PREXEXEVEDL(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B751C0", Offset = "0x2B741C0", VA = "0x182B751C0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) VJTLPEXWGCM(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B70AC0", Offset = "0x2B6FAC0", VA = "0x182B70AC0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) AYSBCYXKLYM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B73DF0", Offset = "0x2B72DF0", VA = "0x182B73DF0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) MTAOZSFQUNV(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B71170", Offset = "0x2B70170", VA = "0x182B71170")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) BNBZEVTKDRE(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B736E0", Offset = "0x2B726E0", VA = "0x182B736E0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>) KDJFARQMTZI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IUSFABQMYST<KSOYRRRMEVU>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B72B10", Offset = "0x2B71B10", VA = "0x182B72B10")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>) GYKOAMFLWIV(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<IUSFABQMYST<KSOYRRRMEVU>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B70D80", Offset = "0x2B6FD80", VA = "0x182B70D80")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>) BGNBPKFEVEP(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IUSFABQMYST<KSOYRRRMEVU>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B740A0", Offset = "0x2B730A0", VA = "0x182B740A0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>) OAFLHEUXMCE(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<IUSFABQMYST<KSOYRRRMEVU>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B71D60", Offset = "0x2B70D60", VA = "0x182B71D60")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<CINWVLLIKQC>>) DYQVTFYZTPP(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<CINWVLLIKQC>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<CINWVLLIKQC>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B71C50", Offset = "0x2B70C50", VA = "0x182B71C50")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<CINWVLLIKQC>>>) DWKXXJOCTUU(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<LFNQUYKKBAN<CINWVLLIKQC>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<CINWVLLIKQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B752E0", Offset = "0x2B742E0", VA = "0x182B752E0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<RGDVWPILPWQ>>) VLWXHCBOFXV(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<RGDVWPILPWQ>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<RGDVWPILPWQ>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B75490", Offset = "0x2B74490", VA = "0x182B75490")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<RGDVWPILPWQ>>>) VQYNQPFAHVM(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<LFNQUYKKBAN<RGDVWPILPWQ>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<RGDVWPILPWQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x411D470", Offset = "0x411C470", VA = "0x18411D470")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<ASCDINNYFPF>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<a>>) WYRIOVPQUUQ<a>(this UnsafeList<byte> a, [Optional] Id32<ASCDINNYFPF>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<ASCDINNYFPF>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B70750", Offset = "0x2B6F750", VA = "0x182B70750")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) ADXRNWEKMZY(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B73CE0", Offset = "0x2B72CE0", VA = "0x182B73CE0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) MRHZDCPYDIR(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x411D060", Offset = "0x411C060", VA = "0x18411D060")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<b>>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<b>>) IWWXCSNKRUK<b>(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<b>>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x411CD30", Offset = "0x411BD30", VA = "0x18411CD30")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<c>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<c>>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>) EEJCQYPUSDP<c>(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<c>>? b, [Optional] Id32<LFNQUYKKBAN<c>>? c, [Optional] int? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<c>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<c>>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B72030", Offset = "0x2B71030", VA = "0x182B72030")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) EPZOWYKWJUC(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B732D0", Offset = "0x2B722D0", VA = "0x182B732D0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) IOYDXQTSCSN(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B75C00", Offset = "0x2B74C00", VA = "0x182B75C00")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) ZSCGQHPWLIA(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B75D20", Offset = "0x2B74D20", VA = "0x182B75D20")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) ZTVJPRTXNAA(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B75E80", Offset = "0x2B74E80", VA = "0x182B75E80")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) ZWLPLNCMPGD(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B72ED0", Offset = "0x2B71ED0", VA = "0x182B72ED0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) HVLCKNHIWPA(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B741C0", Offset = "0x2B731C0", VA = "0x182B741C0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) ORNSHOVWYAV(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B74B70", Offset = "0x2B73B70", VA = "0x182B74B70")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) THFNYUHXQTU(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B74A50", Offset = "0x2B73A50", VA = "0x182B74A50")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) SRNUDJSKPPV(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B745D0", Offset = "0x2B735D0", VA = "0x182B745D0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>) QNNPTZRBMTQ(this UnsafeList<byte> a, [Optional] Id32<IUSFABQMYST<KSOYRRRMEVU>>? b)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<IUSFABQMYST<KSOYRRRMEVU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B722D0", Offset = "0x2B712D0", VA = "0x182B722D0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) FQGLVLXCGEO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B75060", Offset = "0x2B74060", VA = "0x182B75060")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) VGUUUCZAVFT(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B74F30", Offset = "0x2B73F30", VA = "0x182B74F30")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) UXBDXXVHXGQ(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B70E90", Offset = "0x2B6FE90", VA = "0x182B70E90")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) BJHYEZEAYUP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B75AB0", Offset = "0x2B74AB0", VA = "0x182B75AB0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) ZPWTEPJLLAE(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B74CC0", Offset = "0x2B73CC0", VA = "0x182B74CC0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) TXIEUHQKJBD(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B71710", Offset = "0x2B70710", VA = "0x182B71710")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) CSJTFCMFTWR(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B73580", Offset = "0x2B72580", VA = "0x182B73580")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) JYQOLDZPYYO(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B71560", Offset = "0x2B70560", VA = "0x182B71560")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) BXCMZHQXXYP(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B73170", Offset = "0x2B72170", VA = "0x182B73170")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) IJBXJDNZEMU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B73A70", Offset = "0x2B72A70", VA = "0x182B73A70")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) LLEVVSGLAAL(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B74930", Offset = "0x2B73930", VA = "0x182B74930")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) SGNDTTDARUK(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B72450", Offset = "0x2B71450", VA = "0x182B72450")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) FZIVUEYTSTH(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B73F40", Offset = "0x2B72F40", VA = "0x182B73F40")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) NMRQPSLNQAS(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B71890", Offset = "0x2B70890", VA = "0x182B71890")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) CUCDYGVHRVZ(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B74320", Offset = "0x2B73320", VA = "0x182B74320")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) PIOTLCRIKFG(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B747E0", Offset = "0x2B737E0", VA = "0x182B747E0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) RVWUTAOPHXF(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B70630", Offset = "0x2B6F630", VA = "0x182B70630")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) ACXYKSBNCDU(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B719C0", Offset = "0x2B709C0", VA = "0x182B719C0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) CURBDQHIRMU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B70C20", Offset = "0x2B6FC20", VA = "0x182B70C20")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) BEOSGLGIIZF(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B729E0", Offset = "0x2B719E0", VA = "0x182B729E0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) GTJCDSTOPIW(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B72880", Offset = "0x2B71880", VA = "0x182B72880")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) GLDWZHSGEQN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B74DE0", Offset = "0x2B73DE0", VA = "0x182B74DE0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) UUPFJWQCZGC(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B73BC0", Offset = "0x2B72BC0", VA = "0x182B73BC0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) LZOZAMTGLOH(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B71290", Offset = "0x2B70290", VA = "0x182B71290")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) BUTFFTSFZMP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B75700", Offset = "0x2B74700", VA = "0x182B75700")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) XANFTNYERUY(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B709A0", Offset = "0x2B6F9A0", VA = "0x182B709A0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) ALLQPMZWSQZ(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B755A0", Offset = "0x2B745A0", VA = "0x182B755A0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) WWXQRLTXGFX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B72D80", Offset = "0x2B71D80", VA = "0x182B72D80")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) HGJHSURYRES(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B71F10", Offset = "0x2B70F10", VA = "0x182B71F10")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) EOTGBLVGVFF(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B759A0", Offset = "0x2B749A0", VA = "0x182B759A0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) ZBCLFDGKCVI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B71B40", Offset = "0x2B70B40", VA = "0x182B71B40")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) DTGTJGPCABD(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B71690", Offset = "0x2B70690", VA = "0x182B71690")]
		public static Id32<IUSFABQMYST<KSOYRRRMEVU>> BXEEAKQPLTS(this UnsafeList<byte> a)
		{
			return default(Id32<IUSFABQMYST<KSOYRRRMEVU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B72FF0", Offset = "0x2B71FF0", VA = "0x182B72FF0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) IHTSLKENLNZ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B72730", Offset = "0x2B71730", VA = "0x182B72730")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) GIHFKLUMCHC(this UnsafeList<byte> a, float b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<QTADGVCPVHW>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B721B0", Offset = "0x2B711B0", VA = "0x182B721B0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>) EYYOEYAYEYN(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? b, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? c, [Optional] Id32<LFNQUYKKBAN<QTADGVCPVHW>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<QTADGVCPVHW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B725D0", Offset = "0x2B715D0", VA = "0x182B725D0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) GHKCNTXRURD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B72C30", Offset = "0x2B71C30", VA = "0x182B72C30")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) GZKWIPUWYWO(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B70880", Offset = "0x2B6F880", VA = "0x182B70880")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) AEWIAEJFIUX(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B73910", Offset = "0x2B72910", VA = "0x182B73910")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) LBSYOQADTHO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B75850", Offset = "0x2B74850", VA = "0x182B75850")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) YJZSGPHVBQL(this UnsafeList<byte> a, int b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<XDHGRWMIQRX>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B746C0", Offset = "0x2B736C0", VA = "0x182B746C0")]
		public static (Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>) RURAQYBPPDY(this UnsafeList<byte> a, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? b, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? c, [Optional] Id32<LFNQUYKKBAN<XDHGRWMIQRX>>? d)
		{
			return default((Id32<IUSFABQMYST<KSOYRRRMEVU>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>, Id32<IUSFABQMYST<LFNQUYKKBAN<XDHGRWMIQRX>>>));
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
