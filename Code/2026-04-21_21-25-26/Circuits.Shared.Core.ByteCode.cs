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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAA580", Offset = "0x2BA8F80", VA = "0x182BAA580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class VOARQCJAOUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4113820", Offset = "0x4112220", VA = "0x184113820")]
		public static Id32<WXKPXITHDLK<a>> JLRXYMXSZKU<a>(this int a)
		{
			return default(Id32<WXKPXITHDLK<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA600", Offset = "0x2BA9000", VA = "0x182BAA600")]
		public static Id32<GQSCCKHWVOV> IFQEZZKSSEF(this int a)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4113820", Offset = "0x4112220", VA = "0x184113820")]
		public static Id32<IXKHGZWDMFU<b>> PFIZFDBGOOS<b>(this int a)
		{
			return default(Id32<IXKHGZWDMFU<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class WXKPXITHDLK<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class XZWASXESRJR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class CXMCVELPQUC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GQSCCKHWVOV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class VABZENOIJNF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class FRPUBIFEUNX
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
	public static class LIVRQFOHDMC
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x76A47D0", Offset = "0x76A31D0", VA = "0x1876A47D0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C14140", Offset = "0x3C12B40", VA = "0x183C14140")]
		public static void OCKWTTKZKNH<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA4E0", Offset = "0x2BA8EE0", VA = "0x182BAA4E0")]
		private static int WGHKTVJLLUP([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GBGBFCBRUXX
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int NEKDIGOLBFD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B04B50", Offset = "0x3B03550", VA = "0x183B04B50")]
		public static Id32<WXKPXITHDLK<a>> CVTSUYBSWXR<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<WXKPXITHDLK<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B04CB0", Offset = "0x3B036B0", VA = "0x183B04CB0")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<b>>> DXWQSOXWPFC<b>(this UnsafeList<byte> a, [Optional] Id32<WXKPXITHDLK<b>>? b)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA0C0", Offset = "0x2BA8AC0", VA = "0x182BAA0C0")]
		public static Id32<WXKPXITHDLK<OYXCYVSZNSL>> PEMFXOIHCXA(this UnsafeList<byte> a, [Optional] Id32<OYXCYVSZNSL>? b)
		{
			return default(Id32<WXKPXITHDLK<OYXCYVSZNSL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9DF0", Offset = "0x2BA87F0", VA = "0x182BA9DF0")]
		public static Id32<WXKPXITHDLK<XZWASXESRJR>> IMAAEUNDLIY(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<WXKPXITHDLK<XZWASXESRJR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9EE0", Offset = "0x2BA88E0", VA = "0x182BA9EE0")]
		public static Id32<WXKPXITHDLK<CXMCVELPQUC>> MVAJXDWTNEZ(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<WXKPXITHDLK<CXMCVELPQUC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9D00", Offset = "0x2BA8700", VA = "0x182BA9D00")]
		public static Id32<WXKPXITHDLK<IUBIECDJGSA>> FUNUFRNDTJV(this UnsafeList<byte> a, [Optional] Id32<IUBIECDJGSA>? b)
		{
			return default(Id32<WXKPXITHDLK<IUBIECDJGSA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9FC0", Offset = "0x2BA89C0", VA = "0x182BA9FC0")]
		public static Id32<WXKPXITHDLK<FRPUBIFEUNX>> OMPLHFGRDJS(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<WXKPXITHDLK<FRPUBIFEUNX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA2A0", Offset = "0x2BA8CA0", VA = "0x182BAA2A0")]
		public static Id32<WXKPXITHDLK<GQSCCKHWVOV>> UQDODDJPIHS(this UnsafeList<byte> a, [Optional] Id32<GQSCCKHWVOV>? b)
		{
			return default(Id32<WXKPXITHDLK<GQSCCKHWVOV>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA1B0", Offset = "0x2BA8BB0", VA = "0x182BAA1B0")]
		public static Id32<WXKPXITHDLK<VABZENOIJNF>> UMICVRJFUSG(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<WXKPXITHDLK<VABZENOIJNF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B04CB0", Offset = "0x3B036B0", VA = "0x183B04CB0")]
		public static Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>> FFXNBZDSRCK<c>(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<c>>? b)
		{
			return default(Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3E50", Offset = "0x2BA2850", VA = "0x182BA3E50")]
		public static void ITFMAKCQRFI(this UnsafeList<byte> a, Id32<WXKPXITHDLK<CXMCVELPQUC>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B04AF0", Offset = "0x3B034F0", VA = "0x183B04AF0")]
		public static void BPAXYQVHQDN<d>(this UnsafeList<byte> a, Id32<WXKPXITHDLK<WXKPXITHDLK<d>>> b, Id32<WXKPXITHDLK<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B04AF0", Offset = "0x3B034F0", VA = "0x183B04AF0")]
		public static void XJYIRTKMEJD<e>(this UnsafeList<byte> a, Id32<WXKPXITHDLK<IXKHGZWDMFU<e>>> b, Id32<IXKHGZWDMFU<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class KRZWNZTWIUE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA3D0", Offset = "0x2BA8DD0", VA = "0x182BAA3D0")]
		public static Union32 FOXBGIXPFHE([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA440", Offset = "0x2BA8E40", VA = "0x182BAA440")]
		public static Union32 FOXBGIXPFHE([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B730", Offset = "0x3C0A130", VA = "0x183C0B730")]
		public static Union32 FOXBGIXPFHE<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B5B0", Offset = "0x3C09FB0", VA = "0x183C0B5B0")]
		public static Union32 FOXBGIXPFHE<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B970", Offset = "0x3C0A370", VA = "0x183C0B970")]
		public static Union32 FOXBGIXPFHE<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B540", Offset = "0x3C09F40", VA = "0x183C0B540")]
		public static Union32 FOXBGIXPFHE<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B8B0", Offset = "0x3C0A2B0", VA = "0x183C0B8B0")]
		public static Union32 FOXBGIXPFHE<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA3D0", Offset = "0x2BA8DD0", VA = "0x182BAA3D0")]
		public static int PYOBFIISELT([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3FF0", Offset = "0x2BA29F0", VA = "0x182BA3FF0")]
		public static int PYOBFIISELT([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BD60", Offset = "0x3C0A760", VA = "0x183C0BD60")]
		public static int PYOBFIISELT<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BE00", Offset = "0x3C0A800", VA = "0x183C0BE00")]
		public static int PYOBFIISELT<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BE80", Offset = "0x3C0A880", VA = "0x183C0BE80")]
		public static int PYOBFIISELT<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BDB0", Offset = "0x3C0A7B0", VA = "0x183C0BDB0")]
		public static int PYOBFIISELT<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BB40", Offset = "0x3C0A540", VA = "0x183C0BB40")]
		public static float JOGXUGYZJBS<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BBC0", Offset = "0x3C0A5C0", VA = "0x183C0BBC0")]
		public static float JOGXUGYZJBS<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BAF0", Offset = "0x3C0A4F0", VA = "0x183C0BAF0")]
		public static float JOGXUGYZJBS<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C1A0", Offset = "0x3C0ABA0", VA = "0x183C0C1A0")]
		public static byte TRFAKJIWNBW<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C000", Offset = "0x3C0AA00", VA = "0x183C0C000")]
		public static byte TRFAKJIWNBW<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C120", Offset = "0x3C0AB20", VA = "0x183C0C120")]
		public static byte TRFAKJIWNBW<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C1F0", Offset = "0x3C0ABF0", VA = "0x183C0C1F0")]
		public static byte TRFAKJIWNBW<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C050", Offset = "0x3C0AA50", VA = "0x183C0C050")]
		public static byte TRFAKJIWNBW<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3FF0", Offset = "0x2BA29F0", VA = "0x182BA3FF0")]
		public static Op JWIXSSKQSXY([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BC60", Offset = "0x3C0A660", VA = "0x183C0BC60")]
		public static Op JWIXSSKQSXY<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C490", Offset = "0x3C0AE90", VA = "0x183C0C490")]
		public static Id32<WXKPXITHDLK<WFSWBPUBAOK>> VNDMZCKPMDO<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C510", Offset = "0x3C0AF10", VA = "0x183C0C510")]
		public static Id32<WXKPXITHDLK<WFSWBPUBAOK>> VNDMZCKPMDO<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C400", Offset = "0x3C0AE00", VA = "0x183C0C400")]
		public static Id32<WXKPXITHDLK<WFSWBPUBAOK>> VNDMZCKPMDO<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C0ADB0", Offset = "0x3C097B0", VA = "0x183C0ADB0")]
		public static Id32<IXKHGZWDMFU<WFSWBPUBAOK>> DGPXBFYSUUG<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<IXKHGZWDMFU<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C840", Offset = "0x3C0B240", VA = "0x183C0C840")]
		public static Id32<GQSCCKHWVOV> YAYOHXZZMNA<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C7B0", Offset = "0x3C0B1B0", VA = "0x183C0C7B0")]
		public static Id32<GQSCCKHWVOV> YAYOHXZZMNA<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C720", Offset = "0x3C0B120", VA = "0x183C0C720")]
		public static Id32<GQSCCKHWVOV> YAYOHXZZMNA<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AF40", Offset = "0x3C09940", VA = "0x183C0AF40")]
		public static Id32<OYXCYVSZNSL> DZULTHUJLKM<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<OYXCYVSZNSL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AFD0", Offset = "0x3C099D0", VA = "0x183C0AFD0")]
		public static Id32<OYXCYVSZNSL> DZULTHUJLKM<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<OYXCYVSZNSL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B0E0", Offset = "0x3C09AE0", VA = "0x183C0B0E0")]
		public static Id32<IUBIECDJGSA> FCISTPGXRQP<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<IUBIECDJGSA>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class FUONFSCORSE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9AE0", Offset = "0x2BA84E0", VA = "0x182BA9AE0")]
		public static void SWJZJBBAAKV(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9BA0", Offset = "0x2BA85A0", VA = "0x182BA9BA0")]
		public static void SWJZJBBAAKV(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9C10", Offset = "0x2BA8610", VA = "0x182BA9C10")]
		public static void SWJZJBBAAKV([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF7B0", Offset = "0x3AEE1B0", VA = "0x183AEF7B0")]
		public static void SWJZJBBAAKV<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF900", Offset = "0x3AEE300", VA = "0x183AEF900")]
		public static void SWJZJBBAAKV<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3E50", Offset = "0x2BA2850", VA = "0x182BA3E50")]
		public static void ITFMAKCQRFI(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2BA99E0", Offset = "0x2BA83E0", VA = "0x182BA99E0")]
		public static void ITFMAKCQRFI(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9A60", Offset = "0x2BA8460", VA = "0x182BA9A60")]
		public static void ITFMAKCQRFI([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF4F0", Offset = "0x3AEDEF0", VA = "0x183AEF4F0")]
		public static void ITFMAKCQRFI<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF550", Offset = "0x3AEDF50", VA = "0x183AEF550")]
		public static void ITFMAKCQRFI<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA99A0", Offset = "0x2BA83A0", VA = "0x182BA99A0")]
		public static void ALWLAWGXDJF(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF170", Offset = "0x3AEDB70", VA = "0x183AEF170")]
		public static void ALWLAWGXDJF<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF1E0", Offset = "0x3AEDBE0", VA = "0x183AEF1E0")]
		public static void ALWLAWGXDJF<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9C90", Offset = "0x2BA8690", VA = "0x182BA9C90")]
		public static void WTJEXMYEAUN(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFB00", Offset = "0x3AEE500", VA = "0x183AEFB00")]
		public static void WTJEXMYEAUN<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFB60", Offset = "0x3AEE560", VA = "0x183AEFB60")]
		public static void WTJEXMYEAUN<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF390", Offset = "0x3AEDD90", VA = "0x183AEF390")]
		public static void BPAXYQVHQDN<q>(this IdArray<q, byte> a, Id32<q> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF310", Offset = "0x3AEDD10", VA = "0x183AEF310")]
		public static void BPAXYQVHQDN<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF390", Offset = "0x3AEDD90", VA = "0x183AEF390")]
		public static void YEKSCATTISV<t>(this IdArray<t, byte> a, Id32<t> b, Id32<GQSCCKHWVOV> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF310", Offset = "0x3AEDD10", VA = "0x183AEF310")]
		public static void YEKSCATTISV<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<GQSCCKHWVOV> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class FSBRECRZUVP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5590", Offset = "0x2BA3F90", VA = "0x182BA5590")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) GRQWXGOASKJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7B90", Offset = "0x2BA6590", VA = "0x182BA7B90")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) SINOEXLVUJI(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5B20", Offset = "0x2BA4520", VA = "0x182BA5B20")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) IKAFSZQBHLB(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5710", Offset = "0x2BA4110", VA = "0x182BA5710")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) HBPUYIUQTEP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4920", Offset = "0x2BA3320", VA = "0x182BA4920")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) DZMWLUCEXQY(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6480", Offset = "0x2BA4E80", VA = "0x182BA6480")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MFAISFRBLCF(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4A70", Offset = "0x2BA3470", VA = "0x182BA4A70")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ECHFHLXTSGZ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4CF0", Offset = "0x2BA36F0", VA = "0x182BA4CF0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) EUHZCHUYWMK(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9160", Offset = "0x2BA7B60", VA = "0x182BA9160")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) XZTKTWJHGKT(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8B00", Offset = "0x2BA7500", VA = "0x182BA8B00")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) WSEVYTNUNDH(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9880", Offset = "0x2BA8280", VA = "0x182BA9880")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) ZQNASLNIOVI(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA88A0", Offset = "0x2BA72A0", VA = "0x182BA88A0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) VHLVCFUZBNM(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8C10", Offset = "0x2BA7610", VA = "0x182BA8C10")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) XELEKGWNSWV(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7880", Offset = "0x2BA6280", VA = "0x182BA7880")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<OYXCYVSZNSL>>) RONQUSROTPE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<OYXCYVSZNSL>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<OYXCYVSZNSL>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7770", Offset = "0x2BA6170", VA = "0x182BA7770")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<OYXCYVSZNSL>>>) RMSGTJUMMRB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IXKHGZWDMFU<OYXCYVSZNSL>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<OYXCYVSZNSL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5C40", Offset = "0x2BA4640", VA = "0x182BA5C40")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<GQSCCKHWVOV>>) IVOPVAEGJFW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GQSCCKHWVOV>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<GQSCCKHWVOV>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5DF0", Offset = "0x2BA47F0", VA = "0x182BA5DF0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<GQSCCKHWVOV>>>) JBATZAVNEAF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IXKHGZWDMFU<GQSCCKHWVOV>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<GQSCCKHWVOV>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDC30", Offset = "0x3AEC630", VA = "0x183AEDC30")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<a>>) EZWGIYNAQNF<a>(this UnsafeList<byte> a, [Optional] Id32<IUBIECDJGSA>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2BA65A0", Offset = "0x2BA4FA0", VA = "0x182BA65A0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MGCMIKUUOVF(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4F60", Offset = "0x2BA3960", VA = "0x182BA4F60")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FJFSEMHPCHK(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE030", Offset = "0x3AECA30", VA = "0x183AEE030")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<b>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<b>>) MIOIPNLESCZ<b>(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<b>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE360", Offset = "0x3AECD60", VA = "0x183AEE360")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>) VOKSXTHBLOG<c>(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<c>>? b, [Optional] Id32<IXKHGZWDMFU<c>>? c, [Optional] int? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7CE0", Offset = "0x2BA66E0", VA = "0x182BA7CE0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) SVEMGVTFFLP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2BA89B0", Offset = "0x2BA73B0", VA = "0x182BA89B0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) VJTXFPOZDRA(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6360", Offset = "0x2BA4D60", VA = "0x182BA6360")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) LWPFBOMUIST(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5310", Offset = "0x2BA3D10", VA = "0x182BA5310")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FVOFLCCKXNJ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8320", Offset = "0x2BA6D20", VA = "0x182BA8320")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) UBFROIUEOYA(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4800", Offset = "0x2BA3200", VA = "0x182BA4800")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) CVGMZFMKZFL(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5870", Offset = "0x2BA4270", VA = "0x182BA5870")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) IEEICNJQOWY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA59D0", Offset = "0x2BA43D0", VA = "0x182BA59D0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) IGUNYISFRDB(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA74F0", Offset = "0x2BA5EF0", VA = "0x182BA74F0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) QFUAXIXBYLY(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8110", Offset = "0x2BA6B10", VA = "0x182BA8110")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) TPGGIZKFHTZ(this UnsafeList<byte> a, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? b)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4160", Offset = "0x2BA2B60", VA = "0x182BA4160")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ATGMFSIIWQP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6E40", Offset = "0x2BA5840", VA = "0x182BA6E40")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) OYXYIZACOBG(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BA94B0", Offset = "0x2BA7EB0", VA = "0x182BA94B0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) YSDXEAIIYBH(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7A30", Offset = "0x2BA6430", VA = "0x182BA7A30")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) RWUOLPMGBJY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6A80", Offset = "0x2BA5480", VA = "0x182BA6A80")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MXZAOGWHIKV(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8200", Offset = "0x2BA6C00", VA = "0x182BA8200")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) UAOJHPRMFPO(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8470", Offset = "0x2BA6E70", VA = "0x182BA8470")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ULMTWYGDPJY(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7260", Offset = "0x2BA5C60", VA = "0x182BA7260")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PMRFZPQEWKV(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BA73C0", Offset = "0x2BA5DC0", VA = "0x182BA73C0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PWIFBVZUWYA(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7100", Offset = "0x2BA5B00", VA = "0x182BA7100")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PGYRCXZZYZN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6800", Offset = "0x2BA5200", VA = "0x182BA6800")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MTQPVACTBHO(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4BD0", Offset = "0x2BA35D0", VA = "0x182BA4BD0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ENRPDHLFPSB(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5070", Offset = "0x2BA3A70", VA = "0x182BA5070")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FOOVXCBWJAS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6FA0", Offset = "0x2BA59A0", VA = "0x182BA6FA0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PEZHVHYZPBT(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA66D0", Offset = "0x2BA50D0", VA = "0x182BA66D0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MODBDGYCBAE(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9000", Offset = "0x2BA7A00", VA = "0x182BA9000")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) XSWAWPHAUZF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9730", Offset = "0x2BA8130", VA = "0x182BA9730")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ZIYJTUIBDMU(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D20", Offset = "0x2BA5720", VA = "0x182BA6D20")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) NXMQGEFSXUF(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5F00", Offset = "0x2BA4900", VA = "0x182BA5F00")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) JFECNYJPAAR(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7FB0", Offset = "0x2BA69B0", VA = "0x182BA7FB0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) TJGELXCEEGC(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6950", Offset = "0x2BA5350", VA = "0x182BA6950")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MXPZFIWENYH(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2BA85F0", Offset = "0x2BA6FF0", VA = "0x182BA85F0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ULOQSHXMVXC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8750", Offset = "0x2BA7150", VA = "0x182BA8750")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) UOEWODGBYDF(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BA46E0", Offset = "0x2BA30E0", VA = "0x182BA46E0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) CNEJNDKYFMC(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8D30", Offset = "0x2BA7730", VA = "0x182BA8D30")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) XHGXTUMSTUQ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BA95E0", Offset = "0x2BA7FE0", VA = "0x182BA95E0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) ZBTACJZQHUP(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4E40", Offset = "0x2BA3840", VA = "0x182BA4E40")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) EYUQPPMSOWW(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4000", Offset = "0x2BA2A00", VA = "0x182BA4000")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) AKVNOVGYNJM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E60", Offset = "0x2BA6860", VA = "0x182BA7E60")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) SXMSTHUEQCB(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5470", Offset = "0x2BA3E70", VA = "0x182BA5470")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) GRILZIPUAQM(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA61D0", Offset = "0x2BA4BD0", VA = "0x182BA61D0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) KMKENRMZICJ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA93A0", Offset = "0x2BA7DA0", VA = "0x182BA93A0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) YJDPFVNSRYG(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA62E0", Offset = "0x2BA4CE0", VA = "0x182BA62E0")]
		public static Id32<WXKPXITHDLK<VABZENOIJNF>> KXWDEBSCRJZ(this UnsafeList<byte> a)
		{
			return default(Id32<WXKPXITHDLK<VABZENOIJNF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2BA42E0", Offset = "0x2BA2CE0", VA = "0x182BA42E0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) ATOKEPVQLXW(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6BD0", Offset = "0x2BA55D0", VA = "0x182BA6BD0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) NLWTIWFNMQP(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9280", Offset = "0x2BA7C80", VA = "0x182BA9280")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) YJAXLIRIIHY(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4460", Offset = "0x2BA2E60", VA = "0x182BA4460")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) BHYKYDUKLTU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8EB0", Offset = "0x2BA78B0", VA = "0x182BA8EB0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) XKZMCSRELAN(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2BA51F0", Offset = "0x2BA3BF0", VA = "0x182BA51F0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FQYMULIRWQA(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7610", Offset = "0x2BA6010", VA = "0x182BA7610")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) QNJLSQSKQBT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6080", Offset = "0x2BA4A80", VA = "0x182BA6080")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) JVJGNXLRVDI(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BA45C0", Offset = "0x2BA2FC0", VA = "0x182BA45C0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) BOICWFYUAWT(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
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
