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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x7983F30", Offset = "0x7983330", VA = "0x187983F30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
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
		[Cpp2IlInjected.Address(RVA = "0x7983A00", Offset = "0x7982E00", VA = "0x187983A00")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OFEGFLMHALN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JBNKJPBAHJL CGOCJGMFHNK
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
public interface ADLGLEMDCBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPNAJIDNPIG(Entity PPBBFEJHKOL, object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POICBMACFHD(Entity PPBBFEJHKOL, object HEJFDMJNIGB, [Out] bool HPOHGGIAEKD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJJBPEGAENO(Entity PPBBFEJHKOL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HKOLEDIOIFL<TComponentData, TValue> : CLBPDJNKOCE<TValue>, IDisposable where TComponentData : struct, OFEGFLMHALN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class MODOECFBLKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> JMHKEMEJOPH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int DLMGPHHMEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3E73790", Offset = "0x3E72B90", VA = "0x183E73790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4FA4250", Offset = "0x4FA3650", VA = "0x184FA4250")]
		public bool ALNFBDJNNFC([Out] TValue FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4FA4410", Offset = "0x4FA3810", VA = "0x184FA4410")]
		public void LLICHLCEEGA(object HEJFDMJNIGB, TValue FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4FA4360", Offset = "0x4FA3760", VA = "0x184FA4360")]
		public bool FBDLIPAFCGJ(object HEJFDMJNIGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4FA44F0", Offset = "0x4FA38F0", VA = "0x184FA44F0")]
		public int PHPPPHPHCBN(object HEJFDMJNIGB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4FA45D0", Offset = "0x4FA39D0", VA = "0x184FA45D0")]
		public MODOECFBLKO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<MODOECFBLKO> MJJONNBKNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OCIHKBLGDJN<JBNKJPBAHJL, MODOECFBLKO> BEKGDAANEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager EDIIKMBGJIA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4892E00", Offset = "0x4892200", VA = "0x184892E00")]
	public HKOLEDIOIFL(EntityManager EDIIKMBGJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4892770", Offset = "0x4891B70", VA = "0x184892770", Slot = "4")]
	public void DPNAJIDNPIG(Entity PPBBFEJHKOL, object HEJFDMJNIGB, TValue FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4892C10", Offset = "0x4892010", VA = "0x184892C10", Slot = "5")]
	public bool POICBMACFHD(Entity PPBBFEJHKOL, object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48925A0", Offset = "0x48919A0", VA = "0x1848925A0", Slot = "6")]
	public bool ALNFBDJNNFC(Entity PPBBFEJHKOL, [Out] TValue FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x48928F0", Offset = "0x4891CF0", VA = "0x1848928F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48926B0", Offset = "0x4891AB0", VA = "0x1848926B0")]
	private void BFDKOJDOBEA(MODOECFBLKO PGJADLDNKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4892B50", Offset = "0x4891F50", VA = "0x184892B50")]
	private bool KDEOEJCOKAC(Entity PPBBFEJHKOL, [Out] JBNKJPBAHJL ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4892A50", Offset = "0x4891E50", VA = "0x184892A50")]
	private void IJHCHODGCGL(Entity PPBBFEJHKOL, JBNKJPBAHJL ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4892910", Offset = "0x4891D10", VA = "0x184892910")]
	private bool GLKBGCCDNFG(JBNKJPBAHJL ENGGEIHHCEE, [Out] MODOECFBLKO PGJADLDNKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4892930", Offset = "0x4891D30", VA = "0x184892930")]
	private MODOECFBLKO GPKHPPHNGBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CLBPDJNKOCE<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPNAJIDNPIG(Entity PPBBFEJHKOL, object HEJFDMJNIGB, TValue FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POICBMACFHD(Entity PPBBFEJHKOL, object HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALNFBDJNNFC(Entity PPBBFEJHKOL, [Out] TValue FIIKLGCIAGG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JBNKJPBAHJL : GLCINBGBILH, IEquatable<JBNKJPBAHJL>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JBNKJPBAHJL DBEDOALFIKK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int BNBIOAJGDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8E0", Offset = "0x9DCCE0", VA = "0x1809DD8E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11A6020", Offset = "0x11A5420", VA = "0x1811A6020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int KIPMDJJPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A510", Offset = "0x2C89910", VA = "0x182C8A510", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A94680", Offset = "0x6A93A80", VA = "0x186A94680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7983DA0", Offset = "0x79831A0", VA = "0x187983DA0", Slot = "8")]
	public bool Equals(JBNKJPBAHJL JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7983DF0", Offset = "0x79831F0", VA = "0x187983DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DFIGBLCHPFE<THasTokensTag> : ADLGLEMDCBL, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, JBNKJPBAHJL> NAJJAKMOFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> MJJONNBKNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private OCIHKBLGDJN<JBNKJPBAHJL, HashSet<object>> BEKGDAANEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager EDIIKMBGJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem KHCHOPBHPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x65C4590", Offset = "0x65C3990", VA = "0x1865C4590")]
	public DFIGBLCHPFE(EntityManager EDIIKMBGJIA, EntityCommandBufferSystem KHCHOPBHPID, ABDDJEPKCOD LBMKGCOEIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65C1730", Offset = "0x65C0B30", VA = "0x1865C1730", Slot = "4")]
	public bool DPNAJIDNPIG(Entity PPBBFEJHKOL, object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65C3EF0", Offset = "0x65C32F0", VA = "0x1865C3EF0", Slot = "5")]
	public bool POICBMACFHD(Entity PPBBFEJHKOL, object HEJFDMJNIGB, [Out] bool HPOHGGIAEKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65C31B0", Offset = "0x65C25B0", VA = "0x1865C31B0", Slot = "6")]
	public bool PJJBPEGAENO(Entity PPBBFEJHKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65C33C0", Offset = "0x65C27C0", VA = "0x1865C33C0", Slot = "8")]
	public bool PJJBPEGAENO(JBNKJPBAHJL ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65C1EF0", Offset = "0x65C12F0", VA = "0x1865C1EF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65C16C0", Offset = "0x65C0AC0", VA = "0x1865C16C0")]
	private void BFDKOJDOBEA(HashSet<object> PGJADLDNKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65C2930", Offset = "0x65C1D30", VA = "0x1865C2930")]
	private bool KDEOEJCOKAC(Entity PPBBFEJHKOL, [Out] JBNKJPBAHJL ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65C2F70", Offset = "0x65C2370", VA = "0x1865C2F70")]
	private bool PHAOBBNDDPE(Entity PPBBFEJHKOL, [Out] JBNKJPBAHJL ENGGEIHHCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65C24F0", Offset = "0x65C18F0", VA = "0x1865C24F0")]
	private void HAPCDHJOHAO(Entity PPBBFEJHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x65C3520", Offset = "0x65C2920", VA = "0x1865C3520")]
	private void PNOLGJFHJJC(Entity PPBBFEJHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65C2C30", Offset = "0x65C2030", VA = "0x1865C2C30")]
	private void NCFGAPIIPHE(Entity PPBBFEJHKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65C27E0", Offset = "0x65C1BE0", VA = "0x1865C27E0")]
	private void IJHCHODGCGL(Entity PPBBFEJHKOL, JBNKJPBAHJL ENGGEIHHCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x65C2710", Offset = "0x65C1B10", VA = "0x1865C2710")]
	private bool ICHKKDBDGKP(JBNKJPBAHJL ENGGEIHHCEE, [Out] HashSet<object> PGJADLDNKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x65C2010", Offset = "0x65C1410", VA = "0x1865C2010")]
	private HashSet<object> GPKHPPHNGBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PHEAKJBBIFM
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OIOKJHPBJPG : CFEKPOOKCAL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7983FB0", Offset = "0x79833B0", VA = "0x187983FB0")]
	public float NHIAKGOHIGD([In] float3 FIIKLGCIAGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7983FB0", Offset = "0x79833B0", VA = "0x187983FB0", Slot = "4")]
	private float DDCCKNCMBHO([In] float3 FIIKLGCIAGG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LIJLGJMOPCI : CFEKPOOKCAL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7983E80", Offset = "0x7983280", VA = "0x187983E80")]
	public float NHIAKGOHIGD([In] float3 FIIKLGCIAGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7983E80", Offset = "0x7983280", VA = "0x187983E80", Slot = "4")]
	private float DDCCKNCMBHO([In] float3 FIIKLGCIAGG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GFPCDCJPEAJ : CFEKPOOKCAL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xDAE170", Offset = "0xDAD570", VA = "0x180DAE170")]
	public float NHIAKGOHIGD([In] float3 FIIKLGCIAGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xDAE170", Offset = "0xDAD570", VA = "0x180DAE170", Slot = "4")]
	private float DDCCKNCMBHO([In] float3 FIIKLGCIAGG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BHMKCEHLOPM : CFEKPOOKCAL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x20137E0", Offset = "0x2012BE0", VA = "0x1820137E0")]
	public int NHIAKGOHIGD([In] int3 FIIKLGCIAGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20137E0", Offset = "0x2012BE0", VA = "0x1820137E0", Slot = "4")]
	private int JDEFECKHEJP([In] int3 FIIKLGCIAGG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ODDCIEAMDNO : CFEKPOOKCAL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE40910", Offset = "0xE3FD10", VA = "0x180E40910")]
	public int NHIAKGOHIGD([In] int3 FIIKLGCIAGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xE40910", Offset = "0xE3FD10", VA = "0x180E40910", Slot = "4")]
	private int JDEFECKHEJP([In] int3 FIIKLGCIAGG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LCMGGOKDLCD : CFEKPOOKCAL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xD932F0", Offset = "0xD926F0", VA = "0x180D932F0")]
	public int NHIAKGOHIGD([In] int3 FIIKLGCIAGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD932F0", Offset = "0xD926F0", VA = "0x180D932F0", Slot = "4")]
	private int JDEFECKHEJP([In] int3 FIIKLGCIAGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DKCEAPGJLPJ : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F20DC0", Offset = "0x1F201C0", VA = "0x181F20DC0")]
	public DKCEAPGJLPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class AKIFIDDOCJA : SystemBase, JDGLMBCGAGO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79830C0", Offset = "0x79824C0", VA = "0x1879830C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D64C60", Offset = "0x3D64060", VA = "0x183D64C60")]
	public void AECBHILDAMK<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D64C60", Offset = "0x3D64060", VA = "0x183D64C60")]
	public void PHNFPFEBFOL<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7982F70", Offset = "0x7982370", VA = "0x187982F70")]
	public JobHandle BDBKINJLDII(ReadOnlySpan<int> DLCPGJAMMIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D65AA0", Offset = "0x3D64EA0", VA = "0x183D65AA0")]
	public JobHandle NJJCHALMHFB<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7983150", Offset = "0x7982550", VA = "0x187983150")]
	public JobHandle NJJCHALMHFB(ReadOnlySpan<int> DLCPGJAMMIE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D64DE0", Offset = "0x3D641E0", VA = "0x183D64DE0")]
	public void KMDCCIHCMNG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D65110", Offset = "0x3D64510", VA = "0x183D65110")]
	public JobHandle KMDCCIHCMNG<T>(JobHandle ENGGEIHHCEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7983050", Offset = "0x7982450", VA = "0x187983050")]
	public JobHandle KMDCCIHCMNG(ReadOnlySpan<int> DLCPGJAMMIE, JobHandle ENGGEIHHCEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D64DE0", Offset = "0x3D641E0", VA = "0x183D64DE0")]
	public void CCBMGPLCLKI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D64E70", Offset = "0x3D64270", VA = "0x183D64E70")]
	public JobHandle CCBMGPLCLKI<T>(JobHandle ENGGEIHHCEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7982FC0", Offset = "0x79823C0", VA = "0x187982FC0")]
	public JobHandle CCBMGPLCLKI(Span<int> DLCPGJAMMIE, JobHandle ENGGEIHHCEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D65B50", Offset = "0x3D64F50", VA = "0x183D65B50")]
	public ComponentDataFromEntity PPCGLCDDFEM<T>(bool MCGHHBDAMGJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79831A0", Offset = "0x79825A0", VA = "0x1879831A0")]
	public ComponentDataFromEntity PPCGLCDDFEM(int DIPHMNABJON, bool MCGHHBDAMGJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D659D0", Offset = "0x3D64DD0", VA = "0x183D659D0")]
	public SharedComponentIndexFromEntity<T> MEEKBCJPANJ<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79830F0", Offset = "0x79824F0", VA = "0x1879830F0")]
	[BurstCompatible]
	public ComponentTypeHandle NAEGJEKPBEA(ComponentType MJBALOBGKLJ)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7983030", Offset = "0x7982430", VA = "0x187983030")]
	public EntityExistenceLookupByEntity FIBDNEHCJME()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7983260", Offset = "0x7982660", VA = "0x187983260", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D64CC0", Offset = "0x3D640C0", VA = "0x183D64CC0")]
	public bool AGDBMIDGLDJ<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F20DC0", Offset = "0x1F201C0", VA = "0x181F20DC0")]
	protected AKIFIDDOCJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class OPLNFFIANGJ : AKIFIDDOCJA
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7983FC0", Offset = "0x79833C0", VA = "0x187983FC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F20DC0", Offset = "0x1F201C0", VA = "0x181F20DC0")]
	protected OPLNFFIANGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CJGCPLKHDJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PIJIFDAJAFL : EntityCommandBufferSystem, JDGLMBCGAGO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ABDDJEPKCOD DLBCFJLNCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCC24E0", Offset = "0xCC18E0", VA = "0x180CC24E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7984260", Offset = "0x7983660", VA = "0x187984260")]
	public PIJIFDAJAFL(ABDDJEPKCOD LEMJHEDOKDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CFEKPOOKCAL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NHIAKGOHIGD([In] TFrom FIIKLGCIAGG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PAGKHIPOGDH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADCJEIFOFFC(T FIIKLGCIAGG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct IAPEBLEFOML : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer BACOPLMMJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes IGDMPNNFGNO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7983CB0", Offset = "0x79830B0", VA = "0x187983CB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct DANBPIKDMOB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer BACOPLMMJNN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x79835B0", Offset = "0x79829B0", VA = "0x1879835B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct BOOOHKHFAKI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer BACOPLMMJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType MJBALOBGKLJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7983270", Offset = "0x7982670", VA = "0x187983270", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct HCKNIJPPBOP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> AMHCLKHIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer BACOPLMMJNN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4877B30", Offset = "0x4876F30", VA = "0x184877B30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct EDCLADPBGIJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> EDJBENPLFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer BACOPLMMJNN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct ODFNFKCPOGM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T FIIKLGCIAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer BACOPLMMJNN;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct KOMEHKKMGAP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, CFEKPOOKCAL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> LPKMLGLNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> FEEHMNKKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap AKLHLNJOCEK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct HDKNNJCADBJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity LMGLOFGMGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> LPKMLGLNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> FEEHMNKKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int MBFKDOKKKGC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7983BB0", Offset = "0x7982FB0", VA = "0x187983BB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct CPIEJMLPGIL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OMGLPBCCMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> LPKMLGLNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> ALKDDMBIAPO;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct EGGNONCODGN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, CFEKPOOKCAL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> KJIAGPLCPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> FEEHMNKKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap AKLHLNJOCEK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct FAAEAFBPKGK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OFKKLELOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> JKICNMBMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> JGJFGJGIJOB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct HDJIEBPFBGJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OFKKLELOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> JKICNMBMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> JGJFGJGIJOB;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x487A7C0", Offset = "0x4879BC0", VA = "0x18487A7C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct LPFNKJAFPJM<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> LPKMLGLNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> ALKDDMBIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> DALNELLCDHC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4D983F0", Offset = "0x4D977F0", VA = "0x184D983F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HCEHLCKJNBC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : CFEKPOOKCAL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> LPKMLGLNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> ALKDDMBIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> DALNELLCDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap AKLHLNJOCEK;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct EFDBMOAPOLF<T, TPredicate> : IJob where T : struct where TPredicate : struct, PAGKHIPOGDH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> LPKMLGLNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> JDOAKFNLKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> DLFLGCFMFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate AKLHLNJOCEK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct LPCFHBOCFME<T, TPredicate> : IJob where T : struct where TPredicate : struct, PAGKHIPOGDH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> LPKMLGLNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> ALKDDMBIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate AKLHLNJOCEK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct LNMNJFMLEBJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity OFKKLELOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> JKICNMBMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> FMGGFGBDJGL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7983E90", Offset = "0x7983290", VA = "0x187983E90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct ACLLGHPBNKC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity OFKKLELOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> JKICNMBMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> FMGGFGBDJGL;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7982EE0", Offset = "0x79822E0", VA = "0x187982EE0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DGNNFMNIBIA
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class IOKDIBLMJFJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3664530", Offset = "0x3663930", VA = "0x183664530")]
	public static bool AKIMIFCKPNL<T>(this NativeArray<Entity> JKICNMBMPKD, EntityManager EDIIKMBGJIA, Allocator LENIJMBFHJK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PCAHBCPJGBH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JDGPIJEHCGE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public JDGPIJEHCGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GAFCLFEGAIC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public GAFCLFEGAIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> GHHFPCFEPCG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7983FF0", Offset = "0x79833F0", VA = "0x187983FF0")]
	public PCAHBCPJGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IIOMNEAFLAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NOKJBDCFPIN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct EEOEBOGFEBF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct CHAILAOLGKK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal EEOEBOGFEBF<TFrom> PBIFOHNGFLL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> ICAPBAKKPBL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct NFICGHKIOJG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JGMKLPEILCM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal NFICGHKIOJG<TFrom> PBIFOHNGFLL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> ICAPBAKKPBL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct COOIIJFKNEF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct EOGHOGMKDPI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal COOIIJFKNEF<TFrom> PBIFOHNGFLL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> ICAPBAKKPBL;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct PAEFBKDDHKO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct BNGHPFDIILN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal PAEFBKDDHKO<TFrom> PBIFOHNGFLL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> ICAPBAKKPBL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EBGHPJJJMDB
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IJOBDFDJINE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3659800", Offset = "0x3658C00", VA = "0x183659800")]
	public static NativeList<T> HGPBJBAKDFK<T>(this NativeArray<T> NNBDIDMOBNM, Allocator LENIJMBFHJK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AAMDIKIGBBE
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CELLFGLDPEK
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x33BF160", Offset = "0x33BE560", VA = "0x1833BF160")]
	[PMKHAKGFINM]
	public static JobHandle ANBKPHIMBEM<T>(this EntityCommandBufferSystem KHCHOPBHPID, NativeArray<Entity> CCIGPBFJEAO, NativeArray<T> AMHCLKHIFKH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x33BEE60", Offset = "0x33BE260", VA = "0x1833BEE60")]
	[PMKHAKGFINM]
	public static JobHandle ANBKPHIMBEM<T>(this EntityCommandBufferSystem KHCHOPBHPID, NativeArrayAsync<Entity> CCIGPBFJEAO, NativeArrayAsync<T> AMHCLKHIFKH, [Optional] JobHandle BODEMHDIPOA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x33BED30", Offset = "0x33BE130", VA = "0x1833BED30")]
	[PMKHAKGFINM]
	public static JobHandle ANBKPHIMBEM<T>(this EntityCommandBufferSystem KHCHOPBHPID, NativeArray<Entity> CCIGPBFJEAO, [Optional] JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7983440", Offset = "0x7982840", VA = "0x187983440")]
	[PMKHAKGFINM]
	public static JobHandle ANBKPHIMBEM(this EntityCommandBufferSystem KHCHOPBHPID, NativeArray<Entity> CCIGPBFJEAO, ComponentTypes IGDMPNNFGNO, [Optional] JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x79832F0", Offset = "0x79826F0", VA = "0x1879832F0")]
	[PMKHAKGFINM]
	public static JobHandle ANBKPHIMBEM(this EntityCommandBufferSystem KHCHOPBHPID, EntityCommandBuffer BACOPLMMJNN, NativeArray<Entity> CCIGPBFJEAO, ComponentTypes IGDMPNNFGNO, [Optional] JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DMGFOMLOPNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DMJINLGPIDM
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7983870", Offset = "0x7982C70", VA = "0x187983870")]
	[PMKHAKGFINM]
	public static JobHandle PBCBOBLHNCL(this EntityCommandBufferSystem KHCHOPBHPID, NativeList<Entity> CCIGPBFJEAO, [Optional] JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7983770", Offset = "0x7982B70", VA = "0x187983770")]
	[PMKHAKGFINM]
	public static JobHandle PBCBOBLHNCL(this EntityCommandBufferSystem KHCHOPBHPID, NativeArrayAsync<Entity> CCIGPBFJEAO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FBAHJDCHJIE
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x358F9E0", Offset = "0x358EDE0", VA = "0x18358F9E0")]
	[PMKHAKGFINM]
	public static JobHandle LIHOKIILKAJ<T>(this EntityCommandBufferSystem KHCHOPBHPID, NativeArrayAsync<Entity> CCIGPBFJEAO, [Optional] JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7983A20", Offset = "0x7982E20", VA = "0x187983A20")]
	[PMKHAKGFINM]
	public static JobHandle LIHOKIILKAJ(this EntityCommandBufferSystem KHCHOPBHPID, NativeArrayAsync<Entity> CCIGPBFJEAO, ComponentType MJBALOBGKLJ, [Optional] JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GGJLLOEKLEE
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x35BD1D0", Offset = "0x35BC5D0", VA = "0x1835BD1D0")]
	[PMKHAKGFINM]
	public static JobHandle PHJOGBJHHBK<T>(this EntityCommandBufferSystem KHCHOPBHPID, NativeArray<Entity> CCIGPBFJEAO, NativeArray<T> AMHCLKHIFKH, JobHandle BODEMHDIPOA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AILPMFCJHAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DPKFNHKJLHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PGOKBCLCHKH
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x37E4670", Offset = "0x37E3A70", VA = "0x1837E4670")]
	public static NativeArray<T> LODIAINBBKH<T>(this NativeList<Entity> NNBDIDMOBNM, EntityManager EDIIKMBGJIA, Allocator LENIJMBFHJK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x37E4490", Offset = "0x37E3890", VA = "0x1837E4490")]
	public static NativeArray<T> LODIAINBBKH<T>(this NativeArray<Entity> NNBDIDMOBNM, EntityManager EDIIKMBGJIA, Allocator LENIJMBFHJK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7984080", Offset = "0x7983480", VA = "0x187984080")]
	public static NativeArray<Entity> ECELHGODIIC(this NativeArray<Entity> NNBDIDMOBNM, EntityManager EDIIKMBGJIA, ComponentType MJBALOBGKLJ, Allocator LENIJMBFHJK = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37E4390", Offset = "0x37E3790", VA = "0x1837E4390")]
	public static NativeArray<T> CDCKAHIEOFJ<T>(this NativeArray<Entity> NNBDIDMOBNM, EntityManager EDIIKMBGJIA, Allocator LENIJMBFHJK = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class FPFBKENNLFI
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct LCMOIHGPEHO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct EIDFACLNNBN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public LCMOIHGPEHO<TFrom> ICAPBAKKPBL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> LPKMLGLNPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct KHLCNPEMNON<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct AFAFLHBFHMK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public KHLCNPEMNON<TFrom> ICAPBAKKPBL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> LPKMLGLNPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct JFNDFHHBCHL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct CHEBPGJKBCF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public JFNDFHHBCHL<TFrom> ICAPBAKKPBL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> LPKMLGLNPKH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HAGBAHOFPJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class APBGANLDAFC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct LPDPNHIEIOL : CFEKPOOKCAL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> HKAIMIGDEDB;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7983F20", Offset = "0x7983320", VA = "0x187983F20")]
		[BurstCompatible]
		public Entity NHIAKGOHIGD([In] Entity FIIKLGCIAGG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7983F20", Offset = "0x7983320", VA = "0x187983F20", Slot = "4")]
		private Entity HOBFHONIIDE([In] Entity FIIKLGCIAGG)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class LAOODMKPALN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct JHFEAFHONKP<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4BE69C0", Offset = "0x4BE5DC0", VA = "0x184BE69C0", Slot = "4")]
		public int Compare((TKey, TValue) JFJPEDLJOKC, (TKey, TValue) MJINJIJLGDP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x36B98E0", Offset = "0x36B8CE0", VA = "0x1836B98E0")]
	public static void GPBEGJIEFPH<TKey, TValue>(NativeList<TKey> MKCLAIOIKNO, NativeList<TValue> EDJBENPLFOA) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x36B9710", Offset = "0x36B8B10", VA = "0x1836B9710")]
	public static void GPBEGJIEFPH<TKey, TValue>(NativeArray<TKey> MKCLAIOIKNO, NativeArray<TValue> EDJBENPLFOA) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x36B9B70", Offset = "0x36B8F70", VA = "0x1836B9B70")]
	public static void GPBEGJIEFPH<TKey, TValue, U>(NativeArray<TKey> MKCLAIOIKNO, NativeArray<TValue> EDJBENPLFOA, U BFIKMGGACPA) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class KDBLBALHMGP
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct JLKEOJPGFDF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> JDOAKFNLKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> LPKMLGLNPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct IGJACGOKDFB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> JDOAKFNLKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> LPKMLGLNPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct NLMADOFNHKK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> JDOAKFNLKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> LPKMLGLNPKH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class LADBEPGOEAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LPHAHKDGHND
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct PDDDPOLPLEP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> LPKMLGLNPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct IINLGIGHHOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> LPKMLGLNPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct OFLIBBIFBMC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> LPKMLGLNPKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct HDJDBJOJGND<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator LENIJMBFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> LPKMLGLNPKH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class KOEPNAIAFNE
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class BHAEKPCIENK
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x335D080", Offset = "0x335C480", VA = "0x18335D080")]
	public static NativeList<Entity> PAADGCEODNE<T>(this NativeList<Entity> JKICNMBMPKD, EntityManager EDIIKMBGJIA, Allocator LENIJMBFHJK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x335CA40", Offset = "0x335BE40", VA = "0x18335CA40")]
	public static NativeList<Entity> PAADGCEODNE<T>(this NativeArray<Entity> JKICNMBMPKD, EntityManager EDIIKMBGJIA, Allocator LENIJMBFHJK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class OBEPCOLEMCG
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37C5840", Offset = "0x37C4C40", VA = "0x1837C5840")]
	public static NativeList<Entity> KBDMHKMAIAO<T>(this NativeArray<Entity> JKICNMBMPKD, EntityManager EDIIKMBGJIA, Allocator LENIJMBFHJK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class PIOOBCAHHNE
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct MOBHFEMNHAA<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> KCPGIJAPEHH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct KFKLLEGOIMO<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> KCPGIJAPEHH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct LFIKAPHICFJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, CFEKPOOKCAL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> KCPGIJAPEHH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GIGGLMBBBBE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, CFEKPOOKCAL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> KCPGIJAPEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector MOEOMDFBGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int KDCAMOIGIMA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NJKFFKPAOCM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, CFEKPOOKCAL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private GIGGLMBBBBE<TSrc, TValue, TSelector> BLIPHGJEAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue JDMOPDGDBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int FOGJBEMBBDP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class PPBHEBCOAEP
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct MDHJAMOLKFD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> KCPGIJAPEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FOGJBEMBBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int BJBAAIJPMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T JDMOPDGDBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T GDNONJILGHN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JMJNMGPMDKG DIFGHMJDLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4CCE190", Offset = "0x4CCD590", VA = "0x184CCE190")]
			get
			{
				return default(JMJNMGPMDKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T CKEKOAGMMFH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, JMJNMGPMDKG) NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4CCDFA0", Offset = "0x4CCD3A0", VA = "0x184CCDFA0")]
			get
			{
				return default((T, JMJNMGPMDKG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4F68BD0", Offset = "0x4F67FD0", VA = "0x184F68BD0")]
		public MDHJAMOLKFD(NativeArray<T> KCPGIJAPEHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x43651E0", Offset = "0x43645E0", VA = "0x1843651E0")]
		public MDHJAMOLKFD<T> NHFIHKFCIDL()
		{
			return default(MDHJAMOLKFD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4F68A70", Offset = "0x4F67E70", VA = "0x184F68A70")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3BA7B20", Offset = "0x3BA6F20", VA = "0x183BA7B20")]
		public KEGIMLBEMAM<T, TComparer> KJCFBGGKLND<TComparer>([Optional] TComparer BFIKMGGACPA) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KEGIMLBEMAM<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct KEGIMLBEMAM<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> KCPGIJAPEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int FOGJBEMBBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int BJBAAIJPMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T JDMOPDGDBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T GDNONJILGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer BFIKMGGACPA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JMJNMGPMDKG DIFGHMJDLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4CCE190", Offset = "0x4CCD590", VA = "0x184CCE190")]
			get
			{
				return default(JMJNMGPMDKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T CKEKOAGMMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, JMJNMGPMDKG range) NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4CCDFA0", Offset = "0x4CCD3A0", VA = "0x184CCDFA0")]
			get
			{
				return default((T, JMJNMGPMDKG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE410", Offset = "0x4CCD810", VA = "0x184CCE410")]
		public KEGIMLBEMAM(NativeArray<T> KCPGIJAPEHH, TComparer BFIKMGGACPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x341B910", Offset = "0x341AD10", VA = "0x18341B910")]
		public KEGIMLBEMAM<T, TComparer> NHFIHKFCIDL()
		{
			return default(KEGIMLBEMAM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE250", Offset = "0x4CCD650", VA = "0x184CCE250")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37F6820", Offset = "0x37F5C20", VA = "0x1837F6820")]
	public static MDHJAMOLKFD<T> LLKEEODDOPG<T>(this NativeArray<T> KCPGIJAPEHH) where T : struct
	{
		return default(MDHJAMOLKFD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface HCAGLANIEOC
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MECJBFIDECH
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct JEOKPDPMCFF<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class JCDMFHPGLNI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JEOKPDPMCFF<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xB47C60", Offset = "0xB47060", VA = "0x180B47C60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x47A6DF0", Offset = "0x47A61F0", VA = "0x1847A6DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public JCDMFHPGLNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9930", Offset = "0x4BC8D30", VA = "0x184BC9930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9B00", Offset = "0x4BC8F00", VA = "0x184BC9B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> HNEFKHNGMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream FEFFODEJHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream ONBECKDLOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf LPHDHPNCHAO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4BD2A90", Offset = "0x4BD1E90", VA = "0x184BD2A90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4BD2AD0", Offset = "0x4BD1ED0", VA = "0x184BD2AD0", Slot = "4")]
	[IteratorStateMachine(typeof(JEOKPDPMCFF<>.JCDMFHPGLNI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4BD2BD0", Offset = "0x4BD1FD0", VA = "0x184BD2BD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FICBGGLLMMG<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] GODPNOEEIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf LPHDHPNCHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream FEFFODEJHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream KKDHEBFAPOL;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x46E5470", Offset = "0x46E4870", VA = "0x1846E5470", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KGGOHIJGOMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream FEFFODEJHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream ONBECKDLOPB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7983E40", Offset = "0x7983240", VA = "0x187983E40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DFHGFCNHDAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] GODPNOEEIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream FEFFODEJHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream KKDHEBFAPOL;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7983650", Offset = "0x7982A50", VA = "0x187983650", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OBJJKFCGFDE
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GLMGCHNJJNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum FIJOAGLJDJL
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
internal static class IEOOGOCIEOI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DAKAGJPPDPP
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public DAKAGJPPDPP()
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
