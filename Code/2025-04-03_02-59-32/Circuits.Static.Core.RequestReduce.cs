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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x269C420", Offset = "0x269B820", VA = "0x18269C420")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate ENCDLLFOBMH<TActionKind, TPayload> OINLNLLGAJK<TActionKind, TSerializedAction, TPayload>(TSerializedAction GNNMNAEBBHP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GAHMLPKFCNM<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> NBEBOJADJAF(TDeps OHJFEHDLOHB, TRoot BKHMOJGGBFN, TSerializedAction GNNMNAEBBHP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OCOLFAPDPJB<TActionKind, TSerializedAction, TRoot, TDeps> : IOLFOONCHKI where TDeps : KLOPJJFPPNK.OEAIGBPOPBO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps AMCNMNPOCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction PELDLAIGMGG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x51DE000", Offset = "0x51DD400", VA = "0x1851DE000")]
	public OCOLFAPDPJB([In] TDeps OHJFEHDLOHB, [In] TSerializedAction GNNMNAEBBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x51DDDE0", Offset = "0x51DD1E0", VA = "0x1851DDDE0", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ENCDLLFOBMH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GLGDPDFCHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload AJILNNFMGGD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x42D9A60", Offset = "0x42D8E60", VA = "0x1842D9A60")]
	internal ENCDLLFOBMH(TActionKind AFKOOLJCMNH, [In] TPayload DMDJHNIAOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JNGJFCMIFNK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x367E250", Offset = "0x367D650", VA = "0x18367E250")]
	public static ENCDLLFOBMH<TActionKind, TPayload> HBLBJMFGHFK<TActionKind, TPayload>([In] TActionKind AFKOOLJCMNH, [In] TPayload DMDJHNIAOJN)
	{
		return default(ENCDLLFOBMH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<KGPHFOFOMPJ<TOk, TErr>> AGBECACOKNH<TRoot, TPayload, TOk, TErr>(TRoot BKHMOJGGBFN, TPayload DMDJHNIAOJN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate KGPHFOFOMPJ<TOk, TErr> KNEJLKMLBAB<TRoot, TPayload, TOk, TErr>(TRoot BKHMOJGGBFN, [In] TPayload DMDJHNIAOJN);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LAHKIFIDPBB<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : KLOPJJFPPNK.OEAIGBPOPBO<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LKLHNAEKFDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LAHKIFIDPBB<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<KGPHFOFOMPJ<object, HEGOEPNOLEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4E45F50", Offset = "0x4E45350", VA = "0x184E45F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E46380", Offset = "0x4E45780", VA = "0x184E46380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, GAHMLPKFCNM<TSerializedAction, TRoot, TDeps>> NNFLPPEOGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps AMCNMNPOCHO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
	internal LAHKIFIDPBB(Dictionary<TActionKind, GAHMLPKFCNM<TSerializedAction, TRoot, TDeps>> FDEDIBKCNIF, TDeps OHJFEHDLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E15390", Offset = "0x4E14790", VA = "0x184E15390")]
	[AsyncStateMachine(typeof(LAHKIFIDPBB<, , , >.LKLHNAEKFDN))]
	public Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> NBEBOJADJAF(TRoot BKHMOJGGBFN, TSerializedAction GNNMNAEBBHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KLOPJJFPPNK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OEAIGBPOPBO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DMEFMDBKELA(TSerializedAction JOCJBPPJMJJ);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CGGLILCMDLP(TRoot BKHMOJGGBFN, TSerializedAction IOPCFKOHPBF);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void POJCCKLONCH(TRoot BKHMOJGGBFN, TSerializedAction IOPCFKOHPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x33ED1F0", Offset = "0x33EC5F0", VA = "0x1833ED1F0")]
	internal static LAHKIFIDPBB<TActionKind, TSerializedAction, TRoot, TDeps> HBLBJMFGHFK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GAHMLPKFCNM<TSerializedAction, TRoot, TDeps>> FDEDIBKCNIF, TDeps OHJFEHDLOHB) where TDeps : OEAIGBPOPBO<TActionKind, TSerializedAction, TRoot>
	{
		return default(LAHKIFIDPBB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KNPHHMMCNEO<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, GAHMLPKFCNM<TSerializedAction, TRoot, TDeps>> BHLGOEPIJCG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	private KNPHHMMCNEO(Dictionary<TActionKind, GAHMLPKFCNM<TSerializedAction, TRoot, TDeps>> FDEDIBKCNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D925E0", Offset = "0x4D919E0", VA = "0x184D925E0")]
	public static KNPHHMMCNEO<TActionKind, TSerializedAction, TRoot, TDeps> HBLBJMFGHFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DNNLPNOLHBJ<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, KLOPJJFPPNK.OEAIGBPOPBO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class GPHPHPNKGIP<TPayload, TOk, TErr> : GAHMLPKFCNM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HEGOEPNOLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OINLNLLGAJK<TActionKind, TSerializedAction, TPayload> ALNIOCJDBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KNEJLKMLBAB<TRoot, TPayload, TOk, TErr> JADDIBEKKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool LJOEGMFNLCP;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x18714B0", Offset = "0x18708B0", VA = "0x1818714B0")]
		public GPHPHPNKGIP(OINLNLLGAJK<TActionKind, TSerializedAction, TPayload> OCINOJFBHFA, KNEJLKMLBAB<TRoot, TPayload, TOk, TErr> FCBMAAMGOHP, bool PEHOHDIAHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x486C060", Offset = "0x486B460", VA = "0x18486C060", Slot = "4")]
		public Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> NBEBOJADJAF(TDeps OHJFEHDLOHB, TRoot BKHMOJGGBFN, TSerializedAction GNNMNAEBBHP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GEGANOGIINC<TPayload, TOk, TErr> : GAHMLPKFCNM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HEGOEPNOLEN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct AMNIMAAJFGD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<KGPHFOFOMPJ<object?, HEGOEPNOLEN>> <>t__builder;

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
			public GEGANOGIINC<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private KGPHFOFOMPJ<object?, HEGOEPNOLEN> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<KGPHFOFOMPJ<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4A1E380", Offset = "0x4A1D780", VA = "0x184A1E380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4A1F400", Offset = "0x4A1E800", VA = "0x184A1F400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OINLNLLGAJK<TActionKind, TSerializedAction, TPayload> ALNIOCJDBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly AGBECACOKNH<TRoot, TPayload, TOk, TErr> JADDIBEKKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool LJOEGMFNLCP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x18714B0", Offset = "0x18708B0", VA = "0x1818714B0")]
		public GEGANOGIINC(OINLNLLGAJK<TActionKind, TSerializedAction, TPayload> OCINOJFBHFA, AGBECACOKNH<TRoot, TPayload, TOk, TErr> FCBMAAMGOHP, bool PEHOHDIAHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4831CD0", Offset = "0x48310D0", VA = "0x184831CD0", Slot = "4")]
		[AsyncStateMachine(typeof(GEGANOGIINC<, , >.AMNIMAAJFGD))]
		public Task<KGPHFOFOMPJ<object, HEGOEPNOLEN>> NBEBOJADJAF(TDeps OHJFEHDLOHB, TRoot BKHMOJGGBFN, TSerializedAction GNNMNAEBBHP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KNPHHMMCNEO<TActionKind, TSerializedAction, TRoot, TDeps> HFHDNFLLMDB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
	private DNNLPNOLHBJ(KNPHHMMCNEO<TActionKind, TSerializedAction, TRoot, TDeps> HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x66959D0", Offset = "0x6694DD0", VA = "0x1866959D0")]
	public static DNNLPNOLHBJ<TActionKind, TSerializedAction, TRoot, TDeps> HBLBJMFGHFK()
	{
		return default(DNNLPNOLHBJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A5DA20", Offset = "0x3A5CE20", VA = "0x183A5DA20")]
	public DNNLPNOLHBJ<TActionKind, TSerializedAction, TRoot, TDeps> PPBMDIFAFHO<TPayload, TOk, TErr>(TActionKind AFKOOLJCMNH, OINLNLLGAJK<TActionKind, TSerializedAction, TPayload> OCINOJFBHFA, KNEJLKMLBAB<TRoot, TPayload, TOk, TErr> FCBMAAMGOHP, bool PEHOHDIAHIO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HEGOEPNOLEN
	{
		return default(DNNLPNOLHBJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A5DA20", Offset = "0x3A5CE20", VA = "0x183A5DA20")]
	public DNNLPNOLHBJ<TActionKind, TSerializedAction, TRoot, TDeps> AKEJFNOBPHP<TPayload, TOk, TErr>(TActionKind AFKOOLJCMNH, OINLNLLGAJK<TActionKind, TSerializedAction, TPayload> OCINOJFBHFA, AGBECACOKNH<TRoot, TPayload, TOk, TErr> FCBMAAMGOHP, bool PEHOHDIAHIO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HEGOEPNOLEN
	{
		return default(DNNLPNOLHBJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6695A70", Offset = "0x6694E70", VA = "0x186695A70")]
	public LAHKIFIDPBB<TActionKind, TSerializedAction, TRoot, TDeps> NJIDHPODGEN(TDeps OHJFEHDLOHB)
	{
		return default(LAHKIFIDPBB<TActionKind, TSerializedAction, TRoot, TDeps>);
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
