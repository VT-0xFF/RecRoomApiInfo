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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A44640", Offset = "0x7A43A40", VA = "0x187A44640")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A44310", Offset = "0x7A43710", VA = "0x187A44310")]
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
			[Cpp2IlInjected.Address(RVA = "0x3EA7C60", Offset = "0x3EA7060", VA = "0x183EA7C60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x52FC320", Offset = "0x52FB720", VA = "0x1852FC320")]
		public bool BKMMMCAANMG([Out] TValue FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x52FC4E0", Offset = "0x52FB8E0", VA = "0x1852FC4E0")]
		public void JJBKLNLGAIJ(object HHGPJKKLNIG, TValue FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x52FC430", Offset = "0x52FB830", VA = "0x1852FC430")]
		public bool JEBJOEBLLEI(object HHGPJKKLNIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x52FC5C0", Offset = "0x52FB9C0", VA = "0x1852FC5C0")]
		public int NDOEKMMOHNB(object HHGPJKKLNIG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x52FC6A0", Offset = "0x52FBAA0", VA = "0x1852FC6A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x48FA930", Offset = "0x48F9D30", VA = "0x1848FA930")]
	public HBLBOOPHCCA(EntityManager MPNJFPGMBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x48FA1E0", Offset = "0x48F95E0", VA = "0x1848FA1E0", Slot = "4")]
	public void BMCCEANIJAJ(Entity GJIBJHOJMIG, object HHGPJKKLNIG, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48FA740", Offset = "0x48F9B40", VA = "0x1848FA740", Slot = "5")]
	public bool PHBDNGFBCCD(Entity GJIBJHOJMIG, object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48FA0D0", Offset = "0x48F94D0", VA = "0x1848FA0D0", Slot = "6")]
	public bool BKMMMCAANMG(Entity GJIBJHOJMIG, [Out] TValue FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x48FA360", Offset = "0x48F9760", VA = "0x1848FA360", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48FA5A0", Offset = "0x48F99A0", VA = "0x1848FA5A0")]
	private void KGEGCECMCLK(PDNIECMPFCI FNPGLBIMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x48FA660", Offset = "0x48F9A60", VA = "0x1848FA660")]
	private bool LLGHBLNNNHD(Entity GJIBJHOJMIG, [Out] BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x48FA4A0", Offset = "0x48F98A0", VA = "0x1848FA4A0")]
	private void KEHKINFJOCI(Entity GJIBJHOJMIG, BJFJLFKBJFP GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x48FA720", Offset = "0x48F9B20", VA = "0x1848FA720")]
	private bool NALNCJKMPOF(BJFJLFKBJFP GGBKPDHLOJF, [Out] PDNIECMPFCI FNPGLBIMKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48FA380", Offset = "0x48F9780", VA = "0x1848FA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CB98E0", Offset = "0x2CB8CE0", VA = "0x182CB98E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C890", Offset = "0x6B3BC90", VA = "0x186B3C890", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A437A0", Offset = "0x7A42BA0", VA = "0x187A437A0", Slot = "8")]
	public bool Equals(BJFJLFKBJFP KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A437F0", Offset = "0x7A42BF0", VA = "0x187A437F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x42FD860", Offset = "0x42FCC60", VA = "0x1842FD860")]
	public ENPHOHFMGBG(EntityManager MPNJFPGMBFH, EntityCommandBufferSystem LGJBMJJMAGE, GBHBOJAPDOA FKEJEKIDHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42FB5D0", Offset = "0x42FA9D0", VA = "0x1842FB5D0", Slot = "4")]
	public bool BMCCEANIJAJ(Entity GJIBJHOJMIG, object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42FD480", Offset = "0x42FC880", VA = "0x1842FD480", Slot = "5")]
	public bool PHBDNGFBCCD(Entity GJIBJHOJMIG, object HHGPJKKLNIG, [Out] bool PFAAMFNIBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42FAE50", Offset = "0x42FA250", VA = "0x1842FAE50", Slot = "6")]
	public bool AEJJCGKCLAI(Entity GJIBJHOJMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42FADA0", Offset = "0x42FA1A0", VA = "0x1842FADA0", Slot = "8")]
	public bool AEJJCGKCLAI(BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42FBBA0", Offset = "0x42FAFA0", VA = "0x1842FBBA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42FC5D0", Offset = "0x42FB9D0", VA = "0x1842FC5D0")]
	private void KGEGCECMCLK(HashSet<object> FNPGLBIMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42FCB20", Offset = "0x42FBF20", VA = "0x1842FCB20")]
	private bool LLGHBLNNNHD(Entity GJIBJHOJMIG, [Out] BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42FBEE0", Offset = "0x42FB2E0", VA = "0x1842FBEE0")]
	private bool GLFAFPELGHP(Entity GJIBJHOJMIG, [Out] BJFJLFKBJFP GGBKPDHLOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42FBAA0", Offset = "0x42FAEA0", VA = "0x1842FBAA0")]
	private void BOGJEOEMMKM(Entity GJIBJHOJMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x42FCCA0", Offset = "0x42FC0A0", VA = "0x1842FCCA0")]
	private void MHLEAJLFIBN(Entity GJIBJHOJMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42FC900", Offset = "0x42FBD00", VA = "0x1842FC900")]
	private void KMLMHKBIKGG(Entity GJIBJHOJMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42FC480", Offset = "0x42FB880", VA = "0x1842FC480")]
	private void KEHKINFJOCI(Entity GJIBJHOJMIG, BJFJLFKBJFP GGBKPDHLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x42FC0C0", Offset = "0x42FB4C0", VA = "0x1842FC0C0")]
	private bool HCJHEMOHINJ(BJFJLFKBJFP GGBKPDHLOJF, [Out] HashSet<object> FNPGLBIMKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x42FC1C0", Offset = "0x42FB5C0", VA = "0x1842FC1C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A44560", Offset = "0x7A43960", VA = "0x187A44560")]
	public float AHDIBBAIBEF([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A44560", Offset = "0x7A43960", VA = "0x187A44560", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A43780", Offset = "0x7A42B80", VA = "0x187A43780")]
	public float AHDIBBAIBEF([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A43780", Offset = "0x7A42B80", VA = "0x187A43780", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xDBA4A0", Offset = "0xDB98A0", VA = "0x180DBA4A0")]
	public float AHDIBBAIBEF([In] float3 FFOEEMKIKJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xDBA4A0", Offset = "0xDB98A0", VA = "0x180DBA4A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2055A00", Offset = "0x2054E00", VA = "0x182055A00")]
	public int AHDIBBAIBEF([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2055A00", Offset = "0x2054E00", VA = "0x182055A00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xE49D40", Offset = "0xE49140", VA = "0x180E49D40")]
	public int AHDIBBAIBEF([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xE49D40", Offset = "0xE49140", VA = "0x180E49D40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xD9E680", Offset = "0xD9DA80", VA = "0x180D9E680")]
	public int AHDIBBAIBEF([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD9E680", Offset = "0xD9DA80", VA = "0x180D9E680", Slot = "4")]
	private int HIMGKHAHJJE([In] int3 FFOEEMKIKJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MDPDEMPHEMF : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D190", Offset = "0x1F4C590", VA = "0x181F4D190")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A43F20", Offset = "0x7A43320", VA = "0x187A43F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x340A520", Offset = "0x3409920", VA = "0x18340A520")]
	public void POKNOBPPHDB<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x340A520", Offset = "0x3409920", VA = "0x18340A520")]
	public void MBLBBIPGNII<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7A43ED0", Offset = "0x7A432D0", VA = "0x187A43ED0")]
	public JobHandle IPAEPFBKOEB(ReadOnlySpan<int> LJHJOPPPJCA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3409860", Offset = "0x3408C60", VA = "0x183409860")]
	public JobHandle CHAHCGBEJKG<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A43CF0", Offset = "0x7A430F0", VA = "0x187A43CF0")]
	public JobHandle CHAHCGBEJKG(ReadOnlySpan<int> LJHJOPPPJCA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3409AD0", Offset = "0x3408ED0", VA = "0x183409AD0")]
	public void EKNJPNMFJCK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3409910", Offset = "0x3408D10", VA = "0x183409910")]
	public JobHandle EKNJPNMFJCK<T>(JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A43DA0", Offset = "0x7A431A0", VA = "0x187A43DA0")]
	public JobHandle EKNJPNMFJCK(ReadOnlySpan<int> LJHJOPPPJCA, JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3409AD0", Offset = "0x3408ED0", VA = "0x183409AD0")]
	public void MMFIIHHDOJB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x340A580", Offset = "0x3409980", VA = "0x18340A580")]
	public JobHandle MMFIIHHDOJB<T>(JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A43F50", Offset = "0x7A43350", VA = "0x187A43F50")]
	public JobHandle MMFIIHHDOJB(Span<int> LJHJOPPPJCA, JobHandle GGBKPDHLOJF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x340A330", Offset = "0x3409730", VA = "0x18340A330")]
	public ComponentDataFromEntity EPMOKPDEGDL<T>(bool GPPDNEDPIAM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A43E10", Offset = "0x7A43210", VA = "0x187A43E10")]
	public ComponentDataFromEntity EPMOKPDEGDL(int HIALDCJGAPD, bool GPPDNEDPIAM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x340A260", Offset = "0x3409660", VA = "0x18340A260")]
	public SharedComponentIndexFromEntity<T> EMBDOCEDBCI<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A43D40", Offset = "0x7A43140", VA = "0x187A43D40")]
	[BurstCompatible]
	public ComponentTypeHandle DCPMNLFKMGD(ComponentType MCLKGGFBODE)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A43FC0", Offset = "0x7A433C0", VA = "0x187A43FC0")]
	public EntityExistenceLookupByEntity PIOKBGBMECM()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A43FE0", Offset = "0x7A433E0", VA = "0x187A43FE0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x340A400", Offset = "0x3409800", VA = "0x18340A400")]
	public bool LLBAODPNPIA<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D190", Offset = "0x1F4C590", VA = "0x181F4D190")]
	protected CPCJJCHJEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class GFFBJGAFODC : CPCJJCHJEHO
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A44330", Offset = "0x7A43730", VA = "0x187A44330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D190", Offset = "0x1F4C590", VA = "0x181F4D190")]
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
		[Cpp2IlInjected.Address(RVA = "0xCC3F40", Offset = "0xCC3340", VA = "0x180CC3F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A44610", Offset = "0x7A43A10", VA = "0x187A44610")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A44470", Offset = "0x7A43870", VA = "0x187A44470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A44570", Offset = "0x7A43970", VA = "0x187A44570", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A44360", Offset = "0x7A43760", VA = "0x187A44360", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D76A0", Offset = "0x66D6AA0", VA = "0x1866D76A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A43FF0", Offset = "0x7A433F0", VA = "0x187A43FF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x47819A0", Offset = "0x4780DA0", VA = "0x1847819A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4920940", Offset = "0x491FD40", VA = "0x184920940", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A44AA0", Offset = "0x7A43EA0", VA = "0x187A44AA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A443E0", Offset = "0x7A437E0", VA = "0x187A443E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x33FF550", Offset = "0x33FE950", VA = "0x1833FF550")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A439D0", Offset = "0x7A42DD0", VA = "0x187A439D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x35EB5B0", Offset = "0x35EA9B0", VA = "0x1835EB5B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x381B1B0", Offset = "0x381A5B0", VA = "0x18381B1B0")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArray<Entity> MGNIPLBHEJL, NativeArray<T> HPMNBNLACCC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x381AEB0", Offset = "0x381A2B0", VA = "0x18381AEB0")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArrayAsync<Entity> MGNIPLBHEJL, NativeArrayAsync<T> HPMNBNLACCC, [Optional] JobHandle GDBJMLKDEFE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x381AD80", Offset = "0x381A180", VA = "0x18381AD80")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArray<Entity> MGNIPLBHEJL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A447E0", Offset = "0x7A43BE0", VA = "0x187A447E0")]
	[IJPMNIGGNIN]
	public static JobHandle NJKOGAEDIHL(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArray<Entity> MGNIPLBHEJL, ComponentTypes BNAPIBHIEGL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A44950", Offset = "0x7A43D50", VA = "0x187A44950")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A43A60", Offset = "0x7A42E60", VA = "0x187A43A60")]
	[IJPMNIGGNIN]
	public static JobHandle AKIPOJDHEOC(this EntityCommandBufferSystem LGJBMJJMAGE, NativeList<Entity> MGNIPLBHEJL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A43BF0", Offset = "0x7A42FF0", VA = "0x187A43BF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x33FC7C0", Offset = "0x33FBBC0", VA = "0x1833FC7C0")]
	[IJPMNIGGNIN]
	public static JobHandle MINAAJJLMLB<T>(this EntityCommandBufferSystem LGJBMJJMAGE, NativeArrayAsync<Entity> MGNIPLBHEJL, [Optional] JobHandle GDBJMLKDEFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A43840", Offset = "0x7A42C40", VA = "0x187A43840")]
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
	[Cpp2IlInjected.Address(RVA = "0x3825DA0", Offset = "0x38251A0", VA = "0x183825DA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x348A500", Offset = "0x3489900", VA = "0x18348A500")]
	public static NativeArray<T> PGAGONMDLDA<T>(this NativeList<Entity> OEDFEBEPMFH, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x348A140", Offset = "0x3489540", VA = "0x18348A140")]
	public static NativeArray<T> PGAGONMDLDA<T>(this NativeArray<Entity> OEDFEBEPMFH, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A44130", Offset = "0x7A43530", VA = "0x187A44130")]
	public static NativeArray<Entity> NOGDFICPPOM(this NativeArray<Entity> OEDFEBEPMFH, EntityManager MPNJFPGMBFH, ComponentType MCLKGGFBODE, Allocator JMEGNHGDHIA = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x348A040", Offset = "0x3489440", VA = "0x18348A040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A43790", Offset = "0x7A42B90", VA = "0x187A43790")]
		[BurstCompatible]
		public Entity AHDIBBAIBEF([In] Entity FFOEEMKIKJO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7A43790", Offset = "0x7A42B90", VA = "0x187A43790", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E59100", Offset = "0x4E58500", VA = "0x184E59100", Slot = "4")]
		public int Compare((TKey, TValue) MEAMPLHPPKP, (TKey, TValue) KDELALKKKOF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3692380", Offset = "0x3691780", VA = "0x183692380")]
	public static void JCPPPPGBPGP<TKey, TValue>(NativeList<TKey> JFPEBPFNIGF, NativeList<TValue> JGMAGBDHLIF) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3692610", Offset = "0x3691A10", VA = "0x183692610")]
	public static void JCPPPPGBPGP<TKey, TValue>(NativeArray<TKey> JFPEBPFNIGF, NativeArray<TValue> JGMAGBDHLIF) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3692140", Offset = "0x3691540", VA = "0x183692140")]
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
	[Cpp2IlInjected.Address(RVA = "0x339BFB0", Offset = "0x339B3B0", VA = "0x18339BFB0")]
	public static NativeList<Entity> OBGHAKGEAPF<T>(this NativeList<Entity> MEEJPADNFAC, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x339B7E0", Offset = "0x339ABE0", VA = "0x18339B7E0")]
	public static NativeList<Entity> OBGHAKGEAPF<T>(this NativeArray<Entity> MEEJPADNFAC, EntityManager MPNJFPGMBFH, Allocator JMEGNHGDHIA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class PPOFAGOJOCK
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x382ACD0", Offset = "0x382A0D0", VA = "0x18382ACD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4920A00", Offset = "0x491FE00", VA = "0x184920A00")]
			get
			{
				return default(GIEALLIDLLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T CAIEMFCHFGN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, GIEALLIDLLC) JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4920F20", Offset = "0x4920320", VA = "0x184920F20")]
			get
			{
				return default((T, GIEALLIDLLC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4921100", Offset = "0x4920500", VA = "0x184921100")]
		public HLKOPOAFLIO(NativeArray<T> LLPLHOOOAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x38071C0", Offset = "0x38065C0", VA = "0x1838071C0")]
		public HLKOPOAFLIO<T> DBEEDGEHMMA()
		{
			return default(HLKOPOAFLIO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4920CF0", Offset = "0x49200F0", VA = "0x184920CF0")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C470", Offset = "0x3B9B870", VA = "0x183B9C470")]
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
			[Cpp2IlInjected.Address(RVA = "0x4920A00", Offset = "0x491FE00", VA = "0x184920A00")]
			get
			{
				return default(GIEALLIDLLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T CAIEMFCHFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, GIEALLIDLLC range) JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4920F20", Offset = "0x4920320", VA = "0x184920F20")]
			get
			{
				return default((T, GIEALLIDLLC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5086B30", Offset = "0x5085F30", VA = "0x185086B30")]
		public MLOLGGNJFBM(NativeArray<T> LLPLHOOOAEB, TComparer IDEDEAKFOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x42DEE60", Offset = "0x42DE260", VA = "0x1842DEE60")]
		public MLOLGGNJFBM<T, TComparer> DBEEDGEHMMA()
		{
			return default(MLOLGGNJFBM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x50869A0", Offset = "0x5085DA0", VA = "0x1850869A0")]
		public bool IIKPHPEMPPE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37D13B0", Offset = "0x37D07B0", VA = "0x1837D13B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB52830", Offset = "0xB51C30", VA = "0x180B52830", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x47C8310", Offset = "0x47C7710", VA = "0x1847C8310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public LGCDLLDGNGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E700", Offset = "0x4E5DB00", VA = "0x184E5E700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E8D0", Offset = "0x4E5DCD0", VA = "0x184E5E8D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x66CDE90", Offset = "0x66CD290", VA = "0x1866CDE90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x66CDED0", Offset = "0x66CD2D0", VA = "0x1866CDED0", Slot = "4")]
	[IteratorStateMachine(typeof(DEAMAICNOBB<>.LGCDLLDGNGB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x66CDFD0", Offset = "0x66CD3D0", VA = "0x1866CDFD0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4809C40", Offset = "0x4809040", VA = "0x184809C40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A440F0", Offset = "0x7A434F0", VA = "0x187A440F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A446C0", Offset = "0x7A43AC0", VA = "0x187A446C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
