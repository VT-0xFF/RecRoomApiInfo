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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A7EBC0", Offset = "0x7A7D5C0", VA = "0x187A7EBC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A7DCB0", Offset = "0x7A7C6B0", VA = "0x187A7DCB0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GCMDOONGFHE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FLLMDNHGNBM AJONEENKLFO
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
public interface IBNGEGEAFBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMOPENGNFEF(Entity CGNAGBGLBDK, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHIGPKHDHPL(Entity CGNAGBGLBDK, object GNAAILLDOKI, [Out] bool GOCOBHACAID);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IMJFLDMBKPB(Entity CGNAGBGLBDK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LINPLAEOBFJ<TComponentData, TValue> : BPEMIMBDOKG<TValue>, IDisposable where TComponentData : struct, GCMDOONGFHE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class BKBHLKAOCGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> FMFEHIEKOMI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int NIAGHPMMKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3EC87C0", Offset = "0x3EC71C0", VA = "0x183EC87C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6487B90", Offset = "0x6486590", VA = "0x186487B90")]
		public bool ALLAFFFAMCD([Out] TValue PPJFMHBDGNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6487E30", Offset = "0x6486830", VA = "0x186487E30")]
		public void HEHCILJMFIP(object GNAAILLDOKI, TValue PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6487D80", Offset = "0x6486780", VA = "0x186487D80")]
		public bool CBCJJMKDJJC(object GNAAILLDOKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6487CA0", Offset = "0x64866A0", VA = "0x186487CA0")]
		public int BNJEHECAOFH(object GNAAILLDOKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6487F10", Offset = "0x6486910", VA = "0x186487F10")]
		public BKBHLKAOCGH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<BKBHLKAOCGH> BCIGEGHLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OAGNPLEFMGD<FLLMDNHGNBM, BKBHLKAOCGH> KJEJHPLKOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager IOCALHHKFGN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF5E0", Offset = "0x4ECDFE0", VA = "0x184ECF5E0")]
	public LINPLAEOBFJ(EntityManager IOCALHHKFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4ECEFB0", Offset = "0x4ECD9B0", VA = "0x184ECEFB0", Slot = "4")]
	public void BMOPENGNFEF(Entity CGNAGBGLBDK, object GNAAILLDOKI, TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF210", Offset = "0x4ECDC10", VA = "0x184ECF210", Slot = "5")]
	public bool FHIGPKHDHPL(Entity CGNAGBGLBDK, object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4ECED80", Offset = "0x4ECD780", VA = "0x184ECED80", Slot = "6")]
	public bool ALLAFFFAMCD(Entity CGNAGBGLBDK, [Out] TValue PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF1F0", Offset = "0x4ECDBF0", VA = "0x184ECF1F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF130", Offset = "0x4ECDB30", VA = "0x184ECF130")]
	private void CJAPDLMDGEK(BKBHLKAOCGH NNBPOKGINNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF520", Offset = "0x4ECDF20", VA = "0x184ECF520")]
	private bool NOJPDOMEAAP(Entity CGNAGBGLBDK, [Out] FLLMDNHGNBM ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF420", Offset = "0x4ECDE20", VA = "0x184ECF420")]
	private void MPEIGGHOIPB(Entity CGNAGBGLBDK, FLLMDNHGNBM ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF400", Offset = "0x4ECDE00", VA = "0x184ECF400")]
	private bool HNPCPHKBBJA(FLLMDNHGNBM ENNBIIMEOCP, [Out] BKBHLKAOCGH NNBPOKGINNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4ECEE90", Offset = "0x4ECD890", VA = "0x184ECEE90")]
	private BKBHLKAOCGH AOFIKHCLFKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BPEMIMBDOKG<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMOPENGNFEF(Entity CGNAGBGLBDK, object GNAAILLDOKI, TValue PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHIGPKHDHPL(Entity CGNAGBGLBDK, object GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ALLAFFFAMCD(Entity CGNAGBGLBDK, [Out] TValue PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FLLMDNHGNBM : KPKOEBEHBFB, IEquatable<FLLMDNHGNBM>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly FLLMDNHGNBM BOFAFIIEJCI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int LIGNGKONFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int FDJPACNIFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC650", Offset = "0x2CDB050", VA = "0x182CDC650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C4D0", Offset = "0x6B6AED0", VA = "0x186B6C4D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DD60", Offset = "0x7A7C760", VA = "0x187A7DD60", Slot = "8")]
	public bool Equals(FLLMDNHGNBM OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DDB0", Offset = "0x7A7C7B0", VA = "0x187A7DDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CJPHBDJAFCG<THasTokensTag> : IBNGEGEAFBH, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, FLLMDNHGNBM> AAIJMOHFHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> BCIGEGHLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private OAGNPLEFMGD<FLLMDNHGNBM, HashSet<object>> KJEJHPLKOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager IOCALHHKFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem GKLAEIHDPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x657FB50", Offset = "0x657E550", VA = "0x18657FB50")]
	public CJPHBDJAFCG(EntityManager IOCALHHKFGN, EntityCommandBufferSystem GKLAEIHDPAE, LMPJBEBLCLM JDKHDBCNBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x657D2E0", Offset = "0x657BCE0", VA = "0x18657D2E0", Slot = "4")]
	public bool BMOPENGNFEF(Entity CGNAGBGLBDK, object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x657E3A0", Offset = "0x657CDA0", VA = "0x18657E3A0", Slot = "5")]
	public bool FHIGPKHDHPL(Entity CGNAGBGLBDK, object GNAAILLDOKI, [Out] bool GOCOBHACAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x657E8E0", Offset = "0x657D2E0", VA = "0x18657E8E0", Slot = "6")]
	public bool IMJFLDMBKPB(Entity CGNAGBGLBDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x657E830", Offset = "0x657D230", VA = "0x18657E830", Slot = "8")]
	public bool IMJFLDMBKPB(FLLMDNHGNBM ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x657DB80", Offset = "0x657C580", VA = "0x18657DB80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x657D7D0", Offset = "0x657C1D0", VA = "0x18657D7D0")]
	private void CJAPDLMDGEK(HashSet<object> NNBPOKGINNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x657EFB0", Offset = "0x657D9B0", VA = "0x18657EFB0")]
	private bool NOJPDOMEAAP(Entity CGNAGBGLBDK, [Out] FLLMDNHGNBM ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x657EBB0", Offset = "0x657D5B0", VA = "0x18657EBB0")]
	private bool IOIIFJMOAIA(Entity CGNAGBGLBDK, [Out] FLLMDNHGNBM ENNBIIMEOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x657DCC0", Offset = "0x657C6C0", VA = "0x18657DCC0")]
	private void ENFLLADIGIO(Entity CGNAGBGLBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x657F730", Offset = "0x657E130", VA = "0x18657F730")]
	private void OMFBGIEMFCE(Entity CGNAGBGLBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x657D840", Offset = "0x657C240", VA = "0x18657D840")]
	private void DMFAAKIGBAB(Entity CGNAGBGLBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x657EF40", Offset = "0x657D940", VA = "0x18657EF40")]
	private void MPEIGGHOIPB(Entity CGNAGBGLBDK, FLLMDNHGNBM ENNBIIMEOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x657F370", Offset = "0x657DD70", VA = "0x18657F370")]
	private bool NPCLGOGFDMB(FLLMDNHGNBM ENNBIIMEOCP, [Out] HashSet<object> NNBPOKGINNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x657CEA0", Offset = "0x657B8A0", VA = "0x18657CEA0")]
	private HashSet<object> AOFIKHCLFKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BPLCMHLDHDM
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NEJHHHLILOC : DPPHPGGNNDH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EA90", Offset = "0x7A7D490", VA = "0x187A7EA90")]
	public float MCEOBLJGFIN([In] float3 PPJFMHBDGNA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EA90", Offset = "0x7A7D490", VA = "0x187A7EA90", Slot = "4")]
	private float ECMHEPMFCOC([In] float3 PPJFMHBDGNA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IFMCDBKICLE : DPPHPGGNNDH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E0B0", Offset = "0x7A7CAB0", VA = "0x187A7E0B0")]
	public float MCEOBLJGFIN([In] float3 PPJFMHBDGNA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E0B0", Offset = "0x7A7CAB0", VA = "0x187A7E0B0", Slot = "4")]
	private float ECMHEPMFCOC([In] float3 PPJFMHBDGNA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JBADAPBEMEF : DPPHPGGNNDH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xDE3180", Offset = "0xDE1B80", VA = "0x180DE3180")]
	public float MCEOBLJGFIN([In] float3 PPJFMHBDGNA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xDE3180", Offset = "0xDE1B80", VA = "0x180DE3180", Slot = "4")]
	private float ECMHEPMFCOC([In] float3 PPJFMHBDGNA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CGMIIGHMPCE : DPPHPGGNNDH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2083650", Offset = "0x2082050", VA = "0x182083650")]
	public int MCEOBLJGFIN([In] int3 PPJFMHBDGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2083650", Offset = "0x2082050", VA = "0x182083650", Slot = "4")]
	private int LJDCLALICGE([In] int3 PPJFMHBDGNA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BPPIKJNEFDE : DPPHPGGNNDH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE74830", Offset = "0xE73230", VA = "0x180E74830")]
	public int MCEOBLJGFIN([In] int3 PPJFMHBDGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xE74830", Offset = "0xE73230", VA = "0x180E74830", Slot = "4")]
	private int LJDCLALICGE([In] int3 PPJFMHBDGNA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MFHEFAKAJFF : DPPHPGGNNDH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xDC7910", Offset = "0xDC6310", VA = "0x180DC7910")]
	public int MCEOBLJGFIN([In] int3 PPJFMHBDGNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xDC7910", Offset = "0xDC6310", VA = "0x180DC7910", Slot = "4")]
	private int LJDCLALICGE([In] int3 PPJFMHBDGNA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PDFJMPCAOEJ : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F816B0", Offset = "0x1F800B0", VA = "0x181F816B0")]
	public PDFJMPCAOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class IMFEJPHBKOA : SystemBase, CFCMJMLOGJG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A7E0C0", Offset = "0x7A7CAC0", VA = "0x187A7E0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x36BD560", Offset = "0x36BBF60", VA = "0x1836BD560")]
	public void FNLCGKNKLOJ<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36BD560", Offset = "0x36BBF60", VA = "0x1836BD560")]
	public void ENOJPEICGOC<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E2A0", Offset = "0x7A7CCA0", VA = "0x187A7E2A0")]
	public JobHandle MPLKDDFGOLD(ReadOnlySpan<int> MBPJOOPABAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36BD5C0", Offset = "0x36BBFC0", VA = "0x1836BD5C0")]
	public JobHandle FMPEMCBNLAJ<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E150", Offset = "0x7A7CB50", VA = "0x187A7E150")]
	public JobHandle FMPEMCBNLAJ(ReadOnlySpan<int> MBPJOOPABAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36BD940", Offset = "0x36BC340", VA = "0x1836BD940")]
	public void MHEBLADOLCK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36BDB90", Offset = "0x36BC590", VA = "0x1836BDB90")]
	public JobHandle MHEBLADOLCK<T>(JobHandle ENNBIIMEOCP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E230", Offset = "0x7A7CC30", VA = "0x187A7E230")]
	public JobHandle MHEBLADOLCK(ReadOnlySpan<int> MBPJOOPABAP, JobHandle ENNBIIMEOCP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x36BD940", Offset = "0x36BC340", VA = "0x1836BD940")]
	public void INJFKKKGABL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36BD860", Offset = "0x36BC260", VA = "0x1836BD860")]
	public JobHandle INJFKKKGABL<T>(JobHandle ENNBIIMEOCP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E1C0", Offset = "0x7A7CBC0", VA = "0x187A7E1C0")]
	public JobHandle INJFKKKGABL(Span<int> MBPJOOPABAP, JobHandle ENNBIIMEOCP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x36BE450", Offset = "0x36BCE50", VA = "0x1836BE450")]
	public ComponentDataFromEntity PJCMGHHLOAH<T>(bool BBNIOJNCAEJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E2F0", Offset = "0x7A7CCF0", VA = "0x187A7E2F0")]
	public ComponentDataFromEntity PJCMGHHLOAH(int DIMNPBKLDMO, bool BBNIOJNCAEJ = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x36BD670", Offset = "0x36BC070", VA = "0x1836BD670")]
	public SharedComponentIndexFromEntity<T> HLLKGHDMLGG<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E0F0", Offset = "0x7A7CAF0", VA = "0x187A7E0F0")]
	[BurstCompatible]
	public ComponentTypeHandle CMHALJGNFNE(ComponentType MAGKBLLPBDI)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E1A0", Offset = "0x7A7CBA0", VA = "0x187A7E1A0")]
	public EntityExistenceLookupByEntity IHKIPKNJDPJ()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E3B0", Offset = "0x7A7CDB0", VA = "0x187A7E3B0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36BD740", Offset = "0x36BC140", VA = "0x1836BD740")]
	public bool IJLCPBDBPEA<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F816B0", Offset = "0x1F800B0", VA = "0x181F816B0")]
	protected IMFEJPHBKOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class CKEBNEPKAOJ : IMFEJPHBKOA
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DB50", Offset = "0x7A7C550", VA = "0x187A7DB50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F816B0", Offset = "0x1F800B0", VA = "0x181F816B0")]
	protected CKEBNEPKAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BBLBAEPNGHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NDEJCHDCBIO : EntityCommandBufferSystem, CFCMJMLOGJG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LMPJBEBLCLM HIMKLMLGBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCFE570", Offset = "0xCFCF70", VA = "0x180CFE570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EA60", Offset = "0x7A7D460", VA = "0x187A7EA60")]
	public NDEJCHDCBIO(LMPJBEBLCLM BLAHIKOFFGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DPPHPGGNNDH<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo MCEOBLJGFIN([In] TFrom PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LDBACJIEEHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ECJCMODFAJM(T PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct DIBHOJLCDNJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer EJEOGHFCKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes PFJHIDGMOFL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DB80", Offset = "0x7A7C580", VA = "0x187A7DB80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct MPOJFCJGEGN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer EJEOGHFCKCL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E940", Offset = "0x7A7D340", VA = "0x187A7E940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct NCLAKKIPJIF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer EJEOGHFCKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType MAGKBLLPBDI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E9E0", Offset = "0x7A7D3E0", VA = "0x187A7E9E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct EKCDFFODIDP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> DFPGGEDGGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer EJEOGHFCKCL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x436C4E0", Offset = "0x436AEE0", VA = "0x18436C4E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct DFPIHNEFHGE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> IOMEFCNHNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer EJEOGHFCKCL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct DJBOIGEKDHM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T PPJFMHBDGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer EJEOGHFCKCL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct HEEDEGCMMCG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DPPHPGGNNDH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> PBACHDEKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> CNBFBBHGKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap HNDDBOOOBBE;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct LONBMGDBOJN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity EHEBGPDHGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> PBACHDEKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> CNBFBBHGKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int EOBMLGFCPNP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E840", Offset = "0x7A7D240", VA = "0x187A7E840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct IJAAFMJOMIF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ABFKHIOKNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> PBACHDEKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> KAJBEJFONJA;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct AJLLFNDEGMN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DPPHPGGNNDH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> DJJIGDJAIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> CNBFBBHGKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap HNDDBOOOBBE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct AMJCMMPLAHC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> INDBHABENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> NJMJMFNKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> GDIDHIGNNJM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct BNAKJNGCHAF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> INDBHABENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> NJMJMFNKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> GDIDHIGNNJM;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x649E140", Offset = "0x649CB40", VA = "0x18649E140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct BHKLIKEBAMA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> PBACHDEKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> KAJBEJFONJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> GJKBBDJJMHF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6465600", Offset = "0x6464000", VA = "0x186465600", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct IGFFFIPGHAC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DPPHPGGNNDH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> PBACHDEKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> KAJBEJFONJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> GJKBBDJJMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap HNDDBOOOBBE;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GCLPJJEIJIC<T, TPredicate> : IJob where T : struct where TPredicate : struct, LDBACJIEEHD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> PBACHDEKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> LGIACJAAOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> FGGCCHFDIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate HNDDBOOOBBE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct ALHPKJOBPJD<T, TPredicate> : IJob where T : struct where TPredicate : struct, LDBACJIEEHD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> PBACHDEKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> KAJBEJFONJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate HNDDBOOOBBE;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct FCCOFPJBHGA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity INDBHABENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> NJMJMFNKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> INPNHKCBIEA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DCD0", Offset = "0x7A7C6D0", VA = "0x187A7DCD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct HBGLBLCJFEG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity INDBHABENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> NJMJMFNKNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> INPNHKCBIEA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DE90", Offset = "0x7A7C890", VA = "0x187A7DE90", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JMCBMKHEOHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class EEKEJNKBNKI
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x34B71E0", Offset = "0x34B5BE0", VA = "0x1834B71E0")]
	public static bool GHGBCGLHFAI<T>(this NativeArray<Entity> NJMJMFNKNOE, EntityManager IOCALHHKFGN, Allocator DDBBFOCJEFL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FNEDFIDIBOI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HABIDKBAFOC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public HABIDKBAFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class EHPIIBGDMGB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public EHPIIBGDMGB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> PIMCFGBFGLO;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DE00", Offset = "0x7A7C800", VA = "0x187A7DE00")]
	public FNEDFIDIBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DCNBIGICHBB
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JBCKOOFMPCL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct GBHOFCNCJPB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct IHNCJMEPOKI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal GBHOFCNCJPB<TFrom> HGBJMKAPAJA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> KKMIKMKCMKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct NDOLCFMNBIB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct GDHMKIBLNJI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal NDOLCFMNBIB<TFrom> HGBJMKAPAJA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> KKMIKMKCMKE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct DNDBOENIDAP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PMBEEFOEDIJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal DNDBOENIDAP<TFrom> HGBJMKAPAJA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> KKMIKMKCMKE;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct MDNBGAOFDHI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct AAJKOHFNNCN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal MDNBGAOFDHI<TFrom> HGBJMKAPAJA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> KKMIKMKCMKE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EDLLOMFMFFK
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class INNEFHDHGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x36BFB90", Offset = "0x36BE590", VA = "0x1836BFB90")]
	public static NativeList<T> ODCBCJKAKKJ<T>(this NativeArray<T> AFMAHHBBIPL, Allocator DDBBFOCJEFL = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JCMHKPLJIHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CEKJGEJOLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x341F7F0", Offset = "0x341E1F0", VA = "0x18341F7F0")]
	[BHBAPAJPACA]
	public static JobHandle HFAFBNAKGAN<T>(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArray<Entity> GABLPEMHKBP, NativeArray<T> DFPGGEDGGGN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x341F540", Offset = "0x341DF40", VA = "0x18341F540")]
	[BHBAPAJPACA]
	public static JobHandle HFAFBNAKGAN<T>(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArrayAsync<Entity> GABLPEMHKBP, NativeArrayAsync<T> DFPGGEDGGGN, [Optional] JobHandle BNGPINPCCLG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x341F6C0", Offset = "0x341E0C0", VA = "0x18341F6C0")]
	[BHBAPAJPACA]
	public static JobHandle HFAFBNAKGAN<T>(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArray<Entity> GABLPEMHKBP, [Optional] JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D9E0", Offset = "0x7A7C3E0", VA = "0x187A7D9E0")]
	[BHBAPAJPACA]
	public static JobHandle HFAFBNAKGAN(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArray<Entity> GABLPEMHKBP, ComponentTypes PFJHIDGMOFL, [Optional] JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A7D890", Offset = "0x7A7C290", VA = "0x187A7D890")]
	[BHBAPAJPACA]
	public static JobHandle HFAFBNAKGAN(this EntityCommandBufferSystem GKLAEIHDPAE, EntityCommandBuffer EJEOGHFCKCL, NativeArray<Entity> GABLPEMHKBP, ComponentTypes PFJHIDGMOFL, [Optional] JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LDMCEEPKEMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LEPBCEIJDBL
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E5A0", Offset = "0x7A7CFA0", VA = "0x187A7E5A0")]
	[BHBAPAJPACA]
	public static JobHandle HNDLLBFPKPI(this EntityCommandBufferSystem GKLAEIHDPAE, NativeList<Entity> GABLPEMHKBP, [Optional] JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E730", Offset = "0x7A7D130", VA = "0x187A7E730")]
	[BHBAPAJPACA]
	public static JobHandle HNDLLBFPKPI(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArrayAsync<Entity> GABLPEMHKBP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HLADEBNFKIG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x369BCF0", Offset = "0x369A6F0", VA = "0x18369BCF0")]
	[BHBAPAJPACA]
	public static JobHandle DJIBEHFMBMD<T>(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArrayAsync<Entity> GABLPEMHKBP, [Optional] JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DF20", Offset = "0x7A7C920", VA = "0x187A7DF20")]
	[BHBAPAJPACA]
	public static JobHandle DJIBEHFMBMD(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArrayAsync<Entity> GABLPEMHKBP, ComponentType MAGKBLLPBDI, [Optional] JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class AGDAFLJJJKB
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA840", Offset = "0x3DA9240", VA = "0x183DAA840")]
	[BHBAPAJPACA]
	public static JobHandle CMAGGGOKCAD<T>(this EntityCommandBufferSystem GKLAEIHDPAE, NativeArray<Entity> GABLPEMHKBP, NativeArray<T> DFPGGEDGGGN, JobHandle BNGPINPCCLG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AMPNPCOJNNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class GIPONHINLLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KPFMAMJDNJF
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x371F8E0", Offset = "0x371E2E0", VA = "0x18371F8E0")]
	public static NativeArray<T> LEMKDMDMGNH<T>(this NativeList<Entity> AFMAHHBBIPL, EntityManager IOCALHHKFGN, Allocator DDBBFOCJEFL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x371F9B0", Offset = "0x371E3B0", VA = "0x18371F9B0")]
	public static NativeArray<T> LEMKDMDMGNH<T>(this NativeArray<Entity> AFMAHHBBIPL, EntityManager IOCALHHKFGN, Allocator DDBBFOCJEFL = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7E3C0", Offset = "0x7A7CDC0", VA = "0x187A7E3C0")]
	public static NativeArray<Entity> OIGPGEMEIGL(this NativeArray<Entity> AFMAHHBBIPL, EntityManager IOCALHHKFGN, ComponentType MAGKBLLPBDI, Allocator DDBBFOCJEFL = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x371F7E0", Offset = "0x371E1E0", VA = "0x18371F7E0")]
	public static NativeArray<T> DKFANCJHFGA<T>(this NativeArray<Entity> AFMAHHBBIPL, EntityManager IOCALHHKFGN, Allocator DDBBFOCJEFL = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NENIPICBNMM
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct ALIBJKCOPFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct KLMCFGAAPGM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ALIBJKCOPFJ<TFrom> KKMIKMKCMKE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> PBACHDEKEAF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct BKFIPMHFJBO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct GCPEGMEAOOO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public BKFIPMHFJBO<TFrom> KKMIKMKCMKE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> PBACHDEKEAF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct OPKGPMBFENP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct FLJJPGGEFAG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public OPKGPMBFENP<TFrom> KKMIKMKCMKE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> PBACHDEKEAF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FPJJHLJFELK
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IKIMFMEHFAF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct LFNCDIGCECO : DPPHPGGNNDH<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> NCPKIGJLCAJ;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A7E830", Offset = "0x7A7D230", VA = "0x187A7E830")]
		[BurstCompatible]
		public Entity MCEOBLJGFIN([In] Entity PPJFMHBDGNA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7A7E830", Offset = "0x7A7D230", VA = "0x187A7E830", Slot = "4")]
		private Entity JKOCGDEAKLF([In] Entity PPJFMHBDGNA)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class PDJNEKLGNOM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct KCDOBMNPANB<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA610", Offset = "0x4DF9010", VA = "0x184DFA610", Slot = "4")]
		public int Compare((TKey, TValue) CJBFFOKBLHB, (TKey, TValue) CNBLFOFLDDG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3839940", Offset = "0x3838340", VA = "0x183839940")]
	public static void JGFMGEMKOFO<TKey, TValue>(NativeList<TKey> HGIMMGGCAEF, NativeList<TValue> IOMEFCNHNJN) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3839BD0", Offset = "0x38385D0", VA = "0x183839BD0")]
	public static void JGFMGEMKOFO<TKey, TValue>(NativeArray<TKey> HGIMMGGCAEF, NativeArray<TValue> IOMEFCNHNJN) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3839DA0", Offset = "0x38387A0", VA = "0x183839DA0")]
	public static void JGFMGEMKOFO<TKey, TValue, U>(NativeArray<TKey> HGIMMGGCAEF, NativeArray<TValue> IOMEFCNHNJN, U FLJKGFAOPKJ) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HADGIABIKJO
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct JLNKBJPKNHJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> LGIACJAAOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> PBACHDEKEAF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CKIPGMCMBNJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> LGIACJAAOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> PBACHDEKEAF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct PNNHOCJPBGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> LGIACJAAOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> PBACHDEKEAF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class ADEINHDPCAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CNICJEBKJCD
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct IGMALDIHHEJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> PBACHDEKEAF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct HDLIJIPKBGK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> PBACHDEKEAF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct MFIGAOBJADJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> PBACHDEKEAF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct MKNKKPGMAMI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator DDBBFOCJEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> PBACHDEKEAF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JMKGGJOECHH
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class EAEDKMJFAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x349F820", Offset = "0x349E220", VA = "0x18349F820")]
	public static NativeList<Entity> HPIPANEOKJB<T>(this NativeList<Entity> NJMJMFNKNOE, EntityManager IOCALHHKFGN, Allocator DDBBFOCJEFL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x349F050", Offset = "0x349DA50", VA = "0x18349F050")]
	public static NativeList<Entity> HPIPANEOKJB<T>(this NativeArray<Entity> NJMJMFNKNOE, EntityManager IOCALHHKFGN, Allocator DDBBFOCJEFL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class MLOMLIONJHM
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3754A80", Offset = "0x3753480", VA = "0x183754A80")]
	public static NativeList<Entity> HCPMJEONBPC<T>(this NativeArray<Entity> NJMJMFNKNOE, EntityManager IOCALHHKFGN, Allocator DDBBFOCJEFL = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class OCMAOMAJMIL
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct KAGCABLCPGA<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> NAKGFAINKPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct JMKKMHJNKLL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> NAKGFAINKPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct OPBEHMHJDIF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DPPHPGGNNDH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> NAKGFAINKPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct JAKGOGGKJAM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DPPHPGGNNDH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> NAKGFAINKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector LICKBACDDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int DOAKEFBOPIA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct FEHDCAHLBIL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DPPHPGGNNDH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private JAKGOGGKJAM<TSrc, TValue, TSelector> EEBIIAOHCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue JMPHMGFIELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int FNEPEEDFAPL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class FPHGGNMPFPP
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct GOPIHOOIKJM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> NAKGFAINKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FNEPEEDFAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int HGAMGBPPLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T JMPHMGFIELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T NFGPGOLJEIO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FOFEFKICODD NGJJJEBEMJC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x48FC490", Offset = "0x48FAE90", VA = "0x1848FC490")]
			get
			{
				return default(FOFEFKICODD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T FHLDCCKHLHK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, FOFEFKICODD) GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x48FC280", Offset = "0x48FAC80", VA = "0x1848FC280")]
			get
			{
				return default((T, FOFEFKICODD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x48FC8E0", Offset = "0x48FB2E0", VA = "0x1848FC8E0")]
		public GOPIHOOIKJM(NativeArray<T> NAKGFAINKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x443C710", Offset = "0x443B110", VA = "0x18443C710")]
		public GOPIHOOIKJM<T> KCFKLFFNEEA()
		{
			return default(GOPIHOOIKJM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x48FC780", Offset = "0x48FB180", VA = "0x1848FC780")]
		public bool FMNODPIACON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3A7C3B0", Offset = "0x3A7ADB0", VA = "0x183A7C3B0")]
		public AKHGOCPCFIF<T, TComparer> BDMKPAIAEMO<TComparer>([Optional] TComparer FLJKGFAOPKJ) where TComparer : struct, IEqualityComparer<T>
		{
			return default(AKHGOCPCFIF<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct AKHGOCPCFIF<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> NAKGFAINKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int FNEPEEDFAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int HGAMGBPPLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T JMPHMGFIELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T NFGPGOLJEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer FLJKGFAOPKJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FOFEFKICODD NGJJJEBEMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x48FC490", Offset = "0x48FAE90", VA = "0x1848FC490")]
			get
			{
				return default(FOFEFKICODD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T FHLDCCKHLHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, FOFEFKICODD range) GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x48FC280", Offset = "0x48FAC80", VA = "0x1848FC280")]
			get
			{
				return default((T, FOFEFKICODD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x502BBE0", Offset = "0x502A5E0", VA = "0x18502BBE0")]
		public AKHGOCPCFIF(NativeArray<T> NAKGFAINKPB, TComparer FLJKGFAOPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x33AE590", Offset = "0x33ACF90", VA = "0x1833AE590")]
		public AKHGOCPCFIF<T, TComparer> KCFKLFFNEEA()
		{
			return default(AKHGOCPCFIF<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x502BB00", Offset = "0x502A500", VA = "0x18502BB00")]
		public bool FMNODPIACON()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x36322F0", Offset = "0x3630CF0", VA = "0x1836322F0")]
	public static GOPIHOOIKJM<T> KMIPMMMJCKD<T>(this NativeArray<T> NAKGFAINKPB) where T : struct
	{
		return default(GOPIHOOIKJM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface EBPFOKCDCPH
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class AHOGJIBOEPD
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct BNOAOFIKIID<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MLEHMFKCNGP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public BNOAOFIKIID<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xB9B420", Offset = "0xB99E20", VA = "0x180B9B420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x48260D0", Offset = "0x4824AD0", VA = "0x1848260D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public MLEHMFKCNGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x51370C0", Offset = "0x5135AC0", VA = "0x1851370C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5137290", Offset = "0x5135C90", VA = "0x185137290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> PHMJABDEIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream HDBIIHBLCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream CPBMMNLJMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf GAICPBMAOMP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x64B5FB0", Offset = "0x64B49B0", VA = "0x1864B5FB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x64B5FF0", Offset = "0x64B49F0", VA = "0x1864B5FF0", Slot = "4")]
	[IteratorStateMachine(typeof(BNOAOFIKIID<>.MLEHMFKCNGP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x64B60F0", Offset = "0x64B4AF0", VA = "0x1864B60F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct BLKLMEAIINL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] KGINKPKLCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf GAICPBMAOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream HDBIIHBLCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream HJNJAAFIPOI;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6491890", Offset = "0x6490290", VA = "0x186491890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct EEHJOCHJBPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream HDBIIHBLCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream CPBMMNLJMCM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7A7DC70", Offset = "0x7A7C670", VA = "0x187A7DC70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct NKGGKKBOJGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] KGINKPKLCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream HDBIIHBLCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream HJNJAAFIPOI;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A7EAA0", Offset = "0x7A7D4A0", VA = "0x187A7EAA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class BMHJIBALGNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class PJJDDMKCGFP
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum GNEFDIENCHC
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
internal static class EIAMLEGGANH
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LPHLOPHCPMO
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LPHLOPHCPMO()
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
