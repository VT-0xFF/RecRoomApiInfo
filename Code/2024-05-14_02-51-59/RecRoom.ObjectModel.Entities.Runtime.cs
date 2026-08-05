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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x6410470", Offset = "0x640EE70", VA = "0x186410470")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DJMDLBAMNKH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HJBNGCMMFNB KIPEFBELNKH
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
public interface DDHIBDNBMCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIFBGEIAANJ(Entity DFBELOGKKCC, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EKMDHABACBL(Entity DFBELOGKKCC, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CBGFDMFBEAG(Entity DFBELOGKKCC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ADKBFNOBFBA(Entity DFBELOGKKCC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CGBJOBMEIDN<TComponentData, TValue> : ALOEMEKLOLF<TValue>, IDisposable where TComponentData : struct, DJMDLBAMNKH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class LHHBLPEKAJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> GOJPHGMMOOM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int IAGPAHCAHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x32DCC30", Offset = "0x32DB630", VA = "0x1832DCC30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E403E0", Offset = "0x3E3EDE0", VA = "0x183E403E0")]
		public bool EOLNAMANNAC([Out] TValue AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E40330", Offset = "0x3E3ED30", VA = "0x183E40330")]
		public void BIPEDCDHLGG(object AIDIDMJCFEK, TValue AEJBOLFACJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E404B0", Offset = "0x3E3EEB0", VA = "0x183E404B0")]
		public bool MDELFCPLFEE(object AIDIDMJCFEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3E40250", Offset = "0x3E3EC50", VA = "0x183E40250")]
		public int AKBBJAAMMHG(object AIDIDMJCFEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3E40530", Offset = "0x3E3EF30", VA = "0x183E40530")]
		public LHHBLPEKAJB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<LHHBLPEKAJB> GKGCHAMKJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DBIGHMLEPKI<HJBNGCMMFNB, LHHBLPEKAJB> HGAJKHJLIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager KBFJIBCFALI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2F20", Offset = "0x4AB1920", VA = "0x184AB2F20")]
	public CGBJOBMEIDN(EntityManager KBFJIBCFALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2840", Offset = "0x4AB1240", VA = "0x184AB2840", Slot = "4")]
	public void DIFBGEIAANJ(Entity DFBELOGKKCC, object AIDIDMJCFEK, TValue AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2A60", Offset = "0x4AB1460", VA = "0x184AB2A60", Slot = "5")]
	public bool EKMDHABACBL(Entity DFBELOGKKCC, object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2BF0", Offset = "0x4AB15F0", VA = "0x184AB2BF0", Slot = "6")]
	public bool EOLNAMANNAC(Entity DFBELOGKKCC, [Out] TValue AEJBOLFACJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2A40", Offset = "0x4AB1440", VA = "0x184AB2A40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2E70", Offset = "0x4AB1870", VA = "0x184AB2E70")]
	private void NMLCDMCNIFE(LHHBLPEKAJB DBHIHKNLHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2CD0", Offset = "0x4AB16D0", VA = "0x184AB2CD0")]
	private bool FHNEAGLGJBN(Entity DFBELOGKKCC, [Out] HJBNGCMMFNB MEGCFGBDKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2960", Offset = "0x4AB1360", VA = "0x184AB2960")]
	private void DPJFNPAGOBI(Entity DFBELOGKKCC, HJBNGCMMFNB MEGCFGBDKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2F00", Offset = "0x4AB1900", VA = "0x184AB2F00")]
	private bool POFDJAJJNGO(HJBNGCMMFNB MEGCFGBDKPO, [Out] LHHBLPEKAJB DBHIHKNLHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2D90", Offset = "0x4AB1790", VA = "0x184AB2D90")]
	private LHHBLPEKAJB JJKIFFPFMAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ALOEMEKLOLF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIFBGEIAANJ(Entity DFBELOGKKCC, object AIDIDMJCFEK, TValue AEJBOLFACJC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EKMDHABACBL(Entity DFBELOGKKCC, object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EOLNAMANNAC(Entity DFBELOGKKCC, [Out] TValue AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HJBNGCMMFNB : FJKKAFGOBOJ, IEquatable<HJBNGCMMFNB>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HJBNGCMMFNB ENOPEJBDPMA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int JIFJFCOEJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int HEDMKAPCFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x23C7760", Offset = "0x23C6160", VA = "0x1823C7760", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x575D410", Offset = "0x575BE10", VA = "0x18575D410", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6410510", Offset = "0x640EF10", VA = "0x186410510", Slot = "8")]
	public bool Equals(HJBNGCMMFNB HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6410560", Offset = "0x640EF60", VA = "0x186410560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JPJKLLHAKPD<THasTokensTag> : DDHIBDNBMCN, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LBNENDFDEJK EMEAPIGMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, HJBNGCMMFNB> DBKDPHCNKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> GKGCHAMKJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DBIGHMLEPKI<HJBNGCMMFNB, HashSet<object>> HGAJKHJLIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager KBFJIBCFALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem PAMEPNBGNHM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E810", Offset = "0x3C8D210", VA = "0x183C8E810")]
	public JPJKLLHAKPD(EntityManager KBFJIBCFALI, EntityCommandBufferSystem PAMEPNBGNHM, LBNENDFDEJK HDKCPHIFNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BAE0", Offset = "0x3C8A4E0", VA = "0x183C8BAE0", Slot = "4")]
	public bool DIFBGEIAANJ(Entity DFBELOGKKCC, object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C3D0", Offset = "0x3C8ADD0", VA = "0x183C8C3D0", Slot = "5")]
	public bool EKMDHABACBL(Entity DFBELOGKKCC, object AIDIDMJCFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B170", Offset = "0x3C89B70", VA = "0x183C8B170", Slot = "6")]
	public bool CBGFDMFBEAG(Entity DFBELOGKKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B4B0", Offset = "0x3C89EB0", VA = "0x183C8B4B0", Slot = "9")]
	public bool CBGFDMFBEAG(HJBNGCMMFNB MEGCFGBDKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C8ACC0", Offset = "0x3C896C0", VA = "0x183C8ACC0", Slot = "7")]
	public bool ADKBFNOBFBA(Entity DFBELOGKKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BEB0", Offset = "0x3C8A8B0", VA = "0x183C8BEB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DD70", Offset = "0x3C8C770", VA = "0x183C8DD70")]
	private void NMLCDMCNIFE(HashSet<object> DBHIHKNLHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C830", Offset = "0x3C8B230", VA = "0x183C8C830")]
	private bool FHNEAGLGJBN(Entity DFBELOGKKCC, [Out] HJBNGCMMFNB MEGCFGBDKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DFD0", Offset = "0x3C8C9D0", VA = "0x183C8DFD0")]
	private bool OJNJAFELJCH(Entity DFBELOGKKCC, [Out] HJBNGCMMFNB MEGCFGBDKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C8CDA0", Offset = "0x3C8B7A0", VA = "0x183C8CDA0")]
	private void FJBPOAIBHON(Entity DFBELOGKKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D4A0", Offset = "0x3C8BEA0", VA = "0x183C8D4A0")]
	private void JNLBKBDPJGO(Entity DFBELOGKKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D9A0", Offset = "0x3C8C3A0", VA = "0x183C8D9A0")]
	private void LPBFCIMCIMN(Entity DFBELOGKKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BE00", Offset = "0x3C8A800", VA = "0x183C8BE00")]
	private void DPJFNPAGOBI(Entity DFBELOGKKCC, HJBNGCMMFNB MEGCFGBDKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D120", Offset = "0x3C8BB20", VA = "0x183C8D120")]
	private bool GAHALCPKLAH(HJBNGCMMFNB MEGCFGBDKPO, [Out] HashSet<object> DBHIHKNLHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D360", Offset = "0x3C8BD60", VA = "0x183C8D360")]
	private HashSet<object> JJKIFFPFMAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FKEEHDHMPNL
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EFCCKJPDCOB : FIHBFFNNAHM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6410370", Offset = "0x640ED70", VA = "0x186410370")]
	public float PPEDHBMIKGC([In] float3 AEJBOLFACJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6410370", Offset = "0x640ED70", VA = "0x186410370", Slot = "4")]
	private float HDKNAMLPJIK([In] float3 AEJBOLFACJC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KLPFFCOGHOL : FIHBFFNNAHM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6410A90", Offset = "0x640F490", VA = "0x186410A90")]
	public float PPEDHBMIKGC([In] float3 AEJBOLFACJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6410A90", Offset = "0x640F490", VA = "0x186410A90", Slot = "4")]
	private float HDKNAMLPJIK([In] float3 AEJBOLFACJC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JNOLGANMNGI : FIHBFFNNAHM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C2C0", Offset = "0x1B4ACC0", VA = "0x181B4C2C0")]
	public float PPEDHBMIKGC([In] float3 AEJBOLFACJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C2C0", Offset = "0x1B4ACC0", VA = "0x181B4C2C0", Slot = "4")]
	private float HDKNAMLPJIK([In] float3 AEJBOLFACJC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KAOPALAMMCJ : FIHBFFNNAHM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1429230", Offset = "0x1427C30", VA = "0x181429230")]
	public int PPEDHBMIKGC([In] int3 AEJBOLFACJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1429230", Offset = "0x1427C30", VA = "0x181429230", Slot = "4")]
	private int IIKDKNDFIMN([In] int3 AEJBOLFACJC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LHPPBNEAKBB : FIHBFFNNAHM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6410D30", Offset = "0x640F730", VA = "0x186410D30")]
	public int PPEDHBMIKGC([In] int3 AEJBOLFACJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6410D30", Offset = "0x640F730", VA = "0x186410D30", Slot = "4")]
	private int IIKDKNDFIMN([In] int3 AEJBOLFACJC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ACKDIDNHHNB : FIHBFFNNAHM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x173DBB0", Offset = "0x173C5B0", VA = "0x18173DBB0")]
	public int PPEDHBMIKGC([In] int3 AEJBOLFACJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x173DBB0", Offset = "0x173C5B0", VA = "0x18173DBB0", Slot = "4")]
	private int IIKDKNDFIMN([In] int3 AEJBOLFACJC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DBNHHJCBAKB : NJIIJAHIOAA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x137BD10", Offset = "0x137A710", VA = "0x18137BD10")]
	public DBNHHJCBAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class CNDAFLEONKG : SystemBase, BEHFBBHPONP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27BD130", Offset = "0x27BBB30", VA = "0x1827BD130")]
	public void LBGNCELIGKC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27BCEF0", Offset = "0x27BB8F0", VA = "0x1827BCEF0")]
	public JobHandle LBGNCELIGKC<T>(JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27BD130", Offset = "0x27BBB30", VA = "0x1827BD130")]
	public void OFNGMGGNJFP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27BD570", Offset = "0x27BBF70", VA = "0x1827BD570")]
	public JobHandle OFNGMGGNJFP<T>(JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6410270", Offset = "0x640EC70", VA = "0x186410270")]
	public ComponentDataFromEntity OHEHKNOAJCK(int JOLOGDHIEGI, bool PGGBDONDJDL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6410330", Offset = "0x640ED30", VA = "0x186410330")]
	public EntityExistenceLookupByEntity OHLLPIHOOIK()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6410350", Offset = "0x640ED50", VA = "0x186410350", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x137BD10", Offset = "0x137A710", VA = "0x18137BD10")]
	protected CNDAFLEONKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NINPHGIPGLB : CNDAFLEONKG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6410E70", Offset = "0x640F870", VA = "0x186410E70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x137BD10", Offset = "0x137A710", VA = "0x18137BD10")]
	protected NINPHGIPGLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FEBNMINPLIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class FDBIAEFCAIN : EntityCommandBufferSystem, BEHFBBHPONP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x137BD10", Offset = "0x137A710", VA = "0x18137BD10")]
	protected FDBIAEFCAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FIHBFFNNAHM<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PPEDHBMIKGC([In] TFrom AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EHFGIDLLLFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJBIEPJBEAH(T AEJBOLFACJC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct EMDLIPODJME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> JKAMGAGLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer NPBPFBIGMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes HIBIPLKGONI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6410380", Offset = "0x640ED80", VA = "0x186410380", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct NGILGFHPAIL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> JKAMGAGLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer NPBPFBIGMEO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6410DD0", Offset = "0x640F7D0", VA = "0x186410DD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct FIJAAFCPFMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> JKAMGAGLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer NPBPFBIGMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType AKDKNFIGKMM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6410490", Offset = "0x640EE90", VA = "0x186410490", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct HHOEOEIFGJE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> JKAMGAGLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> ABDLEBPKDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer NPBPFBIGMEO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x39F4720", Offset = "0x39F3120", VA = "0x1839F4720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct MDFAKNLMONG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> JKAMGAGLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> KCNHIGOABNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer NPBPFBIGMEO;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct KOMDEAMKHNG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> JKAMGAGLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T AEJBOLFACJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer NPBPFBIGMEO;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FFE0", Offset = "0x3D8E9E0", VA = "0x183D8FFE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct LEMAHAPDFMG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FIHBFFNNAHM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> OBPMELFDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> BEOCGPGIGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap HKIJJKKNOIF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct IDNNOPFDFHB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity DGBDIPBPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> OBPMELFDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> BEOCGPGIGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int PDCEJHPHDOC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64106D0", Offset = "0x640F0D0", VA = "0x1864106D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct ANBAJCLLJEK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GKDCICKEBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> OBPMELFDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> DMCEIMNKOAP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct IKOJJHNGKIG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FIHBFFNNAHM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> KLNMNICDCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> BEOCGPGIGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap HKIJJKKNOIF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct GFHAPFKBHHC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HNKNBFOJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> JGAJMMNFFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> DMGDMOKEEFD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct JNELGJHGKGA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HNKNBFOJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> JGAJMMNFFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> DMGDMOKEEFD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C88B20", Offset = "0x3C87520", VA = "0x183C88B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CBPCNKINAMD<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> OBPMELFDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> DMCEIMNKOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> LOBCGJMCNHA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB650", Offset = "0x4AAA050", VA = "0x184AAB650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct GGDEECAMJPC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FIHBFFNNAHM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> OBPMELFDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> DMCEIMNKOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> LOBCGJMCNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap HKIJJKKNOIF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct FNNPJPMJJCG<T, TPredicate> : IJob where T : struct where TPredicate : struct, EHFGIDLLLFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> OBPMELFDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> EODLGBOKMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> PBGGFOMDFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate HKIJJKKNOIF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x38D0660", Offset = "0x38CF060", VA = "0x1838D0660", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct DELJPIJCJAF<T, TPredicate> : IJob where T : struct where TPredicate : struct, EHFGIDLLLFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> OBPMELFDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> DMCEIMNKOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate HKIJJKKNOIF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct NLFLPDOPHIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity HNKNBFOJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> JGAJMMNFFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> MOIMNNHBICH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6410EA0", Offset = "0x640F8A0", VA = "0x186410EA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MFBEMPEFLEL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity HNKNBFOJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> JGAJMMNFFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> MOIMNNHBICH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6410D40", Offset = "0x640F740", VA = "0x186410D40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HFLEJJFFIID
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MFDEOLEAIFA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A23650", Offset = "0x2A22050", VA = "0x182A23650")]
	public static bool AEDCBBDMDEN<T>(this NativeArray<Entity> JGAJMMNFFJM, EntityManager KBFJIBCFALI, Allocator IMPJLMNPHBC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AGOGPLOBOIH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NAJPNAPKBCL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public NAJPNAPKBCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LKIBACEOKKB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public LKIBACEOKKB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> PKNIAKLBKLK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x64101A0", Offset = "0x640EBA0", VA = "0x1864101A0")]
	public AGOGPLOBOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CAIOAGEHMHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PJAKEPELPFO
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct KOCPDCIEMFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct JPBKABFNHFB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal KOCPDCIEMFJ<TFrom> HHJLJBMAMDD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> HJEPAOPBPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct POMMHEDBPAA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct OIEGMGHMNOG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal POMMHEDBPAA<TFrom> HHJLJBMAMDD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> HJEPAOPBPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FEJABJCFKBL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct GMJFAJPIBPJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal FEJABJCFKBL<TFrom> HHJLJBMAMDD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> HJEPAOPBPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct COPLIIMCPLE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct AEGJDKIOHMM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal COPLIIMCPLE<TFrom> HHJLJBMAMDD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> HJEPAOPBPKH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BOBBFGGIBJL
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JOFHLOEAFKL
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29A3F40", Offset = "0x29A2940", VA = "0x1829A3F40")]
	public static NativeList<T> IKBPONKKMKH<T>(this NativeArray<T> LLCJGKFFGHN, Allocator IMPJLMNPHBC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JEJELGPIKPE
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JCLAMLMGGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2999D90", Offset = "0x2998790", VA = "0x182999D90")]
	[EKEPLMOOOFL]
	public static JobHandle OGNHECOICNE<T>(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArrayAsync<Entity> JKAMGAGLGEP, NativeArrayAsync<T> ABDLEBPKDKC, [Optional] JobHandle FEDAMNOMMBK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2999EF0", Offset = "0x29988F0", VA = "0x182999EF0")]
	[EKEPLMOOOFL]
	public static JobHandle OGNHECOICNE<T>(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArrayAsync<Entity> JKAMGAGLGEP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2999C70", Offset = "0x2998670", VA = "0x182999C70")]
	[EKEPLMOOOFL]
	public static JobHandle OGNHECOICNE<T>(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArray<Entity> JKAMGAGLGEP, [Optional] JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6410920", Offset = "0x640F320", VA = "0x186410920")]
	[EKEPLMOOOFL]
	public static JobHandle OGNHECOICNE(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArray<Entity> JKAMGAGLGEP, ComponentTypes HIBIPLKGONI, [Optional] JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x64107D0", Offset = "0x640F1D0", VA = "0x1864107D0")]
	[EKEPLMOOOFL]
	public static JobHandle OGNHECOICNE(this EntityCommandBufferSystem PAMEPNBGNHM, EntityCommandBuffer NPBPFBIGMEO, NativeArray<Entity> JKAMGAGLGEP, ComponentTypes HIBIPLKGONI, [Optional] JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PDOHLMHNDBA
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2AC48B0", Offset = "0x2AC32B0", VA = "0x182AC48B0")]
	[EKEPLMOOOFL]
	public static JobHandle FMOMHHCFPIL<T>(this EntityCommandBufferSystem PAMEPNBGNHM, EntityCommandBuffer NPBPFBIGMEO, EntityQuery JKGBIHDJFJC, T AEJBOLFACJC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KMKNIGHPKLE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6410AA0", Offset = "0x640F4A0", VA = "0x186410AA0")]
	[EKEPLMOOOFL]
	public static JobHandle HAMAALBOCAD(this EntityCommandBufferSystem PAMEPNBGNHM, NativeList<Entity> JKAMGAGLGEP, [Optional] JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6410C30", Offset = "0x640F630", VA = "0x186410C30")]
	[EKEPLMOOOFL]
	public static JobHandle HAMAALBOCAD(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArrayAsync<Entity> JKAMGAGLGEP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CAPOMCHGGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2789360", Offset = "0x2787D60", VA = "0x182789360")]
	public static void KIELAOKILJD<T>(this EntityCommandBufferSystem PAMEPNBGNHM, EntityQuery JKGBIHDJFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2789110", Offset = "0x2787B10", VA = "0x182789110")]
	[EKEPLMOOOFL]
	public static JobHandle IODDAJELGOC<T>(this EntityCommandBufferSystem PAMEPNBGNHM, NativeListAsync<Entity> JKAMGAGLGEP, [Optional] JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27891D0", Offset = "0x2787BD0", VA = "0x1827891D0")]
	[EKEPLMOOOFL]
	public static JobHandle IODDAJELGOC<T>(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArrayAsync<Entity> JKAMGAGLGEP, [Optional] JobHandle FEDAMNOMMBK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FFHJKHFOOND
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2936490", Offset = "0x2934E90", VA = "0x182936490")]
	[EKEPLMOOOFL]
	public static JobHandle KCOPAAKGIFA<T>(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArray<Entity> JKAMGAGLGEP, NativeArray<T> ABDLEBPKDKC, JobHandle FEDAMNOMMBK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MLECLGJDILI
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A25DB0", Offset = "0x2A247B0", VA = "0x182A25DB0")]
	[EKEPLMOOOFL]
	public static JobHandle ONKPEOGIIIE<T>(this EntityCommandBufferSystem PAMEPNBGNHM, NativeArray<Entity> JKAMGAGLGEP, T AEJBOLFACJC, [Optional] JobHandle FEDAMNOMMBK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2A25CE0", Offset = "0x2A246E0", VA = "0x182A25CE0")]
	[EKEPLMOOOFL]
	public static JobHandle ONKPEOGIIIE<T>(this EntityCommandBufferSystem PAMEPNBGNHM, EntityCommandBuffer NPBPFBIGMEO, NativeArray<Entity> JKAMGAGLGEP, T AEJBOLFACJC, [Optional] JobHandle FEDAMNOMMBK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class APIMLMOIAML
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PNPLAGFFIGC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7980", Offset = "0x2AD6380", VA = "0x182AD7980")]
	public static NativeArray<T> JMMGHHIOMJO<T>(this NativeList<Entity> LLCJGKFFGHN, EntityManager KBFJIBCFALI, Allocator IMPJLMNPHBC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7600", Offset = "0x2AD6000", VA = "0x182AD7600")]
	public static NativeArray<T> JMMGHHIOMJO<T>(this NativeArray<Entity> LLCJGKFFGHN, EntityManager KBFJIBCFALI, Allocator IMPJLMNPHBC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6410F30", Offset = "0x640F930", VA = "0x186410F30")]
	public static NativeArray<Entity> LMOIINPENAO(this NativeArray<Entity> LLCJGKFFGHN, EntityManager KBFJIBCFALI, ComponentType AKDKNFIGKMM, Allocator IMPJLMNPHBC = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7520", Offset = "0x2AD5F20", VA = "0x182AD7520")]
	public static NativeArray<T> BKHFCKPHKJD<T>(this NativeArray<Entity> LLCJGKFFGHN, EntityManager KBFJIBCFALI, Allocator IMPJLMNPHBC = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class PEBDHFJGKBE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct EBGBFCNOGBG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct HEAFGHBOKKE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public EBGBFCNOGBG<TFrom> HJEPAOPBPKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> OBPMELFDODF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DEHKBIGLMAK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct NMKGKEOILOH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public DEHKBIGLMAK<TFrom> HJEPAOPBPKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> OBPMELFDODF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GEGNKDJDLGK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LFJDHGMFFEK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public GEGNKDJDLGK<TFrom> HJEPAOPBPKH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> OBPMELFDODF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FFGBELNPEJC
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OADNOBPCBAE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct DNKKONGFAOL : FIHBFFNNAHM<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KLPOLFNMCKL;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6410360", Offset = "0x640ED60", VA = "0x186410360")]
		[BurstCompatible]
		public Entity PPEDHBMIKGC([In] Entity AEJBOLFACJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6410360", Offset = "0x640ED60", VA = "0x186410360", Slot = "4")]
		private Entity HHCEGOMLNJE([In] Entity AEJBOLFACJC)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class HJCDEGHAMKC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct JHPIDHPCNML<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> EODLGBOKMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> OBPMELFDODF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DEDKIGJLHOM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> EODLGBOKMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> OBPMELFDODF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct NHBCKPHBFOM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> EODLGBOKMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> OBPMELFDODF;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28C6C50", Offset = "0x28C5650", VA = "0x1828C6C50")]
		public NativeListAsync<Entity> NJBIEPJBEAH<TPredicate>() where TPredicate : struct, EHFGIDLLLFB<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x296CED0", Offset = "0x296B8D0", VA = "0x18296CED0")]
	public static NHBCKPHBFOM<T> OHIGGHHOFMH<T>(this NativeArrayAsync<Entity> JGAJMMNFFJM, NativeArrayAsync<T> LLCJGKFFGHN, Allocator IMPJLMNPHBC = Allocator.TempJob) where T : struct
	{
		return default(NHBCKPHBFOM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AKPDNINPCKK
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2F73BC0", Offset = "0x2F725C0", VA = "0x182F73BC0")]
	public static NativeListAsync<Entity> DMOBKLNCJEE<T, TPredicate>(this NativeArrayAsync<T> LLCJGKFFGHN, NativeArrayAsync<Entity> JGAJMMNFFJM, Allocator IMPJLMNPHBC = Allocator.TempJob) where T : struct where TPredicate : struct, EHFGIDLLLFB<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2F73C80", Offset = "0x2F72680", VA = "0x182F73C80")]
	private static NativeListAsync<Entity> ODBGNLEHJEJ<T, TPredicate>(NativeArrayAsync<T> MBEBJKIECFL, NativeArrayAsync<Entity> JGAJMMNFFJM, int JEKCEPEEELJ, Allocator IMPJLMNPHBC) where T : struct where TPredicate : struct, EHFGIDLLLFB<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class LDJDMBJPLIC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct FAAJPDIDFLG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> OBPMELFDODF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct DJCFDFKCEJN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> OBPMELFDODF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct DBNGLEKKKPL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> OBPMELFDODF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct OPAOGDNEOEG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator IMPJLMNPHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> OBPMELFDODF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class HCIBBOKFGKC
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CIGPMAMMGCK
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27B30A0", Offset = "0x27B1AA0", VA = "0x1827B30A0")]
	public static NativeList<Entity> NPMGDHBOMPN<T>(this NativeArray<Entity> JGAJMMNFFJM, EntityManager KBFJIBCFALI, Allocator IMPJLMNPHBC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MFMICCLFMJL
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EHNIIEBEOHP
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct KCKKEEOOLEN<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> KKAKPOKBAHF;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E79380", Offset = "0x1E77D80", VA = "0x181E79380")]
		public KCKKEEOOLEN(NativeArray<TSrc> KKAKPOKBAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public GDMAIPLMBJP<TSrc, TValue> HACMHLIJDDD<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(GDMAIPLMBJP<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct GDMAIPLMBJP<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> KKAKPOKBAHF;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E79380", Offset = "0x1E77D80", VA = "0x181E79380")]
		public GDMAIPLMBJP(NativeArray<TSrc> KKAKPOKBAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public KGCPIOGLPJC<TSrc, TValue, TSelector> FIKCCDOHEGO<TSelector>() where TSelector : struct, FIHBFFNNAHM<TSrc, TValue>
		{
			return default(KGCPIOGLPJC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct KGCPIOGLPJC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FIHBFFNNAHM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> KKAKPOKBAHF;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E79380", Offset = "0x1E77D80", VA = "0x181E79380")]
		public KGCPIOGLPJC(NativeArray<TSrc> KKAKPOKBAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3D65E10", Offset = "0x3D64810", VA = "0x183D65E10")]
		public GKPPOAMLIGG<TSrc, TValue, TSelector> NOECOCFEEOL()
		{
			return default(GKPPOAMLIGG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct LJHKKOIOBDL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FIHBFFNNAHM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> KKAKPOKBAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector DDAIEIGBDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int ABBNIPHGMGH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3E4FEE0", Offset = "0x3E4E8E0", VA = "0x183E4FEE0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JIFJFCOEJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB60", Offset = "0xA6E560", VA = "0x180A6FB60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EEALFJDFGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3E50060", Offset = "0x3E4EA60", VA = "0x183E50060")]
		public LJHKKOIOBDL(NativeArray<TSrc> KKAKPOKBAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FF70", Offset = "0x3E4E970", VA = "0x183E4FF70")]
		public bool FFFNJOFKODI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FF80", Offset = "0x3E4E980", VA = "0x183E4FF80")]
		private TSrc JFGPHPKIMNL(int AJODNFJNJPO)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct GKPPOAMLIGG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FIHBFFNNAHM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private LJHKKOIOBDL<TSrc, TValue, TSelector> GKPKKDMKOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue JIMKHDCOPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int ALMDOMLFINK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FLIICHHCFKO FDEGKHKOOMF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3993610", Offset = "0x3992010", VA = "0x183993610")]
			get
			{
				return default(FLIICHHCFKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue LPFLEHBBIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, FLIICHHCFKO range) EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3993650", Offset = "0x3992050", VA = "0x183993650")]
			get
			{
				return default((TValue, FLIICHHCFKO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3993880", Offset = "0x3992280", VA = "0x183993880")]
		public GKPPOAMLIGG(NativeArray<TSrc> KKAKPOKBAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3993860", Offset = "0x3992260", VA = "0x183993860")]
		public GKPPOAMLIGG<TSrc, TValue, TSelector> HOEJGHKHDAP()
		{
			return default(GKPPOAMLIGG<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3993720", Offset = "0x3992120", VA = "0x183993720")]
		public bool FFFNJOFKODI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2808960", Offset = "0x2807360", VA = "0x182808960")]
	public static KCKKEEOOLEN<T> BIJDLALEIEL<T>(this NativeList<T> GOJPHGMMOOM) where T : struct
	{
		return default(KCKKEEOOLEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
	public static KCKKEEOOLEN<T> BIJDLALEIEL<T>(this NativeArray<T> KKAKPOKBAHF) where T : struct
	{
		return default(KCKKEEOOLEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class MCDPGFBAOEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct OJGMOOFHJEN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly KKAKPOKBAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int ALMDOMLFINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int GKEOFPOJMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T JIMKHDCOPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T JIMEKLGBGKP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FLIICHHCFKO FDEGKHKOOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4218C20", Offset = "0x4217620", VA = "0x184218C20")]
			get
			{
				return default(FLIICHHCFKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T LPFLEHBBIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x357F1C0", Offset = "0x357DBC0", VA = "0x18357F1C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, FLIICHHCFKO) EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4218CD0", Offset = "0x42176D0", VA = "0x184218CD0")]
			get
			{
				return default((T, FLIICHHCFKO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x42191E0", Offset = "0x4217BE0", VA = "0x1842191E0")]
		public OJGMOOFHJEN(NativeArray<T> KKAKPOKBAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4219130", Offset = "0x4217B30", VA = "0x184219130")]
		public OJGMOOFHJEN<T> HOEJGHKHDAP()
		{
			return default(OJGMOOFHJEN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4218DA0", Offset = "0x42177A0", VA = "0x184218DA0")]
		public bool FFFNJOFKODI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28C80F0", Offset = "0x28C6AF0", VA = "0x1828C80F0")]
		public BAHIOIAJHDB<T, TComparer> LEMEAJHODGN<TComparer>([Optional] TComparer NHAPOEAGAIE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BAHIOIAJHDB<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct BAHIOIAJHDB<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly KKAKPOKBAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int ALMDOMLFINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int GKEOFPOJMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T JIMKHDCOPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T JIMEKLGBGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer NHAPOEAGAIE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FLIICHHCFKO FDEGKHKOOMF
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x4218C20", Offset = "0x4217620", VA = "0x184218C20")]
			get
			{
				return default(FLIICHHCFKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T LPFLEHBBIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x357F1C0", Offset = "0x357DBC0", VA = "0x18357F1C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x49219A0", Offset = "0x49203A0", VA = "0x1849219A0")]
		public BAHIOIAJHDB(NativeArray<T>.ReadOnly KKAKPOKBAHF, TComparer NHAPOEAGAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x49217D0", Offset = "0x49201D0", VA = "0x1849217D0")]
		public bool FFFNJOFKODI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B2A0", Offset = "0x2A19CA0", VA = "0x182A1B2A0")]
	public static OJGMOOFHJEN<T> NOECOCFEEOL<T>(this NativeArray<T> KKAKPOKBAHF) where T : struct
	{
		return default(OJGMOOFHJEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface LAIKKJGLOIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class EHCBNAJNPIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IFNJLMOGFOI<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class IIADHAGMMJB : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public IFNJLMOGFOI<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xB019B0", Offset = "0xB003B0", VA = "0x180B019B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3900FF0", Offset = "0x38FF9F0", VA = "0x183900FF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
		[DebuggerHidden]
		public IIADHAGMMJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB600", Offset = "0x3ABA000", VA = "0x183ABB600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB7B0", Offset = "0x3ABA1B0", VA = "0x183ABB7B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> LFPNCPNJAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream GHKIPMIFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream COFCDOMBAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf CMCELNBGPLK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int EEALFJDFGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3A30", Offset = "0x3AB2430", VA = "0x183AB3A30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3A70", Offset = "0x3AB2470", VA = "0x183AB3A70", Slot = "4")]
	[IteratorStateMachine(typeof(IFNJLMOGFOI<>.IIADHAGMMJB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3B60", Offset = "0x3AB2560", VA = "0x183AB3B60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct CHGILDCKJJI<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] PJIBFCJPNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf CMCELNBGPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream GHKIPMIFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream KHPJNBLDHHI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4AB38D0", Offset = "0x4AB22D0", VA = "0x184AB38D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct BBLFCCMLKIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream GHKIPMIFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream COFCDOMBAJH;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6410230", Offset = "0x640EC30", VA = "0x186410230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct IALJBOGJLOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] PJIBFCJPNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GHKIPMIFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream KHPJNBLDHHI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64105B0", Offset = "0x640EFB0", VA = "0x1864105B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BHCAFBOHBGA
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class DGFOPCFBEOJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum MEJOJPAHBMH
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
internal static class DGOAIFIDFGB
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FJLMCBABILJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FJLMCBABILJ()
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
