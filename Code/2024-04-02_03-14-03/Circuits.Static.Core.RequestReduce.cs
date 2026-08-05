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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E08430", Offset = "0x1E07030", VA = "0x181E08430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate ILHAJEBFGOI<TActionKind, TPayload> EGOJFKNDMJJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction HLNKBJDOFDL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GLEDKBMJBEC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> ECDNJKDACHL(TDeps BNNGNHILECN, TRoot EBCHPMPLBLG, TSerializedAction HLNKBJDOFDL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IPNJDPIMGCD<TActionKind, TSerializedAction, TRoot, TDeps> : PGJMJGCIBHB where TDeps : KBCJMJJCBAG.DCMBHPCGLIG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps AJFJAGOPOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction AFJMEHBKPLO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x396A8B0", Offset = "0x39694B0", VA = "0x18396A8B0")]
	public IPNJDPIMGCD([In] TDeps BNNGNHILECN, [In] TSerializedAction HLNKBJDOFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x396A680", Offset = "0x3969280", VA = "0x18396A680", Slot = "7")]
	public override string HJJFPLKFILC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ILHAJEBFGOI<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind CPIEOEABPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload PLDHPPGLGFF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39512E0", Offset = "0x394FEE0", VA = "0x1839512E0")]
	internal ILHAJEBFGOI(TActionKind FGNCENMPDIH, [In] TPayload FGGJAKAMDOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KONKDIPJBAP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x285A020", Offset = "0x2858C20", VA = "0x18285A020")]
	public static ILHAJEBFGOI<TActionKind, TPayload> CIGBOGDFGOD<TActionKind, TPayload>([In] TActionKind FGNCENMPDIH, [In] TPayload FGGJAKAMDOE)
	{
		return default(ILHAJEBFGOI<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<DGKNLHNBBJB<TOk, TErr>> KHENBHIAPAD<TRoot, TPayload, TOk, TErr>(TRoot EBCHPMPLBLG, TPayload FGGJAKAMDOE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate DGKNLHNBBJB<TOk, TErr> GKHENPEIJKM<TRoot, TPayload, TOk, TErr>(TRoot EBCHPMPLBLG, [In] TPayload FGGJAKAMDOE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OMHOEMCOFLL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : KBCJMJJCBAG.DCMBHPCGLIG<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JBALPNLHENO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public OMHOEMCOFLL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1200", Offset = "0x3ADFE00", VA = "0x183AE1200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1AA0", Offset = "0x3AE06A0", VA = "0x183AE1AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, GLEDKBMJBEC<TSerializedAction, TRoot, TDeps>> BDENGAGHAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps AJFJAGOPOOC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x902320", Offset = "0x900F20", VA = "0x180902320")]
	internal OMHOEMCOFLL(Dictionary<TActionKind, GLEDKBMJBEC<TSerializedAction, TRoot, TDeps>> MACJCNJKPAA, TDeps BNNGNHILECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4038970", Offset = "0x4037570", VA = "0x184038970")]
	[AsyncStateMachine(typeof(OMHOEMCOFLL<, , , >.JBALPNLHENO))]
	public Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> ECDNJKDACHL(TRoot EBCHPMPLBLG, TSerializedAction HLNKBJDOFDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KBCJMJJCBAG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DCMBHPCGLIG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind JKBDJEGAMNJ(TSerializedAction NOLNJDLEMAA);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OFCCNMDFKDM(TRoot EBCHPMPLBLG, TSerializedAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EBHJCHJCOIL(TRoot EBCHPMPLBLG, TSerializedAction ODKDNEPMNIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2597F90", Offset = "0x2596B90", VA = "0x182597F90")]
	internal static OMHOEMCOFLL<TActionKind, TSerializedAction, TRoot, TDeps> CIGBOGDFGOD<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GLEDKBMJBEC<TSerializedAction, TRoot, TDeps>> MACJCNJKPAA, TDeps BNNGNHILECN) where TDeps : DCMBHPCGLIG<TActionKind, TSerializedAction, TRoot>
	{
		return default(OMHOEMCOFLL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BMKMAJANJDE<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, GLEDKBMJBEC<TSerializedAction, TRoot, TDeps>> BMFKMOJMBIE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	private BMKMAJANJDE(Dictionary<TActionKind, GLEDKBMJBEC<TSerializedAction, TRoot, TDeps>> MACJCNJKPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x47F57D0", Offset = "0x47F43D0", VA = "0x1847F57D0")]
	public static BMKMAJANJDE<TActionKind, TSerializedAction, TRoot, TDeps> CIGBOGDFGOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OOGNGCJKBIK<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, KBCJMJJCBAG.DCMBHPCGLIG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OJBCEPHHBHI<TPayload, TOk, TErr> : GLEDKBMJBEC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BNLEFJJKIPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EGOJFKNDMJJ<TActionKind, TSerializedAction, TPayload> MLJIBKBNFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly GKHENPEIJKM<TRoot, TPayload, TOk, TErr> EHLDCCDFAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool IDNJDDGLKJA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FB20", Offset = "0x3B2E720", VA = "0x183B2FB20")]
		public OJBCEPHHBHI(EGOJFKNDMJJ<TActionKind, TSerializedAction, TPayload> KIDHJNGEJFP, GKHENPEIJKM<TRoot, TPayload, TOk, TErr> LIFAGHAGNKG, bool FPOOHCFNHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4017FE0", Offset = "0x4016BE0", VA = "0x184017FE0", Slot = "4")]
		public Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> ECDNJKDACHL(TDeps BNNGNHILECN, TRoot EBCHPMPLBLG, TSerializedAction HLNKBJDOFDL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JPIKIKDGKHB<TPayload, TOk, TErr> : GLEDKBMJBEC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BNLEFJJKIPP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct HIAPJBKDINI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DGKNLHNBBJB<object?, BNLEFJJKIPP>> <>t__builder;

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
			public JPIKIKDGKHB<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DGKNLHNBBJB<object?, BNLEFJJKIPP> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DGKNLHNBBJB<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x386C5D0", Offset = "0x386B1D0", VA = "0x18386C5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x386CCB0", Offset = "0x386B8B0", VA = "0x18386CCB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly EGOJFKNDMJJ<TActionKind, TSerializedAction, TPayload> MLJIBKBNFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly KHENBHIAPAD<TRoot, TPayload, TOk, TErr> EHLDCCDFAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool IDNJDDGLKJA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B2FB20", Offset = "0x3B2E720", VA = "0x183B2FB20")]
		public JPIKIKDGKHB(EGOJFKNDMJJ<TActionKind, TSerializedAction, TPayload> KIDHJNGEJFP, KHENBHIAPAD<TRoot, TPayload, TOk, TErr> LIFAGHAGNKG, bool FPOOHCFNHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B2F700", Offset = "0x3B2E300", VA = "0x183B2F700", Slot = "4")]
		[AsyncStateMachine(typeof(JPIKIKDGKHB<, , >.HIAPJBKDINI))]
		public Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> ECDNJKDACHL(TDeps BNNGNHILECN, TRoot EBCHPMPLBLG, TSerializedAction HLNKBJDOFDL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BMKMAJANJDE<TActionKind, TSerializedAction, TRoot, TDeps> GBNALPEDEID;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	private OOGNGCJKBIK(BMKMAJANJDE<TActionKind, TSerializedAction, TRoot, TDeps> KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x403CE10", Offset = "0x403BA10", VA = "0x18403CE10")]
	public static OOGNGCJKBIK<TActionKind, TSerializedAction, TRoot, TDeps> CIGBOGDFGOD()
	{
		return default(OOGNGCJKBIK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2725710", Offset = "0x2724310", VA = "0x182725710")]
	public OOGNGCJKBIK<TActionKind, TSerializedAction, TRoot, TDeps> CLPOMFAIAJK<TPayload, TOk, TErr>(TActionKind FGNCENMPDIH, EGOJFKNDMJJ<TActionKind, TSerializedAction, TPayload> KIDHJNGEJFP, GKHENPEIJKM<TRoot, TPayload, TOk, TErr> LIFAGHAGNKG, bool FPOOHCFNHAB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BNLEFJJKIPP
	{
		return default(OOGNGCJKBIK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2725710", Offset = "0x2724310", VA = "0x182725710")]
	public OOGNGCJKBIK<TActionKind, TSerializedAction, TRoot, TDeps> POCABPBLEEN<TPayload, TOk, TErr>(TActionKind FGNCENMPDIH, EGOJFKNDMJJ<TActionKind, TSerializedAction, TPayload> KIDHJNGEJFP, KHENBHIAPAD<TRoot, TPayload, TOk, TErr> LIFAGHAGNKG, bool FPOOHCFNHAB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BNLEFJJKIPP
	{
		return default(OOGNGCJKBIK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x403CD60", Offset = "0x403B960", VA = "0x18403CD60")]
	public OMHOEMCOFLL<TActionKind, TSerializedAction, TRoot, TDeps> CAMOLGCILAI(TDeps BNNGNHILECN)
	{
		return default(OMHOEMCOFLL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
