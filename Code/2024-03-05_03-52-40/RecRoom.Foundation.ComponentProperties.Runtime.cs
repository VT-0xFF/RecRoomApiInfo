using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DPHHBGHMKAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class IGOCGNBLCPK<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] CGLOIJDHLPN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x244BA30", Offset = "0x244A830", VA = "0x18244BA30")]
	public static void GKDHBJBDCLB<TField>(int OHINPGIGDNE, string OCCHBLONHPL, IBNFBAMIIPM MFMCNKPOLBN, [Out] IIAFPNKGPOL<TField> EIJAJNKHLMI) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x244D960", Offset = "0x244C760", VA = "0x18244D960")]
	public static void LNGCPJMPNLF<TField>(int OHINPGIGDNE, string OCCHBLONHPL, [Out] MENBIMFAEDP<TField> AOPFLAFGCLL) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class CEFHFNGFJBG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60D9660", Offset = "0x60D8460", VA = "0x1860D9660")]
	public static FieldInfo[] LOCBFKKNMKH(Type LPFFKBBBCBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JODDJOIANPF<View, Data> : KDEBEHMICDF where View : struct, DPHHBGHMKAH where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType OGPKPBCMGCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type AJNBNKIJPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3A7EEE0", Offset = "0x3A7DCE0", VA = "0x183A7EEE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type LACNNHHLHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3A7EAC0", Offset = "0x3A7D8C0", VA = "0x183A7EAC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int GOAAKKEFFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3A7FE40", Offset = "0x3A7EC40", VA = "0x183A7FE40", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View KOBAFAJMPKG(Entity JLCPBIBMCCJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x244E090", Offset = "0x244CE90", VA = "0x18244E090", Slot = "15")]
	public override T KOBAFAJMPKG<T>(Entity JLCPBIBMCCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
	protected JODDJOIANPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class KDEBEHMICDF : IBNFBAMIIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle JKKCHCIFFIO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager BFMJGNLOKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x130E730", Offset = "0x130D530", VA = "0x18130E730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type AJNBNKIJPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type LACNNHHLHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int GOAAKKEFFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type IDCINNAKCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37C8310", Offset = "0x37C7110", VA = "0x1837C8310", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int DAPEALLEOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60D9830", Offset = "0x60D8630", VA = "0x1860D9830", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DMMAAODJPCL[] EDGHELHIODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2113C10", Offset = "0x2112A10", VA = "0x182113C10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual DMMAAODJPCL[] NBEPILANCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60D97A0", Offset = "0x60D85A0", VA = "0x1860D97A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60D9990", Offset = "0x60D8790", VA = "0x1860D9990")]
	public void KCJBJGBIMAI(EntityManager MDAGMBDMCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T KOBAFAJMPKG<T>(Entity JLCPBIBMCCJ) where T : struct, DPHHBGHMKAH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60D98A0", Offset = "0x60D86A0", VA = "0x1860D98A0", Slot = "8")]
	public (uint, uint) JEPEHINAOKE(Entity JLCPBIBMCCJ)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60D9AD0", Offset = "0x60D88D0", VA = "0x1860D9AD0", Slot = "9")]
	public bool LPAIPNNKPFM(Entity JLCPBIBMCCJ, (uint order, uint change) OCEOBDFJNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected KDEBEHMICDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DMDDHLJBMOA
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HPJJGAKKNAL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HPJJGAKKNAL()
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
