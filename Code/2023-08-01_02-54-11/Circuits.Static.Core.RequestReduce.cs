using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72D1860", Offset = "0x72D0860", VA = "0x1872D1860")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB36FF0", Offset = "0xB35FF0", VA = "0x180B36FF0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct OMPFNKJBJDD<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind JOPJDPPOLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload GHKDELKCEMI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25EE710", Offset = "0x25ED710", VA = "0x1825EE710")]
	internal OMPFNKJBJDD(TActionKind HIGOJBHJPGN, in TPayload KPMKPNDNMBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KDBCOCFFMGI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13BB6C0", Offset = "0x13BA6C0", VA = "0x1813BB6C0")]
	public static OMPFNKJBJDD<TActionKind, TPayload> CECGBIGMPDN<TActionKind, TPayload>(in TActionKind HIGOJBHJPGN, in TPayload KPMKPNDNMBB)
	{
		return default(OMPFNKJBJDD<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface HCIPHKHIODL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ADCOJCAAGFK<object, OODLLKGHJOL>> DHHHMBPEINI(TDeps LGKMJKEAAMO, TRoot FMNCHFNIOHH, TSerializedAction JHBMIBCLGKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct PIAMFNLGGMG<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : BJIPGEFAIEJ.JIOCCEKLMCG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JNIPAFLJNNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<ADCOJCAAGFK<object, OODLLKGHJOL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PIAMFNLGGMG<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private ADCOJCAAGFK<object, OODLLKGHJOL> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private HCIPHKHIODL<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ADCOJCAAGFK<object, OODLLKGHJOL> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<ADCOJCAAGFK<object, OODLLKGHJOL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public JNIPAFLJNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3429710", Offset = "0x3428710", VA = "0x183429710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, HCIPHKHIODL<TSerializedAction, TRoot, TDeps>> NAKEDHFHFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps KPGBJJBPKMJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xB2E3C0", Offset = "0xB2D3C0", VA = "0x180B2E3C0")]
	internal PIAMFNLGGMG(Dictionary<TActionKind, HCIPHKHIODL<TSerializedAction, TRoot, TDeps>> EFIKOBCMEOO, TDeps LGKMJKEAAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E2D0", Offset = "0x1E6D2D0", VA = "0x181E6E2D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIAMFNLGGMG<, , , >.JNIPAFLJNNN))]
	public Task<ADCOJCAAGFK<object, OODLLKGHJOL>> DHHHMBPEINI(TRoot FMNCHFNIOHH, TSerializedAction JHBMIBCLGKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BJIPGEFAIEJ
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface JIOCCEKLMCG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind HNDECLACONN(TSerializedAction DPHICODLGJD);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ODFKHAODJAA(TRoot FMNCHFNIOHH, TSerializedAction NPNCNABHINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2626C60", Offset = "0x2625C60", VA = "0x182626C60")]
	internal static PIAMFNLGGMG<TActionKind, TSerializedAction, TRoot, TDeps> CECGBIGMPDN<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, HCIPHKHIODL<TSerializedAction, TRoot, TDeps>> EFIKOBCMEOO, TDeps LGKMJKEAAMO) where TDeps : JIOCCEKLMCG<TActionKind, TSerializedAction, TRoot>
	{
		return default(PIAMFNLGGMG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate ADCOJCAAGFK<TOk, TErr> LMENNMBIPIE<TRoot, TPayload, TOk, TErr>(TRoot FMNCHFNIOHH, in TPayload KPMKPNDNMBB);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class FFGDBDGPBLK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, HCIPHKHIODL<TSerializedAction, TRoot, TDeps>> OBKODDNPHLG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xEDE1E0", Offset = "0xEDD1E0", VA = "0x180EDE1E0")]
	private FFGDBDGPBLK(Dictionary<TActionKind, HCIPHKHIODL<TSerializedAction, TRoot, TDeps>> EFIKOBCMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F01CF0", Offset = "0x1F00CF0", VA = "0x181F01CF0")]
	public static FFGDBDGPBLK<TActionKind, TSerializedAction, TRoot, TDeps> CECGBIGMPDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<ADCOJCAAGFK<TOk, TErr>> LPAJFOBNEBK<TRoot, TPayload, TOk, TErr>(TRoot FMNCHFNIOHH, TPayload KPMKPNDNMBB);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class BGFGCFCOJNO<TActionKind, TSerializedAction, TRoot, TDeps> : FBIODNBOINH where TDeps : BJIPGEFAIEJ.JIOCCEKLMCG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps KPGBJJBPKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction MADLDDBCBMO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E01950", Offset = "0x3E00950", VA = "0x183E01950")]
	public BGFGCFCOJNO(in TDeps LGKMJKEAAMO, in TSerializedAction JHBMIBCLGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E01730", Offset = "0x3E00730", VA = "0x183E01730", Slot = "7")]
	public override string OCMKCNKAONG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate OMPFNKJBJDD<TActionKind, TPayload> CPLGOKHPGML<TActionKind, TSerializedAction, TPayload>(TSerializedAction JHBMIBCLGKJ);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GJGDLJCILFA<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, BJIPGEFAIEJ.JIOCCEKLMCG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class JBNBINNCGKF<TPayload, TOk, TErr> : HCIPHKHIODL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OODLLKGHJOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CPLGOKHPGML<TActionKind, TSerializedAction, TPayload> GDGMLIKODNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly LMENNMBIPIE<TRoot, TPayload, TOk, TErr> MKCFAEIGGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool HLHOPJOIEJD;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD7F0", Offset = "0x2CDC7F0", VA = "0x182CDD7F0")]
		public JBNBINNCGKF(CPLGOKHPGML<TActionKind, TSerializedAction, TPayload> MFFDCCNILIF, LMENNMBIPIE<TRoot, TPayload, TOk, TErr> OFJKCANJFKI, bool BEPHIJJLLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39B7FD0", Offset = "0x39B6FD0", VA = "0x1839B7FD0", Slot = "4")]
		public Task<ADCOJCAAGFK<object, OODLLKGHJOL>> DHHHMBPEINI(TDeps LGKMJKEAAMO, TRoot FMNCHFNIOHH, TSerializedAction JHBMIBCLGKJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CCDCDBMAJMP<TPayload, TOk, TErr> : HCIPHKHIODL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OODLLKGHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MFMIAOFKFMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x783B70", Offset = "0x782F70")]
			public AsyncTaskMethodBuilder<ADCOJCAAGFK<object, OODLLKGHJOL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public CCDCDBMAJMP<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x783BD0", Offset = "0x782FD0")]
			private ADCOJCAAGFK<object, OODLLKGHJOL> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x783C30", Offset = "0x783030")]
			private OMPFNKJBJDD<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x783C90", Offset = "0x783090")]
			private ADCOJCAAGFK<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x783CF0", Offset = "0x7830F0")]
			private ADCOJCAAGFK<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x783D50", Offset = "0x783150")]
			private TaskAwaiter<ADCOJCAAGFK<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
			public MFMIAOFKFMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x29DF7A0", Offset = "0x29DE7A0", VA = "0x1829DF7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly CPLGOKHPGML<TActionKind, TSerializedAction, TPayload> GDGMLIKODNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly LPAJFOBNEBK<TRoot, TPayload, TOk, TErr> MKCFAEIGGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool HLHOPJOIEJD;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD7F0", Offset = "0x2CDC7F0", VA = "0x182CDD7F0")]
		public CCDCDBMAJMP(CPLGOKHPGML<TActionKind, TSerializedAction, TPayload> MFFDCCNILIF, LPAJFOBNEBK<TRoot, TPayload, TOk, TErr> OFJKCANJFKI, bool BEPHIJJLLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD250", Offset = "0x2CDC250", VA = "0x182CDD250", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CCDCDBMAJMP<, , >.MFMIAOFKFMO))]
		public Task<ADCOJCAAGFK<object, OODLLKGHJOL>> DHHHMBPEINI(TDeps LGKMJKEAAMO, TRoot FMNCHFNIOHH, TSerializedAction JHBMIBCLGKJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FFGDBDGPBLK<TActionKind, TSerializedAction, TRoot, TDeps> GPOMDHAFGMJ;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA9F760", Offset = "0xA9E760", VA = "0x180A9F760")]
	private GJGDLJCILFA(FFGDBDGPBLK<TActionKind, TSerializedAction, TRoot, TDeps> HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3441FD0", Offset = "0x3440FD0", VA = "0x183441FD0")]
	public static GJGDLJCILFA<TActionKind, TSerializedAction, TRoot, TDeps> CECGBIGMPDN()
	{
		return default(GJGDLJCILFA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1D8CAD0", Offset = "0x1D8BAD0", VA = "0x181D8CAD0")]
	public GJGDLJCILFA<TActionKind, TSerializedAction, TRoot, TDeps> CNPOALDDFOC<TPayload, TOk, TErr>(TActionKind HIGOJBHJPGN, CPLGOKHPGML<TActionKind, TSerializedAction, TPayload> MFFDCCNILIF, LMENNMBIPIE<TRoot, TPayload, TOk, TErr> OFJKCANJFKI, bool BEPHIJJLLBL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OODLLKGHJOL
	{
		return default(GJGDLJCILFA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D8CAD0", Offset = "0x1D8BAD0", VA = "0x181D8CAD0")]
	public GJGDLJCILFA<TActionKind, TSerializedAction, TRoot, TDeps> LBMDJKKEACG<TPayload, TOk, TErr>(TActionKind HIGOJBHJPGN, CPLGOKHPGML<TActionKind, TSerializedAction, TPayload> MFFDCCNILIF, LPAJFOBNEBK<TRoot, TPayload, TOk, TErr> OFJKCANJFKI, bool BEPHIJJLLBL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OODLLKGHJOL
	{
		return default(GJGDLJCILFA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3441F20", Offset = "0x3440F20", VA = "0x183441F20")]
	public PIAMFNLGGMG<TActionKind, TSerializedAction, TRoot, TDeps> BJFHGMFDOEI(TDeps LGKMJKEAAMO)
	{
		return default(PIAMFNLGGMG<TActionKind, TSerializedAction, TRoot, TDeps>);
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
