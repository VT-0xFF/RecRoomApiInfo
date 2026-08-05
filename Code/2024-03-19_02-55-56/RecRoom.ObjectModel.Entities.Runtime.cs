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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x624F380", Offset = "0x624E380", VA = "0x18624F380")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PPGFAPKHABB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JHPAFKNCJMC EIKPALDJOHJ
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
public interface CJHLEEDAKJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLKNCOAFMOG(Entity FHDCFAANCBM, object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POHNOAIFIFF(Entity FHDCFAANCBM, object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NJOJLDFNBLI(Entity FHDCFAANCBM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LGEOJMLMEMN(Entity FHDCFAANCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CEONNIDHEOD<TComponentData, TValue> : CKAJLFNGPML<TValue>, IDisposable where TComponentData : struct, PPGFAPKHABB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class MJLCKDKEHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> JOAHCODCDPO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int BIBAPHNHGKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3111D10", Offset = "0x3110D10", VA = "0x183111D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3ED18F0", Offset = "0x3ED08F0", VA = "0x183ED18F0")]
		public bool IMONJCNJMHC([Out] TValue CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1840", Offset = "0x3ED0840", VA = "0x183ED1840")]
		public void EMJMPPLJJNE(object OGACLNNOKDA, TValue CFJDHAGGAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3ED19E0", Offset = "0x3ED09E0", VA = "0x183ED19E0")]
		public bool JOBFLKKFIPF(object OGACLNNOKDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1760", Offset = "0x3ED0760", VA = "0x183ED1760")]
		public int ALCDHDBOCOD(object OGACLNNOKDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1A60", Offset = "0x3ED0A60", VA = "0x183ED1A60")]
		public MJLCKDKEHEG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<MJLCKDKEHEG> LFLMJCDDMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NLDFGMAFEKN<JHPAFKNCJMC, MJLCKDKEHEG> OEAKPMCKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager PFHEMIPIMIH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E970", Offset = "0x4C8D970", VA = "0x184C8E970")]
	public CEONNIDHEOD(EntityManager PFHEMIPIMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E4E0", Offset = "0x4C8D4E0", VA = "0x184C8E4E0", Slot = "4")]
	public void JLKNCOAFMOG(Entity FHDCFAANCBM, object OGACLNNOKDA, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E7D0", Offset = "0x4C8D7D0", VA = "0x184C8E7D0", Slot = "5")]
	public bool POHNOAIFIFF(Entity FHDCFAANCBM, object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E2F0", Offset = "0x4C8D2F0", VA = "0x184C8E2F0", Slot = "6")]
	public bool IMONJCNJMHC(Entity FHDCFAANCBM, [Out] TValue CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E220", Offset = "0x4C8D220", VA = "0x184C8E220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E240", Offset = "0x4C8D240", VA = "0x184C8E240")]
	private void HHNJFFPIBJB(MJLCKDKEHEG OAIOLOBOKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E620", Offset = "0x4C8D620", VA = "0x184C8E620")]
	private bool LDHABDNPGBL(Entity FHDCFAANCBM, [Out] JHPAFKNCJMC CBPMLJGALEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E3F0", Offset = "0x4C8D3F0", VA = "0x184C8E3F0")]
	private void JFOLBIFCDEK(Entity FHDCFAANCBM, JHPAFKNCJMC CBPMLJGALEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E2D0", Offset = "0x4C8D2D0", VA = "0x184C8E2D0")]
	private bool HIBGHBFIEPF(JHPAFKNCJMC CBPMLJGALEL, [Out] MJLCKDKEHEG OAIOLOBOKPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E6E0", Offset = "0x4C8D6E0", VA = "0x184C8E6E0")]
	private MJLCKDKEHEG NOLBLGHMALF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CKAJLFNGPML<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLKNCOAFMOG(Entity FHDCFAANCBM, object OGACLNNOKDA, TValue CFJDHAGGAJO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POHNOAIFIFF(Entity FHDCFAANCBM, object OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IMONJCNJMHC(Entity FHDCFAANCBM, [Out] TValue CFJDHAGGAJO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JHPAFKNCJMC : PGCDLPDMIKN, IEquatable<JHPAFKNCJMC>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly JHPAFKNCJMC OFFGGPMLGLG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int EDPEAEGJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90C4B0", VA = "0x18090D4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int IINHLNHHHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2276720", Offset = "0x2275720", VA = "0x182276720", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x55D8B50", Offset = "0x55D7B50", VA = "0x1855D8B50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x624F610", Offset = "0x624E610", VA = "0x18624F610", Slot = "8")]
	public bool Equals(JHPAFKNCJMC PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x624F660", Offset = "0x624E660", VA = "0x18624F660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EDBEGJNBGOB<THasTokensTag> : CJHLEEDAKJN, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, JHPAFKNCJMC> PIFNPHHNFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> LFLMJCDDMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private NLDFGMAFEKN<JHPAFKNCJMC, HashSet<object>> OEAKPMCKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager PFHEMIPIMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem HGACMKMCNDA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3310B70", Offset = "0x330FB70", VA = "0x183310B70")]
	public EDBEGJNBGOB(EntityManager PFHEMIPIMIH, EntityCommandBufferSystem HGACMKMCNDA, LPCGADPJIJD NKIMLFBDONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x330E700", Offset = "0x330D700", VA = "0x18330E700", Slot = "4")]
	public bool JLKNCOAFMOG(Entity FHDCFAANCBM, object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x330FE40", Offset = "0x330EE40", VA = "0x18330FE40", Slot = "5")]
	public bool POHNOAIFIFF(Entity FHDCFAANCBM, object OGACLNNOKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x330F7D0", Offset = "0x330E7D0", VA = "0x18330F7D0", Slot = "6")]
	public bool NJOJLDFNBLI(Entity FHDCFAANCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x330F860", Offset = "0x330E860", VA = "0x18330F860", Slot = "9")]
	public bool NJOJLDFNBLI(JHPAFKNCJMC CBPMLJGALEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x330EC80", Offset = "0x330DC80", VA = "0x18330EC80", Slot = "7")]
	public bool LGEOJMLMEMN(Entity FHDCFAANCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x330D920", Offset = "0x330C920", VA = "0x18330D920", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x330DA60", Offset = "0x330CA60", VA = "0x18330DA60")]
	private void HHNJFFPIBJB(HashSet<object> OAIOLOBOKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x330EBB0", Offset = "0x330DBB0", VA = "0x18330EBB0")]
	private bool LDHABDNPGBL(Entity FHDCFAANCBM, [Out] JHPAFKNCJMC CBPMLJGALEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x330F300", Offset = "0x330E300", VA = "0x18330F300")]
	private bool LMJOBDDHCFH(Entity FHDCFAANCBM, [Out] JHPAFKNCJMC CBPMLJGALEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x330D3D0", Offset = "0x330C3D0", VA = "0x18330D3D0")]
	private void DKLJNKIIOPI(Entity FHDCFAANCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x330D2C0", Offset = "0x330C2C0", VA = "0x18330D2C0")]
	private void AHKIJPFGHCG(Entity FHDCFAANCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x330E0C0", Offset = "0x330D0C0", VA = "0x18330E0C0")]
	private void JGLPCJKIKIO(Entity FHDCFAANCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x330DDE0", Offset = "0x330CDE0", VA = "0x18330DDE0")]
	private void JFOLBIFCDEK(Entity FHDCFAANCBM, JHPAFKNCJMC CBPMLJGALEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x330F660", Offset = "0x330E660", VA = "0x18330F660")]
	private bool NBMFAAFBCEH(JHPAFKNCJMC CBPMLJGALEL, [Out] HashSet<object> OAIOLOBOKPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x330FBC0", Offset = "0x330EBC0", VA = "0x18330FBC0")]
	private HashSet<object> NOLBLGHMALF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EGFOKEJBKJD
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DHFKKCOJFDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int CNHEAECNOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int FBDNKGNOEFD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GGCHNCJELKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2276720", Offset = "0x2275720", VA = "0x182276720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x55D8B50", Offset = "0x55D7B50", VA = "0x1855D8B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MJBPCJHBCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x90D4B0", Offset = "0x90C4B0", VA = "0x18090D4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NIKCELCOIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x624EEA0", Offset = "0x624DEA0", VA = "0x18624EEA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x624EEB0", Offset = "0x624DEB0", VA = "0x18624EEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAF6870", Offset = "0xAF5870", VA = "0x180AF6870")]
	private DHFKKCOJFDE(int CNHEAECNOFO, int FBDNKGNOEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6EE0", Offset = "0x1DE5EE0", VA = "0x181DE6EE0")]
	public static DHFKKCOJFDE LHIAACLIGCE(int CNHEAECNOFO, int FBDNKGNOEFD)
	{
		return default(DHFKKCOJFDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x624EE90", Offset = "0x624DE90", VA = "0x18624EE90")]
	public static DHFKKCOJFDE CDHNLNMBHOK(int CGJCOMADABC, int KOKNIBHCDLN)
	{
		return default(DHFKKCOJFDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x624EEC0", Offset = "0x624DEC0", VA = "0x18624EEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KBHDHHGLMPB : NGLIBMBFKIP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x624F6B0", Offset = "0x624E6B0", VA = "0x18624F6B0")]
	public float IJNLMBCMNPP([In] float3 CFJDHAGGAJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x624F6B0", Offset = "0x624E6B0", VA = "0x18624F6B0", Slot = "4")]
	private float JKHNOGENJAI([In] float3 CFJDHAGGAJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MHONBCKNHKK : NGLIBMBFKIP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x624F930", Offset = "0x624E930", VA = "0x18624F930")]
	public float IJNLMBCMNPP([In] float3 CFJDHAGGAJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x624F930", Offset = "0x624E930", VA = "0x18624F930", Slot = "4")]
	private float JKHNOGENJAI([In] float3 CFJDHAGGAJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JKBGFMGLOJA : NGLIBMBFKIP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1AB5DA0", Offset = "0x1AB4DA0", VA = "0x181AB5DA0")]
	public float IJNLMBCMNPP([In] float3 CFJDHAGGAJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1AB5DA0", Offset = "0x1AB4DA0", VA = "0x181AB5DA0", Slot = "4")]
	private float JKHNOGENJAI([In] float3 CFJDHAGGAJO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KNHNHMDODLC : NGLIBMBFKIP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x13CBC20", Offset = "0x13CAC20", VA = "0x1813CBC20")]
	public int IJNLMBCMNPP([In] int3 CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x13CBC20", Offset = "0x13CAC20", VA = "0x1813CBC20", Slot = "4")]
	private int BEMCAIDMCGB([In] int3 CFJDHAGGAJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PBKCBBFKCHP : NGLIBMBFKIP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x624FD00", Offset = "0x624ED00", VA = "0x18624FD00")]
	public int IJNLMBCMNPP([In] int3 CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x624FD00", Offset = "0x624ED00", VA = "0x18624FD00", Slot = "4")]
	private int BEMCAIDMCGB([In] int3 CFJDHAGGAJO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LGKMDOKLDIE : NGLIBMBFKIP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16A8D20", Offset = "0x16A7D20", VA = "0x1816A8D20")]
	public int IJNLMBCMNPP([In] int3 CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16A8D20", Offset = "0x16A7D20", VA = "0x1816A8D20", Slot = "4")]
	private int BEMCAIDMCGB([In] int3 CFJDHAGGAJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NPALNNGNFIC : MCJPEDFJCPC
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	public NPALNNGNFIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class FEHEAIFLDJF : SystemBase, IGCICCIALAJ
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x624F450", Offset = "0x624E450", VA = "0x18624F450")]
	public ComponentDataFromEntity OMKMBAPOBMH(int DGHDBPEDAIK, bool EOEDDNIFBIB = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x624F430", Offset = "0x624E430", VA = "0x18624F430")]
	public EntityExistenceLookupByEntity MGHOFJNIIEM()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x624F510", Offset = "0x624E510", VA = "0x18624F510", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	protected FEHEAIFLDJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class OBPDPMPMBKE : FEHEAIFLDJF
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x624FCD0", Offset = "0x624ECD0", VA = "0x18624FCD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	protected OBPDPMPMBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AOFFAIMLDJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class CPDBDEHIPDO : EntityCommandBufferSystem, IGCICCIALAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	protected CPDBDEHIPDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NGLIBMBFKIP<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IJNLMBCMNPP([In] TFrom CFJDHAGGAJO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IOMAODAMIAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIACAOCEFPD(T CFJDHAGGAJO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct FMKHKAALKIM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	public NativeArray<Entity> IBJCDFFELHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EntityCommandBuffer JJAKBDGALDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ComponentTypes ECCDBPLMGPL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x624F520", Offset = "0x624E520", VA = "0x18624F520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct EOBEKDGBAGC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> IBJCDFFELHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer JJAKBDGALDM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x624F050", Offset = "0x624E050", VA = "0x18624F050", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct CKMFMDMEEFC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> IBJCDFFELHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer JJAKBDGALDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public ComponentType CIODOKKDLHG;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x624EE10", Offset = "0x624DE10", VA = "0x18624EE10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct ILHACPPAKLI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<Entity> IBJCDFFELHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<T> ELANMAGHLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer JJAKBDGALDM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x395CCD0", Offset = "0x395BCD0", VA = "0x18395CCD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct AJOCIHNJLMD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<Entity> IBJCDFFELHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<T> MHPPDDHIHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer JJAKBDGALDM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct EBBGNOEJPMF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> IBJCDFFELHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public T CFJDHAGGAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EntityCommandBuffer JJAKBDGALDM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3309F60", Offset = "0x3308F60", VA = "0x183309F60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct CFOEGCPILFG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NGLIBMBFKIP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<TFrom> MIOLANJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[WriteOnly]
	public NativeArray<TTo> LENLIKIFAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public TMap DFHNKDINOMO;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct EHELHPGEAKL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public ComponentDataFromEntity BKEGDNGCNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<Entity> MIOLANJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeArray<byte> LENLIKIFAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int KCFLHDLIENO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x624EF50", Offset = "0x624DF50", VA = "0x18624EF50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct LJMMPJBDAIN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MCFEAJHFIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<Entity> MIOLANJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<T> CCBEHDKNCEH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct LOBIKGAIKFB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NGLIBMBFKIP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<TFrom> LCGHLOLCLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<TTo> LENLIKIFAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public TMap DFHNKDINOMO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LJBIFIHKJOK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MNEJNADBMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public NativeArray<Entity> NANCHKMEHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<bool> OEBNLHNPBAB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct ECIDBFPJGPE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MNEJNADBMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> NANCHKMEHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeArray<bool> OEBNLHNPBAB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x330B5B0", Offset = "0x330A5B0", VA = "0x18330B5B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct GDOGBANLNOA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<T> MIOLANJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeList<T> CCBEHDKNCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeParallelHashSet<T> OKOJGJGJAKI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3741470", Offset = "0x3740470", VA = "0x183741470", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct KEOEENDGMBI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NGLIBMBFKIP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public NativeArray<TFrom> MIOLANJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeList<TFrom> CCBEHDKNCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeParallelHashSet<TTo> OKOJGJGJAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public TMap DFHNKDINOMO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct KLDGADEOMPN<T, TPredicate> : IJob where T : struct where TPredicate : struct, IOMAODAMIAL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<T> MIOLANJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	public NativeArray<Entity> HKFGINPPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NativeList<Entity> IOFIDPPODBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TPredicate DFHNKDINOMO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3C3C160", Offset = "0x3C3B160", VA = "0x183C3C160", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GIDLBAHFEHM<T, TPredicate> : IJob where T : struct where TPredicate : struct, IOMAODAMIAL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	public NativeArray<T> MIOLANJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public NativeList<T> CCBEHDKNCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public TPredicate DFHNKDINOMO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct NKJJEBMHAPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public ComponentDataFromEntity MNEJNADBMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public NativeArray<Entity> NANCHKMEHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NativeList<Entity> DDDKFOGFEOI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x624F980", Offset = "0x624E980", VA = "0x18624F980", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct FEBMPACEJIG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public ComponentDataFromEntity MNEJNADBMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ReadOnly]
	public NativeArray<Entity> NANCHKMEHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<Entity> DDDKFOGFEOI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x624F3A0", Offset = "0x624E3A0", VA = "0x18624F3A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ILCENNJBNBL
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KEBPCCCFIJG
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2823380", Offset = "0x2822380", VA = "0x182823380")]
	public static bool NNGBLEIIBLG<T>(this NativeArray<Entity> NANCHKMEHEP, EntityManager PFHEMIPIMIH, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LAMEHMCEOJB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BPLADMBNAKD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		public BPLADMBNAKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DAOGHFCCIFO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		public DAOGHFCCIFO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<Func<JobHandle, JobHandle>> LIBFNGOACML;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x624F8A0", Offset = "0x624E8A0", VA = "0x18624F8A0")]
	public LAMEHMCEOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LPHIENJMNAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OCGHKIHMMON
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct IFJEIBCLPAO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct DCAEHNJBMIE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			internal IFJEIBCLPAO<TFrom> MMPNPJILHCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal NativeArray<TFrom> KDCCNGJCKFD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct ALLNJCLFEML<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct DPNBOPKDJJJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			internal ALLNJCLFEML<TFrom> MMPNPJILHCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal NativeList<TFrom> KDCCNGJCKFD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct HJIJALNBMLG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct FKLFKNDOGCD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			internal HJIJALNBMLG<TFrom> MMPNPJILHCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NativeArrayAsync<TFrom> KDCCNGJCKFD;
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct CCNMLFCGJBJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct GCFJOJOECEP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal CCNMLFCGJBJ<TFrom> MMPNPJILHCD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeListAsync<TFrom> KDCCNGJCKFD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MBBPDHPJOEG
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GNOPNFDNLLM
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x279BAC0", Offset = "0x279AAC0", VA = "0x18279BAC0")]
	public static NativeList<T> PDAHHBJFEMG<T>(this NativeList<T> BDMIPBFNHJB, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x279B940", Offset = "0x279A940", VA = "0x18279B940")]
	public static NativeList<T> PDAHHBJFEMG<T>(this NativeArray<T> BDMIPBFNHJB, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KJMPEALLKOB
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NKKPMOKJMIO
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x28F6B10", Offset = "0x28F5B10", VA = "0x1828F6B10")]
	[EGHAIHMJKCB]
	public static JobHandle EAKHMBICMAO<T>(this EntityCommandBufferSystem HGACMKMCNDA, NativeArrayAsync<Entity> IBJCDFFELHE, NativeArrayAsync<T> ELANMAGHLLI, [Optional] JobHandle AHMDOJHJLCM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28F6C70", Offset = "0x28F5C70", VA = "0x1828F6C70")]
	[EGHAIHMJKCB]
	public static JobHandle EAKHMBICMAO<T>(this EntityCommandBufferSystem HGACMKMCNDA, NativeArrayAsync<Entity> IBJCDFFELHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28F69F0", Offset = "0x28F59F0", VA = "0x1828F69F0")]
	[EGHAIHMJKCB]
	public static JobHandle EAKHMBICMAO<T>(this EntityCommandBufferSystem HGACMKMCNDA, NativeArray<Entity> IBJCDFFELHE, [Optional] JobHandle AHMDOJHJLCM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x624FA10", Offset = "0x624EA10", VA = "0x18624FA10")]
	[EGHAIHMJKCB]
	public static JobHandle EAKHMBICMAO(this EntityCommandBufferSystem HGACMKMCNDA, NativeArray<Entity> IBJCDFFELHE, ComponentTypes ECCDBPLMGPL, [Optional] JobHandle AHMDOJHJLCM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x624FB80", Offset = "0x624EB80", VA = "0x18624FB80")]
	[EGHAIHMJKCB]
	public static JobHandle EAKHMBICMAO(this EntityCommandBufferSystem HGACMKMCNDA, EntityCommandBuffer JJAKBDGALDM, NativeArray<Entity> IBJCDFFELHE, ComponentTypes ECCDBPLMGPL, [Optional] JobHandle AHMDOJHJLCM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class ICBBEBCHDPD
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27D8620", Offset = "0x27D7620", VA = "0x1827D8620")]
	[EGHAIHMJKCB]
	public static JobHandle GEDJKGPFPAL<T>(this EntityCommandBufferSystem HGACMKMCNDA, EntityCommandBuffer JJAKBDGALDM, EntityQuery DEMOAPCNAOD, T CFJDHAGGAJO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EPGOLJFCGPN
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x624F1F0", Offset = "0x624E1F0", VA = "0x18624F1F0")]
	[EGHAIHMJKCB]
	public static JobHandle CJLPFBHNDDO(this EntityCommandBufferSystem HGACMKMCNDA, NativeList<Entity> IBJCDFFELHE, [Optional] JobHandle AHMDOJHJLCM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x624F0F0", Offset = "0x624E0F0", VA = "0x18624F0F0")]
	[EGHAIHMJKCB]
	public static JobHandle CJLPFBHNDDO(this EntityCommandBufferSystem HGACMKMCNDA, NativeArrayAsync<Entity> IBJCDFFELHE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ALKIBJCDEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2D87090", Offset = "0x2D86090", VA = "0x182D87090")]
	public static void DKNHOOPJPHB<T>(this EntityCommandBufferSystem HGACMKMCNDA, EntityQuery DEMOAPCNAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D87460", Offset = "0x2D86460", VA = "0x182D87460")]
	[EGHAIHMJKCB]
	public static JobHandle MCOGFHOHOGD<T>(this EntityCommandBufferSystem HGACMKMCNDA, NativeListAsync<Entity> IBJCDFFELHE, [Optional] JobHandle AHMDOJHJLCM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2D87520", Offset = "0x2D86520", VA = "0x182D87520")]
	[EGHAIHMJKCB]
	public static JobHandle MCOGFHOHOGD<T>(this EntityCommandBufferSystem HGACMKMCNDA, NativeArrayAsync<Entity> IBJCDFFELHE, [Optional] JobHandle AHMDOJHJLCM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BLGCDKMPMNM
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x25852D0", Offset = "0x25842D0", VA = "0x1825852D0")]
	[EGHAIHMJKCB]
	public static JobHandle KPMPIFKHAEP<T>(this EntityCommandBufferSystem HGACMKMCNDA, NativeArray<Entity> IBJCDFFELHE, NativeArray<T> ELANMAGHLLI, JobHandle AHMDOJHJLCM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LDJCKLJAFBC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2839060", Offset = "0x2838060", VA = "0x182839060")]
	[EGHAIHMJKCB]
	public static JobHandle FPKIPJMGHHB<T>(this EntityCommandBufferSystem HGACMKMCNDA, NativeArray<Entity> IBJCDFFELHE, T CFJDHAGGAJO, [Optional] JobHandle AHMDOJHJLCM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2839140", Offset = "0x2838140", VA = "0x182839140")]
	[EGHAIHMJKCB]
	public static JobHandle FPKIPJMGHHB<T>(this EntityCommandBufferSystem HGACMKMCNDA, EntityCommandBuffer JJAKBDGALDM, NativeArray<Entity> IBJCDFFELHE, T CFJDHAGGAJO, [Optional] JobHandle AHMDOJHJLCM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class IFHMBJLMLNN
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27DA9B0", Offset = "0x27D99B0", VA = "0x1827DA9B0")]
	public static NativeList<T> PDAHHBJFEMG<T>(NativeList<T> BDMIPBFNHJB, Allocator NHBLMPKODCH) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KMKBICACIEC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2830CD0", Offset = "0x282FCD0", VA = "0x182830CD0")]
	public static NativeArray<T> PHMABOOIOBM<T>(this NativeList<Entity> BDMIPBFNHJB, EntityManager PFHEMIPIMIH, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2830950", Offset = "0x282F950", VA = "0x182830950")]
	public static NativeArray<T> PHMABOOIOBM<T>(this NativeArray<Entity> BDMIPBFNHJB, EntityManager PFHEMIPIMIH, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x624F6C0", Offset = "0x624E6C0", VA = "0x18624F6C0")]
	public static NativeArray<Entity> PCIBIIEHMGL(this NativeArray<Entity> BDMIPBFNHJB, EntityManager PFHEMIPIMIH, ComponentType CIODOKKDLHG, Allocator NHBLMPKODCH = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2830870", Offset = "0x282F870", VA = "0x182830870")]
	public static NativeArray<T> FPHBANNGPKB<T>(this NativeArray<Entity> BDMIPBFNHJB, EntityManager PFHEMIPIMIH, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JCHGOHNIHAK
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct FPMDLJMGAGK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct GPBNKBANNKH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public FPMDLJMGAGK<TFrom> KDCCNGJCKFD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeArray<TFrom> MIOLANJMJDA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct MHIEHAHCALF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct FJGKEIIDIEJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public MHIEHAHCALF<TFrom> KDCCNGJCKFD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NativeArrayAsync<TFrom> MIOLANJMJDA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public struct EHFNFEHDMIF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public struct NCBIFPKHPLL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public EHFNFEHDMIF<TFrom> KDCCNGJCKFD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NativeListAsync<TFrom> MIOLANJMJDA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FLPBBNADFMH
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KGGGBIFOKFO
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct BLGABHJPCHJ : NGLIBMBFKIP<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EGPIIPFKKDC;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x624EE00", Offset = "0x624DE00", VA = "0x18624EE00")]
		[BurstCompatible]
		public Entity IJNLMBCMNPP([In] Entity CFJDHAGGAJO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x624EE00", Offset = "0x624DE00", VA = "0x18624EE00", Slot = "4")]
		private Entity JIDMMDJIINB([In] Entity CFJDHAGGAJO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HJJFOPDKECC
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DGEKLDCEHGA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<Entity> HKFGINPPIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeArray<T> MIOLANJMJDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct OOFLDFONBMK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<Entity> HKFGINPPIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArray<T> MIOLANJMJDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public struct DCBCCDDGAHN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<Entity> HKFGINPPIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArrayAsync<T> MIOLANJMJDA;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x22D07C0", Offset = "0x22CF7C0", VA = "0x1822D07C0")]
		public NativeListAsync<Entity> CIACAOCEFPD<TPredicate>() where TPredicate : struct, IOMAODAMIAL<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27B7B70", Offset = "0x27B6B70", VA = "0x1827B7B70")]
	public static DCBCCDDGAHN<T> DMIOPJPDKEJ<T>(this NativeArrayAsync<Entity> NANCHKMEHEP, NativeArrayAsync<T> BDMIPBFNHJB, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct
	{
		return default(DCBCCDDGAHN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class KGOLFGHMGOC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2827280", Offset = "0x2826280", VA = "0x182827280")]
	public static NativeListAsync<Entity> EIJBFFKDNDP<T, TPredicate>(this NativeArrayAsync<T> BDMIPBFNHJB, NativeArrayAsync<Entity> NANCHKMEHEP, Allocator NHBLMPKODCH = Allocator.TempJob) where T : struct where TPredicate : struct, IOMAODAMIAL<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2827340", Offset = "0x2826340", VA = "0x182827340")]
	private static NativeListAsync<Entity> GDCKFCLEPKA<T, TPredicate>(NativeArrayAsync<T> HAGMEKKEDJM, NativeArrayAsync<Entity> NANCHKMEHEP, int NAHHNFGPNAE, Allocator NHBLMPKODCH) where T : struct where TPredicate : struct, IOMAODAMIAL<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JHOOGJFBCCP
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct CGHOMCMJLOO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<T> MIOLANJMJDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct EDHJNBOOOGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<T> MIOLANJMJDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct OBDBENKIMJN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArrayAsync<T> MIOLANJMJDA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EDCHIBKDCBK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator NHBLMPKODCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeListAsync<T> MIOLANJMJDA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class APMNECHPIFM
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class HPNCFEMCJIB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x27D0810", Offset = "0x27CF810", VA = "0x1827D0810")]
	public static NativeList<Entity> GDCBBJKBLHN<T>(this NativeArray<Entity> NANCHKMEHEP, EntityManager PFHEMIPIMIH, Allocator NHBLMPKODCH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EMJCKIGPKJA
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NGNENAMKCMJ
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct MGDAGFPPIFF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> IJPOMPNGBEF;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
		public MGDAGFPPIFF(NativeArray<TSrc> IJPOMPNGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public JFNKPGJLEFC<TSrc, TValue> BOFCKJHMBMO<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(JFNKPGJLEFC<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct JFNKPGJLEFC<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> IJPOMPNGBEF;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
		public JFNKPGJLEFC(NativeArray<TSrc> IJPOMPNGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public CDAMBEGJKPG<TSrc, TValue, TSelector> ABALJKCHPPH<TSelector>() where TSelector : struct, NGLIBMBFKIP<TSrc, TValue>
		{
			return default(CDAMBEGJKPG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public readonly struct CDAMBEGJKPG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NGLIBMBFKIP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> IJPOMPNGBEF;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
		public CDAMBEGJKPG(NativeArray<TSrc> IJPOMPNGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB820", Offset = "0x4BAA820", VA = "0x184BAB820")]
		public NEGJMLMDDKE<TSrc, TValue, TSelector> BHEGBKMLIHL()
		{
			return default(NEGJMLMDDKE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct CEDKIIFIGAB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NGLIBMBFKIP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> IJPOMPNGBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TSelector MNBPIBOKMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int GCDIELAOHNA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FKHNLELEDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4C8D130", Offset = "0x4C8C130", VA = "0x184C8D130")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int EDPEAEGJAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA575A0", Offset = "0xA565A0", VA = "0x180A575A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HOCNAFCFDNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D2B0", Offset = "0x4C8C2B0", VA = "0x184C8D2B0")]
		public CEDKIIFIGAB(NativeArray<TSrc> IJPOMPNGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D1C0", Offset = "0x4C8C1C0", VA = "0x184C8D1C0")]
		public bool DPDKHJIIAND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D1D0", Offset = "0x4C8C1D0", VA = "0x184C8D1D0")]
		private TSrc GDNFINECJNC(int BFOKHFCOJAP)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct NEGJMLMDDKE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NGLIBMBFKIP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CEDKIIFIGAB<TSrc, TValue, TSelector> CMEFBIBGAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TValue PGKMODICEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int BMGBMMPKFAO;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DHFKKCOJFDE GFDHPMIFODH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3F43EE0", Offset = "0x3F42EE0", VA = "0x183F43EE0")]
			get
			{
				return default(DHFKKCOJFDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TValue MDHAJPLJGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public (TValue value, DHFKKCOJFDE range) FKHNLELEDDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3F43F20", Offset = "0x3F42F20", VA = "0x183F43F20")]
			get
			{
				return default((TValue, DHFKKCOJFDE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3F44140", Offset = "0x3F43140", VA = "0x183F44140")]
		public NEGJMLMDDKE(NativeArray<TSrc> IJPOMPNGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x33291F0", Offset = "0x33281F0", VA = "0x1833291F0")]
		public NEGJMLMDDKE<TSrc, TValue, TSelector> CJGNNJFLGEE()
		{
			return default(NEGJMLMDDKE<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3F44000", Offset = "0x3F43000", VA = "0x183F44000")]
		public bool DPDKHJIIAND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28EED10", Offset = "0x28EDD10", VA = "0x1828EED10")]
	public static MGDAGFPPIFF<T> FNDBLLMJNHH<T>(this NativeList<T> JOAHCODCDPO) where T : struct
	{
		return default(MGDAGFPPIFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
	public static MGDAGFPPIFF<T> FNDBLLMJNHH<T>(this NativeArray<T> IJPOMPNGBEF) where T : struct
	{
		return default(MGDAGFPPIFF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class EHINGGFJHJL
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct IHKKJEDEBEK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<T>.ReadOnly IJPOMPNGBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int BMGBMMPKFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int DCJNJNMIAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T PGKMODICEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private T KJJHDANMBCC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DHFKKCOJFDE GFDHPMIFODH
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3932C40", Offset = "0x3931C40", VA = "0x183932C40")]
			get
			{
				return default(DHFKKCOJFDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T MDHAJPLJGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3388EA0", Offset = "0x3387EA0", VA = "0x183388EA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public (T, DHFKKCOJFDE) FKHNLELEDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3932C50", Offset = "0x3931C50", VA = "0x183932C50")]
			get
			{
				return default((T, DHFKKCOJFDE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3933230", Offset = "0x3932230", VA = "0x183933230")]
		public IHKKJEDEBEK(NativeArray<T> IJPOMPNGBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3932DD0", Offset = "0x3931DD0", VA = "0x183932DD0")]
		public IHKKJEDEBEK<T> CJGNNJFLGEE()
		{
			return default(IHKKJEDEBEK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3932E10", Offset = "0x3931E10", VA = "0x183932E10")]
		public bool DPDKHJIIAND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x22D8480", Offset = "0x22D7480", VA = "0x1822D8480")]
		public BIEHBFJCAAA<T, TComparer> KLFBAILLGMH<TComparer>([Optional] TComparer OAKFLHIKMBN) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BIEHBFJCAAA<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct BIEHBFJCAAA<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly NativeArray<T>.ReadOnly IJPOMPNGBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int BMGBMMPKFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int DCJNJNMIAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T PGKMODICEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private T KJJHDANMBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TComparer OAKFLHIKMBN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DHFKKCOJFDE GFDHPMIFODH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3932C40", Offset = "0x3931C40", VA = "0x183932C40")]
			get
			{
				return default(DHFKKCOJFDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T MDHAJPLJGHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3388EA0", Offset = "0x3387EA0", VA = "0x183388EA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x47B9030", Offset = "0x47B8030", VA = "0x1847B9030")]
		public BIEHBFJCAAA(NativeArray<T>.ReadOnly IJPOMPNGBEF, TComparer OAKFLHIKMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x47B8E50", Offset = "0x47B7E50", VA = "0x1847B8E50")]
		public bool DPDKHJIIAND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2670E50", Offset = "0x266FE50", VA = "0x182670E50")]
	public static IHKKJEDEBEK<T> BHEGBKMLIHL<T>(this NativeArray<T> IJPOMPNGBEF) where T : struct
	{
		return default(IHKKJEDEBEK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface GAPLICDBPFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class LEBKMJAJLFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PCLGACGIANA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GJMADADHDAE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PCLGACGIANA<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAE3DA0", Offset = "0xAE2DA0", VA = "0x180AE3DA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x36D8440", Offset = "0x36D7440", VA = "0x1836D8440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public GJMADADHDAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x375A660", Offset = "0x3759660", VA = "0x18375A660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x375A810", Offset = "0x3759810", VA = "0x18375A810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Action<Protobuf> NGCCBMODIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MemoryStream OEHHIKFPHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CodedInputStream LCBODEEONOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Protobuf DEEABNJAEAL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int HOCNAFCFDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x413CCE0", Offset = "0x413BCE0", VA = "0x18413CCE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x413CD20", Offset = "0x413BD20", VA = "0x18413CD20", Slot = "4")]
	[IteratorStateMachine(typeof(PCLGACGIANA<>.GJMADADHDAE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x413CE10", Offset = "0x413BE10", VA = "0x18413CE10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct HMLJKFABAHA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly byte[] EOOJCJAHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly Protobuf DEEABNJAEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream OEHHIKFPHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedOutputStream JMJADPMBOEO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x37EE5B0", Offset = "0x37ED5B0", VA = "0x1837EE5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct MJJIAFEDJJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream OEHHIKFPHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedInputStream LCBODEEONOE;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x624F940", Offset = "0x624E940", VA = "0x18624F940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct PMOKGFAPKOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly byte[] EOOJCJAHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MemoryStream OEHHIKFPHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CodedOutputStream JMJADPMBOEO;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x624FD10", Offset = "0x624ED10", VA = "0x18624FD10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class FHPGGGJGKAP
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class IPKEIEGDKJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Flags]
public enum PIAPEOJKNFI
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
internal static class DFDECAOILMJ
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class LCCIMHLHFIH
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LCCIMHLHFIH()
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
