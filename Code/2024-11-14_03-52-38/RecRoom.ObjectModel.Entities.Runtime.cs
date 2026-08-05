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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E64170", Offset = "0x6E63570", VA = "0x186E64170")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KNIPNMIAPFI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FHHOGCBMPHG NGNLAGNHLDF
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
public interface FDIPIADCODJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGDBGAJDFLE(Entity FEMCIAKBEIF, object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIMMHCOICJK(Entity FEMCIAKBEIF, object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNEJOCHKFGC(Entity FEMCIAKBEIF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EAMKOONHGHM<TComponentData, TValue> : LNPKMNMGCFB<TValue>, IDisposable where TComponentData : struct, KNIPNMIAPFI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class MFEDCKCKPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> PBBPHMMFLFN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int AHBPDFJLDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x38CC630", Offset = "0x38CBA30", VA = "0x1838CC630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x485A620", Offset = "0x4859A20", VA = "0x18485A620")]
		public bool HBJFFOFPOJO([Out] TValue PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x485A460", Offset = "0x4859860", VA = "0x18485A460")]
		public void FNBCENOGBNB(object CFGHNHCDKCN, TValue PFKKDHPJFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x485A3B0", Offset = "0x48597B0", VA = "0x18485A3B0")]
		public bool BIJNEFLCHFA(object CFGHNHCDKCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x485A540", Offset = "0x4859940", VA = "0x18485A540")]
		public int GEKFBAGACOL(object CFGHNHCDKCN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x485A730", Offset = "0x4859B30", VA = "0x18485A730")]
		public MFEDCKCKPAO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<MFEDCKCKPAO> LFJJGFEDBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private JEMEPMKCLAO<FHHOGCBMPHG, MFEDCKCKPAO> EGNJGNPDFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager FINHDKAKKGK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B654C0", Offset = "0x3B648C0", VA = "0x183B654C0")]
	public EAMKOONHGHM(EntityManager FINHDKAKKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3B64C80", Offset = "0x3B64080", VA = "0x183B64C80", Slot = "4")]
	public void EGDBGAJDFLE(Entity FEMCIAKBEIF, object CFGHNHCDKCN, TValue PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3B65050", Offset = "0x3B64450", VA = "0x183B65050", Slot = "5")]
	public bool LIMMHCOICJK(Entity FEMCIAKBEIF, object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3B64E00", Offset = "0x3B64200", VA = "0x183B64E00", Slot = "6")]
	public bool HBJFFOFPOJO(Entity FEMCIAKBEIF, [Out] TValue PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B64C60", Offset = "0x3B64060", VA = "0x183B64C60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B65400", Offset = "0x3B64800", VA = "0x183B65400")]
	private void OCAOKJMDCCA(MFEDCKCKPAO MHHFLPIGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B65340", Offset = "0x3B64740", VA = "0x183B65340")]
	private bool NFHFFCOJPEF(Entity FEMCIAKBEIF, [Out] FHHOGCBMPHG DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3B65240", Offset = "0x3B64640", VA = "0x183B65240")]
	private void LOFFPDEBOIB(Entity FEMCIAKBEIF, FHHOGCBMPHG DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3B64F10", Offset = "0x3B64310", VA = "0x183B64F10")]
	private bool KCLPDNHFJIJ(FHHOGCBMPHG DOBBMOLDHPN, [Out] MFEDCKCKPAO MHHFLPIGOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3B64F30", Offset = "0x3B64330", VA = "0x183B64F30")]
	private MFEDCKCKPAO KMEJDPPOIBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LNPKMNMGCFB<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGDBGAJDFLE(Entity FEMCIAKBEIF, object CFGHNHCDKCN, TValue PFKKDHPJFEH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LIMMHCOICJK(Entity FEMCIAKBEIF, object CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBJFFOFPOJO(Entity FEMCIAKBEIF, [Out] TValue PFKKDHPJFEH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FHHOGCBMPHG : FLCBANDPIBK, IEquatable<FHHOGCBMPHG>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly FHHOGCBMPHG EPPAKPACCLK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int DIJEOHGLGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x974190", Offset = "0x973590", VA = "0x180974190", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC8A120", Offset = "0xC89520", VA = "0x180C8A120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LJMJPEBFKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x283D840", Offset = "0x283CC40", VA = "0x18283D840", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60E85D0", Offset = "0x60E79D0", VA = "0x1860E85D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E64190", Offset = "0x6E63590", VA = "0x186E64190", Slot = "8")]
	public bool Equals(FHHOGCBMPHG OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E641E0", Offset = "0x6E635E0", VA = "0x186E641E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LOAOFGIMGJM<THasTokensTag> : FDIPIADCODJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, FHHOGCBMPHG> HFJKNADHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> LFJJGFEDBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private JEMEPMKCLAO<FHHOGCBMPHG, HashSet<object>> EGNJGNPDFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager FINHDKAKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem NADGJNIEIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool AAFPLDAFGFB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4684AF0", Offset = "0x4683EF0", VA = "0x184684AF0")]
	public LOAOFGIMGJM(EntityManager FINHDKAKKGK, EntityCommandBufferSystem NADGJNIEIDL, LDGDBHIGNCI APHMJGFGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x46821A0", Offset = "0x46815A0", VA = "0x1846821A0", Slot = "4")]
	public bool EGDBGAJDFLE(Entity FEMCIAKBEIF, object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x46837F0", Offset = "0x4682BF0", VA = "0x1846837F0", Slot = "5")]
	public bool LIMMHCOICJK(Entity FEMCIAKBEIF, object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4683240", Offset = "0x4682640", VA = "0x184683240", Slot = "6")]
	public bool KNEJOCHKFGC(Entity FEMCIAKBEIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x46833A0", Offset = "0x46827A0", VA = "0x1846833A0", Slot = "8")]
	public bool KNEJOCHKFGC(FHHOGCBMPHG DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4681CA0", Offset = "0x46810A0", VA = "0x184681CA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4684610", Offset = "0x4683A10", VA = "0x184684610")]
	private void OCAOKJMDCCA(HashSet<object> MHHFLPIGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4684240", Offset = "0x4683640", VA = "0x184684240")]
	private bool NFHFFCOJPEF(Entity FEMCIAKBEIF, [Out] FHHOGCBMPHG DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46843D0", Offset = "0x46837D0", VA = "0x1846843D0")]
	private bool NGIKMBDHKAF(Entity FEMCIAKBEIF, [Out] FHHOGCBMPHG DOBBMOLDHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4682D60", Offset = "0x4682160", VA = "0x184682D60")]
	private void KABNGPANNIA(Entity FEMCIAKBEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4681EA0", Offset = "0x46812A0", VA = "0x184681EA0")]
	private void EGCNDAOEOAF(Entity FEMCIAKBEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4683E90", Offset = "0x4683290", VA = "0x184683E90")]
	private void MDDNFGAALCH(Entity FEMCIAKBEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4683CE0", Offset = "0x46830E0", VA = "0x184683CE0")]
	private void LOFFPDEBOIB(Entity FEMCIAKBEIF, FHHOGCBMPHG DOBBMOLDHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4682940", Offset = "0x4681D40", VA = "0x184682940")]
	private bool JJLAGCKEAHF(FHHOGCBMPHG DOBBMOLDHPN, [Out] HashSet<object> MHHFLPIGOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4682E60", Offset = "0x4682260", VA = "0x184682E60")]
	private HashSet<object> KMEJDPPOIBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JJHFDKDHOAL
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DCJNPEHFDGA : IIBFDONBOJD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E64160", Offset = "0x6E63560", VA = "0x186E64160")]
	public float FDJCPDHFHJB([In] float3 PFKKDHPJFEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E64160", Offset = "0x6E63560", VA = "0x186E64160", Slot = "4")]
	private float AJNNADMOKHO([In] float3 PFKKDHPJFEH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MGADPBJCIIG : IIBFDONBOJD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E64600", Offset = "0x6E63A00", VA = "0x186E64600")]
	public float FDJCPDHFHJB([In] float3 PFKKDHPJFEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E64600", Offset = "0x6E63A00", VA = "0x186E64600", Slot = "4")]
	private float AJNNADMOKHO([In] float3 PFKKDHPJFEH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ACOKEKGPIBI : IIBFDONBOJD<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xA0A1C0", Offset = "0xA095C0", VA = "0x180A0A1C0")]
	public float FDJCPDHFHJB([In] float3 PFKKDHPJFEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xA0A1C0", Offset = "0xA095C0", VA = "0x180A0A1C0", Slot = "4")]
	private float AJNNADMOKHO([In] float3 PFKKDHPJFEH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BMFMEOKOMPM : IIBFDONBOJD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A371B0", Offset = "0x1A365B0", VA = "0x181A371B0")]
	public int FDJCPDHFHJB([In] int3 PFKKDHPJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1A371B0", Offset = "0x1A365B0", VA = "0x181A371B0", Slot = "4")]
	private int MPHDNHHNABG([In] int3 PFKKDHPJFEH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EAAIJEIJKBE : IIBFDONBOJD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7D70", Offset = "0x6AD7170", VA = "0x186AD7D70")]
	public int FDJCPDHFHJB([In] int3 PFKKDHPJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7D70", Offset = "0x6AD7170", VA = "0x186AD7D70", Slot = "4")]
	private int MPHDNHHNABG([In] int3 PFKKDHPJFEH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct APIEGHCHIDE : IIBFDONBOJD<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x9EE170", Offset = "0x9ED570", VA = "0x1809EE170")]
	public int FDJCPDHFHJB([In] int3 PFKKDHPJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9EE170", Offset = "0x9ED570", VA = "0x1809EE170", Slot = "4")]
	private int MPHDNHHNABG([In] int3 PFKKDHPJFEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LKDHAAHLABG : KHDMNEKENHC
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
	public LKDHAAHLABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PCJFGGCOPLO : SystemBase, IDGOFCAEAFM
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E64E70", Offset = "0x6E64270", VA = "0x186E64E70")]
	public JobHandle HLLPOAMBPOA(ReadOnlySpan<int> IALLJADKBIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x309A640", Offset = "0x3099A40", VA = "0x18309A640")]
	public void CJEPGALAKFL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x309A2C0", Offset = "0x30996C0", VA = "0x18309A2C0")]
	public JobHandle CJEPGALAKFL<T>(JobHandle DOBBMOLDHPN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E64DE0", Offset = "0x6E641E0", VA = "0x186E64DE0")]
	public JobHandle CJEPGALAKFL(ReadOnlySpan<int> IALLJADKBIE, JobHandle DOBBMOLDHPN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x309ACF0", Offset = "0x309A0F0", VA = "0x18309ACF0")]
	public JobHandle HNHJJMBOELE<T>(JobHandle DOBBMOLDHPN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E64D20", Offset = "0x6E64120", VA = "0x186E64D20")]
	public ComponentDataFromEntity AKCDDGNFPMD(int NBFPJBGNDFK, bool NJJAAHMCKCP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E64E50", Offset = "0x6E64250", VA = "0x186E64E50")]
	public EntityExistenceLookupByEntity FKHCHBPPCEF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E64EC0", Offset = "0x6E642C0", VA = "0x186E64EC0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
	protected PCJFGGCOPLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class GCGPIDDCJJJ : PCJFGGCOPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E64230", Offset = "0x6E63630", VA = "0x186E64230", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
	protected GCGPIDDCJJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LMPIPJGFAFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class BNGFGLJONED : EntityCommandBufferSystem, IDGOFCAEAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
	protected BNGFGLJONED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IIBFDONBOJD<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo FDJCPDHFHJB([In] TFrom PFKKDHPJFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HBFJMOMDEKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMLJONGOBCJ(T PFKKDHPJFEH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct KKFFDAJPGEF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> BDGHJJGGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer LNEFCGGJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes MLKNBKJFGFO;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E64510", Offset = "0x6E63910", VA = "0x186E64510", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct MGIGEBPCPPJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> BDGHJJGGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer LNEFCGGJECJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E64610", Offset = "0x6E63A10", VA = "0x186E64610", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct JEDEKCMHBPF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> BDGHJJGGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer LNEFCGGJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType JPBKOHOBNFL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E64300", Offset = "0x6E63700", VA = "0x186E64300", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct JPDKPHOEBBN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> BDGHJJGGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> EIFGKHNPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer LNEFCGGJECJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4446B90", Offset = "0x4445F90", VA = "0x184446B90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct GJBJGDPOPMC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> BDGHJJGGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> MHFHLBKJCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer LNEFCGGJECJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct PMFCMJGFIEL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> BDGHJJGGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T PFKKDHPJFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer LNEFCGGJECJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4B42F30", Offset = "0x4B42330", VA = "0x184B42F30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct AFOJBIEBMEO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IIBFDONBOJD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> KMIOFBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> JCMCPJCDLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap LLIKOHELCCA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct JHIOFAKJAOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity NPCIDMENFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> KMIOFBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> JCMCPJCDLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int AKPFFLPJLKJ;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E64380", Offset = "0x6E63780", VA = "0x186E64380", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct CHPEDCCOIEK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BLOIFOBNHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> KMIOFBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> POEJEJFPFJN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct DMNKCCKAAJB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IIBFDONBOJD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> IJGJGGPMEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> JCMCPJCDLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap LLIKOHELCCA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct OLHGPDIHCHA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HOMOMBDMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> GPENPKKAPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> GLPFIDHAOEE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct KMNPDGKDNJO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HOMOMBDMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> GPENPKKAPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> GLPFIDHAOEE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4530080", Offset = "0x452F480", VA = "0x184530080", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct KAFJJLHEHID<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> KMIOFBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> POEJEJFPFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> GPAEPPMNJEB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x44EDA10", Offset = "0x44ECE10", VA = "0x1844EDA10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct CEDOALJLPKJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : IIBFDONBOJD<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> KMIOFBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> POEJEJFPFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> GPAEPPMNJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap LLIKOHELCCA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct PJOKFKEAIGP<T, TPredicate> : IJob where T : struct where TPredicate : struct, HBFJMOMDEKA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> KMIOFBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> ICLJGHAMJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> AAGOFKECJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate LLIKOHELCCA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct LKKCCKNEEJH<T, TPredicate> : IJob where T : struct where TPredicate : struct, HBFJMOMDEKA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> KMIOFBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> POEJEJFPFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate LLIKOHELCCA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JLJLAOCLIHD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity HOMOMBDMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> GPENPKKAPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> MCBFHBCLBFO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E64480", Offset = "0x6E63880", VA = "0x186E64480", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct IDOFDDOAOFH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity HOMOMBDMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> GPENPKKAPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> MCBFHBCLBFO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E64260", Offset = "0x6E63660", VA = "0x186E64260", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KCNOKAJGDIC
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JMMLOJBNFHE
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F45760", Offset = "0x2F44B60", VA = "0x182F45760")]
	public static bool BBGOBEJOGLL<T>(this NativeArray<Entity> GPENPKKAPEO, EntityManager FINHDKAKKGK, Allocator DBCOPEDFGJL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AGKHANBNDNF
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AGBPFKJCMEF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public AGBPFKJCMEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class IOPOLPGAJJO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public IOPOLPGAJJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> NPKKNKBCMKO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E64090", Offset = "0x6E63490", VA = "0x186E64090")]
	public AGKHANBNDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FKCCMNGPKBH
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DCDGEJHKBGB
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct LCDEAEGKPCC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct FJLNFLBLEDC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal LCDEAEGKPCC<TFrom> EGIKLIBGODG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> DPJCEEDGHJL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct BKLNFCDFMBA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct MFBGLAJIPHO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal BKLNFCDFMBA<TFrom> EGIKLIBGODG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> DPJCEEDGHJL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct NMNIEKKKPGL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct AIFCPCFODNB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal NMNIEKKKPGL<TFrom> EGIKLIBGODG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> DPJCEEDGHJL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct FCKFNNJEJGE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct DEPAKOLGMEO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal FCKFNNJEJGE<TFrom> EGIKLIBGODG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> DPJCEEDGHJL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MMEOHAGCHND
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KKCLFFAJAEM
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F75F10", Offset = "0x2F75310", VA = "0x182F75F10")]
	public static NativeList<T> DIPHNIMKGMI<T>(this NativeArray<T> CIILLNJOCMG, Allocator DBCOPEDFGJL = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BLOHANEHGAN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NIDLCFOEJBN
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x303F3C0", Offset = "0x303E7C0", VA = "0x18303F3C0")]
	[PBAFDGCCPAM]
	public static JobHandle OPAHCAGKEPA<T>(this EntityCommandBufferSystem NADGJNIEIDL, NativeArrayAsync<Entity> BDGHJJGGAEJ, NativeArrayAsync<T> EIFGKHNPLEK, [Optional] JobHandle LPNBPKOGNNL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x303F670", Offset = "0x303EA70", VA = "0x18303F670")]
	[PBAFDGCCPAM]
	public static JobHandle OPAHCAGKEPA<T>(this EntityCommandBufferSystem NADGJNIEIDL, NativeArrayAsync<Entity> BDGHJJGGAEJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x303F540", Offset = "0x303E940", VA = "0x18303F540")]
	[PBAFDGCCPAM]
	public static JobHandle OPAHCAGKEPA<T>(this EntityCommandBufferSystem NADGJNIEIDL, NativeArray<Entity> BDGHJJGGAEJ, [Optional] JobHandle LPNBPKOGNNL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E64920", Offset = "0x6E63D20", VA = "0x186E64920")]
	[PBAFDGCCPAM]
	public static JobHandle OPAHCAGKEPA(this EntityCommandBufferSystem NADGJNIEIDL, NativeArray<Entity> BDGHJJGGAEJ, ComponentTypes MLKNBKJFGFO, [Optional] JobHandle LPNBPKOGNNL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E647D0", Offset = "0x6E63BD0", VA = "0x186E647D0")]
	[PBAFDGCCPAM]
	public static JobHandle OPAHCAGKEPA(this EntityCommandBufferSystem NADGJNIEIDL, EntityCommandBuffer LNEFCGGJECJ, NativeArray<Entity> BDGHJJGGAEJ, ComponentTypes MLKNBKJFGFO, [Optional] JobHandle LPNBPKOGNNL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LOFMDJGKOOB
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6570", Offset = "0x2FA5970", VA = "0x182FA6570")]
	[PBAFDGCCPAM]
	public static JobHandle MGIGFBDMHEF<T>(this EntityCommandBufferSystem NADGJNIEIDL, EntityCommandBuffer LNEFCGGJECJ, EntityQuery AEJCGNJPPND, T PFKKDHPJFEH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NJIOFJHJEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E64B90", Offset = "0x6E63F90", VA = "0x186E64B90")]
	[PBAFDGCCPAM]
	public static JobHandle KBOAAFEHBEG(this EntityCommandBufferSystem NADGJNIEIDL, NativeList<Entity> BDGHJJGGAEJ, [Optional] JobHandle LPNBPKOGNNL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E64A90", Offset = "0x6E63E90", VA = "0x186E64A90")]
	[PBAFDGCCPAM]
	public static JobHandle KBOAAFEHBEG(this EntityCommandBufferSystem NADGJNIEIDL, NativeArrayAsync<Entity> BDGHJJGGAEJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EHHFAAEHHOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class OAJEDNLCGHJ
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x30837D0", Offset = "0x3082BD0", VA = "0x1830837D0")]
	[PBAFDGCCPAM]
	public static JobHandle CNBNBJIGPOB<T>(this EntityCommandBufferSystem NADGJNIEIDL, NativeArray<Entity> BDGHJJGGAEJ, NativeArray<T> EIFGKHNPLEK, JobHandle LPNBPKOGNNL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ODEPECAGBIJ
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x30863B0", Offset = "0x30857B0", VA = "0x1830863B0")]
	[PBAFDGCCPAM]
	public static JobHandle MAFIELDBHNC<T>(this EntityCommandBufferSystem NADGJNIEIDL, NativeArray<Entity> BDGHJJGGAEJ, T PFKKDHPJFEH, [Optional] JobHandle LPNBPKOGNNL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x30862D0", Offset = "0x30856D0", VA = "0x1830862D0")]
	[PBAFDGCCPAM]
	public static JobHandle MAFIELDBHNC<T>(this EntityCommandBufferSystem NADGJNIEIDL, EntityCommandBuffer LNEFCGGJECJ, NativeArray<Entity> BDGHJJGGAEJ, T PFKKDHPJFEH, [Optional] JobHandle LPNBPKOGNNL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LMDJNNNHGBE
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PEAOKOPAFGK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x309BFA0", Offset = "0x309B3A0", VA = "0x18309BFA0")]
	public static NativeArray<T> FEPBCKHLJDD<T>(this NativeList<Entity> CIILLNJOCMG, EntityManager FINHDKAKKGK, Allocator DBCOPEDFGJL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x309BA00", Offset = "0x309AE00", VA = "0x18309BA00")]
	public static NativeArray<T> FEPBCKHLJDD<T>(this NativeArray<Entity> CIILLNJOCMG, EntityManager FINHDKAKKGK, Allocator DBCOPEDFGJL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E64ED0", Offset = "0x6E642D0", VA = "0x186E64ED0")]
	public static NativeArray<Entity> DMPDBIGLPFD(this NativeArray<Entity> CIILLNJOCMG, EntityManager FINHDKAKKGK, ComponentType JPBKOHOBNFL, Allocator DBCOPEDFGJL = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x309C070", Offset = "0x309B470", VA = "0x18309C070")]
	public static NativeArray<T> GPKMIHLNPOC<T>(this NativeArray<Entity> CIILLNJOCMG, EntityManager FINHDKAKKGK, Allocator DBCOPEDFGJL = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MGBFDCEPHEI
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct OGBCICBLGPF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct CEGNHKDDJHC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public OGBCICBLGPF<TFrom> DPJCEEDGHJL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> KMIOFBFEAAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct LICBHMDEPKK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct CCFHNLELCMN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public LICBHMDEPKK<TFrom> DPJCEEDGHJL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> KMIOFBFEAAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DCHCHNFDHNP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct GMNJPOPJIMF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public DCHCHNFDHNP<TFrom> DPJCEEDGHJL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> KMIOFBFEAAD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JGEHPBNCOFL
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class NELDMCLBJJM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct IJGNPGEOFOE : IIBFDONBOJD<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> JNMNBGBDMAE;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E642F0", Offset = "0x6E636F0", VA = "0x186E642F0")]
		[BurstCompatible]
		public Entity FDJCPDHFHJB([In] Entity PFKKDHPJFEH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E642F0", Offset = "0x6E636F0", VA = "0x186E642F0", Slot = "4")]
		private Entity INKKOGHMOBK([In] Entity PFKKDHPJFEH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GIFJFPDICIP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct KPIOAELDBDG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> ICLJGHAMJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> KMIOFBFEAAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct NGOCAHHDCFI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> ICLJGHAMJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> KMIOFBFEAAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct DFBCOPAAKLJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> ICLJGHAMJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> KMIOFBFEAAD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class LPNNDGLHJIK
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class ABPDJOMHPDB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct DFHHLMALHFO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> KMIOFBFEAAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct CJKHKCLFPOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> KMIOFBFEAAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct KIAMCKGNOPP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> KMIOFBFEAAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct CKGBEEAAEON<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator DBCOPEDFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> KMIOFBFEAAD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class PNCPANPLKAM
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class BCLFGHNEBBO
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2C46970", Offset = "0x2C45D70", VA = "0x182C46970")]
	public static NativeList<Entity> FKBIKCFODCA<T>(this NativeArray<Entity> GPENPKKAPEO, EntityManager FINHDKAKKGK, Allocator DBCOPEDFGJL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FLPCHDGANFB
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class AHKMAFCGFJE
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct CKMANNEGBHP<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> EFKOIGFMOHD;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
		public CKMANNEGBHP(NativeArray<TSrc> EFKOIGFMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public MCLJIDFMFNP<TSrc, TValue> MDHGFPENHGG<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(MCLJIDFMFNP<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct MCLJIDFMFNP<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> EFKOIGFMOHD;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
		public MCLJIDFMFNP(NativeArray<TSrc> EFKOIGFMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public BDHMEAKFLCP<TSrc, TValue, TSelector> DHIJGOLDGBP<TSelector>() where TSelector : struct, IIBFDONBOJD<TSrc, TValue>
		{
			return default(BDHMEAKFLCP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct BDHMEAKFLCP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IIBFDONBOJD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> EFKOIGFMOHD;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
		public BDHMEAKFLCP(NativeArray<TSrc> EFKOIGFMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x522DF60", Offset = "0x522D360", VA = "0x18522DF60")]
		public BBCNIJBLLGJ<TSrc, TValue, TSelector> FEJIOADPGHL()
		{
			return default(BBCNIJBLLGJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EEPPGLDKBLL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, IIBFDONBOJD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> EFKOIGFMOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector AMEBNJELHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int OBFJPFHENMC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x3B95400", Offset = "0x3B94800", VA = "0x183B95400")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int DIJEOHGLGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA02AE0", Offset = "0xA01EE0", VA = "0x180A02AE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int OCLEKHGCIDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2273940", Offset = "0x2272D40", VA = "0x182273940")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3B955E0", Offset = "0x3B949E0", VA = "0x183B955E0")]
		public EEPPGLDKBLL(NativeArray<TSrc> EFKOIGFMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3B95440", Offset = "0x3B94840", VA = "0x183B95440")]
		public bool KPJEAMDBMKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3B954E0", Offset = "0x3B948E0", VA = "0x183B954E0")]
		private TSrc PAFGPLDJMFD(int CLDPBDGHEDO)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3B95450", Offset = "0x3B94850", VA = "0x183B95450")]
		private TValue OENHGNEBMJO()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct BBCNIJBLLGJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IIBFDONBOJD<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private EEPPGLDKBLL<TSrc, TValue, TSelector> JDBDGAKCPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue AJEJLJHBEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int PNGCLOMDHAJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OJHMBNDHAOH JJKHCBMFLGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5217670", Offset = "0x5216A70", VA = "0x185217670")]
			get
			{
				return default(OJHMBNDHAOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue ACMDPDJICEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, OJHMBNDHAOH range) LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x52176B0", Offset = "0x5216AB0", VA = "0x1852176B0")]
			get
			{
				return default((TValue, OJHMBNDHAOH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5217900", Offset = "0x5216D00", VA = "0x185217900")]
		public BBCNIJBLLGJ(NativeArray<TSrc> EFKOIGFMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xDB7E90", Offset = "0xDB7290", VA = "0x180DB7E90")]
		public BBCNIJBLLGJ<TSrc, TValue, TSelector> EDIPCEILGGF()
		{
			return default(BBCNIJBLLGJ<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5217780", Offset = "0x5216B80", VA = "0x185217780")]
		public bool KPJEAMDBMKH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x35C71D0", Offset = "0x35C65D0", VA = "0x1835C71D0")]
	public static CKMANNEGBHP<T> KJEFJHCEDMO<T>(this NativeList<T> PBBPHMMFLFN) where T : struct
	{
		return default(CKMANNEGBHP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
	public static CKMANNEGBHP<T> KJEFJHCEDMO<T>(this NativeArray<T> EFKOIGFMOHD) where T : struct
	{
		return default(CKMANNEGBHP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class JIGLOFJFMHC
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct DEENHFFHPCM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly EFKOIGFMOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int PNGCLOMDHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int EIPLNACNPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T AJEJLJHBEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T LLPJGOAOABC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OJHMBNDHAOH JJKHCBMFLGP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3FDD000", Offset = "0x3FDC400", VA = "0x183FDD000")]
			get
			{
				return default(OJHMBNDHAOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T ACMDPDJICEI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3C0C940", Offset = "0x3C0BD40", VA = "0x183C0C940")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, OJHMBNDHAOH) LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5BEA240", Offset = "0x5BE9640", VA = "0x185BEA240")]
			get
			{
				return default((T, OJHMBNDHAOH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA7A0", Offset = "0x5BE9BA0", VA = "0x185BEA7A0")]
		public DEENHFFHPCM(NativeArray<T> EFKOIGFMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA3B0", Offset = "0x5BE97B0", VA = "0x185BEA3B0")]
		public DEENHFFHPCM<T> EDIPCEILGGF()
		{
			return default(DEENHFFHPCM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA5C0", Offset = "0x5BE99C0", VA = "0x185BEA5C0")]
		public bool KPJEAMDBMKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2DCDC10", Offset = "0x2DCD010", VA = "0x182DCDC10")]
		public AFOCBJIBEDG<T, TComparer> HGBODGGPLPL<TComparer>([Optional] TComparer MNKANCJLDCI) where TComparer : struct, IEqualityComparer<T>
		{
			return default(AFOCBJIBEDG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct AFOCBJIBEDG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly EFKOIGFMOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int PNGCLOMDHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int EIPLNACNPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T AJEJLJHBEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T LLPJGOAOABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer MNKANCJLDCI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OJHMBNDHAOH JJKHCBMFLGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3FDD000", Offset = "0x3FDC400", VA = "0x183FDD000")]
			get
			{
				return default(OJHMBNDHAOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T ACMDPDJICEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3C0C940", Offset = "0x3C0BD40", VA = "0x183C0C940")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD1F0", Offset = "0x3FDC5F0", VA = "0x183FDD1F0")]
		public AFOCBJIBEDG(NativeArray<T>.ReadOnly EFKOIGFMOHD, TComparer MNKANCJLDCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD010", Offset = "0x3FDC410", VA = "0x183FDD010")]
		public bool KPJEAMDBMKH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B560", Offset = "0x2F3A960", VA = "0x182F3B560")]
	public static DEENHFFHPCM<T> FEJIOADPGHL<T>(this NativeArray<T> EFKOIGFMOHD) where T : struct
	{
		return default(DEENHFFHPCM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface EKNGFPHAJAJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class KFAOJAIHAMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct DPEDAOKBOKG<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class KIDBNEIPKAP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public DPEDAOKBOKG<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x96D130", Offset = "0x96C530", VA = "0x18096D130", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F894E0", Offset = "0x3F888E0", VA = "0x183F894E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
		[DebuggerHidden]
		public KIDBNEIPKAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x45226D0", Offset = "0x4521AD0", VA = "0x1845226D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x45228A0", Offset = "0x4521CA0", VA = "0x1845228A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> EMLPENJJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream OPCCBOKDELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream FPAEMJFNIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf MMGNDBIPIEK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E850", Offset = "0x5C1DC50", VA = "0x185C1E850", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E890", Offset = "0x5C1DC90", VA = "0x185C1E890", Slot = "4")]
	[IteratorStateMachine(typeof(DPEDAOKBOKG<>.KIDBNEIPKAP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E990", Offset = "0x5C1DD90", VA = "0x185C1E990", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct APPNAJAGPCA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] GMKBBDEHIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf MMGNDBIPIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream OPCCBOKDELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream HEPDMNDPKID;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x43137B0", Offset = "0x4312BB0", VA = "0x1843137B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct DBIPILFGMOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream OPCCBOKDELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream FPAEMJFNIIO;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E64120", Offset = "0x6E63520", VA = "0x186E64120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct MIPAGCEJAKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] GMKBBDEHIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream OPCCBOKDELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream HEPDMNDPKID;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E646B0", Offset = "0x6E63AB0", VA = "0x186E646B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JPAIBENANHO
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class KLNMMHPNKAI
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum KEOCFDNJBMA
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
internal static class HJEPGIKKOFA
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DHPHBMGKPAN
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DHPHBMGKPAN()
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
