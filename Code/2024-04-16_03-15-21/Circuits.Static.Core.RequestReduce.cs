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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E1CDB0", Offset = "0x1E1BFB0", VA = "0x181E1CDB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate EGEKHADCDEI<TActionKind, TPayload> HNMOHBAMMIO<TActionKind, TSerializedAction, TPayload>(TSerializedAction NJIJFPLPCOK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface JKPODCEKIMN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> IMCCPHFOFAD(TDeps OAENIJAKBHE, TRoot MFIBAFBMCBA, TSerializedAction NJIJFPLPCOK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DJIBNACHBFG<TActionKind, TSerializedAction, TRoot, TDeps> : HINLGFGENCJ where TDeps : COLNEMPFNPK.FCBAIHGFHME<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps IDCMPNFONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KMBFMMMJLOJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x509E0A0", Offset = "0x509D2A0", VA = "0x18509E0A0")]
	public DJIBNACHBFG([In] TDeps OAENIJAKBHE, [In] TSerializedAction NJIJFPLPCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x509DF80", Offset = "0x509D180", VA = "0x18509DF80", Slot = "7")]
	public override string OFOGPFNLIGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EGEKHADCDEI<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BFKFEBIEJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BJNMFJPJHJN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x341D7C0", Offset = "0x341C9C0", VA = "0x18341D7C0")]
	internal EGEKHADCDEI(TActionKind PFCFHBBDBGN, [In] TPayload JAHJOCBHFCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PEFPHGFDCHM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0F3B0", Offset = "0x2A0E5B0", VA = "0x182A0F3B0")]
	public static EGEKHADCDEI<TActionKind, TPayload> DHBNKMCPKNO<TActionKind, TPayload>([In] TActionKind PFCFHBBDBGN, [In] TPayload JAHJOCBHFCP)
	{
		return default(EGEKHADCDEI<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<OAAHAKNOJDO<TOk, TErr>> PIAOIGCLFHC<TRoot, TPayload, TOk, TErr>(TRoot MFIBAFBMCBA, TPayload JAHJOCBHFCP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate OAAHAKNOJDO<TOk, TErr> DCDJOFABKNN<TRoot, TPayload, TOk, TErr>(TRoot MFIBAFBMCBA, [In] TPayload JAHJOCBHFCP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MDBEBAFIHMA<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : COLNEMPFNPK.FCBAIHGFHME<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NHMICEBAKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MDBEBAFIHMA<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3730", Offset = "0x3FF2930", VA = "0x183FF3730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3B90", Offset = "0x3FF2D90", VA = "0x183FF3B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, JKPODCEKIMN<TSerializedAction, TRoot, TDeps>> OCBHBCIIKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps IDCMPNFONAH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x90BB40", Offset = "0x90AD40", VA = "0x18090BB40")]
	internal MDBEBAFIHMA(Dictionary<TActionKind, JKPODCEKIMN<TSerializedAction, TRoot, TDeps>> IEJDMNEODPD, TDeps OAENIJAKBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F0D060", Offset = "0x3F0C260", VA = "0x183F0D060")]
	[AsyncStateMachine(typeof(MDBEBAFIHMA<, , , >.NHMICEBAKOH))]
	public Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> IMCCPHFOFAD(TRoot MFIBAFBMCBA, TSerializedAction NJIJFPLPCOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class COLNEMPFNPK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FCBAIHGFHME<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind OMAGDDJEFPP(TSerializedAction AOFIGDLFNLH);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OPMLPCHMJJF(TRoot MFIBAFBMCBA, TSerializedAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KIILDMIKMMA(TRoot MFIBAFBMCBA, TSerializedAction OFOIHENMFDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26FA400", Offset = "0x26F9600", VA = "0x1826FA400")]
	internal static MDBEBAFIHMA<TActionKind, TSerializedAction, TRoot, TDeps> DHBNKMCPKNO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, JKPODCEKIMN<TSerializedAction, TRoot, TDeps>> IEJDMNEODPD, TDeps OAENIJAKBHE) where TDeps : FCBAIHGFHME<TActionKind, TSerializedAction, TRoot>
	{
		return default(MDBEBAFIHMA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KMLOHNDPFDI<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, JKPODCEKIMN<TSerializedAction, TRoot, TDeps>> NEDCNMACOCL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	private KMLOHNDPFDI(Dictionary<TActionKind, JKPODCEKIMN<TSerializedAction, TRoot, TDeps>> IEJDMNEODPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0E70", Offset = "0x3CC0070", VA = "0x183CC0E70")]
	public static KMLOHNDPFDI<TActionKind, TSerializedAction, TRoot, TDeps> DHBNKMCPKNO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GGDJONELNKI<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, COLNEMPFNPK.FCBAIHGFHME<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NGJPICBGFDE<TPayload, TOk, TErr> : JKPODCEKIMN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AHFOEFCGOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HNMOHBAMMIO<TActionKind, TSerializedAction, TPayload> CCCPPOIGHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly DCDJOFABKNN<TRoot, TPayload, TOk, TErr> PMPLLAIKNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool CEDJCMPIPBB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3FDBB50", Offset = "0x3FDAD50", VA = "0x183FDBB50")]
		public NGJPICBGFDE(HNMOHBAMMIO<TActionKind, TSerializedAction, TPayload> AFLNFGANNLI, DCDJOFABKNN<TRoot, TPayload, TOk, TErr> HEDANDFHJLP, bool KFMKOLFMHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3FDA3D0", Offset = "0x3FD95D0", VA = "0x183FDA3D0", Slot = "4")]
		public Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> IMCCPHFOFAD(TDeps OAENIJAKBHE, TRoot MFIBAFBMCBA, TSerializedAction NJIJFPLPCOK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class NOFHHHHHNOO<TPayload, TOk, TErr> : JKPODCEKIMN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AHFOEFCGOPM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct HGFDKBBGHDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<object?, AHFOEFCGOPM>> <>t__builder;

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
			public NOFHHHHHNOO<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private OAAHAKNOJDO<object?, AHFOEFCGOPM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OAAHAKNOJDO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x396C1A0", Offset = "0x396B3A0", VA = "0x18396C1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x396D400", Offset = "0x396C600", VA = "0x18396D400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly HNMOHBAMMIO<TActionKind, TSerializedAction, TPayload> CCCPPOIGHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly PIAOIGCLFHC<TRoot, TPayload, TOk, TErr> PMPLLAIKNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool CEDJCMPIPBB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3FDBB50", Offset = "0x3FDAD50", VA = "0x183FDBB50")]
		public NOFHHHHHNOO(HNMOHBAMMIO<TActionKind, TSerializedAction, TPayload> AFLNFGANNLI, PIAOIGCLFHC<TRoot, TPayload, TOk, TErr> HEDANDFHJLP, bool KFMKOLFMHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4015A80", Offset = "0x4014C80", VA = "0x184015A80", Slot = "4")]
		[AsyncStateMachine(typeof(NOFHHHHHNOO<, , >.HGFDKBBGHDO))]
		public Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> IMCCPHFOFAD(TDeps OAENIJAKBHE, TRoot MFIBAFBMCBA, TSerializedAction NJIJFPLPCOK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KMLOHNDPFDI<TActionKind, TSerializedAction, TRoot, TDeps> MEJDGPDEIHB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	private GGDJONELNKI(KMLOHNDPFDI<TActionKind, TSerializedAction, TRoot, TDeps> MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3862C90", Offset = "0x3861E90", VA = "0x183862C90")]
	public static GGDJONELNKI<TActionKind, TSerializedAction, TRoot, TDeps> DHBNKMCPKNO()
	{
		return default(GGDJONELNKI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26708D0", Offset = "0x266FAD0", VA = "0x1826708D0")]
	public GGDJONELNKI<TActionKind, TSerializedAction, TRoot, TDeps> PHEBOHKHLFO<TPayload, TOk, TErr>(TActionKind PFCFHBBDBGN, HNMOHBAMMIO<TActionKind, TSerializedAction, TPayload> AFLNFGANNLI, DCDJOFABKNN<TRoot, TPayload, TOk, TErr> HEDANDFHJLP, bool KFMKOLFMHLE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AHFOEFCGOPM
	{
		return default(GGDJONELNKI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26708D0", Offset = "0x266FAD0", VA = "0x1826708D0")]
	public GGDJONELNKI<TActionKind, TSerializedAction, TRoot, TDeps> PIGDAEBIMJG<TPayload, TOk, TErr>(TActionKind PFCFHBBDBGN, HNMOHBAMMIO<TActionKind, TSerializedAction, TPayload> AFLNFGANNLI, PIAOIGCLFHC<TRoot, TPayload, TOk, TErr> HEDANDFHJLP, bool KFMKOLFMHLE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AHFOEFCGOPM
	{
		return default(GGDJONELNKI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3862D20", Offset = "0x3861F20", VA = "0x183862D20")]
	public MDBEBAFIHMA<TActionKind, TSerializedAction, TRoot, TDeps> EBBDGOIFBGP(TDeps OAENIJAKBHE)
	{
		return default(MDBEBAFIHMA<TActionKind, TSerializedAction, TRoot, TDeps>);
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
