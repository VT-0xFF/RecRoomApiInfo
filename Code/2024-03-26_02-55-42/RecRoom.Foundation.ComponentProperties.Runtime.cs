using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OPOEDDCBANK
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class ACCICMJHLJF<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] HNCJCHGHEHB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22DB480", Offset = "0x22DA880", VA = "0x1822DB480")]
	public static void NHLEMNBOACD<TField>(int PMLKPJNGBAD, string CCNKHEJHFKM, LOKJOECENDK EPBEDPNBBCL, [Out] OLDJDOOGOCO<TField> KENAPEDMLDN) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22DAF40", Offset = "0x22DA340", VA = "0x1822DAF40")]
	public static void CDIIBIOPCIE<TField>(int PMLKPJNGBAD, string CCNKHEJHFKM, [Out] FPIAKKBMKOD<TField> BFCPIIHILCK) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class EOKIACBBMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61B2350", Offset = "0x61B1750", VA = "0x1861B2350")]
	public static FieldInfo[] FOBAKDIMKMA(Type NBMJAHOKHAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HMADGEFEGFK<View, Data> : PMILKAHJIJJ where View : struct, OPOEDDCBANK where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType HNCCBFOCODG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type DGBBEJALDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x387A1D0", Offset = "0x38795D0", VA = "0x18387A1D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type OFFANEKFHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x387B250", Offset = "0x387A650", VA = "0x18387B250", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int MEECKLKEIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x387B370", Offset = "0x387A770", VA = "0x18387B370", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View NPCMNHHPBNC(Entity OGLHBJLEIOC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24AE4F0", Offset = "0x24AD8F0", VA = "0x1824AE4F0", Slot = "15")]
	public override T NPCMNHHPBNC<T>(Entity OGLHBJLEIOC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
	protected HMADGEFEGFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PMILKAHJIJJ : LOKJOECENDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle FFIJDGCKDFK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager MELDPEPFNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type DGBBEJALDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type OFFANEKFHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int MEECKLKEIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type DONFHAAENNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3849300", Offset = "0x3848700", VA = "0x183849300", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int PNNKOCELGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61B2840", Offset = "0x61B1C40", VA = "0x1861B2840", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DLJCHKGNAAL[] NCDPHEHBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x21711F0", Offset = "0x21705F0", VA = "0x1821711F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual DLJCHKGNAAL[] AODGCONKJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61B27B0", Offset = "0x61B1BB0", VA = "0x1861B27B0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61B2580", Offset = "0x61B1980", VA = "0x1861B2580")]
	public void EOPEJCOCBHD(EntityManager CDKDONGNIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T NPCMNHHPBNC<T>(Entity OGLHBJLEIOC) where T : struct, OPOEDDCBANK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61B26C0", Offset = "0x61B1AC0", VA = "0x1861B26C0", Slot = "8")]
	public (uint, uint) FNIBBJMKALI(Entity OGLHBJLEIOC)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61B2490", Offset = "0x61B1890", VA = "0x1861B2490", Slot = "9")]
	public bool BLOIIHMALHP(Entity OGLHBJLEIOC, (uint order, uint change) PAKIAOEKDPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected PMILKAHJIJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KAHGFNCLGIN
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GGOHFKMAPDD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public GGOHFKMAPDD()
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
