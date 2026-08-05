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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EF26D0", Offset = "0x6EF1AD0", VA = "0x186EF26D0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MPNAPJPPNHB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LKDBJJLCJFF EGDFENNKPIC
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
public interface BGDJAJBPMMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APCDNDLCPHF(Entity GLFIOFJHMHG, object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IAMLKOFMJKK(Entity GLFIOFJHMHG, object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFNFJEHIFOA(Entity GLFIOFJHMHG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DAPINBFPEAK<TComponentData, TValue> : KPCEIAEKENF<TValue>, IDisposable where TComponentData : struct, MPNAPJPPNHB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class KFMFDGMJHPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> HGMKHDHJCFJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int NJGLPGPPJOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x389B8C0", Offset = "0x389ACC0", VA = "0x18389B8C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x452D350", Offset = "0x452C750", VA = "0x18452D350")]
		public bool BLIEHBCIDLJ([Out] TValue LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x452D520", Offset = "0x452C920", VA = "0x18452D520")]
		public void PJLPMKJIOFF(object FDAIGOGAKMH, TValue LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x452D460", Offset = "0x452C860", VA = "0x18452D460")]
		public bool MAHJHHAHNPL(object FDAIGOGAKMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x452D250", Offset = "0x452C650", VA = "0x18452D250")]
		public int APCLAAIMPOG(object FDAIGOGAKMH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x452D610", Offset = "0x452CA10", VA = "0x18452D610")]
		public KFMFDGMJHPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<KFMFDGMJHPP> HCPJCIFABPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CLDABECMNED<LKDBJJLCJFF, KFMFDGMJHPP> FGADKGBIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager POOMEDKNPIK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2700", Offset = "0x5BF1B00", VA = "0x185BF2700")]
	public DAPINBFPEAK(EntityManager POOMEDKNPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1E40", Offset = "0x5BF1240", VA = "0x185BF1E40", Slot = "4")]
	public void APCDNDLCPHF(Entity GLFIOFJHMHG, object FDAIGOGAKMH, TValue LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF23D0", Offset = "0x5BF17D0", VA = "0x185BF23D0", Slot = "5")]
	public bool IAMLKOFMJKK(Entity GLFIOFJHMHG, object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1FD0", Offset = "0x5BF13D0", VA = "0x185BF1FD0", Slot = "6")]
	public bool BLIEHBCIDLJ(Entity GLFIOFJHMHG, [Out] TValue LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2220", Offset = "0x5BF1620", VA = "0x185BF2220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2240", Offset = "0x5BF1640", VA = "0x185BF2240")]
	private void FJHEPKADIJM(KFMFDGMJHPP LGPBJDNHFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2310", Offset = "0x5BF1710", VA = "0x185BF2310")]
	private bool GEMEJBCFGGJ(Entity GLFIOFJHMHG, [Out] LKDBJJLCJFF PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2600", Offset = "0x5BF1A00", VA = "0x185BF2600")]
	private void LFGJPECCEOG(Entity GLFIOFJHMHG, LKDBJJLCJFF PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BF25E0", Offset = "0x5BF19E0", VA = "0x185BF25E0")]
	private bool LELLGOEBGEC(LKDBJJLCJFF PKDPMCLKPHH, [Out] KFMFDGMJHPP LGPBJDNHFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BF20F0", Offset = "0x5BF14F0", VA = "0x185BF20F0")]
	private KFMFDGMJHPP DNJAJHMKHFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KPCEIAEKENF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APCDNDLCPHF(Entity GLFIOFJHMHG, object FDAIGOGAKMH, TValue LIHHDPOHLDK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IAMLKOFMJKK(Entity GLFIOFJHMHG, object FDAIGOGAKMH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BLIEHBCIDLJ(Entity GLFIOFJHMHG, [Out] TValue LIHHDPOHLDK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LKDBJJLCJFF : KCAADKMDGIA, IEquatable<LKDBJJLCJFF>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly LKDBJJLCJFF COCGIBDDIEL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int LGPOLAJNCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int KMCLANLNCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27EC6E0", Offset = "0x27EBAE0", VA = "0x1827EC6E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6196640", Offset = "0x6195A40", VA = "0x186196640", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2E50", Offset = "0x6EF2250", VA = "0x186EF2E50", Slot = "8")]
	public bool Equals(LKDBJJLCJFF OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2EA0", Offset = "0x6EF22A0", VA = "0x186EF2EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FILJEEJFPCH<THasTokensTag> : BGDJAJBPMMO, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, LKDBJJLCJFF> MMIFBMACPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> HCPJCIFABPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CLDABECMNED<LKDBJJLCJFF, HashSet<object>> FGADKGBIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager POOMEDKNPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem PHAOOIBCHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HLAMJAHICLD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BD60", Offset = "0x3F2B160", VA = "0x183F2BD60")]
	public FILJEEJFPCH(EntityManager POOMEDKNPIK, EntityCommandBufferSystem PHAOOIBCHBN, EGGMDNJPOBA GHNPGGNOAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3F29360", Offset = "0x3F28760", VA = "0x183F29360", Slot = "4")]
	public bool APCDNDLCPHF(Entity GLFIOFJHMHG, object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3F2AB10", Offset = "0x3F29F10", VA = "0x183F2AB10", Slot = "5")]
	public bool IAMLKOFMJKK(Entity GLFIOFJHMHG, object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3F2A460", Offset = "0x3F29860", VA = "0x183F2A460", Slot = "6")]
	public bool GFNFJEHIFOA(Entity GLFIOFJHMHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3F2A690", Offset = "0x3F29A90", VA = "0x183F2A690", Slot = "8")]
	public bool GFNFJEHIFOA(LKDBJJLCJFF PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3F29DE0", Offset = "0x3F291E0", VA = "0x183F29DE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3F29F50", Offset = "0x3F29350", VA = "0x183F29F50")]
	private void FJHEPKADIJM(HashSet<object> LGPBJDNHFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3F2A220", Offset = "0x3F29620", VA = "0x183F2A220")]
	private bool GEMEJBCFGGJ(Entity GLFIOFJHMHG, [Out] LKDBJJLCJFF PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B990", Offset = "0x3F2AD90", VA = "0x183F2B990")]
	private bool ONBOCMGPJCJ(Entity GLFIOFJHMHG, [Out] LKDBJJLCJFF PKDPMCLKPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B260", Offset = "0x3F2A660", VA = "0x183F2B260")]
	private void KOBOHGMEJJJ(Entity GLFIOFJHMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F29720", Offset = "0x3F28B20", VA = "0x183F29720")]
	private void APEKLOFCKBA(Entity GLFIOFJHMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F2AED0", Offset = "0x3F2A2D0", VA = "0x183F2AED0")]
	private void KALEINNGLML(Entity GLFIOFJHMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B6E0", Offset = "0x3F2AAE0", VA = "0x183F2B6E0")]
	private void LFGJPECCEOG(Entity GLFIOFJHMHG, LKDBJJLCJFF PKDPMCLKPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3F2BB10", Offset = "0x3F2AF10", VA = "0x183F2BB10")]
	private bool PJJIMEEFGJD(LKDBJJLCJFF PKDPMCLKPHH, [Out] HashSet<object> LGPBJDNHFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3F29B60", Offset = "0x3F28F60", VA = "0x183F29B60")]
	private HashSet<object> DNJAJHMKHFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AHIIBGBOPLE
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BBGEPHJKIOH : NBDMEGNBPPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2510", Offset = "0x6EF1910", VA = "0x186EF2510")]
	public float OHOLLHLBJLM([In] float3 LIHHDPOHLDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2510", Offset = "0x6EF1910", VA = "0x186EF2510", Slot = "4")]
	private float DDMCEAEABNK([In] float3 LIHHDPOHLDK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OLNNCLMFPEJ : NBDMEGNBPPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3460", Offset = "0x6EF2860", VA = "0x186EF3460")]
	public float OHOLLHLBJLM([In] float3 LIHHDPOHLDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3460", Offset = "0x6EF2860", VA = "0x186EF3460", Slot = "4")]
	private float DDMCEAEABNK([In] float3 LIHHDPOHLDK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct AKAOLLILKAJ : NBDMEGNBPPA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x9F9320", Offset = "0x9F8720", VA = "0x1809F9320")]
	public float OHOLLHLBJLM([In] float3 LIHHDPOHLDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x9F9320", Offset = "0x9F8720", VA = "0x1809F9320", Slot = "4")]
	private float DDMCEAEABNK([In] float3 LIHHDPOHLDK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CCAMJLDEAHH : NBDMEGNBPPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4AF0", Offset = "0x1AA3EF0", VA = "0x181AA4AF0")]
	public int OHOLLHLBJLM([In] int3 LIHHDPOHLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4AF0", Offset = "0x1AA3EF0", VA = "0x181AA4AF0", Slot = "4")]
	private int KIMAIPKDEHH([In] int3 LIHHDPOHLDK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FKCENHELKEL : NBDMEGNBPPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EF26F0", Offset = "0x6EF1AF0", VA = "0x186EF26F0")]
	public int OHOLLHLBJLM([In] int3 LIHHDPOHLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF26F0", Offset = "0x6EF1AF0", VA = "0x186EF26F0", Slot = "4")]
	private int KIMAIPKDEHH([In] int3 LIHHDPOHLDK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NCNKHPAMKMF : NBDMEGNBPPA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x9DD4B0", Offset = "0x9DC8B0", VA = "0x1809DD4B0")]
	public int OHOLLHLBJLM([In] int3 LIHHDPOHLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9DD4B0", Offset = "0x9DC8B0", VA = "0x1809DD4B0", Slot = "4")]
	private int KIMAIPKDEHH([In] int3 LIHHDPOHLDK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KBKCPFECNNE : OACGMPBFJHP
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x19BDE10", Offset = "0x19BD210", VA = "0x1819BDE10")]
	public KBKCPFECNNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class LCCFGIMALLL : SystemBase, LJKLBDAJLAJ
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2D10", Offset = "0x6EF2110", VA = "0x186EF2D10")]
	public JobHandle JBKDJMDCMJL(ReadOnlySpan<int> IFKBOBILNEJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C630", Offset = "0x2F0BA30", VA = "0x182F0C630")]
	public void EMALJBODCEJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BF30", Offset = "0x2F0B330", VA = "0x182F0BF30")]
	public JobHandle EMALJBODCEJ<T>(JobHandle PKDPMCLKPHH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2CA0", Offset = "0x6EF20A0", VA = "0x186EF2CA0")]
	public JobHandle EMALJBODCEJ(ReadOnlySpan<int> IFKBOBILNEJ, JobHandle PKDPMCLKPHH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BC90", Offset = "0x2F0B090", VA = "0x182F0BC90")]
	public JobHandle BEEMBOEOPAL<T>(JobHandle PKDPMCLKPHH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2D80", Offset = "0x6EF2180", VA = "0x186EF2D80")]
	public ComponentDataFromEntity MOFBDIIDOAK(int BNBPOPFGKEB, bool JJEOCOJGEBM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2D60", Offset = "0x6EF2160", VA = "0x186EF2D60")]
	public EntityExistenceLookupByEntity JMPOOMHPIED()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2E40", Offset = "0x6EF2240", VA = "0x186EF2E40", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x19BDE10", Offset = "0x19BD210", VA = "0x1819BDE10")]
	protected LCCFGIMALLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class EBFJPIEFGIE : LCCFGIMALLL
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EF26A0", Offset = "0x6EF1AA0", VA = "0x186EF26A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x19BDE10", Offset = "0x19BD210", VA = "0x1819BDE10")]
	protected EBFJPIEFGIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HDGIGLNAAFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class KILFDCLFLEC : EntityCommandBufferSystem, LJKLBDAJLAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x19BDE10", Offset = "0x19BD210", VA = "0x1819BDE10")]
	protected KILFDCLFLEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NBDMEGNBPPA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo OHOLLHLBJLM([In] TFrom LIHHDPOHLDK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FMKPOBKMHPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKGKJCJPFMK(T LIHHDPOHLDK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct MJJCDMPANDK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> OOEGFLAGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer NDANEFLGJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes BEAMGDNAHBH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2EF0", Offset = "0x6EF22F0", VA = "0x186EF2EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct IEPKGAOPPDN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> OOEGFLAGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer NDANEFLGJOF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2790", Offset = "0x6EF1B90", VA = "0x186EF2790", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct CMGDELMKLDI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> OOEGFLAGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer NDANEFLGJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType GPFNDLELAFC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2520", Offset = "0x6EF1920", VA = "0x186EF2520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct HJBHPCOKLDG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> OOEGFLAGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> MPMEGOKIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer NDANEFLGJOF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x40AD010", Offset = "0x40AC410", VA = "0x1840AD010", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct BONEGKJJJFG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> OOEGFLAGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> BIHDACIMKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer NDANEFLGJOF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct HAJPECKFBGJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> OOEGFLAGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T LIHHDPOHLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer NDANEFLGJOF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x40628D0", Offset = "0x4061CD0", VA = "0x1840628D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct EILAGAABBHF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NBDMEGNBPPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> KPIAADGOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> ILLLEAONOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap MDOOJHKFGMP;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct DNEMIICDNOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity AMLKKODEBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> KPIAADGOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> ILLLEAONOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int OJJMJKCOLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EF25A0", Offset = "0x6EF19A0", VA = "0x186EF25A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct KJIMMCCBHLM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PDNAGDOMMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> KPIAADGOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> AFKBEEJFMBI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct IFIIEOLIMEB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NBDMEGNBPPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> IHAPDAMLEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> ILLLEAONOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap MDOOJHKFGMP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct IEPDANCCHNK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LGNNJPAHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> BNOFJAAMICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> AKICCNBLMFC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct OEILJKDHMAC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LGNNJPAHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> BNOFJAAMICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> AKICCNBLMFC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4A5EEC0", Offset = "0x4A5E2C0", VA = "0x184A5EEC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct MFKOOADOABE<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> KPIAADGOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> AFKBEEJFMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> GMDIGBDGECA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4818A60", Offset = "0x4817E60", VA = "0x184818A60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct NNAGLBGACEE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NBDMEGNBPPA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> KPIAADGOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> AFKBEEJFMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> GMDIGBDGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap MDOOJHKFGMP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct EBHKMKMDBPI<T, TPredicate> : IJob where T : struct where TPredicate : struct, FMKPOBKMHPM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> KPIAADGOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> KOPIDDEMOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> CGCLMICJPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate MDOOJHKFGMP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct EAODEOJPKLM<T, TPredicate> : IJob where T : struct where TPredicate : struct, FMKPOBKMHPM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> KPIAADGOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> AFKBEEJFMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate MDOOJHKFGMP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct ABFEOOABCBL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity LGNNJPAHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> BNOFJAAMICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> JEIILLEADPO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2440", Offset = "0x6EF1840", VA = "0x186EF2440", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct INPOAPAOGEI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity LGNNJPAHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> BNOFJAAMICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> JEIILLEADPO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2830", Offset = "0x6EF1C30", VA = "0x186EF2830", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HCHLAIJKHJA
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ONJFGCFMOHD
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2FFAC10", Offset = "0x2FFA010", VA = "0x182FFAC10")]
	public static bool FCKBPPKNGEP<T>(this NativeArray<Entity> BNOFJAAMICG, EntityManager POOMEDKNPIK, Allocator MGFIHPDNFPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GDIJGEFFDFD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EHMEAIOGPJL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public EHMEAIOGPJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AMLMFDAEBAO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public AMLMFDAEBAO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> COFCGHJCAIB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2700", Offset = "0x6EF1B00", VA = "0x186EF2700")]
	public GDIJGEFFDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BBANOAGNCGB
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class IJEMECDLBIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct JLLDOEIEPGA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct NMCBLDGMCPF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal JLLDOEIEPGA<TFrom> IIOPLDELPHL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> CAAJFPBAGHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct CCAKAELMHII<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct LCKHKDEHAEA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal CCAKAELMHII<TFrom> IIOPLDELPHL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> CAAJFPBAGHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct BDPGCGBAJNK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct MJNFMAIFDGD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal BDPGCGBAJNK<TFrom> IIOPLDELPHL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> CAAJFPBAGHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct HMKEHJKHDAF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct BCPDMIDEJMB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal HMKEHJKHDAF<TFrom> IIOPLDELPHL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> CAAJFPBAGHE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OKHJIDMEBCH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LOBOJHADKDB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A8F0", Offset = "0x2F39CF0", VA = "0x182F3A8F0")]
	public static NativeList<T> LKFMBBMEKBB<T>(this NativeArray<T> EGILEHGMHCM, Allocator MGFIHPDNFPH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NNCNANMPHJM
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JDFCAPJMFFK
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD470", Offset = "0x2ECC870", VA = "0x182ECD470")]
	[LDANOOGJAPL]
	public static JobHandle BLNGHGINOHM<T>(this EntityCommandBufferSystem PHAOOIBCHBN, NativeArrayAsync<Entity> OOEGFLAGECA, NativeArrayAsync<T> MPMEGOKIEPF, [Optional] JobHandle MAMCAJHLLHB) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD5F0", Offset = "0x2ECC9F0", VA = "0x182ECD5F0")]
	[LDANOOGJAPL]
	public static JobHandle BLNGHGINOHM<T>(this EntityCommandBufferSystem PHAOOIBCHBN, NativeArrayAsync<Entity> OOEGFLAGECA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD340", Offset = "0x2ECC740", VA = "0x182ECD340")]
	[LDANOOGJAPL]
	public static JobHandle BLNGHGINOHM<T>(this EntityCommandBufferSystem PHAOOIBCHBN, NativeArray<Entity> OOEGFLAGECA, [Optional] JobHandle MAMCAJHLLHB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2A10", Offset = "0x6EF1E10", VA = "0x186EF2A10")]
	[LDANOOGJAPL]
	public static JobHandle BLNGHGINOHM(this EntityCommandBufferSystem PHAOOIBCHBN, NativeArray<Entity> OOEGFLAGECA, ComponentTypes BEAMGDNAHBH, [Optional] JobHandle MAMCAJHLLHB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6EF28C0", Offset = "0x6EF1CC0", VA = "0x186EF28C0")]
	[LDANOOGJAPL]
	public static JobHandle BLNGHGINOHM(this EntityCommandBufferSystem PHAOOIBCHBN, EntityCommandBuffer NDANEFLGJOF, NativeArray<Entity> OOEGFLAGECA, ComponentTypes BEAMGDNAHBH, [Optional] JobHandle MAMCAJHLLHB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NHLNDDBOJLM
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7DD0", Offset = "0x2FC71D0", VA = "0x182FC7DD0")]
	[LDANOOGJAPL]
	public static JobHandle BFDNPEOHINH<T>(this EntityCommandBufferSystem PHAOOIBCHBN, EntityCommandBuffer NDANEFLGJOF, EntityQuery PFMGBCNGLDH, T LIHHDPOHLDK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NLNIBOJJGLB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6EF30E0", Offset = "0x6EF24E0", VA = "0x186EF30E0")]
	[LDANOOGJAPL]
	public static JobHandle OMNJOJINNPD(this EntityCommandBufferSystem PHAOOIBCHBN, NativeList<Entity> OOEGFLAGECA, [Optional] JobHandle MAMCAJHLLHB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2FE0", Offset = "0x6EF23E0", VA = "0x186EF2FE0")]
	[LDANOOGJAPL]
	public static JobHandle OMNJOJINNPD(this EntityCommandBufferSystem PHAOOIBCHBN, NativeArrayAsync<Entity> OOEGFLAGECA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KFNMBOHGELH
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DOEAIKAGOFD
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E060", Offset = "0x2C8D460", VA = "0x182C8E060")]
	[LDANOOGJAPL]
	public static JobHandle LJDJMOCFBKB<T>(this EntityCommandBufferSystem PHAOOIBCHBN, NativeArray<Entity> OOEGFLAGECA, NativeArray<T> MPMEGOKIEPF, JobHandle MAMCAJHLLHB) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LFALBOAENAK
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E100", Offset = "0x2F0D500", VA = "0x182F0E100")]
	[LDANOOGJAPL]
	public static JobHandle JAAFAOFNNGE<T>(this EntityCommandBufferSystem PHAOOIBCHBN, NativeArray<Entity> OOEGFLAGECA, T LIHHDPOHLDK, [Optional] JobHandle MAMCAJHLLHB) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E020", Offset = "0x2F0D420", VA = "0x182F0E020")]
	[LDANOOGJAPL]
	public static JobHandle JAAFAOFNNGE<T>(this EntityCommandBufferSystem PHAOOIBCHBN, EntityCommandBuffer NDANEFLGJOF, NativeArray<Entity> OOEGFLAGECA, T LIHHDPOHLDK, [Optional] JobHandle MAMCAJHLLHB) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DHOAECNFKBL
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OKPNJDFOEJE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7770", Offset = "0x2FF6B70", VA = "0x182FF7770")]
	public static NativeArray<T> KNMMGNJPKAI<T>(this NativeList<Entity> EGILEHGMHCM, EntityManager POOMEDKNPIK, Allocator MGFIHPDNFPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2FF71D0", Offset = "0x2FF65D0", VA = "0x182FF71D0")]
	public static NativeArray<T> KNMMGNJPKAI<T>(this NativeArray<Entity> EGILEHGMHCM, EntityManager POOMEDKNPIK, Allocator MGFIHPDNFPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3280", Offset = "0x6EF2680", VA = "0x186EF3280")]
	public static NativeArray<Entity> MDJIJOONKHK(this NativeArray<Entity> EGILEHGMHCM, EntityManager POOMEDKNPIK, ComponentType GPFNDLELAFC, Allocator MGFIHPDNFPH = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2FF70F0", Offset = "0x2FF64F0", VA = "0x182FF70F0")]
	public static NativeArray<T> HILKNDCGFNN<T>(this NativeArray<Entity> EGILEHGMHCM, EntityManager POOMEDKNPIK, Allocator MGFIHPDNFPH = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BPHGKNJDKCG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct HNCNHHOEDMB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct AIHBNHFANCJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HNCNHHOEDMB<TFrom> CAAJFPBAGHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> KPIAADGOJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PGCMLOKHEJC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct PDDLFAILGEO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PGCMLOKHEJC<TFrom> CAAJFPBAGHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> KPIAADGOJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GGBMPHEJOCO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct NCODKPJGPID<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public GGBMPHEJOCO<TFrom> CAAJFPBAGHE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> KPIAADGOJKF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class CAEDKKJLGAL
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HIDNJBILHIK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct OFIFMINKCMK : NBDMEGNBPPA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> MCGPAOBDPAP;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3270", Offset = "0x6EF2670", VA = "0x186EF3270")]
		[BurstCompatible]
		public Entity OHOLLHLBJLM([In] Entity LIHHDPOHLDK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3270", Offset = "0x6EF2670", VA = "0x186EF3270", Slot = "4")]
		private Entity CKCLOJGCGIE([In] Entity LIHHDPOHLDK)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IFCEEKJDKCI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct GIMALNJABMD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> KOPIDDEMOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> KPIAADGOJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct JDGDMKBCGKA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> KOPIDDEMOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> KPIAADGOJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct NJEDCPMCIMB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> KOPIDDEMOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> KPIAADGOJKF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ONMKLKIDFOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GPLJOOEPCFF
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct EKKOLNBLMEM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> KPIAADGOJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct PLMBAHKKCNO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> KPIAADGOJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct IODODMHHMLO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> KPIAADGOJKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct ANAIIHJAEOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator MGFIHPDNFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> KPIAADGOJKF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class PDJCPFEEKED
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class IJBOAEAABNB
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2EA1D90", Offset = "0x2EA1190", VA = "0x182EA1D90")]
	public static NativeList<Entity> KOENILGGAOC<T>(this NativeArray<Entity> BNOFJAAMICG, EntityManager POOMEDKNPIK, Allocator MGFIHPDNFPH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GMGOBMELCPN
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class AIGMEFFICKK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct EAJEEGIHJKD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> AFBDFGIDJPF;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
		public EAJEEGIHJKD(NativeArray<TSrc> AFBDFGIDJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public LMFBKJOBKIG<TSrc, TValue> FBIDLBGDFFB<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LMFBKJOBKIG<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct LMFBKJOBKIG<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> AFBDFGIDJPF;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
		public LMFBKJOBKIG(NativeArray<TSrc> AFBDFGIDJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public CPPOLHGIFHO<TSrc, TValue, TSelector> PGCMEEFDAKC<TSelector>() where TSelector : struct, NBDMEGNBPPA<TSrc, TValue>
		{
			return default(CPPOLHGIFHO<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct CPPOLHGIFHO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NBDMEGNBPPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> AFBDFGIDJPF;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
		public CPPOLHGIFHO(NativeArray<TSrc> AFBDFGIDJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x53E5D20", Offset = "0x53E5120", VA = "0x1853E5D20")]
		public AFOFHDDMMAP<TSrc, TValue, TSelector> DHAAGOILJBD()
		{
			return default(AFOFHDDMMAP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EKIJGGKICPH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NBDMEGNBPPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> AFBDFGIDJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector EKGIAHLBMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int AEAHMAMPNLO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x3B40C80", Offset = "0x3B40080", VA = "0x183B40C80")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LGPOLAJNCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9EDBA0", Offset = "0x9ECFA0", VA = "0x1809EDBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int AKNNAFCACJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x222C340", Offset = "0x222B740", VA = "0x18222C340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3B40DD0", Offset = "0x3B401D0", VA = "0x183B40DD0")]
		public EKIJGGKICPH(NativeArray<TSrc> AFBDFGIDJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B40DC0", Offset = "0x3B401C0", VA = "0x183B40DC0")]
		public bool NPHJBLECBIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3B40CC0", Offset = "0x3B400C0", VA = "0x183B40CC0")]
		private TSrc MIKNCIKMOOO(int INBIGDGMENB)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3B40BF0", Offset = "0x3B3FFF0", VA = "0x183B40BF0")]
		private TValue EINKAHECAKI()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct AFOFHDDMMAP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NBDMEGNBPPA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private EKIJGGKICPH<TSrc, TValue, TSelector> GFMJPAEEPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue IAEHJFHABJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int IHLILPEDKCL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CNPCHKHABFO HBJOMGBJCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3FB5A70", Offset = "0x3FB4E70", VA = "0x183FB5A70")]
			get
			{
				return default(CNPCHKHABFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue JACJHLJJIIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, CNPCHKHABFO range) BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x3FB5AB0", Offset = "0x3FB4EB0", VA = "0x183FB5AB0")]
			get
			{
				return default((TValue, CNPCHKHABFO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3FB5D10", Offset = "0x3FB5110", VA = "0x183FB5D10")]
		public AFOFHDDMMAP(NativeArray<TSrc> AFBDFGIDJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD80210", Offset = "0xD7F610", VA = "0x180D80210")]
		public AFOFHDDMMAP<TSrc, TValue, TSelector> MKNNDFMGFGD()
		{
			return default(AFOFHDDMMAP<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3FB5B90", Offset = "0x3FB4F90", VA = "0x183FB5B90")]
		public bool NPHJBLECBIN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x35705B0", Offset = "0x356F9B0", VA = "0x1835705B0")]
	public static EAJEEGIHJKD<T> IHHNFHPAKHM<T>(this NativeList<T> HGMKHDHJCFJ) where T : struct
	{
		return default(EAJEEGIHJKD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
	public static EAJEEGIHJKD<T> IHHNFHPAKHM<T>(this NativeArray<T> AFBDFGIDJPF) where T : struct
	{
		return default(EAJEEGIHJKD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class OPDOLCFOCKP
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct DNOMPDLMEGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly AFBDFGIDJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int IHLILPEDKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int FCKIEPPFJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T IAEHJFHABJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T BFNGECCPDEE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CNPCHKHABFO HBJOMGBJCME
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x525E450", Offset = "0x525D850", VA = "0x18525E450")]
			get
			{
				return default(CNPCHKHABFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T JACJHLJJIIH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3BCDC10", Offset = "0x3BCD010", VA = "0x183BCDC10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, CNPCHKHABFO) BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA3530", Offset = "0x5CA2930", VA = "0x185CA3530")]
			get
			{
				return default((T, CNPCHKHABFO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA3B30", Offset = "0x5CA2F30", VA = "0x185CA3B30")]
		public DNOMPDLMEGI(NativeArray<T> AFBDFGIDJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA36B0", Offset = "0x5CA2AB0", VA = "0x185CA36B0")]
		public DNOMPDLMEGI<T> MKNNDFMGFGD()
		{
			return default(DNOMPDLMEGI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5CA38D0", Offset = "0x5CA2CD0", VA = "0x185CA38D0")]
		public bool NPHJBLECBIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2F1C5C0", Offset = "0x2F1B9C0", VA = "0x182F1C5C0")]
		public BCFPAKCBLJH<T, TComparer> CIFPLNLNGGC<TComparer>([Optional] TComparer OODKLCBPCMK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BCFPAKCBLJH<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct BCFPAKCBLJH<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly AFBDFGIDJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int IHLILPEDKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int FCKIEPPFJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T IAEHJFHABJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T BFNGECCPDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer OODKLCBPCMK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CNPCHKHABFO HBJOMGBJCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x525E450", Offset = "0x525D850", VA = "0x18525E450")]
			get
			{
				return default(CNPCHKHABFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T JACJHLJJIIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3BCDC10", Offset = "0x3BCD010", VA = "0x183BCDC10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x525E650", Offset = "0x525DA50", VA = "0x18525E650")]
		public BCFPAKCBLJH(NativeArray<T>.ReadOnly AFBDFGIDJPF, TComparer OODKLCBPCMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x525E460", Offset = "0x525D860", VA = "0x18525E460")]
		public bool NPHJBLECBIN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2FFFEE0", Offset = "0x2FFF2E0", VA = "0x182FFFEE0")]
	public static DNOMPDLMEGI<T> DHAAGOILJBD<T>(this NativeArray<T> AFBDFGIDJPF) where T : struct
	{
		return default(DNOMPDLMEGI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface HJFAFHEMMJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class EPIGALABHAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct JDLCJLFLNNB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CPNKECEJHBJ : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public JDLCJLFLNNB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x95E950", Offset = "0x95DD50", VA = "0x18095E950", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3F082B0", Offset = "0x3F076B0", VA = "0x183F082B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public CPNKECEJHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x53E5AF0", Offset = "0x53E4EF0", VA = "0x1853E5AF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x53E5CD0", Offset = "0x53E50D0", VA = "0x1853E5CD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> KPJNJCFBGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream JPOBDPHFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream KOFFMLJDAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf OLFOKAIDJJB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x441BA60", Offset = "0x441AE60", VA = "0x18441BA60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x441BAA0", Offset = "0x441AEA0", VA = "0x18441BAA0", Slot = "4")]
	[IteratorStateMachine(typeof(JDLCJLFLNNB<>.CPNKECEJHBJ))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x441BBA0", Offset = "0x441AFA0", VA = "0x18441BBA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct GGPKPIPHBJL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] FIJBJOBOOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf OLFOKAIDJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream JPOBDPHFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream IBBPGLJMFHG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB640", Offset = "0x3FEAA40", VA = "0x183FEB640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct AFADPLNAOAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream JPOBDPHFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream KOFFMLJDAFG;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EF24D0", Offset = "0x6EF18D0", VA = "0x186EF24D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct JDIPCDIPIJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] FIJBJOBOOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream JPOBDPHFPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream IBBPGLJMFHG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2B80", Offset = "0x6EF1F80", VA = "0x186EF2B80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IHFDJNLHLHM
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class EGDGCCIMCFF
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum PABOLHEBFPG
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
internal static class CKCNBDJLHGL
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class EOOKEPBOIFH
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public EOOKEPBOIFH()
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
