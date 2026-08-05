using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MJIDKPGONBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class FHIFNMKGNEE<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] ABOGCFJOCAD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27C9B40", Offset = "0x27C8940", VA = "0x1827C9B40")]
	public static void DALBFPDKBEO<TField>(int AELAKOMEEDP, string PHEKPMAPPHM, CHENFBANGOH FHGOEMJGCAF, [Out] JGFAHCEHMCM<TField> CINANBNCBIJ) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFB0", Offset = "0x27CADB0", VA = "0x1827CBFB0")]
	public static void LCJGLBOMLIJ<TField>(int AELAKOMEEDP, string PHEKPMAPPHM, [Out] INGFHJHDPPO<TField> OOFPAAIKGCN) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class NGFELHPBLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x620DFE0", Offset = "0x620CDE0", VA = "0x18620DFE0")]
	public static FieldInfo[] AENHFCNMNCE(Type DDEINLAGLLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CPAPBLJCFKG<View, Data> : EANIEADIONO where View : struct, MJIDKPGONBF where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType BAKEMFEHEEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type ODHLLOEJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E07C60", Offset = "0x4E06A60", VA = "0x184E07C60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type KCCHIIFALLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E08FE0", Offset = "0x4E07DE0", VA = "0x184E08FE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int GFACBJFGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4E06FF0", Offset = "0x4E05DF0", VA = "0x184E06FF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View HPMIPAJMFBG(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2698F30", Offset = "0x2697D30", VA = "0x182698F30", Slot = "15")]
	public override T HPMIPAJMFBG<T>(Entity IBOBFMDOLFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
	protected CPAPBLJCFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EANIEADIONO : CHENFBANGOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle LMMGHNIPOPK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager FBNPOHPPCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x13693C0", Offset = "0x13681C0", VA = "0x1813693C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type ODHLLOEJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type KCCHIIFALLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int GFACBJFGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type BNOFDKMHDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x383E2E0", Offset = "0x383D0E0", VA = "0x18383E2E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int ENCCBLFNOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x620DEE0", Offset = "0x620CCE0", VA = "0x18620DEE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private KCEOLLMAHMG[] PDPLEFKLLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAB8D40", Offset = "0xAB7B40", VA = "0x180AB8D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual KCEOLLMAHMG[] GEIIIHNKIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x620DF50", Offset = "0x620CD50", VA = "0x18620DF50", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x620DBC0", Offset = "0x620C9C0", VA = "0x18620DBC0")]
	public void HBPIHILNAPB(EntityManager BCAONBAACAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T HPMIPAJMFBG<T>(Entity IBOBFMDOLFK) where T : struct, MJIDKPGONBF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x620DD00", Offset = "0x620CB00", VA = "0x18620DD00", Slot = "8")]
	public (uint, uint) KJGAINBHMJG(Entity IBOBFMDOLFK)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x620DDF0", Offset = "0x620CBF0", VA = "0x18620DDF0", Slot = "9")]
	public bool KKNDHIJHCAF(Entity IBOBFMDOLFK, (uint order, uint change) MIJEJKOAIDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected EANIEADIONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IBOLIIFPEIN
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LDJNHENMGAB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LDJNHENMGAB()
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
