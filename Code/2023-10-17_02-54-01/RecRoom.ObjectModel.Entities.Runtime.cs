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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DA3C70", Offset = "0x5DA2470", VA = "0x185DA3C70")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MNNNLECHKEN<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] HPMDEMKMGAD;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x229CA40", Offset = "0x229B240", VA = "0x18229CA40")]
	public static void HCNGJEJHOOI<TField>(int LFEFGCGCIAG, string HNHMJGCODBA, EANCAGBLBGP IHLAOGOPNCG, [Out] FAOOFKFDMAN<TField> EJKGILKDBHL) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x229A040", Offset = "0x2298840", VA = "0x18229A040")]
	public static void GMLEBEMEPFE<TField>(int LFEFGCGCIAG, string HNHMJGCODBA, [Out] GCEJGJJCPNB<TField> IACPFKBCIBD) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class NMFAEMLDCKE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4B60", Offset = "0x5DA3360", VA = "0x185DA4B60")]
	public static FieldInfo[] ADLMABPMNIK(Type GFGNPBCFEMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class FNCJJMOODDI<View, Data> : MDPDCPPKJHK where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType LEKLFNKABPL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type IOHCFNNJLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x342B000", Offset = "0x3429800", VA = "0x18342B000", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int GMKBKFMAECL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x342BFC0", Offset = "0x342A7C0", VA = "0x18342BFC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x342C280", Offset = "0x342AA80", VA = "0x18342C280")]
	public Data KOAOMAPDNDD(Entity KCMPKMKBCOO)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View CMJHHOKIGHE(Entity KCMPKMKBCOO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2159610", Offset = "0x2157E10", VA = "0x182159610", Slot = "14")]
	public override T CMJHHOKIGHE<T>(Entity KCMPKMKBCOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	protected FNCJJMOODDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class MDPDCPPKJHK : EANCAGBLBGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle BPPALDMIIFD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1153320", Offset = "0x1151B20", VA = "0x181153320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type IOHCFNNJLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int GMKBKFMAECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type FDJKIKBOCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D80", Offset = "0x8B4580", VA = "0x1808B5D80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int NFNBPLJODOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4A00", Offset = "0x5DA3200", VA = "0x185DA4A00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private DFAONIGDOMP[] FLLPDHHMPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E780", Offset = "0x3B8CF80", VA = "0x183B8E780", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual DFAONIGDOMP[] GAHOFMFOHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4880", Offset = "0x5DA3080", VA = "0x185DA4880", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4650", Offset = "0x5DA2E50", VA = "0x185DA4650")]
	public void GLJEDCMMNGN(EntityManager IDCNBIGHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T CMJHHOKIGHE<T>(Entity KCMPKMKBCOO) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4790", Offset = "0x5DA2F90", VA = "0x185DA4790", Slot = "8")]
	public (uint, uint) GOEABFOMLFD(Entity KCMPKMKBCOO)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4910", Offset = "0x5DA3110", VA = "0x185DA4910", Slot = "9")]
	public bool MCLLCHOPEDG(Entity KCMPKMKBCOO, (uint order, uint change) IFOEKNINMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected MDPDCPPKJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HLPPOLOCFIC
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DJIOGJPHJOM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FPIBBIDFIDM KGJMPBAPLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NIDDFONOPKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFPIACDNOMB(Entity KCMPKMKBCOO, object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHNKLNMNEPE(Entity KCMPKMKBCOO, object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DIGKAJPHPIC(Entity KCMPKMKBCOO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JIPHGOIOGKB(Entity KCMPKMKBCOO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MMJIPEDJBAF<TComponentData, TValue> : DOMLLFGMDGD<TValue>, IDisposable where TComponentData : struct, DJIOGJPHJOM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class NNLFKKFJNBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> HBKECNHANOP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HLNPNOBJJGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2EA0760", Offset = "0x2E9EF60", VA = "0x182EA0760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDB90", Offset = "0x3BFC390", VA = "0x183BFDB90")]
		public bool FKEPEILKLLN([Out] TValue FKKGMPDEPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDA00", Offset = "0x3BFC200", VA = "0x183BFDA00")]
		public void BONJGFNEKBE(object KIAKEGJPMAL, TValue FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDC80", Offset = "0x3BFC480", VA = "0x183BFDC80")]
		public bool PJFBCFIPABD(object KIAKEGJPMAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDAB0", Offset = "0x3BFC2B0", VA = "0x183BFDAB0")]
		public int FDDGNMPBKIB(object KIAKEGJPMAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDD00", Offset = "0x3BFC500", VA = "0x183BFDD00")]
		public NNLFKKFJNBC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<NNLFKKFJNBC> HBALEHIOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private JAMMDJGAEKI<FPIBBIDFIDM, NNLFKKFJNBC> ANIHFHHKMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B46C40", Offset = "0x3B45440", VA = "0x183B46C40")]
	public MMJIPEDJBAF(EntityManager IDCNBIGHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B46770", Offset = "0x3B44F70", VA = "0x183B46770", Slot = "4")]
	public void FFPIACDNOMB(Entity KCMPKMKBCOO, object KIAKEGJPMAL, TValue FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B469B0", Offset = "0x3B451B0", VA = "0x183B469B0", Slot = "5")]
	public bool HHNKLNMNEPE(Entity KCMPKMKBCOO, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B468B0", Offset = "0x3B450B0", VA = "0x183B468B0", Slot = "6")]
	public bool FKEPEILKLLN(Entity KCMPKMKBCOO, [Out] TValue FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B46750", Offset = "0x3B44F50", VA = "0x183B46750", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B466C0", Offset = "0x3B44EC0", VA = "0x183B466C0")]
	private void DMHJJDEPNJL(NNLFKKFJNBC CAAMNJIDOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B465E0", Offset = "0x3B44DE0", VA = "0x183B465E0")]
	private bool CELKBDNLKLK(Entity KCMPKMKBCOO, [Out] FPIBBIDFIDM KPAMIOKBGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3B46B50", Offset = "0x3B45350", VA = "0x183B46B50")]
	private void NJONAHONAON(Entity KCMPKMKBCOO, FPIBBIDFIDM KPAMIOKBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B466A0", Offset = "0x3B44EA0", VA = "0x183B466A0")]
	private bool CNEGDMHJGLI(FPIBBIDFIDM KPAMIOKBGLD, [Out] NNLFKKFJNBC CAAMNJIDOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B464F0", Offset = "0x3B44CF0", VA = "0x183B464F0")]
	private NNLFKKFJNBC AGNALOOJCKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DOMLLFGMDGD<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFPIACDNOMB(Entity KCMPKMKBCOO, object KIAKEGJPMAL, TValue FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHNKLNMNEPE(Entity KCMPKMKBCOO, object KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FKEPEILKLLN(Entity KCMPKMKBCOO, [Out] TValue FKKGMPDEPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FPIBBIDFIDM : KHMBLBDKHME, IEquatable<FPIBBIDFIDM>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly FPIBBIDFIDM HEADMFFNPAP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int NEMCGPAIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F1550", Offset = "0x7EFD50", VA = "0x1807F1550", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int OGGABIEKFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE230", Offset = "0x1FBCA30", VA = "0x181FBE230", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51FC7D0", Offset = "0x51FAFD0", VA = "0x1851FC7D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3C90", Offset = "0x5DA2490", VA = "0x185DA3C90", Slot = "8")]
	public bool Equals(FPIBBIDFIDM IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3CE0", Offset = "0x5DA24E0", VA = "0x185DA3CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IMHGNPPNKHF<THasTokensTag> : NIDDFONOPKD, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, FPIBBIDFIDM> NJAGCGJDBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> HBALEHIOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JAMMDJGAEKI<FPIBBIDFIDM, HashSet<object>> ANIHFHHKMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem HFDADGLHMNF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x365AAA0", Offset = "0x36592A0", VA = "0x18365AAA0")]
	public IMHGNPPNKHF(EntityManager IDCNBIGHJII, EntityCommandBufferSystem HFDADGLHMNF, DGJIKJLGCCH PEMJKCKDHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36588F0", Offset = "0x36570F0", VA = "0x1836588F0", Slot = "4")]
	public bool FFPIACDNOMB(Entity KCMPKMKBCOO, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3659020", Offset = "0x3657820", VA = "0x183659020", Slot = "5")]
	public bool HHNKLNMNEPE(Entity KCMPKMKBCOO, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3657F00", Offset = "0x3656700", VA = "0x183657F00", Slot = "6")]
	public bool DIGKAJPHPIC(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36580F0", Offset = "0x36568F0", VA = "0x1836580F0", Slot = "9")]
	public bool DIGKAJPHPIC(FPIBBIDFIDM KPAMIOKBGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3659B50", Offset = "0x3658350", VA = "0x183659B50", Slot = "7")]
	public bool JIPHGOIOGKB(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36585B0", Offset = "0x3656DB0", VA = "0x1836585B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3658450", Offset = "0x3656C50", VA = "0x183658450")]
	private void DMHJJDEPNJL(HashSet<object> CAAMNJIDOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3657730", Offset = "0x3655F30", VA = "0x183657730")]
	private bool CELKBDNLKLK(Entity KCMPKMKBCOO, [Out] FPIBBIDFIDM KPAMIOKBGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3657B40", Offset = "0x3656340", VA = "0x183657B40")]
	private bool DBIBBGLCPPG(Entity KCMPKMKBCOO, [Out] FPIBBIDFIDM KPAMIOKBGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3659D60", Offset = "0x3658560", VA = "0x183659D60")]
	private void KMBFJJKEFMD(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x365A2B0", Offset = "0x3658AB0", VA = "0x18365A2B0")]
	private void MJLPOBGPCCM(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3658670", Offset = "0x3656E70", VA = "0x183658670")]
	private void FCKPEEKAHCP(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x365A8B0", Offset = "0x36590B0", VA = "0x18365A8B0")]
	private void NJONAHONAON(Entity KCMPKMKBCOO, FPIBBIDFIDM KPAMIOKBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3657550", Offset = "0x3655D50", VA = "0x183657550")]
	private bool BANBKKNMBJE(FPIBBIDFIDM KPAMIOKBGLD, [Out] HashSet<object> CAAMNJIDOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3657410", Offset = "0x3655C10", VA = "0x183657410")]
	private HashSet<object> AGNALOOJCKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CKFCEEONFCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DDIOAHAKKEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int GDMKPCJDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int EHGKBCBKPCI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DICPGLIBNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE230", Offset = "0x1FBCA30", VA = "0x181FBE230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x51FC7D0", Offset = "0x51FAFD0", VA = "0x1851FC7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HOFIIPOCGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F1550", Offset = "0x7EFD50", VA = "0x1807F1550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GGLEHKIOADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3670", Offset = "0x5DA1E70", VA = "0x185DA3670")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3660", Offset = "0x5DA1E60", VA = "0x185DA3660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x979D20", Offset = "0x978520", VA = "0x180979D20")]
	private DDIOAHAKKEH(int GDMKPCJDDGD, int EHGKBCBKPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C3DEF0", Offset = "0x1C3C6F0", VA = "0x181C3DEF0")]
	public static DDIOAHAKKEH NGABEFBCIOH(int GDMKPCJDDGD, int EHGKBCBKPCI)
	{
		return default(DDIOAHAKKEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3650", Offset = "0x5DA1E50", VA = "0x185DA3650")]
	public static DDIOAHAKKEH DDGJKNHJMHP(int OKLBOBFEAFH, int NHGOLACKIAD)
	{
		return default(DDIOAHAKKEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3680", Offset = "0x5DA1E80", VA = "0x185DA3680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HAKGEGPHKKG : GJNHHMMJPCM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D87CF0", Offset = "0x5D864F0", VA = "0x185D87CF0")]
	public float OIDLIBPKLAB([In] float3 FKKGMPDEPMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D87CF0", Offset = "0x5D864F0", VA = "0x185D87CF0", Slot = "4")]
	private float MDDALJKGNKE([In] float3 FKKGMPDEPMA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BGIPOGOIKEC : GJNHHMMJPCM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D8CD90", Offset = "0x5D8B590", VA = "0x185D8CD90")]
	public float OIDLIBPKLAB([In] float3 FKKGMPDEPMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8CD90", Offset = "0x5D8B590", VA = "0x185D8CD90", Slot = "4")]
	private float MDDALJKGNKE([In] float3 FKKGMPDEPMA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NODIDAKJGEE : GJNHHMMJPCM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1892F50", Offset = "0x1891750", VA = "0x181892F50")]
	public float OIDLIBPKLAB([In] float3 FKKGMPDEPMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1892F50", Offset = "0x1891750", VA = "0x181892F50", Slot = "4")]
	private float MDDALJKGNKE([In] float3 FKKGMPDEPMA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KACJBPOHDPI : GJNHHMMJPCM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0")]
	public int OIDLIBPKLAB([In] int3 FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0", Slot = "4")]
	private int EMNJMADCCBL([In] int3 FKKGMPDEPMA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LBAFECFOHFA : GJNHHMMJPCM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B480", Offset = "0x5D89C80", VA = "0x185D8B480")]
	public int OIDLIBPKLAB([In] int3 FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B480", Offset = "0x5D89C80", VA = "0x185D8B480", Slot = "4")]
	private int EMNJMADCCBL([In] int3 FKKGMPDEPMA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ABKDOCEPFJI : GJNHHMMJPCM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14AF570", Offset = "0x14ADD70", VA = "0x1814AF570")]
	public int OIDLIBPKLAB([In] int3 FKKGMPDEPMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x14AF570", Offset = "0x14ADD70", VA = "0x1814AF570", Slot = "4")]
	private int EMNJMADCCBL([In] int3 FKKGMPDEPMA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HKHEFMHJMND : LCBKPFMJPPL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type PNBDKPAIPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type DJMLGMDAFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3F60", Offset = "0x5DA2760", VA = "0x185DA3F60")]
	public HKHEFMHJMND(Type HAMIBANLOHA, Type EMNPHEHBEOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AHBEOEFJALG : LCBKPFMJPPL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type DJMLGMDAFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3230", Offset = "0x5CC1A30", VA = "0x185CC3230")]
	public AHBEOEFJALG(Type EMNPHEHBEOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GPKGGHMNPIO : LCBKPFMJPPL
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public GPKGGHMNPIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class JJPMKBOFLNN<Data> : CJOGNFGAALB where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data MHFKJLABGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3816850", Offset = "0x3815050", VA = "0x183816850", Slot = "8")]
	protected virtual bool OEOFPBAGEJK(ReadOnlySpan<Data> EGHGICGKMKC, DHNDNMFMONI GLLIFKANKFD, [Out] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "9")]
	protected virtual bool HFDKICJOFJH(int IFOEKNINMPE, Span<Data> EGHGICGKMKC, [In] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3816790", Offset = "0x3814F90", VA = "0x183816790", Slot = "5")]
	internal sealed override bool OEOFPBAGEJK(Unity.Entities.Chunk CKCLFCHPNMG, int JBHELKMCNEM, DHNDNMFMONI GLLIFKANKFD, [Out] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38151C0", Offset = "0x38139C0", VA = "0x1838151C0", Slot = "6")]
	internal sealed override bool HFDKICJOFJH(int IFOEKNINMPE, Unity.Entities.Chunk CKCLFCHPNMG, int JBHELKMCNEM, [In] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2292AC0", Offset = "0x22912C0", VA = "0x182292AC0")]
	protected OEPKNOCBKKM<Protobuf> MOEHJFEKGBO<Protobuf>(ReadOnlySpan<Data> EGHGICGKMKC) where Protobuf : IMessage, new()
	{
		return default(OEPKNOCBKKM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2292A40", Offset = "0x2291240", VA = "0x182292A40")]
	protected IBHGHPACBBK<Protobuf> GHFKMOLCHLH<Protobuf>(ReadOnlySpan<byte> KDMODAMJKPD, ReadOnlySpan<Data> EGHGICGKMKC, Action<Protobuf> HGENDKEEDMF) where Protobuf : IMessage, new()
	{
		return default(IBHGHPACBBK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	protected JJPMKBOFLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class CJOGNFGAALB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int OGGABIEKFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DA35C0", Offset = "0x5DA1DC0", VA = "0x185DA35C0", Slot = "5")]
	internal virtual bool OEOFPBAGEJK(Unity.Entities.Chunk CKCLFCHPNMG, int JBHELKMCNEM, DHNDNMFMONI GLLIFKANKFD, [Out] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "6")]
	internal virtual bool HFDKICJOFJH(int IFOEKNINMPE, Unity.Entities.Chunk CKCLFCHPNMG, int JBHELKMCNEM, [In] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected CJOGNFGAALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IPPPLPIMFEO
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class DPGFJAECHAF : SystemBase, IPPPLPIMFEO
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DA39F0", Offset = "0x5DA21F0", VA = "0x185DA39F0")]
	public ComponentDataFromEntity EBJPEIGNGJE(int JIBGFHDMIBK, bool KLLJNIBCPAM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3AB0", Offset = "0x5DA22B0", VA = "0x185DA3AB0")]
	public EntityExistenceLookupByEntity HMJEOFJBNOI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3AD0", Offset = "0x5DA22D0", VA = "0x185DA3AD0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	protected DPGFJAECHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class LILACEBNEFC : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4620", Offset = "0x5DA2E20", VA = "0x185DA4620", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	protected LILACEBNEFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class AAIMCDCHBCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class PAOJLKNKBDD : DCNNAKBCEBC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4D90", Offset = "0x5DA3590", VA = "0x185DA4D90", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase ABBDPPGKKCL();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4D40", Offset = "0x5DA3540", VA = "0x185DA4D40")]
	protected ComponentSystemBase HIBNJBPIOKH(params ComponentSystemBase[] FOCFONOKHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x24E3860", Offset = "0x24E2060", VA = "0x1824E3860")]
	protected ComponentSystemBase HIBNJBPIOKH<T>(params ComponentSystemBase[] FOCFONOKHED) where T : DCNNAKBCEBC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x24E3820", Offset = "0x24E2020", VA = "0x1824E3820")]
	protected ComponentSystemBase KKKNDHDFOAI<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x24E3820", Offset = "0x24E2020", VA = "0x1824E3820")]
	protected ComponentSystemBase DHKKEIOAPIB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4DE0", Offset = "0x5DA35E0", VA = "0x185DA4DE0")]
	protected ComponentSystemBase PMKBGKLBDBB(params SystemHandleUntyped[] FOCFONOKHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24E3950", Offset = "0x24E2150", VA = "0x1824E3950")]
	protected ComponentSystemBase PMKBGKLBDBB<T>(params SystemHandleUntyped[] FOCFONOKHED) where T : DCNNAKBCEBC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24E38F0", Offset = "0x24E20F0", VA = "0x1824E38F0")]
	protected SystemHandleUntyped JJIKAIDIEJN<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3600", Offset = "0x5DA1E00", VA = "0x185DA3600")]
	protected PAOJLKNKBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DCNNAKBCEBC : LAGILAHGKFH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5DA35D0", Offset = "0x5DA1DD0", VA = "0x185DA35D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3600", Offset = "0x5DA1E00", VA = "0x185DA3600")]
	public DCNNAKBCEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class LAGILAHGKFH : ComponentSystemGroup, IPPPLPIMFEO
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3600", Offset = "0x5DA1E00", VA = "0x185DA3600")]
	protected LAGILAHGKFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class MHNPHMEOCAG : EntityCommandBufferSystem, IPPPLPIMFEO
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	protected MHNPHMEOCAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GJNHHMMJPCM<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo OIDLIBPKLAB([In] TFrom FKKGMPDEPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface MPJKLBPKLOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEHPCGJIGOP(T FKKGMPDEPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct NJCOPPNLNLN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes NPLIHIJEIBH;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4A70", Offset = "0x5DA3270", VA = "0x185DA4A70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct NPGCKFFGDKI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4CA0", Offset = "0x5DA34A0", VA = "0x185DA4CA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct KLHMKJLNJCD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType IPLGGDBFLNE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4040", Offset = "0x5DA2840", VA = "0x185DA4040", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct OCECLODDBON<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3CA5430", Offset = "0x3CA3C30", VA = "0x183CA5430", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct BLFHDINEGDF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> OLDAAMHBNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct JOODJIFELEP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T FKKGMPDEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38295E0", Offset = "0x3827DE0", VA = "0x1838295E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct EANJGLALNHM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GJNHHMMJPCM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> HGDKIPMMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> ELBGOBPFNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap OONIIOMBHJI;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct EKCOIFJBPPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity EOEMHHEKPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> HGDKIPMMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> ELBGOBPFNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int GBBCHOLKNMH;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3B70", Offset = "0x5DA2370", VA = "0x185DA3B70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct DJBALDPPMMP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HHHJHDOCKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> HGDKIPMMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> BPEJHEAHEHG;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct JFCKAIHPNGE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GJNHHMMJPCM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> GAEBNIJGFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> ELBGOBPFNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap OONIIOMBHJI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct ALKLABFAIBM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EMNPHEHBEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> OGKCOBIFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> LEBLNKIIMBB;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct MNHMGBPCMGB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EMNPHEHBEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> OGKCOBIFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> LEBLNKIIMBB;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B46E10", Offset = "0x3B45610", VA = "0x183B46E10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct GNNFJKODCGJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> HGDKIPMMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> BPEJHEAHEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> EEGIPOEDBDO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x35046D0", Offset = "0x3502ED0", VA = "0x1835046D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct HLDONEFEGAB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : GJNHHMMJPCM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> HGDKIPMMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> BPEJHEAHEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> EEGIPOEDBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap OONIIOMBHJI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct DJCNMMHGCMP<T, TPredicate> : IJob where T : struct where TPredicate : struct, MPJKLBPKLOJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> HGDKIPMMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> FLHPCCHCNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> LDHCHLEEGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate OONIIOMBHJI;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4D186C0", Offset = "0x4D16EC0", VA = "0x184D186C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct ILNINBNBFBF<T, TPredicate> : IJob where T : struct where TPredicate : struct, MPJKLBPKLOJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> HGDKIPMMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> BPEJHEAHEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate OONIIOMBHJI;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct CEKFDIOKCHO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity EMNPHEHBEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> OGKCOBIFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> ADICBNCGKJD;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3530", Offset = "0x5DA1D30", VA = "0x185DA3530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct JLGNDEJNINI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity EMNPHEHBEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> OGKCOBIFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> ADICBNCGKJD;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3FB0", Offset = "0x5DA27B0", VA = "0x185DA3FB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LNBGNBAEELD
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NDEMKNDOAJD
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x24AF9E0", Offset = "0x24AE1E0", VA = "0x1824AF9E0")]
	public static bool IGIKCNHGEFJ<T>(this NativeArray<Entity> OGKCOBIFMBH, EntityManager IDCNBIGHJII, Allocator JONICLHJBEP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class EFGMFEOOEDC
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class EKPOCHJGJCG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public EKPOCHJGJCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OMLEFDNAAKD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public OMLEFDNAAKD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> IAJFEKIBENC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3AE0", Offset = "0x5DA22E0", VA = "0x185DA3AE0")]
	public EFGMFEOOEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CKMBBONFDCO
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NCFDIPMHJDF
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct HOKEDECNKGM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct JHOAPBNGBLL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal HOKEDECNKGM<TFrom> OBIIIBPBMLD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> INOEECCONEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct NHAKFEACBLK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct GJCGGBECCFE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal NHAKFEACBLK<TFrom> OBIIIBPBMLD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> INOEECCONEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct KLNPIFEPIPN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct KMIDGENPDAH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal KLNPIFEPIPN<TFrom> OBIIIBPBMLD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> INOEECCONEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct BBNNHKPFJCM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct FDEONCNKCDB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal BBNNHKPFJCM<TFrom> OBIIIBPBMLD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> INOEECCONEM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BEBPLIFIGPP
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class JEFKGODKOJK
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x23BFE90", Offset = "0x23BE690", VA = "0x1823BFE90")]
	public static NativeList<T> BDFOABEBMFH<T>(this NativeList<T> NIEGKHBBCJF, Allocator JONICLHJBEP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x23BFF10", Offset = "0x23BE710", VA = "0x1823BFF10")]
	public static NativeList<T> BDFOABEBMFH<T>(this NativeArray<T> NIEGKHBBCJF, Allocator JONICLHJBEP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ILIPDFBCJLD
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class LEEBCCGEEFF
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x240D3D0", Offset = "0x240BBD0", VA = "0x18240D3D0")]
	[BIMOEGDFFFA]
	public static JobHandle KBGOICCOJPB<T>(this EntityCommandBufferSystem HFDADGLHMNF, NativeArrayAsync<Entity> FAIFKAKJOPP, NativeArrayAsync<T> AELCABDCBDD, [Optional] JobHandle DNKOAJMNLIH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x240D690", Offset = "0x240BE90", VA = "0x18240D690")]
	[BIMOEGDFFFA]
	public static JobHandle KBGOICCOJPB<T>(this EntityCommandBufferSystem HFDADGLHMNF, NativeArrayAsync<Entity> FAIFKAKJOPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x240D2B0", Offset = "0x240BAB0", VA = "0x18240D2B0")]
	[BIMOEGDFFFA]
	public static JobHandle KBGOICCOJPB<T>(this EntityCommandBufferSystem HFDADGLHMNF, NativeArray<Entity> FAIFKAKJOPP, [Optional] JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4210", Offset = "0x5DA2A10", VA = "0x185DA4210")]
	[BIMOEGDFFFA]
	public static JobHandle KBGOICCOJPB(this EntityCommandBufferSystem HFDADGLHMNF, NativeArray<Entity> FAIFKAKJOPP, ComponentTypes NPLIHIJEIBH, [Optional] JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DA40C0", Offset = "0x5DA28C0", VA = "0x185DA40C0")]
	[BIMOEGDFFFA]
	public static JobHandle KBGOICCOJPB(this EntityCommandBufferSystem HFDADGLHMNF, EntityCommandBuffer FBMJLIEEDMG, NativeArray<Entity> FAIFKAKJOPP, ComponentTypes NPLIHIJEIBH, [Optional] JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FFBOIOFOAPO
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x234FDA0", Offset = "0x234E5A0", VA = "0x18234FDA0")]
	[BIMOEGDFFFA]
	public static JobHandle BAMAPDHPLCA<T>(this EntityCommandBufferSystem HFDADGLHMNF, EntityCommandBuffer FBMJLIEEDMG, EntityQuery LGGGLPHDMCK, T FKKGMPDEPMA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class BNLIKGJDBGO
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA32A0", Offset = "0x5DA1AA0", VA = "0x185DA32A0")]
	[BIMOEGDFFFA]
	public static JobHandle JOBHGFJEJPF(this EntityCommandBufferSystem HFDADGLHMNF, NativeList<Entity> FAIFKAKJOPP, [Optional] JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3430", Offset = "0x5DA1C30", VA = "0x185DA3430")]
	[BIMOEGDFFFA]
	public static JobHandle JOBHGFJEJPF(this EntityCommandBufferSystem HFDADGLHMNF, NativeArrayAsync<Entity> FAIFKAKJOPP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class EOICGGCCOAE
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x22497D0", Offset = "0x2247FD0", VA = "0x1822497D0")]
	public static void PJBLADGCNAM<T>(this EntityCommandBufferSystem HFDADGLHMNF, EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2249580", Offset = "0x2247D80", VA = "0x182249580")]
	[BIMOEGDFFFA]
	public static JobHandle OCHOFCPPPPN<T>(this EntityCommandBufferSystem HFDADGLHMNF, NativeListAsync<Entity> FAIFKAKJOPP, [Optional] JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2249640", Offset = "0x2247E40", VA = "0x182249640")]
	[BIMOEGDFFFA]
	public static JobHandle OCHOFCPPPPN<T>(this EntityCommandBufferSystem HFDADGLHMNF, NativeArrayAsync<Entity> FAIFKAKJOPP, [Optional] JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class LEMLNBHGPGI
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x240DB20", Offset = "0x240C320", VA = "0x18240DB20")]
	[BIMOEGDFFFA]
	public static JobHandle DODPDMEGEBG<T>(this EntityCommandBufferSystem HFDADGLHMNF, NativeArray<Entity> FAIFKAKJOPP, NativeArray<T> AELCABDCBDD, JobHandle DNKOAJMNLIH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CIDFHDINIGM
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x21F10B0", Offset = "0x21EF8B0", VA = "0x1821F10B0")]
	[BIMOEGDFFFA]
	public static JobHandle CJCDFHCFIHB<T>(this EntityCommandBufferSystem HFDADGLHMNF, NativeArray<Entity> FAIFKAKJOPP, T FKKGMPDEPMA, [Optional] JobHandle DNKOAJMNLIH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x21F0FE0", Offset = "0x21EF7E0", VA = "0x1821F0FE0")]
	[BIMOEGDFFFA]
	public static JobHandle CJCDFHCFIHB<T>(this EntityCommandBufferSystem HFDADGLHMNF, EntityCommandBuffer FBMJLIEEDMG, NativeArray<Entity> FAIFKAKJOPP, T FKKGMPDEPMA, [Optional] JobHandle DNKOAJMNLIH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class MMHGLJBHGHD
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2454FC0", Offset = "0x24537C0", VA = "0x182454FC0")]
	public static NativeList<T> BDFOABEBMFH<T>(NativeList<T> NIEGKHBBCJF, Allocator JONICLHJBEP) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class MGNABDIJNBD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2443150", Offset = "0x2441950", VA = "0x182443150")]
	public static NativeArray<T> GBHOKGFOPCG<T>(this NativeList<Entity> NIEGKHBBCJF, EntityManager IDCNBIGHJII, Allocator JONICLHJBEP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2442C10", Offset = "0x2441410", VA = "0x182442C10")]
	public static NativeArray<T> GBHOKGFOPCG<T>(this NativeArray<Entity> NIEGKHBBCJF, EntityManager IDCNBIGHJII, Allocator JONICLHJBEP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MLJMIDFMGDP
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LJHPJGGCENM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct FEMNNBLIACJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public LJHPJGGCENM<TFrom> INOEECCONEM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> HGDKIPMMJHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct GMIEDOCOHMI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct FABEGEJMKED<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public GMIEDOCOHMI<TFrom> INOEECCONEM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> HGDKIPMMJHF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct ANOEAPLEBMJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct MPKAPAKHCPA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public ANOEAPLEBMJ<TFrom> INOEECCONEM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> HGDKIPMMJHF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OPPFIJLOKCL
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class LNDOADKFHGN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct HBNEAMGKBIL : GJNHHMMJPCM<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> CFNAHIMOJCK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3E20", Offset = "0x5DA2620", VA = "0x185DA3E20")]
		[BurstCompatible]
		public Entity OIDLIBPKLAB([In] Entity FKKGMPDEPMA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5DA3E20", Offset = "0x5DA2620", VA = "0x185DA3E20", Slot = "4")]
		private Entity FDBBOFOJFKA([In] Entity FKKGMPDEPMA)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class MEEOCNEPBFA
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct BHLCIKKBIOI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> FLHPCCHCNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> HGDKIPMMJHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct KOHLHHAFLCB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> FLHPCCHCNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> HGDKIPMMJHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct KEHKIDPBNGK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> FLHPCCHCNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> HGDKIPMMJHF;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2292E90", Offset = "0x2291690", VA = "0x182292E90")]
		public NativeListAsync<Entity> KEHPCGJIGOP<TPredicate>() where TPredicate : struct, MPJKLBPKLOJ<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x243A410", Offset = "0x2438C10", VA = "0x18243A410")]
	public static KEHKIDPBNGK<T> MJAHDCMDFLP<T>(this NativeArrayAsync<Entity> OGKCOBIFMBH, NativeArrayAsync<T> NIEGKHBBCJF, Allocator JONICLHJBEP = Allocator.TempJob) where T : struct
	{
		return default(KEHKIDPBNGK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class MFANPGOPNFI
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x243A700", Offset = "0x2438F00", VA = "0x18243A700")]
	public static NativeListAsync<Entity> AFIEGBFBKJI<T, TPredicate>(this NativeArrayAsync<T> NIEGKHBBCJF, NativeArrayAsync<Entity> OGKCOBIFMBH, Allocator JONICLHJBEP = Allocator.TempJob) where T : struct where TPredicate : struct, MPJKLBPKLOJ<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x243A7C0", Offset = "0x2438FC0", VA = "0x18243A7C0")]
	private static NativeListAsync<Entity> HKGGJMPMECM<T, TPredicate>(NativeArrayAsync<T> IJCKPBEPNJK, NativeArrayAsync<Entity> OGKCOBIFMBH, int HPFMIMMLOKB, Allocator JONICLHJBEP) where T : struct where TPredicate : struct, MPJKLBPKLOJ<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class PIBOJIGJEIM
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct LAHIJLMJJDO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> HGDKIPMMJHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct OJCJPECJNIE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> HGDKIPMMJHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct EOGHGDFENMN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> HGDKIPMMJHF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct PJHPCGPKLAO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator JONICLHJBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> HGDKIPMMJHF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class FMEIGCFJDBA
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class IILNOINBIKM
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2394D80", Offset = "0x2393580", VA = "0x182394D80")]
	public static NativeList<Entity> CECHIIPFMJJ<T>(this NativeArray<Entity> OGKCOBIFMBH, EntityManager IDCNBIGHJII, Allocator JONICLHJBEP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class JBJMLODJCHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class NJFIFEHKLEL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct NBAFKFEOCID<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> INLAJDDNHAO;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
		public NBAFKFEOCID(NativeArray<TSrc> INLAJDDNHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
		public ENNPDJJGCGJ<TSrc, TValue> CNCAONLPCOM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(ENNPDJJGCGJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct ENNPDJJGCGJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> INLAJDDNHAO;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
		public ENNPDJJGCGJ(NativeArray<TSrc> INLAJDDNHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
		public NNBHJMMEEJC<TSrc, TValue, TSelector> HEMPNHFOMOC<TSelector>() where TSelector : struct, GJNHHMMJPCM<TSrc, TValue>
		{
			return default(NNBHJMMEEJC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct NNBHJMMEEJC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GJNHHMMJPCM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> INLAJDDNHAO;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E960", Offset = "0x1C2D160", VA = "0x181C2E960")]
		public NNBHJMMEEJC(NativeArray<TSrc> INLAJDDNHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA350", Offset = "0x3BF8B50", VA = "0x183BFA350")]
		public BIECIBJCMOI<TSrc, TValue, TSelector> HIBNJBPIOKH()
		{
			return default(BIECIBJCMOI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct COIAPFBAKEC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, GJNHHMMJPCM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> INLAJDDNHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector NIHMLADDDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int LFEFGCGCIAG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue NPBPBJCHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x4B7B200", Offset = "0x4B79A00", VA = "0x184B7B200")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int NEMCGPAIDHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C9910", Offset = "0x8C8110", VA = "0x1808C9910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int LPJHKGAOANG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1C420C0", Offset = "0x1C408C0", VA = "0x181C420C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B2A0", Offset = "0x4B79AA0", VA = "0x184B7B2A0")]
		public COIAPFBAKEC(NativeArray<TSrc> INLAJDDNHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B290", Offset = "0x4B79A90", VA = "0x184B7B290")]
		public bool NFEIHDNFEML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B120", Offset = "0x4B79920", VA = "0x184B7B120")]
		private TSrc BOALFNKBFGJ(int DKLECPOCCOI)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct BIECIBJCMOI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GJNHHMMJPCM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private COIAPFBAKEC<TSrc, TValue, TSelector> CODIDGBMKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue GOFPLJKGMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int AIINMNHNKBO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public DDIOAHAKKEH JHKJCHJLPBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x43F6990", Offset = "0x43F5190", VA = "0x1843F6990")]
			get
			{
				return default(DDIOAHAKKEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue AIDPMNKEECP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, DDIOAHAKKEH range) NPBPBJCHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x43F68B0", Offset = "0x43F50B0", VA = "0x1843F68B0")]
			get
			{
				return default((TValue, DDIOAHAKKEH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x43F6B10", Offset = "0x43F5310", VA = "0x1843F6B10")]
		public BIECIBJCMOI(NativeArray<TSrc> INLAJDDNHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x340DEA0", Offset = "0x340C6A0", VA = "0x18340DEA0")]
		public BIECIBJCMOI<TSrc, TValue, TSelector> EKEEKKCIFJI()
		{
			return default(BIECIBJCMOI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x43F69D0", Offset = "0x43F51D0", VA = "0x1843F69D0")]
		public bool NFEIHDNFEML()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x24B4890", Offset = "0x24B3090", VA = "0x1824B4890")]
	public static NBAFKFEOCID<T> AJGANFLOBOO<T>(this NativeList<T> HBKECNHANOP) where T : struct
	{
		return default(NBAFKFEOCID<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
	public static NBAFKFEOCID<T> AJGANFLOBOO<T>(this NativeArray<T> INLAJDDNHAO) where T : struct
	{
		return default(NBAFKFEOCID<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class ODCLMNEGLIA
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct CGOLOBCBJBL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly INLAJDDNHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int AIINMNHNKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int AIMMGECOHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T GOFPLJKGMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T COMFLNBNMEC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public DDIOAHAKKEH JHKJCHJLPBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x3816970", Offset = "0x3815170", VA = "0x183816970")]
			get
			{
				return default(DDIOAHAKKEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T AIDPMNKEECP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x3103A40", Offset = "0x3102240", VA = "0x183103A40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, DDIOAHAKKEH) NPBPBJCHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2090", Offset = "0x4AD0890", VA = "0x184AD2090")]
			get
			{
				return default((T, DDIOAHAKKEH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4AD25C0", Offset = "0x4AD0DC0", VA = "0x184AD25C0")]
		public CGOLOBCBJBL(NativeArray<T> INLAJDDNHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4AD2050", Offset = "0x4AD0850", VA = "0x184AD2050")]
		public CGOLOBCBJBL<T> EKEEKKCIFJI()
		{
			return default(CGOLOBCBJBL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4AD2210", Offset = "0x4AD0A10", VA = "0x184AD2210")]
		public bool NFEIHDNFEML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD16E0", Offset = "0x2BCFEE0", VA = "0x182BD16E0")]
		public JKCCLMJNNIE<T, TComparer> BOANELFCFHH<TComparer>([Optional] TComparer JLBEHDIPANB) where TComparer : struct, IEqualityComparer<T>
		{
			return default(JKCCLMJNNIE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct JKCCLMJNNIE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly INLAJDDNHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int AIINMNHNKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int AIMMGECOHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T GOFPLJKGMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T COMFLNBNMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer JLBEHDIPANB;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DDIOAHAKKEH JHKJCHJLPBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3816970", Offset = "0x3815170", VA = "0x183816970")]
			get
			{
				return default(DDIOAHAKKEH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T AIDPMNKEECP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x3103A40", Offset = "0x3102240", VA = "0x183103A40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, DDIOAHAKKEH range) NPBPBJCHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x38168A0", Offset = "0x38150A0", VA = "0x1838168A0")]
			get
			{
				return default((T, DDIOAHAKKEH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3816B60", Offset = "0x3815360", VA = "0x183816B60")]
		public JKCCLMJNNIE(NativeArray<T>.ReadOnly INLAJDDNHAO, TComparer JLBEHDIPANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3816860", Offset = "0x3815060", VA = "0x183816860")]
		public JKCCLMJNNIE<T, TComparer> EKEEKKCIFJI()
		{
			return default(JKCCLMJNNIE<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3816980", Offset = "0x3815180", VA = "0x183816980")]
		public bool NFEIHDNFEML()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x24D6A00", Offset = "0x24D5200", VA = "0x1824D6A00")]
	public static CGOLOBCBJBL<T> HIBNJBPIOKH<T>(this NativeArray<T> INLAJDDNHAO) where T : struct
	{
		return default(CGOLOBCBJBL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface CABPMEIOOGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class DNOJGLAPCKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct IBHGHPACBBK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class BPEGIAFHLBJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public IBHGHPACBBK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x955E20", Offset = "0x954620", VA = "0x180955E20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x305A1D0", Offset = "0x30589D0", VA = "0x18305A1D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public BPEGIAFHLBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x48981E0", Offset = "0x48969E0", VA = "0x1848981E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4898390", Offset = "0x4896B90", VA = "0x184898390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> HGENDKEEDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream NFDLBBEFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream HMLPNBECIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf MDEENBAIGOI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int LPJHKGAOANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x361F460", Offset = "0x361DC60", VA = "0x18361F460")]
	private IBHGHPACBBK(byte[] NEJFCHMJPKN, Action<Protobuf> HGENDKEEDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x228F300", Offset = "0x228DB00", VA = "0x18228F300")]
	public static IBHGHPACBBK<Protobuf> KLKFANDJKFE<Data>(ReadOnlySpan<byte> KDMODAMJKPD, ReadOnlySpan<Data> EGHGICGKMKC, Action<Protobuf> HGENDKEEDMF)
	{
		return default(IBHGHPACBBK<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x361F2D0", Offset = "0x361DAD0", VA = "0x18361F2D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x361F310", Offset = "0x361DB10", VA = "0x18361F310", Slot = "4")]
	[IteratorStateMachine(typeof(IBHGHPACBBK<>.BPEGIAFHLBJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x361F400", Offset = "0x361DC00", VA = "0x18361F400", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct OEPKNOCBKKM<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] NEJFCHMJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf MDEENBAIGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream NFDLBBEFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream BPDCEKAHEAI;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3880", Offset = "0x3CD2080", VA = "0x183CD3880")]
	private OEPKNOCBKKM(byte[] NEJFCHMJPKN, [In] Protobuf MDEENBAIGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x22B09B0", Offset = "0x22AF1B0", VA = "0x1822B09B0")]
	public static OEPKNOCBKKM<Protobuf> KLKFANDJKFE<T>(ReadOnlySpan<T> EGHGICGKMKC)
	{
		return default(OEPKNOCBKKM<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3850", Offset = "0x3CD2050", VA = "0x183CD3850")]
	public void OEDPDHFJJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3690", Offset = "0x3CD1E90", VA = "0x183CD3690")]
	public ByteString DLFBMNIIFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3CD3720", Offset = "0x3CD1F20", VA = "0x183CD3720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct BCHLODFKBOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream NFDLBBEFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream HMLPNBECIPN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3260", Offset = "0x5DA1A60", VA = "0x185DA3260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct HIGBHJPHILE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] NEJFCHMJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream NFDLBBEFMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream BPDCEKAHEAI;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3E30", Offset = "0x5DA2630", VA = "0x185DA3E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class DKLCJAEBCLP
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void KEGNFKKDCFF<From, To>(From INOEECCONEM, To HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class EAHAAOEKPCD<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static KEGNFKKDCFF<From, To> LPAOHBCGPDD;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EAHAAOEKPCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3720", Offset = "0x5DA1F20", VA = "0x185DA3720")]
	static DKLCJAEBCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x22171B0", Offset = "0x22159B0", VA = "0x1822171B0")]
	public static void AGKCEMOEPMJ<T>(KEGNFKKDCFF<T, T> POHGEFEPGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2216EC0", Offset = "0x22156C0", VA = "0x182216EC0")]
	public static void AGKCEMOEPMJ<From, To>(KEGNFKKDCFF<From, To> POHGEFEPGAM, KEGNFKKDCFF<To, From> MHJJMBIPBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2216F40", Offset = "0x2215740", VA = "0x182216F40")]
	public static void AGKCEMOEPMJ<From, To>(KEGNFKKDCFF<From, To> LPAOHBCGPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2219330", Offset = "0x2217B30", VA = "0x182219330")]
	public static KEGNFKKDCFF<From, To> FEFOPMIBDIF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x221F5A0", Offset = "0x221DDA0", VA = "0x18221F5A0")]
	public static void INLNMAKKHJG<From, To>(From INOEECCONEM, To HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class DHNDNMFMONI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> BLEDCLJNKHA;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C08190", Offset = "0x1C06990", VA = "0x181C08190")]
	public DHNDNMFMONI(NativeArray<EntityRemapUtility.EntityRemapInfo> BLEDCLJNKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3710", Offset = "0x5DA1F10", VA = "0x185DA3710")]
	public Entity FONOHOFMIAK(Entity KLIANGHAKAC)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class GNLKGJIOAMM
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3D90", Offset = "0x5DA2590", VA = "0x185DA3D90")]
	public static ulong MECGDGDANBB(Type GFGNPBCFEMC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3D30", Offset = "0x5DA2530", VA = "0x185DA3D30")]
	public static ulong MECGDGDANBB(string HJEIBFIBOMG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum HPHHJFOKEDC
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AttributeUsage(AttributeTargets.Class)]
public class PELBEBCDLPI : LCBKPFMJPPL
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public PELBEBCDLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class LHIOIJEANHE
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4550", Offset = "0x5DA2D50", VA = "0x185DA4550")]
	private unsafe static Span<byte> MPMCIPICJPH(Unity.Entities.Chunk* CKCLFCHPNMG, int JBHELKMCNEM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x240F9C0", Offset = "0x240E1C0", VA = "0x18240F9C0")]
	public unsafe static Span<T> INONKDIGPIA<T>(Unity.Entities.Chunk* CKCLFCHPNMG, int JBHELKMCNEM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2361A90", Offset = "0x2360290", VA = "0x182361A90")]
	public static Span<T> INONKDIGPIA<T>(this Unity.Entities.Chunk CKCLFCHPNMG, int JBHELKMCNEM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5DA44F0", Offset = "0x5DA2CF0", VA = "0x185DA44F0")]
	public unsafe static Span<Entity> MBEINBDOAOA(Unity.Entities.Chunk* CKCLFCHPNMG)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5DA4380", Offset = "0x5DA2B80", VA = "0x185DA4380")]
	public unsafe static void BEIKHFOBAHI(Unity.Entities.Chunk* CKCLFCHPNMG, int JBHELKMCNEM)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class CAANBFNPALO
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CAANBFNPALO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
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
