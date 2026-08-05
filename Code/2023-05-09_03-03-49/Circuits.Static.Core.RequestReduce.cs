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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E7C790", Offset = "0x1E7B190", VA = "0x181E7C790")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
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
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate global::FKMCMMBLGFF<TActionKind, TPayload> IPKCIPPFIAJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction ENICIJCDPKB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface LHAKCIBKFCC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> BJKLJBGJKDK(TDeps KIMLKGPEIDL, TRoot MNGLAEJHIMG, TSerializedAction ENICIJCDPKB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KCOIPCHMCPL<TActionKind, TSerializedAction, TRoot, TDeps> : NNOGOJMPBNO where TDeps : IGLCGIILGJG.GJDCAHCJAOL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps FHGLBJEIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction NFFCPHFFBLM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3778B20", Offset = "0x3777520", VA = "0x183778B20")]
	public KCOIPCHMCPL(in TDeps KIMLKGPEIDL, in TSerializedAction ENICIJCDPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3778950", Offset = "0x3777350", VA = "0x183778950", Slot = "7")]
	public override string ODHCPOFFIEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FKMCMMBLGFF<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DFDOBFFIKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload EGFIHEDBKHI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36113B0", Offset = "0x360FDB0", VA = "0x1836113B0")]
	internal FKMCMMBLGFF(TActionKind OGBOELNELAI, in TPayload CBBKOHPGNJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AJLNPBOCFCK
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2553130", Offset = "0x2551B30", VA = "0x182553130")]
	public static global::FKMCMMBLGFF<TActionKind, TPayload> IDLIIDOEAFG<TActionKind, TPayload>(in TActionKind OGBOELNELAI, in TPayload CBBKOHPGNJD)
	{
		return default(global::FKMCMMBLGFF<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<global::DAOEJNFJJPJ<TOk, TErr>> LLCEMDCMEBO<TRoot, TPayload, TOk, TErr>(TRoot MNGLAEJHIMG, TPayload CBBKOHPGNJD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate global::DAOEJNFJJPJ<TOk, TErr> CFFPNLEKJJF<TRoot, TPayload, TOk, TErr>(TRoot MNGLAEJHIMG, in TPayload CBBKOHPGNJD);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BDBCGFMDOEA<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : IGLCGIILGJG.GJDCAHCJAOL<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HCGNFOIDCFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::BDBCGFMDOEA<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4553860", Offset = "0x4552260", VA = "0x184553860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4554010", Offset = "0x4552A10", VA = "0x184554010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, global::LHAKCIBKFCC<TSerializedAction, TRoot, TDeps>> BNEEFGMKFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps FHGLBJEIIAF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xC33810", Offset = "0xC32210", VA = "0x180C33810")]
	internal BDBCGFMDOEA(Dictionary<TActionKind, global::LHAKCIBKFCC<TSerializedAction, TRoot, TDeps>> PCEEBPBHCBH, TDeps KIMLKGPEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x46A7B40", Offset = "0x46A6540", VA = "0x1846A7B40")]
	[AsyncStateMachine(typeof(global::BDBCGFMDOEA<, , , >.HCGNFOIDCFI))]
	public Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> BJKLJBGJKDK(TRoot MNGLAEJHIMG, TSerializedAction ENICIJCDPKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IGLCGIILGJG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GJDCAHCJAOL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind LDKDFELJEPF(TSerializedAction IKHBPJOEIEB);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HOMCECDGLNH(TRoot MNGLAEJHIMG, TSerializedAction DJJNLDOINEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34611C0", Offset = "0x345FBC0", VA = "0x1834611C0")]
	internal static global::BDBCGFMDOEA<TActionKind, TSerializedAction, TRoot, TDeps> IDLIIDOEAFG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::LHAKCIBKFCC<TSerializedAction, TRoot, TDeps>> PCEEBPBHCBH, TDeps KIMLKGPEIDL) where TDeps : GJDCAHCJAOL<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::BDBCGFMDOEA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DDEPLAGEPIJ<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, global::LHAKCIBKFCC<TSerializedAction, TRoot, TDeps>> LAAMENACGDH;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E66A0", VA = "0x1834E7CA0")]
	private DDEPLAGEPIJ(Dictionary<TActionKind, global::LHAKCIBKFCC<TSerializedAction, TRoot, TDeps>> PCEEBPBHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4360CA0", Offset = "0x435F6A0", VA = "0x184360CA0")]
	public static global::DDEPLAGEPIJ<TActionKind, TSerializedAction, TRoot, TDeps> IDLIIDOEAFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct APCEBBGPJOF<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, IGLCGIILGJG.GJDCAHCJAOL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KLLOMPKELFB<TPayload, TOk, TErr> : global::LHAKCIBKFCC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PCIJMHLMKIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly global::IPKCIPPFIAJ<TActionKind, TSerializedAction, TPayload> ECCCKALIPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly global::CFFPNLEKJJF<TRoot, TPayload, TOk, TErr> KMKHBNMKKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool KJAPDJKFOEO;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38106C0", Offset = "0x380F0C0", VA = "0x1838106C0")]
		public KLLOMPKELFB(global::IPKCIPPFIAJ<TActionKind, TSerializedAction, TPayload> DBDMBGOFOKF, global::CFFPNLEKJJF<TRoot, TPayload, TOk, TErr> KHFHDIHNEFL, bool NIHHBIGJFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x380E220", Offset = "0x380CC20", VA = "0x18380E220", Slot = "4")]
		public Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> BJKLJBGJKDK(TDeps KIMLKGPEIDL, TRoot MNGLAEJHIMG, TSerializedAction ENICIJCDPKB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JBOENNALIKO<TPayload, TOk, TErr> : global::LHAKCIBKFCC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PCIJMHLMKIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::IPKCIPPFIAJ<TActionKind, TSerializedAction, TPayload> ECCCKALIPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::LLCEMDCMEBO<TRoot, TPayload, TOk, TErr> KMKHBNMKKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool KJAPDJKFOEO;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38106C0", Offset = "0x380F0C0", VA = "0x1838106C0")]
		public JBOENNALIKO(global::IPKCIPPFIAJ<TActionKind, TSerializedAction, TPayload> DBDMBGOFOKF, global::LLCEMDCMEBO<TRoot, TPayload, TOk, TErr> KHFHDIHNEFL, bool NIHHBIGJFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4076970", Offset = "0x4075370", VA = "0x184076970", Slot = "4")]
		[AsyncStateMachine(typeof(IEKMLHOBGJA))]
		public Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> BJKLJBGJKDK(TDeps KIMLKGPEIDL, TRoot MNGLAEJHIMG, TSerializedAction ENICIJCDPKB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::DDEPLAGEPIJ<TActionKind, TSerializedAction, TRoot, TDeps> IAECIDOKMOF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x875C70", Offset = "0x874670", VA = "0x180875C70")]
	private APCEBBGPJOF(global::DDEPLAGEPIJ<TActionKind, TSerializedAction, TRoot, TDeps> MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x475E730", Offset = "0x475D130", VA = "0x18475E730")]
	public static global::APCEBBGPJOF<TActionKind, TSerializedAction, TRoot, TDeps> IDLIIDOEAFG()
	{
		return default(global::APCEBBGPJOF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3327B70", Offset = "0x3326570", VA = "0x183327B70")]
	public global::APCEBBGPJOF<TActionKind, TSerializedAction, TRoot, TDeps> AOCAACMKGDI<TPayload, TOk, TErr>(TActionKind OGBOELNELAI, global::IPKCIPPFIAJ<TActionKind, TSerializedAction, TPayload> DBDMBGOFOKF, global::CFFPNLEKJJF<TRoot, TPayload, TOk, TErr> KHFHDIHNEFL, bool NIHHBIGJFPG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PCIJMHLMKIF
	{
		return default(global::APCEBBGPJOF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3327B70", Offset = "0x3326570", VA = "0x183327B70")]
	public global::APCEBBGPJOF<TActionKind, TSerializedAction, TRoot, TDeps> HGDMELKHKEP<TPayload, TOk, TErr>(TActionKind OGBOELNELAI, global::IPKCIPPFIAJ<TActionKind, TSerializedAction, TPayload> DBDMBGOFOKF, global::LLCEMDCMEBO<TRoot, TPayload, TOk, TErr> KHFHDIHNEFL, bool NIHHBIGJFPG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PCIJMHLMKIF
	{
		return default(global::APCEBBGPJOF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x475E7D0", Offset = "0x475D1D0", VA = "0x18475E7D0")]
	public global::BDBCGFMDOEA<TActionKind, TSerializedAction, TRoot, TDeps> JJLPJHMCCFD(TDeps KIMLKGPEIDL)
	{
		return default(global::BDBCGFMDOEA<TActionKind, TSerializedAction, TRoot, TDeps>);
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
