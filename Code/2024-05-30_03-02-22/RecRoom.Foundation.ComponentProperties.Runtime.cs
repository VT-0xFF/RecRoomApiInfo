using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GKOELECAOJK
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class LOGIFNICBEM<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] AGGHPADBBHP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2891360", Offset = "0x2890560", VA = "0x182891360")]
	public static void JKMINFBIHEJ<TField>(int PMNHOLIPOMJ, string IIADHBOODBK, DKGJCOLIFOJ EGKPNGCIABF, [Out] AGLHDIFCFOB<TField> EHMJOHOMDOD) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2890CA0", Offset = "0x288FEA0", VA = "0x182890CA0")]
	public static void AGHKFCKOCDA<TField>(int PMNHOLIPOMJ, string IIADHBOODBK, [Out] AKLFANKGLAK<TField> HFIBFDNGBHE) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class MNPHLMBIBEI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63F4CD0", Offset = "0x63F3ED0", VA = "0x1863F4CD0")]
	public static FieldInfo[] CJABPNFDGME(Type HHJOOHJDNNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class LEGNEMCHGFP<View, Data> : ACIEECMHDBP where View : struct, GKOELECAOJK where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType LLFMBNJBMEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type EEOCDMEBAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F35480", Offset = "0x3F34680", VA = "0x183F35480", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type OEFGJKPFNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3F35F00", Offset = "0x3F35100", VA = "0x183F35F00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int DBNLFBDGKPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3F369E0", Offset = "0x3F35BE0", VA = "0x183F369E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View LNCGGCPBLKA(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x286B630", Offset = "0x286A830", VA = "0x18286B630", Slot = "15")]
	public override T LNCGGCPBLKA<T>(Entity FOJNONDDGDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
	protected LEGNEMCHGFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class ACIEECMHDBP : DKGJCOLIFOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle IGFJIFFBFGM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager CINBCAKEAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x142DE70", Offset = "0x142D070", VA = "0x18142DE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type EEOCDMEBAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type OEFGJKPFNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int DBNLFBDGKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type KCEHDCDFLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x399F840", Offset = "0x399EA40", VA = "0x18399F840", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int DENKIDPAION
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x63F4C60", Offset = "0x63F3E60", VA = "0x1863F4C60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private NCIJLJCLLBO[] EPCIELFANFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAE4830", Offset = "0xAE3A30", VA = "0x180AE4830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual NCIJLJCLLBO[] LEMPDMCCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x63F4AE0", Offset = "0x63F3CE0", VA = "0x1863F4AE0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63F48B0", Offset = "0x63F3AB0", VA = "0x1863F48B0")]
	public void CNOOLEDIEBH(EntityManager CAODHPOMABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T LNCGGCPBLKA<T>(Entity FOJNONDDGDN) where T : struct, GKOELECAOJK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63F4B70", Offset = "0x63F3D70", VA = "0x1863F4B70", Slot = "8")]
	public (uint, uint) IKKNDGLGFIK(Entity FOJNONDDGDN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63F49F0", Offset = "0x63F3BF0", VA = "0x1863F49F0", Slot = "9")]
	public bool DAHJOMOCFJA(Entity FOJNONDDGDN, (uint order, uint change) DHGBHLPPCDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected ACIEECMHDBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GEDHLMMMAHF
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MIKFNFJDMKB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MIKFNFJDMKB()
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
