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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB8B90", Offset = "0x6FB7B90", VA = "0x186FB8B90")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MBIPKDJDKJN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LMAPKKOFJAC DLGIEOLCGCN
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
public interface IKJMMGJOMGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNKFDCIIHIG(Entity KKABBGOPMMA, object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEEPCONOHIK(Entity KKABBGOPMMA, object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MBEJACJCMCE(Entity KKABBGOPMMA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LBCEIPKGJOG<TComponentData, TValue> : GHAGACNFCHI<TValue>, IDisposable where TComponentData : struct, MBIPKDJDKJN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class MIJDGKMLCJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> AKKGGCHEPCI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int BCEJCMKMCEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x395A3E0", Offset = "0x39593E0", VA = "0x18395A3E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x49522D0", Offset = "0x49512D0", VA = "0x1849522D0")]
		public bool MPOJFMCADIF([Out] TValue BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x49523E0", Offset = "0x49513E0", VA = "0x1849523E0")]
		public void OPFOFHIGBEE(object NANMDIJGGLP, TValue BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4952210", Offset = "0x4951210", VA = "0x184952210")]
		public bool CAKBCGBONLK(object NANMDIJGGLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4952110", Offset = "0x4951110", VA = "0x184952110")]
		public int ALPEADNKMBM(object NANMDIJGGLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x49524D0", Offset = "0x49514D0", VA = "0x1849524D0")]
		public MIJDGKMLCJJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<MIJDGKMLCJJ> DDDFKJEMGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private FAKCOAFGPJL<LMAPKKOFJAC, MIJDGKMLCJJ> BEKMFCKHBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager MPPDEPEBNEN;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4715000", Offset = "0x4714000", VA = "0x184715000")]
	public LBCEIPKGJOG(EntityManager MPPDEPEBNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4714740", Offset = "0x4713740", VA = "0x184714740", Slot = "4")]
	public void BNKFDCIIHIG(Entity KKABBGOPMMA, object NANMDIJGGLP, TValue BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x47148D0", Offset = "0x47138D0", VA = "0x1847148D0", Slot = "5")]
	public bool DEEPCONOHIK(Entity KKABBGOPMMA, object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4714E20", Offset = "0x4713E20", VA = "0x184714E20", Slot = "6")]
	public bool MPOJFMCADIF(Entity KKABBGOPMMA, [Out] TValue BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4714AE0", Offset = "0x4713AE0", VA = "0x184714AE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4714B00", Offset = "0x4713B00", VA = "0x184714B00")]
	private void FKDMDGGNKBH(MIJDGKMLCJJ FCCNGPPAIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4714F40", Offset = "0x4713F40", VA = "0x184714F40")]
	private bool OKNJDBFJNDG(Entity KKABBGOPMMA, [Out] LMAPKKOFJAC GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4714D20", Offset = "0x4713D20", VA = "0x184714D20")]
	private void HLEFDMKNBLJ(Entity KKABBGOPMMA, LMAPKKOFJAC GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4714D00", Offset = "0x4713D00", VA = "0x184714D00")]
	private bool HHPEGFNNBIP(LMAPKKOFJAC GCBNNIKBPHJ, [Out] MIJDGKMLCJJ FCCNGPPAIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4714BD0", Offset = "0x4713BD0", VA = "0x184714BD0")]
	private MIJDGKMLCJJ GCPMBHFLKHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GHAGACNFCHI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNKFDCIIHIG(Entity KKABBGOPMMA, object NANMDIJGGLP, TValue BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEEPCONOHIK(Entity KKABBGOPMMA, object NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPOJFMCADIF(Entity KKABBGOPMMA, [Out] TValue BJDKOHEGDOK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LMAPKKOFJAC : JGFOKCMIJII, IEquatable<LMAPKKOFJAC>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly LMAPKKOFJAC IONEBEBLBGC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int HOLNAIGPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD342A0", Offset = "0xD332A0", VA = "0x180D342A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int ECKOFMKJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BCA20", VA = "0x1828BDA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x625B930", Offset = "0x625A930", VA = "0x18625B930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9680", Offset = "0x6FB8680", VA = "0x186FB9680", Slot = "8")]
	public bool Equals(LMAPKKOFJAC DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FB96D0", Offset = "0x6FB86D0", VA = "0x186FB96D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MLGPBIJIHLC<THasTokensTag> : IKJMMGJOMGA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, LMAPKKOFJAC> MLECEJAOPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> DDDFKJEMGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private FAKCOAFGPJL<LMAPKKOFJAC, HashSet<object>> BEKMFCKHBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager MPPDEPEBNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem GFJMJBDJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool PPKGDGFGJOG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x495B310", Offset = "0x495A310", VA = "0x18495B310")]
	public MLGPBIJIHLC(EntityManager MPPDEPEBNEN, EntityCommandBufferSystem GFJMJBDJGDF, CDBONJBDMGH JHLLNHBMFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4958C80", Offset = "0x4957C80", VA = "0x184958C80", Slot = "4")]
	public bool BNKFDCIIHIG(Entity KKABBGOPMMA, object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4959220", Offset = "0x4958220", VA = "0x184959220", Slot = "5")]
	public bool DEEPCONOHIK(Entity KKABBGOPMMA, object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x495A260", Offset = "0x4959260", VA = "0x18495A260", Slot = "6")]
	public bool MBEJACJCMCE(Entity KKABBGOPMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x495A310", Offset = "0x4959310", VA = "0x18495A310", Slot = "8")]
	public bool MBEJACJCMCE(LMAPKKOFJAC GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4959620", Offset = "0x4958620", VA = "0x184959620", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4959AB0", Offset = "0x4958AB0", VA = "0x184959AB0")]
	private void FKDMDGGNKBH(HashSet<object> FCCNGPPAIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x495A910", Offset = "0x4959910", VA = "0x18495A910")]
	private bool OKNJDBFJNDG(Entity KKABBGOPMMA, [Out] LMAPKKOFJAC GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4959F20", Offset = "0x4958F20", VA = "0x184959F20")]
	private bool GEDLMDNINOE(Entity KKABBGOPMMA, [Out] LMAPKKOFJAC GCBNNIKBPHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x495ADC0", Offset = "0x4959DC0", VA = "0x18495ADC0")]
	private void PJKBOOKHJDP(Entity KKABBGOPMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x495AFE0", Offset = "0x4959FE0", VA = "0x18495AFE0")]
	private void PONFEFKHMIF(Entity KKABBGOPMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4959780", Offset = "0x4958780", VA = "0x184959780")]
	private void EIMMOFDDEEJ(Entity KKABBGOPMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x495A0A0", Offset = "0x49590A0", VA = "0x18495A0A0")]
	private void HLEFDMKNBLJ(Entity KKABBGOPMMA, LMAPKKOFJAC GCBNNIKBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x495A6D0", Offset = "0x49596D0", VA = "0x18495A6D0")]
	private bool MEMENEFFNOA(LMAPKKOFJAC GCBNNIKBPHJ, [Out] HashSet<object> FCCNGPPAIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4959D00", Offset = "0x4958D00", VA = "0x184959D00")]
	private HashSet<object> GCPMBHFLKHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OFHHLKNGPMB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PCJOMLJCGPP : HICFDNNCPAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FB97E0", Offset = "0x6FB87E0", VA = "0x186FB97E0")]
	public float NEBAMBBDNOB([In] float3 BJDKOHEGDOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FB97E0", Offset = "0x6FB87E0", VA = "0x186FB97E0", Slot = "4")]
	private float FIOBOKKJHOL([In] float3 BJDKOHEGDOK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GHLKFMHPJMD : HICFDNNCPAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8DF0", Offset = "0x6FB7DF0", VA = "0x186FB8DF0")]
	public float NEBAMBBDNOB([In] float3 BJDKOHEGDOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8DF0", Offset = "0x6FB7DF0", VA = "0x186FB8DF0", Slot = "4")]
	private float FIOBOKKJHOL([In] float3 BJDKOHEGDOK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LABIHMHMAOH : HICFDNNCPAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xACC7C0", Offset = "0xACB7C0", VA = "0x180ACC7C0")]
	public float NEBAMBBDNOB([In] float3 BJDKOHEGDOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xACC7C0", Offset = "0xACB7C0", VA = "0x180ACC7C0", Slot = "4")]
	private float FIOBOKKJHOL([In] float3 BJDKOHEGDOK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NGPCJDJIOIH : HICFDNNCPAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B803C0", Offset = "0x1B7F3C0", VA = "0x181B803C0")]
	public int NEBAMBBDNOB([In] int3 BJDKOHEGDOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B803C0", Offset = "0x1B7F3C0", VA = "0x181B803C0", Slot = "4")]
	private int MBAEDCGIBPB([In] int3 BJDKOHEGDOK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EONCIBBFMBD : HICFDNNCPAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C39B00", Offset = "0x6C38B00", VA = "0x186C39B00")]
	public int NEBAMBBDNOB([In] int3 BJDKOHEGDOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C39B00", Offset = "0x6C38B00", VA = "0x186C39B00", Slot = "4")]
	private int MBAEDCGIBPB([In] int3 BJDKOHEGDOK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CMHBJBNBIAM : HICFDNNCPAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xAB0B80", Offset = "0xAAFB80", VA = "0x180AB0B80")]
	public int NEBAMBBDNOB([In] int3 BJDKOHEGDOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xAB0B80", Offset = "0xAAFB80", VA = "0x180AB0B80", Slot = "4")]
	private int MBAEDCGIBPB([In] int3 BJDKOHEGDOK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DLNFKJDBMLO : ABJAHIBDLME
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1A9B2A0", Offset = "0x1A9A2A0", VA = "0x181A9B2A0")]
	public DLNFKJDBMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class FKDLKDEFCPI : SystemBase, HOEIKBENIMO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8C20", Offset = "0x6FB7C20", VA = "0x186FB8C20")]
	public JobHandle GBJJFOMADHA(ReadOnlySpan<int> HNDKMIADJPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2F5B060", Offset = "0x2F5A060", VA = "0x182F5B060")]
	public void FMOPNBGHAMH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F5ADC0", Offset = "0x2F59DC0", VA = "0x182F5ADC0")]
	public JobHandle FMOPNBGHAMH<T>(JobHandle GCBNNIKBPHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8BB0", Offset = "0x6FB7BB0", VA = "0x186FB8BB0")]
	public JobHandle FMOPNBGHAMH(ReadOnlySpan<int> HNDKMIADJPL, JobHandle GCBNNIKBPHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2F5AB20", Offset = "0x2F59B20", VA = "0x182F5AB20")]
	public JobHandle ACEBIIAANHK<T>(JobHandle GCBNNIKBPHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8C70", Offset = "0x6FB7C70", VA = "0x186FB8C70")]
	public ComponentDataFromEntity MDJAOIDEMLB(int BPLLKOJNCAJ, bool DAPPHDLLBJN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8D30", Offset = "0x6FB7D30", VA = "0x186FB8D30")]
	public EntityExistenceLookupByEntity PMDMFKAPGBO()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8D50", Offset = "0x6FB7D50", VA = "0x186FB8D50", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1A9B2A0", Offset = "0x1A9A2A0", VA = "0x181A9B2A0")]
	protected FKDLKDEFCPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class MDKBEFHJHLI : FKDLKDEFCPI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9720", Offset = "0x6FB8720", VA = "0x186FB9720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1A9B2A0", Offset = "0x1A9A2A0", VA = "0x181A9B2A0")]
	protected MDKBEFHJHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PBLFFILDADE
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NGDCHPNELOG : EntityCommandBufferSystem, HOEIKBENIMO
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1A9B2A0", Offset = "0x1A9A2A0", VA = "0x181A9B2A0")]
	protected NGDCHPNELOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HICFDNNCPAC<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NEBAMBBDNOB([In] TFrom BJDKOHEGDOK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BJMHCAODPHG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HKLJHCJJEGO(T BJDKOHEGDOK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct IANBAMIGCOH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> DDMFLNKDDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer LGPOHBCJMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes BDFJHEONFPO;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8E90", Offset = "0x6FB7E90", VA = "0x186FB8E90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct AOFALKGAEGN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> DDMFLNKDDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer LGPOHBCJMDL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8850", Offset = "0x6FB7850", VA = "0x186FB8850", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct AGBAEIDBCID : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> DDMFLNKDDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer LGPOHBCJMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType MHFBMAEOLMP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB87D0", Offset = "0x6FB77D0", VA = "0x186FB87D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct OPKPAHENDFC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> DDMFLNKDDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> CONAFKKIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer LGPOHBCJMDL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FC50", Offset = "0x4B3EC50", VA = "0x184B3FC50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct JEHMOFJDCGK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> DDMFLNKDDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> CMDOFHABOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer LGPOHBCJMDL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct NFLDNBADCDP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> DDMFLNKDDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T BJDKOHEGDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer LGPOHBCJMDL;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x49E3DE0", Offset = "0x49E2DE0", VA = "0x1849E3DE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct KOKFLKCDDNE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HICFDNNCPAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> ACBEJBJPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> JNJLKAEANFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap NDLMGANFCBJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct KPMIMHOPPOG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity KFLDGILMDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> ACBEJBJPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> JNJLKAEANFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int FOGHEBJNALH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FB92C0", Offset = "0x6FB82C0", VA = "0x186FB92C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct IEFCPKCCEHF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KMNMLGCHGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> ACBEJBJPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> OGIDGHAOINJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct DOMGDGGIHMH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HICFDNNCPAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> LODDJPILKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> JNJLKAEANFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap NDLMGANFCBJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct MKMIGLLMHMA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MLCABPMCGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> JJDBGFLBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> PGAGJBNKEHN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct JPNAOGNMOAF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MLCABPMCGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> JJDBGFLBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> PGAGJBNKEHN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x45C0F40", Offset = "0x45BFF40", VA = "0x1845C0F40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct NOFKOMMKIDL<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> ACBEJBJPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> OGIDGHAOINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> HKADNAMPGFN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x49FEAD0", Offset = "0x49FDAD0", VA = "0x1849FEAD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct HKMJOBODNLL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HICFDNNCPAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> ACBEJBJPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> OGIDGHAOINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> HKADNAMPGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap NDLMGANFCBJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct HAEAEALHMBA<T, TPredicate> : IJob where T : struct where TPredicate : struct, BJMHCAODPHG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> ACBEJBJPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> EFHKKNPEJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> LECOCKPPFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate NDLMGANFCBJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct IBHJFFHFKKM<T, TPredicate> : IJob where T : struct where TPredicate : struct, BJMHCAODPHG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> ACBEJBJPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> OGIDGHAOINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate NDLMGANFCBJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct NDMHANLPBNM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity MLCABPMCGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> JJDBGFLBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> NLFBBAOCBJC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9750", Offset = "0x6FB8750", VA = "0x186FB9750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct GCHGGLNNNNL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity MLCABPMCGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> JJDBGFLBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NLFBBAOCBJC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8D60", Offset = "0x6FB7D60", VA = "0x186FB8D60", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KBMGEKJODHC
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KMLJLJABGFH
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x303E8F0", Offset = "0x303D8F0", VA = "0x18303E8F0")]
	public static bool MBLADGOHCHJ<T>(this NativeArray<Entity> JJDBGFLBKHA, EntityManager MPPDEPEBNEN, Allocator HHJAFJNPHLL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HGLAFGDFBHB
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MGMDJAODAKI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public MGMDJAODAKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EDHDLOCKOLC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public EDHDLOCKOLC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> LAAKNJNKKPH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8E00", Offset = "0x6FB7E00", VA = "0x186FB8E00")]
	public HGLAFGDFBHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PKDOGHNGMNK
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OMALLAHDLJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct JFIONMFLGMK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct NEFKIGFMNDB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal JFIONMFLGMK<TFrom> JNLBEALAMNB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> KBCCBGCMCIL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct AJDGGCNABAA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct ALEBDGLKKNJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal AJDGGCNABAA<TFrom> JNLBEALAMNB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> KBCCBGCMCIL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FAPKKDLJCLC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct KAMOLCDNAEF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal FAPKKDLJCLC<TFrom> JNLBEALAMNB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> KBCCBGCMCIL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct HGCDMBFDDGA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PLILEBHGMOK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal HGCDMBFDDGA<TFrom> JNLBEALAMNB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> KBCCBGCMCIL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BEEFDEEFGCO
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HOADIEBHLIB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F97CE0", Offset = "0x2F96CE0", VA = "0x182F97CE0")]
	public static NativeList<T> GFCCAMMGIND<T>(this NativeArray<T> EHBFCNMJGLO, Allocator HHJAFJNPHLL = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IJFBHOBIFCK
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LFJKNFEHIMH
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x304A590", Offset = "0x3049590", VA = "0x18304A590")]
	[NLKPEONJFIO]
	public static JobHandle GGMJLLFLGIK<T>(this EntityCommandBufferSystem GFJMJBDJGDF, NativeArrayAsync<Entity> DDMFLNKDDEE, NativeArrayAsync<T> CONAFKKIHKL, [Optional] JobHandle JNELEDNFIIM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x304A710", Offset = "0x3049710", VA = "0x18304A710")]
	[NLKPEONJFIO]
	public static JobHandle GGMJLLFLGIK<T>(this EntityCommandBufferSystem GFJMJBDJGDF, NativeArrayAsync<Entity> DDMFLNKDDEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x304A460", Offset = "0x3049460", VA = "0x18304A460")]
	[NLKPEONJFIO]
	public static JobHandle GGMJLLFLGIK<T>(this EntityCommandBufferSystem GFJMJBDJGDF, NativeArray<Entity> DDMFLNKDDEE, [Optional] JobHandle JNELEDNFIIM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FB93C0", Offset = "0x6FB83C0", VA = "0x186FB93C0")]
	[NLKPEONJFIO]
	public static JobHandle GGMJLLFLGIK(this EntityCommandBufferSystem GFJMJBDJGDF, NativeArray<Entity> DDMFLNKDDEE, ComponentTypes BDFJHEONFPO, [Optional] JobHandle JNELEDNFIIM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9530", Offset = "0x6FB8530", VA = "0x186FB9530")]
	[NLKPEONJFIO]
	public static JobHandle GGMJLLFLGIK(this EntityCommandBufferSystem GFJMJBDJGDF, EntityCommandBuffer LGPOHBCJMDL, NativeArray<Entity> DDMFLNKDDEE, ComponentTypes BDFJHEONFPO, [Optional] JobHandle JNELEDNFIIM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FDIINNCGPDP
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2F4E730", Offset = "0x2F4D730", VA = "0x182F4E730")]
	[NLKPEONJFIO]
	public static JobHandle HDBNBNKHJND<T>(this EntityCommandBufferSystem GFJMJBDJGDF, EntityCommandBuffer LGPOHBCJMDL, EntityQuery GMKFBPLHJPM, T BJDKOHEGDOK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BMABJEJOJPP
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8900", Offset = "0x6FB7900", VA = "0x186FB8900")]
	[NLKPEONJFIO]
	public static JobHandle CNOCLOFEKLP(this EntityCommandBufferSystem GFJMJBDJGDF, NativeList<Entity> DDMFLNKDDEE, [Optional] JobHandle JNELEDNFIIM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8A90", Offset = "0x6FB7A90", VA = "0x186FB8A90")]
	[NLKPEONJFIO]
	public static JobHandle CNOCLOFEKLP(this EntityCommandBufferSystem GFJMJBDJGDF, NativeArrayAsync<Entity> DDMFLNKDDEE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ODDCGPFPDNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DNBBFANOONJ
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2DBDB70", Offset = "0x2DBCB70", VA = "0x182DBDB70")]
	[NLKPEONJFIO]
	public static JobHandle PMGPGDIKDKJ<T>(this EntityCommandBufferSystem GFJMJBDJGDF, NativeArray<Entity> DDMFLNKDDEE, NativeArray<T> CONAFKKIHKL, JobHandle JNELEDNFIIM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MJOFBLJHMHP
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3088EC0", Offset = "0x3087EC0", VA = "0x183088EC0")]
	[NLKPEONJFIO]
	public static JobHandle NPJCBIIAAAH<T>(this EntityCommandBufferSystem GFJMJBDJGDF, NativeArray<Entity> DDMFLNKDDEE, T BJDKOHEGDOK, [Optional] JobHandle JNELEDNFIIM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3088FB0", Offset = "0x3087FB0", VA = "0x183088FB0")]
	[NLKPEONJFIO]
	public static JobHandle NPJCBIIAAAH<T>(this EntityCommandBufferSystem GFJMJBDJGDF, EntityCommandBuffer LGPOHBCJMDL, NativeArray<Entity> DDMFLNKDDEE, T BJDKOHEGDOK, [Optional] JobHandle JNELEDNFIIM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CDGBMJIHOCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class JBDAIPMBEGD
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC5F0", Offset = "0x2FFB5F0", VA = "0x182FFC5F0")]
	public static NativeArray<T> AACCCLHHHDP<T>(this NativeList<Entity> EHBFCNMJGLO, EntityManager MPPDEPEBNEN, Allocator HHJAFJNPHLL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC230", Offset = "0x2FFB230", VA = "0x182FFC230")]
	public static NativeArray<T> AACCCLHHHDP<T>(this NativeArray<Entity> EHBFCNMJGLO, EntityManager MPPDEPEBNEN, Allocator HHJAFJNPHLL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6FB90E0", Offset = "0x6FB80E0", VA = "0x186FB90E0")]
	public static NativeArray<Entity> EFALNGKEFDM(this NativeArray<Entity> EHBFCNMJGLO, EntityManager MPPDEPEBNEN, ComponentType MHFBMAEOLMP, Allocator HHJAFJNPHLL = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC8A0", Offset = "0x2FFB8A0", VA = "0x182FFC8A0")]
	public static NativeArray<T> KHFFIKGCJFF<T>(this NativeArray<Entity> EHBFCNMJGLO, EntityManager MPPDEPEBNEN, Allocator HHJAFJNPHLL = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class AOMBACCFKKG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct KLMANFENPIH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct CNDLFBLIBKI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public KLMANFENPIH<TFrom> KBCCBGCMCIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> ACBEJBJPLMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NGOENNCIPDK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct BDJGCHFDLPJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public NGOENNCIPDK<TFrom> KBCCBGCMCIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> ACBEJBJPLMA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NGBFPIGFDHN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct JHMFNONDMMD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NGBFPIGFDHN<TFrom> KBCCBGCMCIL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> ACBEJBJPLMA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MHPKNPHKECF
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class GHEJBGHGELK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct BIKLONLJOOD : HICFDNNCPAC<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> PMDALDGIIBD;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FB88F0", Offset = "0x6FB78F0", VA = "0x186FB88F0")]
		[BurstCompatible]
		public Entity NEBAMBBDNOB([In] Entity BJDKOHEGDOK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FB88F0", Offset = "0x6FB78F0", VA = "0x186FB88F0", Slot = "4")]
		private Entity JECIEAFBBGN([In] Entity BJDKOHEGDOK)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FAMEDADHOEI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct DMFDJKENMGH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> EFHKKNPEJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> ACBEJBJPLMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct JDIMJEDKCEN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> EFHKKNPEJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> ACBEJBJPLMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct EANNDGMCHLF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> EFHKKNPEJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> ACBEJBJPLMA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HMGMHLIEJLP
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class JJMFCEMPNIC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct BILKMJIAFBM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> ACBEJBJPLMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct BFKNBJHPEDH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> ACBEJBJPLMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct POCDGBEPMGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> ACBEJBJPLMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct DFKOODLAHJH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator HHJAFJNPHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> ACBEJBJPLMA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class LPOKGOMKJOD
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GCKHBGOPPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C5A0", Offset = "0x2F7B5A0", VA = "0x182F7C5A0")]
	public static NativeList<Entity> FGIDDDICMDN<T>(this NativeArray<Entity> JJDBGFLBKHA, EntityManager MPPDEPEBNEN, Allocator HHJAFJNPHLL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BBBJLMMJDHE
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class BNLFAIFICIJ
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct MAKFPMEKFPG<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> CHPMBGHOEJI;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
		public MAKFPMEKFPG(NativeArray<TSrc> CHPMBGHOEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public BMBCPEMBCGH<TSrc, TValue> CFICFFEBGKH<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(BMBCPEMBCGH<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct BMBCPEMBCGH<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> CHPMBGHOEJI;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
		public BMBCPEMBCGH(NativeArray<TSrc> CHPMBGHOEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public DDHGIEGAJOF<TSrc, TValue, TSelector> HKMDHCEDFNK<TSelector>() where TSelector : struct, HICFDNNCPAC<TSrc, TValue>
		{
			return default(DDHGIEGAJOF<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct DDHGIEGAJOF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HICFDNNCPAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> CHPMBGHOEJI;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
		public DDHGIEGAJOF(NativeArray<TSrc> CHPMBGHOEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E2E0", Offset = "0x5D6D2E0", VA = "0x185D6E2E0")]
		public CHAHIHPMPHP<TSrc, TValue, TSelector> FLONFIIJDHB()
		{
			return default(CHAHIHPMPHP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct GILGEBMOHPJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HICFDNNCPAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> CHPMBGHOEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector KFHOEFNALIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int KHAIDMGPIED;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4171340", Offset = "0x4170340", VA = "0x184171340")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int HOLNAIGPNGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC40D0", VA = "0x180AC50D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int AAOLGFOFBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x22F9A20", Offset = "0x22F8A20", VA = "0x1822F9A20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4171380", Offset = "0x4170380", VA = "0x184171380")]
		public GILGEBMOHPJ(NativeArray<TSrc> CHPMBGHOEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x41712A0", Offset = "0x41702A0", VA = "0x1841712A0")]
		public bool IFOGALALJEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x41711A0", Offset = "0x41701A0", VA = "0x1841711A0")]
		private TSrc CCNODBCCDDN(int MEJGJHNGKCJ)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x41712B0", Offset = "0x41702B0", VA = "0x1841712B0")]
		private TValue KLLIANIAMEM()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct CHAHIHPMPHP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HICFDNNCPAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private GILGEBMOHPJ<TSrc, TValue, TSelector> DIHCGFLIECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue IGECHFPLLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int KECPKLHBJEB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BPODBOELFJH BALDEMOMOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5811B70", Offset = "0x5810B70", VA = "0x185811B70")]
			get
			{
				return default(BPODBOELFJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue EIIMOHAMCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, BPODBOELFJH range) OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5811D30", Offset = "0x5810D30", VA = "0x185811D30")]
			get
			{
				return default((TValue, BPODBOELFJH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5811E10", Offset = "0x5810E10", VA = "0x185811E10")]
		public CHAHIHPMPHP(NativeArray<TSrc> CHPMBGHOEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xE60660", Offset = "0xE5F660", VA = "0x180E60660")]
		public CHAHIHPMPHP<TSrc, TValue, TSelector> EMFBOAAPBLH()
		{
			return default(CHAHIHPMPHP<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5811BB0", Offset = "0x5810BB0", VA = "0x185811BB0")]
		public bool IFOGALALJEO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D02C20", Offset = "0x2D01C20", VA = "0x182D02C20")]
	public static MAKFPMEKFPG<T> PGMDBJOOAGM<T>(this NativeList<T> AKKGGCHEPCI) where T : struct
	{
		return default(MAKFPMEKFPG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
	public static MAKFPMEKFPG<T> PGMDBJOOAGM<T>(this NativeArray<T> CHPMBGHOEJI) where T : struct
	{
		return default(MAKFPMEKFPG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class OCJIKBCCFLA
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct HKLJCHOAOJE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly CHPMBGHOEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int KECPKLHBJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int DBHBCMIEDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T IGECHFPLLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T JMCIAPDCICJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BPODBOELFJH BALDEMOMOOD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x401D610", Offset = "0x401C610", VA = "0x18401D610")]
			get
			{
				return default(BPODBOELFJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T EIIMOHAMCKG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3CCBDC0", Offset = "0x3CCADC0", VA = "0x183CCBDC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, BPODBOELFJH) OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4207920", Offset = "0x4206920", VA = "0x184207920")]
			get
			{
				return default((T, BPODBOELFJH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4207A60", Offset = "0x4206A60", VA = "0x184207A60")]
		public HKLJCHOAOJE(NativeArray<T> CHPMBGHOEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4207460", Offset = "0x4206460", VA = "0x184207460")]
		public HKLJCHOAOJE<T> EMFBOAAPBLH()
		{
			return default(HKLJCHOAOJE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x42074A0", Offset = "0x42064A0", VA = "0x1842074A0")]
		public bool IFOGALALJEO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3272CF0", Offset = "0x3271CF0", VA = "0x183272CF0")]
		public FONFIIEGEGC<T, TComparer> FCFIAIJKHBJ<TComparer>([Optional] TComparer JOFEBBPBCBA) where TComparer : struct, IEqualityComparer<T>
		{
			return default(FONFIIEGEGC<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FONFIIEGEGC<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly CHPMBGHOEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int KECPKLHBJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int DBHBCMIEDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T IGECHFPLLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T JMCIAPDCICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer JOFEBBPBCBA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BPODBOELFJH BALDEMOMOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x401D610", Offset = "0x401C610", VA = "0x18401D610")]
			get
			{
				return default(BPODBOELFJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T EIIMOHAMCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3CCBDC0", Offset = "0x3CCADC0", VA = "0x183CCBDC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x401D810", Offset = "0x401C810", VA = "0x18401D810")]
		public FONFIIEGEGC(NativeArray<T>.ReadOnly CHPMBGHOEJI, TComparer JOFEBBPBCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x401D620", Offset = "0x401C620", VA = "0x18401D620")]
		public bool IFOGALALJEO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x31455D0", Offset = "0x31445D0", VA = "0x1831455D0")]
	public static HKLJCHOAOJE<T> FLONFIIJDHB<T>(this NativeArray<T> CHPMBGHOEJI) where T : struct
	{
		return default(HKLJCHOAOJE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface IINJEOMDEGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DPBAJKMAAIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IFDDGABCEIM<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IPFPHDGFDEB : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public IFDDGABCEIM<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA17190", Offset = "0xA16190", VA = "0x180A17190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4050B70", Offset = "0x404FB70", VA = "0x184050B70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public IPFPHDGFDEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x437E1B0", Offset = "0x437D1B0", VA = "0x18437E1B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x437E390", Offset = "0x437D390", VA = "0x18437E390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> EOMNGEIOHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream DONEMIPDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream OBHMDNJNHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf DPNCJOLAJOK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int AAOLGFOFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x42F6770", Offset = "0x42F5770", VA = "0x1842F6770", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x42F67B0", Offset = "0x42F57B0", VA = "0x1842F67B0", Slot = "4")]
	[IteratorStateMachine(typeof(IFDDGABCEIM<>.IPFPHDGFDEB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x42F68B0", Offset = "0x42F58B0", VA = "0x1842F68B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct KDHAHOGFDOK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] CNIEHBMANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf DPNCJOLAJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream DONEMIPDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream FIOPNDDEOKA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x466DFF0", Offset = "0x466CFF0", VA = "0x18466DFF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JBBLJCEMGAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream DONEMIPDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream OBHMDNJNHHJ;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB90A0", Offset = "0x6FB80A0", VA = "0x186FB90A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct IOMGICODGNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] CNIEHBMANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream DONEMIPDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream FIOPNDDEOKA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8F80", Offset = "0x6FB7F80", VA = "0x186FB8F80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PENDFJMIAOI
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class EKNANFKBKAO
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum ELEAKLMKAFB
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
internal static class GMBOPICAHFA
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OBMFEFCOIEE
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OBMFEFCOIEE()
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
