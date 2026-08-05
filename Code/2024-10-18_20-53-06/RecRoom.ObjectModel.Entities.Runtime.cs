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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE2470", Offset = "0x6EE1870", VA = "0x186EE2470")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GBLBIOPPAEE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DEGJJGDACCH LPNGFFCEAEH
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
public interface DDDNCNPGKAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KABMBGNFGDD(Entity KFLBPHJAJJL, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CACBCANEDPB(Entity KFLBPHJAJJL, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KNOHPCPGHDI(Entity KFLBPHJAJJL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KOEFLKCHIJI<TComponentData, TValue> : PACLMCCLCCI<TValue>, IDisposable where TComponentData : struct, GBLBIOPPAEE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class AGBHCJAJCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> KDBAFFDDPME;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ICBOPDBFFOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x388A9A0", Offset = "0x3889DA0", VA = "0x18388A9A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3FDA0F0", Offset = "0x3FD94F0", VA = "0x183FDA0F0")]
		public bool OINFFLFDOGM([Out] TValue EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3FDA000", Offset = "0x3FD9400", VA = "0x183FDA000")]
		public void LEFBGNCKNFL(object ABHFNNFMPHA, TValue EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3FD9E40", Offset = "0x3FD9240", VA = "0x183FD9E40")]
		public bool BJFEGIDGDBE(object ABHFNNFMPHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3FD9F00", Offset = "0x3FD9300", VA = "0x183FD9F00")]
		public int EDNOBGFMLLB(object ABHFNNFMPHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3FDA200", Offset = "0x3FD9600", VA = "0x183FDA200")]
		public AGBHCJAJCAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<AGBHCJAJCAH> IODIMDMCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private PHHHHGHCNBO<DEGJJGDACCH, AGBHCJAJCAH> NIGCMCIFDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager BIDAOIBGIKA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x45108A0", Offset = "0x450FCA0", VA = "0x1845108A0")]
	public KOEFLKCHIJI(EntityManager BIDAOIBGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x45105D0", Offset = "0x450F9D0", VA = "0x1845105D0", Slot = "4")]
	public void KABMBGNFGDD(Entity KFLBPHJAJJL, object ABHFNNFMPHA, TValue EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x45100E0", Offset = "0x450F4E0", VA = "0x1845100E0", Slot = "5")]
	public bool CACBCANEDPB(Entity KFLBPHJAJJL, object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4510780", Offset = "0x450FB80", VA = "0x184510780", Slot = "6")]
	public bool OINFFLFDOGM(Entity KFLBPHJAJJL, [Out] TValue EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45103C0", Offset = "0x450F7C0", VA = "0x1845103C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45102F0", Offset = "0x450F6F0", VA = "0x1845102F0")]
	private void CJBLACFFNHI(AGBHCJAJCAH EPGPMFPHHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4510510", Offset = "0x450F910", VA = "0x184510510")]
	private bool IMCPCNMDAAE(Entity KFLBPHJAJJL, [Out] DEGJJGDACCH KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x450FFE0", Offset = "0x450F3E0", VA = "0x18450FFE0")]
	private void AKFJKMJBADD(Entity KFLBPHJAJJL, DEGJJGDACCH KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4510760", Offset = "0x450FB60", VA = "0x184510760")]
	private bool KADBGHBAICJ(DEGJJGDACCH KNOJBNNAGCL, [Out] AGBHCJAJCAH EPGPMFPHHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x45103E0", Offset = "0x450F7E0", VA = "0x1845103E0")]
	private AGBHCJAJCAH EEELHHJBKFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PACLMCCLCCI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KABMBGNFGDD(Entity KFLBPHJAJJL, object ABHFNNFMPHA, TValue EEPLCHCGAIN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CACBCANEDPB(Entity KFLBPHJAJJL, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OINFFLFDOGM(Entity KFLBPHJAJJL, [Out] TValue EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DEGJJGDACCH : NLGMFENKCMI, IEquatable<DEGJJGDACCH>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly DEGJJGDACCH ILFKJMJAIPF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int KMIIBMECGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x92A840", Offset = "0x929C40", VA = "0x18092A840", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int GPEGCFLKPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27EB090", Offset = "0x27EA490", VA = "0x1827EB090", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6183F60", Offset = "0x6183360", VA = "0x186183F60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2230", Offset = "0x6EE1630", VA = "0x186EE2230", Slot = "8")]
	public bool Equals(DEGJJGDACCH KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2280", Offset = "0x6EE1680", VA = "0x186EE2280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ABGPJOOCLDF<THasTokensTag> : DDDNCNPGKAD, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, DEGJJGDACCH> HMPDMIMHOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> IODIMDMCBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PHHHHGHCNBO<DEGJJGDACCH, HashSet<object>> NIGCMCIFDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager BIDAOIBGIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem DGBNJALAMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool INBIMOFIBDA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3FCF1C0", Offset = "0x3FCE5C0", VA = "0x183FCF1C0")]
	public ABGPJOOCLDF(EntityManager BIDAOIBGIKA, EntityCommandBufferSystem DGBNJALAMGG, FLILHMOBPPM JEPPKELCNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3FCDD30", Offset = "0x3FCD130", VA = "0x183FCDD30", Slot = "4")]
	public bool KABMBGNFGDD(Entity KFLBPHJAJJL, object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC930", Offset = "0x3FCBD30", VA = "0x183FCC930", Slot = "5")]
	public bool CACBCANEDPB(Entity KFLBPHJAJJL, object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE710", Offset = "0x3FCDB10", VA = "0x183FCE710", Slot = "6")]
	public bool KNOHPCPGHDI(Entity KFLBPHJAJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE940", Offset = "0x3FCDD40", VA = "0x183FCE940", Slot = "8")]
	public bool KNOHPCPGHDI(DEGJJGDACCH KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD150", Offset = "0x3FCC550", VA = "0x183FCD150", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3FCCFB0", Offset = "0x3FCC3B0", VA = "0x183FCCFB0")]
	private void CJBLACFFNHI(HashSet<object> EPGPMFPHHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD9D0", Offset = "0x3FCCDD0", VA = "0x183FCD9D0")]
	private bool IMCPCNMDAAE(Entity KFLBPHJAJJL, [Out] DEGJJGDACCH KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3FCEAC0", Offset = "0x3FCDEC0", VA = "0x183FCEAC0")]
	private bool NAFMCMNNGEC(Entity KFLBPHJAJJL, [Out] DEGJJGDACCH KNOJBNNAGCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD520", Offset = "0x3FCC920", VA = "0x183FCD520")]
	private void EOALCFBBMPE(Entity KFLBPHJAJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE2D0", Offset = "0x3FCD6D0", VA = "0x183FCE2D0")]
	private void KMOKIEGLIHC(Entity KFLBPHJAJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3FCEF40", Offset = "0x3FCE340", VA = "0x183FCEF40")]
	private void PDBAOMBKBHF(Entity KFLBPHJAJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC590", Offset = "0x3FCB990", VA = "0x183FCC590")]
	private void AKFJKMJBADD(Entity KFLBPHJAJJL, DEGJJGDACCH KNOJBNNAGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3FCEDC0", Offset = "0x3FCE1C0", VA = "0x183FCEDC0")]
	private bool NHPHPGBEGCE(DEGJJGDACCH KNOJBNNAGCL, [Out] HashSet<object> EPGPMFPHHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD2D0", Offset = "0x3FCC6D0", VA = "0x183FCD2D0")]
	private HashSet<object> EEELHHJBKFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BMGHGDFJELL
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KACPFCBMADE : MKBOOCPJLFI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2960", Offset = "0x6EE1D60", VA = "0x186EE2960")]
	public float IPLKECLELKI([In] float3 EEPLCHCGAIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2960", Offset = "0x6EE1D60", VA = "0x186EE2960", Slot = "4")]
	private float BGHJDFFHGCI([In] float3 EEPLCHCGAIN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BHKOEBKFHGO : MKBOOCPJLFI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1F50", Offset = "0x6EE1350", VA = "0x186EE1F50")]
	public float IPLKECLELKI([In] float3 EEPLCHCGAIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1F50", Offset = "0x6EE1350", VA = "0x186EE1F50", Slot = "4")]
	private float BGHJDFFHGCI([In] float3 EEPLCHCGAIN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct DHMDNOACPKC : MKBOOCPJLFI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7B0", Offset = "0x9BCBB0", VA = "0x1809BD7B0")]
	public float IPLKECLELKI([In] float3 EEPLCHCGAIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7B0", Offset = "0x9BCBB0", VA = "0x1809BD7B0", Slot = "4")]
	private float BGHJDFFHGCI([In] float3 EEPLCHCGAIN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IKKPNFMMDIB : MKBOOCPJLFI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A71670", Offset = "0x1A70A70", VA = "0x181A71670")]
	public int IPLKECLELKI([In] int3 EEPLCHCGAIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1A71670", Offset = "0x1A70A70", VA = "0x181A71670", Slot = "4")]
	private int HJOIFCNBJDA([In] int3 EEPLCHCGAIN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CPFMEFHDKCE : MKBOOCPJLFI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B61B80", Offset = "0x6B60F80", VA = "0x186B61B80")]
	public int IPLKECLELKI([In] int3 EEPLCHCGAIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B61B80", Offset = "0x6B60F80", VA = "0x186B61B80", Slot = "4")]
	private int HJOIFCNBJDA([In] int3 EEPLCHCGAIN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HJDLHHPKAHO : MKBOOCPJLFI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x9A18B0", Offset = "0x9A0CB0", VA = "0x1809A18B0")]
	public int IPLKECLELKI([In] int3 EEPLCHCGAIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9A18B0", Offset = "0x9A0CB0", VA = "0x1809A18B0", Slot = "4")]
	private int HJOIFCNBJDA([In] int3 EEPLCHCGAIN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LJNOLKDJHLB : MADNEGOOBGO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x198B2B0", Offset = "0x198A6B0", VA = "0x18198B2B0")]
	public LJNOLKDJHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class GEHIGNLPDGG : SystemBase, EEIDEHIKLNL
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2580", Offset = "0x6EE1980", VA = "0x186EE2580")]
	public JobHandle BJEMAOKEKPE(ReadOnlySpan<int> FKDEGCGPKCL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E5AC40", Offset = "0x2E5A040", VA = "0x182E5AC40")]
	public void LNAEDPBHJDE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A9A0", Offset = "0x2E59DA0", VA = "0x182E5A9A0")]
	public JobHandle LNAEDPBHJDE<T>(JobHandle KNOJBNNAGCL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EE25F0", Offset = "0x6EE19F0", VA = "0x186EE25F0")]
	public JobHandle LNAEDPBHJDE(ReadOnlySpan<int> FKDEGCGPKCL, JobHandle KNOJBNNAGCL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A700", Offset = "0x2E59B00", VA = "0x182E5A700")]
	public JobHandle GHEAJLNJFKN<T>(JobHandle KNOJBNNAGCL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2660", Offset = "0x6EE1A60", VA = "0x186EE2660")]
	public ComponentDataFromEntity OACHHLBDFOI(int HPIFEIGNDML, bool NAPMJEFHEIK = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EE25D0", Offset = "0x6EE19D0", VA = "0x186EE25D0")]
	public EntityExistenceLookupByEntity JPJPKMAAFNI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2720", Offset = "0x6EE1B20", VA = "0x186EE2720", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x198B2B0", Offset = "0x198A6B0", VA = "0x18198B2B0")]
	protected GEHIGNLPDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class KNBCIBGCGOG : GEHIGNLPDGG
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2970", Offset = "0x6EE1D70", VA = "0x186EE2970", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x198B2B0", Offset = "0x198A6B0", VA = "0x18198B2B0")]
	protected KNBCIBGCGOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AKKLENIANEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class MJLKHLNFMAL : EntityCommandBufferSystem, EEIDEHIKLNL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x198B2B0", Offset = "0x198A6B0", VA = "0x18198B2B0")]
	protected MJLKHLNFMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MKBOOCPJLFI<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IPLKECLELKI([In] TFrom EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IMHFEEGOPIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDELDPDKIIG(T EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct FKOIAFDACHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> IKCCHOOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer BCCACBFDKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes MMKCNFGAHIL;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2490", Offset = "0x6EE1890", VA = "0x186EE2490", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct GPFBEJLPELP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> IKCCHOOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer BCCACBFDKLD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2730", Offset = "0x6EE1B30", VA = "0x186EE2730", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct EBDJCDKLEDH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> IKCCHOOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer BCCACBFDKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType AEBGABLODHD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE22D0", Offset = "0x6EE16D0", VA = "0x186EE22D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct MGNFBLOILCI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> IKCCHOOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> AIKOCCMKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer BCCACBFDKLD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x47C31B0", Offset = "0x47C25B0", VA = "0x1847C31B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct GDOFDOJOBOD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> IKCCHOOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> BFAMJIIMLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer BCCACBFDKLD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct PBOAJFCBEPL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> IKCCHOOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T EEPLCHCGAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer BCCACBFDKLD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4AD1CD0", Offset = "0x4AD10D0", VA = "0x184AD1CD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct EFMDLFJKBLH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MKBOOCPJLFI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> OEPOAMBIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> NMMONGFNMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap HJOAJFDFEDM;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct IOBLPGMBCKC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity LKMMKGKDHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> OEPOAMBIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> NMMONGFNMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int ONBIDMFLGLH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EE27D0", Offset = "0x6EE1BD0", VA = "0x186EE27D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct KCJGKOKHLKN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OAFMEAPDEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> OEPOAMBIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> JICALKIIMNK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct OHIFJLNNLOK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MKBOOCPJLFI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> BDEFDKGJKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> NMMONGFNMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap HJOAJFDFEDM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct KHIKHLKCEDE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MPKDLBKIAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> ABNKNBAEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> NHEAJJKHACN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct AMDDLHMLDKF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MPKDLBKIAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> ABNKNBAEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> NHEAJJKHACN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40D1480", Offset = "0x40D0880", VA = "0x1840D1480", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct PLJCAEEIBAF<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> OEPOAMBIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> JICALKIIMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> NELNDAHMMFN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B29BD0", Offset = "0x4B28FD0", VA = "0x184B29BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct POOPGIPEEJL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : MKBOOCPJLFI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> OEPOAMBIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> JICALKIIMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> NELNDAHMMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap HJOAJFDFEDM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct BNPIFMEGDJM<T, TPredicate> : IJob where T : struct where TPredicate : struct, IMHFEEGOPIC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> OEPOAMBIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> ECPNGNLNPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> LLOAIFOBGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate HJOAJFDFEDM;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct LNEFGAICJIP<T, TPredicate> : IJob where T : struct where TPredicate : struct, IMHFEEGOPIC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> OEPOAMBIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> JICALKIIMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate HJOAJFDFEDM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct NELIIPALHOF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity MPKDLBKIAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> ABNKNBAEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> OECEFCCJPOO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE29A0", Offset = "0x6EE1DA0", VA = "0x186EE29A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct OHLHBLPFBEH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity MPKDLBKIAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> ABNKNBAEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> OECEFCCJPOO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2A30", Offset = "0x6EE1E30", VA = "0x186EE2A30", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FDGFLACJKEG
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KFEMIDPEIGK
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2EE5570", Offset = "0x2EE4970", VA = "0x182EE5570")]
	public static bool OOJONOEJNAM<T>(this NativeArray<Entity> ABNKNBAEGCJ, EntityManager BIDAOIBGIKA, Allocator HPLNAKONHEI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IOEAINNFGKI
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GBPKJKGLCCJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public GBPKJKGLCCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PELGAJJHGGC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public PELGAJJHGGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> EEHIEIGEAOA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE28D0", Offset = "0x6EE1CD0", VA = "0x186EE28D0")]
	public IOEAINNFGKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class IAHJJFOKIEP
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FGGLHNCODGG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct ICJPLCAGIAO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct JMECKCPDJDI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal ICJPLCAGIAO<TFrom> DEDHJMDEEIE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> CEMFCPJEKHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct DGNCEHKIAEO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct MLNKLHPIDFM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal DGNCEHKIAEO<TFrom> DEDHJMDEEIE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> CEMFCPJEKHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct DKBCCCHHFHO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct CHDEMILLNOB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal DKBCCCHHFHO<TFrom> DEDHJMDEEIE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> CEMFCPJEKHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct LACBDFHAGFI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct HMHEDJGJFHM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal LACBDFHAGFI<TFrom> DEDHJMDEEIE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> CEMFCPJEKHI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class CENNDJNNLIK
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FLAHOLFKNNP
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AAB0", Offset = "0x2E49EB0", VA = "0x182E4AAB0")]
	public static NativeList<T> JOLIDJDJGKL<T>(this NativeArray<T> EKEGLNNIFMJ, Allocator HPLNAKONHEI = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GEGJIPCGIMA
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CPMPKKDDHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C747D0", Offset = "0x2C73BD0", VA = "0x182C747D0")]
	[NFPJMIFJEOC]
	public static JobHandle NGFFFMMKAFF<T>(this EntityCommandBufferSystem DGBNJALAMGG, NativeArrayAsync<Entity> IKCCHOOOHEH, NativeArrayAsync<T> AIKOCCMKKAE, [Optional] JobHandle NANPLDGDDKM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C74950", Offset = "0x2C73D50", VA = "0x182C74950")]
	[NFPJMIFJEOC]
	public static JobHandle NGFFFMMKAFF<T>(this EntityCommandBufferSystem DGBNJALAMGG, NativeArrayAsync<Entity> IKCCHOOOHEH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2C746A0", Offset = "0x2C73AA0", VA = "0x182C746A0")]
	[NFPJMIFJEOC]
	public static JobHandle NGFFFMMKAFF<T>(this EntityCommandBufferSystem DGBNJALAMGG, NativeArray<Entity> IKCCHOOOHEH, [Optional] JobHandle NANPLDGDDKM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1F60", Offset = "0x6EE1360", VA = "0x186EE1F60")]
	[NFPJMIFJEOC]
	public static JobHandle NGFFFMMKAFF(this EntityCommandBufferSystem DGBNJALAMGG, NativeArray<Entity> IKCCHOOOHEH, ComponentTypes MMKCNFGAHIL, [Optional] JobHandle NANPLDGDDKM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6EE20D0", Offset = "0x6EE14D0", VA = "0x186EE20D0")]
	[NFPJMIFJEOC]
	public static JobHandle NGFFFMMKAFF(this EntityCommandBufferSystem DGBNJALAMGG, EntityCommandBuffer BCCACBFDKLD, NativeArray<Entity> IKCCHOOOHEH, ComponentTypes MMKCNFGAHIL, [Optional] JobHandle NANPLDGDDKM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DHNICDKEOKL
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1EA0", Offset = "0x2CA12A0", VA = "0x182CA1EA0")]
	[NFPJMIFJEOC]
	public static JobHandle GOGBEGFEGAA<T>(this EntityCommandBufferSystem DGBNJALAMGG, EntityCommandBuffer BCCACBFDKLD, EntityQuery MHDABIJDMFL, T EEPLCHCGAIN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BGPPODFEAJA
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1DC0", Offset = "0x6EE11C0", VA = "0x186EE1DC0")]
	[NFPJMIFJEOC]
	public static JobHandle NHNMCIKMFCJ(this EntityCommandBufferSystem DGBNJALAMGG, NativeList<Entity> IKCCHOOOHEH, [Optional] JobHandle NANPLDGDDKM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1CC0", Offset = "0x6EE10C0", VA = "0x186EE1CC0")]
	[NFPJMIFJEOC]
	public static JobHandle NHNMCIKMFCJ(this EntityCommandBufferSystem DGBNJALAMGG, NativeArrayAsync<Entity> IKCCHOOOHEH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KFJMDFMPJPB
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class OCPBAFEBLBB
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB540", Offset = "0x2FFA940", VA = "0x182FFB540")]
	[NFPJMIFJEOC]
	public static JobHandle AMCFCMFPBOL<T>(this EntityCommandBufferSystem DGBNJALAMGG, NativeArray<Entity> IKCCHOOOHEH, NativeArray<T> AIKOCCMKKAE, JobHandle NANPLDGDDKM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HNDLBHNBIKK
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2E784E0", Offset = "0x2E778E0", VA = "0x182E784E0")]
	[NFPJMIFJEOC]
	public static JobHandle JBEELLFCECA<T>(this EntityCommandBufferSystem DGBNJALAMGG, NativeArray<Entity> IKCCHOOOHEH, T EEPLCHCGAIN, [Optional] JobHandle NANPLDGDDKM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E78400", Offset = "0x2E77800", VA = "0x182E78400")]
	[NFPJMIFJEOC]
	public static JobHandle JBEELLFCECA<T>(this EntityCommandBufferSystem DGBNJALAMGG, EntityCommandBuffer BCCACBFDKLD, NativeArray<Entity> IKCCHOOOHEH, T EEPLCHCGAIN, [Optional] JobHandle NANPLDGDDKM) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KGCPLCCCCMH
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PIGPEFLEGBH
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3043340", Offset = "0x3042740", VA = "0x183043340")]
	public static NativeArray<T> FIIMKEJBDFA<T>(this NativeList<Entity> EKEGLNNIFMJ, EntityManager BIDAOIBGIKA, Allocator HPLNAKONHEI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3042DA0", Offset = "0x30421A0", VA = "0x183042DA0")]
	public static NativeArray<T> FIIMKEJBDFA<T>(this NativeArray<Entity> EKEGLNNIFMJ, EntityManager BIDAOIBGIKA, Allocator HPLNAKONHEI = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2AC0", Offset = "0x6EE1EC0", VA = "0x186EE2AC0")]
	public static NativeArray<Entity> AGHBFGOJPLO(this NativeArray<Entity> EKEGLNNIFMJ, EntityManager BIDAOIBGIKA, ComponentType AEBGABLODHD, Allocator HPLNAKONHEI = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3043410", Offset = "0x3042810", VA = "0x183043410")]
	public static NativeArray<T> NFIIMBDLOAI<T>(this NativeArray<Entity> EKEGLNNIFMJ, EntityManager BIDAOIBGIKA, Allocator HPLNAKONHEI = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FEPCLMFOMKD
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct INAGADMFOII<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct KHHJKPBJBNE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public INAGADMFOII<TFrom> CEMFCPJEKHI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> OEPOAMBIDJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct JMLFJMPJKEN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct ODLCFFPNNLP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public JMLFJMPJKEN<TFrom> CEMFCPJEKHI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> OEPOAMBIDJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NLDCJIBGBPJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct NLGKLNNLJMJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NLDCJIBGBPJ<TFrom> CEMFCPJEKHI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> OEPOAMBIDJI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class AKMNKKDIKGI
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class NDNIKFPMPAF
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct DCLMJFIGHHD : MKBOOCPJLFI<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> JBDDACOMJHB;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2220", Offset = "0x6EE1620", VA = "0x186EE2220")]
		[BurstCompatible]
		public Entity IPLKECLELKI([In] Entity EEPLCHCGAIN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2220", Offset = "0x6EE1620", VA = "0x186EE2220", Slot = "4")]
		private Entity CBGJNJFDOAB([In] Entity EEPLCHCGAIN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GJOPACFHKPD
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct PGKDFBHBGEO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> ECPNGNLNPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> OEPOAMBIDJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct ADEOJEABBIA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> ECPNGNLNPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> OEPOAMBIDJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct HJPGNLPEKHB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> ECPNGNLNPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> OEPOAMBIDJI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ADLFKHCJDGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class PPFFHEEIJCF
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct KOKIIFNCCEG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> OEPOAMBIDJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct OPGGLDMGCCN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> OEPOAMBIDJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct KIGLINDINOC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> OEPOAMBIDJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct LHFIIEBGJII<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator HPLNAKONHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> OEPOAMBIDJI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FBNJBOEEJGK
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FCPHGOCLEEI
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2E2E630", Offset = "0x2E2DA30", VA = "0x182E2E630")]
	public static NativeList<Entity> DLAPDBEHOIM<T>(this NativeArray<Entity> ABNKNBAEGCJ, EntityManager BIDAOIBGIKA, Allocator HPLNAKONHEI = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GOJJOLHAIMB
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FDOFMOLCMLB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct MPNBACFOKFA<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> IGGIDMIPNHL;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
		public MPNBACFOKFA(NativeArray<TSrc> IGGIDMIPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public LLEOFOLONNK<TSrc, TValue> PKHCCDBNMFB<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LLEOFOLONNK<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct LLEOFOLONNK<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> IGGIDMIPNHL;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
		public LLEOFOLONNK(NativeArray<TSrc> IGGIDMIPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public JKIPJJNOHKO<TSrc, TValue, TSelector> KAOFLHKBIGC<TSelector>() where TSelector : struct, MKBOOCPJLFI<TSrc, TValue>
		{
			return default(JKIPJJNOHKO<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct JKIPJJNOHKO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MKBOOCPJLFI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> IGGIDMIPNHL;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
		public JKIPJJNOHKO(NativeArray<TSrc> IGGIDMIPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4426D30", Offset = "0x4426130", VA = "0x184426D30")]
		public KMOJNIJAGML<TSrc, TValue, TSelector> MJMMKFMHELO()
		{
			return default(KMOJNIJAGML<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct BJGKIFGKINL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, MKBOOCPJLFI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> IGGIDMIPNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector OHGNLOKBMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int HAJICDLBEKC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5273180", Offset = "0x5272580", VA = "0x185273180")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int KMIIBMECGKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E50", Offset = "0x9B2250", VA = "0x1809B2E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int AEFILNEPPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2224730", Offset = "0x2223B30", VA = "0x182224730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x52731C0", Offset = "0x52725C0", VA = "0x1852731C0")]
		public BJGKIFGKINL(NativeArray<TSrc> IGGIDMIPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5273170", Offset = "0x5272570", VA = "0x185273170")]
		public bool MOBDCELHOMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5273070", Offset = "0x5272470", VA = "0x185273070")]
		private TSrc GIJCNGIJALM(int PGOOPNPHNCA)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5272FE0", Offset = "0x52723E0", VA = "0x185272FE0")]
		private TValue COCDLFGOKAP()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct KMOJNIJAGML<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MKBOOCPJLFI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private BJGKIFGKINL<TSrc, TValue, TSelector> ADGILLNPFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue JGGFPFHHEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int PGAHHGFJKBL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KAGIILHFJGF DDJCMLJABML
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x450FAA0", Offset = "0x450EEA0", VA = "0x18450FAA0")]
			get
			{
				return default(KAGIILHFJGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue AMHKIGCFMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, KAGIILHFJGF range) GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x450FC60", Offset = "0x450F060", VA = "0x18450FC60")]
			get
			{
				return default((TValue, KAGIILHFJGF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x450FD40", Offset = "0x450F140", VA = "0x18450FD40")]
		public KMOJNIJAGML(NativeArray<TSrc> IGGIDMIPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD42FF0", Offset = "0xD423F0", VA = "0x180D42FF0")]
		public KMOJNIJAGML<TSrc, TValue, TSelector> JLDAKMOMDIF()
		{
			return default(KMOJNIJAGML<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x450FAE0", Offset = "0x450EEE0", VA = "0x18450FAE0")]
		public bool MOBDCELHOMP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2E479D0", Offset = "0x2E46DD0", VA = "0x182E479D0")]
	public static MPNBACFOKFA<T> AEENEIPGMPN<T>(this NativeList<T> KDBAFFDDPME) where T : struct
	{
		return default(MPNBACFOKFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
	public static MPNBACFOKFA<T> AEENEIPGMPN<T>(this NativeArray<T> IGGIDMIPNHL) where T : struct
	{
		return default(MPNBACFOKFA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class PKHOPJNEJOG
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct LEGANGIJMKH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly IGGIDMIPNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int PGAHHGFJKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int JNGIJMGCMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T JGGFPFHHEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T IBBLHIHMNPL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KAGIILHFJGF DDJCMLJABML
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4595500", Offset = "0x4594900", VA = "0x184595500")]
			get
			{
				return default(KAGIILHFJGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T AMHKIGCFMAB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3C15FA0", Offset = "0x3C153A0", VA = "0x183C15FA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, KAGIILHFJGF) GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x45959D0", Offset = "0x4594DD0", VA = "0x1845959D0")]
			get
			{
				return default((T, KAGIILHFJGF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4595AA0", Offset = "0x4594EA0", VA = "0x184595AA0")]
		public LEGANGIJMKH(NativeArray<T> IGGIDMIPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4595510", Offset = "0x4594910", VA = "0x184595510")]
		public LEGANGIJMKH<T> JLDAKMOMDIF()
		{
			return default(LEGANGIJMKH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4595730", Offset = "0x4594B30", VA = "0x184595730")]
		public bool MOBDCELHOMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2D923E0", Offset = "0x2D917E0", VA = "0x182D923E0")]
		public OKIPMOHIJGH<T, TComparer> MAPJKOHPDCE<TComparer>([Optional] TComparer HHMDHCMOGGH) where TComparer : struct, IEqualityComparer<T>
		{
			return default(OKIPMOHIJGH<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct OKIPMOHIJGH<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly IGGIDMIPNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int PGAHHGFJKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int JNGIJMGCMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T JGGFPFHHEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T IBBLHIHMNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer HHMDHCMOGGH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KAGIILHFJGF DDJCMLJABML
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4595500", Offset = "0x4594900", VA = "0x184595500")]
			get
			{
				return default(KAGIILHFJGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T AMHKIGCFMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3C15FA0", Offset = "0x3C153A0", VA = "0x183C15FA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4A175C0", Offset = "0x4A169C0", VA = "0x184A175C0")]
		public OKIPMOHIJGH(NativeArray<T>.ReadOnly IGGIDMIPNHL, TComparer HHMDHCMOGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4A173D0", Offset = "0x4A167D0", VA = "0x184A173D0")]
		public bool MOBDCELHOMP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3044830", Offset = "0x3043C30", VA = "0x183044830")]
	public static LEGANGIJMKH<T> MJMMKFMHELO<T>(this NativeArray<T> IGGIDMIPNHL) where T : struct
	{
		return default(LEGANGIJMKH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface EJOAJEHGICD
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class CLBCKKJPFLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct DFMBAAGGAKK<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class HDEMABPOADE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public DFMBAAGGAKK<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9220B0", Offset = "0x9214B0", VA = "0x1809220B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F98E00", Offset = "0x3F98200", VA = "0x183F98E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public HDEMABPOADE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4119BD0", Offset = "0x4118FD0", VA = "0x184119BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4119DB0", Offset = "0x41191B0", VA = "0x184119DB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> BNEIIKELNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream OFEOCHDJIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream PMKHDOKLNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf FCFKEIFCDCL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D870", Offset = "0x5C9CC70", VA = "0x185C9D870", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D8B0", Offset = "0x5C9CCB0", VA = "0x185C9D8B0", Slot = "4")]
	[IteratorStateMachine(typeof(DFMBAAGGAKK<>.HDEMABPOADE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5C9D9B0", Offset = "0x5C9CDB0", VA = "0x185C9D9B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct OPKHKIIMMFN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] PCJDGFHBJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf FCFKEIFCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream OFEOCHDJIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream BNLHGFPAGPD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A2D660", Offset = "0x4A2CA60", VA = "0x184A2D660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PPNBDMGCLID : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream OFEOCHDJIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream PMKHDOKLNJD;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2CA0", Offset = "0x6EE20A0", VA = "0x186EE2CA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct EJIFOGDPHLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] PCJDGFHBJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream OFEOCHDJIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream BNLHGFPAGPD;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2350", Offset = "0x6EE1750", VA = "0x186EE2350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DADKMEHOJMF
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class IAOMMGLKPKE
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum JKCNILAOBDN
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
internal static class OCLCOLICBGO
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JHDCDGCMADC
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public JHDCDGCMADC()
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
