using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BMBGJEDJJKC
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class FMELAPFKLKF<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] CBCIMOLIBLD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26F6BE0", Offset = "0x26F55E0", VA = "0x1826F6BE0")]
	public static void GKPIMNAJPHM<TField>(int ABBNIPHGMGH, string GKDOOPOCBPP, PDLNDJNECDK GFBPEPFJGCG, [Out] CHMNJBFIOJP<TField> DMJMLGBLOFK) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26F7E50", Offset = "0x26F6850", VA = "0x1826F7E50")]
	public static void LPCKAHDOGMB<TField>(int ABBNIPHGMGH, string GKDOOPOCBPP, [Out] ICAFADEJOLA<TField> AMPADKKCLFC) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class BEJBBOBLPEG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6333CC0", Offset = "0x63326C0", VA = "0x186333CC0")]
	public static FieldInfo[] DHKFFNLJMNN(Type CGEOAHHPHHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class IAOJJHMNOHP<View, Data> : BEJCICNODIB where View : struct, BMBGJEDJJKC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType OKPBLFCMNIA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type PABBBMGFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2AA0", Offset = "0x3AA14A0", VA = "0x183AA2AA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type GAKCOOKLEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3AA1C60", Offset = "0x3AA0660", VA = "0x183AA1C60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int OJFOCADMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3880", Offset = "0x3AA2280", VA = "0x183AA3880", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View FGHEOIFPKCI(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x281E690", Offset = "0x281D090", VA = "0x18281E690", Slot = "15")]
	public override T FGHEOIFPKCI<T>(Entity DFBELOGKKCC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
	protected IAOJJHMNOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class BEJCICNODIB : PDLNDJNECDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle IPLKLGMKJFF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager NMNDJPANEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x13A19C0", Offset = "0x13A03C0", VA = "0x1813A19C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type PABBBMGFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type GAKCOOKLEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int OJFOCADMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type EHNMAJIHILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3506660", Offset = "0x3505060", VA = "0x183506660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int BPLOANBOPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6333E90", Offset = "0x6332890", VA = "0x186333E90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private LPBPPKKEEHB[] EEAAPHJCPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAC72E0", Offset = "0xAC5CE0", VA = "0x180AC72E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual LPBPPKKEEHB[] JHBAEFHLFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6333E00", Offset = "0x6332800", VA = "0x186333E00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63340E0", Offset = "0x6332AE0", VA = "0x1863340E0")]
	public void MPOMBMILLLK(EntityManager KBFJIBCFALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T FGHEOIFPKCI<T>(Entity DFBELOGKKCC) where T : struct, BMBGJEDJJKC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6333FF0", Offset = "0x63329F0", VA = "0x186333FF0", Slot = "8")]
	public (uint, uint) KKNLDIKMFBN(Entity DFBELOGKKCC)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6333F00", Offset = "0x6332900", VA = "0x186333F00", Slot = "9")]
	public bool CPKKJLNJKOJ(Entity DFBELOGKKCC, (uint order, uint change) LHMJGBJEDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected BEJCICNODIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LNNGBIEIPBH
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FJLMCBABILJ
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FJLMCBABILJ()
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
