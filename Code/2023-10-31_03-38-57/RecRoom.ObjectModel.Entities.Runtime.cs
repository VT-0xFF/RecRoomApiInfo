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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D4B370", Offset = "0x5D4A770", VA = "0x185D4B370")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KJGCANAEBIG<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] JEOLPDGHPNH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D24080", Offset = "0x2D23480", VA = "0x182D24080")]
	public static void NLNDAIANPLK<TField>(int APOENOPNHBG, string LFAIHEECJFK, GLNELICFCEC KEKJMPCLMIK, [Out] PJFEPPCEHDM<TField> ANNDMLIIDLL) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D22AC0", Offset = "0x2D21EC0", VA = "0x182D22AC0")]
	public static void LHNMFCLBOFN<TField>(int APOENOPNHBG, string LFAIHEECJFK, [Out] OFMDLNJBPPF<TField> IHPCGCBJCJP) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LMCNKCICMMA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C600", Offset = "0x5D4BA00", VA = "0x185D4C600")]
	public static FieldInfo[] MGOCKMMCMJH(Type IJFAMCPOKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class AEAPDCHFPAE<View, Data> : FKMDJINEHMO where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType LKDDOHLALPE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type MJEOPJHABPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x346B9E0", Offset = "0x346ADE0", VA = "0x18346B9E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int MPGOKNIMLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x346BC80", Offset = "0x346B080", VA = "0x18346BC80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x346B860", Offset = "0x346AC60", VA = "0x18346B860")]
	public Data BDGJFCOAGAM(Entity FILKDLNBIJH)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View BEPMDIGLCAC(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2047FE0", Offset = "0x20473E0", VA = "0x182047FE0", Slot = "14")]
	public override T BEPMDIGLCAC<T>(Entity FILKDLNBIJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	protected AEAPDCHFPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class FKMDJINEHMO : GLNELICFCEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle PBBADNHBFMM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type MJEOPJHABPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int MPGOKNIMLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type HIAHHKOMALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD00", Offset = "0x8BA100", VA = "0x1808BAD00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int CNMDCGNENNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D4B740", Offset = "0x5D4AB40", VA = "0x185D4B740", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private EHEMBOJPNLK[] MFFFNOBDOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3D40", Offset = "0x3BF3140", VA = "0x183BF3D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual EHEMBOJPNLK[] FLPDMOCOECG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4B5C0", Offset = "0x5D4A9C0", VA = "0x185D4B5C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B390", Offset = "0x5D4A790", VA = "0x185D4B390")]
	public void FGBNJEBGKMH(EntityManager OKJDPAMBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T BEPMDIGLCAC<T>(Entity FILKDLNBIJH) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B4D0", Offset = "0x5D4A8D0", VA = "0x185D4B4D0", Slot = "8")]
	public (uint, uint) MBMGBIMPEOK(Entity FILKDLNBIJH)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B650", Offset = "0x5D4AA50", VA = "0x185D4B650", Slot = "9")]
	public bool OJNENBPOPJH(Entity FILKDLNBIJH, (uint order, uint change) FOIKACEEEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected FKMDJINEHMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OBJBHFNENIF
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MKCCIJEBDNJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CJHIPCBDNGG OPKIADLJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LLFOCGGLBGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HFFLOIKCHFC(Entity FILKDLNBIJH, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOBANOHCACN(Entity FILKDLNBIJH, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NFAGMLHKFHM(Entity FILKDLNBIJH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GHBBJOMOIKE(Entity FILKDLNBIJH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BJMIDNIMEPB<TComponentData, TValue> : MLCMPGDAIKL<TValue>, IDisposable where TComponentData : struct, MKCCIJEBDNJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FOOIDGKFNBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> KEKPLKHNJAG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EJNDKIEMIHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6030", Offset = "0x2EC5430", VA = "0x182EC6030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x33EC6A0", Offset = "0x33EBAA0", VA = "0x1833EC6A0")]
		public bool KBEOLJIECPE([Out] TValue EOHMJBFGDPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x33EC5F0", Offset = "0x33EB9F0", VA = "0x1833EC5F0")]
		public void INMJBKGEACO(object KJAGMGIFCEM, TValue EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x33EC490", Offset = "0x33EB890", VA = "0x1833EC490")]
		public bool BLFHNKIOGCM(object KJAGMGIFCEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x33EC510", Offset = "0x33EB910", VA = "0x1833EC510")]
		public int HIMPNBFPDHB(object KJAGMGIFCEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x33EC790", Offset = "0x33EBB90", VA = "0x1833EC790")]
		public FOOIDGKFNBJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<FOOIDGKFNBJ> CIDHDCEJLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private OIFHGLGDACC<CJHIPCBDNGG, FOOIDGKFNBJ> FELAMHJIICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4849A00", Offset = "0x4848E00", VA = "0x184849A00")]
	public BJMIDNIMEPB(EntityManager OKJDPAMBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4849380", Offset = "0x4848780", VA = "0x184849380", Slot = "4")]
	public void HFFLOIKCHFC(Entity FILKDLNBIJH, object KJAGMGIFCEM, TValue EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48494C0", Offset = "0x48488C0", VA = "0x1848494C0", Slot = "5")]
	public bool JOBANOHCACN(Entity FILKDLNBIJH, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4849660", Offset = "0x4848A60", VA = "0x184849660", Slot = "6")]
	public bool KBEOLJIECPE(Entity FILKDLNBIJH, [Out] TValue EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4849340", Offset = "0x4848740", VA = "0x184849340", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48492B0", Offset = "0x48486B0", VA = "0x1848492B0")]
	private void CENFAOKNDNG(FOOIDGKFNBJ NNHJPDEMMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4849940", Offset = "0x4848D40", VA = "0x184849940")]
	private bool PICDDNNPMIC(Entity FILKDLNBIJH, [Out] CJHIPCBDNGG DELBIPHKFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4849850", Offset = "0x4848C50", VA = "0x184849850")]
	private void LJKHKEMICIG(Entity FILKDLNBIJH, CJHIPCBDNGG DELBIPHKFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4849360", Offset = "0x4848760", VA = "0x184849360")]
	private bool EBEPLJHDGKH(CJHIPCBDNGG DELBIPHKFDD, [Out] FOOIDGKFNBJ NNHJPDEMMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4849760", Offset = "0x4848B60", VA = "0x184849760")]
	private FOOIDGKFNBJ LIEFEBJJBAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MLCMPGDAIKL<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFFLOIKCHFC(Entity FILKDLNBIJH, object KJAGMGIFCEM, TValue EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOBANOHCACN(Entity FILKDLNBIJH, object KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBEOLJIECPE(Entity FILKDLNBIJH, [Out] TValue EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CJHIPCBDNGG : KNNNCNBLDBG, IEquatable<CJHIPCBDNGG>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly CJHIPCBDNGG JCNACNONIMC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int CBNNNKAIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int EIHKBEAJCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200B5F0", VA = "0x18200C1F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51828C0", Offset = "0x5181CC0", VA = "0x1851828C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4ADA0", Offset = "0x5D4A1A0", VA = "0x185D4ADA0", Slot = "8")]
	public bool Equals(CJHIPCBDNGG LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4ADF0", Offset = "0x5D4A1F0", VA = "0x185D4ADF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HKALNAIIIGG<THasTokensTag> : LLFOCGGLBGJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, CJHIPCBDNGG> CEPFPJGLIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> CIDHDCEJLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OIFHGLGDACC<CJHIPCBDNGG, HashSet<object>> FELAMHJIICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem PAKMEGEOHCF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3568770", Offset = "0x3567B70", VA = "0x183568770")]
	public HKALNAIIIGG(EntityManager OKJDPAMBACM, EntityCommandBufferSystem PAKMEGEOHCF, FBKCBHAMJJJ HKBAJKANCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3565FE0", Offset = "0x35653E0", VA = "0x183565FE0", Slot = "4")]
	public bool HFFLOIKCHFC(Entity FILKDLNBIJH, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3566980", Offset = "0x3565D80", VA = "0x183566980", Slot = "5")]
	public bool JOBANOHCACN(Entity FILKDLNBIJH, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35673D0", Offset = "0x35667D0", VA = "0x1835673D0", Slot = "6")]
	public bool NFAGMLHKFHM(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3567320", Offset = "0x3566720", VA = "0x183567320", Slot = "9")]
	public bool NFAGMLHKFHM(CJHIPCBDNGG DELBIPHKFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3565820", Offset = "0x3564C20", VA = "0x183565820", Slot = "7")]
	public bool GHBBJOMOIKE(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3565280", Offset = "0x3564680", VA = "0x183565280", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3564BD0", Offset = "0x3563FD0", VA = "0x183564BD0")]
	private void CENFAOKNDNG(HashSet<object> NNHJPDEMMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3567C80", Offset = "0x3567080", VA = "0x183567C80")]
	private bool PICDDNNPMIC(Entity FILKDLNBIJH, [Out] CJHIPCBDNGG DELBIPHKFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3567A20", Offset = "0x3566E20", VA = "0x183567A20")]
	private bool PFKNBECEPGI(Entity FILKDLNBIJH, [Out] CJHIPCBDNGG DELBIPHKFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35650F0", Offset = "0x35644F0", VA = "0x1835650F0")]
	private void CLEILMHNDKO(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3566370", Offset = "0x3565770", VA = "0x183566370")]
	private void HOEANMPLBFJ(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3567FF0", Offset = "0x35673F0", VA = "0x183567FF0")]
	private void PMANADGLDEE(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35670F0", Offset = "0x35664F0", VA = "0x1835670F0")]
	private void LJKHKEMICIG(Entity FILKDLNBIJH, CJHIPCBDNGG DELBIPHKFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35654C0", Offset = "0x35648C0", VA = "0x1835654C0")]
	private bool GEFNFDIJDKI(CJHIPCBDNGG DELBIPHKFDD, [Out] HashSet<object> NNHJPDEMMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3566E70", Offset = "0x3566270", VA = "0x183566E70")]
	private HashSet<object> LIEFEBJJBAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JGEJMBMHGCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HAJJCCPKKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int APBJNEFOGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int OGEHFGGOGMJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DHODODFJCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200B5F0", VA = "0x18200C1F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x51828C0", Offset = "0x5181CC0", VA = "0x1851828C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OBDOJPHIBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HJCPNAFFHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D4BFC0", Offset = "0x5D4B3C0", VA = "0x185D4BFC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D4BFD0", Offset = "0x5D4B3D0", VA = "0x185D4BFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
	private HAJJCCPKKFD(int APBJNEFOGOC, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C74400", Offset = "0x1C73800", VA = "0x181C74400")]
	public static HAJJCCPKKFD FEEBFEKMNLK(int APBJNEFOGOC, int OGEHFGGOGMJ)
	{
		return default(HAJJCCPKKFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BFE0", Offset = "0x5D4B3E0", VA = "0x185D4BFE0")]
	public static HAJJCCPKKFD KPEKKFKFOPB(int NBBMHNNJHFB, int ICPDBPOHHIC)
	{
		return default(HAJJCCPKKFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BFF0", Offset = "0x5D4B3F0", VA = "0x185D4BFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LGKAALJHBGO : NLKEGPPPDFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D30260", Offset = "0x5D2F660", VA = "0x185D30260")]
	public float DBILEHAJOGJ([In] float3 EOHMJBFGDPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D30260", Offset = "0x5D2F660", VA = "0x185D30260", Slot = "4")]
	private float OJIIOFAPGPA([In] float3 EOHMJBFGDPD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HFNLMFOIKDD : NLKEGPPPDFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D30920", Offset = "0x5D2FD20", VA = "0x185D30920")]
	public float DBILEHAJOGJ([In] float3 EOHMJBFGDPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D30920", Offset = "0x5D2FD20", VA = "0x185D30920", Slot = "4")]
	private float OJIIOFAPGPA([In] float3 EOHMJBFGDPD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LOOAKMMHOOP : NLKEGPPPDFA<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x18BB1A0", Offset = "0x18BA5A0", VA = "0x1818BB1A0")]
	public float DBILEHAJOGJ([In] float3 EOHMJBFGDPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x18BB1A0", Offset = "0x18BA5A0", VA = "0x1818BB1A0", Slot = "4")]
	private float OJIIOFAPGPA([In] float3 EOHMJBFGDPD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IGOHCOFJDHB : NLKEGPPPDFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x12203C0", Offset = "0x121F7C0", VA = "0x1812203C0")]
	public int DBILEHAJOGJ([In] int3 EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12203C0", Offset = "0x121F7C0", VA = "0x1812203C0", Slot = "4")]
	private int GPLNIBGDJEP([In] int3 EOHMJBFGDPD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct POGGAIOAJLC : NLKEGPPPDFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D35790", Offset = "0x5D34B90", VA = "0x185D35790")]
	public int DBILEHAJOGJ([In] int3 EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D35790", Offset = "0x5D34B90", VA = "0x185D35790", Slot = "4")]
	private int GPLNIBGDJEP([In] int3 EOHMJBFGDPD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IIMFABMNIIE : NLKEGPPPDFA<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14EFA60", Offset = "0x14EEE60", VA = "0x1814EFA60")]
	public int DBILEHAJOGJ([In] int3 EOHMJBFGDPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x14EFA60", Offset = "0x14EEE60", VA = "0x1814EFA60", Slot = "4")]
	private int GPLNIBGDJEP([In] int3 EOHMJBFGDPD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GEAOPPHOIJM : ICCFEBIBGCG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type MHCKNPKBGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type DIDMPHBKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B8B0", Offset = "0x5D4ACB0", VA = "0x185D4B8B0")]
	public GEAOPPHOIJM(Type AABDACBIJEC, Type IMIEHOHKKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JKMDIICCHDE : ICCFEBIBGCG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type DIDMPHBKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C69790", Offset = "0x5C68B90", VA = "0x185C69790")]
	public JKMDIICCHDE(Type IMIEHOHKKGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NDGCLKCPJNE : ICCFEBIBGCG
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public NDGCLKCPJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class JJCHEBMOMOG<Data> : LDAMFPBECCI where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data BDJLOIHNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3845D50", Offset = "0x3845150", VA = "0x183845D50", Slot = "8")]
	protected virtual bool MKDBEDAHKLG(ReadOnlySpan<Data> DLBJPBJAFGL, GILPKIILCCE GCLEDKPLBKL, [Out] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "9")]
	protected virtual bool FMFPJIDGABL(int FOIKACEEEGH, Span<Data> DLBJPBJAFGL, [In] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3845C90", Offset = "0x3845090", VA = "0x183845C90", Slot = "5")]
	internal sealed override bool MKDBEDAHKLG(Unity.Entities.Chunk KGJGPOJOPDJ, int BOMDCPNEPCD, GILPKIILCCE GCLEDKPLBKL, [Out] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3845940", Offset = "0x3844D40", VA = "0x183845940", Slot = "6")]
	internal sealed override bool FMFPJIDGABL(int FOIKACEEEGH, Unity.Entities.Chunk KGJGPOJOPDJ, int BOMDCPNEPCD, [In] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AA40", Offset = "0x2D19E40", VA = "0x182D1AA40")]
	protected FGDLAMGJGEB<Protobuf> PEKMMEIKHKI<Protobuf>(ReadOnlySpan<Data> DLBJPBJAFGL) where Protobuf : IMessage, new()
	{
		return default(FGDLAMGJGEB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A9C0", Offset = "0x2D19DC0", VA = "0x182D1A9C0")]
	protected HMCBJPCNJJP<Protobuf> DAKHCJIOHPD<Protobuf>(ReadOnlySpan<byte> EGFEGIMIICO, ReadOnlySpan<Data> DLBJPBJAFGL, Action<Protobuf> CPNAAPDBILD) where Protobuf : IMessage, new()
	{
		return default(HMCBJPCNJJP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	protected JJCHEBMOMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class LDAMFPBECCI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int EIHKBEAJCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C5F0", Offset = "0x5D4B9F0", VA = "0x185D4C5F0", Slot = "5")]
	internal virtual bool MKDBEDAHKLG(Unity.Entities.Chunk KGJGPOJOPDJ, int BOMDCPNEPCD, GILPKIILCCE GCLEDKPLBKL, [Out] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "6")]
	internal virtual bool FMFPJIDGABL(int FOIKACEEEGH, Unity.Entities.Chunk KGJGPOJOPDJ, int BOMDCPNEPCD, [In] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected LDAMFPBECCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GFPEONJDBNM
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class EJPAANLNCMB : SystemBase, GFPEONJDBNM
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B280", Offset = "0x5D4A680", VA = "0x185D4B280")]
	public ComponentDataFromEntity DMJEPGCBGHH(int PIEALCBDGOA, bool BGPIOJOGCKM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B340", Offset = "0x5D4A740", VA = "0x185D4B340")]
	public EntityExistenceLookupByEntity OMFHDPHBPKM()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B360", Offset = "0x5D4A760", VA = "0x185D4B360", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	protected EJPAANLNCMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class BNNLPOAHIHI : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D4AD70", Offset = "0x5D4A170", VA = "0x185D4AD70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	protected BNNLPOAHIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class KAJKAPMFNNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class EJJGNIPMDNB : DEECDILBOJC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B230", Offset = "0x5D4A630", VA = "0x185D4B230", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase PKMFPDDAKEK();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B1E0", Offset = "0x5D4A5E0", VA = "0x185D4B1E0")]
	protected ComponentSystemBase IIIODFCEEFH(params ComponentSystemBase[] LCDKABNLFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2256E30", Offset = "0x2256230", VA = "0x182256E30")]
	protected ComponentSystemBase IIIODFCEEFH<T>(params ComponentSystemBase[] LCDKABNLFIH) where T : DEECDILBOJC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2256D60", Offset = "0x2256160", VA = "0x182256D60")]
	protected ComponentSystemBase DJLDLJGEOHJ<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2256D60", Offset = "0x2256160", VA = "0x182256D60")]
	protected ComponentSystemBase GFJPJHELAHB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B190", Offset = "0x5D4A590", VA = "0x185D4B190")]
	protected ComponentSystemBase FJEAOKKJOMG(params SystemHandleUntyped[] LCDKABNLFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2256DA0", Offset = "0x22561A0", VA = "0x182256DA0")]
	protected ComponentSystemBase FJEAOKKJOMG<T>(params SystemHandleUntyped[] LCDKABNLFIH) where T : DEECDILBOJC, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2256EC0", Offset = "0x22562C0", VA = "0x182256EC0")]
	protected SystemHandleUntyped POIMPBFFJMA<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D4AE70", Offset = "0x5D4A270", VA = "0x185D4AE70")]
	protected EJJGNIPMDNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DEECDILBOJC : LBKGDCALPNM
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D4AE40", Offset = "0x5D4A240", VA = "0x185D4AE40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D4AE70", Offset = "0x5D4A270", VA = "0x185D4AE70")]
	public DEECDILBOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class LBKGDCALPNM : ComponentSystemGroup, GFPEONJDBNM
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D4AE70", Offset = "0x5D4A270", VA = "0x185D4AE70")]
	protected LBKGDCALPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class AOKLLJPGCEJ : EntityCommandBufferSystem, GFPEONJDBNM
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	protected AOKLLJPGCEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NLKEGPPPDFA<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DBILEHAJOGJ([In] TFrom EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ELIPJMCFOMJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJMDOGMHFGF(T EOHMJBFGDPD);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct PCFMCMIGMBF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes NAKAOODNAGC;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C7C0", Offset = "0x5D4BBC0", VA = "0x185D4C7C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JEKLNKKFGCI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C330", Offset = "0x5D4B730", VA = "0x185D4C330", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct OOGADCLPHDC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType HDDPJGDCFBD;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C740", Offset = "0x5D4BB40", VA = "0x185D4C740", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct CBHKOLGBLNE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4AADAA0", Offset = "0x4AACEA0", VA = "0x184AADAA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct EIKFBDPBOBI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> PKDIDJEMOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct LDPJKIDLKFH<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T EOHMJBFGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3975B90", Offset = "0x3974F90", VA = "0x183975B90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct IKGFPNLIGJK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NLKEGPPPDFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> ECABAMJJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> OPEHGPLNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap GMCEKENFDDF;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct FMHKGEDKALD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity EOGBBJDDOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> ECABAMJJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> OPEHGPLNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int ICHEEHJMLFO;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B7B0", Offset = "0x5D4ABB0", VA = "0x185D4B7B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct HHHLHHDNEPD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JKLOGAIJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> ECABAMJJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> GPPECKKCIMK;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct EDPJBJNNHKA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NLKEGPPPDFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> GKBDPANPPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> OPEHGPLNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap GMCEKENFDDF;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct MKLDJGAHKGF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IMIEHOHKKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> CIKOOGCEBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> LIEBGFJDHAK;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct NKBLJJFCGJK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IMIEHOHKKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> CIKOOGCEBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> LIEBGFJDHAK;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C10D60", Offset = "0x3C10160", VA = "0x183C10D60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct ADHAMGNMAJM<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> ECABAMJJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> GPPECKKCIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> OCPCJNPGDLF;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x34623D0", Offset = "0x34617D0", VA = "0x1834623D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct PLFLMAAAGOO<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NLKEGPPPDFA<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> ECABAMJJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> GPPECKKCIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> OCPCJNPGDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap GMCEKENFDDF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct OGLGMKPFEKB<T, TPredicate> : IJob where T : struct where TPredicate : struct, ELIPJMCFOMJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> ECABAMJJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> OAKCOMMMEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> KHJDAGMPMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate GMCEKENFDDF;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE78F0", Offset = "0x3CE6CF0", VA = "0x183CE78F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct NEPEFGDNIOH<T, TPredicate> : IJob where T : struct where TPredicate : struct, ELIPJMCFOMJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> ECABAMJJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> GPPECKKCIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate GMCEKENFDDF;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct GOFJEJGCFGH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity IMIEHOHKKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> CIKOOGCEBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> JOPINHPDIJL;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BF30", Offset = "0x5D4B330", VA = "0x185D4BF30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct BKKPJEPIBLE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity IMIEHOHKKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> CIKOOGCEBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> JOPINHPDIJL;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4ACE0", Offset = "0x5D4A0E0", VA = "0x185D4ACE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OLDFLOOBHGP
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CNCGMDNBFJI
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x220D190", Offset = "0x220C590", VA = "0x18220D190")]
	public static bool OLOCJDOFNDI<T>(this NativeArray<Entity> CIKOOGCEBCP, EntityManager OKJDPAMBACM, Allocator KIKFOGPECEC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class GENPIBMGKNF
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LBIOPJLKLEF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public LBIOPJLKLEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class GCIBLIDNBLM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public GCIBLIDNBLM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> HJNJIAMGMDK;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B900", Offset = "0x5D4AD00", VA = "0x185D4B900")]
	public GENPIBMGKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JLEGIBNIJAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CMHFLOIABFG
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct GDPKOIGLOHP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct CHIBNBMDELI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal GDPKOIGLOHP<TFrom> EBFCMPBKGBM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> ABNGLIALIJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct CJGPPCFDJIP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct MDHKNDGGDCD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal CJGPPCFDJIP<TFrom> EBFCMPBKGBM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> ABNGLIALIJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct KNBKDNOEFCL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct EGBIBGNPEDN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal KNBKDNOEFCL<TFrom> EBFCMPBKGBM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> ABNGLIALIJA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct CBJCLAPABLC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct OENANDEEFOL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal CBJCLAPABLC<TFrom> EBFCMPBKGBM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> ABNGLIALIJA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BMFAPNGKIFA
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NLCEMKAGOFA
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x24E3F00", Offset = "0x24E3300", VA = "0x1824E3F00")]
	public static NativeList<T> LOEGPIGHHEE<T>(this NativeList<T> ODOODFCLNFJ, Allocator KIKFOGPECEC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x24E3D80", Offset = "0x24E3180", VA = "0x1824E3D80")]
	public static NativeList<T> LOEGPIGHHEE<T>(this NativeArray<T> ODOODFCLNFJ, Allocator KIKFOGPECEC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ILFIMFIAOOK
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GNAFDBIFFGB
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x239FA30", Offset = "0x239EE30", VA = "0x18239FA30")]
	[DIBACGOADBB]
	public static JobHandle GGFHGOOGDEJ<T>(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArrayAsync<Entity> BAPHNAADJCK, NativeArrayAsync<T> GHFAAPNAFDE, [Optional] JobHandle MCHBCAPEEON) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x239FE10", Offset = "0x239F210", VA = "0x18239FE10")]
	[DIBACGOADBB]
	public static JobHandle GGFHGOOGDEJ<T>(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArrayAsync<Entity> BAPHNAADJCK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x239FB90", Offset = "0x239EF90", VA = "0x18239FB90")]
	[DIBACGOADBB]
	public static JobHandle GGFHGOOGDEJ<T>(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArray<Entity> BAPHNAADJCK, [Optional] JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BC70", Offset = "0x5D4B070", VA = "0x185D4BC70")]
	[DIBACGOADBB]
	public static JobHandle GGFHGOOGDEJ(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArray<Entity> BAPHNAADJCK, ComponentTypes NAKAOODNAGC, [Optional] JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BDE0", Offset = "0x5D4B1E0", VA = "0x185D4BDE0")]
	[DIBACGOADBB]
	public static JobHandle GGFHGOOGDEJ(this EntityCommandBufferSystem PAKMEGEOHCF, EntityCommandBuffer ECEKOIAALDA, NativeArray<Entity> BAPHNAADJCK, ComponentTypes NAKAOODNAGC, [Optional] JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OPGAKCJKJEA
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25069A0", Offset = "0x2505DA0", VA = "0x1825069A0")]
	[DIBACGOADBB]
	public static JobHandle GMKOEFOLKJA<T>(this EntityCommandBufferSystem PAKMEGEOHCF, EntityCommandBuffer ECEKOIAALDA, EntityQuery NGALCCNNOFF, T EOHMJBFGDPD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EGBOJNEBNAC
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B000", Offset = "0x5D4A400", VA = "0x185D4B000")]
	[DIBACGOADBB]
	public static JobHandle PDALMGDFLGG(this EntityCommandBufferSystem PAKMEGEOHCF, NativeList<Entity> BAPHNAADJCK, [Optional] JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D4AF00", Offset = "0x5D4A300", VA = "0x185D4AF00")]
	[DIBACGOADBB]
	public static JobHandle PDALMGDFLGG(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArrayAsync<Entity> BAPHNAADJCK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class JINPEHJMNHP
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x23F4AB0", Offset = "0x23F3EB0", VA = "0x1823F4AB0")]
	public static void JPKLAGLFELH<T>(this EntityCommandBufferSystem PAKMEGEOHCF, EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x23F4860", Offset = "0x23F3C60", VA = "0x1823F4860")]
	[DIBACGOADBB]
	public static JobHandle CHBAIDJGLPC<T>(this EntityCommandBufferSystem PAKMEGEOHCF, NativeListAsync<Entity> BAPHNAADJCK, [Optional] JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x23F4920", Offset = "0x23F3D20", VA = "0x1823F4920")]
	[DIBACGOADBB]
	public static JobHandle CHBAIDJGLPC<T>(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArrayAsync<Entity> BAPHNAADJCK, [Optional] JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class OPFHIJDBMOO
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x25068A0", Offset = "0x2505CA0", VA = "0x1825068A0")]
	[DIBACGOADBB]
	public static JobHandle HNBGPNDDALD<T>(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArray<Entity> BAPHNAADJCK, NativeArray<T> GHFAAPNAFDE, JobHandle MCHBCAPEEON) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KAIBDCOGIHE
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x241C360", Offset = "0x241B760", VA = "0x18241C360")]
	[DIBACGOADBB]
	public static JobHandle MCNAACKFFHE<T>(this EntityCommandBufferSystem PAKMEGEOHCF, NativeArray<Entity> BAPHNAADJCK, T EOHMJBFGDPD, [Optional] JobHandle MCHBCAPEEON) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x241C290", Offset = "0x241B690", VA = "0x18241C290")]
	[DIBACGOADBB]
	public static JobHandle MCNAACKFFHE<T>(this EntityCommandBufferSystem PAKMEGEOHCF, EntityCommandBuffer ECEKOIAALDA, NativeArray<Entity> BAPHNAADJCK, T EOHMJBFGDPD, [Optional] JobHandle MCHBCAPEEON) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class GBBJFNLPOOF
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2377F90", Offset = "0x2377390", VA = "0x182377F90")]
	public static NativeList<T> LOEGPIGHHEE<T>(NativeList<T> ODOODFCLNFJ, Allocator KIKFOGPECEC) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NCPKNPILNMO
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x24D1B20", Offset = "0x24D0F20", VA = "0x1824D1B20")]
	public static NativeArray<T> EJCPADJOBGD<T>(this NativeList<Entity> ODOODFCLNFJ, EntityManager OKJDPAMBACM, Allocator KIKFOGPECEC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x24D15E0", Offset = "0x24D09E0", VA = "0x1824D15E0")]
	public static NativeArray<T> EJCPADJOBGD<T>(this NativeArray<Entity> ODOODFCLNFJ, EntityManager OKJDPAMBACM, Allocator KIKFOGPECEC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class INJPPFAOBCH
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct EMIKMELAEKH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct ILJLBMJBEIO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public EMIKMELAEKH<TFrom> ABNGLIALIJA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> ECABAMJJGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct LPFMEBIFHKE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct MPBIBLGNNIB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public LPFMEBIFHKE<TFrom> ABNGLIALIJA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> ECABAMJJGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct ACKMCDBAHBM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct IBLCCHANCHD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public ACKMCDBAHBM<TFrom> ABNGLIALIJA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> ECABAMJJGIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class OLNLCGKLLDM
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HMEBGJCFGOO
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct IDBLGGGOEFB : NLKEGPPPDFA<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> LLILFOJBKNG;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D4C080", Offset = "0x5D4B480", VA = "0x185D4C080")]
		[BurstCompatible]
		public Entity DBILEHAJOGJ([In] Entity EOHMJBFGDPD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D4C080", Offset = "0x5D4B480", VA = "0x185D4C080", Slot = "4")]
		private Entity EMBDKNMEIPL([In] Entity EOHMJBFGDPD)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class IIIKIDEPGLD
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct NCONNKHMLCO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> OAKCOMMMEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> ECABAMJJGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct NJGAOEFCADG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> OAKCOMMMEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> ECABAMJJGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct EOACGKBBENE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> OAKCOMMMEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> ECABAMJJGIB;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D7D0", Offset = "0x2D0CBD0", VA = "0x182D0D7D0")]
		public NativeListAsync<Entity> BJMDOGMHFGF<TPredicate>() where TPredicate : struct, ELIPJMCFOMJ<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x23D4750", Offset = "0x23D3B50", VA = "0x1823D4750")]
	public static EOACGKBBENE<T> CGKBJMLHHGA<T>(this NativeArrayAsync<Entity> CIKOOGCEBCP, NativeArrayAsync<T> ODOODFCLNFJ, Allocator KIKFOGPECEC = Allocator.TempJob) where T : struct
	{
		return default(EOACGKBBENE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class ABAGAFFFCDI
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x29CC800", Offset = "0x29CBC00", VA = "0x1829CC800")]
	public static NativeListAsync<Entity> DOMGGBILMJN<T, TPredicate>(this NativeArrayAsync<T> ODOODFCLNFJ, NativeArrayAsync<Entity> CIKOOGCEBCP, Allocator KIKFOGPECEC = Allocator.TempJob) where T : struct where TPredicate : struct, ELIPJMCFOMJ<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29CC8C0", Offset = "0x29CBCC0", VA = "0x1829CC8C0")]
	private static NativeListAsync<Entity> ONCFMIKGADK<T, TPredicate>(NativeArrayAsync<T> FAEIPLOPLJD, NativeArrayAsync<Entity> CIKOOGCEBCP, int KIHHOMBMMEI, Allocator KIKFOGPECEC) where T : struct where TPredicate : struct, ELIPJMCFOMJ<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class ADOBPCKBBKI
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct CEHBAMKINFH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> ECABAMJJGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LGNPBNCNCOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> ECABAMJJGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct BEMBMCGHHLP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> ECABAMJJGIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct CIDBJLNFNKJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator KIKFOGPECEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> ECABAMJJGIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class HBKCPMIDPCA
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class JNAIMAEEGAO
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x23FD630", Offset = "0x23FCA30", VA = "0x1823FD630")]
	public static NativeList<Entity> FNJIAKHNCPP<T>(this NativeArray<Entity> CIKOOGCEBCP, EntityManager OKJDPAMBACM, Allocator KIKFOGPECEC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class OPBBFOFEEKI
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class EMBHIAFPCPB
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct IFPGAHMMLCJ<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> FFAHMFOPGLA;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C659E0", Offset = "0x1C64DE0", VA = "0x181C659E0")]
		public IFPGAHMMLCJ(NativeArray<TSrc> FFAHMFOPGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
		public EFHKADMEFJL<TSrc, TValue> HNJFFBBEHHE<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(EFHKADMEFJL<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct EFHKADMEFJL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> FFAHMFOPGLA;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C659E0", Offset = "0x1C64DE0", VA = "0x181C659E0")]
		public EFHKADMEFJL(NativeArray<TSrc> FFAHMFOPGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
		public IJDPIPFKEMD<TSrc, TValue, TSelector> DEMNFLBCGHP<TSelector>() where TSelector : struct, NLKEGPPPDFA<TSrc, TValue>
		{
			return default(IJDPIPFKEMD<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct IJDPIPFKEMD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NLKEGPPPDFA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> FFAHMFOPGLA;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C659E0", Offset = "0x1C64DE0", VA = "0x181C659E0")]
		public IJDPIPFKEMD(NativeArray<TSrc> FFAHMFOPGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x363B4C0", Offset = "0x363A8C0", VA = "0x18363B4C0")]
		public DKJDHGEGGBE<TSrc, TValue, TSelector> IIIODFCEEFH()
		{
			return default(DKJDHGEGGBE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct KFNFLECPKJG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NLKEGPPPDFA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> FFAHMFOPGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector JCLLCOOMNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int APOENOPNHBG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x38D5000", Offset = "0x38D4400", VA = "0x1838D5000")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int CBNNNKAIBOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C3200", Offset = "0x8C2600", VA = "0x1808C3200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int EKAAEPEENKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1C782F0", Offset = "0x1C776F0", VA = "0x181C782F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x38D5180", Offset = "0x38D4580", VA = "0x1838D5180")]
		public KFNFLECPKJG(NativeArray<TSrc> FFAHMFOPGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x38D5090", Offset = "0x38D4490", VA = "0x1838D5090")]
		public bool PEKPNEJHNNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x38D50A0", Offset = "0x38D44A0", VA = "0x1838D50A0")]
		private TSrc PPEJMPNGEON(int KEFLNPGBJEJ)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct DKJDHGEGGBE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NLKEGPPPDFA<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private KFNFLECPKJG<TSrc, TValue, TSelector> HBGFNOABMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue GMONIOGPIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int IDGHKCPGHHK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public HAJJCCPKKFD JLOJFICHJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x4CA1F60", Offset = "0x4CA1360", VA = "0x184CA1F60")]
			get
			{
				return default(HAJJCCPKKFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue NHIFAHKLPNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, HAJJCCPKKFD range) PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4CA1FA0", Offset = "0x4CA13A0", VA = "0x184CA1FA0")]
			get
			{
				return default((TValue, HAJJCCPKKFD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4CA21C0", Offset = "0x4CA15C0", VA = "0x184CA21C0")]
		public DKJDHGEGGBE(NativeArray<TSrc> FFAHMFOPGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x33D9C80", Offset = "0x33D9080", VA = "0x1833D9C80")]
		public DKJDHGEGGBE<TSrc, TValue, TSelector> JBKAHEPNGNA()
		{
			return default(DKJDHGEGGBE<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4CA2080", Offset = "0x4CA1480", VA = "0x184CA2080")]
		public bool PEKPNEJHNNK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x225A4E0", Offset = "0x22598E0", VA = "0x18225A4E0")]
	public static IFPGAHMMLCJ<T> HDEMAMPNDGP<T>(this NativeList<T> KEKPLKHNJAG) where T : struct
	{
		return default(IFPGAHMMLCJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
	public static IFPGAHMMLCJ<T> HDEMAMPNDGP<T>(this NativeArray<T> FFAHMFOPGLA) where T : struct
	{
		return default(IFPGAHMMLCJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class FMOLPLDIDEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct GFFGDMFAANH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly FFAHMFOPGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int IDGHKCPGHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int KEEHGKHJCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T GMONIOGPIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T EGFDIPNELEE;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public HAJJCCPKKFD JLOJFICHJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x34BCCF0", Offset = "0x34BC0F0", VA = "0x1834BCCF0")]
			get
			{
				return default(HAJJCCPKKFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T NHIFAHKLPNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x30E4190", Offset = "0x30E3590", VA = "0x1830E4190")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, HAJJCCPKKFD) PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x34BCD00", Offset = "0x34BC100", VA = "0x1834BCD00")]
			get
			{
				return default((T, HAJJCCPKKFD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x34BD2A0", Offset = "0x34BC6A0", VA = "0x1834BD2A0")]
		public GFFGDMFAANH(NativeArray<T> FFAHMFOPGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x34BCCB0", Offset = "0x34BC0B0", VA = "0x1834BCCB0")]
		public GFFGDMFAANH<T> JBKAHEPNGNA()
		{
			return default(GFFGDMFAANH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x34BD050", Offset = "0x34BC450", VA = "0x1834BD050")]
		public bool PEKPNEJHNNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D13090", Offset = "0x2D12490", VA = "0x182D13090")]
		public KNENMKMLHKD<T, TComparer> PHMEOHGPBPN<TComparer>([Optional] TComparer PFJKDDOKICN) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KNENMKMLHKD<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct KNENMKMLHKD<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly FFAHMFOPGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int IDGHKCPGHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int KEEHGKHJCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T GMONIOGPIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T EGFDIPNELEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer PFJKDDOKICN;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public HAJJCCPKKFD JLOJFICHJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x34BCCF0", Offset = "0x34BC0F0", VA = "0x1834BCCF0")]
			get
			{
				return default(HAJJCCPKKFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T NHIFAHKLPNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x30E4190", Offset = "0x30E3590", VA = "0x1830E4190")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, HAJJCCPKKFD range) PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x38FBE90", Offset = "0x38FB290", VA = "0x1838FBE90")]
			get
			{
				return default((T, HAJJCCPKKFD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x38FC140", Offset = "0x38FB540", VA = "0x1838FC140")]
		public KNENMKMLHKD(NativeArray<T>.ReadOnly FFAHMFOPGLA, TComparer PFJKDDOKICN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x38FBE50", Offset = "0x38FB250", VA = "0x1838FBE50")]
		public KNENMKMLHKD<T, TComparer> JBKAHEPNGNA()
		{
			return default(KNENMKMLHKD<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x38FBF60", Offset = "0x38FB360", VA = "0x1838FBF60")]
		public bool PEKPNEJHNNK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2373350", Offset = "0x2372750", VA = "0x182373350")]
	public static GFFGDMFAANH<T> IIIODFCEEFH<T>(this NativeArray<T> FFAHMFOPGLA) where T : struct
	{
		return default(GFFGDMFAANH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface BIEAIMHNJPN
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class LEOKCJJKCKG
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HMCBJPCNJJP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class HGOMDNNAGDI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HMCBJPCNJJP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x95E320", Offset = "0x95D720", VA = "0x18095E320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x33FF390", Offset = "0x33FE790", VA = "0x1833FF390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
		[DebuggerHidden]
		public HGOMDNNAGDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x353DB00", Offset = "0x353CF00", VA = "0x18353DB00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x353DCB0", Offset = "0x353D0B0", VA = "0x18353DCB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> CPNAAPDBILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream FMJIOIIBMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream PMNJIOAMAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf KGBLNECAAPF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x356F230", Offset = "0x356E630", VA = "0x18356F230")]
	private HMCBJPCNJJP(byte[] FNCIFBBDALE, Action<Protobuf> CPNAAPDBILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D14880", Offset = "0x2D13C80", VA = "0x182D14880")]
	public static HMCBJPCNJJP<Protobuf> EECJKDKEFDC<Data>(ReadOnlySpan<byte> EGFEGIMIICO, ReadOnlySpan<Data> DLBJPBJAFGL, Action<Protobuf> CPNAAPDBILD)
	{
		return default(HMCBJPCNJJP<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x356F0A0", Offset = "0x356E4A0", VA = "0x18356F0A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x356F0E0", Offset = "0x356E4E0", VA = "0x18356F0E0", Slot = "4")]
	[IteratorStateMachine(typeof(HMCBJPCNJJP<>.HGOMDNNAGDI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x356F1D0", Offset = "0x356E5D0", VA = "0x18356F1D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct FGDLAMGJGEB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] FNCIFBBDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf KGBLNECAAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream FMJIOIIBMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream HMGBCGNOJKI;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x33D7DE0", Offset = "0x33D71E0", VA = "0x1833D7DE0")]
	private FGDLAMGJGEB(byte[] FNCIFBBDALE, [In] Protobuf KGBLNECAAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D840", Offset = "0x2D0CC40", VA = "0x182D0D840")]
	public static FGDLAMGJGEB<Protobuf> EECJKDKEFDC<T>(ReadOnlySpan<T> DLBJPBJAFGL)
	{
		return default(FGDLAMGJGEB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x33D7D20", Offset = "0x33D7120", VA = "0x1833D7D20")]
	public void NBKLADNEDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x33D7D50", Offset = "0x33D7150", VA = "0x1833D7D50")]
	public ByteString PCENJPCJCHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x33D7BF0", Offset = "0x33D6FF0", VA = "0x1833D7BF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DPICOLNIOOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream FMJIOIIBMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream PMNJIOAMAMG;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D4AEC0", Offset = "0x5D4A2C0", VA = "0x185D4AEC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct JIIAMDPMMOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] FNCIFBBDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream FMJIOIIBMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream HMGBCGNOJKI;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C3D0", Offset = "0x5D4B7D0", VA = "0x185D4C3D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class GLFFIHDFLMM
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void DELKIGJOFON<From, To>(From ABNGLIALIJA, To DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class LAKMHFGIIDP<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static DELKIGJOFON<From, To> BLHIHCBCFEL;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public LAKMHFGIIDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B9A0", Offset = "0x5D4ADA0", VA = "0x185D4B9A0")]
	static GLFFIHDFLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x239D8A0", Offset = "0x239CCA0", VA = "0x18239D8A0")]
	public static void OAKCOIAFMED<T>(DELKIGJOFON<T, T> FLJKLJBODAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x239E2E0", Offset = "0x239D6E0", VA = "0x18239E2E0")]
	public static void OAKCOIAFMED<From, To>(DELKIGJOFON<From, To> FLJKLJBODAM, DELKIGJOFON<To, From> LMJMNCLMPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x239D3B0", Offset = "0x239C7B0", VA = "0x18239D3B0")]
	public static void OAKCOIAFMED<From, To>(DELKIGJOFON<From, To> BLHIHCBCFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2398DF0", Offset = "0x23981F0", VA = "0x182398DF0")]
	public static DELKIGJOFON<From, To> NGFEOJFHOKK<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2394430", Offset = "0x2393830", VA = "0x182394430")]
	public static void IMGNBILILIM<From, To>(From ABNGLIALIJA, To DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class GILPKIILCCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> KCNEBECLCPA;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C3CD80", Offset = "0x1C3C180", VA = "0x181C3CD80")]
	public GILPKIILCCE(NativeArray<EntityRemapUtility.EntityRemapInfo> KCNEBECLCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B990", Offset = "0x5D4AD90", VA = "0x185D4B990")]
	public Entity ACMLMHABCAE(Entity OAGNBNMPALP)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class JLANEFEIHPG
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C500", Offset = "0x5D4B900", VA = "0x185D4C500")]
	public static ulong FKBENPNAIOF(Type IJFAMCPOKBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C590", Offset = "0x5D4B990", VA = "0x185D4C590")]
	public static ulong FKBENPNAIOF(string PKBLHDNHONK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum LLFIBOALHBA
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AttributeUsage(AttributeTargets.Class)]
public class ACCFGGIJBGE : ICCFEBIBGCG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public ACCFGGIJBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class IEHCCNOGGFG
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C260", Offset = "0x5D4B660", VA = "0x185D4C260")]
	private unsafe static Span<byte> NAKDHKLGNLF(Unity.Entities.Chunk* KGJGPOJOPDJ, int BOMDCPNEPCD)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x23B6420", Offset = "0x23B5820", VA = "0x1823B6420")]
	public unsafe static Span<T> HJGIKDJEKEF<T>(Unity.Entities.Chunk* KGJGPOJOPDJ, int BOMDCPNEPCD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x23B63F0", Offset = "0x23B57F0", VA = "0x1823B63F0")]
	public static Span<T> HJGIKDJEKEF<T>(this Unity.Entities.Chunk KGJGPOJOPDJ, int BOMDCPNEPCD)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C090", Offset = "0x5D4B490", VA = "0x185D4C090")]
	public unsafe static Span<Entity> ADDMKPOLCNP(Unity.Entities.Chunk* KGJGPOJOPDJ)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C0F0", Offset = "0x5D4B4F0", VA = "0x185D4C0F0")]
	public unsafe static void BPHEMFKLBDC(Unity.Entities.Chunk* KGJGPOJOPDJ, int BOMDCPNEPCD)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class GJFEHICIKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GJFEHICIKAF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
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
