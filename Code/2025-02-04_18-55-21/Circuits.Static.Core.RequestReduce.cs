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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25577C0", Offset = "0x25565C0", VA = "0x1825577C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate KAIBPOAMLHJ<TActionKind, TPayload> IPLPANNPIJG<TActionKind, TSerializedAction, TPayload>(TSerializedAction CCJFGGAMEKO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FNOEPHHFMAN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> JJFFEGPDIDD(TDeps FLOGLGIGMAI, TRoot DOJENPPADJD, TSerializedAction CCJFGGAMEKO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PILADFABKMG<TActionKind, TSerializedAction, TRoot, TDeps> : NPDJLDEDKNL where TDeps : LNLOKMHCLCK.MPDIIICCGGC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps IKKBNFCGFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BHCCJDMHMOP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4F316A0", Offset = "0x4F304A0", VA = "0x184F316A0")]
	public PILADFABKMG([In] TDeps FLOGLGIGMAI, [In] TSerializedAction CCJFGGAMEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F31580", Offset = "0x4F30380", VA = "0x184F31580", Slot = "7")]
	public override string KMIKCFPGPHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KAIBPOAMLHJ<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GOHACKBHNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload EFCOGPIOBOI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4999FF0", Offset = "0x4998DF0", VA = "0x184999FF0")]
	internal KAIBPOAMLHJ(TActionKind MGIPGLLINCJ, [In] TPayload KGDIEBJBNPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PGJCFJDKHCK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x349DAA0", Offset = "0x349C8A0", VA = "0x18349DAA0")]
	public static KAIBPOAMLHJ<TActionKind, TPayload> MKHEJJEDOII<TActionKind, TPayload>([In] TActionKind MGIPGLLINCJ, [In] TPayload KGDIEBJBNPG)
	{
		return default(KAIBPOAMLHJ<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PGOLMGNGGBM<TOk, TErr>> IKFKACPFKJK<TRoot, TPayload, TOk, TErr>(TRoot DOJENPPADJD, TPayload KGDIEBJBNPG);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PGOLMGNGGBM<TOk, TErr> IKFOAPFBANN<TRoot, TPayload, TOk, TErr>(TRoot DOJENPPADJD, [In] TPayload KGDIEBJBNPG);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DLKEMAONFHP<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LNLOKMHCLCK.MPDIIICCGGC<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KCEIKPNKJCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public DLKEMAONFHP<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x49A18D0", Offset = "0x49A06D0", VA = "0x1849A18D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x49A1DC0", Offset = "0x49A0BC0", VA = "0x1849A1DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FNOEPHHFMAN<TSerializedAction, TRoot, TDeps>> NPPDNCJEPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps IKKBNFCGFBJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	internal DLKEMAONFHP(Dictionary<TActionKind, FNOEPHHFMAN<TSerializedAction, TRoot, TDeps>> GOLLEOMCPAN, TDeps FLOGLGIGMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6115500", Offset = "0x6114300", VA = "0x186115500")]
	[AsyncStateMachine(typeof(DLKEMAONFHP<, , , >.KCEIKPNKJCB))]
	public Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> JJFFEGPDIDD(TRoot DOJENPPADJD, TSerializedAction CCJFGGAMEKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LNLOKMHCLCK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MPDIIICCGGC<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind HNCPEJNFDBN(TSerializedAction DJAJDIFOIHP);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CPGMEHOFLKP(TRoot DOJENPPADJD, TSerializedAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IPJDEFPNIHK(TRoot DOJENPPADJD, TSerializedAction OOCJAOHFGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x339BF60", Offset = "0x339AD60", VA = "0x18339BF60")]
	internal static DLKEMAONFHP<TActionKind, TSerializedAction, TRoot, TDeps> MKHEJJEDOII<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FNOEPHHFMAN<TSerializedAction, TRoot, TDeps>> GOLLEOMCPAN, TDeps FLOGLGIGMAI) where TDeps : MPDIIICCGGC<TActionKind, TSerializedAction, TRoot>
	{
		return default(DLKEMAONFHP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NPDNOMDOEGP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FNOEPHHFMAN<TSerializedAction, TRoot, TDeps>> IBBPHFNKFGK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	private NPDNOMDOEGP(Dictionary<TActionKind, FNOEPHHFMAN<TSerializedAction, TRoot, TDeps>> GOLLEOMCPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F120", Offset = "0x4D3DF20", VA = "0x184D3F120")]
	public static NPDNOMDOEGP<TActionKind, TSerializedAction, TRoot, TDeps> MKHEJJEDOII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KDAFJECKBGP<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LNLOKMHCLCK.MPDIIICCGGC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class GNCNPAHLCBP<TPayload, TOk, TErr> : FNOEPHHFMAN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HJBBDBHAMJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IPLPANNPIJG<TActionKind, TSerializedAction, TPayload> OIHCMFIDNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly IKFOAPFBANN<TRoot, TPayload, TOk, TErr> LKCIIMEGBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool IMHLACNBEIJ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x44E9740", Offset = "0x44E8540", VA = "0x1844E9740")]
		public GNCNPAHLCBP(IPLPANNPIJG<TActionKind, TSerializedAction, TPayload> PANEBMLFIJO, IKFOAPFBANN<TRoot, TPayload, TOk, TErr> OIHGHJHIPLL, bool BJAPJDGLMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x44DF690", Offset = "0x44DE490", VA = "0x1844DF690", Slot = "4")]
		public Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> JJFFEGPDIDD(TDeps FLOGLGIGMAI, TRoot DOJENPPADJD, TSerializedAction CCJFGGAMEKO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IELDPKFDBFG<TPayload, TOk, TErr> : FNOEPHHFMAN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HJBBDBHAMJJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DILPIKBAOED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>t__builder;

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
			public IELDPKFDBFG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PGOLMGNGGBM<object?, HJBBDBHAMJJ> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PGOLMGNGGBM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6108290", Offset = "0x6107090", VA = "0x186108290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x610A010", Offset = "0x6108E10", VA = "0x18610A010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IPLPANNPIJG<TActionKind, TSerializedAction, TPayload> OIHCMFIDNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly IKFKACPFKJK<TRoot, TPayload, TOk, TErr> LKCIIMEGBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool IMHLACNBEIJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x44E9740", Offset = "0x44E8540", VA = "0x1844E9740")]
		public IELDPKFDBFG(IPLPANNPIJG<TActionKind, TSerializedAction, TPayload> PANEBMLFIJO, IKFKACPFKJK<TRoot, TPayload, TOk, TErr> OIHGHJHIPLL, bool BJAPJDGLMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x46D85A0", Offset = "0x46D73A0", VA = "0x1846D85A0", Slot = "4")]
		[AsyncStateMachine(typeof(IELDPKFDBFG<, , >.DILPIKBAOED))]
		public Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> JJFFEGPDIDD(TDeps FLOGLGIGMAI, TRoot DOJENPPADJD, TSerializedAction CCJFGGAMEKO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NPDNOMDOEGP<TActionKind, TSerializedAction, TRoot, TDeps> GAMLGJDLMJD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	private KDAFJECKBGP(NPDNOMDOEGP<TActionKind, TSerializedAction, TRoot, TDeps> JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x49A1EF0", Offset = "0x49A0CF0", VA = "0x1849A1EF0")]
	public static KDAFJECKBGP<TActionKind, TSerializedAction, TRoot, TDeps> MKHEJJEDOII()
	{
		return default(KDAFJECKBGP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35B5A40", Offset = "0x35B4840", VA = "0x1835B5A40")]
	public KDAFJECKBGP<TActionKind, TSerializedAction, TRoot, TDeps> HBGIMCKIEJF<TPayload, TOk, TErr>(TActionKind MGIPGLLINCJ, IPLPANNPIJG<TActionKind, TSerializedAction, TPayload> PANEBMLFIJO, IKFOAPFBANN<TRoot, TPayload, TOk, TErr> OIHGHJHIPLL, bool BJAPJDGLMJG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HJBBDBHAMJJ
	{
		return default(KDAFJECKBGP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35B5A40", Offset = "0x35B4840", VA = "0x1835B5A40")]
	public KDAFJECKBGP<TActionKind, TSerializedAction, TRoot, TDeps> OGCEGHBFJGA<TPayload, TOk, TErr>(TActionKind MGIPGLLINCJ, IPLPANNPIJG<TActionKind, TSerializedAction, TPayload> PANEBMLFIJO, IKFKACPFKJK<TRoot, TPayload, TOk, TErr> OIHGHJHIPLL, bool BJAPJDGLMJG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HJBBDBHAMJJ
	{
		return default(KDAFJECKBGP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x49A1E30", Offset = "0x49A0C30", VA = "0x1849A1E30")]
	public DLKEMAONFHP<TActionKind, TSerializedAction, TRoot, TDeps> CHGKKDHAAHF(TDeps FLOGLGIGMAI)
	{
		return default(DLKEMAONFHP<TActionKind, TSerializedAction, TRoot, TDeps>);
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
