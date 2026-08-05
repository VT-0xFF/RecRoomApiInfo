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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E532C0", Offset = "0x1E522C0", VA = "0x181E532C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate DBDOFJKDFII<TActionKind, TPayload> FOKHDGLHMOJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction NHEIOOJEOJP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BPBMJMABDKF<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGLGENBDGKP<object, AABLFGLHLFL>> DOJCBMJCAGI(TDeps AKOGIKBAMPF, TRoot OPFDMIOAEHD, TSerializedAction NHEIOOJEOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NOFJMABBBPP<TActionKind, TSerializedAction, TRoot, TDeps> : AKCFNDEBMDK where TDeps : BFNHHGDMKBD.MBIBLJLDHEM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KOPMBDPCNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction OKFOKOCDNGG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x40C9F70", Offset = "0x40C8F70", VA = "0x1840C9F70")]
	public NOFJMABBBPP([In] TDeps AKOGIKBAMPF, [In] TSerializedAction NHEIOOJEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40C9D40", Offset = "0x40C8D40", VA = "0x1840C9D40", Slot = "7")]
	public override string MGJEJBNDCKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DBDOFJKDFII<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind JEKCKHGCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BPPOPIMNIPF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51E4190", Offset = "0x51E3190", VA = "0x1851E4190")]
	internal DBDOFJKDFII(TActionKind EPEPEPKLPKN, [In] TPayload KKAPFENLPIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LIEMJOMOAGP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2963520", Offset = "0x2962520", VA = "0x182963520")]
	public static DBDOFJKDFII<TActionKind, TPayload> MGIIAIMPALM<TActionKind, TPayload>([In] TActionKind EPEPEPKLPKN, [In] TPayload KKAPFENLPIM)
	{
		return default(DBDOFJKDFII<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PGLGENBDGKP<TOk, TErr>> KDHCLJOHGLA<TRoot, TPayload, TOk, TErr>(TRoot OPFDMIOAEHD, TPayload KKAPFENLPIM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PGLGENBDGKP<TOk, TErr> KBDBLIDIFNM<TRoot, TPayload, TOk, TErr>(TRoot OPFDMIOAEHD, [In] TPayload KKAPFENLPIM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EHAEGNKHIGE<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : BFNHHGDMKBD.MBIBLJLDHEM<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KBLIHAJBJPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public EHAEGNKHIGE<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D58780", Offset = "0x3D57780", VA = "0x183D58780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D58C10", Offset = "0x3D57C10", VA = "0x183D58C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, BPBMJMABDKF<TSerializedAction, TRoot, TDeps>> FELDBKNKOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KOPMBDPCNDC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
	internal EHAEGNKHIGE(Dictionary<TActionKind, BPBMJMABDKF<TSerializedAction, TRoot, TDeps>> EDLKKICAHGC, TDeps AKOGIKBAMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x350CDA0", Offset = "0x350BDA0", VA = "0x18350CDA0")]
	[AsyncStateMachine(typeof(EHAEGNKHIGE<, , , >.KBLIHAJBJPG))]
	public Task<PGLGENBDGKP<object, AABLFGLHLFL>> DOJCBMJCAGI(TRoot OPFDMIOAEHD, TSerializedAction NHEIOOJEOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BFNHHGDMKBD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MBIBLJLDHEM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind BEFJNNIIHGB(TSerializedAction HFLBADIEKAM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MOBHOFIPEII(TRoot OPFDMIOAEHD, TSerializedAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KPGKFDJIAML(TRoot OPFDMIOAEHD, TSerializedAction LNMJHEPMAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26BA190", Offset = "0x26B9190", VA = "0x1826BA190")]
	internal static EHAEGNKHIGE<TActionKind, TSerializedAction, TRoot, TDeps> MGIIAIMPALM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, BPBMJMABDKF<TSerializedAction, TRoot, TDeps>> EDLKKICAHGC, TDeps AKOGIKBAMPF) where TDeps : MBIBLJLDHEM<TActionKind, TSerializedAction, TRoot>
	{
		return default(EHAEGNKHIGE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DBNJLBAEHGN<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, BPBMJMABDKF<TSerializedAction, TRoot, TDeps>> PNIFLOAIAGK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	private DBNJLBAEHGN(Dictionary<TActionKind, BPBMJMABDKF<TSerializedAction, TRoot, TDeps>> EDLKKICAHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x51E4B60", Offset = "0x51E3B60", VA = "0x1851E4B60")]
	public static DBNJLBAEHGN<TActionKind, TSerializedAction, TRoot, TDeps> MGIIAIMPALM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KKILFCDNNAI<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, BFNHHGDMKBD.MBIBLJLDHEM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class EFEPEKNOFDP<TPayload, TOk, TErr> : BPBMJMABDKF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AABLFGLHLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FOKHDGLHMOJ<TActionKind, TSerializedAction, TPayload> LNNHOAGOLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KBDBLIDIFNM<TRoot, TPayload, TOk, TErr> LDOOMNCJJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool EPJGPLAGELF;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x34EE6D0", Offset = "0x34ED6D0", VA = "0x1834EE6D0")]
		public EFEPEKNOFDP(FOKHDGLHMOJ<TActionKind, TSerializedAction, TPayload> MEMPBBBKPIC, KBDBLIDIFNM<TRoot, TPayload, TOk, TErr> AMDMDBNCJJM, bool IFAKKHGAKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x34E9A30", Offset = "0x34E8A30", VA = "0x1834E9A30", Slot = "4")]
		public Task<PGLGENBDGKP<object, AABLFGLHLFL>> DOJCBMJCAGI(TDeps AKOGIKBAMPF, TRoot OPFDMIOAEHD, TSerializedAction NHEIOOJEOJP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IPBJJPDAAJK<TPayload, TOk, TErr> : BPBMJMABDKF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AABLFGLHLFL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct MIOCHDNHKHE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PGLGENBDGKP<object?, AABLFGLHLFL>> <>t__builder;

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
			public IPBJJPDAAJK<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PGLGENBDGKP<object?, AABLFGLHLFL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PGLGENBDGKP<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x40426C0", Offset = "0x40416C0", VA = "0x1840426C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40442B0", Offset = "0x40432B0", VA = "0x1840442B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly FOKHDGLHMOJ<TActionKind, TSerializedAction, TPayload> LNNHOAGOLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly KDHCLJOHGLA<TRoot, TPayload, TOk, TErr> LDOOMNCJJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool EPJGPLAGELF;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x34EE6D0", Offset = "0x34ED6D0", VA = "0x1834EE6D0")]
		public IPBJJPDAAJK(FOKHDGLHMOJ<TActionKind, TSerializedAction, TPayload> MEMPBBBKPIC, KDHCLJOHGLA<TRoot, TPayload, TOk, TErr> AMDMDBNCJJM, bool IFAKKHGAKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B26880", Offset = "0x3B25880", VA = "0x183B26880", Slot = "4")]
		[AsyncStateMachine(typeof(IPBJJPDAAJK<, , >.MIOCHDNHKHE))]
		public Task<PGLGENBDGKP<object, AABLFGLHLFL>> DOJCBMJCAGI(TDeps AKOGIKBAMPF, TRoot OPFDMIOAEHD, TSerializedAction NHEIOOJEOJP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DBNJLBAEHGN<TActionKind, TSerializedAction, TRoot, TDeps> GBOCLODMIOP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	private KKILFCDNNAI(DBNJLBAEHGN<TActionKind, TSerializedAction, TRoot, TDeps> GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D9AB10", Offset = "0x3D99B10", VA = "0x183D9AB10")]
	public static KKILFCDNNAI<TActionKind, TSerializedAction, TRoot, TDeps> MGIIAIMPALM()
	{
		return default(KKILFCDNNAI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27CECF0", Offset = "0x27CDCF0", VA = "0x1827CECF0")]
	public KKILFCDNNAI<TActionKind, TSerializedAction, TRoot, TDeps> LJLFNFJDAJJ<TPayload, TOk, TErr>(TActionKind EPEPEPKLPKN, FOKHDGLHMOJ<TActionKind, TSerializedAction, TPayload> MEMPBBBKPIC, KBDBLIDIFNM<TRoot, TPayload, TOk, TErr> AMDMDBNCJJM, bool IFAKKHGAKEB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AABLFGLHLFL
	{
		return default(KKILFCDNNAI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27CECF0", Offset = "0x27CDCF0", VA = "0x1827CECF0")]
	public KKILFCDNNAI<TActionKind, TSerializedAction, TRoot, TDeps> IALALNNHGKI<TPayload, TOk, TErr>(TActionKind EPEPEPKLPKN, FOKHDGLHMOJ<TActionKind, TSerializedAction, TPayload> MEMPBBBKPIC, KDHCLJOHGLA<TRoot, TPayload, TOk, TErr> AMDMDBNCJJM, bool IFAKKHGAKEB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AABLFGLHLFL
	{
		return default(KKILFCDNNAI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D9AA60", Offset = "0x3D99A60", VA = "0x183D9AA60")]
	public EHAEGNKHIGE<TActionKind, TSerializedAction, TRoot, TDeps> FKKJHBGFFND(TDeps AKOGIKBAMPF)
	{
		return default(EHAEGNKHIGE<TActionKind, TSerializedAction, TRoot, TDeps>);
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
