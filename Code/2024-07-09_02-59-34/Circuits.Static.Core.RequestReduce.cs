using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FF02B0", Offset = "0x1FEEEB0", VA = "0x181FF02B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate KIHKAALOEMO<TActionKind, TPayload> AAKPOBJHCPB<TActionKind, TSerializedAction, TPayload>(TSerializedAction DDLCLBBEHCM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface LPLPOAKMACC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NLDGPBPIIJN<object, MFMODGJHEIL>> DPGHPNGDBLH(TDeps EIDBKEEIBKK, TRoot LNPGMAMPBAC, TSerializedAction DDLCLBBEHCM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LOOHIBMFJAF<TActionKind, TSerializedAction, TRoot, TDeps> : BCBJAFAHBED where TDeps : EGFFNDEANCI.NEILCCAIIPG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps PLLBOMGPHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction EBPGHGCDPJC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4291BC0", Offset = "0x42907C0", VA = "0x184291BC0")]
	public LOOHIBMFJAF([In] TDeps EIDBKEEIBKK, [In] TSerializedAction DDLCLBBEHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x42919F0", Offset = "0x42905F0", VA = "0x1842919F0", Slot = "7")]
	public override string FGIPLPDCCEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KIHKAALOEMO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind EBFPCDHFLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload NPFFALIFFEJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x41B0310", Offset = "0x41AEF10", VA = "0x1841B0310")]
	internal KIHKAALOEMO(TActionKind GOLHNKLLMEL, [In] TPayload BHGBMMFNCAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PBLMLBADBIC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE5F0", Offset = "0x2CDD1F0", VA = "0x182CDE5F0")]
	public static KIHKAALOEMO<TActionKind, TPayload> FCDPFGJNKNI<TActionKind, TPayload>([In] TActionKind GOLHNKLLMEL, [In] TPayload BHGBMMFNCAD)
	{
		return default(KIHKAALOEMO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<NLDGPBPIIJN<TOk, TErr>> HAAOCKPJCFP<TRoot, TPayload, TOk, TErr>(TRoot LNPGMAMPBAC, TPayload BHGBMMFNCAD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate NLDGPBPIIJN<TOk, TErr> CIGEEIFHABD<TRoot, TPayload, TOk, TErr>(TRoot LNPGMAMPBAC, [In] TPayload BHGBMMFNCAD);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CJGFMHCFEOM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : EGFFNDEANCI.NEILCCAIIPG<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HMNEHBDAFNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CJGFMHCFEOM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4CC0", Offset = "0x3DE38C0", VA = "0x183DE4CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5540", Offset = "0x3DE4140", VA = "0x183DE5540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, LPLPOAKMACC<TSerializedAction, TRoot, TDeps>> EDCEJNCDAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps PLLBOMGPHPP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	internal CJGFMHCFEOM(Dictionary<TActionKind, LPLPOAKMACC<TSerializedAction, TRoot, TDeps>> OCLOBAFPLFE, TDeps EIDBKEEIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x56745D0", Offset = "0x56731D0", VA = "0x1856745D0")]
	[AsyncStateMachine(typeof(CJGFMHCFEOM<, , , >.HMNEHBDAFNI))]
	public Task<NLDGPBPIIJN<object, MFMODGJHEIL>> DPGHPNGDBLH(TRoot LNPGMAMPBAC, TSerializedAction DDLCLBBEHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EGFFNDEANCI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NEILCCAIIPG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind JCBOPKMJJBK(TSerializedAction ENEDBNLKLJL);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AABNMKHDLHK(TRoot LNPGMAMPBAC, TSerializedAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OCNADHOACLL(TRoot LNPGMAMPBAC, TSerializedAction OBNFAOABLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29E00C0", Offset = "0x29DECC0", VA = "0x1829E00C0")]
	internal static CJGFMHCFEOM<TActionKind, TSerializedAction, TRoot, TDeps> FCDPFGJNKNI<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, LPLPOAKMACC<TSerializedAction, TRoot, TDeps>> OCLOBAFPLFE, TDeps EIDBKEEIBKK) where TDeps : NEILCCAIIPG<TActionKind, TSerializedAction, TRoot>
	{
		return default(CJGFMHCFEOM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NPKGKJNGPMH<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, LPLPOAKMACC<TSerializedAction, TRoot, TDeps>> EGKFBEPLILO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	private NPKGKJNGPMH(Dictionary<TActionKind, LPLPOAKMACC<TSerializedAction, TRoot, TDeps>> OCLOBAFPLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x453B330", Offset = "0x4539F30", VA = "0x18453B330")]
	public static NPKGKJNGPMH<TActionKind, TSerializedAction, TRoot, TDeps> FCDPFGJNKNI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FECEGHFEDAM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, EGFFNDEANCI.NEILCCAIIPG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LGIBEBHLLBN<TPayload, TOk, TErr> : LPLPOAKMACC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MFMODGJHEIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AAKPOBJHCPB<TActionKind, TSerializedAction, TPayload> LEMFJOAGEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CIGEEIFHABD<TRoot, TPayload, TOk, TErr> IKMGKLKNLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool GGPFHFAEEEJ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2450", Offset = "0x3DE1050", VA = "0x183DE2450")]
		public LGIBEBHLLBN(AAKPOBJHCPB<TActionKind, TSerializedAction, TPayload> NHLFBBEONGK, CIGEEIFHABD<TRoot, TPayload, TOk, TErr> ANBLNPMGCNM, bool EFEJFAKAANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4264510", Offset = "0x4263110", VA = "0x184264510", Slot = "4")]
		public Task<NLDGPBPIIJN<object, MFMODGJHEIL>> DPGHPNGDBLH(TDeps EIDBKEEIBKK, TRoot LNPGMAMPBAC, TSerializedAction DDLCLBBEHCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HLOPLJDJPJK<TPayload, TOk, TErr> : LPLPOAKMACC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MFMODGJHEIL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JHFFMHNGDGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<NLDGPBPIIJN<object?, MFMODGJHEIL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HLOPLJDJPJK<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private NLDGPBPIIJN<object?, MFMODGJHEIL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<NLDGPBPIIJN<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4093A40", Offset = "0x4092640", VA = "0x184093A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40948B0", Offset = "0x40934B0", VA = "0x1840948B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AAKPOBJHCPB<TActionKind, TSerializedAction, TPayload> LEMFJOAGEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HAAOCKPJCFP<TRoot, TPayload, TOk, TErr> IKMGKLKNLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool GGPFHFAEEEJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2450", Offset = "0x3DE1050", VA = "0x183DE2450")]
		public HLOPLJDJPJK(AAKPOBJHCPB<TActionKind, TSerializedAction, TPayload> NHLFBBEONGK, HAAOCKPJCFP<TRoot, TPayload, TOk, TErr> ANBLNPMGCNM, bool EFEJFAKAANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2030", Offset = "0x3DE0C30", VA = "0x183DE2030", Slot = "4")]
		[AsyncStateMachine(typeof(HLOPLJDJPJK<, , >.JHFFMHNGDGF))]
		public Task<NLDGPBPIIJN<object, MFMODGJHEIL>> DPGHPNGDBLH(TDeps EIDBKEEIBKK, TRoot LNPGMAMPBAC, TSerializedAction DDLCLBBEHCM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NPKGKJNGPMH<TActionKind, TSerializedAction, TRoot, TDeps> LIOJMKFGCMB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	private FECEGHFEDAM(NPKGKJNGPMH<TActionKind, TSerializedAction, TRoot, TDeps> JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C108C0", Offset = "0x3C0F4C0", VA = "0x183C108C0")]
	public static FECEGHFEDAM<TActionKind, TSerializedAction, TRoot, TDeps> FCDPFGJNKNI()
	{
		return default(FECEGHFEDAM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2A79CB0", Offset = "0x2A788B0", VA = "0x182A79CB0")]
	public FECEGHFEDAM<TActionKind, TSerializedAction, TRoot, TDeps> FGICPIBAPAP<TPayload, TOk, TErr>(TActionKind GOLHNKLLMEL, AAKPOBJHCPB<TActionKind, TSerializedAction, TPayload> NHLFBBEONGK, CIGEEIFHABD<TRoot, TPayload, TOk, TErr> ANBLNPMGCNM, bool EFEJFAKAANM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MFMODGJHEIL
	{
		return default(FECEGHFEDAM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2A79CB0", Offset = "0x2A788B0", VA = "0x182A79CB0")]
	public FECEGHFEDAM<TActionKind, TSerializedAction, TRoot, TDeps> CFJFMPCCHIM<TPayload, TOk, TErr>(TActionKind GOLHNKLLMEL, AAKPOBJHCPB<TActionKind, TSerializedAction, TPayload> NHLFBBEONGK, HAAOCKPJCFP<TRoot, TPayload, TOk, TErr> ANBLNPMGCNM, bool EFEJFAKAANM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MFMODGJHEIL
	{
		return default(FECEGHFEDAM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C10800", Offset = "0x3C0F400", VA = "0x183C10800")]
	public CJGFMHCFEOM<TActionKind, TSerializedAction, TRoot, TDeps> BNKOHBOJIFP(TDeps EIDBKEEIBKK)
	{
		return default(CJGFMHCFEOM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
