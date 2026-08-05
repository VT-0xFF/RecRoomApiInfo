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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A68210", Offset = "0x6A67210", VA = "0x186A68210")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NCCHEKFGKAN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DPMICKHFIFL EGJLHJCJDFF
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
public interface HKCCDJFGFPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBLDLIDCFMI(Entity BOENFECPGGB, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFHEIKMMIHL(Entity BOENFECPGGB, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IDBOCGMNJDA(Entity BOENFECPGGB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IMDEJABOIML<TComponentData, TValue> : EAAANFBANEO<TValue>, IDisposable where TComponentData : struct, NCCHEKFGKAN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class GOMEHKELJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> IEKJOJONGFC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int DHMBIHOHONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x35E3D10", Offset = "0x35E2D10", VA = "0x1835E3D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D98290", Offset = "0x3D97290", VA = "0x183D98290")]
		public bool NIHEBPLMNLD([Out] TValue JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D981B0", Offset = "0x3D971B0", VA = "0x183D981B0")]
		public void GKAGDNHKNII(object DJIBMMAIGPE, TValue JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D98100", Offset = "0x3D97100", VA = "0x183D98100")]
		public bool FFDBNDOHLIO(object DJIBMMAIGPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D98010", Offset = "0x3D97010", VA = "0x183D98010")]
		public int CBDGBGLBFJH(object DJIBMMAIGPE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D98390", Offset = "0x3D97390", VA = "0x183D98390")]
		public GOMEHKELJAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<GOMEHKELJAE> CCINJMBGICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CLNLOHJEKJN<DPMICKHFIFL, GOMEHKELJAE> GPECKLDDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager OOHOEBAONBK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F487F0", Offset = "0x3F477F0", VA = "0x183F487F0")]
	public IMDEJABOIML(EntityManager OOHOEBAONBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F480A0", Offset = "0x3F470A0", VA = "0x183F480A0", Slot = "4")]
	public void EBLDLIDCFMI(Entity BOENFECPGGB, object DJIBMMAIGPE, TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F48210", Offset = "0x3F47210", VA = "0x183F48210", Slot = "5")]
	public bool EFHEIKMMIHL(Entity BOENFECPGGB, object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F486D0", Offset = "0x3F476D0", VA = "0x183F486D0", Slot = "6")]
	public bool NIHEBPLMNLD(Entity BOENFECPGGB, [Out] TValue JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F48080", Offset = "0x3F47080", VA = "0x183F48080", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F48400", Offset = "0x3F47400", VA = "0x183F48400")]
	private void ELONNFOJJCF(GOMEHKELJAE OPBABEALOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3F47FC0", Offset = "0x3F46FC0", VA = "0x183F47FC0")]
	private bool AJHMODKECBF(Entity BOENFECPGGB, [Out] DPMICKHFIFL EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F484C0", Offset = "0x3F474C0", VA = "0x183F484C0")]
	private void GAIOEPCENEO(Entity BOENFECPGGB, DPMICKHFIFL EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F487D0", Offset = "0x3F477D0", VA = "0x183F487D0")]
	private bool PFPFLGBKEPM(DPMICKHFIFL EFPCBKOLOGB, [Out] GOMEHKELJAE OPBABEALOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F485B0", Offset = "0x3F475B0", VA = "0x183F485B0")]
	private GOMEHKELJAE JJICGHNAHOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EAAANFBANEO<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBLDLIDCFMI(Entity BOENFECPGGB, object DJIBMMAIGPE, TValue JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFHEIKMMIHL(Entity BOENFECPGGB, object DJIBMMAIGPE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NIHEBPLMNLD(Entity BOENFECPGGB, [Out] TValue JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DPMICKHFIFL : GONNAKCGBMI, IEquatable<DPMICKHFIFL>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly DPMICKHFIFL JDOOJIEMHEC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int LCNJIFOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xB57280", Offset = "0xB56280", VA = "0x180B57280", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BPAJHBABCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x25ADC50", Offset = "0x25ACC50", VA = "0x1825ADC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D41F50", Offset = "0x5D40F50", VA = "0x185D41F50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A68070", Offset = "0x6A67070", VA = "0x186A68070", Slot = "8")]
	public bool Equals(DPMICKHFIFL ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A680C0", Offset = "0x6A670C0", VA = "0x186A680C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ANOJPBNNINE<THasTokensTag> : HKCCDJFGFPJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, DPMICKHFIFL> DGCIFBBHPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> CCINJMBGICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CLNLOHJEKJN<DPMICKHFIFL, HashSet<object>> GPECKLDDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager OOHOEBAONBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem ONIONNELLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OJOGLGJEHMD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E830", Offset = "0x3E3D830", VA = "0x183E3E830")]
	public ANOJPBNNINE(EntityManager OOHOEBAONBK, EntityCommandBufferSystem ONIONNELLKD, PHLKHBEJKKB HHKEJCHBIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CE50", Offset = "0x3E3BE50", VA = "0x183E3CE50", Slot = "4")]
	public bool EBLDLIDCFMI(Entity BOENFECPGGB, object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D1F0", Offset = "0x3E3C1F0", VA = "0x183E3D1F0", Slot = "5")]
	public bool EFHEIKMMIHL(Entity BOENFECPGGB, object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DA90", Offset = "0x3E3CA90", VA = "0x183E3DA90", Slot = "6")]
	public bool IDBOCGMNJDA(Entity BOENFECPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DB30", Offset = "0x3E3CB30", VA = "0x183E3DB30", Slot = "8")]
	public bool IDBOCGMNJDA(DPMICKHFIFL EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E3C9F0", Offset = "0x3E3B9F0", VA = "0x183E3C9F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D600", Offset = "0x3E3C600", VA = "0x183E3D600")]
	private void ELONNFOJJCF(HashSet<object> OPBABEALOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E3C660", Offset = "0x3E3B660", VA = "0x183E3C660")]
	private bool AJHMODKECBF(Entity BOENFECPGGB, [Out] DPMICKHFIFL EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E470", Offset = "0x3E3D470", VA = "0x183E3E470")]
	private bool PKIBGKNNHAE(Entity BOENFECPGGB, [Out] DPMICKHFIFL EFPCBKOLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DE70", Offset = "0x3E3CE70", VA = "0x183E3DE70")]
	private void KLOLPPNCIJH(Entity BOENFECPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E3E170", Offset = "0x3E3D170", VA = "0x183E3E170")]
	private void LEMBCLJGIJI(Entity BOENFECPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D800", Offset = "0x3E3C800", VA = "0x183E3D800")]
	private void FIHCEJKNHPK(Entity BOENFECPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D900", Offset = "0x3E3C900", VA = "0x183E3D900")]
	private void GAIOEPCENEO(Entity BOENFECPGGB, DPMICKHFIFL EFPCBKOLOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E3C930", Offset = "0x3E3B930", VA = "0x183E3C930")]
	private bool CMFMAOAHFDP(DPMICKHFIFL EFPCBKOLOGB, [Out] HashSet<object> OPBABEALOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E3DDD0", Offset = "0x3E3CDD0", VA = "0x183E3DDD0")]
	private HashSet<object> JJICGHNAHOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MDCCMLFEOCN
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KGMGLOCGMCI : ICAIHKOKNDB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A68740", Offset = "0x6A67740", VA = "0x186A68740")]
	public float ICMKFJOKGGH([In] float3 JJCEIJMGOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A68740", Offset = "0x6A67740", VA = "0x186A68740", Slot = "4")]
	private float GAPBOIOBLNG([In] float3 JJCEIJMGOAB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct EFJMPOKKEIG : ICAIHKOKNDB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A68110", Offset = "0x6A67110", VA = "0x186A68110")]
	public float ICMKFJOKGGH([In] float3 JJCEIJMGOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A68110", Offset = "0x6A67110", VA = "0x186A68110", Slot = "4")]
	private float GAPBOIOBLNG([In] float3 JJCEIJMGOAB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LLIIMFJMKEM : ICAIHKOKNDB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EC70", Offset = "0x1E0DC70", VA = "0x181E0EC70")]
	public float ICMKFJOKGGH([In] float3 JJCEIJMGOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EC70", Offset = "0x1E0DC70", VA = "0x181E0EC70", Slot = "4")]
	private float GAPBOIOBLNG([In] float3 JJCEIJMGOAB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AHBEOAGNKLB : ICAIHKOKNDB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1696830", Offset = "0x1695830", VA = "0x181696830")]
	public int ICMKFJOKGGH([In] int3 JJCEIJMGOAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1696830", Offset = "0x1695830", VA = "0x181696830", Slot = "4")]
	private int GFCKAFLIBLI([In] int3 JJCEIJMGOAB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LJNFHLOAJIN : ICAIHKOKNDB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A68780", Offset = "0x6A67780", VA = "0x186A68780")]
	public int ICMKFJOKGGH([In] int3 JJCEIJMGOAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A68780", Offset = "0x6A67780", VA = "0x186A68780", Slot = "4")]
	private int GFCKAFLIBLI([In] int3 JJCEIJMGOAB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EGANBNOFPKF : ICAIHKOKNDB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1866BF0", Offset = "0x1865BF0", VA = "0x181866BF0")]
	public int ICMKFJOKGGH([In] int3 JJCEIJMGOAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1866BF0", Offset = "0x1865BF0", VA = "0x181866BF0", Slot = "4")]
	private int GFCKAFLIBLI([In] int3 JJCEIJMGOAB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PCLMFLGMDFP : DFFPGBKEHKH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
	public PCLMFLGMDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PEELIPDHBOH : SystemBase, JCNNJMIDBIK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A689E0", Offset = "0x6A679E0", VA = "0x186A689E0")]
	public JobHandle FJOIEPKCJNN(ReadOnlySpan<int> CLIIMNNKGIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EF20", Offset = "0x2D6DF20", VA = "0x182D6EF20")]
	public void GENNBDGMJFF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EC80", Offset = "0x2D6DC80", VA = "0x182D6EC80")]
	public JobHandle GENNBDGMJFF<T>(JobHandle EFPCBKOLOGB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A68A30", Offset = "0x6A67A30", VA = "0x186A68A30")]
	public JobHandle GENNBDGMJFF(ReadOnlySpan<int> CLIIMNNKGIL, JobHandle EFPCBKOLOGB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EF20", Offset = "0x2D6DF20", VA = "0x182D6EF20")]
	public void OOEHIHDCBNH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D6FBF0", Offset = "0x2D6EBF0", VA = "0x182D6FBF0")]
	public JobHandle OOEHIHDCBNH<T>(JobHandle EFPCBKOLOGB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A68AA0", Offset = "0x6A67AA0", VA = "0x186A68AA0")]
	public ComponentDataFromEntity HPKGFEMECKN(int NMKJGMDJHGN, bool OGAMNNKBJIP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A689C0", Offset = "0x6A679C0", VA = "0x186A689C0")]
	public EntityExistenceLookupByEntity DBLLGCJEGFK()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A68B60", Offset = "0x6A67B60", VA = "0x186A68B60", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
	protected PEELIPDHBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class LBLOGCELFOB : PEELIPDHBOH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A68750", Offset = "0x6A67750", VA = "0x186A68750", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
	protected LBLOGCELFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DCBLFJPKCEO
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class EFADKBKGOFJ : EntityCommandBufferSystem, JCNNJMIDBIK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
	protected EFADKBKGOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ICAIHKOKNDB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo ICMKFJOKGGH([In] TFrom JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KHOCHOMHJMH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDMJFLCKODD(T JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct ELBCDGKADJH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> LCKAMOJEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer DGABDCJHCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes PIEEDPNGFGE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A68120", Offset = "0x6A67120", VA = "0x186A68120", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct IPIMADLDCKI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> LCKAMOJEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer DGABDCJHCNC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A686A0", Offset = "0x6A676A0", VA = "0x186A686A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct MLHKJCAKHFP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> LCKAMOJEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer DGABDCJHCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType OLHHFOGDMMI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A68820", Offset = "0x6A67820", VA = "0x186A68820", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct MIBCOIDAALB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> LCKAMOJEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> AHGAPHMJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer DGABDCJHCNC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x44E9880", Offset = "0x44E8880", VA = "0x1844E9880", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct ODFCMMGKEMM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> LCKAMOJEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> ADLAOOMHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer DGABDCJHCNC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct APHCHEAIKNN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> LCKAMOJEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T JJCEIJMGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer DGABDCJHCNC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3F5D0F0", Offset = "0x3F5C0F0", VA = "0x183F5D0F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct AEKHFAJCAEI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ICAIHKOKNDB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> NCOIGFCJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> CDMDKGGJCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap JFOAFIPDIOA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct ILFPPMOIJAB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity IKKDCFOGKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> NCOIGFCJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> CDMDKGGJCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int HDAEPECJDCD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A685A0", Offset = "0x6A675A0", VA = "0x186A685A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct PGEGCEKALKA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CJMIEIIPLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> NCOIGFCJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> HOLNIDAMELG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct MJIADADPGFJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, ICAIHKOKNDB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> NLOKGAMPJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> CDMDKGGJCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap JFOAFIPDIOA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct BBHJDLOPLHE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IMJBEGNNOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> PCBPJHPCCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> NBEGADOJKFK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct GAFEKCGLIOB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IMJBEGNNOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PCBPJHPCCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> NBEGADOJKFK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3D32CE0", Offset = "0x3D31CE0", VA = "0x183D32CE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct GCDFIMHGHHB<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> NCOIGFCJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> HOLNIDAMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> DMJJLFJCIPP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D36BB0", Offset = "0x3D35BB0", VA = "0x183D36BB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct ODMNAMMHIGO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : ICAIHKOKNDB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> NCOIGFCJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> HOLNIDAMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> DMJJLFJCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap JFOAFIPDIOA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct AOBPEPIEAJL<T, TPredicate> : IJob where T : struct where TPredicate : struct, KHOCHOMHJMH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> NCOIGFCJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> NGFKIHPMCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> INDEHKDCPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate JFOAFIPDIOA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct FILACHOENMN<T, TPredicate> : IJob where T : struct where TPredicate : struct, KHOCHOMHJMH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> NCOIGFCJEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> HOLNIDAMELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate JFOAFIPDIOA;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct LNLKIMLNEKL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity IMJBEGNNOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> PCBPJHPCCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> JBOGILIPIJE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A68790", Offset = "0x6A67790", VA = "0x186A68790", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct ACPAAAGBJFG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity IMJBEGNNOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PCBPJHPCCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> JBOGILIPIJE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A67B40", Offset = "0x6A66B40", VA = "0x186A67B40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EPPABOACFAD
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HLFBELFPLOO
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7D80", Offset = "0x2BC6D80", VA = "0x182BC7D80")]
	public static bool KKAEEBOGNJO<T>(this NativeArray<Entity> PCBPJHPCCIC, EntityManager OOHOEBAONBK, Allocator OOMMBGGEBLM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IEDOJBAMADN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JHECHMCGFGL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public JHECHMCGFGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GAHAJKHIINC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public GAHAJKHIINC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> CLBJFEIFBDI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A68500", Offset = "0x6A67500", VA = "0x186A68500")]
	public IEDOJBAMADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class GEHNGBGBHNM
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KNIJKDCLOLK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct POMOFMGCJKA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct HEPJFEFNEMD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal POMOFMGCJKA<TFrom> EMOKCJBMKOL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> ABGFGEMBNMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct GOCIAFCHBNO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct LADPBFGBKJM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal GOCIAFCHBNO<TFrom> EMOKCJBMKOL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> ABGFGEMBNMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct KLFEFPENKFC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PIGACAMEPML<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal KLFEFPENKFC<TFrom> EMOKCJBMKOL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> ABGFGEMBNMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct MMNDBGGKEOI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct JCIMHLENLOK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal MMNDBGGKEOI<TFrom> EMOKCJBMKOL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> ABGFGEMBNMN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PMJIGBABBPF
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class ICJGLLHPNKG
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4C70", Offset = "0x2BD3C70", VA = "0x182BD4C70")]
	public static NativeList<T> OKKOOPOAGAB<T>(this NativeArray<T> NJFAGOGEHPH, Allocator OOMMBGGEBLM = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MINPPGHAJMM
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DCMJENCMFAL
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x29FDC20", Offset = "0x29FCC20", VA = "0x1829FDC20")]
	[PCDPKHAKGMK]
	public static JobHandle KIIGNGFJPBB<T>(this EntityCommandBufferSystem ONIONNELLKD, NativeArrayAsync<Entity> LCKAMOJEGOK, NativeArrayAsync<T> AHGAPHMJDIB, [Optional] JobHandle DJEEMNAOGNG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29FDEC0", Offset = "0x29FCEC0", VA = "0x1829FDEC0")]
	[PCDPKHAKGMK]
	public static JobHandle KIIGNGFJPBB<T>(this EntityCommandBufferSystem ONIONNELLKD, NativeArrayAsync<Entity> LCKAMOJEGOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x29FDD90", Offset = "0x29FCD90", VA = "0x1829FDD90")]
	[PCDPKHAKGMK]
	public static JobHandle KIIGNGFJPBB<T>(this EntityCommandBufferSystem ONIONNELLKD, NativeArray<Entity> LCKAMOJEGOK, [Optional] JobHandle DJEEMNAOGNG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A67BD0", Offset = "0x6A66BD0", VA = "0x186A67BD0")]
	[PCDPKHAKGMK]
	public static JobHandle KIIGNGFJPBB(this EntityCommandBufferSystem ONIONNELLKD, NativeArray<Entity> LCKAMOJEGOK, ComponentTypes PIEEDPNGFGE, [Optional] JobHandle DJEEMNAOGNG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A67D40", Offset = "0x6A66D40", VA = "0x186A67D40")]
	[PCDPKHAKGMK]
	public static JobHandle KIIGNGFJPBB(this EntityCommandBufferSystem ONIONNELLKD, EntityCommandBuffer DGABDCJHCNC, NativeArray<Entity> LCKAMOJEGOK, ComponentTypes PIEEDPNGFGE, [Optional] JobHandle DJEEMNAOGNG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GMCLKCJAOGL
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAF60", Offset = "0x2BB9F60", VA = "0x182BBAF60")]
	[PCDPKHAKGMK]
	public static JobHandle BAMMOLPGIIN<T>(this EntityCommandBufferSystem ONIONNELLKD, EntityCommandBuffer DGABDCJHCNC, EntityQuery NADKLOBBDMK, T JJCEIJMGOAB) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class HIHIJFFBFLJ
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A68270", Offset = "0x6A67270", VA = "0x186A68270")]
	[PCDPKHAKGMK]
	public static JobHandle LBHOHDJCCBF(this EntityCommandBufferSystem ONIONNELLKD, NativeList<Entity> LCKAMOJEGOK, [Optional] JobHandle DJEEMNAOGNG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A68400", Offset = "0x6A67400", VA = "0x186A68400")]
	[PCDPKHAKGMK]
	public static JobHandle LBHOHDJCCBF(this EntityCommandBufferSystem ONIONNELLKD, NativeArrayAsync<Entity> LCKAMOJEGOK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BOBMHJPDJGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LFLFPJENMHN
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C5C0", Offset = "0x2C7B5C0", VA = "0x182C7C5C0")]
	[PCDPKHAKGMK]
	public static JobHandle ECBCAEFLJNB<T>(this EntityCommandBufferSystem ONIONNELLKD, NativeArray<Entity> LCKAMOJEGOK, NativeArray<T> AHGAPHMJDIB, JobHandle DJEEMNAOGNG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GALKFGEEIPP
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4900", Offset = "0x2BB3900", VA = "0x182BB4900")]
	[PCDPKHAKGMK]
	public static JobHandle NNGGALHDFBM<T>(this EntityCommandBufferSystem ONIONNELLKD, NativeArray<Entity> LCKAMOJEGOK, T JJCEIJMGOAB, [Optional] JobHandle DJEEMNAOGNG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4820", Offset = "0x2BB3820", VA = "0x182BB4820")]
	[PCDPKHAKGMK]
	public static JobHandle NNGGALHDFBM<T>(this EntityCommandBufferSystem ONIONNELLKD, EntityCommandBuffer DGABDCJHCNC, NativeArray<Entity> LCKAMOJEGOK, T JJCEIJMGOAB, [Optional] JobHandle DJEEMNAOGNG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LEAIOFICCJO
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DLMLMJMLKAG
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2A16E30", Offset = "0x2A15E30", VA = "0x182A16E30")]
	public static NativeArray<T> MONEOPCDAPJ<T>(this NativeList<Entity> NJFAGOGEHPH, EntityManager OOHOEBAONBK, Allocator OOMMBGGEBLM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A16890", Offset = "0x2A15890", VA = "0x182A16890")]
	public static NativeArray<T> MONEOPCDAPJ<T>(this NativeArray<Entity> NJFAGOGEHPH, EntityManager OOHOEBAONBK, Allocator OOMMBGGEBLM = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A67E90", Offset = "0x6A66E90", VA = "0x186A67E90")]
	public static NativeArray<Entity> COIJHPBGOOM(this NativeArray<Entity> NJFAGOGEHPH, EntityManager OOHOEBAONBK, ComponentType OLHHFOGDMMI, Allocator OOMMBGGEBLM = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A167B0", Offset = "0x2A157B0", VA = "0x182A167B0")]
	public static NativeArray<T> ANCKFEEHIKH<T>(this NativeArray<Entity> NJFAGOGEHPH, EntityManager OOHOEBAONBK, Allocator OOMMBGGEBLM = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HMCCMHDKFDP
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct JOMEDJLFCEK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct HENGAACODGJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public JOMEDJLFCEK<TFrom> ABGFGEMBNMN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> NCOIGFCJEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GGHCBMIENFP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct EJJLBLABDEF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public GGHCBMIENFP<TFrom> ABGFGEMBNMN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> NCOIGFCJEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct FOCFHBCKIDC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct AGDJANNFKBA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public FOCFHBCKIDC<TFrom> ABGFGEMBNMN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> NCOIGFCJEGH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GGMOCIKFILG
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FIIIMAJEEBC
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct IGCEFJHPIGF : ICAIHKOKNDB<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KHNCKFDDHGI;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A68590", Offset = "0x6A67590", VA = "0x186A68590")]
		[BurstCompatible]
		public Entity ICMKFJOKGGH([In] Entity JJCEIJMGOAB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6A68590", Offset = "0x6A67590", VA = "0x186A68590", Slot = "4")]
		private Entity DDAGIDOBOBM([In] Entity JJCEIJMGOAB)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class JKMHJDGOBOK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct NDIMILMHOEK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> NGFKIHPMCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> NCOIGFCJEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct GBHPICLDLLN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> NGFKIHPMCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> NCOIGFCJEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct JGIAELPNCAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> NGFKIHPMCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> NCOIGFCJEGH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HDPNLJFEKBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CNNDHKEDGMC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct NFMAOGPJGFL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> NCOIGFCJEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct DLJINPOPHNK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> NCOIGFCJEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct OJBCJNKONGN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> NCOIGFCJEGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct LKEFEOKJKCF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator OOMMBGGEBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> NCOIGFCJEGH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class NKJONPAMCNB
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class KAPMMACABPG
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FC90", Offset = "0x2C5EC90", VA = "0x182C5FC90")]
	public static NativeList<Entity> OBAPAPJHJCF<T>(this NativeArray<Entity> PCBPJHPCCIC, EntityManager OOHOEBAONBK, Allocator OOMMBGGEBLM = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ABGIKEKLKDE
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HIOOKIAHHDI
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct IBIMIFNMDCL<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> IKONNGGNFPH;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
		public IBIMIFNMDCL(NativeArray<TSrc> IKONNGGNFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public PGKPJMKGKHJ<TSrc, TValue> NHHFKHABAHJ<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(PGKPJMKGKHJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct PGKPJMKGKHJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> IKONNGGNFPH;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
		public PGKPJMKGKHJ(NativeArray<TSrc> IKONNGGNFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public CGCIEFBGGJI<TSrc, TValue, TSelector> BKMNMPOFJBO<TSelector>() where TSelector : struct, ICAIHKOKNDB<TSrc, TValue>
		{
			return default(CGCIEFBGGJI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct CGCIEFBGGJI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ICAIHKOKNDB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> IKONNGGNFPH;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
		public CGCIEFBGGJI(NativeArray<TSrc> IKONNGGNFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x527B750", Offset = "0x527A750", VA = "0x18527B750")]
		public GKLBCNAJEDJ<TSrc, TValue, TSelector> NHDLAJEMNEH()
		{
			return default(GKLBCNAJEDJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct GGAFBLJEKOE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, ICAIHKOKNDB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> IKONNGGNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector JJKIJKJILIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int HCALFJOJKJO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3D5F040", Offset = "0x3D5E040", VA = "0x183D5F040")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LCNJIFOOGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9A2800", Offset = "0x9A1800", VA = "0x1809A2800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NLCDAFOIEDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2032730", Offset = "0x2031730", VA = "0x182032730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F120", Offset = "0x3D5E120", VA = "0x183D5F120")]
		public GGAFBLJEKOE(NativeArray<TSrc> IKONNGGNFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F080", Offset = "0x3D5E080", VA = "0x183D5F080")]
		public bool KNNBHONEFAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EF50", Offset = "0x3D5DF50", VA = "0x183D5EF50")]
		private TSrc AIMBABCDMJH(int GGJGGMKAJPM)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F090", Offset = "0x3D5E090", VA = "0x183D5F090")]
		private TValue NNPDJMDCIIJ()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct GKLBCNAJEDJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, ICAIHKOKNDB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private GGAFBLJEKOE<TSrc, TValue, TSelector> FONGOFJDDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue PKDHAMINPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int EFHNBALPFBO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HPLFBCPLACJ KJCCBFPMOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3D7EC60", Offset = "0x3D7DC60", VA = "0x183D7EC60")]
			get
			{
				return default(HPLFBCPLACJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue ACJBLOCAANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, HPLFBCPLACJ range) NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3D7E9F0", Offset = "0x3D7D9F0", VA = "0x183D7E9F0")]
			get
			{
				return default((TValue, HPLFBCPLACJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D7ECA0", Offset = "0x3D7DCA0", VA = "0x183D7ECA0")]
		public GKLBCNAJEDJ(NativeArray<TSrc> IKONNGGNFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3D7EAC0", Offset = "0x3D7DAC0", VA = "0x183D7EAC0")]
		public GKLBCNAJEDJ<TSrc, TValue, TSelector> EAJKDCOBAGF()
		{
			return default(GKLBCNAJEDJ<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7EAE0", Offset = "0x3D7DAE0", VA = "0x183D7EAE0")]
		public bool KNNBHONEFAI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5D90", Offset = "0x2BC4D90", VA = "0x182BC5D90")]
	public static IBIMIFNMDCL<T> HICCLCMDCLA<T>(this NativeList<T> IEKJOJONGFC) where T : struct
	{
		return default(IBIMIFNMDCL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
	public static IBIMIFNMDCL<T> HICCLCMDCLA<T>(this NativeArray<T> IKONNGGNFPH) where T : struct
	{
		return default(IBIMIFNMDCL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class ADNCFNFKICN
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct JFLJMIEFCJD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly IKONNGGNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int EFHNBALPFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int IGFDPEBDNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T PKDHAMINPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T EHKBBFIEIGB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HPLFBCPLACJ KJCCBFPMOOH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x410C520", Offset = "0x410B520", VA = "0x18410C520")]
			get
			{
				return default(HPLFBCPLACJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T ACJBLOCAANE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3908420", Offset = "0x3907420", VA = "0x183908420")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, HPLFBCPLACJ) NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x410BFC0", Offset = "0x410AFC0", VA = "0x18410BFC0")]
			get
			{
				return default((T, HPLFBCPLACJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x410C5A0", Offset = "0x410B5A0", VA = "0x18410C5A0")]
		public JFLJMIEFCJD(NativeArray<T> IKONNGGNFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x410C130", Offset = "0x410B130", VA = "0x18410C130")]
		public JFLJMIEFCJD<T> EAJKDCOBAGF()
		{
			return default(JFLJMIEFCJD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x410C340", Offset = "0x410B340", VA = "0x18410C340")]
		public bool KNNBHONEFAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7EA0", Offset = "0x2AE6EA0", VA = "0x182AE7EA0")]
		public BOHNADIPPBH<T, TComparer> AIMDNCAHHDL<TComparer>([Optional] TComparer DCHEEMKBOAG) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BOHNADIPPBH<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct BOHNADIPPBH<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly IKONNGGNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int EFHNBALPFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int IGFDPEBDNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T PKDHAMINPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T EHKBBFIEIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer DCHEEMKBOAG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HPLFBCPLACJ KJCCBFPMOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x410C520", Offset = "0x410B520", VA = "0x18410C520")]
			get
			{
				return default(HPLFBCPLACJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T ACJBLOCAANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3908420", Offset = "0x3907420", VA = "0x183908420")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7410", Offset = "0x4EA6410", VA = "0x184EA7410")]
		public BOHNADIPPBH(NativeArray<T>.ReadOnly IKONNGGNFPH, TComparer DCHEEMKBOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7230", Offset = "0x4EA6230", VA = "0x184EA7230")]
		public bool KNNBHONEFAI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3266340", Offset = "0x3265340", VA = "0x183266340")]
	public static JFLJMIEFCJD<T> NHDLAJEMNEH<T>(this NativeArray<T> IKONNGGNFPH) where T : struct
	{
		return default(JFLJMIEFCJD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface JGENODPKNNE
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class IHLBJBDGLDI
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct HNMGLHBHJDI<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IDECIJJMHCJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public HNMGLHBHJDI<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xD382A0", Offset = "0xD372A0", VA = "0x180D382A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C00250", Offset = "0x3BFF250", VA = "0x183C00250", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public IDECIJJMHCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9510", Offset = "0x3EB8510", VA = "0x183EB9510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3EB96E0", Offset = "0x3EB86E0", VA = "0x183EB96E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> JDIFIBPGADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream BDHIFNLNDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream PBLGAANICJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf KIICPOGENEP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC500", Offset = "0x3DFB500", VA = "0x183DFC500", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC540", Offset = "0x3DFB540", VA = "0x183DFC540", Slot = "4")]
	[IteratorStateMachine(typeof(HNMGLHBHJDI<>.IDECIJJMHCJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC640", Offset = "0x3DFB640", VA = "0x183DFC640", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct CMFKPKMPAJC<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] EPDCHNAKJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf KIICPOGENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream BDHIFNLNDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream JDFDKOJGPOH;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x55360B0", Offset = "0x55350B0", VA = "0x1855360B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct GCJNLJLLJCA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream BDHIFNLNDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream PBLGAANICJL;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A68230", Offset = "0x6A67230", VA = "0x186A68230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct OFFMMDMMEJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] EPDCHNAKJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream BDHIFNLNDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream JDFDKOJGPOH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A688A0", Offset = "0x6A678A0", VA = "0x186A688A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NBJMMMAPMFE
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class KEFPPJIPIHN
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum GCEHLLGIONJ
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
internal static class POELLJCKEHB
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HCDGHKBPKAH
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HCDGHKBPKAH()
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
