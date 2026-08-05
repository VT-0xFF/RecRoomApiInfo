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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6085E80", Offset = "0x6084880", VA = "0x186085E80")]
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
			[Cpp2IlInjected.Address(RVA = "0x303C1D0", Offset = "0x303ABD0", VA = "0x18303C1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A31D90", Offset = "0x3A30790", VA = "0x183A31D90")]
		public bool DIPGBAHAPIF([Out] TValue FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3A31E80", Offset = "0x3A30880", VA = "0x183A31E80")]
		public void FLOHBAGDPJC(object FACMOGNGACN, TValue FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3A31F30", Offset = "0x3A30930", VA = "0x183A31F30")]
		public bool NJHEJNEGCKN(object FACMOGNGACN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3A31CB0", Offset = "0x3A306B0", VA = "0x183A31CB0")]
		public int CFPFFGNEMEK(object FACMOGNGACN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3A31FB0", Offset = "0x3A309B0", VA = "0x183A31FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x36E86B0", Offset = "0x36E70B0", VA = "0x1836E86B0")]
	public HBBHPNCICNM(EntityManager KFOGOLNDMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x36E8570", Offset = "0x36E6F70", VA = "0x1836E8570", Slot = "4")]
	public void PNFCNPCHEKO(Entity IBMHOJHGCIG, object FACMOGNGACN, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36E82E0", Offset = "0x36E6CE0", VA = "0x1836E82E0", Slot = "5")]
	public bool IDLIABILAJO(Entity IBMHOJHGCIG, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36E80B0", Offset = "0x36E6AB0", VA = "0x1836E80B0", Slot = "6")]
	public bool DIPGBAHAPIF(Entity IBMHOJHGCIG, [Out] TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36E81B0", Offset = "0x36E6BB0", VA = "0x1836E81B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x36E7F60", Offset = "0x36E6960", VA = "0x1836E7F60")]
	private void AHOIPHCFEEL(JOANCLBFOPH LHBJDDJFCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36E7FF0", Offset = "0x36E69F0", VA = "0x1836E7FF0")]
	private bool DGNIILCMLDO(Entity IBMHOJHGCIG, [Out] LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36E81D0", Offset = "0x36E6BD0", VA = "0x1836E81D0")]
	private void GEJONFDMHGA(Entity IBMHOJHGCIG, LALOMEGNPHJ FDKACFALFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36E82C0", Offset = "0x36E6CC0", VA = "0x1836E82C0")]
	private bool HLMPLAAOADO(LALOMEGNPHJ FDKACFALFCB, [Out] JOANCLBFOPH LHBJDDJFCAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36E8480", Offset = "0x36E6E80", VA = "0x1836E8480")]
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
		[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x21E5FF0", Offset = "0x21E49F0", VA = "0x1821E5FF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x54213D0", Offset = "0x541FDD0", VA = "0x1854213D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6086600", Offset = "0x6085000", VA = "0x186086600", Slot = "8")]
	public bool Equals(LALOMEGNPHJ AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6086650", Offset = "0x6085050", VA = "0x186086650", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B981B0", Offset = "0x3B96BB0", VA = "0x183B981B0")]
	public LJOLHMJHGKE(EntityManager KFOGOLNDMKF, EntityCommandBufferSystem HFGIDFMIFJG, AMCJMMGFCLE BOJEADKMFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B978F0", Offset = "0x3B962F0", VA = "0x183B978F0", Slot = "4")]
	public bool PNFCNPCHEKO(Entity IBMHOJHGCIG, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B96960", Offset = "0x3B95360", VA = "0x183B96960", Slot = "5")]
	public bool IDLIABILAJO(Entity IBMHOJHGCIG, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B961C0", Offset = "0x3B94BC0", VA = "0x183B961C0", Slot = "6")]
	public bool GKEEJKBHGEO(Entity IBMHOJHGCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B963B0", Offset = "0x3B94DB0", VA = "0x183B963B0", Slot = "9")]
	public bool GKEEJKBHGEO(LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B95890", Offset = "0x3B94290", VA = "0x183B95890", Slot = "7")]
	public bool DGHMCKLEMEB(Entity IBMHOJHGCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B95DE0", Offset = "0x3B947E0", VA = "0x183B95DE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B948A0", Offset = "0x3B932A0", VA = "0x183B948A0")]
	private void AHOIPHCFEEL(HashSet<object> LHBJDDJFCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B95B30", Offset = "0x3B94530", VA = "0x183B95B30")]
	private bool DGNIILCMLDO(Entity IBMHOJHGCIG, [Out] LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B97360", Offset = "0x3B95D60", VA = "0x183B97360")]
	private bool OJDILHLFKGO(Entity IBMHOJHGCIG, [Out] LALOMEGNPHJ FDKACFALFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B94B00", Offset = "0x3B93500", VA = "0x183B94B00")]
	private void BOMHAKMCIPK(Entity IBMHOJHGCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B95050", Offset = "0x3B93A50", VA = "0x183B95050")]
	private void DACEJFBDKEO(Entity IBMHOJHGCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B96FE0", Offset = "0x3B959E0", VA = "0x183B96FE0")]
	private void MHGEPIEMNDC(Entity IBMHOJHGCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B960A0", Offset = "0x3B94AA0", VA = "0x183B960A0")]
	private void GEJONFDMHGA(Entity IBMHOJHGCIG, LALOMEGNPHJ FDKACFALFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B97720", Offset = "0x3B96120", VA = "0x183B97720")]
	private bool PFFDMCMMHBI(LALOMEGNPHJ FDKACFALFCB, [Out] HashSet<object> LHBJDDJFCAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B96E20", Offset = "0x3B95820", VA = "0x183B96E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x21E5FF0", Offset = "0x21E49F0", VA = "0x1821E5FF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x54213D0", Offset = "0x541FDD0", VA = "0x1854213D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KFFONFDGEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x896410", Offset = "0x894E10", VA = "0x180896410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8964E0", Offset = "0x894EE0", VA = "0x1808964E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GJADLDCIGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6086440", Offset = "0x6084E40", VA = "0x186086440")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6086460", Offset = "0x6084E60", VA = "0x186086460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E280", Offset = "0xA4CC80", VA = "0x180A4E280")]
	private KMPDJEMBHKM(int ABOMIAEBHEB, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1D89580", Offset = "0x1D87F80", VA = "0x181D89580")]
	public static KMPDJEMBHKM MGHHKECECGO(int ABOMIAEBHEB, int DPBEIPGOMHN)
	{
		return default(KMPDJEMBHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6086450", Offset = "0x6084E50", VA = "0x186086450")]
	public static KMPDJEMBHKM JHGIOAFAEKG(int AJOMPGHNEBN, int HPBGGHHMELE)
	{
		return default(KMPDJEMBHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6086470", Offset = "0x6084E70", VA = "0x186086470", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6085B30", Offset = "0x6084530", VA = "0x186085B30")]
	public float EFBHBNMNEEK([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6085B30", Offset = "0x6084530", VA = "0x186085B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6086430", Offset = "0x6084E30", VA = "0x186086430")]
	public float EFBHBNMNEEK([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6086430", Offset = "0x6084E30", VA = "0x186086430", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x19F4980", Offset = "0x19F3380", VA = "0x1819F4980")]
	public float EFBHBNMNEEK([In] float3 FDFHGIHHGHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x19F4980", Offset = "0x19F3380", VA = "0x1819F4980", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x131A140", Offset = "0x1318B40", VA = "0x18131A140")]
	public int EFBHBNMNEEK([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x131A140", Offset = "0x1318B40", VA = "0x18131A140", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6085B20", Offset = "0x6084520", VA = "0x186085B20")]
	public int EFBHBNMNEEK([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6085B20", Offset = "0x6084520", VA = "0x186085B20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x160BC20", Offset = "0x160A620", VA = "0x18160BC20")]
	public int EFBHBNMNEEK([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x160BC20", Offset = "0x160A620", VA = "0x18160BC20", Slot = "4")]
	private int PKCNAMLHGMD([In] int3 FDFHGIHHGHO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MMCAGKIPGCB : JMFFMANBMIK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7100", Offset = "0x7B5B00", VA = "0x1807B7100")]
	public MMCAGKIPGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class DBENBEMKLAI : SystemBase, NFOFOCGFDBP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6085BD0", Offset = "0x60845D0", VA = "0x186085BD0")]
	public ComponentDataFromEntity DLFBKMONLOK(int FNNBNHJOPHM, bool BKEAGODNFPN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6085C90", Offset = "0x6084690", VA = "0x186085C90")]
	public EntityExistenceLookupByEntity HIGINJPBBFD()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6085CB0", Offset = "0x60846B0", VA = "0x186085CB0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7100", Offset = "0x7B5B00", VA = "0x1807B7100")]
	protected DBENBEMKLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class EPKFGCDPPOP : DBENBEMKLAI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6085E50", Offset = "0x6084850", VA = "0x186085E50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B7100", Offset = "0x7B5B00", VA = "0x1807B7100")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B7100", Offset = "0x7B5B00", VA = "0x1807B7100")]
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
	[Cpp2IlInjected.Address(RVA = "0x6085CC0", Offset = "0x60846C0", VA = "0x186085CC0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6085DB0", Offset = "0x60847B0", VA = "0x186085DB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6085AA0", Offset = "0x60844A0", VA = "0x186085AA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E45250", Offset = "0x3E43C50", VA = "0x183E45250", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A43A10", Offset = "0x3A42410", VA = "0x183A43A10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6086500", Offset = "0x6084F00", VA = "0x186086500", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4667840", Offset = "0x4666240", VA = "0x184667840", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A9E1C0", Offset = "0x3A9CBC0", VA = "0x183A9E1C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F32720", Offset = "0x3F31120", VA = "0x183F32720", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6086110", Offset = "0x6084B10", VA = "0x186086110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6086080", Offset = "0x6084A80", VA = "0x186086080", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x27088E0", Offset = "0x27072E0", VA = "0x1827088E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6085B40", Offset = "0x6084540", VA = "0x186085B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x26CE550", Offset = "0x26CCF50", VA = "0x1826CE550")]
	public static NativeList<T> CPKBOMNBODM<T>(this NativeList<T> PNDHBMNLPBD, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26CE3D0", Offset = "0x26CCDD0", VA = "0x1826CE3D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2762C30", Offset = "0x2761630", VA = "0x182762C30")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArrayAsync<Entity> CLKJOCHJHDA, NativeArrayAsync<T> MFNOAEFOKBK, [Optional] JobHandle OEAKLAEMPBC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2762EB0", Offset = "0x27618B0", VA = "0x182762EB0")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArrayAsync<Entity> CLKJOCHJHDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2762D90", Offset = "0x2761790", VA = "0x182762D90")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArray<Entity> CLKJOCHJHDA, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6086810", Offset = "0x6085210", VA = "0x186086810")]
	[LCLPIELMIDI]
	public static JobHandle ONHDONGOMOI(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArray<Entity> CLKJOCHJHDA, ComponentTypes DPFHIGNOMKL, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6086980", Offset = "0x6085380", VA = "0x186086980")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C645C0", Offset = "0x2C62FC0", VA = "0x182C645C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x60861A0", Offset = "0x6084BA0", VA = "0x1860861A0")]
	[LCLPIELMIDI]
	public static JobHandle MBHJPIOHCCL(this EntityCommandBufferSystem HFGIDFMIFJG, NativeList<Entity> CLKJOCHJHDA, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6086330", Offset = "0x6084D30", VA = "0x186086330")]
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
	[Cpp2IlInjected.Address(RVA = "0x27C1670", Offset = "0x27C0070", VA = "0x1827C1670")]
	public static void APFOICLKBBL<T>(this EntityCommandBufferSystem HFGIDFMIFJG, EntityQuery DKNOHCFCBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27C1A40", Offset = "0x27C0440", VA = "0x1827C1A40")]
	[LCLPIELMIDI]
	public static JobHandle BLDJFKHCBDN<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeListAsync<Entity> CLKJOCHJHDA, [Optional] JobHandle OEAKLAEMPBC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27C1B00", Offset = "0x27C0500", VA = "0x1827C1B00")]
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
	[Cpp2IlInjected.Address(RVA = "0x27C3720", Offset = "0x27C2120", VA = "0x1827C3720")]
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
	[Cpp2IlInjected.Address(RVA = "0x27DC7C0", Offset = "0x27DB1C0", VA = "0x1827DC7C0")]
	[LCLPIELMIDI]
	public static JobHandle FKGLKMCFBKD<T>(this EntityCommandBufferSystem HFGIDFMIFJG, NativeArray<Entity> CLKJOCHJHDA, T FDFHGIHHGHO, [Optional] JobHandle OEAKLAEMPBC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27DC6F0", Offset = "0x27DB0F0", VA = "0x1827DC6F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x27423E0", Offset = "0x2740DE0", VA = "0x1827423E0")]
	public static NativeList<T> CPKBOMNBODM<T>(NativeList<T> PNDHBMNLPBD, Allocator FNHHOCKOINK) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FMKGCCFIAHN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x266C580", Offset = "0x266AF80", VA = "0x18266C580")]
	public static NativeArray<T> EBEAMHLMCLJ<T>(this NativeList<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x266C200", Offset = "0x266AC00", VA = "0x18266C200")]
	public static NativeArray<T> EBEAMHLMCLJ<T>(this NativeArray<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6085EA0", Offset = "0x60848A0", VA = "0x186085EA0")]
	public static NativeArray<Entity> AMMEJOMFGEH(this NativeArray<Entity> PNDHBMNLPBD, EntityManager KFOGOLNDMKF, ComponentType IIMAALCKFOC, Allocator FNHHOCKOINK = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x266C120", Offset = "0x266AB20", VA = "0x18266C120")]
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
		[Cpp2IlInjected.Address(RVA = "0x6086AD0", Offset = "0x60854D0", VA = "0x186086AD0")]
		[BurstCompatible]
		public Entity EFBHBNMNEEK([In] Entity FDFHGIHHGHO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6086AD0", Offset = "0x60854D0", VA = "0x186086AD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x25BD7E0", Offset = "0x25BC1E0", VA = "0x1825BD7E0")]
		public NativeListAsync<Entity> OLOFLBGDBFN<TPredicate>() where TPredicate : struct, ANDPDOKOIHG<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26FD070", Offset = "0x26FBA70", VA = "0x1826FD070")]
	public static LCILIFLAKEH<T> KBNEBHGKPOJ<T>(this NativeArrayAsync<Entity> MHGOFCOADBC, NativeArrayAsync<T> PNDHBMNLPBD, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct
	{
		return default(LCILIFLAKEH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KGANNANGABK
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2733B20", Offset = "0x2732520", VA = "0x182733B20")]
	public static NativeListAsync<Entity> FLHFKDLNHDF<T, TPredicate>(this NativeArrayAsync<T> PNDHBMNLPBD, NativeArrayAsync<Entity> MHGOFCOADBC, Allocator FNHHOCKOINK = Allocator.TempJob) where T : struct where TPredicate : struct, ANDPDOKOIHG<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2733980", Offset = "0x2732380", VA = "0x182733980")]
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
	[Cpp2IlInjected.Address(RVA = "0x2690980", Offset = "0x268F380", VA = "0x182690980")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
		public EKNJGDKHCAM(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
		public KLGBIABPCLL(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
		public DOGLCIAGKKG(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4F23030", Offset = "0x4F21A30", VA = "0x184F23030")]
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
			[Cpp2IlInjected.Address(RVA = "0x3206840", Offset = "0x3205240", VA = "0x183206840")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MEJJBNBBHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9B0770", Offset = "0x9AF170", VA = "0x1809B0770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NDHLDPJEOPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1D60D30", Offset = "0x1D5F730", VA = "0x181D60D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x32069C0", Offset = "0x32053C0", VA = "0x1832069C0")]
		public EDOKHKLDOBI(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x32069B0", Offset = "0x32053B0", VA = "0x1832069B0")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x32068D0", Offset = "0x32052D0", VA = "0x1832068D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E34CC0", Offset = "0x3E336C0", VA = "0x183E34CC0")]
			get
			{
				return default(KMPDJEMBHKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue OMLFIMBKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, KMPDJEMBHKM range) FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3E34AA0", Offset = "0x3E334A0", VA = "0x183E34AA0")]
			get
			{
				return default((TValue, KMPDJEMBHKM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3E34D00", Offset = "0x3E33700", VA = "0x183E34D00")]
		public NIBPJOBILEG(NativeArray<TSrc> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x35A4A10", Offset = "0x35A3410", VA = "0x1835A4A10")]
		public NIBPJOBILEG<TSrc, TValue, TSelector> MFONJKCHJIL()
		{
			return default(NIBPJOBILEG<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3E34B80", Offset = "0x3E33580", VA = "0x183E34B80")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x27F5500", Offset = "0x27F3F00", VA = "0x1827F5500")]
	public static EKNJGDKHCAM<T> DAOIHNFOKFP<T>(this NativeList<T> EPNEAFACLDA) where T : struct
	{
		return default(EKNJGDKHCAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
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
			[Cpp2IlInjected.Address(RVA = "0x3205A30", Offset = "0x3204430", VA = "0x183205A30")]
			get
			{
				return default(KMPDJEMBHKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T OMLFIMBKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3205830", Offset = "0x3204230", VA = "0x183205830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, KMPDJEMBHKM) FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3B7A400", Offset = "0x3B78E00", VA = "0x183B7A400")]
			get
			{
				return default((T, KMPDJEMBHKM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A9E0", Offset = "0x3B793E0", VA = "0x183B7A9E0")]
		public LCHFDCEEADC(NativeArray<T> NIKMHLBDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A580", Offset = "0x3B78F80", VA = "0x183B7A580")]
		public LCHFDCEEADC<T> MFONJKCHJIL()
		{
			return default(LCHFDCEEADC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A5C0", Offset = "0x3B78FC0", VA = "0x183B7A5C0")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x25BD790", Offset = "0x25BC190", VA = "0x1825BD790")]
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
			[Cpp2IlInjected.Address(RVA = "0x3205A30", Offset = "0x3204430", VA = "0x183205A30")]
			get
			{
				return default(KMPDJEMBHKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T OMLFIMBKHCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3205830", Offset = "0x3204230", VA = "0x183205830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3205A40", Offset = "0x3204440", VA = "0x183205A40")]
		public ECEHABFNAGO(NativeArray<T>.ReadOnly NIKMHLBDDHG, TComparer FNFGDNGIJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3205850", Offset = "0x3204250", VA = "0x183205850")]
		public bool NLINJCHNNNN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x253DA60", Offset = "0x253C460", VA = "0x18253DA60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA29FA0", Offset = "0xA289A0", VA = "0x180A29FA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x36391F0", Offset = "0x3637BF0", VA = "0x1836391F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public KMDCNPOBGFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3AC45B0", Offset = "0x3AC2FB0", VA = "0x183AC45B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3AC4760", Offset = "0x3AC3160", VA = "0x183AC4760", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x36A6DD0", Offset = "0x36A57D0", VA = "0x1836A6DD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x36A6E10", Offset = "0x36A5810", VA = "0x1836A6E10", Slot = "4")]
	[IteratorStateMachine(typeof(GEPOEKKAEIP<>.KMDCNPOBGFK))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x36A6F00", Offset = "0x36A5900", VA = "0x1836A6F00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x461F810", Offset = "0x461E210", VA = "0x18461F810", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x60866A0", Offset = "0x60850A0", VA = "0x1860866A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x60866E0", Offset = "0x60850E0", VA = "0x1860866E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
