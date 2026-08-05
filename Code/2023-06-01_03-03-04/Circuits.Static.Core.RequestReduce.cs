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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FFA8C0", Offset = "0x6FF94C0", VA = "0x186FFA8C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FB9A30", Offset = "0x1FB8630", VA = "0x181FB9A30")]
	internal NDGJMKEFIHF(TActionKind MEPKJIMJDDM, in TPayload MEKBNGFFPML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DEOJEGIPNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B6D0", Offset = "0x2B7A2D0", VA = "0x182B7B6D0")]
	public static NDGJMKEFIHF<TActionKind, TPayload> DOBPLOGGNLM<TActionKind, TPayload>(in TActionKind MEPKJIMJDDM, in TPayload MEKBNGFFPML)
	{
		return default(NDGJMKEFIHF<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TDeps LHPOMNBICEN, TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : BFBLNPGELFB.FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OBJFHBGKINO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<PKJAENHCLMN<object, HECNFFAEBGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private PKJAENHCLMN<object, HECNFFAEBGF> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private BGGOGDCFOCA<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PKJAENHCLMN<object, HECNFFAEBGF> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<PKJAENHCLMN<object, HECNFFAEBGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public OBJFHBGKINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x48691B0", Offset = "0x4867DB0", VA = "0x1848691B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> BLEIIPCICBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps PNGKFALBFEP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
	internal NCGNPNOHKEB(Dictionary<TActionKind, BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> OIBBAEBBLGN, TDeps LHPOMNBICEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FB46A0", Offset = "0x1FB32A0", VA = "0x181FB46A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCGNPNOHKEB<, , , >.OBJFHBGKINO))]
	public Task<PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ)
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
	[Cpp2IlInjected.Address(RVA = "0x2FF59F0", Offset = "0x2FF45F0", VA = "0x182FF59F0")]
	internal static NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> DOBPLOGGNLM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> OIBBAEBBLGN, TDeps LHPOMNBICEN) where TDeps : FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
	{
		return default(NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate PKJAENHCLMN<TOk, TErr> ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr>(TRoot PMBNHDHBMIA, in TPayload MEKBNGFFPML);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> BKINODFLKND;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AF70", Offset = "0x1D59B70", VA = "0x181D5AF70")]
	private HPALHADLNKP(Dictionary<TActionKind, BGGOGDCFOCA<TSerializedAction, TRoot, TDeps>> OIBBAEBBLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DFF0", Offset = "0x2E7CBF0", VA = "0x182E7DFF0")]
	public static HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps> DOBPLOGGNLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<PKJAENHCLMN<TOk, TErr>> EFJCBPIOGDK<TRoot, TPayload, TOk, TErr>(TRoot PMBNHDHBMIA, TPayload MEKBNGFFPML);
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
	[Cpp2IlInjected.Address(RVA = "0x2980B00", Offset = "0x297F700", VA = "0x182980B00")]
	public JGCPBNHKIIO(in TDeps LHPOMNBICEN, in TSerializedAction LBNKHDOJONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29809D0", Offset = "0x297F5D0", VA = "0x1829809D0", Slot = "7")]
	public override string AFLBGGMHEAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate NDGJMKEFIHF<TActionKind, TPayload> CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload>(TSerializedAction LBNKHDOJONJ);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, BFBLNPGELFB.FCGEFALGFOM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PPPJDNHAPEE<TPayload, TOk, TErr> : BGGOGDCFOCA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> IJFJDAPGGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr> GCMOEAIJJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool DIPFGFDNDMM;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x296FCE0", Offset = "0x296E8E0", VA = "0x18296FCE0")]
		public PPPJDNHAPEE(CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CBC0", Offset = "0x2D4B7C0", VA = "0x182D4CBC0", Slot = "4")]
		public Task<PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TDeps LHPOMNBICEN, TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PODBLPJGEKK<TPayload, TOk, TErr> : BGGOGDCFOCA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IJBMBHBJFDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BC0D0", Offset = "0x7BB4D0")]
			public AsyncTaskMethodBuilder<PKJAENHCLMN<object, HECNFFAEBGF>> <>t__builder;

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
			public PODBLPJGEKK<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BC130", Offset = "0x7BB530")]
			private PKJAENHCLMN<object, HECNFFAEBGF> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BC190", Offset = "0x7BB590")]
			private NDGJMKEFIHF<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BC1F0", Offset = "0x7BB5F0")]
			private PKJAENHCLMN<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BC250", Offset = "0x7BB650")]
			private PKJAENHCLMN<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7BC2B0", Offset = "0x7BB6B0")]
			private TaskAwaiter<PKJAENHCLMN<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public IJBMBHBJFDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1C873D0", Offset = "0x1C85FD0", VA = "0x181C873D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> IJFJDAPGGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly EFJCBPIOGDK<TRoot, TPayload, TOk, TErr> GCMOEAIJJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool DIPFGFDNDMM;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x296FCE0", Offset = "0x296E8E0", VA = "0x18296FCE0")]
		public PODBLPJGEKK(CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, EFJCBPIOGDK<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2D46D30", Offset = "0x2D45930", VA = "0x182D46D30", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(PODBLPJGEKK<, , >.IJBMBHBJFDA))]
		public Task<PKJAENHCLMN<object, HECNFFAEBGF>> EIMPNHKKKBK(TDeps LHPOMNBICEN, TRoot PMBNHDHBMIA, TSerializedAction LBNKHDOJONJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps> KPHHIGDOCPF;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	private EMMFBHIJIOC(HPALHADLNKP<TActionKind, TSerializedAction, TRoot, TDeps> PHBHEFAPHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1B04770", Offset = "0x1B03370", VA = "0x181B04770")]
	public static EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> DOBPLOGGNLM()
	{
		return default(EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x24692B0", Offset = "0x2467EB0", VA = "0x1824692B0")]
	public EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> MLDEFFIKGOE<TPayload, TOk, TErr>(TActionKind MEPKJIMJDDM, CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, ADDHIFGKHPJ<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		return default(EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x24692B0", Offset = "0x2467EB0", VA = "0x1824692B0")]
	public EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps> ANPAFCOGOGL<TPayload, TOk, TErr>(TActionKind MEPKJIMJDDM, CHDMDLGHOAD<TActionKind, TSerializedAction, TPayload> HLIEHGBPEIK, EFJCBPIOGDK<TRoot, TPayload, TOk, TErr> CFKMOHGHLLJ, bool EOCNDBBHLHE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HECNFFAEBGF
	{
		return default(EMMFBHIJIOC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1B04810", Offset = "0x1B03410", VA = "0x181B04810")]
	public NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps> FGKHEPONKIM(TDeps LHPOMNBICEN)
	{
		return default(NCGNPNOHKEB<TActionKind, TSerializedAction, TRoot, TDeps>);
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
