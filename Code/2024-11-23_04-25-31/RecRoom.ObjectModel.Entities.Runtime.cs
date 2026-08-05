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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F1E920", Offset = "0x6F1D320", VA = "0x186F1E920")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FMMBHLNCLAA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DMLFMPENEDC DDHEDJFLMGD
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
public interface AOGCHJNMKDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PHMAFLLKFNC(Entity IHGPCLDNNFC, object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMHEEMIEJEM(Entity IHGPCLDNNFC, object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CMFBBPLAEIO(Entity IHGPCLDNNFC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PKNMIJFOGDG<TComponentData, TValue> : CNOJBPHGPCM<TValue>, IDisposable where TComponentData : struct, FMMBHLNCLAA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class LOJEIFEFHOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> HIOONLIPGID;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int HMLBKDIMLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x38E2640", Offset = "0x38E1040", VA = "0x1838E2640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4689570", Offset = "0x4687F70", VA = "0x184689570")]
		public bool HNIOAOKPGHB([Out] TValue PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4689780", Offset = "0x4688180", VA = "0x184689780")]
		public void NOEGDDICEDP(object AICEIDIHFDO, TValue PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4689870", Offset = "0x4688270", VA = "0x184689870")]
		public bool PJOABDGMIKH(object AICEIDIHFDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4689680", Offset = "0x4688080", VA = "0x184689680")]
		public int LKLHKEJPMLO(object AICEIDIHFDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4689930", Offset = "0x4688330", VA = "0x184689930")]
		public LOJEIFEFHOO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<LOJEIFEFHOO> CHGIOANMPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private INEKKCBCIAF<DMLFMPENEDC, LOJEIFEFHOO> EBNGIFGACDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager LOJAAGLKEBK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B80910", Offset = "0x4B7F310", VA = "0x184B80910")]
	public PKNMIJFOGDG(EntityManager LOJAAGLKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B80780", Offset = "0x4B7F180", VA = "0x184B80780", Slot = "4")]
	public void PHMAFLLKFNC(Entity IHGPCLDNNFC, object AICEIDIHFDO, TValue PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B80360", Offset = "0x4B7ED60", VA = "0x184B80360", Slot = "5")]
	public bool GMHEEMIEJEM(Entity IHGPCLDNNFC, object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B80570", Offset = "0x4B7EF70", VA = "0x184B80570", Slot = "6")]
	public bool HNIOAOKPGHB(Entity IHGPCLDNNFC, [Out] TValue PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B80280", Offset = "0x4B7EC80", VA = "0x184B80280", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B80690", Offset = "0x4B7F090", VA = "0x184B80690")]
	private void JBCFJONFOGO(LOJEIFEFHOO DOCAMLOKNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B802A0", Offset = "0x4B7ECA0", VA = "0x184B802A0")]
	private bool ENCMGJHIOLI(Entity IHGPCLDNNFC, [Out] DMLFMPENEDC DFEBEONMKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4B80180", Offset = "0x4B7EB80", VA = "0x184B80180")]
	private void DJMHLGDDDCG(Entity IHGPCLDNNFC, DMLFMPENEDC DFEBEONMKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B80760", Offset = "0x4B7F160", VA = "0x184B80760")]
	private bool PAOKGIPAGIC(DMLFMPENEDC DFEBEONMKNH, [Out] LOJEIFEFHOO DOCAMLOKNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B80050", Offset = "0x4B7EA50", VA = "0x184B80050")]
	private LOJEIFEFHOO BJJOHIFFOLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CNOJBPHGPCM<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHMAFLLKFNC(Entity IHGPCLDNNFC, object AICEIDIHFDO, TValue PKCLPFEIPFH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMHEEMIEJEM(Entity IHGPCLDNNFC, object AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HNIOAOKPGHB(Entity IHGPCLDNNFC, [Out] TValue PKCLPFEIPFH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DMLFMPENEDC : PMIBHODOOIG, IEquatable<DMLFMPENEDC>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly DMLFMPENEDC OMNMEECEPCK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int BPKEJBPHLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PCBHJHCPNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x286D5C0", Offset = "0x286BFC0", VA = "0x18286D5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x617B8C0", Offset = "0x617A2C0", VA = "0x18617B8C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E880", Offset = "0x6F1D280", VA = "0x186F1E880", Slot = "8")]
	public bool Equals(DMLFMPENEDC GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E8D0", Offset = "0x6F1D2D0", VA = "0x186F1E8D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MEAMMPFIHFN<THasTokensTag> : AOGCHJNMKDC, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, DMLFMPENEDC> ENMGFIHBIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> CHGIOANMPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private INEKKCBCIAF<DMLFMPENEDC, HashSet<object>> EBNGIFGACDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager LOJAAGLKEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem JHOMHBKMLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x489E200", Offset = "0x489CC00", VA = "0x18489E200")]
	public MEAMMPFIHFN(EntityManager LOJAAGLKEBK, EntityCommandBufferSystem JHOMHBKMLDP, KLEHBGEJMBN HBDCLEAMFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x489DAD0", Offset = "0x489C4D0", VA = "0x18489DAD0", Slot = "4")]
	public bool PHMAFLLKFNC(Entity IHGPCLDNNFC, object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x489D010", Offset = "0x489BA10", VA = "0x18489D010", Slot = "5")]
	public bool GMHEEMIEJEM(Entity IHGPCLDNNFC, object AICEIDIHFDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x489C1C0", Offset = "0x489ABC0", VA = "0x18489C1C0", Slot = "6")]
	public bool CMFBBPLAEIO(Entity IHGPCLDNNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x489C270", Offset = "0x489AC70", VA = "0x18489C270", Slot = "8")]
	public bool CMFBBPLAEIO(DMLFMPENEDC DFEBEONMKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x489C7B0", Offset = "0x489B1B0", VA = "0x18489C7B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x489D620", Offset = "0x489C020", VA = "0x18489D620")]
	private void JBCFJONFOGO(HashSet<object> DOCAMLOKNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x489CD70", Offset = "0x489B770", VA = "0x18489CD70")]
	private bool ENCMGJHIOLI(Entity IHGPCLDNNFC, [Out] DMLFMPENEDC DFEBEONMKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x489C8F0", Offset = "0x489B2F0", VA = "0x18489C8F0")]
	private bool EKMDKACKMCJ(Entity IHGPCLDNNFC, [Out] DMLFMPENEDC DFEBEONMKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x489B6C0", Offset = "0x489A0C0", VA = "0x18489B6C0")]
	private void AEMLDOINMGD(Entity IHGPCLDNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x489BD20", Offset = "0x489A720", VA = "0x18489BD20")]
	private void BABLIDLEIHA(Entity IHGPCLDNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x489B4E0", Offset = "0x4899EE0", VA = "0x18489B4E0")]
	private void ABJBBPJEKIG(Entity IHGPCLDNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x489C650", Offset = "0x489B050", VA = "0x18489C650")]
	private void DJMHLGDDDCG(Entity IHGPCLDNNFC, DMLFMPENEDC DFEBEONMKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x489D890", Offset = "0x489C290", VA = "0x18489D890")]
	private bool KGHGAMOOKAL(DMLFMPENEDC DFEBEONMKNH, [Out] HashSet<object> DOCAMLOKNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x489C080", Offset = "0x489AA80", VA = "0x18489C080")]
	private HashSet<object> BJJOHIFFOLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BOJMMHLENJL
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JOKMHAMEOIM : DJEEEGLINEL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ED10", Offset = "0x6F1D710", VA = "0x186F1ED10")]
	public float BMBLCHMBODA([In] float3 PKCLPFEIPFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ED10", Offset = "0x6F1D710", VA = "0x186F1ED10", Slot = "4")]
	private float AONPJKGONLJ([In] float3 PKCLPFEIPFH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NOOLLIOHIBF : DJEEEGLINEL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFB0", Offset = "0x6F1D9B0", VA = "0x186F1EFB0")]
	public float BMBLCHMBODA([In] float3 PKCLPFEIPFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFB0", Offset = "0x6F1D9B0", VA = "0x186F1EFB0", Slot = "4")]
	private float AONPJKGONLJ([In] float3 PKCLPFEIPFH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KCEHCNFBEDD : DJEEEGLINEL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xA19BF0", Offset = "0xA185F0", VA = "0x180A19BF0")]
	public float BMBLCHMBODA([In] float3 PKCLPFEIPFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xA19BF0", Offset = "0xA185F0", VA = "0x180A19BF0", Slot = "4")]
	private float AONPJKGONLJ([In] float3 PKCLPFEIPFH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AKDFMIMGLIK : DJEEEGLINEL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A48C80", Offset = "0x1A47680", VA = "0x181A48C80")]
	public int BMBLCHMBODA([In] int3 PKCLPFEIPFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1A48C80", Offset = "0x1A47680", VA = "0x181A48C80", Slot = "4")]
	private int HDDJLIMDJEF([In] int3 PKCLPFEIPFH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BHHIKHMPJGH : DJEEEGLINEL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B500", Offset = "0x6B59F00", VA = "0x186B5B500")]
	public int BMBLCHMBODA([In] int3 PKCLPFEIPFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B5B500", Offset = "0x6B59F00", VA = "0x186B5B500", Slot = "4")]
	private int HDDJLIMDJEF([In] int3 PKCLPFEIPFH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MFNKDCMAAAJ : DJEEEGLINEL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x9FDDB0", Offset = "0x9FC7B0", VA = "0x1809FDDB0")]
	public int BMBLCHMBODA([In] int3 PKCLPFEIPFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9FDDB0", Offset = "0x9FC7B0", VA = "0x1809FDDB0", Slot = "4")]
	private int HDDJLIMDJEF([In] int3 PKCLPFEIPFH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ONKFLJPJFPE : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1983700", Offset = "0x1982100", VA = "0x181983700")]
	public ONKFLJPJFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class AMFIOFPENLE : SystemBase, FFEMLGAFGHB
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E3B0", Offset = "0x6F1CDB0", VA = "0x186F1E3B0")]
	public JobHandle CMFEKCNENPB(ReadOnlySpan<int> PNAIBHDNJBP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35C7420", Offset = "0x35C5E20", VA = "0x1835C7420")]
	public void ILEHPILBJFJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35C7180", Offset = "0x35C5B80", VA = "0x1835C7180")]
	public JobHandle ILEHPILBJFJ<T>(JobHandle DFEBEONMKNH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E400", Offset = "0x6F1CE00", VA = "0x186F1E400")]
	public JobHandle ILEHPILBJFJ(ReadOnlySpan<int> PNAIBHDNJBP, JobHandle DFEBEONMKNH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35C7BB0", Offset = "0x35C65B0", VA = "0x1835C7BB0")]
	public JobHandle MEKNKNIIOEO<T>(JobHandle DFEBEONMKNH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E2F0", Offset = "0x6F1CCF0", VA = "0x186F1E2F0")]
	public ComponentDataFromEntity CJFBCHJBIFK(int MHLBLKFCOMN, bool FCLLKNHEDBI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E470", Offset = "0x6F1CE70", VA = "0x186F1E470")]
	public EntityExistenceLookupByEntity NGBMIJMPMLF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E490", Offset = "0x6F1CE90", VA = "0x186F1E490", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1983700", Offset = "0x1982100", VA = "0x181983700")]
	protected AMFIOFPENLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IIAEOHPFHBP : AMFIOFPENLE
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EA50", Offset = "0x6F1D450", VA = "0x186F1EA50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1983700", Offset = "0x1982100", VA = "0x181983700")]
	protected IIAEOHPFHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ELOGBPOIINH
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NFOECAGFLMI : EntityCommandBufferSystem, FFEMLGAFGHB
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1983700", Offset = "0x1982100", VA = "0x181983700")]
	protected NFOECAGFLMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DJEEEGLINEL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo BMBLCHMBODA([In] TFrom PKCLPFEIPFH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GKGJBHEIOIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PHKGPIODJOL(T PKCLPFEIPFH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct KMMLGOFAPGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer LFNMLCFJCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes JDHAHIKLNMI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EE30", Offset = "0x6F1D830", VA = "0x186F1EE30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct AGKLEDHJHOO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer LFNMLCFJCFF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E250", Offset = "0x6F1CC50", VA = "0x186F1E250", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct KGBHINMCAEK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer LFNMLCFJCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType AHNNLHPCBCC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EDB0", Offset = "0x6F1D7B0", VA = "0x186F1EDB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct OAJIBNLGJFD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> GGEMPJLCHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer LFNMLCFJCFF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A41650", Offset = "0x4A40050", VA = "0x184A41650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct CELLIADENLN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> KJCKFFGBDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer LFNMLCFJCFF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct LHEIOHIPCDL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T PKCLPFEIPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer LFNMLCFJCFF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x466B350", Offset = "0x4669D50", VA = "0x18466B350", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct HJJDGEAEGIE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DJEEEGLINEL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> BONADGIEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> HBPMOCPJAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap EFFBNJEBEKP;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct GHBAHDDJJMJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity DGPPDMBCGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> BONADGIEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> HBPMOCPJAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int KCABEIEDHFO;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E940", Offset = "0x6F1D340", VA = "0x186F1E940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct AIJDAFFFBNE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DLKAFJGOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> BONADGIEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> ELIEOAMEIMN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct KKOFMJHMLBE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, DJEEEGLINEL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> IIBPHIOJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> HBPMOCPJAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap EFFBNJEBEKP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct NBBIPNFEHAN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MKAAIHMKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> FLJBHAOECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> KANIFLPPKIF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct FBMJFFPNCPH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MKAAIHMKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> FLJBHAOECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> KANIFLPPKIF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F13660", Offset = "0x3F12060", VA = "0x183F13660", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct NPMJHJENFEC<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> BONADGIEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> ELIEOAMEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> CONAELBKADO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x496DF10", Offset = "0x496C910", VA = "0x18496DF10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct OGAOAKGMNNO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : DJEEEGLINEL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> BONADGIEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> ELIEOAMEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> CONAELBKADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap EFFBNJEBEKP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct MBCLNLKFCDA<T, TPredicate> : IJob where T : struct where TPredicate : struct, GKGJBHEIOIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> BONADGIEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> DPKBHHDFIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> ANIOMCBEKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate EFFBNJEBEKP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct LGOJNFLKDAK<T, TPredicate> : IJob where T : struct where TPredicate : struct, GKGJBHEIOIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> BONADGIEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> ELIEOAMEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate EFFBNJEBEKP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct NBAJMKMDBJE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity MKAAIHMKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> FLJBHAOECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> HOAKMDAMNKK;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EF20", Offset = "0x6F1D920", VA = "0x186F1EF20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct KBFLNMKHENC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity MKAAIHMKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> FLJBHAOECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> HOAKMDAMNKK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ED20", Offset = "0x6F1D720", VA = "0x186F1ED20", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MODCDHHILJN
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class GHBNDNGPMBA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2EECFB0", Offset = "0x2EEB9B0", VA = "0x182EECFB0")]
	public static bool KLHINOLLGOD<T>(this NativeArray<Entity> FLJBHAOECFO, EntityManager LOJAAGLKEBK, Allocator MCBEFIMHDPO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class ABNONPIGOEE
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KNCJPIGEDEN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public KNCJPIGEDEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AIPADPBAMBJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public AIPADPBAMBJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> ONJNLKFEKCA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E1C0", Offset = "0x6F1CBC0", VA = "0x186F1E1C0")]
	public ABNONPIGOEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class LKDMENMLNLK
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PFDJFDGCBOI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct PIFJJGOIHKL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct NJBBGPILDHP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal PIFJJGOIHKL<TFrom> NNFBEGDDJKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> GOJOFOOEGJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct CJDENCMGBPL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct GPKHNAHMMCF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal CJDENCMGBPL<TFrom> NNFBEGDDJKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> GOJOFOOEGJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct CGGAHDGHMEP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct AOEALPNHBIO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal CGGAHDGHMEP<TFrom> NNFBEGDDJKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> GOJOFOOEGJK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct HPLFPOEIJOJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct GMKJOLDDIFI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal HPLFPOEIJOJ<TFrom> NNFBEGDDJKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> GOJOFOOEGJK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LGJDCAHCNMG
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BFPJBAGDOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C70980", Offset = "0x2C6F380", VA = "0x182C70980")]
	public static NativeList<T> MIPGLHKKCBP<T>(this NativeArray<T> HCBHOHCHHMC, Allocator MCBEFIMHDPO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MLLNEFBNENN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CLIDEBCDJJM
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2CED420", Offset = "0x2CEBE20", VA = "0x182CED420")]
	[FNIOJHAGPCO]
	public static JobHandle LAOAALCDHNF<T>(this EntityCommandBufferSystem JHOMHBKMLDP, NativeArrayAsync<Entity> GBJFFOOALKI, NativeArrayAsync<T> GGEMPJLCHFC, [Optional] JobHandle GKJIOFGLJGG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2CED6D0", Offset = "0x2CEC0D0", VA = "0x182CED6D0")]
	[FNIOJHAGPCO]
	public static JobHandle LAOAALCDHNF<T>(this EntityCommandBufferSystem JHOMHBKMLDP, NativeArrayAsync<Entity> GBJFFOOALKI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2CED5A0", Offset = "0x2CEBFA0", VA = "0x182CED5A0")]
	[FNIOJHAGPCO]
	public static JobHandle LAOAALCDHNF<T>(this EntityCommandBufferSystem JHOMHBKMLDP, NativeArray<Entity> GBJFFOOALKI, [Optional] JobHandle GKJIOFGLJGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E710", Offset = "0x6F1D110", VA = "0x186F1E710")]
	[FNIOJHAGPCO]
	public static JobHandle LAOAALCDHNF(this EntityCommandBufferSystem JHOMHBKMLDP, NativeArray<Entity> GBJFFOOALKI, ComponentTypes JDHAHIKLNMI, [Optional] JobHandle GKJIOFGLJGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E5C0", Offset = "0x6F1CFC0", VA = "0x186F1E5C0")]
	[FNIOJHAGPCO]
	public static JobHandle LAOAALCDHNF(this EntityCommandBufferSystem JHOMHBKMLDP, EntityCommandBuffer LFNMLCFJCFF, NativeArray<Entity> GBJFFOOALKI, ComponentTypes JDHAHIKLNMI, [Optional] JobHandle GKJIOFGLJGG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NHGFLPDILFB
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x304B0A0", Offset = "0x3049AA0", VA = "0x18304B0A0")]
	[FNIOJHAGPCO]
	public static JobHandle CDAIIBILALF<T>(this EntityCommandBufferSystem JHOMHBKMLDP, EntityCommandBuffer LFNMLCFJCFF, EntityQuery IBGCHBHCBAH, T PKCLPFEIPFH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JAPNAIHLEHM
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EA80", Offset = "0x6F1D480", VA = "0x186F1EA80")]
	[FNIOJHAGPCO]
	public static JobHandle IKHLFMOFKCD(this EntityCommandBufferSystem JHOMHBKMLDP, NativeList<Entity> GBJFFOOALKI, [Optional] JobHandle GKJIOFGLJGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EC10", Offset = "0x6F1D610", VA = "0x186F1EC10")]
	[FNIOJHAGPCO]
	public static JobHandle IKHLFMOFKCD(this EntityCommandBufferSystem JHOMHBKMLDP, NativeArrayAsync<Entity> GBJFFOOALKI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ADMGCBHOPON
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DNOPDGMCNGE
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B230", Offset = "0x2D29C30", VA = "0x182D2B230")]
	[FNIOJHAGPCO]
	public static JobHandle HJBLENMMEAA<T>(this EntityCommandBufferSystem JHOMHBKMLDP, NativeArray<Entity> GBJFFOOALKI, NativeArray<T> GGEMPJLCHFC, JobHandle GKJIOFGLJGG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PKKCKNLJENO
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3092D80", Offset = "0x3091780", VA = "0x183092D80")]
	[FNIOJHAGPCO]
	public static JobHandle ANCNCMLHFJG<T>(this EntityCommandBufferSystem JHOMHBKMLDP, NativeArray<Entity> GBJFFOOALKI, T PKCLPFEIPFH, [Optional] JobHandle GKJIOFGLJGG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3092CA0", Offset = "0x30916A0", VA = "0x183092CA0")]
	[FNIOJHAGPCO]
	public static JobHandle ANCNCMLHFJG<T>(this EntityCommandBufferSystem JHOMHBKMLDP, EntityCommandBuffer LFNMLCFJCFF, NativeArray<Entity> GBJFFOOALKI, T PKCLPFEIPFH, [Optional] JobHandle GKJIOFGLJGG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class IBEAJDEIOMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PBMKBAEJFLC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x30886B0", Offset = "0x30870B0", VA = "0x1830886B0")]
	public static NativeArray<T> CAENBIKKMOB<T>(this NativeArray<Entity> HCBHOHCHHMC, EntityManager LOJAAGLKEBK, Allocator MCBEFIMHDPO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F000", Offset = "0x6F1DA00", VA = "0x186F1F000")]
	public static NativeArray<Entity> NJCFLDEELEO(this NativeArray<Entity> HCBHOHCHHMC, EntityManager LOJAAGLKEBK, ComponentType AHNNLHPCBCC, Allocator MCBEFIMHDPO = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3088A70", Offset = "0x3087470", VA = "0x183088A70")]
	public static NativeArray<T> MBJGGCKOPCB<T>(this NativeArray<Entity> HCBHOHCHHMC, EntityManager LOJAAGLKEBK, Allocator MCBEFIMHDPO = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class LNPCEAOMEMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct BNHPHJJKCLI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct EICFHCPPIDP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public BNHPHJJKCLI<TFrom> GOJOFOOEGJK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> BONADGIEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FANPDGOELCH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct CGDFDDPGFNC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public FANPDGOELCH<TFrom> GOJOFOOEGJK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> BONADGIEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct ABDBJKEDHDA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct FMFECIPHEIE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ABDBJKEDHDA<TFrom> GOJOFOOEGJK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> BONADGIEEIP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MCMBECHFIDP
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class NFMHIOIOKGI
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct IBAJGEOMMLP : DJEEEGLINEL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EA40", Offset = "0x6F1D440", VA = "0x186F1EA40")]
		[BurstCompatible]
		public Entity BMBLCHMBODA([In] Entity PKCLPFEIPFH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EA40", Offset = "0x6F1D440", VA = "0x186F1EA40", Slot = "4")]
		private Entity PIGEELAAEMF([In] Entity PKCLPFEIPFH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class AGNOGJEOIIG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct LFMDLECDOBC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> DPKBHHDFIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> BONADGIEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct EBLJFHNDNEG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> DPKBHHDFIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> BONADGIEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GPFNPHDDILC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> DPKBHHDFIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> BONADGIEEIP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HHCLBBGLCAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class PBAPOEMCKHH
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct EOCBOIBFNOE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> BONADGIEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct ANLJANFEHNN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> BONADGIEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct JGFHCMAOELB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> BONADGIEEIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct LMJKILJJDJD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator MCBEFIMHDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> BONADGIEEIP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IPGPEBHJHNG
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CAIPFGGDGOF
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4A40", Offset = "0x2CE3440", VA = "0x182CE4A40")]
	public static NativeList<Entity> NFEOMPGCNEJ<T>(this NativeArray<Entity> FLJBHAOECFO, EntityManager LOJAAGLKEBK, Allocator MCBEFIMHDPO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class JBNAOMDBCFK
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class MJAGBKOOHKB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct MLHCDAMICIN<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> LOCJOHPCANM;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
		public MLHCDAMICIN(NativeArray<TSrc> LOCJOHPCANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public MEOLCOJNBKA<TSrc, TValue> HBBCAIJBGEC<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(MEOLCOJNBKA<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct MEOLCOJNBKA<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> LOCJOHPCANM;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
		public MEOLCOJNBKA(NativeArray<TSrc> LOCJOHPCANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public LHMPMLHBKDJ<TSrc, TValue, TSelector> DHEKLEHJEJH<TSelector>() where TSelector : struct, DJEEEGLINEL<TSrc, TValue>
		{
			return default(LHMPMLHBKDJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct LHMPMLHBKDJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DJEEEGLINEL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> LOCJOHPCANM;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
		public LHMPMLHBKDJ(NativeArray<TSrc> LOCJOHPCANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x466C4B0", Offset = "0x466AEB0", VA = "0x18466C4B0")]
		public PJOJHJAKGLB<TSrc, TValue, TSelector> PLMOMDAPJCO()
		{
			return default(PJOJHJAKGLB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct HGIPHHPKFIG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, DJEEEGLINEL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> LOCJOHPCANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector DBCONAOBEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int GCBONJOGHCD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x417B450", Offset = "0x4179E50", VA = "0x18417B450")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int BPKEJBPHLFM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA10880", Offset = "0xA0F280", VA = "0x180A10880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EKAJMJBAGEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x228D680", Offset = "0x228C080", VA = "0x18228D680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x417B530", Offset = "0x4179F30", VA = "0x18417B530")]
		public HGIPHHPKFIG(NativeArray<TSrc> LOCJOHPCANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x417B490", Offset = "0x4179E90", VA = "0x18417B490")]
		public bool JLIPANEBJLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x417B350", Offset = "0x4179D50", VA = "0x18417B350")]
		private TSrc AAKMCPMBEBP(int FNLONGIJDLD)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x417B4A0", Offset = "0x4179EA0", VA = "0x18417B4A0")]
		private TValue LFGGJGEIICH()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct PJOJHJAKGLB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, DJEEEGLINEL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private HGIPHHPKFIG<TSrc, TValue, TSelector> JLNFMCJGDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue KGLMAGDHEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int FMCLGEDFPEP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AJGMEHOLLCO GEJEABOGPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x4B75270", Offset = "0x4B73C70", VA = "0x184B75270")]
			get
			{
				return default(AJGMEHOLLCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue JCBLMDFFIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, AJGMEHOLLCO range) MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4B75010", Offset = "0x4B73A10", VA = "0x184B75010")]
			get
			{
				return default((TValue, AJGMEHOLLCO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4B752B0", Offset = "0x4B73CB0", VA = "0x184B752B0")]
		public PJOJHJAKGLB(NativeArray<TSrc> LOCJOHPCANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3B65650", Offset = "0x3B64050", VA = "0x183B65650")]
		public PJOJHJAKGLB<TSrc, TValue, TSelector> CBLJDKEPCGL()
		{
			return default(PJOJHJAKGLB<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4B750F0", Offset = "0x4B73AF0", VA = "0x184B750F0")]
		public bool JLIPANEBJLB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2FE08B0", Offset = "0x2FDF2B0", VA = "0x182FE08B0")]
	public static MLHCDAMICIN<T> IOJDKHEJABF<T>(this NativeList<T> HIOONLIPGID) where T : struct
	{
		return default(MLHCDAMICIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
	public static MLHCDAMICIN<T> IOJDKHEJABF<T>(this NativeArray<T> LOCJOHPCANM) where T : struct
	{
		return default(MLHCDAMICIN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class GKEPHKAJFDL
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct AIJMFFAEAIJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly LOCJOHPCANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int FMCLGEDFPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int BIEAOKELFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T KGLMAGDHEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T NDOBCDEDEEA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AJGMEHOLLCO GEJEABOGPJD
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4145200", Offset = "0x4143C00", VA = "0x184145200")]
			get
			{
				return default(AJGMEHOLLCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T JCBLMDFFIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3BFE970", Offset = "0x3BFD370", VA = "0x183BFE970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, AJGMEHOLLCO) MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4144CB0", Offset = "0x41436B0", VA = "0x184144CB0")]
			get
			{
				return default((T, AJGMEHOLLCO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4145280", Offset = "0x4143C80", VA = "0x184145280")]
		public AIJMFFAEAIJ(NativeArray<T> LOCJOHPCANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4144C70", Offset = "0x4143670", VA = "0x184144C70")]
		public AIJMFFAEAIJ<T> CBLJDKEPCGL()
		{
			return default(AIJMFFAEAIJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4144E30", Offset = "0x4143830", VA = "0x184144E30")]
		public bool JLIPANEBJLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28AE5E0", Offset = "0x28ACFE0", VA = "0x1828AE5E0")]
		public HBGJMEENGBD<T, TComparer> AHHEEKGNHAK<TComparer>([Optional] TComparer ONCPECMFEOE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(HBGJMEENGBD<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HBGJMEENGBD<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly LOCJOHPCANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int FMCLGEDFPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int BIEAOKELFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T KGLMAGDHEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T NDOBCDEDEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer ONCPECMFEOE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AJGMEHOLLCO GEJEABOGPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4145200", Offset = "0x4143C00", VA = "0x184145200")]
			get
			{
				return default(AJGMEHOLLCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T JCBLMDFFIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3BFE970", Offset = "0x3BFD370", VA = "0x183BFE970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x41721C0", Offset = "0x4170BC0", VA = "0x1841721C0")]
		public HBGJMEENGBD(NativeArray<T>.ReadOnly LOCJOHPCANM, TComparer ONCPECMFEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4171FD0", Offset = "0x41709D0", VA = "0x184171FD0")]
		public bool JLIPANEBJLB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1040", Offset = "0x2EEFA40", VA = "0x182EF1040")]
	public static AIJMFFAEAIJ<T> PLMOMDAPJCO<T>(this NativeArray<T> LOCJOHPCANM) where T : struct
	{
		return default(AIJMFFAEAIJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface OIDIJAKJJPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class EKIIJHHFNND
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct BFIEFBDANNK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class LGONCGICAJI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public BFIEFBDANNK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x97E910", Offset = "0x97D310", VA = "0x18097E910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x40625E0", Offset = "0x4060FE0", VA = "0x1840625E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public LGONCGICAJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x466A130", Offset = "0x4668B30", VA = "0x18466A130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x466A310", Offset = "0x4668D10", VA = "0x18466A310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> EMFJFPKEAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream CHHHDKLHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream NKAHGHCFEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf FHMBDNEADLF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int EKAJMJBAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x52796B0", Offset = "0x52780B0", VA = "0x1852796B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x52796F0", Offset = "0x52780F0", VA = "0x1852796F0", Slot = "4")]
	[IteratorStateMachine(typeof(BFIEFBDANNK<>.LGONCGICAJI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x52797F0", Offset = "0x52781F0", VA = "0x1852797F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct DNECGHJOOJP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] GNKEDFJBDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf FHMBDNEADLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream CHHHDKLHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream BHKNKIHMBPM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B930", Offset = "0x5C8A330", VA = "0x185C8B930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct OPFENIKJOFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream CHHHDKLHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream NKAHGHCFEJN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFC0", Offset = "0x6F1D9C0", VA = "0x186F1EFC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct CIENCJOOFJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] GNKEDFJBDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream CHHHDKLHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream BHKNKIHMBPM;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E4A0", Offset = "0x6F1CEA0", VA = "0x186F1E4A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class APKNHBNPHKK
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class BDKAKIHBJMI
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum LJCADOACGOB
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
internal static class GAFNDFJLCJF
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JJODAPEKCBG
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JJODAPEKCBG()
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
