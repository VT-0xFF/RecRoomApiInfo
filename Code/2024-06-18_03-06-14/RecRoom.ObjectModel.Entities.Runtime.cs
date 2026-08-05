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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B8A50", Offset = "0x69B7450", VA = "0x1869B8A50")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AGBGMNKBPBB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EEAMKEIKHIH AFJEKJHILFP
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
public interface COKKELBLFID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDDHEJGCKAP(Entity INJBCGOEBHC, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MLDBOCJGDIA(Entity INJBCGOEBHC, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AMHOEHAJGEA(Entity INJBCGOEBHC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FGNPFCKHKGH<TComponentData, TValue> : MJOEJFGMILL<TValue>, IDisposable where TComponentData : struct, AGBGMNKBPBB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class EEHLMDILDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> AGFBCPPODBI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int BGDNEMFMALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3563C40", Offset = "0x3562640", VA = "0x183563C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x383EF80", Offset = "0x383D980", VA = "0x18383EF80")]
		public bool EBBEGJLHNDP([Out] TValue DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x383F170", Offset = "0x383DB70", VA = "0x18383F170")]
		public void KODKNHDNNHA(object JCIFCENKMKP, TValue DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x383F250", Offset = "0x383DC50", VA = "0x18383F250")]
		public bool PLMGPBLKDNE(object JCIFCENKMKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x383F090", Offset = "0x383DA90", VA = "0x18383F090")]
		public int IHJKALNGAGB(object JCIFCENKMKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x383F300", Offset = "0x383DD00", VA = "0x18383F300")]
		public EEHLMDILDJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<EEHLMDILDJO> NONHDBNHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LGLDGIOBEKC<EEAMKEIKHIH, EEHLMDILDJO> CNDPFCENIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager NFHPCHOLBII;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF6B0", Offset = "0x3BFE0B0", VA = "0x183BFF6B0")]
	public FGNPFCKHKGH(EntityManager NFHPCHOLBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF140", Offset = "0x3BFDB40", VA = "0x183BFF140", Slot = "4")]
	public void JDDHEJGCKAP(Entity INJBCGOEBHC, object JCIFCENKMKP, TValue DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF3A0", Offset = "0x3BFDDA0", VA = "0x183BFF3A0", Slot = "5")]
	public bool MLDBOCJGDIA(Entity INJBCGOEBHC, object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF030", Offset = "0x3BFDA30", VA = "0x183BFF030", Slot = "6")]
	public bool EBBEGJLHNDP(Entity INJBCGOEBHC, [Out] TValue DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF010", Offset = "0x3BFDA10", VA = "0x183BFF010", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFEF50", Offset = "0x3BFD950", VA = "0x183BFEF50")]
	private void BPFIAOMBAIP(EEHLMDILDJO DHGDHFJOOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF2E0", Offset = "0x3BFDCE0", VA = "0x183BFF2E0")]
	private bool LPCJOALNEID(Entity INJBCGOEBHC, [Out] EEAMKEIKHIH AHCMMMOBCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3BFEE50", Offset = "0x3BFD850", VA = "0x183BFEE50")]
	private void AMDHKACAKKK(Entity INJBCGOEBHC, EEAMKEIKHIH AHCMMMOBCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF2C0", Offset = "0x3BFDCC0", VA = "0x183BFF2C0")]
	private bool LDDBEFJLPEO(EEAMKEIKHIH AHCMMMOBCPP, [Out] EEHLMDILDJO DHGDHFJOOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF590", Offset = "0x3BFDF90", VA = "0x183BFF590")]
	private EEHLMDILDJO PEHFBBDDFMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MJOEJFGMILL<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDDHEJGCKAP(Entity INJBCGOEBHC, object JCIFCENKMKP, TValue DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MLDBOCJGDIA(Entity INJBCGOEBHC, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBBEGJLHNDP(Entity INJBCGOEBHC, [Out] TValue DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EEAMKEIKHIH : JAPLOFGMOOP, IEquatable<EEAMKEIKHIH>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly EEAMKEIKHIH OPGDHOBODPJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int JCLKIAMNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x92B7E0", Offset = "0x92A1E0", VA = "0x18092B7E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MOFBDCNAPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x253EE00", Offset = "0x253D800", VA = "0x18253EE00", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAD0", Offset = "0x5CAA4D0", VA = "0x185CABAD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69B89B0", Offset = "0x69B73B0", VA = "0x1869B89B0", Slot = "8")]
	public bool Equals(EEAMKEIKHIH HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69B8A00", Offset = "0x69B7400", VA = "0x1869B8A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OBDDNAFCDAN<THasTokensTag> : COKKELBLFID, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, EEAMKEIKHIH> KHLHFFIHLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> NONHDBNHJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LGLDGIOBEKC<EEAMKEIKHIH, HashSet<object>> CNDPFCENIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager NFHPCHOLBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem AOKKCDEKPGH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x45F5020", Offset = "0x45F3A20", VA = "0x1845F5020")]
	public OBDDNAFCDAN(EntityManager NFHPCHOLBII, EntityCommandBufferSystem AOKKCDEKPGH, LGKLDLNGEGN LAGLDPBDLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x45F3200", Offset = "0x45F1C00", VA = "0x1845F3200", Slot = "4")]
	public bool JDDHEJGCKAP(Entity INJBCGOEBHC, object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x45F42E0", Offset = "0x45F2CE0", VA = "0x1845F42E0", Slot = "5")]
	public bool MLDBOCJGDIA(Entity INJBCGOEBHC, object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x45F2860", Offset = "0x45F1260", VA = "0x1845F2860", Slot = "6")]
	public bool AMHOEHAJGEA(Entity INJBCGOEBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x45F27B0", Offset = "0x45F11B0", VA = "0x1845F27B0", Slot = "8")]
	public bool AMHOEHAJGEA(EEAMKEIKHIH AHCMMMOBCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x45F2FA0", Offset = "0x45F19A0", VA = "0x1845F2FA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x45F2B90", Offset = "0x45F1590", VA = "0x1845F2B90")]
	private void BPFIAOMBAIP(HashSet<object> DHGDHFJOOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x45F3C60", Offset = "0x45F2660", VA = "0x1845F3C60")]
	private bool LPCJOALNEID(Entity INJBCGOEBHC, [Out] EEAMKEIKHIH AHCMMMOBCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x45F48A0", Offset = "0x45F32A0", VA = "0x1845F48A0")]
	private bool PJJPKIKNBEF(Entity INJBCGOEBHC, [Out] EEAMKEIKHIH AHCMMMOBCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x45F37E0", Offset = "0x45F21E0", VA = "0x1845F37E0")]
	private void KFAJNABEGFK(Entity INJBCGOEBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x45F21F0", Offset = "0x45F0BF0", VA = "0x1845F21F0")]
	private void AIILKDNIDOL(Entity INJBCGOEBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45F2D80", Offset = "0x45F1780", VA = "0x1845F2D80")]
	private void CDDEJBMGKOP(Entity INJBCGOEBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x45F26D0", Offset = "0x45F10D0", VA = "0x1845F26D0")]
	private void AMDHKACAKKK(Entity INJBCGOEBHC, EEAMKEIKHIH AHCMMMOBCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x45F3B40", Offset = "0x45F2540", VA = "0x1845F3B40")]
	private bool LMJMNPKJBDC(EEAMKEIKHIH AHCMMMOBCPP, [Out] HashSet<object> DHGDHFJOOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x45F4800", Offset = "0x45F3200", VA = "0x1845F4800")]
	private HashSet<object> PEHFBBDDFMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LKFLIGDPLPC
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BEEKJFAIHFH : OBOOEFLOMLA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69B8800", Offset = "0x69B7200", VA = "0x1869B8800")]
	public float EFBGOPEJNJN([In] float3 DBOBEHLEAAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69B8800", Offset = "0x69B7200", VA = "0x1869B8800", Slot = "4")]
	private float JKIMCFCIKGP([In] float3 DBOBEHLEAAE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KDIEMMBADFB : OBOOEFLOMLA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69B9050", Offset = "0x69B7A50", VA = "0x1869B9050")]
	public float EFBGOPEJNJN([In] float3 DBOBEHLEAAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69B9050", Offset = "0x69B7A50", VA = "0x1869B9050", Slot = "4")]
	private float JKIMCFCIKGP([In] float3 DBOBEHLEAAE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CGGCNBOJEKG : OBOOEFLOMLA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1CB4FC0", Offset = "0x1CB39C0", VA = "0x181CB4FC0")]
	public float EFBGOPEJNJN([In] float3 DBOBEHLEAAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CB4FC0", Offset = "0x1CB39C0", VA = "0x181CB4FC0", Slot = "4")]
	private float JKIMCFCIKGP([In] float3 DBOBEHLEAAE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JKMPKIDDFNH : OBOOEFLOMLA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x158E9A0", Offset = "0x158D3A0", VA = "0x18158E9A0")]
	public int EFBGOPEJNJN([In] int3 DBOBEHLEAAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x158E9A0", Offset = "0x158D3A0", VA = "0x18158E9A0", Slot = "4")]
	private int OIHNJILHLIM([In] int3 DBOBEHLEAAE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PDBIGKEAEOJ : OBOOEFLOMLA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69B9630", Offset = "0x69B8030", VA = "0x1869B9630")]
	public int EFBGOPEJNJN([In] int3 DBOBEHLEAAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69B9630", Offset = "0x69B8030", VA = "0x1869B9630", Slot = "4")]
	private int OIHNJILHLIM([In] int3 DBOBEHLEAAE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EIDAFMDHLDB : OBOOEFLOMLA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1897960", Offset = "0x1896360", VA = "0x181897960")]
	public int EFBGOPEJNJN([In] int3 DBOBEHLEAAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1897960", Offset = "0x1896360", VA = "0x181897960", Slot = "4")]
	private int OIHNJILHLIM([In] int3 DBOBEHLEAAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FDGPHHKEKKC : HJDOGECJOAI
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14C46D0", Offset = "0x14C30D0", VA = "0x1814C46D0")]
	public FDGPHHKEKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NDJLKBFCMBA : SystemBase, NHPILMAHCIC
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69B9320", Offset = "0x69B7D20", VA = "0x1869B9320")]
	public JobHandle CMKMBHJPJEK(ReadOnlySpan<int> EMHJOFDFKFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B2A0", Offset = "0x2C79CA0", VA = "0x182C7B2A0")]
	public void PEKMBIHCMPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B790", Offset = "0x2C7A190", VA = "0x182C7B790")]
	public JobHandle PEKMBIHCMPN<T>(JobHandle AHCMMMOBCPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69B9450", Offset = "0x69B7E50", VA = "0x1869B9450")]
	public JobHandle PEKMBIHCMPN(ReadOnlySpan<int> EMHJOFDFKFC, JobHandle AHCMMMOBCPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B2A0", Offset = "0x2C79CA0", VA = "0x182C7B2A0")]
	public void FLFPHLHCPAH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AF20", Offset = "0x2C79920", VA = "0x182C7AF20")]
	public JobHandle FLFPHLHCPAH<T>(JobHandle AHCMMMOBCPP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69B9370", Offset = "0x69B7D70", VA = "0x1869B9370")]
	public ComponentDataFromEntity HMOFMEICCLG(int NCLOOEMMHHO, bool KFAPFHIACIM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69B9430", Offset = "0x69B7E30", VA = "0x1869B9430")]
	public EntityExistenceLookupByEntity LBLGNEGGPBF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69B94C0", Offset = "0x69B7EC0", VA = "0x1869B94C0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14C46D0", Offset = "0x14C30D0", VA = "0x1814C46D0")]
	protected NDJLKBFCMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class MBONIOMBLPG : NDJLKBFCMBA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69B92F0", Offset = "0x69B7CF0", VA = "0x1869B92F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x14C46D0", Offset = "0x14C30D0", VA = "0x1814C46D0")]
	protected MBONIOMBLPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CBJAHDHGHIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class GEHKBOPPANN : EntityCommandBufferSystem, NHPILMAHCIC
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x14C46D0", Offset = "0x14C30D0", VA = "0x1814C46D0")]
	protected GEHKBOPPANN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OBOOEFLOMLA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo EFBGOPEJNJN([In] TFrom DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IPNJBKGHEPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJOMFOPEECD(T DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct JMMOMNAAEEK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> MIIDIGABFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer EHKBKPKMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes FIKHFLHCHKN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69B8EC0", Offset = "0x69B78C0", VA = "0x1869B8EC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct JMOLNDNDBMN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> MIIDIGABFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer EHKBKPKMEGJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69B8FB0", Offset = "0x69B79B0", VA = "0x1869B8FB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct CCPMFNGJMCC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> MIIDIGABFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer EHKBKPKMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType PDICIOPEDFF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69B8810", Offset = "0x69B7210", VA = "0x1869B8810", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct DCPELGBCAKA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> MIIDIGABFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> EEOBDBMOHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer EHKBKPKMEGJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x57640E0", Offset = "0x5762AE0", VA = "0x1857640E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct HMDGNBKBJBG<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> MIIDIGABFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> AHBFNFFEMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer EHKBKPKMEGJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct AAJAIMGMDJC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> MIIDIGABFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T DBOBEHLEAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer EHKBKPKMEGJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3CA7530", Offset = "0x3CA5F30", VA = "0x183CA7530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct GGCAAFBGBHK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OBOOEFLOMLA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> MAIGBGEHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> JPEJHKMNEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap GKKKLNHPKBN;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct IEFFCIIFONL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity JIPFFPGAJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> MAIGBGEHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> JPEJHKMNEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int JCKPMIDLFJD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69B8B00", Offset = "0x69B7500", VA = "0x1869B8B00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct DKBGJOCDHJL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ABEHHOBILMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> MAIGBGEHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> GMFMHDIGPPI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct HMGFBDOMNHM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OBOOEFLOMLA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> PKIAFICAKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> JPEJHKMNEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap GKKKLNHPKBN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct ICFFLEBHOAB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CFAAAFCFKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> OPCPANAIMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> MOHOLKIHOOK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct CHHGCJHABGP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CFAAAFCFKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> OPCPANAIMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> MOHOLKIHOOK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5164EB0", Offset = "0x51638B0", VA = "0x185164EB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct LOMNMCNBFFO<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> MAIGBGEHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> GMFMHDIGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> PJKOKMEJLGC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x42A70C0", Offset = "0x42A5AC0", VA = "0x1842A70C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct FBDGNOAFIOB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : OBOOEFLOMLA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> MAIGBGEHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> GMFMHDIGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> PJKOKMEJLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap GKKKLNHPKBN;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct DIPLMFLCBAL<T, TPredicate> : IJob where T : struct where TPredicate : struct, IPNJBKGHEPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> MAIGBGEHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> JMPCOIDLMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> PKFMAFNOCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate GKKKLNHPKBN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JBHCPIEKJIM<T, TPredicate> : IJob where T : struct where TPredicate : struct, IPNJBKGHEPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> MAIGBGEHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> GMFMHDIGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate GKKKLNHPKBN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct PCDCDMFHHOO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity CFAAAFCFKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> OPCPANAIMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> ICFLGCNNFOG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69B95A0", Offset = "0x69B7FA0", VA = "0x1869B95A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct OJKCIOIHLPP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity CFAAAFCFKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> OPCPANAIMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> ICFLGCNNFOG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69B94D0", Offset = "0x69B7ED0", VA = "0x1869B94D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BINGDINBCHC
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MBODDJJMCPO
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6930", Offset = "0x2BF5330", VA = "0x182BF6930")]
	public static bool DFOBINONDDB<T>(this NativeArray<Entity> OPCPANAIMAB, EntityManager NFHPCHOLBII, Allocator BPMIGAHMDHE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FHENOCACHNI
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DMLFKHEGFOC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public DMLFKHEGFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ACGOCCLOPAN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public ACGOCCLOPAN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> CMMGKBJIKJJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69B8A70", Offset = "0x69B7470", VA = "0x1869B8A70")]
	public FHENOCACHNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KPNNJKHCJGG
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PAJDCLJNLDM
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct KBLFHNKIADL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct KFDGGOAONFA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal KBLFHNKIADL<TFrom> EMNGIAIDBPA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> PPJABDMHAEE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct KAGFCIPOHNL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct IDNPJEHDMGC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal KAGFCIPOHNL<TFrom> EMNGIAIDBPA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> PPJABDMHAEE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct OCMLPDNJHKL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JKEDFNHHFBA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal OCMLPDNJHKL<TFrom> EMNGIAIDBPA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> PPJABDMHAEE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct FNCPPLAAPMI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct CBJAHMLKOGK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal FNCPPLAAPMI<TFrom> EMNGIAIDBPA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> PPJABDMHAEE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FNMJKPGFIEA
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PKHEMIAKFCK
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5E60", Offset = "0x2CF4860", VA = "0x182CF5E60")]
	public static NativeList<T> KLPODFMFHMB<T>(this NativeArray<T> OGLPFLDJCNE, Allocator BPMIGAHMDHE = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class AAIHFCEEOHO
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IKPGHFAEBOE
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B8D0", Offset = "0x2B5A2D0", VA = "0x182B5B8D0")]
	[CGDKLDMLJEN]
	public static JobHandle KBDHMHFMECM<T>(this EntityCommandBufferSystem AOKKCDEKPGH, NativeArrayAsync<Entity> MIIDIGABFDA, NativeArrayAsync<T> EEOBDBMOHPL, [Optional] JobHandle GKJKEOKEOCI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B5BA50", Offset = "0x2B5A450", VA = "0x182B5BA50")]
	[CGDKLDMLJEN]
	public static JobHandle KBDHMHFMECM<T>(this EntityCommandBufferSystem AOKKCDEKPGH, NativeArrayAsync<Entity> MIIDIGABFDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B7A0", Offset = "0x2B5A1A0", VA = "0x182B5B7A0")]
	[CGDKLDMLJEN]
	public static JobHandle KBDHMHFMECM<T>(this EntityCommandBufferSystem AOKKCDEKPGH, NativeArray<Entity> MIIDIGABFDA, [Optional] JobHandle GKJKEOKEOCI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69B8C00", Offset = "0x69B7600", VA = "0x1869B8C00")]
	[CGDKLDMLJEN]
	public static JobHandle KBDHMHFMECM(this EntityCommandBufferSystem AOKKCDEKPGH, NativeArray<Entity> MIIDIGABFDA, ComponentTypes FIKHFLHCHKN, [Optional] JobHandle GKJKEOKEOCI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69B8D70", Offset = "0x69B7770", VA = "0x1869B8D70")]
	[CGDKLDMLJEN]
	public static JobHandle KBDHMHFMECM(this EntityCommandBufferSystem AOKKCDEKPGH, EntityCommandBuffer EHKBKPKMEGJ, NativeArray<Entity> MIIDIGABFDA, ComponentTypes FIKHFLHCHKN, [Optional] JobHandle GKJKEOKEOCI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AJIBEHDAHPC
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x31F2290", Offset = "0x31F0C90", VA = "0x1831F2290")]
	[CGDKLDMLJEN]
	public static JobHandle OKPCPOBBAHP<T>(this EntityCommandBufferSystem AOKKCDEKPGH, EntityCommandBuffer EHKBKPKMEGJ, EntityQuery LAMMLOKDPEJ, T DBOBEHLEAAE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KLJOOJDLINI
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69B9160", Offset = "0x69B7B60", VA = "0x1869B9160")]
	[CGDKLDMLJEN]
	public static JobHandle ADFEMAEOBNO(this EntityCommandBufferSystem AOKKCDEKPGH, NativeList<Entity> MIIDIGABFDA, [Optional] JobHandle GKJKEOKEOCI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69B9060", Offset = "0x69B7A60", VA = "0x1869B9060")]
	[CGDKLDMLJEN]
	public static JobHandle ADFEMAEOBNO(this EntityCommandBufferSystem AOKKCDEKPGH, NativeArrayAsync<Entity> MIIDIGABFDA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AHPLBAGALLP
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HNMPKKMFLFB
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B48F60", Offset = "0x2B47960", VA = "0x182B48F60")]
	[CGDKLDMLJEN]
	public static JobHandle FPLILNCEGLB<T>(this EntityCommandBufferSystem AOKKCDEKPGH, NativeArray<Entity> MIIDIGABFDA, NativeArray<T> EEOBDBMOHPL, JobHandle GKJKEOKEOCI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BDOGLAMPMDC
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28B8310", Offset = "0x28B6D10", VA = "0x1828B8310")]
	[CGDKLDMLJEN]
	public static JobHandle EALFFKDFBGO<T>(this EntityCommandBufferSystem AOKKCDEKPGH, NativeArray<Entity> MIIDIGABFDA, T DBOBEHLEAAE, [Optional] JobHandle GKJKEOKEOCI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28B8230", Offset = "0x28B6C30", VA = "0x1828B8230")]
	[CGDKLDMLJEN]
	public static JobHandle EALFFKDFBGO<T>(this EntityCommandBufferSystem AOKKCDEKPGH, EntityCommandBuffer EHKBKPKMEGJ, NativeArray<Entity> MIIDIGABFDA, T DBOBEHLEAAE, [Optional] JobHandle GKJKEOKEOCI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class HKCFGJPIHLF
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AKMLLJJOKDL
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x31F3270", Offset = "0x31F1C70", VA = "0x1831F3270")]
	public static NativeArray<T> AADEANEONAL<T>(this NativeList<Entity> OGLPFLDJCNE, EntityManager NFHPCHOLBII, Allocator BPMIGAHMDHE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x31F2CD0", Offset = "0x31F16D0", VA = "0x1831F2CD0")]
	public static NativeArray<T> AADEANEONAL<T>(this NativeArray<Entity> OGLPFLDJCNE, EntityManager NFHPCHOLBII, Allocator BPMIGAHMDHE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69B8610", Offset = "0x69B7010", VA = "0x1869B8610")]
	public static NativeArray<Entity> BLAGHDDIPDD(this NativeArray<Entity> OGLPFLDJCNE, EntityManager NFHPCHOLBII, ComponentType PDICIOPEDFF, Allocator BPMIGAHMDHE = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31F3340", Offset = "0x31F1D40", VA = "0x1831F3340")]
	public static NativeArray<T> IJIDPCHMGKP<T>(this NativeArray<Entity> OGLPFLDJCNE, EntityManager NFHPCHOLBII, Allocator BPMIGAHMDHE = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KBNOABEIICG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct GKHLDBAEHBN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct JFNIHOOJPAP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public GKHLDBAEHBN<TFrom> PPJABDMHAEE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> MAIGBGEHHIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct JIJBBCKLGOE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct NJFLPBNNPPE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public JIJBBCKLGOE<TFrom> PPJABDMHAEE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> MAIGBGEHHIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GPODJIIGDHJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct HKKFGKDLEOB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public GPODJIIGDHJ<TFrom> PPJABDMHAEE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> MAIGBGEHHIK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GMPNOAIHMJC
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class MFHEGLGHKCL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct APLHHAFEEIA : OBOOEFLOMLA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> POAIJLINPAL;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69B87F0", Offset = "0x69B71F0", VA = "0x1869B87F0")]
		[BurstCompatible]
		public Entity EFBGOPEJNJN([In] Entity DBOBEHLEAAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69B87F0", Offset = "0x69B71F0", VA = "0x1869B87F0", Slot = "4")]
		private Entity ODMKNGCLMBA([In] Entity DBOBEHLEAAE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BFCOELMIMDI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BMJPOAAPDCI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> JMPCOIDLMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> MAIGBGEHHIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct ACMMGCFNEEC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> JMPCOIDLMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> MAIGBGEHHIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct EPFHCAMPDNO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> JMPCOIDLMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> MAIGBGEHHIK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class BINEMOANCCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class BPCIMPLDNFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct IHOCCLEBBKF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> MAIGBGEHHIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct KCGHMGOBEHB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> MAIGBGEHHIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct BPKEOHLEFFK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> MAIGBGEHHIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct FDJNMLNKKMM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator BPMIGAHMDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> MAIGBGEHHIK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class PLLFOKBGIBC
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LPFIJFAPCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7110", Offset = "0x2BE5B10", VA = "0x182BE7110")]
	public static NativeList<Entity> MCGIBOCLCJN<T>(this NativeArray<Entity> OPCPANAIMAB, EntityManager NFHPCHOLBII, Allocator BPMIGAHMDHE = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class AGJLKGAEEHH
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class DELJNAOILOM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct NBPLKJJIHEE<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> MHMBNFEOIBK;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
		public NBPLKJJIHEE(NativeArray<TSrc> MHMBNFEOIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public CGDLNJJGKNJ<TSrc, TValue> ENGPFECLJIM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(CGDLNJJGKNJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct CGDLNJJGKNJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> MHMBNFEOIBK;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
		public CGDLNJJGKNJ(NativeArray<TSrc> MHMBNFEOIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public JDBBCOLMFOB<TSrc, TValue, TSelector> IHMFNIBBFEG<TSelector>() where TSelector : struct, OBOOEFLOMLA<TSrc, TValue>
		{
			return default(JDBBCOLMFOB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct JDBBCOLMFOB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OBOOEFLOMLA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> MHMBNFEOIBK;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
		public JDBBCOLMFOB(NativeArray<TSrc> MHMBNFEOIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x404DA30", Offset = "0x404C430", VA = "0x18404DA30")]
		public NMAKHFHGGJO<TSrc, TValue, TSelector> OCOLLBPEPJJ()
		{
			return default(NMAKHFHGGJO<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct DMJLADGMOOG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, OBOOEFLOMLA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> MHMBNFEOIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector HEJOGNIIIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int ILOCEPPJPDO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x57D0FB0", Offset = "0x57CF9B0", VA = "0x1857D0FB0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JCLKIAMNLIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8C0BE0", Offset = "0x8BF5E0", VA = "0x1808C0BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NBLIGAPNOOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDFC0", Offset = "0x1FCC9C0", VA = "0x181FCDFC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x57D1090", Offset = "0x57CFA90", VA = "0x1857D1090")]
		public DMJLADGMOOG(NativeArray<TSrc> MHMBNFEOIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x57D1080", Offset = "0x57CFA80", VA = "0x1857D1080")]
		public bool NHDBGAGIJHC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x57D0EB0", Offset = "0x57CF8B0", VA = "0x1857D0EB0")]
		private TSrc BCGDIOILKAC(int KLFNJJLKNGE)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x57D0FF0", Offset = "0x57CF9F0", VA = "0x1857D0FF0")]
		private TValue CLNMMEFPJJP()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct NMAKHFHGGJO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OBOOEFLOMLA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private DMJLADGMOOG<TSrc, TValue, TSelector> CBNHKGJHAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue EACAGIILFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int PFNBAEBFNFJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ACKOOEJPCBO CDLCMAILJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x44F8940", Offset = "0x44F7340", VA = "0x1844F8940")]
			get
			{
				return default(ACKOOEJPCBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue JDDONEBHGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, ACKOOEJPCBO range) NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x44F86F0", Offset = "0x44F70F0", VA = "0x1844F86F0")]
			get
			{
				return default((TValue, ACKOOEJPCBO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x44F8980", Offset = "0x44F7380", VA = "0x1844F8980")]
		public NMAKHFHGGJO(NativeArray<TSrc> MHMBNFEOIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FD30", Offset = "0x3E9E730", VA = "0x183E9FD30")]
		public NMAKHFHGGJO<TSrc, TValue, TSelector> PNMCCDOOLCI()
		{
			return default(NMAKHFHGGJO<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x44F87C0", Offset = "0x44F71C0", VA = "0x1844F87C0")]
		public bool NHDBGAGIJHC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29606E0", Offset = "0x295F0E0", VA = "0x1829606E0")]
	public static NBPLKJJIHEE<T> ECHPDJACLJM<T>(this NativeList<T> AGFBCPPODBI) where T : struct
	{
		return default(NBPLKJJIHEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
	public static NBPLKJJIHEE<T> ECHPDJACLJM<T>(this NativeArray<T> MHMBNFEOIBK) where T : struct
	{
		return default(NBPLKJJIHEE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class IBLJLALIICI
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct IKCPKJJLKNM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly MHMBNFEOIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int PFNBAEBFNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int EANDNBGHFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T EACAGIILFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T EFJKDBCMNGF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ACKOOEJPCBO CDLCMAILJAL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3E9FD20", Offset = "0x3E9E720", VA = "0x183E9FD20")]
			get
			{
				return default(ACKOOEJPCBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T JDDONEBHGHM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x38D9740", Offset = "0x38D8140", VA = "0x1838D9740")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, ACKOOEJPCBO) NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3E9F800", Offset = "0x3E9E200", VA = "0x183E9F800")]
			get
			{
				return default((T, ACKOOEJPCBO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FE00", Offset = "0x3E9E800", VA = "0x183E9FE00")]
		public IKCPKJJLKNM(NativeArray<T> MHMBNFEOIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FD50", Offset = "0x3E9E750", VA = "0x183E9FD50")]
		public IKCPKJJLKNM<T> PNMCCDOOLCI()
		{
			return default(IKCPKJJLKNM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F970", Offset = "0x3E9E370", VA = "0x183E9F970")]
		public bool NHDBGAGIJHC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A070", Offset = "0x2A68A70", VA = "0x182A6A070")]
		public PFHBPEOPEMI<T, TComparer> LGKPJGNNJHN<TComparer>([Optional] TComparer FLIEGGEHBEK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(PFHBPEOPEMI<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PFHBPEOPEMI<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly MHMBNFEOIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int PFNBAEBFNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int EANDNBGHFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T EACAGIILFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T EFJKDBCMNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer FLIEGGEHBEK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ACKOOEJPCBO CDLCMAILJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3E9FD20", Offset = "0x3E9E720", VA = "0x183E9FD20")]
			get
			{
				return default(ACKOOEJPCBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T JDDONEBHGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x38D9740", Offset = "0x38D8140", VA = "0x1838D9740")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x46C6230", Offset = "0x46C4C30", VA = "0x1846C6230")]
		public PFHBPEOPEMI(NativeArray<T>.ReadOnly MHMBNFEOIBK, TComparer FLIEGGEHBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x46C6050", Offset = "0x46C4A50", VA = "0x1846C6050")]
		public bool NHDBGAGIJHC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B542A0", Offset = "0x2B52CA0", VA = "0x182B542A0")]
	public static IKCPKJJLKNM<T> OCOLLBPEPJJ<T>(this NativeArray<T> MHMBNFEOIBK) where T : struct
	{
		return default(IKCPKJJLKNM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DEIAKJMAOME
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class OHDPKIFCINN
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GOCNHJMECEH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class EFCABHLJACE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public GOCNHJMECEH<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC2A030", Offset = "0xC28A30", VA = "0x180C2A030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3841110", Offset = "0x383FB10", VA = "0x183841110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
		[DebuggerHidden]
		public EFCABHLJACE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3840EF0", Offset = "0x383F8F0", VA = "0x183840EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x38410C0", Offset = "0x383FAC0", VA = "0x1838410C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> NENCGEBIFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream JCEJDGECCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream KDGPKKPNLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf MDCEGLNACHJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int NBLIGAPNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3D49FE0", Offset = "0x3D489E0", VA = "0x183D49FE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3D4A020", Offset = "0x3D48A20", VA = "0x183D4A020", Slot = "4")]
	[IteratorStateMachine(typeof(GOCNHJMECEH<>.EFCABHLJACE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4A120", Offset = "0x3D48B20", VA = "0x183D4A120", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct GBIBFEDKCPM<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] BLNHMFAPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf MDCEGLNACHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream JCEJDGECCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream MPGIGCPFPBD;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CF7B30", Offset = "0x3CF6530", VA = "0x183CF7B30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PAKCODGLCBF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream JCEJDGECCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream KDGPKKPNLDI;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69B9560", Offset = "0x69B7F60", VA = "0x1869B9560", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct CJGNALJDDAN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] BLNHMFAPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream JCEJDGECCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream MPGIGCPFPBD;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69B8890", Offset = "0x69B7290", VA = "0x1869B8890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KIPNFJPOCNH
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class LAIOKHILFME
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum KPGGOIFECBN
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
internal static class CMICNBAFOAA
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GGKFJPNBAIC
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public GGKFJPNBAIC()
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
