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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C68910", Offset = "0x1C67710", VA = "0x181C68910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate KECCHLFNHMB<TActionKind, TPayload> FEBPNNHIJPC<TActionKind, TSerializedAction, TPayload>(TSerializedAction NOIKOBEEBEG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CBNMBMONNHN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> BBHHOKIKMIE(TDeps BLNNMOCCDKN, TRoot PHNFANHCONA, TSerializedAction NOIKOBEEBEG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class EAJCDOFOPIB<TActionKind, TSerializedAction, TRoot, TDeps> : BKLKNEGKHFP where TDeps : MECJKIKFFAN.GOPDODKANIL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JFMOPJMOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JEGOKIDOJBH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30082A0", Offset = "0x30070A0", VA = "0x1830082A0")]
	public EAJCDOFOPIB([In] TDeps BLNNMOCCDKN, [In] TSerializedAction NOIKOBEEBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3008170", Offset = "0x3006F70", VA = "0x183008170", Slot = "7")]
	public override string KJDIEKJIOOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KECCHLFNHMB<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind HIMMCPGEKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload KOFEMDOKPAN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x389A260", Offset = "0x3899060", VA = "0x18389A260")]
	internal KECCHLFNHMB(TActionKind OPMKJOMLLEH, [In] TPayload JOPBACODGFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MJFCPEOMEHA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x247FE70", Offset = "0x247EC70", VA = "0x18247FE70")]
	public static KECCHLFNHMB<TActionKind, TPayload> IGHHFGMBDIH<TActionKind, TPayload>([In] TActionKind OPMKJOMLLEH, [In] TPayload JOPBACODGFL)
	{
		return default(KECCHLFNHMB<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<FEBPNEDDNDE<TOk, TErr>> FLJEKFGCAMP<TRoot, TPayload, TOk, TErr>(TRoot PHNFANHCONA, TPayload JOPBACODGFL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate FEBPNEDDNDE<TOk, TErr> HIPFHMMECOC<TRoot, TPayload, TOk, TErr>(TRoot PHNFANHCONA, [In] TPayload JOPBACODGFL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KMBBPAJDPHN<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MECJKIKFFAN.GOPDODKANIL<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PGCGNPJACAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KMBBPAJDPHN<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1170", Offset = "0x3DAFF70", VA = "0x183DB1170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1A10", Offset = "0x3DB0810", VA = "0x183DB1A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, CBNMBMONNHN<TSerializedAction, TRoot, TDeps>> MGGNAJOHEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JFMOPJMOHHN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
	internal KMBBPAJDPHN(Dictionary<TActionKind, CBNMBMONNHN<TSerializedAction, TRoot, TDeps>> KHIFMHNGIAC, TDeps BLNNMOCCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38CF160", Offset = "0x38CDF60", VA = "0x1838CF160")]
	[AsyncStateMachine(typeof(KMBBPAJDPHN<, , , >.PGCGNPJACAJ))]
	public Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> BBHHOKIKMIE(TRoot PHNFANHCONA, TSerializedAction NOIKOBEEBEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MECJKIKFFAN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GOPDODKANIL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FJHHNELMMKI(TSerializedAction PECKHAMCEFO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IKEFFCJMEHF(TRoot PHNFANHCONA, TSerializedAction IPGJPNDBCJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x224A680", Offset = "0x2249480", VA = "0x18224A680")]
	internal static KMBBPAJDPHN<TActionKind, TSerializedAction, TRoot, TDeps> IGHHFGMBDIH<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, CBNMBMONNHN<TSerializedAction, TRoot, TDeps>> KHIFMHNGIAC, TDeps BLNNMOCCDKN) where TDeps : GOPDODKANIL<TActionKind, TSerializedAction, TRoot>
	{
		return default(KMBBPAJDPHN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class EHAFCFKBBGD<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, CBNMBMONNHN<TSerializedAction, TRoot, TDeps>> NJABCCAOOGA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	private EHAFCFKBBGD(Dictionary<TActionKind, CBNMBMONNHN<TSerializedAction, TRoot, TDeps>> KHIFMHNGIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x302D0F0", Offset = "0x302BEF0", VA = "0x18302D0F0")]
	public static EHAFCFKBBGD<TActionKind, TSerializedAction, TRoot, TDeps> IGHHFGMBDIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GFGKKIBGJKJ<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MECJKIKFFAN.GOPDODKANIL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class POHJPBNOJAH<TPayload, TOk, TErr> : CBNMBMONNHN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KBBJHNEEOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FEBPNNHIJPC<TActionKind, TSerializedAction, TPayload> HLGGEKKGFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HIPFHMMECOC<TRoot, TPayload, TOk, TErr> DJIFEKMJAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool FIICHMNGBCK;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35E2A10", Offset = "0x35E1810", VA = "0x1835E2A10")]
		public POHJPBNOJAH(FEBPNNHIJPC<TActionKind, TSerializedAction, TPayload> DJCAOAHHHBH, HIPFHMMECOC<TRoot, TPayload, TOk, TErr> DMGNCJOPFEE, bool JBCHDFJJFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEC710", Offset = "0x3DEB510", VA = "0x183DEC710", Slot = "4")]
		public Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> BBHHOKIKMIE(TDeps BLNNMOCCDKN, TRoot PHNFANHCONA, TSerializedAction NOIKOBEEBEG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HJGCKADAAFG<TPayload, TOk, TErr> : CBNMBMONNHN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KBBJHNEEOGJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BMPOJAHOMLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<object?, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HJGCKADAAFG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private FEBPNEDDNDE<object?, KBBJHNEEOGJ> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<FEBPNEDDNDE<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x449E7C0", Offset = "0x449D5C0", VA = "0x18449E7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x449F120", Offset = "0x449DF20", VA = "0x18449F120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly FEBPNNHIJPC<TActionKind, TSerializedAction, TPayload> HLGGEKKGFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly FLJEKFGCAMP<TRoot, TPayload, TOk, TErr> DJIFEKMJAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool FIICHMNGBCK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x35E2A10", Offset = "0x35E1810", VA = "0x1835E2A10")]
		public HJGCKADAAFG(FEBPNNHIJPC<TActionKind, TSerializedAction, TPayload> DJCAOAHHHBH, FLJEKFGCAMP<TRoot, TPayload, TOk, TErr> DMGNCJOPFEE, bool JBCHDFJJFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35E25F0", Offset = "0x35E13F0", VA = "0x1835E25F0", Slot = "4")]
		[AsyncStateMachine(typeof(HJGCKADAAFG<, , >.BMPOJAHOMLD))]
		public Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> BBHHOKIKMIE(TDeps BLNNMOCCDKN, TRoot PHNFANHCONA, TSerializedAction NOIKOBEEBEG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EHAFCFKBBGD<TActionKind, TSerializedAction, TRoot, TDeps> GLDGIPKLAOB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	private GFGKKIBGJKJ(EHAFCFKBBGD<TActionKind, TSerializedAction, TRoot, TDeps> LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x348C730", Offset = "0x348B530", VA = "0x18348C730")]
	public static GFGKKIBGJKJ<TActionKind, TSerializedAction, TRoot, TDeps> IGHHFGMBDIH()
	{
		return default(GFGKKIBGJKJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2189E20", Offset = "0x2188C20", VA = "0x182189E20")]
	public GFGKKIBGJKJ<TActionKind, TSerializedAction, TRoot, TDeps> MMBIAEALPFN<TPayload, TOk, TErr>(TActionKind OPMKJOMLLEH, FEBPNNHIJPC<TActionKind, TSerializedAction, TPayload> DJCAOAHHHBH, HIPFHMMECOC<TRoot, TPayload, TOk, TErr> DMGNCJOPFEE, bool JBCHDFJJFMI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KBBJHNEEOGJ
	{
		return default(GFGKKIBGJKJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2189E20", Offset = "0x2188C20", VA = "0x182189E20")]
	public GFGKKIBGJKJ<TActionKind, TSerializedAction, TRoot, TDeps> KHLNCCBNDNH<TPayload, TOk, TErr>(TActionKind OPMKJOMLLEH, FEBPNNHIJPC<TActionKind, TSerializedAction, TPayload> DJCAOAHHHBH, FLJEKFGCAMP<TRoot, TPayload, TOk, TErr> DMGNCJOPFEE, bool JBCHDFJJFMI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KBBJHNEEOGJ
	{
		return default(GFGKKIBGJKJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x348C7C0", Offset = "0x348B5C0", VA = "0x18348C7C0")]
	public KMBBPAJDPHN<TActionKind, TSerializedAction, TRoot, TDeps> OACGCGFLLOK(TDeps BLNNMOCCDKN)
	{
		return default(KMBBPAJDPHN<TActionKind, TSerializedAction, TRoot, TDeps>);
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
