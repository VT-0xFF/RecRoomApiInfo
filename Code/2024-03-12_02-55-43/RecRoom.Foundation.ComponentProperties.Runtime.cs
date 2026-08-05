using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FNICJPHGCLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class KPPPHCGCFOC<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] OEOFLMNJCCB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26A7A40", Offset = "0x26A6C40", VA = "0x1826A7A40")]
	public static void HHFPEJJIAOH<TField>(int ILNNGHKJMBD, string NLBAJPAADNH, PDADIBGCLMB OFCDJFMIPJM, [Out] NCFMPHAHLFO<TField> EPEGAGFKJNJ) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26A9A30", Offset = "0x26A8C30", VA = "0x1826A9A30")]
	public static void KGHJKJGJOMK<TField>(int ILNNGHKJMBD, string NLBAJPAADNH, [Out] JOIOFNHCNKK<TField> LBFIPBHPMNC) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class GCAKLPCILLP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6149680", Offset = "0x6148880", VA = "0x186149680")]
	public static FieldInfo[] FICGCIFIHAC(Type DMEGHACCPAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class IHPLHMNNGEB<View, Data> : ECJFNHEHJFD where View : struct, FNICJPHGCLD where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType DHJNBIKAOFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type JCDJPLNKNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x389A6C0", Offset = "0x38998C0", VA = "0x18389A6C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type ALEFHNAMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x389BB20", Offset = "0x389AD20", VA = "0x18389BB20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int ILFNPPMBMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x389AF00", Offset = "0x389A100", VA = "0x18389AF00", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View POCOMCLIPBL(Entity CHIBHEBBKEE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26A55C0", Offset = "0x26A47C0", VA = "0x1826A55C0", Slot = "15")]
	public override T POCOMCLIPBL<T>(Entity CHIBHEBBKEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
	protected IHPLHMNNGEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class ECJFNHEHJFD : PDADIBGCLMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle ADDMIIKHKJF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager JHMGPFJOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x13307D0", Offset = "0x132F9D0", VA = "0x1813307D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type JCDJPLNKNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type ALEFHNAMJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int ILFNPPMBMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type EJILOKPDACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x365A890", Offset = "0x3659A90", VA = "0x18365A890", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int NLBGMLBPGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6149580", Offset = "0x6148780", VA = "0x186149580", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BNGPNLGNJFM[] POOHBBOKKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x21402B0", Offset = "0x213F4B0", VA = "0x1821402B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual BNGPNLGNJFM[] EMJJIAMBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61495F0", Offset = "0x61487F0", VA = "0x1861495F0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6149260", Offset = "0x6148460", VA = "0x186149260")]
	public void AKCGAJHNOGB(EntityManager IACEDLKPNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T POCOMCLIPBL<T>(Entity CHIBHEBBKEE) where T : struct, FNICJPHGCLD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61493A0", Offset = "0x61485A0", VA = "0x1861493A0", Slot = "8")]
	public (uint, uint) EPDMNGMGAJL(Entity CHIBHEBBKEE)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6149490", Offset = "0x6148690", VA = "0x186149490", Slot = "9")]
	public bool FIFIFBBDKPK(Entity CHIBHEBBKEE, (uint order, uint change) LMCDLECLJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected ECJFNHEHJFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BGFDJMDPJPC
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CNDGMOJHGPO
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public CNDGMOJHGPO()
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
