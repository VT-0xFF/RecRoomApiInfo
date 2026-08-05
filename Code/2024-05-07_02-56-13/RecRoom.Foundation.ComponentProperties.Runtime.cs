using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HDJOPFOEMAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class GKFPPKGAFLF<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] BEBMKKMKMCK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2579540", Offset = "0x2578740", VA = "0x182579540")]
	public static void BKIPNDCCMJI<TField>(int HMFNCGHECPG, string IKEFBMMMAJB, EFJPOPCFEBL KKJNMBCBOEJ, [Out] IPJDEPGKKOL<TField> KCBHGLJDNNP) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x257BB30", Offset = "0x257AD30", VA = "0x18257BB30")]
	public static void OENAGBBBFKJ<TField>(int HMFNCGHECPG, string IKEFBMMMAJB, [Out] NHBFCLBDPEE<TField> COCPAGHPOPH) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class FMIDLKJDDHH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61E57C0", Offset = "0x61E49C0", VA = "0x1861E57C0")]
	public static FieldInfo[] MDBCFNPBOBH(Type FLPJMDMACMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BMPHMGKLEHC<View, Data> : BMDPJHFGELP where View : struct, HDJOPFOEMAB where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType NNPNBIPPBFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type EHLKPNLBKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x48B1E30", Offset = "0x48B1030", VA = "0x1848B1E30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type FNFKEIIECKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x48B0870", Offset = "0x48AFA70", VA = "0x1848B0870", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int LGJDNPKGIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x48B2730", Offset = "0x48B1930", VA = "0x1848B2730", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View HKOAFCEMFKN(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x23DA510", Offset = "0x23D9710", VA = "0x1823DA510", Slot = "15")]
	public override T HKOAFCEMFKN<T>(Entity NFFCGLFHPNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
	protected BMPHMGKLEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class BMDPJHFGELP : EFJPOPCFEBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle JLIKCNIDLKF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager OGMFHBAHCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1380DC0", Offset = "0x137FFC0", VA = "0x181380DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type EHLKPNLBKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type FNFKEIIECKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int LGJDNPKGIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type MDIJFHDDFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3887AD0", Offset = "0x3886CD0", VA = "0x183887AD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int JCEKKJOFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61E5660", Offset = "0x61E4860", VA = "0x1861E5660", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private CBLKJOJOGPN[] DEPLOMJLNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAB2750", Offset = "0xAB1950", VA = "0x180AB2750", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual CBLKJOJOGPN[] JMDKMCNOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61E54E0", Offset = "0x61E46E0", VA = "0x1861E54E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61E53A0", Offset = "0x61E45A0", VA = "0x1861E53A0")]
	public void GEJAFFIMNGM(EntityManager LMKGBBMBMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T HKOAFCEMFKN<T>(Entity NFFCGLFHPNG) where T : struct, HDJOPFOEMAB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61E5570", Offset = "0x61E4770", VA = "0x1861E5570", Slot = "8")]
	public (uint, uint) LLPFBECDKKK(Entity NFFCGLFHPNG)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61E56D0", Offset = "0x61E48D0", VA = "0x1861E56D0", Slot = "9")]
	public bool OOMMFEJINGJ(Entity NFFCGLFHPNG, (uint order, uint change) LOGOABBJBAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected BMDPJHFGELP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DOLCBIBLLJI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NIBLCMOALME
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NIBLCMOALME()
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
