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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2578C30", Offset = "0x2578030", VA = "0x182578C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate FAGPPDKBBNO<TActionKind, TPayload> PHGINOJMBNM<TActionKind, TSerializedAction, TPayload>(TSerializedAction PMKDFNINDPP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EIFECJLHCKL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TDeps GKFDJGEMKAB, TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class ANPAFHJOLKP<TActionKind, TSerializedAction, TRoot, TDeps> : MPAEBDCEOBD where TDeps : NOEGOOCAILH.NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction LBKIJMMADHD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4950DB0", Offset = "0x49501B0", VA = "0x184950DB0")]
	public ANPAFHJOLKP([In] TDeps GKFDJGEMKAB, [In] TSerializedAction PMKDFNINDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4950C90", Offset = "0x4950090", VA = "0x184950C90", Slot = "7")]
	public override string BBCHEHFFEBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FAGPPDKBBNO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind POHGDLLAMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload HBBGBNNJCHH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x43B0CC0", Offset = "0x43B00C0", VA = "0x1843B0CC0")]
	internal FAGPPDKBBNO(TActionKind LCLDCHNIOPM, [In] TPayload GOAPBALNOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MKMEHDIIMFN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x34CEBD0", Offset = "0x34CDFD0", VA = "0x1834CEBD0")]
	public static FAGPPDKBBNO<TActionKind, TPayload> FEOBEKOIKMG<TActionKind, TPayload>([In] TActionKind LCLDCHNIOPM, [In] TPayload GOAPBALNOKD)
	{
		return default(FAGPPDKBBNO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<JOFBNNGKBOO<TOk, TErr>> DHPDIFBEPOA<TRoot, TPayload, TOk, TErr>(TRoot JGHOOBNHEJB, TPayload GOAPBALNOKD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate JOFBNNGKBOO<TOk, TErr> CJDCNLPPIIL<TRoot, TPayload, TOk, TErr>(TRoot JGHOOBNHEJB, [In] TPayload GOAPBALNOKD);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : NOEGOOCAILH.NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EOHLNHBKJGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<JOFBNNGKBOO<object, PPAGHPBHFJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4024280", Offset = "0x4023680", VA = "0x184024280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4024700", Offset = "0x4023B00", VA = "0x184024700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> FHLPBIGELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
	internal NKBPINFEMPK(Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> PDKBPOECKEG, TDeps GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D0F0", Offset = "0x4E7C4F0", VA = "0x184E7D0F0")]
	[AsyncStateMachine(typeof(NKBPINFEMPK<, , , >.EOHLNHBKJGC))]
	public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NOEGOOCAILH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind ECMMNNHBDPD(TSerializedAction JDCFMPOHCEA);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NFOKJFBPIHF(TRoot JGHOOBNHEJB, TSerializedAction PJDAFKMDDCG);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KFCGHNNPOPA(TRoot JGHOOBNHEJB, TSerializedAction PJDAFKMDDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x346F0B0", Offset = "0x346E4B0", VA = "0x18346F0B0")]
	internal static NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> FEOBEKOIKMG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> PDKBPOECKEG, TDeps GKFDJGEMKAB) where TDeps : NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
	{
		return default(NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> BCENBNFJLKH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	private DHJBGGOPKLA(Dictionary<TActionKind, EIFECJLHCKL<TSerializedAction, TRoot, TDeps>> PDKBPOECKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62A82C0", Offset = "0x62A76C0", VA = "0x1862A82C0")]
	public static DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps> FEOBEKOIKMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, NOEGOOCAILH.NBFPMIDGEGN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class GOJFKHHPLJE<TPayload, TOk, TErr> : EIFECJLHCKL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CEJCOHLIKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CJDCNLPPIIL<TRoot, TPayload, TOk, TErr> FKJLFCNBFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool NOIPDGIKDLE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x451E600", Offset = "0x451DA00", VA = "0x18451E600")]
		public GOJFKHHPLJE(PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, CJDCNLPPIIL<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4517B40", Offset = "0x4516F40", VA = "0x184517B40", Slot = "4")]
		public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TDeps GKFDJGEMKAB, TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class OLBHBPGEHCJ<TPayload, TOk, TErr> : EIFECJLHCKL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct AFKAHFHAHNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<JOFBNNGKBOO<object?, PPAGHPBHFJD>> <>t__builder;

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
			public OLBHBPGEHCJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private JOFBNNGKBOO<object?, PPAGHPBHFJD> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<JOFBNNGKBOO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x479CA00", Offset = "0x479BE00", VA = "0x18479CA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x479D3D0", Offset = "0x479C7D0", VA = "0x18479D3D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CEJCOHLIKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly DHPDIFBEPOA<TRoot, TPayload, TOk, TErr> FKJLFCNBFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool NOIPDGIKDLE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x451E600", Offset = "0x451DA00", VA = "0x18451E600")]
		public OLBHBPGEHCJ(PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, DHPDIFBEPOA<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4FBFC00", Offset = "0x4FBF000", VA = "0x184FBFC00", Slot = "4")]
		[AsyncStateMachine(typeof(OLBHBPGEHCJ<, , >.AFKAHFHAHNL))]
		public Task<JOFBNNGKBOO<object, PPAGHPBHFJD>> IAKLNGNNDFI(TDeps GKFDJGEMKAB, TRoot JGHOOBNHEJB, TSerializedAction PMKDFNINDPP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps> NGLBBEFFGIM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	private HMHNOMGHDBI(DHJBGGOPKLA<TActionKind, TSerializedAction, TRoot, TDeps> GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4630470", Offset = "0x462F870", VA = "0x184630470")]
	public static HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> FEOBEKOIKMG()
	{
		return default(HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3418720", Offset = "0x3417B20", VA = "0x183418720")]
	public HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> ANDDNGMAEGK<TPayload, TOk, TErr>(TActionKind LCLDCHNIOPM, PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, CJDCNLPPIIL<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		return default(HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3418720", Offset = "0x3417B20", VA = "0x183418720")]
	public HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps> LDFLMAEJFBE<TPayload, TOk, TErr>(TActionKind LCLDCHNIOPM, PHGINOJMBNM<TActionKind, TSerializedAction, TPayload> CPGEKIIILGL, DHPDIFBEPOA<TRoot, TPayload, TOk, TErr> FNOCJCOOMEG, bool PDGKKPABECG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PPAGHPBHFJD
	{
		return default(HMHNOMGHDBI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x46303B0", Offset = "0x462F7B0", VA = "0x1846303B0")]
	public NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps> BMHADMIFCBL(TDeps GKFDJGEMKAB)
	{
		return default(NKBPINFEMPK<TActionKind, TSerializedAction, TRoot, TDeps>);
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
