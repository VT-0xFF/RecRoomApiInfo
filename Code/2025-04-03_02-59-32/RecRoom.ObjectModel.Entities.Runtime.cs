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
using RecRoom;
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79F6BB0", Offset = "0x79F5FB0", VA = "0x1879F6BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79F6880", Offset = "0x79F5C80", VA = "0x1879F6880")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PBKGDJOHGIO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BJFJLFKBJFP KJMHNECGCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GDIKDPLACOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMCCEANIJAJ(Entity GJIBJHOJMIG, object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHBDNGFBCCD(Entity GJIBJHOJMIG, object HHGPJKKLNIG, [Out] bool PFAAMFNIBIP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEJJCGKCLAI(Entity GJIBJHOJMIG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HBLBOOPHCCA<TComponentData, TValue> : KLAELOJBAPK<TValue>, IDisposable where TComponentData : struct, PBKGDJOHGIO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class PDNIECMPFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> CEFIHBLEFNG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int GMILMIAEFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3E98B50", Offset = "0x3E97F50", VA = "0x183E98B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x52C8A40", Offset = "0x52C7E40", VA = "0x1852C8A40")]
		public bool BKMMMCAANMG([Out] TValue FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x52C8C00", Offset = "0x52C8000", VA = "0x1852C8C00")]
		public void JJBKLNLGAIJ(object HHGPJKKLNIG, TValue FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x52C8B50", Offset = "0x52C7F50", VA = "0x1852C8B50")]
		public bool JEBJOEBLLEI(object HHGPJKKLNIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x52C8CE0", Offset = "0x52C80E0", VA = "0x1852C8CE0")]
		public int NDOEKMMOHNB(object HHGPJKKLNIG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x52C8DC0", Offset = "0x52C81C0", VA = "0x1852C8DC0")]
		public PDNIECMPFCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<PDNIECMPFCI> FDEMBALPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GNANIDDMMPE<BJFJLFKBJFP, PDNIECMPFCI> CCBKAMPMOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager MPNJFPGMBFH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x48C9BA0", Offset = "0x48C8FA0", VA = "0x1848C9BA0")]
	public HBLBOOPHCCA(EntityManager MPNJFPGMBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x48C9450", Offset = "0x48C8850", VA = "0x1848C9450", Slot = "4")]
	public void BMCCEANIJAJ(Entity GJIBJHOJMIG, object HHGPJKKLNIG, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48C99B0", Offset = "0x48C8DB0", VA = "0x1848C99B0", Slot = "5")]
	public bool PHBDNGFBCCD(Entity GJIBJHOJMIG, object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48C9340", Offset = "0x48C8740", VA = "0x1848C9340", Slot = "6")]
	public bool BKMMMCAANMG(Entity GJIBJHOJMIG, [Out] TValue FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x48C95D0", Offset = "0x48C89D0", VA = "0x1848C95D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48C9810", Offset = "0x48C8C10", VA = "0x1848C9810")]
	private void KGEGCECMCLK(PDNIECMPFCI FNPGLBIMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x48C98D0", Offset = "0x48C8CD0", VA = "0x1848C98D0")]
	private bool LLGHBLNNNHD(Entity GJIBJHOJMIG, [Out] BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x48C9710", Offset = "0x48C8B10", VA = "0x1848C9710")]
	private void KEHKINFJOCI(Entity GJIBJHOJMIG, BJFJLFKBJFP GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x48C9990", Offset = "0x48C8D90", VA = "0x1848C9990")]
	private bool NALNCJKMPOF(BJFJLFKBJFP GGBKPDHLOJF, [Out] PDNIECMPFCI FNPGLBIMKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48C95F0", Offset = "0x48C89F0", VA = "0x1848C95F0")]
	private PDNIECMPFCI IAEFPJIIECI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KLAELOJBAPK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMCCEANIJAJ(Entity GJIBJHOJMIG, object HHGPJKKLNIG, TValue FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHBDNGFBCCD(Entity GJIBJHOJMIG, object HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BKMMMCAANMG(Entity GJIBJHOJMIG, [Out] TValue FFOEEMKIKJO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BJFJLFKBJFP : PFGKJOCFDIP, IEquatable<BJFJLFKBJFP>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly BJFJLFKBJFP EFMDICAFKHF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int FBMJOLKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EGOLIAJEBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2CBED00", Offset = "0x2CBE100", VA = "0x182CBED00", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1DE0", Offset = "0x6AE11E0", VA = "0x186AE1DE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x79F5D10", Offset = "0x79F5110", VA = "0x1879F5D10", Slot = "8")]
	public bool Equals(BJFJLFKBJFP KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x79F5D60", Offset = "0x79F5160", VA = "0x1879F5D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ENPHOHFMGBG<THasTokensTag> : GDIKDPLACOP, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, BJFJLFKBJFP> HOOMPHFIPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> FDEMBALPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private GNANIDDMMPE<BJFJLFKBJFP, HashSet<object>> CCBKAMPMOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager MPNJFPGMBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem LGJBMJJMAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x42DECA0", Offset = "0x42DE0A0", VA = "0x1842DECA0")]
	public ENPHOHFMGBG(EntityManager MPNJFPGMBFH, EntityCommandBufferSystem LGJBMJJMAGE, GBHBOJAPDOA FKEJEKIDHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42DC9D0", Offset = "0x42DBDD0", VA = "0x1842DC9D0", Slot = "4")]
	public bool BMCCEANIJAJ(Entity GJIBJHOJMIG, object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42DE8C0", Offset = "0x42DDCC0", VA = "0x1842DE8C0", Slot = "5")]
	public bool PHBDNGFBCCD(Entity GJIBJHOJMIG, object HHGPJKKLNIG, [Out] bool PFAAMFNIBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42DC250", Offset = "0x42DB650", VA = "0x1842DC250", Slot = "6")]
	public bool AEJJCGKCLAI(Entity GJIBJHOJMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42DC1A0", Offset = "0x42DB5A0", VA = "0x1842DC1A0", Slot = "8")]
	public bool AEJJCGKCLAI(BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42DCFA0", Offset = "0x42DC3A0", VA = "0x1842DCFA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42DD9D0", Offset = "0x42DCDD0", VA = "0x1842DD9D0")]
	private void KGEGCECMCLK(HashSet<object> FNPGLBIMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42DDF40", Offset = "0x42DD340", VA = "0x1842DDF40")]
	private bool LLGHBLNNNHD(Entity GJIBJHOJMIG, [Out] BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42DD2E0", Offset = "0x42DC6E0", VA = "0x1842DD2E0")]
	private bool GLFAFPELGHP(Entity GJIBJHOJMIG, [Out] BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42DCEA0", Offset = "0x42DC2A0", VA = "0x1842DCEA0")]
	private void BOGJEOEMMKM(Entity GJIBJHOJMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x42DE0E0", Offset = "0x42DD4E0", VA = "0x1842DE0E0")]
	private void MHLEAJLFIBN(Entity GJIBJHOJMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42DDD00", Offset = "0x42DD100", VA = "0x1842DDD00")]
	private void KMLMHKBIKGG(Entity GJIBJHOJMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42DD880", Offset = "0x42DCC80", VA = "0x1842DD880")]
	private void KEHKINFJOCI(Entity GJIBJHOJMIG, BJFJLFKBJFP GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x42DD4C0", Offset = "0x42DC8C0", VA = "0x1842DD4C0")]
	private bool HCJHEMOHINJ(BJFJLFKBJFP GGBKPDHLOJF, [Out] HashSet<object> FNPGLBIMKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x42DD5C0", Offset = "0x42DC9C0", VA = "0x1842DD5C0")]
	private HashSet<object> IAEFPJIIECI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BLJCHPOIGKP
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IMJGLAKBBMP : NPBDGHGAAGP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x79F6AD0", Offset = "0x79F5ED0", VA = "0x1879F6AD0")]
	public float AHDIBBAIBEF([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x79F6AD0", Offset = "0x79F5ED0", VA = "0x1879F6AD0", Slot = "4")]
	private float JMILGKKIFNB([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AKBJFJAANLL : NPBDGHGAAGP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x79F5CF0", Offset = "0x79F50F0", VA = "0x1879F5CF0")]
	public float AHDIBBAIBEF([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x79F5CF0", Offset = "0x79F50F0", VA = "0x1879F5CF0", Slot = "4")]
	private float JMILGKKIFNB([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HNPMAEGEEBJ : NPBDGHGAAGP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xDB5CB0", Offset = "0xDB50B0", VA = "0x180DB5CB0")]
	public float AHDIBBAIBEF([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xDB5CB0", Offset = "0xDB50B0", VA = "0x180DB5CB0", Slot = "4")]
	private float JMILGKKIFNB([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DIAJJJNMOFI : NPBDGHGAAGP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2049D90", Offset = "0x2049190", VA = "0x182049D90")]
	public int AHDIBBAIBEF([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2049D90", Offset = "0x2049190", VA = "0x182049D90", Slot = "4")]
	private int HIMGKHAHJJE([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PECCAKBDNBA : NPBDGHGAAGP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE45EB0", Offset = "0xE452B0", VA = "0x180E45EB0")]
	public int AHDIBBAIBEF([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xE45EB0", Offset = "0xE452B0", VA = "0x180E45EB0", Slot = "4")]
	private int HIMGKHAHJJE([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EFKPGIBDFCA : NPBDGHGAAGP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xD99C80", Offset = "0xD99080", VA = "0x180D99C80")]
	public int AHDIBBAIBEF([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD99C80", Offset = "0xD99080", VA = "0x180D99C80", Slot = "4")]
	private int HIMGKHAHJJE([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MDPDEMPHEMF : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F41440", Offset = "0x1F40840", VA = "0x181F41440")]
	public MDPDEMPHEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class CPCJJCHJEHO : SystemBase, AONCBJIOGFC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79F6490", Offset = "0x79F5890", VA = "0x1879F6490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33F6380", Offset = "0x33F5780", VA = "0x1833F6380")]
	public void POKNOBPPHDB<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33F6380", Offset = "0x33F5780", VA = "0x1833F6380")]
	public void MBLBBIPGNII<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x79F6440", Offset = "0x79F5840", VA = "0x1879F6440")]
	public JobHandle IPAEPFBKOEB(ReadOnlySpan<int> LJHJOPPPJCA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x33F56C0", Offset = "0x33F4AC0", VA = "0x1833F56C0")]
	public JobHandle CHAHCGBEJKG<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79F6260", Offset = "0x79F5660", VA = "0x1879F6260")]
	public JobHandle CHAHCGBEJKG(ReadOnlySpan<int> LJHJOPPPJCA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x33F5930", Offset = "0x33F4D30", VA = "0x1833F5930")]
	public void EKNJPNMFJCK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x33F5770", Offset = "0x33F4B70", VA = "0x1833F5770")]
	public JobHandle EKNJPNMFJCK<T>(JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79F6310", Offset = "0x79F5710", VA = "0x1879F6310")]
	public JobHandle EKNJPNMFJCK(ReadOnlySpan<int> LJHJOPPPJCA, JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x33F5930", Offset = "0x33F4D30", VA = "0x1833F5930")]
	public void MMFIIHHDOJB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x33F63E0", Offset = "0x33F57E0", VA = "0x1833F63E0")]
	public JobHandle MMFIIHHDOJB<T>(JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x79F64C0", Offset = "0x79F58C0", VA = "0x1879F64C0")]
	public JobHandle MMFIIHHDOJB(Span<int> LJHJOPPPJCA, JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33F6190", Offset = "0x33F5590", VA = "0x1833F6190")]
	public ComponentDataFromEntity EPMOKPDEGDL<T>(bool GPPDNEDPIAM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79F6380", Offset = "0x79F5780", VA = "0x1879F6380")]
	public ComponentDataFromEntity EPMOKPDEGDL(int HIALDCJGAPD, bool GPPDNEDPIAM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x33F60C0", Offset = "0x33F54C0", VA = "0x1833F60C0")]
	public SharedComponentIndexFromEntity<T> EMBDOCEDBCI<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79F62B0", Offset = "0x79F56B0", VA = "0x1879F62B0")]
	[BurstCompatible]
	public ComponentTypeHandle DCPMNLFKMGD(ComponentType MCLKGGFBODE)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79F6530", Offset = "0x79F5930", VA = "0x1879F6530")]
	public EntityExistenceLookupByEntity PIOKBGBMECM()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79F6550", Offset = "0x79F5950", VA = "0x1879F6550", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x33F6260", Offset = "0x33F5660", VA = "0x1833F6260")]
	public bool LLBAODPNPIA<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F41440", Offset = "0x1F40840", VA = "0x181F41440")]
	protected CPCJJCHJEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class GFFBJGAFODC : CPCJJCHJEHO
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79F68A0", Offset = "0x79F5CA0", VA = "0x1879F68A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F41440", Offset = "0x1F40840", VA = "0x181F41440")]
	protected GFFBJGAFODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FCEOAPMPHBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LHHCMOIBFGC : EntityCommandBufferSystem, AONCBJIOGFC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GBHBOJAPDOA GFDFDHMHGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCDA260", Offset = "0xCD9660", VA = "0x180CDA260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x79F6B80", Offset = "0x79F5F80", VA = "0x1879F6B80")]
	public LHHCMOIBFGC(GBHBOJAPDOA DPDKJPMBJOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NPBDGHGAAGP<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo AHDIBBAIBEF([In] TFrom FFOEEMKIKJO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ABMBIENBBDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJAMNHJEFNG(T FFOEEMKIKJO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct HKLHKPAFNND : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer BKMEKKEIMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes BNAPIBHIEGL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79F69E0", Offset = "0x79F5DE0", VA = "0x1879F69E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct JGHFIAKILOC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer BKMEKKEIMPF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x79F6AE0", Offset = "0x79F5EE0", VA = "0x1879F6AE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct HDJMKOCHPED : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer BKMEKKEIMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType MCLKGGFBODE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x79F68D0", Offset = "0x79F5CD0", VA = "0x1879F68D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct DHDFEOHGEGG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> HPMNBNLACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer BKMEKKEIMPF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x666F540", Offset = "0x666E940", VA = "0x18666F540", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct FJLBGOKLPEL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> JGMAGBDHLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer BKMEKKEIMPF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct IDKDPIPMLAK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> MGNIPLBHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T FFOEEMKIKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer BKMEKKEIMPF;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct APMMMABNHNB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NPBDGHGAAGP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> GHHGJIAKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> CNMEBDEGNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap IOPCFKOHPBF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct DEIJIGHNCNK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity DMOJHKOLOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> GHHGJIAKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> CNMEBDEGNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JEGBJOGGHLH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x79F6560", Offset = "0x79F5960", VA = "0x1879F6560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct ADMKFNAEHBG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NMGGMPGEBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> GHHGJIAKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> LIGGJFGFNFH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct JEPAGKIAGFI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NPBDGHGAAGP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> NBKJNGEAIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> CNMEBDEGNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap IOPCFKOHPBF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CGECMJOCALL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DEGMDGFGJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> MEEJPADNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> DBIKDGHBCIO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct FODJIAPGFNC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DEGMDGFGJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> MEEJPADNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> DBIKDGHBCIO;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x47552A0", Offset = "0x47546A0", VA = "0x1847552A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct HLDOJKEDKOB<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> GHHGJIAKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> LIGGJFGFNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> MCJEECOKCKE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x49081D0", Offset = "0x49075D0", VA = "0x1849081D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct LFIDJAEHGFM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NPBDGHGAAGP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> GHHGJIAKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> LIGGJFGFNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> MCJEECOKCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap IOPCFKOHPBF;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GDMJMEHLBHD<T, TPredicate> : IJob where T : struct where TPredicate : struct, ABMBIENBBDN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> GHHGJIAKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> EBINJPJGBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> EGMBLJCMFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate IOPCFKOHPBF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct DGMJCFIPDDB<T, TPredicate> : IJob where T : struct where TPredicate : struct, ABMBIENBBDN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> GHHGJIAKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> LIGGJFGFNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate IOPCFKOHPBF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct POJLFFFAJLE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity DEGMDGFGJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> MEEJPADNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NCJKMJKBJDG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x79F7010", Offset = "0x79F6410", VA = "0x1879F7010", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct HIGPAJHOIKM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity DEGMDGFGJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> MEEJPADNFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> NCJKMJKBJDG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x79F6950", Offset = "0x79F5D50", VA = "0x1879F6950", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PGKNLBKDJCD
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class CICJMGMPKJI
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x33EB350", Offset = "0x33EA750", VA = "0x1833EB350")]
	public static bool CGDFCFLACKN<T>(this NativeArray<Entity> MEEJPADNFAC, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class CJIOADLABAL
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BDFLHJHNCNE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public BDFLHJHNCNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FAANMOLFLCJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public FAANMOLFLCJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> JPOHMKENANG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x79F5F40", Offset = "0x79F5340", VA = "0x1879F5F40")]
	public CJIOADLABAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EMHEILJIEAJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HAOPDAKJHOO
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OMGOODJLEBI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct JECAMKHECKO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal OMGOODJLEBI<TFrom> KLDFHLFOOFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> IEAOMLJNJLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct KFDLPDEBPPG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct OHIEPJLMCBG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal KFDLPDEBPPG<TFrom> KLDFHLFOOFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> IEAOMLJNJLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct HGFGEKBNCPO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct GBMMEBCMNDO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal HGFGEKBNCPO<TFrom> KLDFHLFOOFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> IEAOMLJNJLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct KOJBLOICBHK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct JCDMLKGMMOJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal KOJBLOICBHK<TFrom> KLDFHLFOOFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> IEAOMLJNJLM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CLDADDEHBJL
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GAIGODLJGCL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x35D5310", Offset = "0x35D4710", VA = "0x1835D5310")]
	public static NativeList<T> DHJFFMNNBOI<T>(this NativeArray<T> OEDFEBEPMFH, Allocator JMEGNHGDHIA = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NCJOHONLFFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OOABMCDDIPF
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3807CD0", Offset = "0x38070D0", VA = "0x183807CD0")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArray<Entity> MGNIPLBHEJL, NativeArray<T> HPMNBNLACCC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38079D0", Offset = "0x3806DD0", VA = "0x1838079D0")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArrayAsync<Entity> MGNIPLBHEJL, NativeArrayAsync<T> HPMNBNLACCC, [Optional] JobHandle GDBJMLKDEFE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x38078A0", Offset = "0x3806CA0", VA = "0x1838078A0")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArray<Entity> MGNIPLBHEJL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x79F6D50", Offset = "0x79F6150", VA = "0x1879F6D50")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArray<Entity> MGNIPLBHEJL, ComponentTypes BNAPIBHIEGL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x79F6EC0", Offset = "0x79F62C0", VA = "0x1879F6EC0")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL(this EntityCommandBufferSystem LGJBMJJMAGE, EntityCommandBuffer BKMEKKEIMPF, NativeArray<Entity> MGNIPLBHEJL, ComponentTypes BNAPIBHIEGL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BJELAMICIMB
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CMALOMAJDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79F5FD0", Offset = "0x79F53D0", VA = "0x1879F5FD0")]
	[IJPMNIGGNIN]
	public static JobHandle AKIPOJDHEOC(this EntityCommandBufferSystem LGJBMJJMAGE, NativeList<Entity> MGNIPLBHEJL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x79F6160", Offset = "0x79F5560", VA = "0x1879F6160")]
	[IJPMNIGGNIN]
	public static JobHandle AKIPOJDHEOC(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArrayAsync<Entity> MGNIPLBHEJL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CBDODHOHOHG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x33E8860", Offset = "0x33E7C60", VA = "0x1833E8860")]
	[IJPMNIGGNIN]
	public static JobHandle MINAAJJLMLB<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArrayAsync<Entity> MGNIPLBHEJL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x79F5DB0", Offset = "0x79F51B0", VA = "0x1879F5DB0")]
	[IJPMNIGGNIN]
	public static JobHandle MINAAJJLMLB(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArrayAsync<Entity> MGNIPLBHEJL, ComponentType MCLKGGFBODE, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PLCLNGGOKFM
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3812600", Offset = "0x3811A00", VA = "0x183812600")]
	[IJPMNIGGNIN]
	public static JobHandle FNCHAEBHMFD<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArray<Entity> MGNIPLBHEJL, NativeArray<T> HPMNBNLACCC, JobHandle GDBJMLKDEFE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class IJEANDGFBIH
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class OIINCLGLKGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EPDHCEEJAJN
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x34754E0", Offset = "0x34748E0", VA = "0x1834754E0")]
	public static NativeArray<T> PGAGONMDLDA<T>(this NativeList<Entity> OEDFEBEPMFH, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3475300", Offset = "0x3474700", VA = "0x183475300")]
	public static NativeArray<T> PGAGONMDLDA<T>(this NativeArray<Entity> OEDFEBEPMFH, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x79F66A0", Offset = "0x79F5AA0", VA = "0x1879F66A0")]
	public static NativeArray<Entity> NOGDFICPPOM(this NativeArray<Entity> OEDFEBEPMFH, EntityManager MPNJFPGMBFH, ComponentType MCLKGGFBODE, Allocator JMEGNHGDHIA = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3475200", Offset = "0x3474600", VA = "0x183475200")]
	public static NativeArray<T> AMONOBLHBLC<T>(this NativeArray<Entity> OEDFEBEPMFH, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class PODNPOMBMBF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct HFMBPGCDEBB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct KABNLJJCNJF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public HFMBPGCDEBB<TFrom> IEAOMLJNJLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> GHHGJIAKCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct KLNPKJFIJGP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct NELIIKEMCOC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public KLNPKJFIJGP<TFrom> IEAOMLJNJLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> GHHGJIAKCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct GIJBPIFHFCP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct IPFOHNJBMAF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public GIJBPIFHFCP<TFrom> IEAOMLJNJLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> GHHGJIAKCLP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FHMJBGDMJAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LCBLKEDDJNO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct BANBNFKGGCA : NPBDGHGAAGP<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> MOHOBHDJDOG;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x79F5D00", Offset = "0x79F5100", VA = "0x1879F5D00")]
		[BurstCompatible]
		public Entity AHDIBBAIBEF([In] Entity FFOEEMKIKJO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x79F5D00", Offset = "0x79F5100", VA = "0x1879F5D00", Slot = "4")]
		private Entity NBJGPKLAIFA([In] Entity FFOEEMKIKJO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class JOBIEJKMEKF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct LCBFEJMFDKH<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4E335C0", Offset = "0x4E329C0", VA = "0x184E335C0", Slot = "4")]
		public int Compare((TKey, TValue) MEAMPLHPPKP, (TKey, TValue) KDELALKKKOF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x367EF60", Offset = "0x367E360", VA = "0x18367EF60")]
	public static void JCPPPPGBPGP<TKey, TValue>(NativeList<TKey> JFPEBPFNIGF, NativeList<TValue> JGMAGBDHLIF) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x367F1F0", Offset = "0x367E5F0", VA = "0x18367F1F0")]
	public static void JCPPPPGBPGP<TKey, TValue>(NativeArray<TKey> JFPEBPFNIGF, NativeArray<TValue> JGMAGBDHLIF) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x367ED20", Offset = "0x367E120", VA = "0x18367ED20")]
	public static void JCPPPPGBPGP<TKey, TValue, U>(NativeArray<TKey> JFPEBPFNIGF, NativeArray<TValue> JGMAGBDHLIF, U IDEDEAKFOFF) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HNPMKCIMEJM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct DOMNAAAEDBM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> EBINJPJGBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> GHHGJIAKCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct HLANJFPHHJB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> EBINJPJGBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> GHHGJIAKCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct KGEEDDOJJKE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> EBINJPJGBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> GHHGJIAKCLP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class DKDBPEKLNGF
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OEAAHCEIGHF
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HFAIOMMLNIA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> GHHGJIAKCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct ILGECLLKPAH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> GHHGJIAKCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct BNCOMEEOEJJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> GHHGJIAKCLP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct OEJNHJIOEFE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator JMEGNHGDHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> GHHGJIAKCLP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class FINICGJGDLA
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class BLJJDINELKI
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3385D40", Offset = "0x3385140", VA = "0x183385D40")]
	public static NativeList<Entity> OBGHAKGEAPF<T>(this NativeList<Entity> MEEJPADNFAC, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3385700", Offset = "0x3384B00", VA = "0x183385700")]
	public static NativeList<Entity> OBGHAKGEAPF<T>(this NativeArray<Entity> MEEJPADNFAC, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class PPOFAGOJOCK
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x38175C0", Offset = "0x38169C0", VA = "0x1838175C0")]
	public static NativeList<Entity> KPFMFJMPHHP<T>(this NativeArray<Entity> MEEJPADNFAC, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class KKMGPIAOFCG
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct BAFIOEFBHGD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> LLPLHOOOAEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct CBPJIBCKAPK<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> LLPLHOOOAEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct JEJCBBDFHPO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NPBDGHGAAGP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> LLPLHOOOAEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PNJKIHHKDHN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NPBDGHGAAGP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> LLPLHOOOAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector MMCDKAGHNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int CJFNAFNJJLB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct AJEPJBGMHFH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NPBDGHGAAGP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private PNJKIHHKDHN<TSrc, TValue, TSelector> CBEBKIBOLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue OCLNCENAOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int GNPKFMEIDNL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class NJAAEHEAMLF
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct HLKOPOAFLIO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> LLPLHOOOAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int GNPKFMEIDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int EBDJFOPBMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T OCLNCENAOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T KNMANCGEDNE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GIEALLIDLLC NPEFPKBALEI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4908290", Offset = "0x4907690", VA = "0x184908290")]
			get
			{
				return default(GIEALLIDLLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T CAIEMFCHFGN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, GIEALLIDLLC) JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x49087B0", Offset = "0x4907BB0", VA = "0x1849087B0")]
			get
			{
				return default((T, GIEALLIDLLC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4908990", Offset = "0x4907D90", VA = "0x184908990")]
		public HLKOPOAFLIO(NativeArray<T> LLPLHOOOAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x37F3CE0", Offset = "0x37F30E0", VA = "0x1837F3CE0")]
		public HLKOPOAFLIO<T> DBEEDGEHMMA()
		{
			return default(HLKOPOAFLIO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4908580", Offset = "0x4907980", VA = "0x184908580")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0180", Offset = "0x3B9F580", VA = "0x183BA0180")]
		public MLOLGGNJFBM<T, TComparer> GAEIFKNKOAE<TComparer>([Optional] TComparer IDEDEAKFOFF) where TComparer : struct, IEqualityComparer<T>
		{
			return default(MLOLGGNJFBM<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct MLOLGGNJFBM<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> LLPLHOOOAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int GNPKFMEIDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int EBDJFOPBMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T OCLNCENAOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T KNMANCGEDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer IDEDEAKFOFF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GIEALLIDLLC NPEFPKBALEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4908290", Offset = "0x4907690", VA = "0x184908290")]
			get
			{
				return default(GIEALLIDLLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T CAIEMFCHFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, GIEALLIDLLC range) JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x49087B0", Offset = "0x4907BB0", VA = "0x1849087B0")]
			get
			{
				return default((T, GIEALLIDLLC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5066D00", Offset = "0x5066100", VA = "0x185066D00")]
		public MLOLGGNJFBM(NativeArray<T> LLPLHOOOAEB, TComparer IDEDEAKFOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x42C02F0", Offset = "0x42BF6F0", VA = "0x1842C02F0")]
		public MLOLGGNJFBM<T, TComparer> DBEEDGEHMMA()
		{
			return default(MLOLGGNJFBM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5066B70", Offset = "0x5065F70", VA = "0x185066B70")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37BF030", Offset = "0x37BE430", VA = "0x1837BF030")]
	public static HLKOPOAFLIO<T> LMDDDKEKIDJ<T>(this NativeArray<T> LLPLHOOOAEB) where T : struct
	{
		return default(HLKOPOAFLIO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface EEKMICKJMDD
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class EFCDDGBMFEJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DEAMAICNOBB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class LGCDLLDGNGB : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DEAMAICNOBB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xB4B2C0", Offset = "0xB4A6C0", VA = "0x180B4B2C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x47B0B20", Offset = "0x47AFF20", VA = "0x1847B0B20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public LGCDLLDGNGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4E38BE0", Offset = "0x4E37FE0", VA = "0x184E38BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4E38DB0", Offset = "0x4E381B0", VA = "0x184E38DB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> OMMIFPIMDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream DHNIJNCIKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream HGMAJJOAKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf KAHAMJEBHHN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xB35CF0", Offset = "0xB350F0", VA = "0x180B35CF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6666050", Offset = "0x6665450", VA = "0x186666050", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6666090", Offset = "0x6665490", VA = "0x186666090", Slot = "4")]
	[IteratorStateMachine(typeof(DEAMAICNOBB<>.LGCDLLDGNGB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6666190", Offset = "0x6665590", VA = "0x186666190", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct AEDFJJFEEGL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] DAMDACDIHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf KAHAMJEBHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream DHNIJNCIKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream PPFLCJIDABG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x47F0B90", Offset = "0x47EFF90", VA = "0x1847F0B90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct EOCAPDBAMND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream DHNIJNCIKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream HGMAJJOAKNH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x79F6660", Offset = "0x79F5A60", VA = "0x1879F6660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OGOLFJEIPHB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DAMDACDIHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream DHNIJNCIKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream PPFLCJIDABG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x79F6C30", Offset = "0x79F6030", VA = "0x1879F6C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class EBKFAKGKPFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class LKFODCCGCKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum OAPECFGDJOO
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class BEDHLPIEAJO
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class PLEFJCMKMIM
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public PLEFJCMKMIM()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
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
