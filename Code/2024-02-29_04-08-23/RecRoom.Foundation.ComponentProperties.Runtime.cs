using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EFLJMIKJDOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class KHPNIKDBDBL<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] OCDGPEIHFLJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x241A890", Offset = "0x2419690", VA = "0x18241A890")]
	public static void NOBFAHGLKBG<TField>(int ENPOKNEMOMH, string OHHBGJPCFJD, MLADHNOGMKM HICPJBLIKML, [Out] CIMCLNAEFEN<TField> EDANCLIIPKG) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x241A350", Offset = "0x2419150", VA = "0x18241A350")]
	public static void BMBMGIHMAKM<TField>(int ENPOKNEMOMH, string OHHBGJPCFJD, [Out] DJEGHLLJLPD<TField> FEDBJFFPCAF) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class PFIOLJLLLLA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFF50", Offset = "0x5FEED50", VA = "0x185FEFF50")]
	public static FieldInfo[] GADIPIEIKCB(Type HFFNCGFKMBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BPAFBLAFLMF<View, Data> : LMIGMJPCLHI where View : struct, EFLJMIKJDOL where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType EPGAJCMGFKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type AMPAONADCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x46BFC70", Offset = "0x46BEA70", VA = "0x1846BFC70", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type ONFDAPMOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x46C0CF0", Offset = "0x46BFAF0", VA = "0x1846C0CF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int IFCDOHMIHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x46C15F0", Offset = "0x46C03F0", VA = "0x1846C15F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View OBPCNBJJCHL(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x224CC40", Offset = "0x224BA40", VA = "0x18224CC40", Slot = "15")]
	public override T OBPCNBJJCHL<T>(Entity KEAAKDKHLOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
	protected BPAFBLAFLMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class LMIGMJPCLHI : MLADHNOGMKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle ALFCIDLJECE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager DKPFEFECAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12A3400", Offset = "0x12A2200", VA = "0x1812A3400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type AMPAONADCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type ONFDAPMOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int IFCDOHMIHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type KINLNNBFIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D430", Offset = "0x3B9C230", VA = "0x183B9D430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int GACMLDHJIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFDF0", Offset = "0x5FEEBF0", VA = "0x185FEFDF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DCNLFJJFHMC[] MACBCGNILDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x20E87D0", Offset = "0x20E75D0", VA = "0x1820E87D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual DCNLFJJFHMC[] MABGAKOHJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFD60", Offset = "0x5FEEB60", VA = "0x185FEFD60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFC20", Offset = "0x5FEEA20", VA = "0x185FEFC20")]
	public void FCIFMHNEBDM(EntityManager FAPAMPDMFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T OBPCNBJJCHL<T>(Entity KEAAKDKHLOM) where T : struct, EFLJMIKJDOL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFB30", Offset = "0x5FEE930", VA = "0x185FEFB30", Slot = "8")]
	public (uint, uint) BHMABKOICNO(Entity KEAAKDKHLOM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFE60", Offset = "0x5FEEC60", VA = "0x185FEFE60", Slot = "9")]
	public bool KDCNOJCNMMO(Entity KEAAKDKHLOM, (uint order, uint change) ILCLKBNEPAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected LMIGMJPCLHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JGJDEHLCGDA
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JLGMMEPJMLK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JLGMMEPJMLK()
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
