using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FBLNIHPLIAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class KOCFPKBNLHF<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] OINPLOLHPNB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x25A6640", Offset = "0x25A5240", VA = "0x1825A6640")]
	public static void EMPIMPFDLBK<TField>(int PMIDLPOCCEE, string MPGNMPAPHDB, BOHBEILCDCI JIEDPIKNENM, [Out] AJLHIJOKGMI<TField> FOGOAFCOGPF) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x25A61C0", Offset = "0x25A4DC0", VA = "0x1825A61C0")]
	public static void CEIIPIBNELF<TField>(int PMIDLPOCCEE, string MPGNMPAPHDB, [Out] OCELDCMMONB<TField> CBBGNCDFNCK) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class FLOOFEOJNPD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x611EFF0", Offset = "0x611DBF0", VA = "0x18611EFF0")]
	public static FieldInfo[] MKPMBLLFGJN(Type CJEAJMFMNNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class ACFPLCIOCGA<View, Data> : BGPDFLGLNFJ where View : struct, FBLNIHPLIAM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType CMIOFCEOLOP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type GNACHDLJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3734F10", Offset = "0x3733B10", VA = "0x183734F10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type IHFHLBIDLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3735630", Offset = "0x3734230", VA = "0x183735630", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int JPJEGOMFAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x37345F0", Offset = "0x37331F0", VA = "0x1837345F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View IDNOFIABDEN(Entity CMFPBPOIOPE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x22F55F0", Offset = "0x22F41F0", VA = "0x1822F55F0", Slot = "15")]
	public override T IDNOFIABDEN<T>(Entity CMFPBPOIOPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
	protected ACFPLCIOCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class BGPDFLGLNFJ : BOHBEILCDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle ENAKNOEDIEE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager ALMGLJACKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1357DE0", Offset = "0x13569E0", VA = "0x181357DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type GNACHDLJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type IHFHLBIDLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int JPJEGOMFAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type ACOCLFJKDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36930F0", Offset = "0x3691CF0", VA = "0x1836930F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int HACNJBGNBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x611EE00", Offset = "0x611DA00", VA = "0x18611EE00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DDGIJMFBIED[] NECEJCBCDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x219BCF0", Offset = "0x219A8F0", VA = "0x18219BCF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual DDGIJMFBIED[] AOIMLAOFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x611EE70", Offset = "0x611DA70", VA = "0x18611EE70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x611ECC0", Offset = "0x611D8C0", VA = "0x18611ECC0")]
	public void HAJAGMDCLHL(EntityManager DIINGHOOBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T IDNOFIABDEN<T>(Entity CMFPBPOIOPE) where T : struct, FBLNIHPLIAM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x611EF00", Offset = "0x611DB00", VA = "0x18611EF00", Slot = "8")]
	public (uint, uint) LCMBEIFDNDD(Entity CMFPBPOIOPE)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x611EBD0", Offset = "0x611D7D0", VA = "0x18611EBD0", Slot = "9")]
	public bool DACFGDCCFKK(Entity CMFPBPOIOPE, (uint order, uint change) KAHEAPGLNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected BGPDFLGLNFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HNANHPHFIJC
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ALONICFNKBO
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ALONICFNKBO()
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
