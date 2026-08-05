using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CJAKPFKCCCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class FEOBCACDGPB<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] GPKJGOMIPGH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x266CC90", Offset = "0x266BE90", VA = "0x18266CC90")]
	public static void HLNLLINCCLA<TField>(int MBGANDEDPDN, string MPENHPFDCDK, BKMMKBCMGBC OMBOOCPJAFJ, [Out] MKKKMENBGOL<TField> BMIMCNPMKAE) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x266F1C0", Offset = "0x266E3C0", VA = "0x18266F1C0")]
	public static void PMABPPKGGPK<TField>(int MBGANDEDPDN, string MPENHPFDCDK, [Out] NKDILCMHFJA<TField> CCKNMJLGCHL) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class EIFPCBHDPFC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x612AC50", Offset = "0x6129E50", VA = "0x18612AC50")]
	public static FieldInfo[] PBAEPPPANEF(Type MJMAEGDPBNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class LBADIJNLAOO<View, Data> : LAKJMBDBKGD where View : struct, CJAKPFKCCCM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType DEONNAJAPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type AJIMGIEPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C1D0", Offset = "0x3D4B3D0", VA = "0x183D4C1D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type HOGFHICJMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3D4B8D0", Offset = "0x3D4AAD0", VA = "0x183D4B8D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int DJFCKOAOIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D1F0", Offset = "0x3D4C3F0", VA = "0x183D4D1F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View FICPENOPBCF(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27ADB70", Offset = "0x27ACD70", VA = "0x1827ADB70", Slot = "15")]
	public override T FICPENOPBCF<T>(Entity ACPAMCNIKHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
	protected LBADIJNLAOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class LAKJMBDBKGD : BKMMKBCMGBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle DELKNIEOPKB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager NHEHCCGMCJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type AJIMGIEPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type HOGFHICJMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int DJFCKOAOIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type IJKOKDAFBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3895C40", Offset = "0x3894E40", VA = "0x183895C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int LGMKFMALKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x612AFF0", Offset = "0x612A1F0", VA = "0x18612AFF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private POBGGKBBIKM[] PBIBFONENMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xABB440", Offset = "0xABA640", VA = "0x180ABB440", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual POBGGKBBIKM[] FCLIHNICCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x612AD80", Offset = "0x6129F80", VA = "0x18612AD80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x612B060", Offset = "0x612A260", VA = "0x18612B060")]
	public void MEJEOBIHPJE(EntityManager EIHNJKMOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T FICPENOPBCF<T>(Entity ACPAMCNIKHM) where T : struct, CJAKPFKCCCM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x612AE10", Offset = "0x612A010", VA = "0x18612AE10", Slot = "8")]
	public (uint, uint) DCHNMHHLHDN(Entity ACPAMCNIKHM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x612AF00", Offset = "0x612A100", VA = "0x18612AF00", Slot = "9")]
	public bool LBGKHJACJJA(Entity ACPAMCNIKHM, (uint order, uint change) BKPHPJDBECD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected LAKJMBDBKGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HBOFDALPGLE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HDGKNGCCBDL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HDGKNGCCBDL()
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
