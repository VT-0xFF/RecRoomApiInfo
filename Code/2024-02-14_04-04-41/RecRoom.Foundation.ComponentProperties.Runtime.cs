using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KAKOOPEONAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class MLJDCHKGJBJ<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] MOAGBKBKOBK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x256DC30", Offset = "0x256D030", VA = "0x18256DC30")]
	public static void ILCJMFGENDD<TField>(int OJANCMLFDOJ, string OMHHPMIDNAN, PAOCMPDODHC PDODIMHAMNI, [Out] POMLKHKJILK<TField> EEAABMKADCD) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x256D7B0", Offset = "0x256CBB0", VA = "0x18256D7B0")]
	public static void IHGFNLOPMGM<TField>(int OJANCMLFDOJ, string OMHHPMIDNAN, [Out] HOHPJKMJIGL<TField> OJJLJELNBFL) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class JFLNNLPGGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F460D0", Offset = "0x5F454D0", VA = "0x185F460D0")]
	public static FieldInfo[] EEDOALPHMFE(Type ADAMDPHPFAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PLIPPLFLPCB<View, Data> : DBBHMFCMFNA where View : struct, KAKOOPEONAH where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType IKCJPHCIIHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type HGHFBCFFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCED0", Offset = "0x3FCC2D0", VA = "0x183FCCED0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type HNMBDADBMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDB30", Offset = "0x3FCCF30", VA = "0x183FCDB30", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int EFDBOLLDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDFB0", Offset = "0x3FCD3B0", VA = "0x183FCDFB0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View JFOAKBCONDP(Entity IBMHOJHGCIG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x25706E0", Offset = "0x256FAE0", VA = "0x1825706E0", Slot = "15")]
	public override T JFOAKBCONDP<T>(Entity IBMHOJHGCIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
	protected PLIPPLFLPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DBBHMFCMFNA : PAOCMPDODHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle CJAAOIMJBHP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager HIPFBDMCCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1276410", Offset = "0x1275810", VA = "0x181276410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type HGHFBCFFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type HNMBDADBMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int EFDBOLLDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type CMMOECFIIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36D05C0", Offset = "0x36CF9C0", VA = "0x1836D05C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int NONEJHCBGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F45F20", Offset = "0x5F45320", VA = "0x185F45F20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private EHBIFAGHOFK[] LHEHOCKOJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x20B0320", Offset = "0x20AF720", VA = "0x1820B0320", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual EHBIFAGHOFK[] FEHOFHIGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5F45DA0", Offset = "0x5F451A0", VA = "0x185F45DA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F45F90", Offset = "0x5F45390", VA = "0x185F45F90")]
	public void NGFHLNOOHDK(EntityManager KFOGOLNDMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T JFOAKBCONDP<T>(Entity IBMHOJHGCIG) where T : struct, KAKOOPEONAH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F45E30", Offset = "0x5F45230", VA = "0x185F45E30", Slot = "8")]
	public (uint, uint) FNEDBPIGBFG(Entity IBMHOJHGCIG)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F45CB0", Offset = "0x5F450B0", VA = "0x185F45CB0", Slot = "9")]
	public bool BOHMEDKFDGD(Entity IBMHOJHGCIG, (uint order, uint change) OMDPMMKPCNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected DBBHMFCMFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EPKGJFIPCOG
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MOKIHPOCJIO
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MOKIHPOCJIO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
