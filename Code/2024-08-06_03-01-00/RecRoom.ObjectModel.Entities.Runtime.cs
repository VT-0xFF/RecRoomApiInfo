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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AA1550", Offset = "0x6A9FB50", VA = "0x186AA1550")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OHHKPGIMGNG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BIMBBAPHHOL LFELKNAKNIH
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
public interface KIOHHDGAPMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKMLPCJLHED(Entity PEMPNCNIDJF, object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBLELHGJCEK(Entity PEMPNCNIDJF, object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLDNMPNLNAJ(Entity PEMPNCNIDJF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KDLBNLGIDPH<TComponentData, TValue> : HOIDKDPIKNC<TValue>, IDisposable where TComponentData : struct, OHHKPGIMGNG
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class MBDAFLCGIFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> MNNCEMFBNNK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int NCPJPJDHEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x359ECF0", Offset = "0x359D2F0", VA = "0x18359ECF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x44C96B0", Offset = "0x44C7CB0", VA = "0x1844C96B0")]
		public bool NAIDEBAHFNB([Out] TValue FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x44C94C0", Offset = "0x44C7AC0", VA = "0x1844C94C0")]
		public void AGMNBECNIJC(object PNPIGCGKNPI, TValue FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44C97C0", Offset = "0x44C7DC0", VA = "0x1844C97C0")]
		public bool PJEMHMBEIPM(object PNPIGCGKNPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x44C95B0", Offset = "0x44C7BB0", VA = "0x1844C95B0")]
		public int LDAKPMBGKGF(object PNPIGCGKNPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x44C9880", Offset = "0x44C7E80", VA = "0x1844C9880")]
		public MBDAFLCGIFF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<MBDAFLCGIFF> AJOCGJFHNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LDPKHHFLEIH<BIMBBAPHHOL, MBDAFLCGIFF> NAHLLCBEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager ELCBIAGEOKB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x41D12B0", Offset = "0x41CF8B0", VA = "0x1841D12B0")]
	public KDLBNLGIDPH(EntityManager ELCBIAGEOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x41D0C00", Offset = "0x41CF200", VA = "0x1841D0C00", Slot = "4")]
	public void IKMLPCJLHED(Entity PEMPNCNIDJF, object PNPIGCGKNPI, TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41D0D90", Offset = "0x41CF390", VA = "0x1841D0D90", Slot = "5")]
	public bool KBLELHGJCEK(Entity PEMPNCNIDJF, object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x41D1190", Offset = "0x41CF790", VA = "0x1841D1190", Slot = "6")]
	public bool NAIDEBAHFNB(Entity PEMPNCNIDJF, [Out] TValue FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x41D0A10", Offset = "0x41CF010", VA = "0x1841D0A10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x41D0A30", Offset = "0x41CF030", VA = "0x1841D0A30")]
	private void HGINBMJOOJN(MBDAFLCGIFF ADMKMPPMKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x41D10D0", Offset = "0x41CF6D0", VA = "0x1841D10D0")]
	private bool MNMHPCKCBOC(Entity PEMPNCNIDJF, [Out] BIMBBAPHHOL NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x41D0B00", Offset = "0x41CF100", VA = "0x1841D0B00")]
	private void HKEHHOJHFPD(Entity PEMPNCNIDJF, BIMBBAPHHOL NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x41D09F0", Offset = "0x41CEFF0", VA = "0x1841D09F0")]
	private bool BBNCKHLBBEL(BIMBBAPHHOL NNBIOLHDGAK, [Out] MBDAFLCGIFF ADMKMPPMKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x41D0FA0", Offset = "0x41CF5A0", VA = "0x1841D0FA0")]
	private MBDAFLCGIFF LLBDODAPAHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOIDKDPIKNC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKMLPCJLHED(Entity PEMPNCNIDJF, object PNPIGCGKNPI, TValue FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KBLELHGJCEK(Entity PEMPNCNIDJF, object PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NAIDEBAHFNB(Entity PEMPNCNIDJF, [Out] TValue FEBGGALLBNN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BIMBBAPHHOL : BGKDNKIMIFC, IEquatable<BIMBBAPHHOL>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly BIMBBAPHHOL GPPCJKAAKNA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int JPOHIBGABMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC10", Offset = "0xB5D210", VA = "0x180B5EC10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int DDMNNMLGMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2587140", Offset = "0x2585740", VA = "0x182587140", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D948D0", Offset = "0x5D92ED0", VA = "0x185D948D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1490", Offset = "0x6A9FA90", VA = "0x186AA1490", Slot = "8")]
	public bool Equals(BIMBBAPHHOL OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AA14E0", Offset = "0x6A9FAE0", VA = "0x186AA14E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EIOILCPMHAM<THasTokensTag> : KIOHHDGAPMJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, BIMBBAPHHOL> LAOKBNOCJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> AJOCGJFHNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LDPKHHFLEIH<BIMBBAPHHOL, HashSet<object>> NAHLLCBEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager ELCBIAGEOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem FOKHIFGHIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KKDPLHMNJCD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37F6760", Offset = "0x37F4D60", VA = "0x1837F6760")]
	public EIOILCPMHAM(EntityManager ELCBIAGEOKB, EntityCommandBufferSystem FOKHIFGHIEP, CHNLCLDOCNE HBCIKBPIKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37F4E70", Offset = "0x37F3470", VA = "0x1837F4E70", Slot = "4")]
	public bool IKMLPCJLHED(Entity PEMPNCNIDJF, object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37F55F0", Offset = "0x37F3BF0", VA = "0x1837F55F0", Slot = "5")]
	public bool KBLELHGJCEK(Entity PEMPNCNIDJF, object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37F5C30", Offset = "0x37F4230", VA = "0x1837F5C30", Slot = "6")]
	public bool LLDNMPNLNAJ(Entity PEMPNCNIDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37F5F20", Offset = "0x37F4520", VA = "0x1837F5F20", Slot = "8")]
	public bool LLDNMPNLNAJ(BIMBBAPHHOL NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37F36F0", Offset = "0x37F1CF0", VA = "0x1837F36F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37F3A30", Offset = "0x37F2030", VA = "0x1837F3A30")]
	private void HGINBMJOOJN(HashSet<object> ADMKMPPMKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37F5FE0", Offset = "0x37F45E0", VA = "0x1837F5FE0")]
	private bool MNMHPCKCBOC(Entity PEMPNCNIDJF, [Out] BIMBBAPHHOL NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37F3E70", Offset = "0x37F2470", VA = "0x1837F3E70")]
	private bool HMCIHLPMBKE(Entity PEMPNCNIDJF, [Out] BIMBBAPHHOL NNBIOLHDGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x37F42D0", Offset = "0x37F28D0", VA = "0x1837F42D0")]
	private void HPMLFFAPPCA(Entity PEMPNCNIDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37F4820", Offset = "0x37F2E20", VA = "0x1837F4820")]
	private void IKEMDOLHFNB(Entity PEMPNCNIDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37F3850", Offset = "0x37F1E50", VA = "0x1837F3850")]
	private void EBJNFMNECFN(Entity PEMPNCNIDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37F3BF0", Offset = "0x37F21F0", VA = "0x1837F3BF0")]
	private void HKEHHOJHFPD(Entity PEMPNCNIDJF, BIMBBAPHHOL NNBIOLHDGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x37F4A50", Offset = "0x37F3050", VA = "0x1837F4A50")]
	private bool IKHJGBKNKCE(BIMBBAPHHOL NNBIOLHDGAK, [Out] HashSet<object> ADMKMPPMKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x37F5AF0", Offset = "0x37F40F0", VA = "0x1837F5AF0")]
	private HashSet<object> LLBDODAPAHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PELKMEIMBBJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MEEHEGJJBEK : EOHAPJNJGPM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1930", Offset = "0x6A9FF30", VA = "0x186AA1930")]
	public float LNLJBKAEELM([In] float3 FEBGGALLBNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1930", Offset = "0x6A9FF30", VA = "0x186AA1930", Slot = "4")]
	private float PEEEPCLHIDM([In] float3 FEBGGALLBNN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BLOLJJMMLBP : EOHAPJNJGPM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1530", Offset = "0x6A9FB30", VA = "0x186AA1530")]
	public float LNLJBKAEELM([In] float3 FEBGGALLBNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1530", Offset = "0x6A9FB30", VA = "0x186AA1530", Slot = "4")]
	private float PEEEPCLHIDM([In] float3 FEBGGALLBNN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FMGNLFHEPDN : EOHAPJNJGPM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DED3B0", Offset = "0x1DEB9B0", VA = "0x181DED3B0")]
	public float LNLJBKAEELM([In] float3 FEBGGALLBNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DED3B0", Offset = "0x1DEB9B0", VA = "0x181DED3B0", Slot = "4")]
	private float PEEEPCLHIDM([In] float3 FEBGGALLBNN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JBCGPAABPME : EOHAPJNJGPM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1685050", Offset = "0x1683650", VA = "0x181685050")]
	public int LNLJBKAEELM([In] int3 FEBGGALLBNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1685050", Offset = "0x1683650", VA = "0x181685050", Slot = "4")]
	private int PAEMFIHCFGB([In] int3 FEBGGALLBNN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CKLBOJDGLCE : EOHAPJNJGPM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1540", Offset = "0x6A9FB40", VA = "0x186AA1540")]
	public int LNLJBKAEELM([In] int3 FEBGGALLBNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1540", Offset = "0x6A9FB40", VA = "0x186AA1540", Slot = "4")]
	private int PAEMFIHCFGB([In] int3 FEBGGALLBNN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FGPFJNOJGPM : EOHAPJNJGPM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1853AB0", Offset = "0x18520B0", VA = "0x181853AB0")]
	public int LNLJBKAEELM([In] int3 FEBGGALLBNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1853AB0", Offset = "0x18520B0", VA = "0x181853AB0", Slot = "4")]
	private int PAEMFIHCFGB([In] int3 FEBGGALLBNN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OGAKEAFOEKC : APLCPBPAMAE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15B7D00", Offset = "0x15B6300", VA = "0x1815B7D00")]
	public OGAKEAFOEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PLFPELKKOEB : SystemBase, HFJFNNMPFOG
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1DD0", Offset = "0x6AA03D0", VA = "0x186AA1DD0")]
	public JobHandle DONNIFGIKEB(ReadOnlySpan<int> FNMHNANKHCJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B840", Offset = "0x2D19E40", VA = "0x182D1B840")]
	public void NELEBNAIKPF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BEF0", Offset = "0x2D1A4F0", VA = "0x182D1BEF0")]
	public JobHandle NELEBNAIKPF<T>(JobHandle NNBIOLHDGAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1EE0", Offset = "0x6AA04E0", VA = "0x186AA1EE0")]
	public JobHandle NELEBNAIKPF(ReadOnlySpan<int> FNMHNANKHCJ, JobHandle NNBIOLHDGAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B840", Offset = "0x2D19E40", VA = "0x182D1B840")]
	public void LDEJGJGEPAG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B760", Offset = "0x2D19D60", VA = "0x182D1B760")]
	public JobHandle LDEJGJGEPAG<T>(JobHandle NNBIOLHDGAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1E20", Offset = "0x6AA0420", VA = "0x186AA1E20")]
	public ComponentDataFromEntity FMCFFKCPKBC(int GFMLMIBOOKA, bool DEAFLLGNHNI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1F50", Offset = "0x6AA0550", VA = "0x186AA1F50")]
	public EntityExistenceLookupByEntity PJKPJELHBEI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1F70", Offset = "0x6AA0570", VA = "0x186AA1F70", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x15B7D00", Offset = "0x15B6300", VA = "0x1815B7D00")]
	protected PLFPELKKOEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class FCMCLPOPPOG : PLFPELKKOEB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1570", Offset = "0x6A9FB70", VA = "0x186AA1570", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x15B7D00", Offset = "0x15B6300", VA = "0x1815B7D00")]
	protected FCMCLPOPPOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LOGGFBCAJJK
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class BPNPADBDEOB : EntityCommandBufferSystem, HFJFNNMPFOG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x15B7D00", Offset = "0x15B6300", VA = "0x1815B7D00")]
	protected BPNPADBDEOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EOHAPJNJGPM<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LNLJBKAEELM([In] TFrom FEBGGALLBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MAALCICEJDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BAHFPHMOOCA(T FEBGGALLBNN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct ANOEFHGHDOE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> MAOCOLMCNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer DLPNELFJALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes IIPCCMJOMOG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1050", Offset = "0x6A9F650", VA = "0x186AA1050", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct PAJNDAMHPCI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> MAOCOLMCNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer DLPNELFJALN;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1CF0", Offset = "0x6AA02F0", VA = "0x186AA1CF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct FJHBEJHJNNM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> MAOCOLMCNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer DLPNELFJALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType MDALJHACMID;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA15A0", Offset = "0x6A9FBA0", VA = "0x186AA15A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct BEMFEOFGNNN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> MAOCOLMCNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> JHLEMCFOEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer DLPNELFJALN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB6E0", Offset = "0x4EE9CE0", VA = "0x184EEB6E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct EDJEPHDDBFL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> MAOCOLMCNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> EGCOBBLGNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer DLPNELFJALN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct DCOCAHMNPIK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> MAOCOLMCNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T FEBGGALLBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer DLPNELFJALN;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5862230", Offset = "0x5860830", VA = "0x185862230", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct FBANGDDFAFA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EOHAPJNJGPM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> HOBFGHBMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> EJOLLAIHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap IJDJHMGAIOM;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct PNBOFJMDALB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity AGFEDNNJNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> HOBFGHBMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> EJOLLAIHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int DKMKJOFFIDG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1F80", Offset = "0x6AA0580", VA = "0x186AA1F80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct NENLNOEGFID<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LNAALMMFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> HOBFGHBMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> FBAGHJFGJEG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct AGGPBFHKEDJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EOHAPJNJGPM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> DMFKKJJHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> EJOLLAIHMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap IJDJHMGAIOM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct ALOGAKFNLNE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HGKPFKEKFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> LLDCODCNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> HKJNHABAPKD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct FFLIALENJJM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HGKPFKEKFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> LLDCODCNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> HKJNHABAPKD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A200", Offset = "0x3B88800", VA = "0x183B8A200", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct AMNPBDCHCGA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> HOBFGHBMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> FBAGHJFGJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> HJEKOOBJNGH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D83A10", Offset = "0x3D82010", VA = "0x183D83A10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct FFPGAPFKGEF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : EOHAPJNJGPM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> HOBFGHBMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> FBAGHJFGJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> HJEKOOBJNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap IJDJHMGAIOM;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct CIOICMFLFIH<T, TPredicate> : IJob where T : struct where TPredicate : struct, MAALCICEJDJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> HOBFGHBMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> MDIDKNMBCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> LJFJLINFKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate IJDJHMGAIOM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct ACLBGFPJJPD<T, TPredicate> : IJob where T : struct where TPredicate : struct, MAALCICEJDJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> HOBFGHBMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> FBAGHJFGJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate IJDJHMGAIOM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct BILHDGMKMJP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity HGKPFKEKFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> LLDCODCNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> JIKEKDEGACI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1400", Offset = "0x6A9FA00", VA = "0x186AA1400", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct GBFLPLOFHIM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity HGKPFKEKFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> LLDCODCNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> JIKEKDEGACI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1800", Offset = "0x6A9FE00", VA = "0x186AA1800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ECDLBBDJDNB
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BHHIINAAKBJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28FADF0", Offset = "0x28F93F0", VA = "0x1828FADF0")]
	public static bool GNFHICCNDHA<T>(this NativeArray<Entity> LLDCODCNFJN, EntityManager ELCBIAGEOKB, Allocator JKHEKCINHDP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JGHLOGKOFOA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JLNOAFDNOPA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public JLNOAFDNOPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AFPBGGKEOFH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public AFPBGGKEOFH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> ELPBCEAEFLA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1890", Offset = "0x6A9FE90", VA = "0x186AA1890")]
	public JGHLOGKOFOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BPKEFAIHCEB
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MHNNJLBPLLH
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct AMPEJMALKAO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct ILAHGDJBBEN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal AMPEJMALKAO<TFrom> LPFOFJIMHOE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> BOIMHPNGCKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct JNIFFLOAJJG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct CPJHMMPPDDK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal JNIFFLOAJJG<TFrom> LPFOFJIMHOE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> BOIMHPNGCKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct DLJBMNFMLJJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct AIPFFPJHBNA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal DLJBMNFMLJJ<TFrom> LPFOFJIMHOE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> BOIMHPNGCKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct CJJMLJEJLDA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct CFCENCIBNKA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal CJJMLJEJLDA<TFrom> LPFOFJIMHOE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> BOIMHPNGCKI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class APNGGAIIGFK
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class INBNKOLPONF
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA510", Offset = "0x2BA8B10", VA = "0x182BAA510")]
	public static NativeList<T> IEPHDLMICBB<T>(this NativeArray<T> JKDFBJJJONC, Allocator JKHEKCINHDP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LGOBANHCKAM
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BFOHBLOAGHB
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x28F9B80", Offset = "0x28F8180", VA = "0x1828F9B80")]
	[DFNBALACGPP]
	public static JobHandle FMILDCDLNLH<T>(this EntityCommandBufferSystem FOKHIFGHIEP, NativeArrayAsync<Entity> MAOCOLMCNED, NativeArrayAsync<T> JHLEMCFOEMF, [Optional] JobHandle OJDONPHINHP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28F9D00", Offset = "0x28F8300", VA = "0x1828F9D00")]
	[DFNBALACGPP]
	public static JobHandle FMILDCDLNLH<T>(this EntityCommandBufferSystem FOKHIFGHIEP, NativeArrayAsync<Entity> MAOCOLMCNED)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28F9A50", Offset = "0x28F8050", VA = "0x1828F9A50")]
	[DFNBALACGPP]
	public static JobHandle FMILDCDLNLH<T>(this EntityCommandBufferSystem FOKHIFGHIEP, NativeArray<Entity> MAOCOLMCNED, [Optional] JobHandle OJDONPHINHP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1290", Offset = "0x6A9F890", VA = "0x186AA1290")]
	[DFNBALACGPP]
	public static JobHandle FMILDCDLNLH(this EntityCommandBufferSystem FOKHIFGHIEP, NativeArray<Entity> MAOCOLMCNED, ComponentTypes IIPCCMJOMOG, [Optional] JobHandle OJDONPHINHP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1140", Offset = "0x6A9F740", VA = "0x186AA1140")]
	[DFNBALACGPP]
	public static JobHandle FMILDCDLNLH(this EntityCommandBufferSystem FOKHIFGHIEP, EntityCommandBuffer DLPNELFJALN, NativeArray<Entity> MAOCOLMCNED, ComponentTypes IIPCCMJOMOG, [Optional] JobHandle OJDONPHINHP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LDFLGPLLONG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C11510", Offset = "0x2C0FB10", VA = "0x182C11510")]
	[DFNBALACGPP]
	public static JobHandle HHMBJMIIOCC<T>(this EntityCommandBufferSystem FOKHIFGHIEP, EntityCommandBuffer DLPNELFJALN, EntityQuery DEJOOEPLDIN, T FEBGGALLBNN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NKGEMKBMPIP
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1A40", Offset = "0x6AA0040", VA = "0x186AA1A40")]
	[DFNBALACGPP]
	public static JobHandle ABNMEPILLKN(this EntityCommandBufferSystem FOKHIFGHIEP, NativeList<Entity> MAOCOLMCNED, [Optional] JobHandle OJDONPHINHP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1940", Offset = "0x6A9FF40", VA = "0x186AA1940")]
	[DFNBALACGPP]
	public static JobHandle ABNMEPILLKN(this EntityCommandBufferSystem FOKHIFGHIEP, NativeArrayAsync<Entity> MAOCOLMCNED)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DCGOCFPOOGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KNEPDILBLPD
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E5E0", Offset = "0x2C0CBE0", VA = "0x182C0E5E0")]
	[DFNBALACGPP]
	public static JobHandle JEIPHGGPOMN<T>(this EntityCommandBufferSystem FOKHIFGHIEP, NativeArray<Entity> MAOCOLMCNED, NativeArray<T> JHLEMCFOEMF, JobHandle OJDONPHINHP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PPDEEBNKDJJ
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2D20970", Offset = "0x2D1EF70", VA = "0x182D20970")]
	[DFNBALACGPP]
	public static JobHandle CJKGPDKNFLI<T>(this EntityCommandBufferSystem FOKHIFGHIEP, NativeArray<Entity> MAOCOLMCNED, T FEBGGALLBNN, [Optional] JobHandle OJDONPHINHP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2D20890", Offset = "0x2D1EE90", VA = "0x182D20890")]
	[DFNBALACGPP]
	public static JobHandle CJKGPDKNFLI<T>(this EntityCommandBufferSystem FOKHIFGHIEP, EntityCommandBuffer DLPNELFJALN, NativeArray<Entity> MAOCOLMCNED, T FEBGGALLBNN, [Optional] JobHandle OJDONPHINHP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LBFGNDGPECN
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FNPCAKALPBO
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D7D0", Offset = "0x2B5BDD0", VA = "0x182B5D7D0")]
	public static NativeArray<T> AINBOFPOMGL<T>(this NativeList<Entity> JKDFBJJJONC, EntityManager ELCBIAGEOKB, Allocator JKHEKCINHDP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D230", Offset = "0x2B5B830", VA = "0x182B5D230")]
	public static NativeArray<T> AINBOFPOMGL<T>(this NativeArray<Entity> JKDFBJJJONC, EntityManager ELCBIAGEOKB, Allocator JKHEKCINHDP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1620", Offset = "0x6A9FC20", VA = "0x186AA1620")]
	public static NativeArray<Entity> JFICILPBLMN(this NativeArray<Entity> JKDFBJJJONC, EntityManager ELCBIAGEOKB, ComponentType MDALJHACMID, Allocator JKHEKCINHDP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D150", Offset = "0x2B5B750", VA = "0x182B5D150")]
	public static NativeArray<T> AHEFBPAFMGA<T>(this NativeArray<Entity> JKDFBJJJONC, EntityManager ELCBIAGEOKB, Allocator JKHEKCINHDP = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class CJKKLFDBPMF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct IBHJAMAPMBN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct IHGIIEHMIPN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public IBHJAMAPMBN<TFrom> BOIMHPNGCKI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> HOBFGHBMDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NNGPGCHIIAG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct PCPJEBIPIAD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public NNGPGCHIIAG<TFrom> BOIMHPNGCKI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> HOBFGHBMDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct HNFDKNPEGDP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct AHNKBDANGEE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HNFDKNPEGDP<TFrom> BOIMHPNGCKI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> HOBFGHBMDPO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MDMFIGELPGO
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class JFIDEOBPMFF
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct JGONJEGJDJN : EOHAPJNJGPM<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> LIOCGOJOLKG;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1920", Offset = "0x6A9FF20", VA = "0x186AA1920")]
		[BurstCompatible]
		public Entity LNLJBKAEELM([In] Entity FEBGGALLBNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1920", Offset = "0x6A9FF20", VA = "0x186AA1920", Slot = "4")]
		private Entity BEFPGONOAJM([In] Entity FEBGGALLBNN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OOPMOPNNIIM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct PDAEAHFLAHJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> MDIDKNMBCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> HOBFGHBMDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct GODBGGPAOAG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> MDIDKNMBCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> HOBFGHBMDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct OCPEHCKHPDO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> MDIDKNMBCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> HOBFGHBMDPO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GIPADBIJKEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class INNCGNGBENK
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct ILEEMFDGJJL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> HOBFGHBMDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct OLEHOJDKDIB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> HOBFGHBMDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct LLDEGFNJPDE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> HOBFGHBMDPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct OFBHEHHFOJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator JKHEKCINHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> HOBFGHBMDPO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class OKEDJBKGLMH
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FNCENEIFKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B5C960", Offset = "0x2B5AF60", VA = "0x182B5C960")]
	public static NativeList<Entity> DGPLJCLCJMP<T>(this NativeArray<Entity> LLDCODCNFJN, EntityManager ELCBIAGEOKB, Allocator JKHEKCINHDP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DNBLDGOKOBO
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NINPHMNBLCA
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct JBBMMMCIMNI<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> NMHOKLPDKBK;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
		public JBBMMMCIMNI(NativeArray<TSrc> NMHOKLPDKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public FGECGPMCNDL<TSrc, TValue> DGDLMFMAEBK<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(FGECGPMCNDL<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct FGECGPMCNDL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> NMHOKLPDKBK;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
		public FGECGPMCNDL(NativeArray<TSrc> NMHOKLPDKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public OGBHAFDDIMC<TSrc, TValue, TSelector> NNKMOFEEPHI<TSelector>() where TSelector : struct, EOHAPJNJGPM<TSrc, TValue>
		{
			return default(OGBHAFDDIMC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct OGBHAFDDIMC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EOHAPJNJGPM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> NMHOKLPDKBK;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
		public OGBHAFDDIMC(NativeArray<TSrc> NMHOKLPDKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x46D8C80", Offset = "0x46D7280", VA = "0x1846D8C80")]
		public LKHCBKEHJAG<TSrc, TValue, TSelector> MCMHPDINELC()
		{
			return default(LKHCBKEHJAG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct OIMDBACEOLC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, EOHAPJNJGPM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> NMHOKLPDKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector ANHAPOCAGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int EBDMAJMOJLN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x46E6EE0", Offset = "0x46E54E0", VA = "0x1846E6EE0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JPOHIBGABMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9B1650", Offset = "0x9AFC50", VA = "0x1809B1650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BANKGEHECOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x46E70C0", Offset = "0x46E56C0", VA = "0x1846E70C0")]
		public OIMDBACEOLC(NativeArray<TSrc> NMHOKLPDKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x46E70B0", Offset = "0x46E56B0", VA = "0x1846E70B0")]
		public bool LEKDILHCHKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x46E6FB0", Offset = "0x46E55B0", VA = "0x1846E6FB0")]
		private TSrc JGBKBKKICGD(int HBONDKDDBNB)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x46E6F20", Offset = "0x46E5520", VA = "0x1846E6F20")]
		private TValue CJHBGEOCPFL()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct LKHCBKEHJAG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EOHAPJNJGPM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private OIMDBACEOLC<TSrc, TValue, TSelector> MBPJCHKAHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue CEAONINCHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int CHEJIFFIDLB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HHILMKFNIKP BDDNGBMCPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x42DCD70", Offset = "0x42DB370", VA = "0x1842DCD70")]
			get
			{
				return default(HHILMKFNIKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue AIAMENKKHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, HHILMKFNIKP range) LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x42DCC90", Offset = "0x42DB290", VA = "0x1842DCC90")]
			get
			{
				return default((TValue, HHILMKFNIKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x42DCF30", Offset = "0x42DB530", VA = "0x1842DCF30")]
		public LKHCBKEHJAG(NativeArray<TSrc> NMHOKLPDKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2C20", Offset = "0x3CB1220", VA = "0x183CB2C20")]
		public LKHCBKEHJAG<TSrc, TValue, TSelector> CPHKKMADKBM()
		{
			return default(LKHCBKEHJAG<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x42DCDB0", Offset = "0x42DB3B0", VA = "0x1842DCDB0")]
		public bool LEKDILHCHKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2CC02D0", Offset = "0x2CBE8D0", VA = "0x182CC02D0")]
	public static JBBMMMCIMNI<T> ICJFNEDIMGO<T>(this NativeList<T> MNNCEMFBNNK) where T : struct
	{
		return default(JBBMMMCIMNI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
	public static JBBMMMCIMNI<T> ICJFNEDIMGO<T>(this NativeArray<T> NMHOKLPDKBK) where T : struct
	{
		return default(JBBMMMCIMNI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class KHHPNPPNNPB
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct GBDNCIADHDH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly NMHOKLPDKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int CHEJIFFIDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int OCKLDCFKCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T CEAONINCHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T BDPGGPDAINK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HHILMKFNIKP BDDNGBMCPJK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3C07680", Offset = "0x3C05C80", VA = "0x183C07680")]
			get
			{
				return default(HHILMKFNIKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T AIAMENKKHKM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x37DE0A0", Offset = "0x37DC6A0", VA = "0x1837DE0A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, HHILMKFNIKP) LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2B50", Offset = "0x3CB1150", VA = "0x183CB2B50")]
			get
			{
				return default((T, HHILMKFNIKP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3050", Offset = "0x3CB1650", VA = "0x183CB3050")]
		public GBDNCIADHDH(NativeArray<T> NMHOKLPDKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2C40", Offset = "0x3CB1240", VA = "0x183CB2C40")]
		public GBDNCIADHDH<T> CPHKKMADKBM()
		{
			return default(GBDNCIADHDH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2C80", Offset = "0x3CB1280", VA = "0x183CB2C80")]
		public bool LEKDILHCHKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F740", Offset = "0x2A8DD40", VA = "0x182A8F740")]
		public FPENIKFKAJJ<T, TComparer> ELAOHJJOMIN<TComparer>([Optional] TComparer BLNIAGECEBF) where TComparer : struct, IEqualityComparer<T>
		{
			return default(FPENIKFKAJJ<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FPENIKFKAJJ<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly NMHOKLPDKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int CHEJIFFIDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int OCKLDCFKCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T CEAONINCHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T BDPGGPDAINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer BLNIAGECEBF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HHILMKFNIKP BDDNGBMCPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3C07680", Offset = "0x3C05C80", VA = "0x183C07680")]
			get
			{
				return default(HHILMKFNIKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T AIAMENKKHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x37DE0A0", Offset = "0x37DC6A0", VA = "0x1837DE0A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3C07880", Offset = "0x3C05E80", VA = "0x183C07880")]
		public FPENIKFKAJJ(NativeArray<T>.ReadOnly NMHOKLPDKBK, TComparer BLNIAGECEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3C07690", Offset = "0x3C05C90", VA = "0x183C07690")]
		public bool LEKDILHCHKC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B680", Offset = "0x2C09C80", VA = "0x182C0B680")]
	public static GBDNCIADHDH<T> MCMHPDINELC<T>(this NativeArray<T> NMHOKLPDKBK) where T : struct
	{
		return default(GBDNCIADHDH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NNFPGOMCEAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class ABPMHBFHEIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct MLCDJNMBJAK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ODHIELBFDJN : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MLCDJNMBJAK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xD35590", Offset = "0xD33B90", VA = "0x180D35590", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C38D00", Offset = "0x3C37300", VA = "0x183C38D00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public ODHIELBFDJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x46D6480", Offset = "0x46D4A80", VA = "0x1846D6480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x46D6660", Offset = "0x46D4C60", VA = "0x1846D6660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> JFOLLHALOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream LIBFPOKLOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream MFBDJMDMOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf NBMKCMDEKCJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4506310", Offset = "0x4504910", VA = "0x184506310", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4506350", Offset = "0x4504950", VA = "0x184506350", Slot = "4")]
	[IteratorStateMachine(typeof(MLCDJNMBJAK<>.ODHIELBFDJN))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4506450", Offset = "0x4504A50", VA = "0x184506450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IADPJDJNGBP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] KGHDKIBNGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf NBMKCMDEKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream LIBFPOKLOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream LCDDKEBKCCP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE450", Offset = "0x3DFCA50", VA = "0x183DFE450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PFCKKEAEFBI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream LIBFPOKLOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream MFBDJMDMOIJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1D90", Offset = "0x6AA0390", VA = "0x186AA1D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct NPOFAFKFKGE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] KGHDKIBNGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream LIBFPOKLOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream LCDDKEBKCCP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1BD0", Offset = "0x6AA01D0", VA = "0x186AA1BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class LFINNLDMBFN
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class KIJLMDFPOCF
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum MEDFFAMOLGK
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
internal static class GGHDHNGONCI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MIABPGLKCNF
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MIABPGLKCNF()
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
