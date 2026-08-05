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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x16945B0", Offset = "0x1692DB0", VA = "0x1816945B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
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
		[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct NDGJMKEFIHF<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind EFIFDBKPFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload OECCIMIKFOA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29C3320", Offset = "0x29C1B20", VA = "0x1829C3320")]
	internal NDGJMKEFIHF(TActionKind MEPKJIMJDDM, in TPayload MEKBNGFFPML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DEOJEGIPNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0CC0", Offset = "0x2E9F4C0", VA = "0x182EA0CC0")]
	public static global::NDGJMKEFIHF<TActionKind, TPayload> DOBPLOGGNLM<TActionKind, TPayload>(in TActionKind MEPKJIMJDDM, in TPayload MEKBNGFFPML)
	{
		return default(global::NDGJMKEFIHF<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TDeps LHPOMNBICEN, TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : BFBLNPGELFB.FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KLDHHHCGCML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<global::PKJAENHCLMN<object, HECNFFAEBGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private global::PKJAENHCLMN<object, HECNFFAEBGF> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::PKJAENHCLMN<object, HECNFFAEBGF> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<global::PKJAENHCLMN<object, HECNFFAEBGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public KLDHHHCGCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x325DB50", Offset = "0x325C350", VA = "0x18325DB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> BLEIIPCICBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps PNGKFALBFEP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
	internal NCGNPNOHKEB(Dictionary<TActionKind, global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> OIBBAEBBLGN, TDeps LHPOMNBICEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29BFEA0", Offset = "0x29BE6A0", VA = "0x1829BFEA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::NCGNPNOHKEB<, , , >.KLDHHHCGCML))]
	public Task<global::PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BFBLNPGELFB
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind LFFNAGNFLHC(TSerializedAction GPOCLJBKMHA);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FOEHBPMBDAD(TRoot PMBNHDHBMIA, TSerializedAction FOGMDOMFJBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3478420", Offset = "0x3476C20", VA = "0x183478420")]
	internal static global::NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> DOBPLOGGNLM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> OIBBAEBBLGN, TDeps LHPOMNBICEN) where TDeps : FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate global::PKJAENHCLMN<TOk, TErr> ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr>(TRoot PMBNHDHBMIA, in TPayload MEKBNGFFPML);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> BKINODFLKND;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1CA08D0", Offset = "0x1C9F0D0", VA = "0x181CA08D0")]
	private HPALHADLNKP(Dictionary<TActionKind, global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> OIBBAEBBLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x358CC30", Offset = "0x358B430", VA = "0x18358CC30")]
	public static global::HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps> DOBPLOGGNLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<global::PKJAENHCLMN<TOk, TErr>> EFJCBPIOGDK<TRoot, TPayload, TOk, TErr>(TRoot PMBNHDHBMIA, TPayload MEKBNGFFPML);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JGCPBNHKIIO<TActionKind, TSerializedAction, TRoot, TDeps> : EJGLEHOMCMJ where TDeps : BFBLNPGELFB.FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps PNGKFALBFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction MDFDCFHJJDD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32F5B70", Offset = "0x32F4370", VA = "0x1832F5B70")]
	public JGCPBNHKIIO(in TDeps LHPOMNBICEN, in TSerializedAction LBNKHDOJONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32F5A40", Offset = "0x32F4240", VA = "0x1832F5A40", Slot = "7")]
	public override string AFLBGGMHEAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate global::NDGJMKEFIHF<TActionKind, TPayload> CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload>(TSerializedAction LBNKHDOJONJ);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, BFBLNPGELFB.FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LMNBHIOICLF<TPayload, TOk, TErr> : global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> IJFJDAPGGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly global::ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr> GCMOEAIJJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool DIPFGFDNDMM;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x30D8A50", Offset = "0x30D7250", VA = "0x1830D8A50")]
		public LMNBHIOICLF(global::CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, global::ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x30D5980", Offset = "0x30D4180", VA = "0x1830D5980", Slot = "4")]
		public Task<global::PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TDeps LHPOMNBICEN, TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KLKGBODLMHC<TPayload, TOk, TErr> : global::BGGOGDCFOCA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly global::CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> IJFJDAPGGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly global::EFJCBPIOGDK<TRoot, TPayload, TOk, TErr> GCMOEAIJJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool DIPFGFDNDMM;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x30D8A50", Offset = "0x30D7250", VA = "0x1830D8A50")]
		public KLKGBODLMHC(global::CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, global::EFJCBPIOGDK<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x325EE00", Offset = "0x325D600", VA = "0x18325EE00", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(NFGFEPNEKFG))]
		public Task<global::PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TDeps LHPOMNBICEN, TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps> KPHHIGDOCPF;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xB91230", Offset = "0xB8FA30", VA = "0x180B91230")]
	private EMMFBHIJIOC(global::HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps> PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3877A10", Offset = "0x3876210", VA = "0x183877A10")]
	public static global::EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> DOBPLOGGNLM()
	{
		return default(global::EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A124E0", Offset = "0x2A10CE0", VA = "0x182A124E0")]
	public global::EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> MLDEFFIKGOE<TPayload, TOk, TErr>(TActionKind MEPKJIMJDDM, global::CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, global::ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		return default(global::EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A124E0", Offset = "0x2A10CE0", VA = "0x182A124E0")]
	public global::EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> ANPAFCOGOGL<TPayload, TOk, TErr>(TActionKind MEPKJIMJDDM, global::CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, global::EFJCBPIOGDK<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		return default(global::EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3877AB0", Offset = "0x38762B0", VA = "0x183877AB0")]
	public global::NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> FGKHEPONKIM(TDeps LHPOMNBICEN)
	{
		return default(global::NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps>);
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
