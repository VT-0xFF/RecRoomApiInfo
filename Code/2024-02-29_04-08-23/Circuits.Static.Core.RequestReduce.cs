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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D95140", Offset = "0x1D93F40", VA = "0x181D95140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate IDHAJELEGOB<TActionKind, TPayload> OBIFDNFOBEK<TActionKind, TSerializedAction, TPayload>(TSerializedAction GEMBHKNKAAM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface DPMNCKMEPEL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> FPLCDEOCDCK(TDeps DNHMNAAINOD, TRoot ADCDJFADKCK, TSerializedAction GEMBHKNKAAM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class GLPLAMGPHCK<TActionKind, TSerializedAction, TRoot, TDeps> : AGGGGDAGIKE where TDeps : LKOCHJGKODG.CNIKFMHFKKB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps PHADKJKPPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction OBENBEAJNHL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36CF8D0", Offset = "0x36CE6D0", VA = "0x1836CF8D0")]
	public GLPLAMGPHCK([In] TDeps DNHMNAAINOD, [In] TSerializedAction GEMBHKNKAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36CF6A0", Offset = "0x36CE4A0", VA = "0x1836CF6A0", Slot = "7")]
	public override string EMIBBFOKDML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IDHAJELEGOB<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DCAMJGEDHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BPEOKKBCIKN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3846A90", Offset = "0x3845890", VA = "0x183846A90")]
	internal IDHAJELEGOB(TActionKind IDCLCEKFGBN, [In] TPayload FCMJAHOHNCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FFMELLGLBJL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26E4320", Offset = "0x26E3120", VA = "0x1826E4320")]
	public static IDHAJELEGOB<TActionKind, TPayload> KJKFMOENPNA<TActionKind, TPayload>([In] TActionKind IDCLCEKFGBN, [In] TPayload FCMJAHOHNCO)
	{
		return default(IDHAJELEGOB<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<FBEPHKHKLJE<TOk, TErr>> HADDMCPIKPL<TRoot, TPayload, TOk, TErr>(TRoot ADCDJFADKCK, TPayload FCMJAHOHNCO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate FBEPHKHKLJE<TOk, TErr> FBGDJPINEMA<TRoot, TPayload, TOk, TErr>(TRoot ADCDJFADKCK, [In] TPayload FCMJAHOHNCO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GINCPANCIHD<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LKOCHJGKODG.CNIKFMHFKKB<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BAILOGCKMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GINCPANCIHD<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x464C6A0", Offset = "0x464B4A0", VA = "0x18464C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x464CB90", Offset = "0x464B990", VA = "0x18464CB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, DPMNCKMEPEL<TSerializedAction, TRoot, TDeps>> PDOMEEMJBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps PHADKJKPPMM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x89F0F0", Offset = "0x89DEF0", VA = "0x18089F0F0")]
	internal GINCPANCIHD(Dictionary<TActionKind, DPMNCKMEPEL<TSerializedAction, TRoot, TDeps>> BAJIGDGPHND, TDeps DNHMNAAINOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36C6440", Offset = "0x36C5240", VA = "0x1836C6440")]
	[AsyncStateMachine(typeof(GINCPANCIHD<, , , >.BAILOGCKMDI))]
	public Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> FPLCDEOCDCK(TRoot ADCDJFADKCK, TSerializedAction GEMBHKNKAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LKOCHJGKODG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CNIKFMHFKKB<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind AJEDKLCPAHO(TSerializedAction CNFBJPGPBBJ);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FIPNDFIAHNG(TRoot ADCDJFADKCK, TSerializedAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JNCOLNCHJCH(TRoot ADCDJFADKCK, TSerializedAction ENHEBPDFNME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26E4050", Offset = "0x26E2E50", VA = "0x1826E4050")]
	internal static GINCPANCIHD<TActionKind, TSerializedAction, TRoot, TDeps> KJKFMOENPNA<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, DPMNCKMEPEL<TSerializedAction, TRoot, TDeps>> BAJIGDGPHND, TDeps DNHMNAAINOD) where TDeps : CNIKFMHFKKB<TActionKind, TSerializedAction, TRoot>
	{
		return default(GINCPANCIHD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KPAKGKDIOMF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, DPMNCKMEPEL<TSerializedAction, TRoot, TDeps>> OHBOGNGIHIA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	private KPAKGKDIOMF(Dictionary<TActionKind, DPMNCKMEPEL<TSerializedAction, TRoot, TDeps>> BAJIGDGPHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B17A80", Offset = "0x3B16880", VA = "0x183B17A80")]
	public static KPAKGKDIOMF<TActionKind, TSerializedAction, TRoot, TDeps> KJKFMOENPNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BOCBPIMJLDE<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LKOCHJGKODG.CNIKFMHFKKB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KHIBILKPCPJ<TPayload, TOk, TErr> : DPMNCKMEPEL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BEPKJMJJJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OBIFDNFOBEK<TActionKind, TSerializedAction, TPayload> BGGCECAJPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly FBGDJPINEMA<TRoot, TPayload, TOk, TErr> BCGELFFGHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool OEHLAOEMANL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3D70", Offset = "0x3AB2B70", VA = "0x183AB3D70")]
		public KHIBILKPCPJ(OBIFDNFOBEK<TActionKind, TSerializedAction, TPayload> IDGGCLCDDLC, FBGDJPINEMA<TRoot, TPayload, TOk, TErr> FCEKPIIJGEN, bool EAICPGDBFHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AB19D0", Offset = "0x3AB07D0", VA = "0x183AB19D0", Slot = "4")]
		public Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> FPLCDEOCDCK(TDeps DNHMNAAINOD, TRoot ADCDJFADKCK, TSerializedAction GEMBHKNKAAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LKCFCACEHDL<TPayload, TOk, TErr> : DPMNCKMEPEL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BEPKJMJJJMM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct OOOFGAIBIDN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<object?, BEPKJMJJJMM>> <>t__builder;

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
			public LKCFCACEHDL<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private FBEPHKHKLJE<object?, BEPKJMJJJMM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<FBEPHKHKLJE<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3F89AC0", Offset = "0x3F888C0", VA = "0x183F89AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3F8B8E0", Offset = "0x3F8A6E0", VA = "0x183F8B8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OBIFDNFOBEK<TActionKind, TSerializedAction, TPayload> BGGCECAJPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HADDMCPIKPL<TRoot, TPayload, TOk, TErr> BCGELFFGHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool OEHLAOEMANL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3D70", Offset = "0x3AB2B70", VA = "0x183AB3D70")]
		public LKCFCACEHDL(OBIFDNFOBEK<TActionKind, TSerializedAction, TPayload> IDGGCLCDDLC, HADDMCPIKPL<TRoot, TPayload, TOk, TErr> FCEKPIIJGEN, bool EAICPGDBFHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC140", Offset = "0x3BFAF40", VA = "0x183BFC140", Slot = "4")]
		[AsyncStateMachine(typeof(LKCFCACEHDL<, , >.OOOFGAIBIDN))]
		public Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> FPLCDEOCDCK(TDeps DNHMNAAINOD, TRoot ADCDJFADKCK, TSerializedAction GEMBHKNKAAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KPAKGKDIOMF<TActionKind, TSerializedAction, TRoot, TDeps> ADFGBCCJBAP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	private BOCBPIMJLDE(KPAKGKDIOMF<TActionKind, TSerializedAction, TRoot, TDeps> OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x46BF0E0", Offset = "0x46BDEE0", VA = "0x1846BF0E0")]
	public static BOCBPIMJLDE<TActionKind, TSerializedAction, TRoot, TDeps> KJKFMOENPNA()
	{
		return default(BOCBPIMJLDE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F57760", Offset = "0x2F56560", VA = "0x182F57760")]
	public BOCBPIMJLDE<TActionKind, TSerializedAction, TRoot, TDeps> JMGLDLLPALP<TPayload, TOk, TErr>(TActionKind IDCLCEKFGBN, OBIFDNFOBEK<TActionKind, TSerializedAction, TPayload> IDGGCLCDDLC, FBGDJPINEMA<TRoot, TPayload, TOk, TErr> FCEKPIIJGEN, bool EAICPGDBFHC = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BEPKJMJJJMM
	{
		return default(BOCBPIMJLDE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F57760", Offset = "0x2F56560", VA = "0x182F57760")]
	public BOCBPIMJLDE<TActionKind, TSerializedAction, TRoot, TDeps> AOGNNAHHPPO<TPayload, TOk, TErr>(TActionKind IDCLCEKFGBN, OBIFDNFOBEK<TActionKind, TSerializedAction, TPayload> IDGGCLCDDLC, HADDMCPIKPL<TRoot, TPayload, TOk, TErr> FCEKPIIJGEN, bool EAICPGDBFHC = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BEPKJMJJJMM
	{
		return default(BOCBPIMJLDE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x46BF030", Offset = "0x46BDE30", VA = "0x1846BF030")]
	public GINCPANCIHD<TActionKind, TSerializedAction, TRoot, TDeps> HICJPHFMNJJ(TDeps DNHMNAAINOD)
	{
		return default(GINCPANCIHD<TActionKind, TSerializedAction, TRoot, TDeps>);
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
