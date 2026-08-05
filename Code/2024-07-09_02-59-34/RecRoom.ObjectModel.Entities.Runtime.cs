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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AC1A30", Offset = "0x6AC0630", VA = "0x186AC1A30")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ODCMJHJBKHI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JDHOHDOFEHO KBDDOKDLMOL
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
public interface CAEHHBHNANL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OHLLKGGLHCI(Entity AOPPIDPOGKL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KEGPCAGFLIC(Entity AOPPIDPOGKL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PFNPOIDCBPL(Entity AOPPIDPOGKL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NPNKENBGGEF<TComponentData, TValue> : FJOBEAHPEPN<TValue>, IDisposable where TComponentData : struct, ODCMJHJBKHI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class GJLANFMGMPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> ELBBNOKMNCJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int NAAONAFFINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x358E2D0", Offset = "0x358CED0", VA = "0x18358E2D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DEB0", Offset = "0x3D4CAB0", VA = "0x183D4DEB0")]
		public bool FMGFBPLABIN([Out] TValue IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DFC0", Offset = "0x3D4CBC0", VA = "0x183D4DFC0")]
		public void LKPJOLMECIF(object GBENACPKFNA, TValue IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D4DDF0", Offset = "0x3D4C9F0", VA = "0x183D4DDF0")]
		public bool ECLBFOFCOFL(object GBENACPKFNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E0B0", Offset = "0x3D4CCB0", VA = "0x183D4E0B0")]
		public int OFNMBPGBNNI(object GBENACPKFNA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E1B0", Offset = "0x3D4CDB0", VA = "0x183D4E1B0")]
		public GJLANFMGMPK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<GJLANFMGMPK> HNAAGNCAFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private PNOHLKCJAAP<JDHOHDOFEHO, GJLANFMGMPK> BMBCPMNKPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager LHOMFPBLGHH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x453BD70", Offset = "0x453A970", VA = "0x18453BD70")]
	public NPNKENBGGEF(EntityManager LHOMFPBLGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x453BB10", Offset = "0x453A710", VA = "0x18453BB10", Slot = "4")]
	public void OHLLKGGLHCI(Entity AOPPIDPOGKL, object GBENACPKFNA, TValue IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x453B7D0", Offset = "0x453A3D0", VA = "0x18453B7D0", Slot = "5")]
	public bool KEGPCAGFLIC(Entity AOPPIDPOGKL, object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x453B5C0", Offset = "0x453A1C0", VA = "0x18453B5C0", Slot = "6")]
	public bool FMGFBPLABIN(Entity AOPPIDPOGKL, [Out] TValue IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x453B5A0", Offset = "0x453A1A0", VA = "0x18453B5A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x453BCA0", Offset = "0x453A8A0", VA = "0x18453BCA0")]
	private void PACJPMEMHPL(GJLANFMGMPK JPGNLODAOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x453B700", Offset = "0x453A300", VA = "0x18453B700")]
	private bool HPLEIGLOJDP(Entity AOPPIDPOGKL, [Out] JDHOHDOFEHO MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x453B4A0", Offset = "0x453A0A0", VA = "0x18453B4A0")]
	private void DMHFNFJACLF(Entity AOPPIDPOGKL, JDHOHDOFEHO MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x453B6E0", Offset = "0x453A2E0", VA = "0x18453B6E0")]
	private bool GNEJDCJFDKJ(JDHOHDOFEHO MJBLPCEDGPJ, [Out] GJLANFMGMPK JPGNLODAOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x453B9E0", Offset = "0x453A5E0", VA = "0x18453B9E0")]
	private GJLANFMGMPK MPLPIMCOKFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FJOBEAHPEPN<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHLLKGGLHCI(Entity AOPPIDPOGKL, object GBENACPKFNA, TValue IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KEGPCAGFLIC(Entity AOPPIDPOGKL, object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FMGFBPLABIN(Entity AOPPIDPOGKL, [Out] TValue IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JDHOHDOFEHO : PCHGDIKACAK, IEquatable<JDHOHDOFEHO>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly JDHOHDOFEHO IAEFNBLMFND;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int ICIBDGPPAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA8A510", Offset = "0xA89110", VA = "0x180A8A510", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int PDDGDECCJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x256F310", Offset = "0x256DF10", VA = "0x18256F310", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6600", Offset = "0x5DA5200", VA = "0x185DA6600", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1E70", Offset = "0x6AC0A70", VA = "0x186AC1E70", Slot = "8")]
	public bool Equals(JDHOHDOFEHO HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1EC0", Offset = "0x6AC0AC0", VA = "0x186AC1EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NNHMBKMFKAE<THasTokensTag> : CAEHHBHNANL, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, JDHOHDOFEHO> IHNKOENJICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> HNAAGNCAFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PNOHLKCJAAP<JDHOHDOFEHO, HashSet<object>> BMBCPMNKPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager LHOMFPBLGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem AHOMHHKLBKF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x45373E0", Offset = "0x4535FE0", VA = "0x1845373E0")]
	public NNHMBKMFKAE(EntityManager LHOMFPBLGHH, EntityCommandBufferSystem AHOMHHKLBKF, EEGEMFOKJOP MOIIKKNELPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4536400", Offset = "0x4535000", VA = "0x184536400", Slot = "4")]
	public bool OHLLKGGLHCI(Entity AOPPIDPOGKL, object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4535170", Offset = "0x4533D70", VA = "0x184535170", Slot = "5")]
	public bool KEGPCAGFLIC(Entity AOPPIDPOGKL, object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x45368F0", Offset = "0x45354F0", VA = "0x1845368F0", Slot = "6")]
	public bool PFNPOIDCBPL(Entity AOPPIDPOGKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4536830", Offset = "0x4535430", VA = "0x184536830", Slot = "8")]
	public bool PFNPOIDCBPL(JDHOHDOFEHO MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x45348F0", Offset = "0x45334F0", VA = "0x1845348F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4536700", Offset = "0x4535300", VA = "0x184536700")]
	private void PACJPMEMHPL(HashSet<object> JPGNLODAOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4534FD0", Offset = "0x4533BD0", VA = "0x184534FD0")]
	private bool HPLEIGLOJDP(Entity AOPPIDPOGKL, [Out] JDHOHDOFEHO MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4534AF0", Offset = "0x45336F0", VA = "0x184534AF0")]
	private bool GDDMIJAJJOL(Entity AOPPIDPOGKL, [Out] JDHOHDOFEHO MJBLPCEDGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4535AB0", Offset = "0x45346B0", VA = "0x184535AB0")]
	private void NDJJFNJFPBL(Entity AOPPIDPOGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4536B20", Offset = "0x4535720", VA = "0x184536B20")]
	private void PGPLICIMOFG(Entity AOPPIDPOGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4534430", Offset = "0x4533030", VA = "0x184534430")]
	private void ABOHIMNPLLJ(Entity AOPPIDPOGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4534800", Offset = "0x4533400", VA = "0x184534800")]
	private void DMHFNFJACLF(Entity AOPPIDPOGKL, JDHOHDOFEHO MJBLPCEDGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4534A90", Offset = "0x4533690", VA = "0x184534A90")]
	private bool FJNBOBKNIDI(JDHOHDOFEHO MJBLPCEDGPJ, [Out] HashSet<object> JPGNLODAOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4535A10", Offset = "0x4534610", VA = "0x184535A10")]
	private HashSet<object> MPLPIMCOKFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IBJPLHEFFDB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CPJJBJKHAHD : HOGKIDBILFB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1990", Offset = "0x6AC0590", VA = "0x186AC1990")]
	public float DAAPFEJGKCA([In] float3 IIPLJLPCLBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1990", Offset = "0x6AC0590", VA = "0x186AC1990", Slot = "4")]
	private float KDFHBCBLAKC([In] float3 IIPLJLPCLBC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PMCPFBMADBN : HOGKIDBILFB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AC25C0", Offset = "0x6AC11C0", VA = "0x186AC25C0")]
	public float DAAPFEJGKCA([In] float3 IIPLJLPCLBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AC25C0", Offset = "0x6AC11C0", VA = "0x186AC25C0", Slot = "4")]
	private float KDFHBCBLAKC([In] float3 IIPLJLPCLBC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CNEDIJNPHPF : HOGKIDBILFB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2EB0", Offset = "0x1CE1AB0", VA = "0x181CE2EB0")]
	public float DAAPFEJGKCA([In] float3 IIPLJLPCLBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2EB0", Offset = "0x1CE1AB0", VA = "0x181CE2EB0", Slot = "4")]
	private float KDFHBCBLAKC([In] float3 IIPLJLPCLBC)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BNANMPPBDAP : HOGKIDBILFB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15B07A0", Offset = "0x15AF3A0", VA = "0x1815B07A0")]
	public int DAAPFEJGKCA([In] int3 IIPLJLPCLBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x15B07A0", Offset = "0x15AF3A0", VA = "0x1815B07A0", Slot = "4")]
	private int KAKLJJHOCEG([In] int3 IIPLJLPCLBC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MAOBDCPGELG : HOGKIDBILFB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AC20D0", Offset = "0x6AC0CD0", VA = "0x186AC20D0")]
	public int DAAPFEJGKCA([In] int3 IIPLJLPCLBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC20D0", Offset = "0x6AC0CD0", VA = "0x186AC20D0", Slot = "4")]
	private int KAKLJJHOCEG([In] int3 IIPLJLPCLBC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FGPECDFAFCG : HOGKIDBILFB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x175E3F0", Offset = "0x175CFF0", VA = "0x18175E3F0")]
	public int DAAPFEJGKCA([In] int3 IIPLJLPCLBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x175E3F0", Offset = "0x175CFF0", VA = "0x18175E3F0", Slot = "4")]
	private int KAKLJJHOCEG([In] int3 IIPLJLPCLBC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PCPHEIGDKFP : KOIKNKLCNMD
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
	public PCPHEIGDKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class JDFKAEDBCDL : SystemBase, ABNHDHBMEHA
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1CC0", Offset = "0x6AC08C0", VA = "0x186AC1CC0")]
	public JobHandle FOFMAEDFOBI(ReadOnlySpan<int> AINFDDDGJEL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B6F0", Offset = "0x2B9A2F0", VA = "0x182B9B6F0")]
	public void PMNKAJNMBFB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BDA0", Offset = "0x2B9A9A0", VA = "0x182B9BDA0")]
	public JobHandle PMNKAJNMBFB<T>(JobHandle MJBLPCEDGPJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1DF0", Offset = "0x6AC09F0", VA = "0x186AC1DF0")]
	public JobHandle PMNKAJNMBFB(ReadOnlySpan<int> AINFDDDGJEL, JobHandle MJBLPCEDGPJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B6F0", Offset = "0x2B9A2F0", VA = "0x182B9B6F0")]
	public void OOKNPJCCGGN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B530", Offset = "0x2B9A130", VA = "0x182B9B530")]
	public JobHandle OOKNPJCCGGN<T>(JobHandle MJBLPCEDGPJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1D30", Offset = "0x6AC0930", VA = "0x186AC1D30")]
	public ComponentDataFromEntity KIMCLGADFED(int MEKCIDKBALP, bool IECLGADGBHI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1D10", Offset = "0x6AC0910", VA = "0x186AC1D10")]
	public EntityExistenceLookupByEntity HLKCJEJLIPE()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1E60", Offset = "0x6AC0A60", VA = "0x186AC1E60", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
	protected JDFKAEDBCDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class LIPOAMNLOCF : JDFKAEDBCDL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AC20A0", Offset = "0x6AC0CA0", VA = "0x186AC20A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
	protected LIPOAMNLOCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JKELFIOJNEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class AELHBGCPBND : EntityCommandBufferSystem, ABNHDHBMEHA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
	protected AELHBGCPBND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HOGKIDBILFB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DAAPFEJGKCA([In] TFrom IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OINLNHLFNOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGNNJGEHJMM(T IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct JOPMNDGIPHJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> PBGFKAHLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer MLHJKLJBLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes HFDDIFHJOMB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1FA0", Offset = "0x6AC0BA0", VA = "0x186AC1FA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct PLPPGBEGCDB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> PBGFKAHLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer MLHJKLJBLJG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2520", Offset = "0x6AC1120", VA = "0x186AC2520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct MDNNAIJMKFD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> PBGFKAHLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer MLHJKLJBLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType KBNNHPIJJEO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC20E0", Offset = "0x6AC0CE0", VA = "0x186AC20E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct GEMKLDMHEAD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> PBGFKAHLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> JGFKFMMOAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer MLHJKLJBLJG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D30C90", Offset = "0x3D2F890", VA = "0x183D30C90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct HBHHNEECLBF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> PBGFKAHLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> COOBAOCKFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer MLHJKLJBLJG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct CCOLMAALHHA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> PBGFKAHLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T IIPLJLPCLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer MLHJKLJBLJG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5572B90", Offset = "0x5571790", VA = "0x185572B90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct BFKNLGLAIBD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HOGKIDBILFB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> FBNPJDLKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> KNPHIBHJLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap OBNFAOABLKL;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct CGKLFOPLHIP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity NCIPKKGKEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> FBNPJDLKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> KNPHIBHJLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int LFHNAMIABLI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AC15D0", Offset = "0x6AC01D0", VA = "0x186AC15D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct FMOFFJEDJCM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EECOJKANCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> FBNPJDLKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> EGDPMHDIPLE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct IDBIMGCCNPE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HOGKIDBILFB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> MHACMFOPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> KNPHIBHJLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap OBNFAOABLKL;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct FOMCBKCOHOG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NADIOFPMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> PJKEODCCFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> OPCKFMPCKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct MKMNFPJEENK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NADIOFPMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> PJKEODCCFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> OPCKFMPCKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4491760", Offset = "0x4490360", VA = "0x184491760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BLPEGLMJKFJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> FBNPJDLKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> EGDPMHDIPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> JCFGPFAFJCD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4E90560", Offset = "0x4E8F160", VA = "0x184E90560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct APCEAHFIJJB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HOGKIDBILFB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> FBNPJDLKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> EGDPMHDIPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> JCFGPFAFJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap OBNFAOABLKL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct NOLDDLMBGDC<T, TPredicate> : IJob where T : struct where TPredicate : struct, OINLNHLFNOA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> FBNPJDLKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> HMEGCOJAJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> ACOLDHADPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate OBNFAOABLKL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct EEKCNPKEHNN<T, TPredicate> : IJob where T : struct where TPredicate : struct, OINLNHLFNOA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> FBNPJDLKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> EGDPMHDIPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate OBNFAOABLKL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GCEAEDCAOEG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity NADIOFPMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> PJKEODCCFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> LHPLHMKFHOP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1A50", Offset = "0x6AC0650", VA = "0x186AC1A50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct ENBOPFIDBMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity NADIOFPMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> PJKEODCCFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> LHPLHMKFHOP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC19A0", Offset = "0x6AC05A0", VA = "0x186AC19A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BCIKCGHCCFP
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class CDANBJCDGAH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2951AA0", Offset = "0x29506A0", VA = "0x182951AA0")]
	public static bool AMKPAJKKAGC<T>(this NativeArray<Entity> PJKEODCCFLG, EntityManager LHOMFPBLGHH, Allocator MJBDBDLLDBK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JOLMGDNCOPJ
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JEHGFEBKCBP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public JEHGFEBKCBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NMOKJNAPDMJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public NMOKJNAPDMJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> ADMFAEOMMEB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1F10", Offset = "0x6AC0B10", VA = "0x186AC1F10")]
	public JOLMGDNCOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DOGMDCICMMI
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AKKPDHNNCIK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct JILKICPGDAJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct JMELIBCDBLM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal JILKICPGDAJ<TFrom> DELFIACNBGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> IOFJKAICIIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct EPPIENGPKJD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct DPJEAHBHAFB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal EPPIENGPKJD<TFrom> DELFIACNBGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> IOFJKAICIIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct OMMDMDEPHAB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct HKLLPFJBNBF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal OMMDMDEPHAB<TFrom> DELFIACNBGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> IOFJKAICIIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct OBBBDLKAGCB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct HODBFEPCCIE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal OBBBDLKAGCB<TFrom> DELFIACNBGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> IOFJKAICIIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IKENFADGEBE
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HELEGFDJAPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B3DAD0", Offset = "0x2B3C6D0", VA = "0x182B3DAD0")]
	public static NativeList<T> HKFOABGBCDP<T>(this NativeArray<T> OMOKGINFCKM, Allocator MJBDBDLLDBK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class AACEMGAJAPN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CNLLBPIINBE
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x295D510", Offset = "0x295C110", VA = "0x18295D510")]
	[CEBJDOMOENP]
	public static JobHandle GDNHIMGELDP<T>(this EntityCommandBufferSystem AHOMHHKLBKF, NativeArrayAsync<Entity> PBGFKAHLPAM, NativeArrayAsync<T> JGFKFMMOAJO, [Optional] JobHandle IJJKACONAFJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x295D7C0", Offset = "0x295C3C0", VA = "0x18295D7C0")]
	[CEBJDOMOENP]
	public static JobHandle GDNHIMGELDP<T>(this EntityCommandBufferSystem AHOMHHKLBKF, NativeArrayAsync<Entity> PBGFKAHLPAM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x295D690", Offset = "0x295C290", VA = "0x18295D690")]
	[CEBJDOMOENP]
	public static JobHandle GDNHIMGELDP<T>(this EntityCommandBufferSystem AHOMHHKLBKF, NativeArray<Entity> PBGFKAHLPAM, [Optional] JobHandle IJJKACONAFJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1820", Offset = "0x6AC0420", VA = "0x186AC1820")]
	[CEBJDOMOENP]
	public static JobHandle GDNHIMGELDP(this EntityCommandBufferSystem AHOMHHKLBKF, NativeArray<Entity> PBGFKAHLPAM, ComponentTypes HFDDIFHJOMB, [Optional] JobHandle IJJKACONAFJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AC16D0", Offset = "0x6AC02D0", VA = "0x186AC16D0")]
	[CEBJDOMOENP]
	public static JobHandle GDNHIMGELDP(this EntityCommandBufferSystem AHOMHHKLBKF, EntityCommandBuffer MLHJKLJBLJG, NativeArray<Entity> PBGFKAHLPAM, ComponentTypes HFDDIFHJOMB, [Optional] JobHandle IJJKACONAFJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BOIIKEJKGJN
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28F7390", Offset = "0x28F5F90", VA = "0x1828F7390")]
	[CEBJDOMOENP]
	public static JobHandle JLJGJCLNHAP<T>(this EntityCommandBufferSystem AHOMHHKLBKF, EntityCommandBuffer MLHJKLJBLJG, EntityQuery PJOIAACICMN, T IIPLJLPCLBC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NPCHMBOFACE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2160", Offset = "0x6AC0D60", VA = "0x186AC2160")]
	[CEBJDOMOENP]
	public static JobHandle DABKOIGBNGL(this EntityCommandBufferSystem AHOMHHKLBKF, NativeList<Entity> PBGFKAHLPAM, [Optional] JobHandle IJJKACONAFJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC22F0", Offset = "0x6AC0EF0", VA = "0x186AC22F0")]
	[CEBJDOMOENP]
	public static JobHandle DABKOIGBNGL(this EntityCommandBufferSystem AHOMHHKLBKF, NativeArrayAsync<Entity> PBGFKAHLPAM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GGJIDHOPADJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DNHGFCDEAHF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x29978D0", Offset = "0x29964D0", VA = "0x1829978D0")]
	[CEBJDOMOENP]
	public static JobHandle OCPIBLKLLLL<T>(this EntityCommandBufferSystem AHOMHHKLBKF, NativeArray<Entity> PBGFKAHLPAM, NativeArray<T> JGFKFMMOAJO, JobHandle IJJKACONAFJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class EEBGLHLJAML
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x29AE5F0", Offset = "0x29AD1F0", VA = "0x1829AE5F0")]
	[CEBJDOMOENP]
	public static JobHandle EDCPDAAJNJB<T>(this EntityCommandBufferSystem AHOMHHKLBKF, NativeArray<Entity> PBGFKAHLPAM, T IIPLJLPCLBC, [Optional] JobHandle IJJKACONAFJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x29AE6E0", Offset = "0x29AD2E0", VA = "0x1829AE6E0")]
	[CEBJDOMOENP]
	public static JobHandle EDCPDAAJNJB<T>(this EntityCommandBufferSystem AHOMHHKLBKF, EntityCommandBuffer MLHJKLJBLJG, NativeArray<Entity> PBGFKAHLPAM, T IIPLJLPCLBC, [Optional] JobHandle IJJKACONAFJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PKLMOCONDLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class HGAKONADHBA
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E9F0", Offset = "0x2B3D5F0", VA = "0x182B3E9F0")]
	public static NativeArray<T> DKKMEJNAOJI<T>(this NativeList<Entity> OMOKGINFCKM, EntityManager LHOMFPBLGHH, Allocator MJBDBDLLDBK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E630", Offset = "0x2B3D230", VA = "0x182B3E630")]
	public static NativeArray<T> DKKMEJNAOJI<T>(this NativeArray<Entity> OMOKGINFCKM, EntityManager LHOMFPBLGHH, Allocator MJBDBDLLDBK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1AE0", Offset = "0x6AC06E0", VA = "0x186AC1AE0")]
	public static NativeArray<Entity> LHBKIAOIBAG(this NativeArray<Entity> OMOKGINFCKM, EntityManager LHOMFPBLGHH, ComponentType KBNNHPIJJEO, Allocator MJBDBDLLDBK = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B3ECA0", Offset = "0x2B3D8A0", VA = "0x182B3ECA0")]
	public static NativeArray<T> DPGKDGNIGNE<T>(this NativeArray<Entity> OMOKGINFCKM, EntityManager LHOMFPBLGHH, Allocator MJBDBDLLDBK = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BKPEDDOMKLO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct AAKLMEFBFFO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct JGBLDAFHLFJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AAKLMEFBFFO<TFrom> IOFJKAICIIH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> FBNPJDLKDOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct CMOCNOEPKAP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct FMMAKDAGDBC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public CMOCNOEPKAP<TFrom> IOFJKAICIIH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> FBNPJDLKDOG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct HFEKCMABPMO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct DKHOEGJEPEN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public HFEKCMABPMO<TFrom> IOFJKAICIIH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> FBNPJDLKDOG;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class AKGIKLLIJDO
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KADIJKEDEMJ
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct LCLJCPGLBFI : HOGKIDBILFB<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> NCPMJPEHKEK;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2090", Offset = "0x6AC0C90", VA = "0x186AC2090")]
		[BurstCompatible]
		public Entity DAAPFEJGKCA([In] Entity IIPLJLPCLBC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2090", Offset = "0x6AC0C90", VA = "0x186AC2090", Slot = "4")]
		private Entity LLJHHCHGBFN([In] Entity IIPLJLPCLBC)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FBMJHOFPOCF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct CCDKAGIIJNM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> HMEGCOJAJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> FBNPJDLKDOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct JHEDHOLJPEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> HMEGCOJAJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> FBNPJDLKDOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct EMBGCJNPCBE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> HMEGCOJAJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> FBNPJDLKDOG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class PJNAPDCDFOC
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class BAFCEBNGHJM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct DJJBNNJPAFC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> FBNPJDLKDOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct MONLFGHFMFN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> FBNPJDLKDOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct DOHGJLEIIHP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> FBNPJDLKDOG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct HCCNGNBOJBD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator MJBDBDLLDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> FBNPJDLKDOG;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DJGMEJJHPKN
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class DAMHMCJABLB
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2993000", Offset = "0x2991C00", VA = "0x182993000")]
	public static NativeList<Entity> EKOAKJHOCFN<T>(this NativeArray<Entity> PJKEODCCFLG, EntityManager LHOMFPBLGHH, Allocator MJBDBDLLDBK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DNEJJFMKNFM
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class AIDGKPJIGFB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct KCKGKHLGLCI<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> DKCMKELIAPN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
		public KCKGKHLGLCI(NativeArray<TSrc> DKCMKELIAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public DECLANGCJLL<TSrc, TValue> KCGEMMGHACH<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(DECLANGCJLL<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct DECLANGCJLL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> DKCMKELIAPN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
		public DECLANGCJLL(NativeArray<TSrc> DKCMKELIAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public FIEOAJBGGPM<TSrc, TValue, TSelector> GGGKDAGJAID<TSelector>() where TSelector : struct, HOGKIDBILFB<TSrc, TValue>
		{
			return default(FIEOAJBGGPM<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct FIEOAJBGGPM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HOGKIDBILFB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> DKCMKELIAPN;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
		public FIEOAJBGGPM(NativeArray<TSrc> DKCMKELIAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C2F0", Offset = "0x3C1AEF0", VA = "0x183C1C2F0")]
		public LGPPJDOPGNI<TSrc, TValue, TSelector> AEFHFAPFDPL()
		{
			return default(LGPPJDOPGNI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct FHALIINGJNB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HOGKIDBILFB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> DKCMKELIAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector AMMDGJKGOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int BAEBMIBABAE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3C14470", Offset = "0x3C13070", VA = "0x183C14470")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int ICIBDGPPAOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8DA130", Offset = "0x8D8D30", VA = "0x1808DA130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IEIDDKENJGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1FFE370", Offset = "0x1FFCF70", VA = "0x181FFE370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3C14650", Offset = "0x3C13250", VA = "0x183C14650")]
		public FHALIINGJNB(NativeArray<TSrc> DKCMKELIAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C144B0", Offset = "0x3C130B0", VA = "0x183C144B0")]
		public bool IMIKPNNMLJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3C14550", Offset = "0x3C13150", VA = "0x183C14550")]
		private TSrc PAIBFEHFPFK(int BFOGKPIBBMC)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C144C0", Offset = "0x3C130C0", VA = "0x183C144C0")]
		private TValue JMFNNAHLAHK()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct LGPPJDOPGNI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HOGKIDBILFB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private FHALIINGJNB<TSrc, TValue, TSelector> CHFIEPEFDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue EPJBLAINLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int IPBPNCHALEF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FDBPFLBCDGJ HIJMIBEGOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4277040", Offset = "0x4275C40", VA = "0x184277040")]
			get
			{
				return default(FDBPFLBCDGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FFJFKNCOJDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, FDBPFLBCDGJ range) KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4277080", Offset = "0x4275C80", VA = "0x184277080")]
			get
			{
				return default((TValue, FDBPFLBCDGJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x42772E0", Offset = "0x4275EE0", VA = "0x1842772E0")]
		public LGPPJDOPGNI(NativeArray<TSrc> DKCMKELIAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x384C1B0", Offset = "0x384ADB0", VA = "0x18384C1B0")]
		public LGPPJDOPGNI<TSrc, TValue, TSelector> DHNABIACCII()
		{
			return default(LGPPJDOPGNI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4277160", Offset = "0x4275D60", VA = "0x184277160")]
		public bool IMIKPNNMLJH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x31F0140", Offset = "0x31EED40", VA = "0x1831F0140")]
	public static KCKGKHLGLCI<T> BCDDGOEFFCN<T>(this NativeList<T> ELBBNOKMNCJ) where T : struct
	{
		return default(KCKGKHLGLCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
	public static KCKGKHLGLCI<T> BCDDGOEFFCN<T>(this NativeArray<T> DKCMKELIAPN) where T : struct
	{
		return default(KCKGKHLGLCI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class LLJFPCPJAEO
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct FBAFJBIAHLN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly DKCMKELIAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int IPBPNCHALEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int KOBDHKDFGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T EPJBLAINLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T AHPLPFPAAJG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FDBPFLBCDGJ HIJMIBEGOCC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3BBF980", Offset = "0x3BBE580", VA = "0x183BBF980")]
			get
			{
				return default(FDBPFLBCDGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T FFJFKNCOJDI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x38B2870", Offset = "0x38B1470", VA = "0x1838B2870")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, FDBPFLBCDGJ) KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3BBF9D0", Offset = "0x3BBE5D0", VA = "0x183BBF9D0")]
			get
			{
				return default((T, FDBPFLBCDGJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3BBFF90", Offset = "0x3BBEB90", VA = "0x183BBFF90")]
		public FBAFJBIAHLN(NativeArray<T> DKCMKELIAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3BBF990", Offset = "0x3BBE590", VA = "0x183BBF990")]
		public FBAFJBIAHLN<T> DHNABIACCII()
		{
			return default(FBAFJBIAHLN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3BBFD30", Offset = "0x3BBE930", VA = "0x183BBFD30")]
		public bool IMIKPNNMLJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2A794A0", Offset = "0x2A780A0", VA = "0x182A794A0")]
		public GMFCGIJEBKH<T, TComparer> PMGAFHIPKOG<TComparer>([Optional] TComparer INGKGNELEMP) where TComparer : struct, IEqualityComparer<T>
		{
			return default(GMFCGIJEBKH<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GMFCGIJEBKH<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly DKCMKELIAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int IPBPNCHALEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int KOBDHKDFGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T EPJBLAINLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T AHPLPFPAAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer INGKGNELEMP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FDBPFLBCDGJ HIJMIBEGOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3BBF980", Offset = "0x3BBE580", VA = "0x183BBF980")]
			get
			{
				return default(FDBPFLBCDGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FFJFKNCOJDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x38B2870", Offset = "0x38B1470", VA = "0x1838B2870")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A150", Offset = "0x3D68D50", VA = "0x183D6A150")]
		public GMFCGIJEBKH(NativeArray<T>.ReadOnly DKCMKELIAPN, TComparer INGKGNELEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3D69F60", Offset = "0x3D68B60", VA = "0x183D69F60")]
		public bool IMIKPNNMLJH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2C18900", Offset = "0x2C17500", VA = "0x182C18900")]
	public static FBAFJBIAHLN<T> AEFHFAPFDPL<T>(this NativeArray<T> DKCMKELIAPN) where T : struct
	{
		return default(FBAFJBIAHLN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface AMNDFJBBFMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class GFAJCNJJMLC
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct LPKEPDEAIAC<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MAACHFAFHKE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public LPKEPDEAIAC<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC487C0", Offset = "0xC473C0", VA = "0x180C487C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BDCB20", Offset = "0x3BDB720", VA = "0x183BDCB20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public MAACHFAFHKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4463E10", Offset = "0x4462A10", VA = "0x184463E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4463FF0", Offset = "0x4462BF0", VA = "0x184463FF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> EOFIICFMNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream GKBJLEBFJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream EDHAHLEDNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf LEGDHLFEPNP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4297D80", Offset = "0x4296980", VA = "0x184297D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4297DC0", Offset = "0x42969C0", VA = "0x184297DC0", Slot = "4")]
	[IteratorStateMachine(typeof(LPKEPDEAIAC<>.MAACHFAFHKE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4297EC0", Offset = "0x4296AC0", VA = "0x184297EC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct AAEMCIPELPI<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] EBPAODHLEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf LEGDHLFEPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream GKBJLEBFJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream DPPANIJICPO;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CCFE40", Offset = "0x3CCEA40", VA = "0x183CCFE40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PNNMNDCAFEI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream GKBJLEBFJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream EDHAHLEDNOK;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AC25D0", Offset = "0x6AC11D0", VA = "0x186AC25D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct PDCOJLFMOEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] EBPAODHLEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GKBJLEBFJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream DPPANIJICPO;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC23F0", Offset = "0x6AC0FF0", VA = "0x186AC23F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DNOPLCKAMKK
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class AIICJNDFNAA
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum PHKMGOCHJBI
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
internal static class ICGFBIGFPBE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class KNEBJPIKILJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public KNEBJPIKILJ()
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
