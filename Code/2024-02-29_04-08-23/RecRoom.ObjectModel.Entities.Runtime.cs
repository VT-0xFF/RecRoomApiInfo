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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60B64E0", Offset = "0x60B52E0", VA = "0x1860B64E0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HGJGNGAIBGJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FNLKMNMOINE IHNOCLBKBPP
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
public interface IBNIAKHLEJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGHNHCEDEIP(Entity KEAAKDKHLOM, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOAKPNNNFBA(Entity KEAAKDKHLOM, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ECGOFBAILAM(Entity KEAAKDKHLOM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NNMHJGKAAIM(Entity KEAAKDKHLOM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FDOBGJGNJGD<TComponentData, TValue> : FAMBNFLHKPI<TValue>, IDisposable where TComponentData : struct, HGJGNGAIBGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class NIFCOMAJCDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> FOKGGJDBEOD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int DDMEKBICEFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x305C500", Offset = "0x305B300", VA = "0x18305C500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B6D0", Offset = "0x3E6A4D0", VA = "0x183E6B6D0")]
		public bool OICGFBAMGAA([Out] TValue NKKIECLCEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B4C0", Offset = "0x3E6A2C0", VA = "0x183E6B4C0")]
		public void ANMBPKAMKOK(object NBGOKNOECBH, TValue NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B650", Offset = "0x3E6A450", VA = "0x183E6B650")]
		public bool JJGPDDBMEBN(object NBGOKNOECBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B570", Offset = "0x3E6A370", VA = "0x183E6B570")]
		public int JILBOONAJOB(object NBGOKNOECBH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B7C0", Offset = "0x3E6A5C0", VA = "0x183E6B7C0")]
		public NIFCOMAJCDM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<NIFCOMAJCDM> KFABLCKMMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LFMDOGNOAKB<FNLKMNMOINE, NIFCOMAJCDM> KHBIBFLGDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager FAPAMPDMFAG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x35AC800", Offset = "0x35AB600", VA = "0x1835AC800")]
	public FDOBGJGNJGD(EntityManager FAPAMPDMFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x35AC6C0", Offset = "0x35AB4C0", VA = "0x1835AC6C0", Slot = "4")]
	public void PGHNHCEDEIP(Entity KEAAKDKHLOM, object NBGOKNOECBH, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35AC1E0", Offset = "0x35AAFE0", VA = "0x1835AC1E0", Slot = "5")]
	public bool EOAKPNNNFBA(Entity KEAAKDKHLOM, object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35AC5C0", Offset = "0x35AB3C0", VA = "0x1835AC5C0", Slot = "6")]
	public bool OICGFBAMGAA(Entity KEAAKDKHLOM, [Out] TValue NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x35AC1C0", Offset = "0x35AAFC0", VA = "0x1835AC1C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x35AC380", Offset = "0x35AB180", VA = "0x1835AC380")]
	private void HCACIOEBELA(NIFCOMAJCDM GIMIFCCKCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x35AC410", Offset = "0x35AB210", VA = "0x1835AC410")]
	private bool IHGKFLPODHG(Entity KEAAKDKHLOM, [Out] FNLKMNMOINE LDKFOPCPMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x35AC0B0", Offset = "0x35AAEB0", VA = "0x1835AC0B0")]
	private void AJFHMKAEFFC(Entity KEAAKDKHLOM, FNLKMNMOINE LDKFOPCPMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x35AC1A0", Offset = "0x35AAFA0", VA = "0x1835AC1A0")]
	private bool BNBAIACJOJA(FNLKMNMOINE LDKFOPCPMCG, [Out] NIFCOMAJCDM GIMIFCCKCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x35AC4D0", Offset = "0x35AB2D0", VA = "0x1835AC4D0")]
	private NIFCOMAJCDM IHPEDIFFPNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FAMBNFLHKPI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGHNHCEDEIP(Entity KEAAKDKHLOM, object NBGOKNOECBH, TValue NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOAKPNNNFBA(Entity KEAAKDKHLOM, object NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OICGFBAMGAA(Entity KEAAKDKHLOM, [Out] TValue NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FNLKMNMOINE : CDBBGDPCLAA, IEquatable<FNLKMNMOINE>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly FNLKMNMOINE ONINMHIBMCC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int CCEAOHGDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int KKDGMDBLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x544ED00", Offset = "0x544DB00", VA = "0x18544ED00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60B6500", Offset = "0x60B5300", VA = "0x1860B6500", Slot = "8")]
	public bool Equals(FNLKMNMOINE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60B6550", Offset = "0x60B5350", VA = "0x1860B6550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LMNFHKFOJBM<THasTokensTag> : IBNIAKHLEJC, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, FNLKMNMOINE> HLLNEDJGPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> KFABLCKMMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LFMDOGNOAKB<FNLKMNMOINE, HashSet<object>> KHBIBFLGDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager FAPAMPDMFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem DBDNEMICNGA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D2E0", Offset = "0x3C1C0E0", VA = "0x183C1D2E0")]
	public LMNFHKFOJBM(EntityManager FAPAMPDMFAG, EntityCommandBufferSystem DBDNEMICNGA, KNPFMNBIIDA EMJIAEHLHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CBB0", Offset = "0x3C1B9B0", VA = "0x183C1CBB0", Slot = "4")]
	public bool PGHNHCEDEIP(Entity KEAAKDKHLOM, object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C1AA90", Offset = "0x3C19890", VA = "0x183C1AA90", Slot = "5")]
	public bool EOAKPNNNFBA(Entity KEAAKDKHLOM, object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C1A6C0", Offset = "0x3C194C0", VA = "0x183C1A6C0", Slot = "6")]
	public bool ECGOFBAILAM(Entity KEAAKDKHLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C1A610", Offset = "0x3C19410", VA = "0x183C1A610", Slot = "9")]
	public bool ECGOFBAILAM(FNLKMNMOINE LDKFOPCPMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C8B0", Offset = "0x3C1B6B0", VA = "0x183C1C8B0", Slot = "7")]
	public bool NNMHJGKAAIM(Entity KEAAKDKHLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C1A370", Offset = "0x3C19170", VA = "0x183C1A370", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C1B4B0", Offset = "0x3C1A2B0", VA = "0x183C1B4B0")]
	private void HCACIOEBELA(HashSet<object> GIMIFCCKCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1BCA0", Offset = "0x3C1AAA0", VA = "0x183C1BCA0")]
	private bool IHGKFLPODHG(Entity KEAAKDKHLOM, [Out] FNLKMNMOINE LDKFOPCPMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1B8B0", Offset = "0x3C1A6B0", VA = "0x183C1B8B0")]
	private bool HHFDONIKGBH(Entity KEAAKDKHLOM, [Out] FNLKMNMOINE LDKFOPCPMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C19F30", Offset = "0x3C18D30", VA = "0x183C19F30")]
	private void CNGAGFENDIM(Entity KEAAKDKHLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C490", Offset = "0x3C1B290", VA = "0x183C1C490")]
	private void MBEGDHGKJOO(Entity KEAAKDKHLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3C1B240", Offset = "0x3C1A040", VA = "0x183C1B240")]
	private void FMLGHPLFIEE(Entity KEAAKDKHLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C19D40", Offset = "0x3C18B40", VA = "0x183C19D40")]
	private void AJFHMKAEFFC(Entity KEAAKDKHLOM, FNLKMNMOINE LDKFOPCPMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C1AA30", Offset = "0x3C19830", VA = "0x183C1AA30")]
	private bool ELGOLEFCNME(FNLKMNMOINE LDKFOPCPMCG, [Out] HashSet<object> GIMIFCCKCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C1BF80", Offset = "0x3C1AD80", VA = "0x183C1BF80")]
	private HashSet<object> IHPEDIFFPNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MGIHKHDBBFF
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JCFONEGNMOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int OOCJLKADJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int BPFMGMBDOBA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MHPLMCPGHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2200D30", Offset = "0x21FFB30", VA = "0x182200D30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x544ED00", Offset = "0x544DB00", VA = "0x18544ED00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FJMBOHKDLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8982F0", Offset = "0x8970F0", VA = "0x1808982F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HICJPHFMNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60B6AD0", Offset = "0x60B58D0", VA = "0x1860B6AD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x60B6AC0", Offset = "0x60B58C0", VA = "0x1860B6AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xA58C60", Offset = "0xA57A60", VA = "0x180A58C60")]
	private JCFONEGNMOF(int OOCJLKADJBK, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1370", Offset = "0x1DA0170", VA = "0x181DA1370")]
	public static JCFONEGNMOF DOMENMNBLMF(int OOCJLKADJBK, int BPFMGMBDOBA)
	{
		return default(JCFONEGNMOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60B6AE0", Offset = "0x60B58E0", VA = "0x1860B6AE0")]
	public static JCFONEGNMOF NCNLCJHECFG(int IFADIJDFJBM, int DBFFCPMHGNC)
	{
		return default(JCFONEGNMOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60B6AF0", Offset = "0x60B58F0", VA = "0x1860B6AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IAEHNPDBAMD : NOMODBOKHHO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60B6720", Offset = "0x60B5520", VA = "0x1860B6720")]
	public float GCOFJAMIEAF([In] float3 NKKIECLCEML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60B6720", Offset = "0x60B5520", VA = "0x1860B6720", Slot = "4")]
	private float LAAGDNOILPL([In] float3 NKKIECLCEML)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NOOALLLDMDA : NOMODBOKHHO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60B6D50", Offset = "0x60B5B50", VA = "0x1860B6D50")]
	public float GCOFJAMIEAF([In] float3 NKKIECLCEML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60B6D50", Offset = "0x60B5B50", VA = "0x1860B6D50", Slot = "4")]
	private float LAAGDNOILPL([In] float3 NKKIECLCEML)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct COEEPFIBAFF : NOMODBOKHHO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C240", Offset = "0x1A0B040", VA = "0x181A0C240")]
	public float GCOFJAMIEAF([In] float3 NKKIECLCEML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C240", Offset = "0x1A0B040", VA = "0x181A0C240", Slot = "4")]
	private float LAAGDNOILPL([In] float3 NKKIECLCEML)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AAFGOABMFCO : NOMODBOKHHO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x132A360", Offset = "0x1329160", VA = "0x18132A360")]
	public int GCOFJAMIEAF([In] int3 NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x132A360", Offset = "0x1329160", VA = "0x18132A360", Slot = "4")]
	private int MFCLLMCJIIB([In] int3 NKKIECLCEML)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KAGCHNALLFD : NOMODBOKHHO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x60B6C10", Offset = "0x60B5A10", VA = "0x1860B6C10")]
	public int GCOFJAMIEAF([In] int3 NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60B6C10", Offset = "0x60B5A10", VA = "0x1860B6C10", Slot = "4")]
	private int MFCLLMCJIIB([In] int3 NKKIECLCEML)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CCLKEAMPALH : NOMODBOKHHO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1620D80", Offset = "0x161FB80", VA = "0x181620D80")]
	public int GCOFJAMIEAF([In] int3 NKKIECLCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1620D80", Offset = "0x161FB80", VA = "0x181620D80", Slot = "4")]
	private int MFCLLMCJIIB([In] int3 NKKIECLCEML)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FOAGCMAJLBE : NBLHBEOGGMJ
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	public FOAGCMAJLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class GNHIPMMHFHK : SystemBase, KPLOCNOPOED
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60B6630", Offset = "0x60B5430", VA = "0x1860B6630")]
	public ComponentDataFromEntity FLGDJMDKFFI(int CMJIGCCPHNK, bool OJLGKGHDAEM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60B66F0", Offset = "0x60B54F0", VA = "0x1860B66F0")]
	public EntityExistenceLookupByEntity NJFOHCDAEGC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60B6710", Offset = "0x60B5510", VA = "0x1860B6710", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	protected GNHIPMMHFHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ABGDLGKHFKE : GNHIPMMHFHK
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60B6120", Offset = "0x60B4F20", VA = "0x1860B6120", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	protected ABGDLGKHFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FGACMCMNDAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class LHOJABCNHPI : EntityCommandBufferSystem, KPLOCNOPOED
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	protected LHOJABCNHPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NOMODBOKHHO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo GCOFJAMIEAF([In] TFrom NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EJCDBMFOJHN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABCKFNDAOCC(T NKKIECLCEML);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct IMJBEMGJMIE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	public NativeArray<Entity> MPOMEEMHIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EntityCommandBuffer ICNJMPACBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ComponentTypes OCEFMCFCNLL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x60B6740", Offset = "0x60B5540", VA = "0x1860B6740", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct OBFFEJPGLOM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> MPOMEEMHIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer ICNJMPACBAN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60B6D60", Offset = "0x60B5B60", VA = "0x1860B6D60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct PFJMDIAFHFI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> MPOMEEMHIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer ICNJMPACBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public ComponentType NJCJAJJDPPI;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60B6FE0", Offset = "0x60B5DE0", VA = "0x1860B6FE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct GCHHDOOGGJG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<Entity> MPOMEEMHIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<T> OMHIFBJFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer ICNJMPACBAN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3691800", Offset = "0x3690600", VA = "0x183691800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct KCCDMOHEJAL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<Entity> MPOMEEMHIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<T> NCNPEIAEPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer ICNJMPACBAN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct KLCLBLJDAHG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> MPOMEEMHIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public T NKKIECLCEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EntityCommandBuffer ICNJMPACBAN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3AD97B0", Offset = "0x3AD85B0", VA = "0x183AD97B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct LELDDKNKDIF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NOMODBOKHHO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<TFrom> BMBDDEJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[WriteOnly]
	public NativeArray<TTo> FLBGHMMKKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TMap ENHEBPDFNME;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct PLPINBBMGJA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public ComponentDataFromEntity KNJDLIDLFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<Entity> BMBDDEJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeArray<byte> FLBGHMMKKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int FIPGADKAIMF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60B7060", Offset = "0x60B5E60", VA = "0x1860B7060", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct HEPKPHEBIDB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PPAOBJOBNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<Entity> BMBDDEJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<T> JMNFGMDAMAC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct AGKNPDIBHJI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NOMODBOKHHO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<TFrom> NKHPOIKPAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<TTo> FLBGHMMKKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TMap ENHEBPDFNME;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct FKOFFHJBOMH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JLAKIPMJLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public NativeArray<Entity> DIAOIIMGPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<bool> CPLINHLOHEH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct IMAOOONPAOL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JLAKIPMJLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> DIAOIIMGPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<bool> CPLINHLOHEH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x386E3F0", Offset = "0x386D1F0", VA = "0x18386E3F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct HAAMEBHINFA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<T> BMBDDEJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeList<T> JMNFGMDAMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeParallelHashSet<T> HPLMOGBCEGL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x36FAA50", Offset = "0x36F9850", VA = "0x1836FAA50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct BMHFAAJOGLF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NOMODBOKHHO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public NativeArray<TFrom> BMBDDEJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeList<TFrom> JMNFGMDAMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeParallelHashSet<TTo> HPLMOGBCEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap ENHEBPDFNME;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JONBCEEFLMJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, EJCDBMFOJHN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<T> BMBDDEJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> OJOLJKKHMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeList<Entity> KEBIEAHBINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TPredicate ENHEBPDFNME;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3A627A0", Offset = "0x3A615A0", VA = "0x183A627A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IEDNMOMPKJJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, EJCDBMFOJHN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<T> BMBDDEJKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeList<T> JMNFGMDAMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public TPredicate ENHEBPDFNME;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct GEOOACAJPHP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public ComponentDataFromEntity JLAKIPMJLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> DIAOIIMGPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NativeList<Entity> OFNMLHIKOBA;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60B65A0", Offset = "0x60B53A0", VA = "0x1860B65A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct JCIBJBPMPJJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public ComponentDataFromEntity JLAKIPMJLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public NativeArray<Entity> DIAOIIMGPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<Entity> OFNMLHIKOBA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60B6B80", Offset = "0x60B5980", VA = "0x1860B6B80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FDDJHIIDKDL
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CAKHNJDBCIC
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x255BFF0", Offset = "0x255ADF0", VA = "0x18255BFF0")]
	public static bool ECCLPDELDME<T>(this NativeArray<Entity> DIAOIIMGPGN, EntityManager FAPAMPDMFAG, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CNOPFNCCCDP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NAFJFLBKDMO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		public NAFJFLBKDMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KFLBJEDCOEB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		public KFLBJEDCOEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<Func<JobHandle, JobHandle>> MAOACOEDBMC;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60B6190", Offset = "0x60B4F90", VA = "0x1860B6190")]
	public CNOPFNCCCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HCGKHNIGMGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KMAAALKNHFF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct FJAPFJCHCMO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct LBBHCBLHCAA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			internal FJAPFJCHCMO<TFrom> AJKCELPHOFC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal NativeArray<TFrom> HAMFKMJEGLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct MBOLALLFCBF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct OCEHKLOKGDB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			internal MBOLALLFCBF<TFrom> AJKCELPHOFC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal NativeList<TFrom> HAMFKMJEGLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct DBPHFLEGDLG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct DOFAKJJLIAL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal DBPHFLEGDLG<TFrom> AJKCELPHOFC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NativeArrayAsync<TFrom> HAMFKMJEGLE;
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct BGLNOJBIHPG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct OHKJNLPAHAD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal BGLNOJBIHPG<TFrom> AJKCELPHOFC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeListAsync<TFrom> HAMFKMJEGLE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CFHDECFHOEP
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OJBNKJDCLAI
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2854B40", Offset = "0x2853940", VA = "0x182854B40")]
	public static NativeList<T> LBGKLEEHPHG<T>(this NativeList<T> ACFNIIMFABG, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2854BC0", Offset = "0x28539C0", VA = "0x182854BC0")]
	public static NativeList<T> LBGKLEEHPHG<T>(this NativeArray<T> ACFNIIMFABG, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DIEKHJFKJKN
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DEINBCOPBHE
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x259CDE0", Offset = "0x259BBE0", VA = "0x18259CDE0")]
	[ONABGPLNBAB]
	public static JobHandle BPMOMEABNMA<T>(this EntityCommandBufferSystem DBDNEMICNGA, NativeArrayAsync<Entity> MPOMEEMHIFI, NativeArrayAsync<T> OMHIFBJFAGA, [Optional] JobHandle CGPMADMGHBK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x259D060", Offset = "0x259BE60", VA = "0x18259D060")]
	[ONABGPLNBAB]
	public static JobHandle BPMOMEABNMA<T>(this EntityCommandBufferSystem DBDNEMICNGA, NativeArrayAsync<Entity> MPOMEEMHIFI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x259CF40", Offset = "0x259BD40", VA = "0x18259CF40")]
	[ONABGPLNBAB]
	public static JobHandle BPMOMEABNMA<T>(this EntityCommandBufferSystem DBDNEMICNGA, NativeArray<Entity> MPOMEEMHIFI, [Optional] JobHandle CGPMADMGHBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60B6370", Offset = "0x60B5170", VA = "0x1860B6370")]
	[ONABGPLNBAB]
	public static JobHandle BPMOMEABNMA(this EntityCommandBufferSystem DBDNEMICNGA, NativeArray<Entity> MPOMEEMHIFI, ComponentTypes OCEFMCFCNLL, [Optional] JobHandle CGPMADMGHBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60B6220", Offset = "0x60B5020", VA = "0x1860B6220")]
	[ONABGPLNBAB]
	public static JobHandle BPMOMEABNMA(this EntityCommandBufferSystem DBDNEMICNGA, EntityCommandBuffer ICNJMPACBAN, NativeArray<Entity> MPOMEEMHIFI, ComponentTypes OCEFMCFCNLL, [Optional] JobHandle CGPMADMGHBK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DLJCDINEBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x259DF20", Offset = "0x259CD20", VA = "0x18259DF20")]
	[ONABGPLNBAB]
	public static JobHandle GJOJPLAJCKK<T>(this EntityCommandBufferSystem DBDNEMICNGA, EntityCommandBuffer ICNJMPACBAN, EntityQuery MOOOLAKGMBM, T NKKIECLCEML) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JBCGHCEOPLB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60B6930", Offset = "0x60B5730", VA = "0x1860B6930")]
	[ONABGPLNBAB]
	public static JobHandle PFJHBNBLDGA(this EntityCommandBufferSystem DBDNEMICNGA, NativeList<Entity> MPOMEEMHIFI, [Optional] JobHandle CGPMADMGHBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60B6830", Offset = "0x60B5630", VA = "0x1860B6830")]
	[ONABGPLNBAB]
	public static JobHandle PFJHBNBLDGA(this EntityCommandBufferSystem DBDNEMICNGA, NativeArrayAsync<Entity> MPOMEEMHIFI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CCGEOOKPAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x255C620", Offset = "0x255B420", VA = "0x18255C620")]
	public static void GAGENAMNPOK<T>(this EntityCommandBufferSystem DBDNEMICNGA, EntityQuery MOOOLAKGMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x255C3D0", Offset = "0x255B1D0", VA = "0x18255C3D0")]
	[ONABGPLNBAB]
	public static JobHandle FMENAGPCEBO<T>(this EntityCommandBufferSystem DBDNEMICNGA, NativeListAsync<Entity> MPOMEEMHIFI, [Optional] JobHandle CGPMADMGHBK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x255C490", Offset = "0x255B290", VA = "0x18255C490")]
	[ONABGPLNBAB]
	public static JobHandle FMENAGPCEBO<T>(this EntityCommandBufferSystem DBDNEMICNGA, NativeArrayAsync<Entity> MPOMEEMHIFI, [Optional] JobHandle CGPMADMGHBK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NJMEOPGEIEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2830F20", Offset = "0x282FD20", VA = "0x182830F20")]
	[ONABGPLNBAB]
	public static JobHandle IALNIBPIJJO<T>(this EntityCommandBufferSystem DBDNEMICNGA, NativeArray<Entity> MPOMEEMHIFI, NativeArray<T> OMHIFBJFAGA, JobHandle CGPMADMGHBK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GDPNNIIPHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26F3090", Offset = "0x26F1E90", VA = "0x1826F3090")]
	[ONABGPLNBAB]
	public static JobHandle FEHBDAMEOJA<T>(this EntityCommandBufferSystem DBDNEMICNGA, NativeArray<Entity> MPOMEEMHIFI, T NKKIECLCEML, [Optional] JobHandle CGPMADMGHBK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26F2FC0", Offset = "0x26F1DC0", VA = "0x1826F2FC0")]
	[ONABGPLNBAB]
	public static JobHandle FEHBDAMEOJA<T>(this EntityCommandBufferSystem DBDNEMICNGA, EntityCommandBuffer ICNJMPACBAN, NativeArray<Entity> MPOMEEMHIFI, T NKKIECLCEML, [Optional] JobHandle CGPMADMGHBK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AGCFJNNGDPG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC07F0", Offset = "0x2CBF5F0", VA = "0x182CC07F0")]
	public static NativeList<T> LBGKLEEHPHG<T>(NativeList<T> ACFNIIMFABG, Allocator MGPHHCICJPF) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class ODFDHIHKHEC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x284B0D0", Offset = "0x2849ED0", VA = "0x18284B0D0")]
	public static NativeArray<T> AEIMJDDDAEE<T>(this NativeList<Entity> ACFNIIMFABG, EntityManager FAPAMPDMFAG, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x284AB90", Offset = "0x2849990", VA = "0x18284AB90")]
	public static NativeArray<T> AEIMJDDDAEE<T>(this NativeArray<Entity> ACFNIIMFABG, EntityManager FAPAMPDMFAG, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60B6E00", Offset = "0x60B5C00", VA = "0x1860B6E00")]
	public static NativeArray<Entity> PJHBEIPGGPD(this NativeArray<Entity> ACFNIIMFABG, EntityManager FAPAMPDMFAG, ComponentType NJCJAJJDPPI, Allocator MGPHHCICJPF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x284B180", Offset = "0x2849F80", VA = "0x18284B180")]
	public static NativeArray<T> DEGIPIPHPLL<T>(this NativeArray<Entity> ACFNIIMFABG, EntityManager FAPAMPDMFAG, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class AJHBLJHJLIC
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct FJELHLMDCCL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct EJMAEKAODBN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public FJELHLMDCCL<TFrom> HAMFKMJEGLE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<TFrom> BMBDDEJKCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct HMINFMCLEGB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct LMLHAOFODOB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HMINFMCLEGB<TFrom> HAMFKMJEGLE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeArrayAsync<TFrom> BMBDDEJKCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct EGMEOLAFPLO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct MODCEADLBLO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public EGMEOLAFPLO<TFrom> HAMFKMJEGLE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeListAsync<TFrom> BMBDDEJKCJA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KGMGJIFNGDL
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HJJGNNJEDBG
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct IIMAODAOBMP : NOMODBOKHHO<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IMCFJBBENGO;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60B6730", Offset = "0x60B5530", VA = "0x1860B6730")]
		[BurstCompatible]
		public Entity GCOFJAMIEAF([In] Entity NKKIECLCEML)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60B6730", Offset = "0x60B5530", VA = "0x1860B6730", Slot = "4")]
		private Entity KNFCBNEKMGH([In] Entity NKKIECLCEML)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KAEPICJNFBA
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct FOFBKGOOENO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<Entity> OJOLJKKHMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<T> BMBDDEJKCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct PHBOPIMCHFC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<Entity> OJOLJKKHMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<T> BMBDDEJKCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct OFCGCCPGEDD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<Entity> OJOLJKKHMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArrayAsync<T> BMBDDEJKCJA;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2651050", Offset = "0x264FE50", VA = "0x182651050")]
		public NativeListAsync<Entity> ABCKFNDAOCC<TPredicate>() where TPredicate : struct, EJCDBMFOJHN<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2770CC0", Offset = "0x276FAC0", VA = "0x182770CC0")]
	public static OFCGCCPGEDD<T> GDLIBPEHFJB<T>(this NativeArrayAsync<Entity> DIAOIIMGPGN, NativeArrayAsync<T> ACFNIIMFABG, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct
	{
		return default(OFCGCCPGEDD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KAEHAFPJLEG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2770C00", Offset = "0x276FA00", VA = "0x182770C00")]
	public static NativeListAsync<Entity> HEMBPPLACOA<T, TPredicate>(this NativeArrayAsync<T> ACFNIIMFABG, NativeArrayAsync<Entity> DIAOIIMGPGN, Allocator MGPHHCICJPF = Allocator.TempJob) where T : struct where TPredicate : struct, EJCDBMFOJHN<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2770A60", Offset = "0x276F860", VA = "0x182770A60")]
	private static NativeListAsync<Entity> FAAOLIEDCBM<T, TPredicate>(NativeArrayAsync<T> JKFGINEIHLA, NativeArrayAsync<Entity> DIAOIIMGPGN, int FAPCCJLFBAA, Allocator MGPHHCICJPF) where T : struct where TPredicate : struct, EJCDBMFOJHN<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OPGECMLJNPI
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct LNECGCHPIEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<T> BMBDDEJKCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct FBKDFIMAOJA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<T> BMBDDEJKCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct ACHPEAOMJIL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArrayAsync<T> BMBDDEJKCJA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct BGHHEGMMOCO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator MGPHHCICJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeListAsync<T> BMBDDEJKCJA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LLKBANPECFP
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BEECOJILIPF
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24E6520", Offset = "0x24E5320", VA = "0x1824E6520")]
	public static NativeList<Entity> PMPNPHEFBLP<T>(this NativeArray<Entity> DIAOIIMGPGN, EntityManager FAPAMPDMFAG, Allocator MGPHHCICJPF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class KOMDMAFJOIB
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class EGMACAKEEHD
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct IIEMAOOKMBA<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> AAKJIOEDOGA;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
		public IIEMAOOKMBA(NativeArray<TSrc> AAKJIOEDOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public ICMPFCJMAAJ<TSrc, TValue> JMFNBLIKJDL<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(ICMPFCJMAAJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct ICMPFCJMAAJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> AAKJIOEDOGA;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
		public ICMPFCJMAAJ(NativeArray<TSrc> AAKJIOEDOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public OFFFHLEKMMJ<TSrc, TValue, TSelector> MDFJPHFNJAL<TSelector>() where TSelector : struct, NOMODBOKHHO<TSrc, TValue>
		{
			return default(OFFFHLEKMMJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public readonly struct OFFFHLEKMMJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NOMODBOKHHO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> AAKJIOEDOGA;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
		public OFFFHLEKMMJ(NativeArray<TSrc> AAKJIOEDOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3F61760", Offset = "0x3F60560", VA = "0x183F61760")]
		public FNJBOADDPOJ<TSrc, TValue, TSelector> JIPMKFIKOAP()
		{
			return default(FNJBOADDPOJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct PPELMNGMAGK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NOMODBOKHHO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> AAKJIOEDOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TSelector KKOIBCLPOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int ENPOKNEMOMH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x405DE50", Offset = "0x405CC50", VA = "0x18405DE50")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int CCEAOHGDFHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9D47D0", Offset = "0x9D35D0", VA = "0x1809D47D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int AAKPPKIKEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x405DEE0", Offset = "0x405CCE0", VA = "0x18405DEE0")]
		public PPELMNGMAGK(NativeArray<TSrc> AAKJIOEDOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x405DD60", Offset = "0x405CB60", VA = "0x18405DD60")]
		public bool CKKKMHDEGBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x405DD70", Offset = "0x405CB70", VA = "0x18405DD70")]
		private TSrc EIJFKNAJFCM(int PGCIMAABPAK)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct FNJBOADDPOJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NOMODBOKHHO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private PPELMNGMAGK<TSrc, TValue, TSelector> GBMJFFENPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TValue HAHPBLNNPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int BKOJFCPJPEL;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JCFONEGNMOF EEHLPDCCKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x35DFA80", Offset = "0x35DE880", VA = "0x1835DFA80")]
			get
			{
				return default(JCFONEGNMOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue FLMHMJBJLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, JCFONEGNMOF range) ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x35DFAC0", Offset = "0x35DE8C0", VA = "0x1835DFAC0")]
			get
			{
				return default((TValue, JCFONEGNMOF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x35DFBA0", Offset = "0x35DE9A0", VA = "0x1835DFBA0")]
		public FNJBOADDPOJ(NativeArray<TSrc> AAKJIOEDOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x32600E0", Offset = "0x325EEE0", VA = "0x1832600E0")]
		public FNJBOADDPOJ<TSrc, TValue, TSelector> OOEEFIELKKG()
		{
			return default(FNJBOADDPOJ<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x35DF940", Offset = "0x35DE740", VA = "0x1835DF940")]
		public bool CKKKMHDEGBJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x25C7030", Offset = "0x25C5E30", VA = "0x1825C7030")]
	public static IIEMAOOKMBA<T> BIMPHBPHAKD<T>(this NativeList<T> FOKGGJDBEOD) where T : struct
	{
		return default(IIEMAOOKMBA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
	public static IIEMAOOKMBA<T> BIMPHBPHAKD<T>(this NativeArray<T> AAKJIOEDOGA) where T : struct
	{
		return default(IIEMAOOKMBA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class BGDMDIGCFJN
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct NKMECCPEOFH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<T>.ReadOnly AAKJIOEDOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int BKOJFCPJPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int DMNCNIOCGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T HAHPBLNNPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private T OKOBEHKNMBD;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JCFONEGNMOF EEHLPDCCKFB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3E75BF0", Offset = "0x3E749F0", VA = "0x183E75BF0")]
			get
			{
				return default(JCFONEGNMOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T FLMHMJBJLKA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x32C36E0", Offset = "0x32C24E0", VA = "0x1832C36E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, JCFONEGNMOF) ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3E75CB0", Offset = "0x3E74AB0", VA = "0x183E75CB0")]
			get
			{
				return default((T, JCFONEGNMOF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3E75E30", Offset = "0x3E74C30", VA = "0x183E75E30")]
		public NKMECCPEOFH(NativeArray<T> AAKJIOEDOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E75D80", Offset = "0x3E74B80", VA = "0x183E75D80")]
		public NKMECCPEOFH<T> OOEEFIELKKG()
		{
			return default(NKMECCPEOFH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E75A10", Offset = "0x3E74810", VA = "0x183E75A10")]
		public bool CKKKMHDEGBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2650CA0", Offset = "0x264FAA0", VA = "0x182650CA0")]
		public PBNBIPFJMOA<T, TComparer> LCOKLAFJEHM<TComparer>([Optional] TComparer CNOALCGCHPH) where TComparer : struct, IEqualityComparer<T>
		{
			return default(PBNBIPFJMOA<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct PBNBIPFJMOA<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T>.ReadOnly AAKJIOEDOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int BKOJFCPJPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int DMNCNIOCGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T HAHPBLNNPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private T OKOBEHKNMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TComparer CNOALCGCHPH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JCFONEGNMOF EEHLPDCCKFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3E75BF0", Offset = "0x3E749F0", VA = "0x183E75BF0")]
			get
			{
				return default(JCFONEGNMOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T FLMHMJBJLKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x32C36E0", Offset = "0x32C24E0", VA = "0x1832C36E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4011100", Offset = "0x400FF00", VA = "0x184011100")]
		public PBNBIPFJMOA(NativeArray<T>.ReadOnly AAKJIOEDOGA, TComparer CNOALCGCHPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4010F20", Offset = "0x400FD20", VA = "0x184010F20")]
		public bool CKKKMHDEGBJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x24E6BD0", Offset = "0x24E59D0", VA = "0x1824E6BD0")]
	public static NKMECCPEOFH<T> JIPMKFIKOAP<T>(this NativeArray<T> AAKJIOEDOGA) where T : struct
	{
		return default(NKMECCPEOFH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface FCPHNOLBAMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class LJJGBKOKHPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PEPNPFFBOKL<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class MJECKPBOHED : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PEPNPFFBOKL<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA34F00", Offset = "0xA33D00", VA = "0x180A34F00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x362C6C0", Offset = "0x362B4C0", VA = "0x18362C6C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public MJECKPBOHED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8350", Offset = "0x3DE7150", VA = "0x183DE8350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8500", Offset = "0x3DE7300", VA = "0x183DE8500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Action<Protobuf> PGGNEJBNFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MemoryStream MKCMLPKFPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CodedInputStream MABPGCPDLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Protobuf DHPMDODHMON;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int AAKPPKIKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x403CE70", Offset = "0x403BC70", VA = "0x18403CE70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x403CEB0", Offset = "0x403BCB0", VA = "0x18403CEB0", Slot = "4")]
	[IteratorStateMachine(typeof(PEPNPFFBOKL<>.MJECKPBOHED))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x403CFA0", Offset = "0x403BDA0", VA = "0x18403CFA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct LJJIEEMINMO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly byte[] CDNPBOBHCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Protobuf DHPMDODHMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream MKCMLPKFPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedOutputStream HHJILKPDFIA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7A70", Offset = "0x3BF6870", VA = "0x183BF7A70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct BKBIDOJKCNN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream MKCMLPKFPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedInputStream MABPGCPDLKI;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x60B6150", Offset = "0x60B4F50", VA = "0x1860B6150", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct NNNDDMIKALH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly byte[] CDNPBOBHCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MemoryStream MKCMLPKFPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CodedOutputStream HHJILKPDFIA;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x60B6C20", Offset = "0x60B5A20", VA = "0x1860B6C20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MPCDLKGHJOP
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class LKFBMBCKDHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
public enum IHGHKMELNEC
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class NCEMGOGHMPP
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class JLGMMEPJMLK
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JLGMMEPJMLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
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
