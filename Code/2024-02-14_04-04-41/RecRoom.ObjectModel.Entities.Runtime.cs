using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x600C2A0", Offset = "0x600B6A0", VA = "0x18600C2A0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OIEEBFPFACJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LALOMEGNPHJ DAEBGOEBDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HHPNHNAHBLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNFCNPCHEKO(Entity IBMHOJHGCIG, object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IDLIABILAJO(Entity IBMHOJHGCIG, object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKEEJKBHGEO(Entity IBMHOJHGCIG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGHMCKLEMEB(Entity IBMHOJHGCIG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HBBHPNCICNM<TComponentData, TValue> : FDFGNBIDIFI<TValue>, IDisposable where TComponentData : struct, OIEEBFPFACJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class JOANCLBFOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> EPNEAFACLDA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int OICIIFDIAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3014C10", Offset = "0x3014010", VA = "0x183014C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39E8E50", Offset = "0x39E8250", VA = "0x1839E8E50")]
		public bool DIPGBAHAPIF([Out] TValue FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x39E8F40", Offset = "0x39E8340", VA = "0x1839E8F40")]
		public void FLOHBAGDPJC(object FACMOGNGACN, TValue FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x39E8FF0", Offset = "0x39E83F0", VA = "0x1839E8FF0")]
		public bool NJHEJNEGCKN(object FACMOGNGACN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x39E8D70", Offset = "0x39E8170", VA = "0x1839E8D70")]
		public int CFPFFGNEMEK(object FACMOGNGACN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x39E9070", Offset = "0x39E8470", VA = "0x1839E9070")]
		public JOANCLBFOPH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<JOANCLBFOPH> IOMEIOKFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IIHGNBEDDFL<LALOMEGNPHJ, JOANCLBFOPH> NCIBGHLKAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager KFOGOLNDMKF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36CA3C0", Offset = "0x36C97C0", VA = "0x1836CA3C0")]
	public HBBHPNCICNM(EntityManager KFOGOLNDMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x36CA280", Offset = "0x36C9680", VA = "0x1836CA280", Slot = "4")]
	public void PNFCNPCHEKO(Entity IBMHOJHGCIG, object FACMOGNGACN, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36C9FF0", Offset = "0x36C93F0", VA = "0x1836C9FF0", Slot = "5")]
	public bool IDLIABILAJO(Entity IBMHOJHGCIG, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36C9DC0", Offset = "0x36C91C0", VA = "0x1836C9DC0", Slot = "6")]
	public bool DIPGBAHAPIF(Entity IBMHOJHGCIG, [Out] TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36C9EC0", Offset = "0x36C92C0", VA = "0x1836C9EC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x36C9C70", Offset = "0x36C9070", VA = "0x1836C9C70")]
	private void AHOIPHCFEEL(JOANCLBFOPH LHBJDDJFCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36C9D00", Offset = "0x36C9100", VA = "0x1836C9D00")]
	private bool DGNIILCMLDO(Entity IBMHOJHGCIG, [Out] LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36C9EE0", Offset = "0x36C92E0", VA = "0x1836C9EE0")]
	private void GEJONFDMHGA(Entity IBMHOJHGCIG, LALOMEGNPHJ FDKACFALFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36C9FD0", Offset = "0x36C93D0", VA = "0x1836C9FD0")]
	private bool HLMPLAAOADO(LALOMEGNPHJ FDKACFALFCB, [Out] JOANCLBFOPH LHBJDDJFCAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36CA190", Offset = "0x36C9590", VA = "0x1836CA190")]
	private JOANCLBFOPH IDNGCLDDKOK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FDFGNBIDIFI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNFCNPCHEKO(Entity IBMHOJHGCIG, object FACMOGNGACN, TValue FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IDLIABILAJO(Entity IBMHOJHGCIG, object FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DIPGBAHAPIF(Entity IBMHOJHGCIG, [Out] TValue FDFHGIHHGHO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LALOMEGNPHJ : MJIGHPBFKCE, IEquatable<LALOMEGNPHJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly LALOMEGNPHJ OLEBMJMDINK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int MEJJBNBBHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88ADC0", Offset = "0x88A1C0", VA = "0x18088ADC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BDIBPBOBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x21C5940", Offset = "0x21C4D40", VA = "0x1821C5940", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x53B9360", Offset = "0x53B8760", VA = "0x1853B9360", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x600CA20", Offset = "0x600BE20", VA = "0x18600CA20", Slot = "8")]
	public bool Equals(LALOMEGNPHJ AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x600CA70", Offset = "0x600BE70", VA = "0x18600CA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LJOLHMJHGKE<THasTokensTag> : HHPNHNAHBLF, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, LALOMEGNPHJ> JIKLAGPNNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> IOMEIOKFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private IIHGNBEDDFL<LALOMEGNPHJ, HashSet<object>> NCIBGHLKAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager KFOGOLNDMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem HFGIDFMIFJG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B68500", Offset = "0x3B67900", VA = "0x183B68500")]
	public LJOLHMJHGKE(EntityManager KFOGOLNDMKF, EntityCommandBufferSystem HFGIDFMIFJG, AMCJMMGFCLE BOJEADKMFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B67C40", Offset = "0x3B67040", VA = "0x183B67C40", Slot = "4")]
	public bool PNFCNPCHEKO(Entity IBMHOJHGCIG, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B66CB0", Offset = "0x3B660B0", VA = "0x183B66CB0", Slot = "5")]
	public bool IDLIABILAJO(Entity IBMHOJHGCIG, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B66510", Offset = "0x3B65910", VA = "0x183B66510", Slot = "6")]
	public bool GKEEJKBHGEO(Entity IBMHOJHGCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B66700", Offset = "0x3B65B00", VA = "0x183B66700", Slot = "9")]
	public bool GKEEJKBHGEO(LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B65BE0", Offset = "0x3B64FE0", VA = "0x183B65BE0", Slot = "7")]
	public bool DGHMCKLEMEB(Entity IBMHOJHGCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B66130", Offset = "0x3B65530", VA = "0x183B66130", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B64BF0", Offset = "0x3B63FF0", VA = "0x183B64BF0")]
	private void AHOIPHCFEEL(HashSet<object> LHBJDDJFCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B65E80", Offset = "0x3B65280", VA = "0x183B65E80")]
	private bool DGNIILCMLDO(Entity IBMHOJHGCIG, [Out] LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B676B0", Offset = "0x3B66AB0", VA = "0x183B676B0")]
	private bool OJDILHLFKGO(Entity IBMHOJHGCIG, [Out] LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B64E50", Offset = "0x3B64250", VA = "0x183B64E50")]
	private void BOMHAKMCIPK(Entity IBMHOJHGCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B653A0", Offset = "0x3B647A0", VA = "0x183B653A0")]
	private void DACEJFBDKEO(Entity IBMHOJHGCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B67330", Offset = "0x3B66730", VA = "0x183B67330")]
	private void MHGEPIEMNDC(Entity IBMHOJHGCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B663F0", Offset = "0x3B657F0", VA = "0x183B663F0")]
	private void GEJONFDMHGA(Entity IBMHOJHGCIG, LALOMEGNPHJ FDKACFALFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B67A70", Offset = "0x3B66E70", VA = "0x183B67A70")]
	private bool PFFDMCMMHBI(LALOMEGNPHJ FDKACFALFCB, [Out] HashSet<object> LHBJDDJFCAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B67170", Offset = "0x3B66570", VA = "0x183B67170")]
	private HashSet<object> IDNGCLDDKOK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OLKNCKJLLDD
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KMPDJEMBHKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int ABOMIAEBHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int DPBEIPGOMHN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LJINDFIJDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88ADC0", Offset = "0x88A1C0", VA = "0x18088ADC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x21C5940", Offset = "0x21C4D40", VA = "0x1821C5940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x53B9360", Offset = "0x53B8760", VA = "0x1853B9360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KFFONFDGEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88ADC0", Offset = "0x88A1C0", VA = "0x18088ADC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88AE90", Offset = "0x88A290", VA = "0x18088AE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GJADLDCIGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x600C860", Offset = "0x600BC60", VA = "0x18600C860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x600C880", Offset = "0x600BC80", VA = "0x18600C880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xA42880", Offset = "0xA41C80", VA = "0x180A42880")]
	private KMPDJEMBHKM(int ABOMIAEBHEB, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DDD0", Offset = "0x1D6D1D0", VA = "0x181D6DDD0")]
	public static KMPDJEMBHKM MGHHKECECGO(int ABOMIAEBHEB, int DPBEIPGOMHN)
	{
		return default(KMPDJEMBHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x600C870", Offset = "0x600BC70", VA = "0x18600C870")]
	public static KMPDJEMBHKM JHGIOAFAEKG(int AJOMPGHNEBN, int HPBGGHHMELE)
	{
		return default(KMPDJEMBHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x600C890", Offset = "0x600BC90", VA = "0x18600C890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CDIFFEFHIPG : GGCKDLFEMBL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x600BF50", Offset = "0x600B350", VA = "0x18600BF50")]
	public float EFBHBNMNEEK([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x600BF50", Offset = "0x600B350", VA = "0x18600BF50", Slot = "4")]
	private float OLHKLNGFEEH([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IPFHFHHNKAF : GGCKDLFEMBL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x600C850", Offset = "0x600BC50", VA = "0x18600C850")]
	public float EFBHBNMNEEK([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x600C850", Offset = "0x600BC50", VA = "0x18600C850", Slot = "4")]
	private float OLHKLNGFEEH([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IHCNKMCKCNL : GGCKDLFEMBL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x19DBE70", Offset = "0x19DB270", VA = "0x1819DBE70")]
	public float EFBHBNMNEEK([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x19DBE70", Offset = "0x19DB270", VA = "0x1819DBE70", Slot = "4")]
	private float OLHKLNGFEEH([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EHGKJDOLLAN : GGCKDLFEMBL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1305790", Offset = "0x1304B90", VA = "0x181305790")]
	public int EFBHBNMNEEK([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1305790", Offset = "0x1304B90", VA = "0x181305790", Slot = "4")]
	private int PKCNAMLHGMD([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BKELBGJHJOF : GGCKDLFEMBL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x600BF40", Offset = "0x600B340", VA = "0x18600BF40")]
	public int EFBHBNMNEEK([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x600BF40", Offset = "0x600B340", VA = "0x18600BF40", Slot = "4")]
	private int PKCNAMLHGMD([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ICDDGBJOIKK : GGCKDLFEMBL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x15F6720", Offset = "0x15F5B20", VA = "0x1815F6720")]
	public int EFBHBNMNEEK([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x15F6720", Offset = "0x15F5B20", VA = "0x1815F6720", Slot = "4")]
	private int PKCNAMLHGMD([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MMCAGKIPGCB : JMFFMANBMIK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD100", Offset = "0x7AC500", VA = "0x1807AD100")]
	public MMCAGKIPGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class DBENBEMKLAI : SystemBase, NFOFOCGFDBP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x600BFF0", Offset = "0x600B3F0", VA = "0x18600BFF0")]
	public ComponentDataFromEntity DLFBKMONLOK(int FNNBNHJOPHM, bool BKEAGODNFPN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x600C0B0", Offset = "0x600B4B0", VA = "0x18600C0B0")]
	public EntityExistenceLookupByEntity HIGINJPBBFD()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x600C0D0", Offset = "0x600B4D0", VA = "0x18600C0D0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD100", Offset = "0x7AC500", VA = "0x1807AD100")]
	protected DBENBEMKLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class EPKFGCDPPOP : DBENBEMKLAI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x600C270", Offset = "0x600B670", VA = "0x18600C270", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AD100", Offset = "0x7AC500", VA = "0x1807AD100")]
	protected EPKFGCDPPOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BBMIPOIOECP
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class JOFGDLHLBBK : EntityCommandBufferSystem, NFOFOCGFDBP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AD100", Offset = "0x7AC500", VA = "0x1807AD100")]
	protected JOFGDLHLBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GGCKDLFEMBL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo EFBHBNMNEEK([In] TFrom FDFHGIHHGHO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ANDPDOKOIHG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLOFLBGDBFN(T FDFHGIHHGHO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct DOBGGNEECMN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	public NativeArray<Entity> CLKJOCHJHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EntityCommandBuffer KOJKNAFHGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ComponentTypes DPFHIGNOMKL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x600C0E0", Offset = "0x600B4E0", VA = "0x18600C0E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct EANNNIPPLEL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> CLKJOCHJHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer KOJKNAFHGNN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x600C1D0", Offset = "0x600B5D0", VA = "0x18600C1D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct AFKCHOBJNIL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> CLKJOCHJHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer KOJKNAFHGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public ComponentType IIMAALCKFOC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x600BEC0", Offset = "0x600B2C0", VA = "0x18600BEC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct NLOJHEMPLCK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<Entity> CLKJOCHJHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<T> MFNOAEFOKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer KOJKNAFHGNN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E0ED50", Offset = "0x3E0E150", VA = "0x183E0ED50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct GLHHDNPMIBF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<Entity> CLKJOCHJHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<T> FNPMCCBNOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer KOJKNAFHGNN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct JPLFGFMNGAA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> CLKJOCHJHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public T FDFHGIHHGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EntityCommandBuffer KOJKNAFHGNN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A189A0", Offset = "0x3A17DA0", VA = "0x183A189A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct GKLOKPLLACL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GGCKDLFEMBL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<TFrom> MKAECCHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[WriteOnly]
	public NativeArray<TTo> FEFNFONJPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TMap MCLCEMNNOFC;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct KPNODMJKJDN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public ComponentDataFromEntity JHPFACOFMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<Entity> MKAECCHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeArray<byte> FEFNFONJPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int PFKKOMMDFLA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x600C920", Offset = "0x600BD20", VA = "0x18600C920", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct EOGLHLMENHP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IKFKECNJCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<Entity> MKAECCHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<T> MKFFJOJDIMM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct HNBAHCLKIMO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GGCKDLFEMBL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<TFrom> FFEIAGAALMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<TTo> FEFNFONJPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TMap MCLCEMNNOFC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct NMGLCALNIIK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HMFKHALHDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public NativeArray<Entity> MHGOFCOADBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<bool> POHIKNIDLKB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BMCMENICPBM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HMFKHALHDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> MHGOFCOADBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<bool> POHIKNIDLKB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x461CBA0", Offset = "0x461BFA0", VA = "0x18461CBA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct KICNMHPBHCO<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<T> MKAECCHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeList<T> MKFFJOJDIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeParallelHashSet<T> GMPJHEFPOJB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A72D50", Offset = "0x3A72150", VA = "0x183A72D50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct MKJLAIKOALP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : GGCKDLFEMBL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public NativeArray<TFrom> MKAECCHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeList<TFrom> MKFFJOJDIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeParallelHashSet<TTo> GMPJHEFPOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap MCLCEMNNOFC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct ONCHLFHPOFN<T, TPredicate> : IJob where T : struct where TPredicate : struct, ANDPDOKOIHG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<T> MKAECCHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> OMLJMIELKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeList<Entity> PBMLKCBPKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TPredicate MCLCEMNNOFC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD950", Offset = "0x3EFCD50", VA = "0x183EFD950", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IBJNDCMANOB<T, TPredicate> : IJob where T : struct where TPredicate : struct, ANDPDOKOIHG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<T> MKAECCHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeList<T> MKFFJOJDIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public TPredicate MCLCEMNNOFC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HFLDIJOLAHE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public ComponentDataFromEntity HMFKHALHDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> MHGOFCOADBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NativeList<Entity> DMNOCIJMEMB;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x600C530", Offset = "0x600B930", VA = "0x18600C530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct GLGEPHIANLO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public ComponentDataFromEntity HMFKHALHDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public NativeArray<Entity> MHGOFCOADBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<Entity> DMNOCIJMEMB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x600C4A0", Offset = "0x600B8A0", VA = "0x18600C4A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class DNNBHFDDBEM
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JKPPKOJEBEM
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26A1B40", Offset = "0x26A0F40", VA = "0x1826A1B40")]
	public static bool DFBJAEMLAFI<T>(this NativeArray<Entity> MHGOFCOADBC, EntityManager KFOGOLNDMKF, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CILOHNDHCMC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MGJPKLMGDIP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		public MGJPKLMGDIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MDLLHLBEICB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		public MDLLHLBEICB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<Func<JobHandle, JobHandle>> BGHCDBNDDME;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x600BF60", Offset = "0x600B360", VA = "0x18600BF60")]
	public CILOHNDHCMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GBHLJJGMHFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KIGMFDAPCHM
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct AIODPCJNEEK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct NKKOIEFKIGG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			internal AIODPCJNEEK<TFrom> BBCCHMIJNJG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal NativeArray<TFrom> DJMHFPMABHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct NLLBELFIIJG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct IPBJIOFLLOM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			internal NLLBELFIIJG<TFrom> BBCCHMIJNJG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal NativeList<TFrom> DJMHFPMABHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct DINMBDBEKNL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct CANDEKDOLCP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal DINMBDBEKNL<TFrom> BBCCHMIJNJG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NativeArrayAsync<TFrom> DJMHFPMABHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct DAMGGEBNNDA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct IKEJAINKJNI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal DAMGGEBNNDA<TFrom> BBCCHMIJNJG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeListAsync<TFrom> DJMHFPMABHB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MIAHIIOEPPD
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IKBIFJKJCOB
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2679C50", Offset = "0x2679050", VA = "0x182679C50")]
	public static NativeList<T> CPKBOMNBODM<T>(this NativeList<T> PNDHBMNLPBD, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2679AD0", Offset = "0x2678ED0", VA = "0x182679AD0")]
	public static NativeList<T> CPKBOMNBODM<T>(this NativeArray<T> PNDHBMNLPBD, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FGLGBDMPGAP
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MLGCEDKGGEH
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x270BC70", Offset = "0x270B070", VA = "0x18270BC70")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArrayAsync<Entity> CLKJOCHJHDA, NativeArrayAsync<T> MFNOAEFOKBK, [Optional] JobHandle OEAKLAEMPBC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x270BEF0", Offset = "0x270B2F0", VA = "0x18270BEF0")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArrayAsync<Entity> CLKJOCHJHDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x270BDD0", Offset = "0x270B1D0", VA = "0x18270BDD0")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArray<Entity> CLKJOCHJHDA, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x600CC30", Offset = "0x600C030", VA = "0x18600CC30")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArray<Entity> CLKJOCHJHDA, ComponentTypes DPFHIGNOMKL, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x600CDA0", Offset = "0x600C1A0", VA = "0x18600CDA0")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI(this EntityCommandBufferSystem HFGIDFMIFJG, EntityCommandBuffer KOJKNAFHGNN, NativeArray<Entity> CLKJOCHJHDA, ComponentTypes DPFHIGNOMKL, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class AMDKPPEOPNK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C6F0", Offset = "0x2C0BAF0", VA = "0x182C0C6F0")]
	[LCLPIELMIDI]
	public static JobHandle CGPMGCCEDJE<T>(this EntityCommandBufferSystem HFGIDFMIFJG, EntityCommandBuffer KOJKNAFHGNN, EntityQuery DKNOHCFCBGO, T FDFHGIHHGHO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HKOMMFCJBED
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x600C5C0", Offset = "0x600B9C0", VA = "0x18600C5C0")]
	[LCLPIELMIDI]
	public static JobHandle MBHJPIOHCCL(this EntityCommandBufferSystem HFGIDFMIFJG, NativeList<Entity> CLKJOCHJHDA, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x600C750", Offset = "0x600BB50", VA = "0x18600C750")]
	[LCLPIELMIDI]
	public static JobHandle MBHJPIOHCCL(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArrayAsync<Entity> CLKJOCHJHDA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NGIDAOJMBFI
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x276B560", Offset = "0x276A960", VA = "0x18276B560")]
	public static void APFOICLKBBL<T>(this EntityCommandBufferSystem HFGIDFMIFJG, EntityQuery DKNOHCFCBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x276B930", Offset = "0x276AD30", VA = "0x18276B930")]
	[LCLPIELMIDI]
	public static JobHandle BLDJFKHCBDN<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeListAsync<Entity> CLKJOCHJHDA, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x276B9F0", Offset = "0x276ADF0", VA = "0x18276B9F0")]
	[LCLPIELMIDI]
	public static JobHandle BLDJFKHCBDN<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArrayAsync<Entity> CLKJOCHJHDA, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NIJHELHBCCI
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x276D610", Offset = "0x276CA10", VA = "0x18276D610")]
	[LCLPIELMIDI]
	public static JobHandle DJAGAHPGNHM<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArray<Entity> CLKJOCHJHDA, NativeArray<T> MFNOAEFOKBK, JobHandle OEAKLAEMPBC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OHGPINCCHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27867C0", Offset = "0x2785BC0", VA = "0x1827867C0")]
	[LCLPIELMIDI]
	public static JobHandle FKGLKMCFBKD<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArray<Entity> CLKJOCHJHDA, T FDFHGIHHGHO, [Optional] JobHandle OEAKLAEMPBC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27866F0", Offset = "0x2785AF0", VA = "0x1827866F0")]
	[LCLPIELMIDI]
	public static JobHandle FKGLKMCFBKD<T>(this EntityCommandBufferSystem HFGIDFMIFJG, EntityCommandBuffer KOJKNAFHGNN, NativeArray<Entity> CLKJOCHJHDA, T FDFHGIHHGHO, [Optional] JobHandle OEAKLAEMPBC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class LBJDLMKEMLN
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26EB6B0", Offset = "0x26EAAB0", VA = "0x1826EB6B0")]
	public static NativeList<T> CPKBOMNBODM<T>(NativeList<T> PNDHBMNLPBD, Allocator FNHHOCKOINK) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FMKGCCFIAHN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26174F0", Offset = "0x26168F0", VA = "0x1826174F0")]
	public static NativeArray<T> EBEAMHLMCLJ<T>(this NativeList<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2617170", Offset = "0x2616570", VA = "0x182617170")]
	public static NativeArray<T> EBEAMHLMCLJ<T>(this NativeArray<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x600C2C0", Offset = "0x600B6C0", VA = "0x18600C2C0")]
	public static NativeArray<Entity> AMMEJOMFGEH(this NativeArray<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF, ComponentType IIMAALCKFOC, Allocator FNHHOCKOINK = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2617090", Offset = "0x2616490", VA = "0x182617090")]
	public static NativeArray<T> BFHMHEMIIPB<T>(this NativeArray<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class AJPJAMNKCOI
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct MENKJLFJNCG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct GGACFIPCKFK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public MENKJLFJNCG<TFrom> DJMHFPMABHB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<TFrom> MKAECCHJDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct PCEAOBECDFC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct DEGOAAKEAOH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PCEAOBECDFC<TFrom> DJMHFPMABHB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeArrayAsync<TFrom> MKAECCHJDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct BFHINDMLKMA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct ALGONKMNJPG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public BFHINDMLKMA<TFrom> DJMHFPMABHB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeListAsync<TFrom> MKAECCHJDPL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LPFIANJPGOH
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HELAMHCCGGK
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct OLHEFAFFMAM : GGCKDLFEMBL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> LFAAPBGHPEK;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x600CEF0", Offset = "0x600C2F0", VA = "0x18600CEF0")]
		[BurstCompatible]
		public Entity EFBHBNMNEEK([In] Entity FDFHGIHHGHO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x600CEF0", Offset = "0x600C2F0", VA = "0x18600CEF0", Slot = "4")]
		private Entity CADCNANFKHB([In] Entity FDFHGIHHGHO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class JHFGNPONFCI
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct KEINPEFDBBE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<Entity> OMLJMIELKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<T> MKAECCHJDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct LLAANBNCMLL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<Entity> OMLJMIELKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<T> MKAECCHJDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct LCILIFLAKEH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<Entity> OMLJMIELKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArrayAsync<T> MKAECCHJDPL;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x24DBB30", Offset = "0x24DAF30", VA = "0x1824DBB30")]
		public NativeListAsync<Entity> OLOFLBGDBFN<TPredicate>() where TPredicate : struct, ANDPDOKOIHG<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26962D0", Offset = "0x26956D0", VA = "0x1826962D0")]
	public static LCILIFLAKEH<T> KBNEBHGKPOJ<T>(this NativeArrayAsync<Entity> MHGOFCOADBC, NativeArrayAsync<T> PNDHBMNLPBD, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct
	{
		return default(LCILIFLAKEH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KGANNANGABK
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x26DCB40", Offset = "0x26DBF40", VA = "0x1826DCB40")]
	public static NativeListAsync<Entity> FLHFKDLNHDF<T, TPredicate>(this NativeArrayAsync<T> PNDHBMNLPBD, NativeArrayAsync<Entity> MHGOFCOADBC, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct where TPredicate : struct, ANDPDOKOIHG<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26DC9A0", Offset = "0x26DBDA0", VA = "0x1826DC9A0")]
	private static NativeListAsync<Entity> EPJIGCOAIIF<T, TPredicate>(NativeArrayAsync<T> ONPIPMHBEOA, NativeArrayAsync<Entity> MHGOFCOADBC, int CBKFAHCFHJN, Allocator FNHHOCKOINK) where T : struct where TPredicate : struct, ANDPDOKOIHG<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BPMNFCFEKGH
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct EKIIOBKKJCH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<T> MKAECCHJDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct LAOKAGHEOFP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<T> MKAECCHJDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct GGKOMCIECLD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArrayAsync<T> MKAECCHJDPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct IOBKLIKOFJL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator FNHHOCKOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeListAsync<T> MKAECCHJDPL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GGAEAOHNDBH
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GKLMCPOFIDM
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x263B590", Offset = "0x263A990", VA = "0x18263B590")]
	public static NativeList<Entity> EHBNKEEECKB<T>(this NativeArray<Entity> MHGOFCOADBC, EntityManager KFOGOLNDMKF, Allocator FNHHOCKOINK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class KGIDAEACLDC
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class PGPKJLBIGOI
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct EKNJGDKHCAM<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> NIKMHLBDDHG;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D570F0", VA = "0x181D57CF0")]
		public EKNJGDKHCAM(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public KLGBIABPCLL<TSrc, TValue> KEMONMBDGON<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(KLGBIABPCLL<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct KLGBIABPCLL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> NIKMHLBDDHG;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D570F0", VA = "0x181D57CF0")]
		public KLGBIABPCLL(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public DOGLCIAGKKG<TSrc, TValue, TSelector> ABBBNPNOEFO<TSelector>() where TSelector : struct, GGCKDLFEMBL<TSrc, TValue>
		{
			return default(DOGLCIAGKKG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public readonly struct DOGLCIAGKKG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GGCKDLFEMBL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> NIKMHLBDDHG;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D570F0", VA = "0x181D57CF0")]
		public DOGLCIAGKKG(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8F80", Offset = "0x4EB8380", VA = "0x184EB8F80")]
		public NIBPJOBILEG<TSrc, TValue, TSelector> PGLOCGJFEKK()
		{
			return default(NIBPJOBILEG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct EDOKHKLDOBI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, GGCKDLFEMBL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> NIKMHLBDDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TSelector LPMLOJKHMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int OJANCMLFDOJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x31D6FE0", Offset = "0x31D63E0", VA = "0x1831D6FE0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MEJJBNBBHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9A50B0", Offset = "0x9A44B0", VA = "0x1809A50B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NDHLDPJEOPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1D46F30", Offset = "0x1D46330", VA = "0x181D46F30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x31D7160", Offset = "0x31D6560", VA = "0x1831D7160")]
		public EDOKHKLDOBI(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x31D7150", Offset = "0x31D6550", VA = "0x1831D7150")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x31D7070", Offset = "0x31D6470", VA = "0x1831D7070")]
		private TSrc MIIMNLFBFLM(int CCNHOKJIGCD)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct NIBPJOBILEG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GGCKDLFEMBL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private EDOKHKLDOBI<TSrc, TValue, TSelector> JPFOLDCFLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TValue PNCIEBLDJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int DAGOHCNFGEF;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KMPDJEMBHKM IODOKIHONFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3DFE7C0", Offset = "0x3DFDBC0", VA = "0x183DFE7C0")]
			get
			{
				return default(KMPDJEMBHKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue OMLFIMBKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, KMPDJEMBHKM range) FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3DFE5A0", Offset = "0x3DFD9A0", VA = "0x183DFE5A0")]
			get
			{
				return default((TValue, KMPDJEMBHKM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE800", Offset = "0x3DFDC00", VA = "0x183DFE800")]
		public NIBPJOBILEG(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3579970", Offset = "0x3578D70", VA = "0x183579970")]
		public NIBPJOBILEG<TSrc, TValue, TSelector> MFONJKCHJIL()
		{
			return default(NIBPJOBILEG<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE680", Offset = "0x3DFDA80", VA = "0x183DFE680")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x279F4D0", Offset = "0x279E8D0", VA = "0x18279F4D0")]
	public static EKNJGDKHCAM<T> DAOIHNFOKFP<T>(this NativeList<T> EPNEAFACLDA) where T : struct
	{
		return default(EKNJGDKHCAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
	public static EKNJGDKHCAM<T> DAOIHNFOKFP<T>(this NativeArray<T> NIKMHLBDDHG) where T : struct
	{
		return default(EKNJGDKHCAM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class DKNGKMPMHFE
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct LCHFDCEEADC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<T>.ReadOnly NIKMHLBDDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int DAGOHCNFGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int MJNFIIMDFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T PNCIEBLDJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private T HPOGJEEAHNP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public KMPDJEMBHKM IODOKIHONFC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x31D61D0", Offset = "0x31D55D0", VA = "0x1831D61D0")]
			get
			{
				return default(KMPDJEMBHKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T OMLFIMBKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x31D5FD0", Offset = "0x31D53D0", VA = "0x1831D5FD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, KMPDJEMBHKM) FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3B4A610", Offset = "0x3B49A10", VA = "0x183B4A610")]
			get
			{
				return default((T, KMPDJEMBHKM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3B4ABF0", Offset = "0x3B49FF0", VA = "0x183B4ABF0")]
		public LCHFDCEEADC(NativeArray<T> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A790", Offset = "0x3B49B90", VA = "0x183B4A790")]
		public LCHFDCEEADC<T> MFONJKCHJIL()
		{
			return default(LCHFDCEEADC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B4A7D0", Offset = "0x3B49BD0", VA = "0x183B4A7D0")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x24DBAE0", Offset = "0x24DAEE0", VA = "0x1824DBAE0")]
		public ECEHABFNAGO<T, TComparer> BLDPPCOABJP<TComparer>([Optional] TComparer FNFGDNGIJGE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(ECEHABFNAGO<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ECEHABFNAGO<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T>.ReadOnly NIKMHLBDDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int DAGOHCNFGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int MJNFIIMDFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T PNCIEBLDJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private T HPOGJEEAHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TComparer FNFGDNGIJGE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KMPDJEMBHKM IODOKIHONFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x31D61D0", Offset = "0x31D55D0", VA = "0x1831D61D0")]
			get
			{
				return default(KMPDJEMBHKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T OMLFIMBKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x31D5FD0", Offset = "0x31D53D0", VA = "0x1831D5FD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x31D61E0", Offset = "0x31D55E0", VA = "0x1831D61E0")]
		public ECEHABFNAGO(NativeArray<T>.ReadOnly NIKMHLBDDHG, TComparer FNFGDNGIJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x31D5FF0", Offset = "0x31D53F0", VA = "0x1831D5FF0")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x24EBAD0", Offset = "0x24EAED0", VA = "0x1824EBAD0")]
	public static LCHFDCEEADC<T> PGLOCGJFEKK<T>(this NativeArray<T> NIKMHLBDDHG) where T : struct
	{
		return default(LCHFDCEEADC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface JJOOMGDECDB
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class EHOEPGPHMML
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct GEPOEKKAEIP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KMDCNPOBGFK : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GEPOEKKAEIP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8E0", Offset = "0xA1DCE0", VA = "0x180A1E8E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x35CD780", Offset = "0x35CCB80", VA = "0x1835CD780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public KMDCNPOBGFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A98F00", Offset = "0x3A98300", VA = "0x183A98F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A990B0", Offset = "0x3A984B0", VA = "0x183A990B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Action<Protobuf> CFMNHFKPKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MemoryStream FOBHMMKPKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CodedInputStream BAMCFDPBCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Protobuf ECAPCAFPCGH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int NDHLDPJEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3688BB0", Offset = "0x3687FB0", VA = "0x183688BB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3688BF0", Offset = "0x3687FF0", VA = "0x183688BF0", Slot = "4")]
	[IteratorStateMachine(typeof(GEPOEKKAEIP<>.KMDCNPOBGFK))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3688CE0", Offset = "0x36880E0", VA = "0x183688CE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct BDMNPKGGCHO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly byte[] BGIIPDEPEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Protobuf ECAPCAFPCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream FOBHMMKPKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedOutputStream HMNIONNLHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x45E5FD0", Offset = "0x45E53D0", VA = "0x1845E5FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LNFIJAJPMDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream FOBHMMKPKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedInputStream BAMCFDPBCDO;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x600CAC0", Offset = "0x600BEC0", VA = "0x18600CAC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct MALIKEBKILC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly byte[] BGIIPDEPEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MemoryStream FOBHMMKPKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CodedOutputStream HMNIONNLHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x600CB00", Offset = "0x600BF00", VA = "0x18600CB00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FIJFLHMPGNI
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class CMJFNGPKBPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
public enum PJCFFOMPEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class OOIJOCGHCCA
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class MOKIHPOCJIO
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MOKIHPOCJIO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
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
