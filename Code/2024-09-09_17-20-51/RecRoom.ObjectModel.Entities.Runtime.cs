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
using Unity.Burst.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C9A870", Offset = "0x6C99270", VA = "0x186C9A870")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JBHJGPJDINF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BOEJAEGFCAA FNAOEBKOBJI
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
public interface MINPAEJBBGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBDFCEBOEEK(Entity AFNIOPPCKNG, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OEMCLHMOOPI(Entity AFNIOPPCKNG, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKJGGPJDJKO(Entity AFNIOPPCKNG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CFGFGGCDABM<TComponentData, TValue> : PGPMGNHAOJG<TValue>, IDisposable where TComponentData : struct, JBHJGPJDINF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class BCMKHJAFHGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> GLCCIANLCJC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int LEDCMOMLPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3764D90", Offset = "0x3763790", VA = "0x183764D90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x509A4F0", Offset = "0x5098EF0", VA = "0x18509A4F0")]
		public bool ADEFBJCMNFM([Out] TValue IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x509A790", Offset = "0x5099190", VA = "0x18509A790")]
		public void KDCHLCHLBCK(object OEELDHBFFAF, TValue IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x509A6E0", Offset = "0x50990E0", VA = "0x18509A6E0")]
		public bool GDFNAHCIADO(object OEELDHBFFAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x509A600", Offset = "0x5099000", VA = "0x18509A600")]
		public int COKCFNJBHFI(object OEELDHBFFAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x509A870", Offset = "0x5099270", VA = "0x18509A870")]
		public BCMKHJAFHGE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<BCMKHJAFHGE> BDMIEPBMLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BKMJPONAGEP<BOEJAEGFCAA, BCMKHJAFHGE> EDLADNJIPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager JONCEOFPEBL;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x54D05E0", Offset = "0x54CEFE0", VA = "0x1854D05E0")]
	public CFGFGGCDABM(EntityManager JONCEOFPEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x54CFF70", Offset = "0x54CE970", VA = "0x1854CFF70", Slot = "4")]
	public void EBDFCEBOEEK(Entity AFNIOPPCKNG, object OEELDHBFFAF, TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x54D0330", Offset = "0x54CED30", VA = "0x1854D0330", Slot = "5")]
	public bool OEMCLHMOOPI(Entity AFNIOPPCKNG, object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x54CFD80", Offset = "0x54CE780", VA = "0x1854CFD80", Slot = "6")]
	public bool ADEFBJCMNFM(Entity AFNIOPPCKNG, [Out] TValue IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x54CFF50", Offset = "0x54CE950", VA = "0x1854CFF50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54CFE90", Offset = "0x54CE890", VA = "0x1854CFE90")]
	private void BLANOGKCJNN(BCMKHJAFHGE GNFBOLNOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x54D0520", Offset = "0x54CEF20", VA = "0x1854D0520")]
	private bool OPKMLGJCBPP(Entity AFNIOPPCKNG, [Out] BOEJAEGFCAA DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x54D0110", Offset = "0x54CEB10", VA = "0x1854D0110")]
	private void GAOLIFNDCNC(Entity AFNIOPPCKNG, BOEJAEGFCAA DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x54D00F0", Offset = "0x54CEAF0", VA = "0x1854D00F0")]
	private bool GAEJNGCOCCK(BOEJAEGFCAA DKMIJDPJCBM, [Out] BCMKHJAFHGE GNFBOLNOHHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x54D0210", Offset = "0x54CEC10", VA = "0x1854D0210")]
	private BCMKHJAFHGE IIAICJFANDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PGPMGNHAOJG<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBDFCEBOEEK(Entity AFNIOPPCKNG, object OEELDHBFFAF, TValue IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OEMCLHMOOPI(Entity AFNIOPPCKNG, object OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ADEFBJCMNFM(Entity AFNIOPPCKNG, [Out] TValue IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BOEJAEGFCAA : JEDKKJGHJPP, IEquatable<BOEJAEGFCAA>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly BOEJAEGFCAA GOLLGDANENM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PCGHHNFLFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x26E9F30", Offset = "0x26E8930", VA = "0x1826E9F30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63070", VA = "0x185F64670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A5B0", Offset = "0x6C98FB0", VA = "0x186C9A5B0", Slot = "8")]
	public bool Equals(BOEJAEGFCAA CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A600", Offset = "0x6C99000", VA = "0x186C9A600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JADFJIIAOMF<THasTokensTag> : MINPAEJBBGE, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, BOEJAEGFCAA> BCECAALFDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> BDMIEPBMLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BKMJPONAGEP<BOEJAEGFCAA, HashSet<object>> EDLADNJIPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager JONCEOFPEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem AJFJJDLJIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NMOEEADIFFA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x426AFE0", Offset = "0x42699E0", VA = "0x18426AFE0")]
	public JADFJIIAOMF(EntityManager JONCEOFPEBL, EntityCommandBufferSystem AJFJJDLJIAL, CAFGMNLACIN KEEJDACBEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4268E30", Offset = "0x4267830", VA = "0x184268E30", Slot = "4")]
	public bool EBDFCEBOEEK(Entity AFNIOPPCKNG, object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x426A640", Offset = "0x4269040", VA = "0x18426A640", Slot = "5")]
	public bool OEMCLHMOOPI(Entity AFNIOPPCKNG, object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4269F30", Offset = "0x4268930", VA = "0x184269F30", Slot = "6")]
	public bool JKJGGPJDJKO(Entity AFNIOPPCKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x426A1F0", Offset = "0x4268BF0", VA = "0x18426A1F0", Slot = "8")]
	public bool JKJGGPJDJKO(BOEJAEGFCAA DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4268D70", Offset = "0x4267770", VA = "0x184268D70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42688F0", Offset = "0x42672F0", VA = "0x1842688F0")]
	private void BLANOGKCJNN(HashSet<object> GNFBOLNOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x426A9E0", Offset = "0x42693E0", VA = "0x18426A9E0")]
	private bool OPKMLGJCBPP(Entity AFNIOPPCKNG, [Out] BOEJAEGFCAA DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x426ACE0", Offset = "0x42696E0", VA = "0x18426ACE0")]
	private bool PPLIDKBHMOP(Entity AFNIOPPCKNG, [Out] BOEJAEGFCAA DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42687F0", Offset = "0x42671F0", VA = "0x1842687F0")]
	private void AIKCCHGFCLN(Entity AFNIOPPCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4269AB0", Offset = "0x42684B0", VA = "0x184269AB0")]
	private void IPFPFPFDNCG(Entity AFNIOPPCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4268AB0", Offset = "0x42674B0", VA = "0x184268AB0")]
	private void DCKFDFIMBFP(Entity AFNIOPPCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4269650", Offset = "0x4268050", VA = "0x184269650")]
	private void GAOLIFNDCNC(Entity AFNIOPPCKNG, BOEJAEGFCAA DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4269E70", Offset = "0x4268870", VA = "0x184269E70")]
	private bool JFFJMBBDPJJ(BOEJAEGFCAA DKMIJDPJCBM, [Out] HashSet<object> GNFBOLNOHHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4269870", Offset = "0x4268270", VA = "0x184269870")]
	private HashSet<object> IIAICJFANDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FGODFAHKEEP
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HDOBONADNAO : OMCCCCPHIDG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AB50", Offset = "0x6C99550", VA = "0x186C9AB50")]
	public float IHPBGCKJIPF([In] float3 IPHMAHBENGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AB50", Offset = "0x6C99550", VA = "0x186C9AB50", Slot = "4")]
	private float FFOCHKNPBEI([In] float3 IPHMAHBENGI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BDKOFLCFCFH : OMCCCCPHIDG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A510", Offset = "0x6C98F10", VA = "0x186C9A510")]
	public float IHPBGCKJIPF([In] float3 IPHMAHBENGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A510", Offset = "0x6C98F10", VA = "0x186C9A510", Slot = "4")]
	private float FFOCHKNPBEI([In] float3 IPHMAHBENGI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GNNMFEOJDJG : OMCCCCPHIDG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x94B070", Offset = "0x949A70", VA = "0x18094B070")]
	public float IHPBGCKJIPF([In] float3 IPHMAHBENGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x94B070", Offset = "0x949A70", VA = "0x18094B070", Slot = "4")]
	private float FFOCHKNPBEI([In] float3 IPHMAHBENGI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PHDKPAAKAPK : OMCCCCPHIDG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1903E70", Offset = "0x1902870", VA = "0x181903E70")]
	public int IHPBGCKJIPF([In] int3 IPHMAHBENGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1903E70", Offset = "0x1902870", VA = "0x181903E70", Slot = "4")]
	private int PNLBJAJFNBI([In] int3 IPHMAHBENGI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MHBMHLOFFLJ : OMCCCCPHIDG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C9B3A0", Offset = "0x6C99DA0", VA = "0x186C9B3A0")]
	public int IHPBGCKJIPF([In] int3 IPHMAHBENGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9B3A0", Offset = "0x6C99DA0", VA = "0x186C9B3A0", Slot = "4")]
	private int PNLBJAJFNBI([In] int3 IPHMAHBENGI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FHMHENIGGBO : OMCCCCPHIDG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x928E70", Offset = "0x927870", VA = "0x180928E70")]
	public int IHPBGCKJIPF([In] int3 IPHMAHBENGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x928E70", Offset = "0x927870", VA = "0x180928E70", Slot = "4")]
	private int PNLBJAJFNBI([In] int3 IPHMAHBENGI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HEFMMKHOLBP : LCCBCKAMMLH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
	public HEFMMKHOLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class IKEHHAGGAKN : SystemBase, NFDFCPIONBC
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AE20", Offset = "0x6C99820", VA = "0x186C9AE20")]
	public JobHandle MFBGILHIOGG(ReadOnlySpan<int> BFOOPLFHHAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8C40", Offset = "0x2DA7640", VA = "0x182DA8C40")]
	public void GELLIOIFELK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DA89A0", Offset = "0x2DA73A0", VA = "0x182DA89A0")]
	public JobHandle GELLIOIFELK<T>(JobHandle DKMIJDPJCBM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AD90", Offset = "0x6C99790", VA = "0x186C9AD90")]
	public JobHandle GELLIOIFELK(ReadOnlySpan<int> BFOOPLFHHAC, JobHandle DKMIJDPJCBM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8C40", Offset = "0x2DA7640", VA = "0x182DA8C40")]
	public void NFFEJIAOKPK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9910", Offset = "0x2DA8310", VA = "0x182DA9910")]
	public JobHandle NFFEJIAOKPK<T>(JobHandle DKMIJDPJCBM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C9ACD0", Offset = "0x6C996D0", VA = "0x186C9ACD0")]
	public ComponentDataFromEntity CDHMPLJINKF(int DFOHIMDHCEM, bool KECCEDOIHIM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AE00", Offset = "0x6C99800", VA = "0x186C9AE00")]
	public EntityExistenceLookupByEntity KNOMJOBPIDH()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AE70", Offset = "0x6C99870", VA = "0x186C9AE70", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
	protected IKEHHAGGAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class ELBGAGPOAGH : IKEHHAGGAKN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A840", Offset = "0x6C99240", VA = "0x186C9A840", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
	protected ELBGAGPOAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BEJHNLPFEPJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class HJILIBAPDBB : EntityCommandBufferSystem, NFDFCPIONBC
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
	protected HJILIBAPDBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OMCCCCPHIDG<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IHPBGCKJIPF([In] TFrom IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HKBBNGJEEBG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IFDNPFPFGAJ(T IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct HKKIAJNGKLM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> NLHOBFOIDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer NKIBOMOJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes HMIBAPIDOKL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AB60", Offset = "0x6C99560", VA = "0x186C9AB60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct JFCOIJOGDFE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> NLHOBFOIDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer NKIBOMOJOPA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AE80", Offset = "0x6C99880", VA = "0x186C9AE80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct IGIBBIMJHFO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> NLHOBFOIDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer NKIBOMOJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType OHFAPJOJCKG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AC50", Offset = "0x6C99650", VA = "0x186C9AC50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct OPLLDHPOLFO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> NLHOBFOIDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> LNCKNHNHHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer NKIBOMOJOPA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x490E530", Offset = "0x490CF30", VA = "0x18490E530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct FGACFIIMHNA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> NLHOBFOIDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> KIAGDMGGGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer NKIBOMOJOPA;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct NFANODMNJAO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> NLHOBFOIDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T IPHMAHBENGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer NKIBOMOJOPA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4795D40", Offset = "0x4794740", VA = "0x184795D40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct HHKIJOFCNBK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OMCCCCPHIDG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> GOHCMHMPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> JJPAABCNFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap GGEEGOKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct OAMKPJDPHKE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity JJCPACPABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> GOHCMHMPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> JJPAABCNFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int DEHLAEKHHNC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C9B3B0", Offset = "0x6C99DB0", VA = "0x186C9B3B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct NLHBEPHFHPL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FKIGKDAMAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> GOHCMHMPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> FGEACAMMFFO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct IMPIMJFOAII<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OMCCCCPHIDG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> AKCIGKNJKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> JJPAABCNFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap GGEEGOKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct PALPGMOPGGI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FOIOIBANMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> BOOFLHPDJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> HMPBPKJBHCI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct OPDAJACAPMP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FOIOIBANMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> BOOFLHPDJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> HMPBPKJBHCI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x490DF10", Offset = "0x490C910", VA = "0x18490DF10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct IGJEENANIMG<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> GOHCMHMPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> FGEACAMMFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> ICFMCHEMBJE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x408EB90", Offset = "0x408D590", VA = "0x18408EB90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct FLBOEJFCLDA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : OMCCCCPHIDG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> GOHCMHMPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> FGEACAMMFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> ICFMCHEMBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap GGEEGOKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct IHINNKHFEON<T, TPredicate> : IJob where T : struct where TPredicate : struct, HKBBNGJEEBG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> GOHCMHMPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> PAGENMKPAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> PPKCAAHBPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate GGEEGOKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct PHNLKEHHIIJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, HKBBNGJEEBG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> GOHCMHMPDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> FGEACAMMFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate GGEEGOKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct PLPGMEAKJFD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity FOIOIBANMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> BOOFLHPDJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> IALLKCOLCPC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9B4B0", Offset = "0x6C99EB0", VA = "0x186C9B4B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct DEIMJHECBJC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity FOIOIBANMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> BOOFLHPDJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> IALLKCOLCPC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A690", Offset = "0x6C99090", VA = "0x186C9A690", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BCDOGDADNCI
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JLDGMKEFOJM
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2DC45F0", Offset = "0x2DC2FF0", VA = "0x182DC45F0")]
	public static bool DEEKLOLKFCO<T>(this NativeArray<Entity> BOOFLHPDJOP, EntityManager JONCEOFPEBL, Allocator MPFEIGMBFCP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BODNPILOPNN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HJCDGMELALK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public HJCDGMELALK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NPLEHJAMNFA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public NPLEHJAMNFA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> JIADMNCPONF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A520", Offset = "0x6C98F20", VA = "0x186C9A520")]
	public BODNPILOPNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HIIIKNOHOJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CBCPMKNDHEL
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct LMNBKMCLDCA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct EPOGCHKJKCB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal LMNBKMCLDCA<TFrom> KMAENCDMJDN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> EEBGELKKKEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct CIPGHNDJDKA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct NEAANIBBDEK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal CIPGHNDJDKA<TFrom> KMAENCDMJDN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> EEBGELKKKEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct AGOLFGPGEGC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct APIHGDEIKEI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal AGOLFGPGEGC<TFrom> KMAENCDMJDN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> EEBGELKKKEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct OPCMAOCIJPL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct ENLGHKEDNMG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal OPCMAOCIJPL<TFrom> KMAENCDMJDN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> EEBGELKKKEJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NBKHJBGLMKI
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HAGFMDPAJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2D76EF0", Offset = "0x2D758F0", VA = "0x182D76EF0")]
	public static NativeList<T> OCJGKNNOEDA<T>(this NativeArray<T> NLDHJDINPDB, Allocator MPFEIGMBFCP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MBNPLHLNMJJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FODCGEHBPHM
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D5B700", Offset = "0x2D5A100", VA = "0x182D5B700")]
	[MBAOJIDJINM]
	public static JobHandle JEDJPMLPDAD<T>(this EntityCommandBufferSystem AJFJJDLJIAL, NativeArrayAsync<Entity> NLHOBFOIDFG, NativeArrayAsync<T> LNCKNHNHHDF, [Optional] JobHandle HGENEDIAIEP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2D5B880", Offset = "0x2D5A280", VA = "0x182D5B880")]
	[MBAOJIDJINM]
	public static JobHandle JEDJPMLPDAD<T>(this EntityCommandBufferSystem AJFJJDLJIAL, NativeArrayAsync<Entity> NLHOBFOIDFG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2D5B5D0", Offset = "0x2D59FD0", VA = "0x182D5B5D0")]
	[MBAOJIDJINM]
	public static JobHandle JEDJPMLPDAD<T>(this EntityCommandBufferSystem AJFJJDLJIAL, NativeArray<Entity> NLHOBFOIDFG, [Optional] JobHandle HGENEDIAIEP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A9E0", Offset = "0x6C993E0", VA = "0x186C9A9E0")]
	[MBAOJIDJINM]
	public static JobHandle JEDJPMLPDAD(this EntityCommandBufferSystem AJFJJDLJIAL, NativeArray<Entity> NLHOBFOIDFG, ComponentTypes HMIBAPIDOKL, [Optional] JobHandle HGENEDIAIEP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A890", Offset = "0x6C99290", VA = "0x186C9A890")]
	[MBAOJIDJINM]
	public static JobHandle JEDJPMLPDAD(this EntityCommandBufferSystem AJFJJDLJIAL, EntityCommandBuffer NKIBOMOJOPA, NativeArray<Entity> NLHOBFOIDFG, ComponentTypes HMIBAPIDOKL, [Optional] JobHandle HGENEDIAIEP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JOCILKBKDPL
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0A80", Offset = "0x2DDF480", VA = "0x182DE0A80")]
	[MBAOJIDJINM]
	public static JobHandle LNFOCFBLDCB<T>(this EntityCommandBufferSystem AJFJJDLJIAL, EntityCommandBuffer NKIBOMOJOPA, EntityQuery AKDNJKBOAJE, T IPHMAHBENGI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MEMDIHGCLFI
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9B210", Offset = "0x6C99C10", VA = "0x186C9B210")]
	[MBAOJIDJINM]
	public static JobHandle LJEIKGFFPNA(this EntityCommandBufferSystem AJFJJDLJIAL, NativeList<Entity> NLHOBFOIDFG, [Optional] JobHandle HGENEDIAIEP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9B110", Offset = "0x6C99B10", VA = "0x186C9B110")]
	[MBAOJIDJINM]
	public static JobHandle LJEIKGFFPNA(this EntityCommandBufferSystem AJFJJDLJIAL, NativeArrayAsync<Entity> NLHOBFOIDFG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BKDNDPHJJCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JGIHOCCJMDE
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC8A0", Offset = "0x2DBB2A0", VA = "0x182DBC8A0")]
	[MBAOJIDJINM]
	public static JobHandle IDNLDCOIPON<T>(this EntityCommandBufferSystem AJFJJDLJIAL, NativeArray<Entity> NLHOBFOIDFG, NativeArray<T> LNCKNHNHHDF, JobHandle HGENEDIAIEP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NFGFLNPONKO
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED65B0", Offset = "0x2ED4FB0", VA = "0x182ED65B0")]
	[MBAOJIDJINM]
	public static JobHandle KNDPGGALHGI<T>(this EntityCommandBufferSystem AJFJJDLJIAL, NativeArray<Entity> NLHOBFOIDFG, T IPHMAHBENGI, [Optional] JobHandle HGENEDIAIEP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2ED64D0", Offset = "0x2ED4ED0", VA = "0x182ED64D0")]
	[MBAOJIDJINM]
	public static JobHandle KNDPGGALHGI<T>(this EntityCommandBufferSystem AJFJJDLJIAL, EntityCommandBuffer NKIBOMOJOPA, NativeArray<Entity> NLHOBFOIDFG, T IPHMAHBENGI, [Optional] JobHandle HGENEDIAIEP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KCIHKBEBMAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class MDMBAMCOIPN
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C460", Offset = "0x2E6AE60", VA = "0x182E6C460")]
	public static NativeArray<T> OEMILEKHFKL<T>(this NativeList<Entity> NLDHJDINPDB, EntityManager JONCEOFPEBL, Allocator MPFEIGMBFCP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E6BEC0", Offset = "0x2E6A8C0", VA = "0x182E6BEC0")]
	public static NativeArray<T> OEMILEKHFKL<T>(this NativeArray<Entity> NLDHJDINPDB, EntityManager JONCEOFPEBL, Allocator MPFEIGMBFCP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AF30", Offset = "0x6C99930", VA = "0x186C9AF30")]
	public static NativeArray<Entity> MGJNNCCMOOP(this NativeArray<Entity> NLDHJDINPDB, EntityManager JONCEOFPEBL, ComponentType OHFAPJOJCKG, Allocator MPFEIGMBFCP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2E6BDE0", Offset = "0x2E6A7E0", VA = "0x182E6BDE0")]
	public static NativeArray<T> FLKGCEBAGFA<T>(this NativeArray<Entity> NLDHJDINPDB, EntityManager JONCEOFPEBL, Allocator MPFEIGMBFCP = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class EDJHIOAGCMG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct GIADBOGBLDA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct COOHGHIECCC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public GIADBOGBLDA<TFrom> EEBGELKKKEJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> GOHCMHMPDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct ENFAFKENJAN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct FJBDABCCKAL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ENFAFKENJAN<TFrom> EEBGELKKKEJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> GOHCMHMPDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct KBJHGPJJMNO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct GKJDKBEGBBM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public KBJHGPJJMNO<TFrom> EEBGELKKKEJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> GOHCMHMPDHB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HFBDMLKCGED
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class NMGLNKFMHCG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct KKDMNJMNKPK : OMCCCCPHIDG<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> PMPNLBILMLD;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C9AF20", Offset = "0x6C99920", VA = "0x186C9AF20")]
		[BurstCompatible]
		public Entity IHPBGCKJIPF([In] Entity IPHMAHBENGI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C9AF20", Offset = "0x6C99920", VA = "0x186C9AF20", Slot = "4")]
		private Entity HMHHNBACCCP([In] Entity IPHMAHBENGI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PIOLGBFNHKA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct FKPDLJDMONJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> PAGENMKPAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> GOHCMHMPDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DEPOFPOIBOL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> PAGENMKPAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> GOHCMHMPDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GOEHPMCFMBJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> PAGENMKPAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> GOHCMHMPDHB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FLOFBGBKKIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GMLHFGBPKNF
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct JPCKENLLJAF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> GOHCMHMPDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct GANEOMOECJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> GOHCMHMPDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct FMPJLHLJDJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> GOHCMHMPDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct PINOBIJAEFG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator MPFEIGMBFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> GOHCMHMPDHB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class HBLCMLLFDKP
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class HABIBDKCBLD
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D76D60", Offset = "0x2D75760", VA = "0x182D76D60")]
	public static NativeList<Entity> PAOLDBJHDAP<T>(this NativeArray<Entity> BOOFLHPDJOP, EntityManager JONCEOFPEBL, Allocator MPFEIGMBFCP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class AMCAEHNNALH
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FJFJKCAACAH
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct IEFNLKIAPDG<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> FEMJEOMOEIN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
		public IEFNLKIAPDG(NativeArray<TSrc> FEMJEOMOEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public IFFPNPEIJEO<TSrc, TValue> LHAHDMIDDJN<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(IFFPNPEIJEO<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct IFFPNPEIJEO<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> FEMJEOMOEIN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
		public IFFPNPEIJEO(NativeArray<TSrc> FEMJEOMOEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public ILNPMPMAFIH<TSrc, TValue, TSelector> IHBEDFNBLPK<TSelector>() where TSelector : struct, OMCCCCPHIDG<TSrc, TValue>
		{
			return default(ILNPMPMAFIH<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct ILNPMPMAFIH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OMCCCCPHIDG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> FEMJEOMOEIN;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
		public ILNPMPMAFIH(NativeArray<TSrc> FEMJEOMOEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x40A8350", Offset = "0x40A6D50", VA = "0x1840A8350")]
		public OAGCJIDGBKE<TSrc, TValue, TSelector> LFFAHMBCAOM()
		{
			return default(OAGCJIDGBKE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct BHHFOFMHIHH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, OMCCCCPHIDG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> FEMJEOMOEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector LLDMHJINCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int ENMILGHAHOM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x50ADD80", Offset = "0x50AC780", VA = "0x1850ADD80")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int BDIPFIAMOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x913F90", Offset = "0x912990", VA = "0x180913F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NBHPLECAMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x213C400", Offset = "0x213AE00", VA = "0x18213C400")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x50ADE50", Offset = "0x50AC850", VA = "0x1850ADE50")]
		public BHHFOFMHIHH(NativeArray<TSrc> FEMJEOMOEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x50ADC70", Offset = "0x50AC670", VA = "0x1850ADC70")]
		public bool AMKJJPKKBEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x50ADC80", Offset = "0x50AC680", VA = "0x1850ADC80")]
		private TSrc BCNLOINKNAD(int ELMEOKPKOPN)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x50ADDC0", Offset = "0x50AC7C0", VA = "0x1850ADDC0")]
		private TValue LJJPKBMCCKM()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct OAGCJIDGBKE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OMCCCCPHIDG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private BHHFOFMHIHH<TSrc, TValue, TSelector> BJLCJBDKLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue BDFALCKKMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int BHLKMIGNPBH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LFJLIGLJDEF GPAFIHAMNDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x48D3560", Offset = "0x48D1F60", VA = "0x1848D3560")]
			get
			{
				return default(LFJLIGLJDEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue GEHLLHGNLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, LFJLIGLJDEF range) EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x48D3490", Offset = "0x48D1E90", VA = "0x1848D3490")]
			get
			{
				return default((TValue, LFJLIGLJDEF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x48D35A0", Offset = "0x48D1FA0", VA = "0x1848D35A0")]
		public OAGCJIDGBKE(NativeArray<TSrc> FEMJEOMOEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCC2D70", Offset = "0xCC1770", VA = "0x180CC2D70")]
		public OAGCJIDGBKE<TSrc, TValue, TSelector> PBHEMGCNMMA()
		{
			return default(OAGCJIDGBKE<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x48D3310", Offset = "0x48D1D10", VA = "0x1848D3310")]
		public bool AMKJJPKKBEO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2D54490", Offset = "0x2D52E90", VA = "0x182D54490")]
	public static IEFNLKIAPDG<T> ELPGGJGFHOB<T>(this NativeList<T> GLCCIANLCJC) where T : struct
	{
		return default(IEFNLKIAPDG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
	public static IEFNLKIAPDG<T> ELPGGJGFHOB<T>(this NativeArray<T> FEMJEOMOEIN) where T : struct
	{
		return default(IEFNLKIAPDG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class BKLJNCNEBHA
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct HMBBOKLIAJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly FEMJEOMOEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int BHLKMIGNPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int GAMILOIBIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T BDFALCKKMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T BFPBJCHFCBI;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LFJLIGLJDEF GPAFIHAMNDH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3FCAC60", Offset = "0x3FC9660", VA = "0x183FCAC60")]
			get
			{
				return default(LFJLIGLJDEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T GEHLLHGNLKA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3A9F2F0", Offset = "0x3A9DCF0", VA = "0x183A9F2F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, LFJLIGLJDEF) EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3FCAB90", Offset = "0x3FC9590", VA = "0x183FCAB90")]
			get
			{
				return default((T, LFJLIGLJDEF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3FCACB0", Offset = "0x3FC96B0", VA = "0x183FCACB0")]
		public HMBBOKLIAJG(NativeArray<T> FEMJEOMOEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3FCAC70", Offset = "0x3FC9670", VA = "0x183FCAC70")]
		public HMBBOKLIAJG<T> PBHEMGCNMMA()
		{
			return default(HMBBOKLIAJG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA910", Offset = "0x3FC9310", VA = "0x183FCA910")]
		public bool AMKJJPKKBEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2C057D0", Offset = "0x2C041D0", VA = "0x182C057D0")]
		public KMLIMBDCOCP<T, TComparer> ABLGKOCEFHC<TComparer>([Optional] TComparer BHMKBMFCFIP) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KMLIMBDCOCP<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KMLIMBDCOCP<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly FEMJEOMOEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int BHLKMIGNPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int GAMILOIBIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T BDFALCKKMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T BFPBJCHFCBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer BHMKBMFCFIP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LFJLIGLJDEF GPAFIHAMNDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3FCAC60", Offset = "0x3FC9660", VA = "0x183FCAC60")]
			get
			{
				return default(LFJLIGLJDEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T GEHLLHGNLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3A9F2F0", Offset = "0x3A9DCF0", VA = "0x183A9F2F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x43E4430", Offset = "0x43E2E30", VA = "0x1843E4430")]
		public KMLIMBDCOCP(NativeArray<T>.ReadOnly FEMJEOMOEIN, TComparer BHMKBMFCFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x43E4280", Offset = "0x43E2C80", VA = "0x1843E4280")]
		public bool AMKJJPKKBEO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF32D0", Offset = "0x2AF1CD0", VA = "0x182AF32D0")]
	public static HMBBOKLIAJG<T> LFFAHMBCAOM<T>(this NativeArray<T> FEMJEOMOEIN) where T : struct
	{
		return default(HMBBOKLIAJG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface ILBONPPLOML
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class GMMDHBCFJFF
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct EHFPPIGHPBP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class DBILMBPDCHH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public EHFPPIGHPBP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3E3AD10", Offset = "0x3E39710", VA = "0x183E3AD10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public DBILMBPDCHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5A71650", Offset = "0x5A70050", VA = "0x185A71650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5A71820", Offset = "0x5A70220", VA = "0x185A71820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> MOKNEAEOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream ECOBFOEFDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream LJEFFDGBEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf LJHMHPGNKEJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A17BA0", Offset = "0x3A165A0", VA = "0x183A17BA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3A17BE0", Offset = "0x3A165E0", VA = "0x183A17BE0", Slot = "4")]
	[IteratorStateMachine(typeof(EHFPPIGHPBP<>.DBILMBPDCHH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3A17CE0", Offset = "0x3A166E0", VA = "0x183A17CE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IOIFLJLAPLJ<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] FJOBMDHPMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf LJHMHPGNKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream ECOBFOEFDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream BNJLONNGHKA;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x40D12A0", Offset = "0x40CFCA0", VA = "0x1840D12A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct CCEFFPPAECO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream ECOBFOEFDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream LJEFFDGBEKO;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A650", Offset = "0x6C99050", VA = "0x186C9A650", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DJOFBNNEGHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] FJOBMDHPMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream ECOBFOEFDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream BNJLONNGHKA;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A720", Offset = "0x6C99120", VA = "0x186C9A720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LHGGMNALOJG
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class PKJMHNMJJIK
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum MFFFDFOKDDL
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class EJLEMOFCFDK
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MDNKJAHJAPB
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MDNKJAHJAPB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
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
