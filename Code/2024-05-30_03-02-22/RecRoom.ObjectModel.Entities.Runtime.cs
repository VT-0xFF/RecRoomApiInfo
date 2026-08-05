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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x64D1B00", Offset = "0x64D0D00", VA = "0x1864D1B00")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AOFBKMLMKHO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PIHIHJEBCFM FMNNEPFGFID
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
public interface ODLKGIEHKBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PEHMCMFNHPH(Entity FOJNONDDGDN, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMMLGJJHEEH(Entity FOJNONDDGDN, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MIAMDHAMFBE(Entity FOJNONDDGDN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EILPGFBIALA(Entity FOJNONDDGDN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LLFAGGIOJJH<TComponentData, TValue> : NEFFNMOCFIC<TValue>, IDisposable where TComponentData : struct, AOFBKMLMKHO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class IDCDHLOCBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> AIMBMINBCPM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int HJGLMCCDDEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x335AF10", Offset = "0x335A110", VA = "0x18335AF10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B054D0", Offset = "0x3B046D0", VA = "0x183B054D0")]
		public bool ONANLKJGCLO([Out] TValue HLCKBKFCMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B05420", Offset = "0x3B04620", VA = "0x183B05420")]
		public void LGLNKEHGBKE(object CEFPPEHCFCF, TValue HLCKBKFCMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B052C0", Offset = "0x3B044C0", VA = "0x183B052C0")]
		public bool BIFLKBKPGJE(object CEFPPEHCFCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B05340", Offset = "0x3B04540", VA = "0x183B05340")]
		public int ELBMHLBJKOF(object CEFPPEHCFCF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B055A0", Offset = "0x3B047A0", VA = "0x183B055A0")]
		public IDCDHLOCBDI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<IDCDHLOCBDI> COAPAKPAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private FACBJDPHHMI<PIHIHJEBCFM, IDCDHLOCBDI> OLBNGCFMBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager CAODHPOMABB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F66500", Offset = "0x3F65700", VA = "0x183F66500")]
	public LLFAGGIOJJH(EntityManager CAODHPOMABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F663E0", Offset = "0x3F655E0", VA = "0x183F663E0", Slot = "4")]
	public void PEHMCMFNHPH(Entity FOJNONDDGDN, object CEFPPEHCFCF, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F66000", Offset = "0x3F65200", VA = "0x183F66000", Slot = "5")]
	public bool GMMLGJJHEEH(Entity FOJNONDDGDN, object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F66300", Offset = "0x3F65500", VA = "0x183F66300", Slot = "6")]
	public bool ONANLKJGCLO(Entity FOJNONDDGDN, [Out] TValue HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F65FE0", Offset = "0x3F651E0", VA = "0x183F65FE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3F66270", Offset = "0x3F65470", VA = "0x183F66270")]
	private void NGFALPLLICB(IDCDHLOCBDI OLLIMPCFODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F66190", Offset = "0x3F65390", VA = "0x183F66190")]
	private bool HAOPAPLJNFF(Entity FOJNONDDGDN, [Out] PIHIHJEBCFM DHPHAFDDMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F65F00", Offset = "0x3F65100", VA = "0x183F65F00")]
	private void BIFAGCNLKDP(Entity FOJNONDDGDN, PIHIHJEBCFM DHPHAFDDMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F66250", Offset = "0x3F65450", VA = "0x183F66250")]
	private bool MDMHAMCJCOF(PIHIHJEBCFM DHPHAFDDMEE, [Out] IDCDHLOCBDI OLLIMPCFODF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F65E20", Offset = "0x3F65020", VA = "0x183F65E20")]
	private IDCDHLOCBDI AKPNFBCFGDB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NEFFNMOCFIC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEHMCMFNHPH(Entity FOJNONDDGDN, object CEFPPEHCFCF, TValue HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMMLGJJHEEH(Entity FOJNONDDGDN, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ONANLKJGCLO(Entity FOJNONDDGDN, [Out] TValue HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PIHIHJEBCFM : OPLAPEEBMGF, IEquatable<PIHIHJEBCFM>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly PIHIHJEBCFM LCFMFCBHMEC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BAGLMBHIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x24131E0", Offset = "0x24123E0", VA = "0x1824131E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5819400", Offset = "0x5818600", VA = "0x185819400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x64D2720", Offset = "0x64D1920", VA = "0x1864D2720", Slot = "8")]
	public bool Equals(PIHIHJEBCFM JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x64D2770", Offset = "0x64D1970", VA = "0x1864D2770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JAFHJGKPNNE<THasTokensTag> : ODLKGIEHKBM, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LBOEGNBEJHN AMPJEKFBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, PIHIHJEBCFM> DMDBCPDGKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> COAPAKPAJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private FACBJDPHHMI<PIHIHJEBCFM, HashSet<object>> OLBNGCFMBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager CAODHPOMABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem PENMCEINNIN;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0BD0", Offset = "0x3CDFDD0", VA = "0x183CE0BD0")]
	public JAFHJGKPNNE(EntityManager CAODHPOMABB, EntityCommandBufferSystem PENMCEINNIN, LBOEGNBEJHN EJCFDGJMAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3CE04F0", Offset = "0x3CDF6F0", VA = "0x183CE04F0", Slot = "4")]
	public bool PEHMCMFNHPH(Entity FOJNONDDGDN, object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CDE500", Offset = "0x3CDD700", VA = "0x183CDE500", Slot = "5")]
	public bool GMMLGJJHEEH(Entity FOJNONDDGDN, object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3CDFED0", Offset = "0x3CDF0D0", VA = "0x183CDFED0", Slot = "6")]
	public bool MIAMDHAMFBE(Entity FOJNONDDGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0000", Offset = "0x3CDF200", VA = "0x183CE0000", Slot = "9")]
	public bool MIAMDHAMFBE(PIHIHJEBCFM DHPHAFDDMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CDDFE0", Offset = "0x3CDD1E0", VA = "0x183CDDFE0", Slot = "7")]
	public bool EILPGFBIALA(Entity FOJNONDDGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3CDDC90", Offset = "0x3CDCE90", VA = "0x183CDDC90", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0330", Offset = "0x3CDF530", VA = "0x183CE0330")]
	private void NGFALPLLICB(HashSet<object> OLLIMPCFODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF0B0", Offset = "0x3CDE2B0", VA = "0x183CDF0B0")]
	private bool HAOPAPLJNFF(Entity FOJNONDDGDN, [Out] PIHIHJEBCFM DHPHAFDDMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3CDECC0", Offset = "0x3CDDEC0", VA = "0x183CDECC0")]
	private bool GNLCMGNCPBM(Entity FOJNONDDGDN, [Out] PIHIHJEBCFM DHPHAFDDMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3CDFCD0", Offset = "0x3CDEED0", VA = "0x183CDFCD0")]
	private void MGKGHNJLGBF(Entity FOJNONDDGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF350", Offset = "0x3CDE550", VA = "0x183CDF350")]
	private void JOOFDAELDAM(Entity FOJNONDDGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF7D0", Offset = "0x3CDE9D0", VA = "0x183CDF7D0")]
	private void MEMFJBIKDOG(Entity FOJNONDDGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CDDB60", Offset = "0x3CDCD60", VA = "0x183CDDB60")]
	private void BIFAGCNLKDP(Entity FOJNONDDGDN, PIHIHJEBCFM DHPHAFDDMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CDDE30", Offset = "0x3CDD030", VA = "0x183CDDE30")]
	private bool EIIJPMHPPFB(PIHIHJEBCFM DHPHAFDDMEE, [Out] HashSet<object> OLLIMPCFODF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3CDD680", Offset = "0x3CDC880", VA = "0x183CDD680")]
	private HashSet<object> AKPNFBCFGDB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ALGAHJFLBBI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CMOJODOLIOL : DGOEEKBFGEC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x64D19F0", Offset = "0x64D0BF0", VA = "0x1864D19F0")]
	public float BAICGKCAAJP([In] float3 HLCKBKFCMPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x64D19F0", Offset = "0x64D0BF0", VA = "0x1864D19F0", Slot = "4")]
	private float EKLAGJEJKMJ([In] float3 HLCKBKFCMPI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DBJLBCJEAGM : DGOEEKBFGEC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x64D1AF0", Offset = "0x64D0CF0", VA = "0x1864D1AF0")]
	public float BAICGKCAAJP([In] float3 HLCKBKFCMPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x64D1AF0", Offset = "0x64D0CF0", VA = "0x1864D1AF0", Slot = "4")]
	private float EKLAGJEJKMJ([In] float3 HLCKBKFCMPI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LCMNMEPOLJE : DGOEEKBFGEC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1BEA0E0", Offset = "0x1BE92E0", VA = "0x181BEA0E0")]
	public float BAICGKCAAJP([In] float3 HLCKBKFCMPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1BEA0E0", Offset = "0x1BE92E0", VA = "0x181BEA0E0", Slot = "4")]
	private float EKLAGJEJKMJ([In] float3 HLCKBKFCMPI)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HGAAJDOGJFG : DGOEEKBFGEC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x14D1170", Offset = "0x14D0370", VA = "0x1814D1170")]
	public int BAICGKCAAJP([In] int3 HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x14D1170", Offset = "0x14D0370", VA = "0x1814D1170", Slot = "4")]
	private int PGJKFEKOAMO([In] int3 HLCKBKFCMPI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JOMMGKDIGCA : DGOEEKBFGEC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x64D1F40", Offset = "0x64D1140", VA = "0x1864D1F40")]
	public int BAICGKCAAJP([In] int3 HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x64D1F40", Offset = "0x64D1140", VA = "0x1864D1F40", Slot = "4")]
	private int PGJKFEKOAMO([In] int3 HLCKBKFCMPI)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ABFAOMJGJDN : DGOEEKBFGEC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x17D56F0", Offset = "0x17D48F0", VA = "0x1817D56F0")]
	public int BAICGKCAAJP([In] int3 HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x17D56F0", Offset = "0x17D48F0", VA = "0x1817D56F0", Slot = "4")]
	private int PGJKFEKOAMO([In] int3 HLCKBKFCMPI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HGGPKEFHOKC : EACJPAMHPBE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1409650", Offset = "0x1408850", VA = "0x181409650")]
	public HGGPKEFHOKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class JOOKBMDBDKO : SystemBase, GPONKHKBKHH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29F6610", Offset = "0x29F5810", VA = "0x1829F6610")]
	public void BHKNKDHLHOI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29F6A50", Offset = "0x29F5C50", VA = "0x1829F6A50")]
	public JobHandle BHKNKDHLHOI<T>(JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29F6610", Offset = "0x29F5810", VA = "0x1829F6610")]
	public void ADMKBODKLKL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29F6490", Offset = "0x29F5690", VA = "0x1829F6490")]
	public JobHandle ADMKBODKLKL<T>(JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x64D1F50", Offset = "0x64D1150", VA = "0x1864D1F50")]
	public ComponentDataFromEntity AOCKFFGPJDL(int ANKFEMDGJKO, bool CGDMKOGMHEA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x64D2010", Offset = "0x64D1210", VA = "0x1864D2010")]
	public EntityExistenceLookupByEntity HLDONJIAFGJ()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x64D2030", Offset = "0x64D1230", VA = "0x1864D2030", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1409650", Offset = "0x1408850", VA = "0x181409650")]
	protected JOOKBMDBDKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class GKMMDFABPKC : JOOKBMDBDKO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x64D1E80", Offset = "0x64D1080", VA = "0x1864D1E80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1409650", Offset = "0x1408850", VA = "0x181409650")]
	protected GKMMDFABPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HNFJDOMJIOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class KDIJBOJLMFG : EntityCommandBufferSystem, GPONKHKBKHH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1409650", Offset = "0x1408850", VA = "0x181409650")]
	protected KDIJBOJLMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DGOEEKBFGEC<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo BAICGKCAAJP([In] TFrom HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EOBCEEAIEFK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLLIPDNELFB(T HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct CPDJGCILKKK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> BGEKIKEJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer DFCMLICNAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes CCGKLGJBDAO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x64D1A00", Offset = "0x64D0C00", VA = "0x1864D1A00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct APBELFNMGBE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> BGEKIKEJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer DFCMLICNAPF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x64D1850", Offset = "0x64D0A50", VA = "0x1864D1850", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct LKHCOAOEBLI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> BGEKIKEJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer DFCMLICNAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType MKAMCALPLPD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x64D2160", Offset = "0x64D1360", VA = "0x1864D2160", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct MBMAJFANLEE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> BGEKIKEJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> JLJKEBMIIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer DFCMLICNAPF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x412D580", Offset = "0x412C780", VA = "0x18412D580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct OIHKOCKOBDC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> BGEKIKEJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> IJMHBFBFIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer DFCMLICNAPF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct NGCOCINGHBO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> BGEKIKEJMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T HLCKBKFCMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer DFCMLICNAPF;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x41AA670", Offset = "0x41A9870", VA = "0x1841AA670", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct BPMBBGELCJG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DGOEEKBFGEC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> PELIGLJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> LJEDKELACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap BGMBJALDBDD;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct CALHHAGJHLJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity LDBDEMOAHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> PELIGLJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> LJEDKELACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int LPABMKCDEKM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64D18F0", Offset = "0x64D0AF0", VA = "0x1864D18F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct MIMCBNHDGHO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BDGBAIOEDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> PELIGLJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> ENJOIBDKDDG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct JFBOCNLCIDJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DGOEEKBFGEC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> OMIKEHNKKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> LJEDKELACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap BGMBJALDBDD;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct FDLIOHICIOO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MKCDMFJLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> MMLGEAHKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> ONHFBNHAIEH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct DMINKKKGPCK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MKCDMFJLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> MMLGEAHKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> ONHFBNHAIEH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x53482D0", Offset = "0x53474D0", VA = "0x1853482D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BDPOBJOBMFA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> PELIGLJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> ENJOIBDKDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> HANDLMFNBGN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A9E0", Offset = "0x4A49BE0", VA = "0x184A4A9E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct FKEKFMOAEJM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DGOEEKBFGEC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> PELIGLJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> ENJOIBDKDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> HANDLMFNBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap BGMBJALDBDD;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct FOLNIHPICGM<T, TPredicate> : IJob where T : struct where TPredicate : struct, EOBCEEAIEFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> PELIGLJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> LCAPAHFFGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> NINHNEIKABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate BGMBJALDBDD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3927670", Offset = "0x3926870", VA = "0x183927670", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct CEBBBEINKKN<T, TPredicate> : IJob where T : struct where TPredicate : struct, EOBCEEAIEFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> PELIGLJJELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> ENJOIBDKDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate BGMBJALDBDD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct MOJCNMJGLIB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity MKCDMFJLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> MMLGEAHKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> EBMNNGEFHHE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64D2680", Offset = "0x64D1880", VA = "0x1864D2680", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct GCENLMPEACP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity MKCDMFJLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> MMLGEAHKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> EBMNNGEFHHE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64D1DF0", Offset = "0x64D0FF0", VA = "0x1864D1DF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PBAJFLJDIDH
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EJJINBEJKGH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2827740", Offset = "0x2826940", VA = "0x182827740")]
	public static bool KHPLKHBKOAF<T>(this NativeArray<Entity> MMLGEAHKIME, EntityManager CAODHPOMABB, Allocator LGNDPBNMKMP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HACONNGGAKP
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FGKFKEEGPBM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public FGKFKEEGPBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NILGKLCAFOH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public NILGKLCAFOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> JENJPNMPNPA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x64D1EB0", Offset = "0x64D10B0", VA = "0x1864D1EB0")]
	public HACONNGGAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PPLDEONGDHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DKBPBGCLAMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct IJEKHILGIOA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct FDKFINIECGB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal IJEKHILGIOA<TFrom> BGILIGANMHA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> NAKAAHDEHKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct FHHNKNNNAGD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct NLMKBPDINCN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal FHHNKNNNAGD<TFrom> BGILIGANMHA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> NAKAAHDEHKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct NLEPPLOAPMK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct GAMKJCFKCKA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal NLEPPLOAPMK<TFrom> BGILIGANMHA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> NAKAAHDEHKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct FCPPCFNLBIO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct KNCADJIIHLC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal FCPPCFNLBIO<TFrom> BGILIGANMHA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> NAKAAHDEHKM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HPKNPKLAGFG
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GGIAGNJJMIH
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2986660", Offset = "0x2985860", VA = "0x182986660")]
	public static NativeList<T> MKMGFKEEJDJ<T>(this NativeArray<T> PDEGHCDBAEK, Allocator LGNDPBNMKMP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IGDJEMFJEDK
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LLLNBCNCICK
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2A37D40", Offset = "0x2A36F40", VA = "0x182A37D40")]
	[KIKPFNKMMIG]
	public static JobHandle LIJEJDLFNMM<T>(this EntityCommandBufferSystem PENMCEINNIN, NativeArrayAsync<Entity> BGEKIKEJMHP, NativeArrayAsync<T> JLJKEBMIIPF, [Optional] JobHandle MJKOBFEOMGK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A37EA0", Offset = "0x2A370A0", VA = "0x182A37EA0")]
	[KIKPFNKMMIG]
	public static JobHandle LIJEJDLFNMM<T>(this EntityCommandBufferSystem PENMCEINNIN, NativeArrayAsync<Entity> BGEKIKEJMHP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A37C20", Offset = "0x2A36E20", VA = "0x182A37C20")]
	[KIKPFNKMMIG]
	public static JobHandle LIJEJDLFNMM<T>(this EntityCommandBufferSystem PENMCEINNIN, NativeArray<Entity> BGEKIKEJMHP, [Optional] JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64D21E0", Offset = "0x64D13E0", VA = "0x1864D21E0")]
	[KIKPFNKMMIG]
	public static JobHandle LIJEJDLFNMM(this EntityCommandBufferSystem PENMCEINNIN, NativeArray<Entity> BGEKIKEJMHP, ComponentTypes CCGKLGJBDAO, [Optional] JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x64D2350", Offset = "0x64D1550", VA = "0x1864D2350")]
	[KIKPFNKMMIG]
	public static JobHandle LIJEJDLFNMM(this EntityCommandBufferSystem PENMCEINNIN, EntityCommandBuffer DFCMLICNAPF, NativeArray<Entity> BGEKIKEJMHP, ComponentTypes CCGKLGJBDAO, [Optional] JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KDGKFMEIJED
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A1E000", Offset = "0x2A1D200", VA = "0x182A1E000")]
	[KIKPFNKMMIG]
	public static JobHandle KOLGMEAIKGB<T>(this EntityCommandBufferSystem PENMCEINNIN, EntityCommandBuffer DFCMLICNAPF, EntityQuery DKFHCEMLABP, T HLCKBKFCMPI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GAEOOFEOHJN
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x64D1B60", Offset = "0x64D0D60", VA = "0x1864D1B60")]
	[KIKPFNKMMIG]
	public static JobHandle LFKBBAJGFNL(this EntityCommandBufferSystem PENMCEINNIN, NativeList<Entity> BGEKIKEJMHP, [Optional] JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x64D1CF0", Offset = "0x64D0EF0", VA = "0x1864D1CF0")]
	[KIKPFNKMMIG]
	public static JobHandle LFKBBAJGFNL(this EntityCommandBufferSystem PENMCEINNIN, NativeArrayAsync<Entity> BGEKIKEJMHP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LGNOPGBGBFI
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2A34A10", Offset = "0x2A33C10", VA = "0x182A34A10")]
	public static void CGAPLILAPAE<T>(this EntityCommandBufferSystem PENMCEINNIN, EntityQuery DKFHCEMLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A34EB0", Offset = "0x2A340B0", VA = "0x182A34EB0")]
	[KIKPFNKMMIG]
	public static JobHandle FMNFDEDGEPH<T>(this EntityCommandBufferSystem PENMCEINNIN, NativeListAsync<Entity> BGEKIKEJMHP, [Optional] JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A34D20", Offset = "0x2A33F20", VA = "0x182A34D20")]
	[KIKPFNKMMIG]
	public static JobHandle FMNFDEDGEPH<T>(this EntityCommandBufferSystem PENMCEINNIN, NativeArrayAsync<Entity> BGEKIKEJMHP, [Optional] JobHandle MJKOBFEOMGK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EFLBHDKFLFJ
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28222D0", Offset = "0x28214D0", VA = "0x1828222D0")]
	[KIKPFNKMMIG]
	public static JobHandle NIDMEHLABFG<T>(this EntityCommandBufferSystem PENMCEINNIN, NativeArray<Entity> BGEKIKEJMHP, NativeArray<T> JLJKEBMIIPF, JobHandle MJKOBFEOMGK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class OHHMHGMMFAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2190", Offset = "0x2AF1390", VA = "0x182AF2190")]
	[KIKPFNKMMIG]
	public static JobHandle OPKKOKLIDCJ<T>(this EntityCommandBufferSystem PENMCEINNIN, NativeArray<Entity> BGEKIKEJMHP, T HLCKBKFCMPI, [Optional] JobHandle MJKOBFEOMGK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2270", Offset = "0x2AF1470", VA = "0x182AF2270")]
	[KIKPFNKMMIG]
	public static JobHandle OPKKOKLIDCJ<T>(this EntityCommandBufferSystem PENMCEINNIN, EntityCommandBuffer DFCMLICNAPF, NativeArray<Entity> BGEKIKEJMHP, T HLCKBKFCMPI, [Optional] JobHandle MJKOBFEOMGK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class BAOCHJGPNDG
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class LOODODGCPDI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B450", Offset = "0x2A3A650", VA = "0x182A3B450")]
	public static NativeArray<T> BOOCCDBMBPE<T>(this NativeList<Entity> PDEGHCDBAEK, EntityManager CAODHPOMABB, Allocator LGNDPBNMKMP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A3AF10", Offset = "0x2A3A110", VA = "0x182A3AF10")]
	public static NativeArray<T> BOOCCDBMBPE<T>(this NativeArray<Entity> PDEGHCDBAEK, EntityManager CAODHPOMABB, Allocator LGNDPBNMKMP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x64D24A0", Offset = "0x64D16A0", VA = "0x1864D24A0")]
	public static NativeArray<Entity> IMNHCLOMLBA(this NativeArray<Entity> PDEGHCDBAEK, EntityManager CAODHPOMABB, ComponentType MKAMCALPLPD, Allocator LGNDPBNMKMP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A3B500", Offset = "0x2A3A700", VA = "0x182A3B500")]
	public static NativeArray<T> NDAOOIPIPJI<T>(this NativeArray<Entity> PDEGHCDBAEK, EntityManager CAODHPOMABB, Allocator LGNDPBNMKMP = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class LCBHANOINAE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct OKJKKHNEMAJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct NDPKGPECFOG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public OKJKKHNEMAJ<TFrom> NAKAAHDEHKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> PELIGLJJELH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct LHHFOJIDEEB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct HOJILIOBJKB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public LHHFOJIDEEB<TFrom> NAKAAHDEHKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> PELIGLJJELH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NHKHMAJJDPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct AAKCKHPLCAC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public NHKHMAJJDPB<TFrom> NAKAAHDEHKM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> PELIGLJJELH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class OKEBCAIEPLK
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class GLOEPCOFECO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct OOCDGKFJBCP : DGOEEKBFGEC<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> PHNMHCLGAOC;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64D2710", Offset = "0x64D1910", VA = "0x1864D2710")]
		[BurstCompatible]
		public Entity BAICGKCAAJP([In] Entity HLCKBKFCMPI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64D2710", Offset = "0x64D1910", VA = "0x1864D2710", Slot = "4")]
		private Entity NFCNPKBEEFF([In] Entity HLCKBKFCMPI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BKIBABKMEAL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct NBONJNMDIGD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> LCAPAHFFGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> PELIGLJJELH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DPEDNJBFOBB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> LCAPAHFFGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> PELIGLJJELH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct IECAMBCJFHA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> LCAPAHFFGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> PELIGLJJELH;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x286B270", Offset = "0x286A470", VA = "0x18286B270")]
		public NativeListAsync<Entity> FLLIPDNELFB<TPredicate>() where TPredicate : struct, EOBCEEAIEFK<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2776420", Offset = "0x2775620", VA = "0x182776420")]
	public static IECAMBCJFHA<T> IFOONGLBKOA<T>(this NativeArrayAsync<Entity> MMLGEAHKIME, NativeArrayAsync<T> PDEGHCDBAEK, Allocator LGNDPBNMKMP = Allocator.TempJob) where T : struct
	{
		return default(IECAMBCJFHA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class EAGONJKDGFL
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x281FC10", Offset = "0x281EE10", VA = "0x18281FC10")]
	public static NativeListAsync<Entity> LDONIJIMJPN<T, TPredicate>(this NativeArrayAsync<T> PDEGHCDBAEK, NativeArrayAsync<Entity> MMLGEAHKIME, Allocator LGNDPBNMKMP = Allocator.TempJob) where T : struct where TPredicate : struct, EOBCEEAIEFK<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x281FA70", Offset = "0x281EC70", VA = "0x18281FA70")]
	private static NativeListAsync<Entity> GBLKIGIHDDF<T, TPredicate>(NativeArrayAsync<T> OCDCHNNGDAF, NativeArrayAsync<Entity> MMLGEAHKIME, int MKCBFIBLIDD, Allocator LGNDPBNMKMP) where T : struct where TPredicate : struct, EOBCEEAIEFK<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CAJCFACBLFA
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct GAGLDLGLIKB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> PELIGLJJELH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct ICCMBELDIGN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> PELIGLJJELH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct NJKCAKDCGNN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> PELIGLJJELH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct OINCEBIHOJO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator LGNDPBNMKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> PELIGLJJELH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KPDCKPECKKK
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NHBOGCNIHNI
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5070", Offset = "0x2AC4270", VA = "0x182AC5070")]
	public static NativeList<Entity> KBCCJHOBHNK<T>(this NativeArray<Entity> MMLGEAHKIME, EntityManager CAODHPOMABB, Allocator LGNDPBNMKMP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BLAMFHHBKMP
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class OBHOAFMILIN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct MMLGBDDBMPG<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> HPGKNFECNHG;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
		public MMLGBDDBMPG(NativeArray<TSrc> HPGKNFECNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public CCBCJLOFKAF<TSrc, TValue> DKEGMIMMBLJ<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(CCBCJLOFKAF<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct CCBCJLOFKAF<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> HPGKNFECNHG;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
		public CCBCJLOFKAF(NativeArray<TSrc> HPGKNFECNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public NCHGPGOOJFK<TSrc, TValue, TSelector> HLLCKIOILEJ<TSelector>() where TSelector : struct, DGOEEKBFGEC<TSrc, TValue>
		{
			return default(NCHGPGOOJFK<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct NCHGPGOOJFK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DGOEEKBFGEC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> HPGKNFECNHG;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
		public NCHGPGOOJFK(NativeArray<TSrc> HPGKNFECNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4191130", Offset = "0x4190330", VA = "0x184191130")]
		public MODHHLMHFIJ<TSrc, TValue, TSelector> GOJJBBEFDFG()
		{
			return default(MODHHLMHFIJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct GDBKGMHBGCK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DGOEEKBFGEC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> HPGKNFECNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector LJCCPPLKEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int PMNHOLIPOMJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x39B8150", Offset = "0x39B7350", VA = "0x1839B8150")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int DMDPAHAMEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x83B480", Offset = "0x83A680", VA = "0x18083B480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BOHPGPGHAFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1EDFEE0", Offset = "0x1EDF0E0", VA = "0x181EDFEE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x39B81F0", Offset = "0x39B73F0", VA = "0x1839B81F0")]
		public GDBKGMHBGCK(NativeArray<TSrc> HPGKNFECNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x39B81E0", Offset = "0x39B73E0", VA = "0x1839B81E0")]
		public bool JOHDHIDFEFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x39B8070", Offset = "0x39B7270", VA = "0x1839B8070")]
		private TSrc HLHMOABNCIK(int BJOOMLAOBEG)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MODHHLMHFIJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DGOEEKBFGEC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private GDBKGMHBGCK<TSrc, TValue, TSelector> NBJLILNDAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue DOOIINLOELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int CJICFAPMKCE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EIJCIPFCDMO JMHOFOMNKJG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x414FAD0", Offset = "0x414ECD0", VA = "0x18414FAD0")]
			get
			{
				return default(EIJCIPFCDMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FOCDMOCKIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, EIJCIPFCDMO range) NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x414F8C0", Offset = "0x414EAC0", VA = "0x18414F8C0")]
			get
			{
				return default((TValue, EIJCIPFCDMO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x414FB10", Offset = "0x414ED10", VA = "0x18414FB10")]
		public MODHHLMHFIJ(NativeArray<TSrc> HPGKNFECNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3982320", Offset = "0x3981520", VA = "0x183982320")]
		public MODHHLMHFIJ<TSrc, TValue, TSelector> KBKKLBPIAFK()
		{
			return default(MODHHLMHFIJ<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x414F990", Offset = "0x414EB90", VA = "0x18414F990")]
		public bool JOHDHIDFEFJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFBA0", Offset = "0x2AEEDA0", VA = "0x182AEFBA0")]
	public static MMLGBDDBMPG<T> DDCDEFCMAEE<T>(this NativeList<T> AIMBMINBCPM) where T : struct
	{
		return default(MMLGBDDBMPG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
	public static MMLGBDDBMPG<T> DDCDEFCMAEE<T>(this NativeArray<T> HPGKNFECNHG) where T : struct
	{
		return default(MMLGBDDBMPG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class HNPFIKFAHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct GIJGPFMDNDE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly HPGKNFECNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int CJICFAPMKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int NKLPLPKENAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T DOOIINLOELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T BLLPEHDBLBA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EIJCIPFCDMO JMHOFOMNKJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x39D5730", Offset = "0x39D4930", VA = "0x1839D5730")]
			get
			{
				return default(EIJCIPFCDMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T FOCDMOCKIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3596A10", Offset = "0x3595C10", VA = "0x183596A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, EIJCIPFCDMO) NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x39D51F0", Offset = "0x39D43F0", VA = "0x1839D51F0")]
			get
			{
				return default((T, EIJCIPFCDMO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x39D5740", Offset = "0x39D4940", VA = "0x1839D5740")]
		public GIJGPFMDNDE(NativeArray<T> HPGKNFECNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x39D56F0", Offset = "0x39D48F0", VA = "0x1839D56F0")]
		public GIJGPFMDNDE<T> KBKKLBPIAFK()
		{
			return default(GIJGPFMDNDE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x39D5520", Offset = "0x39D4720", VA = "0x1839D5520")]
		public bool JOHDHIDFEFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28692B0", Offset = "0x28684B0", VA = "0x1828692B0")]
		public AKFPENBEGBN<T, TComparer> NFNDCMDCLKH<TComparer>([Optional] TComparer HJOPFPOPMHE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(AKFPENBEGBN<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct AKFPENBEGBN<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly HPGKNFECNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int CJICFAPMKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int NKLPLPKENAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T DOOIINLOELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T BLLPEHDBLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer HJOPFPOPMHE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EIJCIPFCDMO JMHOFOMNKJG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x39D5730", Offset = "0x39D4930", VA = "0x1839D5730")]
			get
			{
				return default(EIJCIPFCDMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FOCDMOCKIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3596A10", Offset = "0x3595C10", VA = "0x183596A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3D63950", Offset = "0x3D62B50", VA = "0x183D63950")]
		public AKFPENBEGBN(NativeArray<T>.ReadOnly HPGKNFECNHG, TComparer HJOPFPOPMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D63780", Offset = "0x3D62980", VA = "0x183D63780")]
		public bool JOHDHIDFEFJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x29C72A0", Offset = "0x29C64A0", VA = "0x1829C72A0")]
	public static GIJGPFMDNDE<T> GOJJBBEFDFG<T>(this NativeArray<T> HPGKNFECNHG) where T : struct
	{
		return default(GIJGPFMDNDE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NAADMCMEBGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class FLFMHADOKGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct MLFCAHAJGJK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class GFDLMFJELFL : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public MLFCAHAJGJK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xB7FD30", Offset = "0xB7EF30", VA = "0x180B7FD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x395B880", Offset = "0x395AA80", VA = "0x18395B880", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public GFDLMFJELFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x39C8200", Offset = "0x39C7400", VA = "0x1839C8200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x39C83B0", Offset = "0x39C75B0", VA = "0x1839C83B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> JLHKMNNFHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream GBJPNMMPFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream FCAONEEBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf LPDMDILMCLC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int BOHPGPGHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x41458C0", Offset = "0x4144AC0", VA = "0x1841458C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4145900", Offset = "0x4144B00", VA = "0x184145900", Slot = "4")]
	[IteratorStateMachine(typeof(MLFCAHAJGJK<>.GFDLMFJELFL))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x41459F0", Offset = "0x4144BF0", VA = "0x1841459F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct GJIJCJHGOJG<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] OPMKPGEDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf LPDMDILMCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream GBJPNMMPFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream BJEOJIJGGJD;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x39D5920", Offset = "0x39D4B20", VA = "0x1839D5920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct FBFPHOFOPFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream GBJPNMMPFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream FCAONEEBOKL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x64D1B20", Offset = "0x64D0D20", VA = "0x1864D1B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct KBABKFENELB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] OPMKPGEDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GBJPNMMPFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream BJEOJIJGGJD;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64D2040", Offset = "0x64D1240", VA = "0x1864D2040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EFLIFEPOBNP
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class FNDEGDIOJII
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum FLBGMFHPPAB
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class EBHJLJLFDNI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MIKFNFJDMKB
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MIKFNFJDMKB()
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
