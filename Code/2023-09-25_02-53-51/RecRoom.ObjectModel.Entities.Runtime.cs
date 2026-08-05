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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D9DBB0", Offset = "0x5D9CFB0", VA = "0x185D9DBB0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class FDAAEBFMFFD<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] ALMCNLLHKFF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4E10", Offset = "0x1FF4210", VA = "0x181FF4E10")]
	public static void IHCIBDLEDPN<TField>(int JPEMHHILGGG, string DKFEAPHKBMP, JKAOACKGDOB DNHMNEKGKCG, [Out] MKIKBAICGGB<TField> OIBKEMMFJDM) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FF6440", Offset = "0x1FF5840", VA = "0x181FF6440")]
	public static void LDDPCABJKLI<TField>(int JPEMHHILGGG, string DKFEAPHKBMP, [Out] EMNGLKONKEK<TField> OKJGMJDJMMC) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class GHILKMLGIAA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E240", Offset = "0x5D9D640", VA = "0x185D9E240")]
	public static FieldInfo[] JJDIGEMGFFM(Type DJMKKNDNCBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class MPMGCPACBPO<View, Data> : BPMBFEJHHKF where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType FHHPCIOOFIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type KOBCKDPBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B95790", Offset = "0x3B94B90", VA = "0x183B95790", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int CEIKBDOPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B95FD0", Offset = "0x3B953D0", VA = "0x183B95FD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B92EB0", Offset = "0x3B922B0", VA = "0x183B92EB0")]
	public Data GLLJBNMGMPE(Entity AHNNJNFIHFM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B94AD0", Offset = "0x3B93ED0", VA = "0x183B94AD0")]
	public Data KNLJAFPKHFO(Entity AHNNJNFIHFM)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View OABKLKICEKC(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21557D0", Offset = "0x2154BD0", VA = "0x1821557D0", Slot = "14")]
	public override T OABKLKICEKC<T>(Entity AHNNJNFIHFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	protected MPMGCPACBPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class BPMBFEJHHKF : JKAOACKGDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle MAAIOPDMFMK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11425F0", Offset = "0x11419F0", VA = "0x1811425F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type KOBCKDPBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int CEIKBDOPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type ANOMOFKKOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A5F0", VA = "0x18089B1F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int ENKCHMCGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D9D4E0", Offset = "0x5D9C8E0", VA = "0x185D9D4E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private BLKKNKJIPKI[] KIAKEIALEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7710", Offset = "0x3BC6B10", VA = "0x183BC7710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual BLKKNKJIPKI[] GLIHDJHBKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D9D550", Offset = "0x5D9C950", VA = "0x185D9D550", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D7C0", Offset = "0x5D9CBC0", VA = "0x185D9D7C0")]
	public void OMELHDOHHCI(EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T OABKLKICEKC<T>(Entity AHNNJNFIHFM) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D5E0", Offset = "0x5D9C9E0", VA = "0x185D9D5E0", Slot = "8")]
	public (uint, uint) LNDPEHBIDBK(Entity AHNNJNFIHFM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D6D0", Offset = "0x5D9CAD0", VA = "0x185D9D6D0", Slot = "9")]
	public bool NJGKIPDANBB(Entity AHNNJNFIHFM, (uint order, uint change) KAHINILDCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected BPMBFEJHHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EHKMLPFKCNF
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AKJDOCOCMOM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MPCGNBAKMOK GPOHNIKAKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CCPHPPNFFDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPFGPHOPDBA(Entity AHNNJNFIHFM, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BOFEABPBCHB(Entity AHNNJNFIHFM, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OJPBEAOHLFI(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LIBDNOBBFLF(Entity AHNNJNFIHFM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PNKPENPEALM<TComponentData, TValue> : BJBKJIMPOKB<TValue>, IDisposable where TComponentData : struct, AKJDOCOCMOM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class DHDHHEMOJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> NMLNNLIOHNF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int ENJCEKMGBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2EC64F0", Offset = "0x2EC58F0", VA = "0x182EC64F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7DA0", Offset = "0x4CF71A0", VA = "0x184CF7DA0")]
		public bool LLMJNALFGOB([Out] TValue LPCGJALKADL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7C70", Offset = "0x4CF7070", VA = "0x184CF7C70")]
		public void GIHKKMKIIOJ(object IBLOMPOENGH, TValue LPCGJALKADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7D20", Offset = "0x4CF7120", VA = "0x184CF7D20")]
		public bool HFJFDMFKDND(object IBLOMPOENGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7B90", Offset = "0x4CF6F90", VA = "0x184CF7B90")]
		public int CKLNEHJAKKF(object IBLOMPOENGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4CF7E90", Offset = "0x4CF7290", VA = "0x184CF7E90")]
		public DHDHHEMOJJD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<DHDHHEMOJJD> BEGGMAKMIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BMOENLKLHFA<MPCGNBAKMOK, DHDHHEMOJJD> AMMKANDKIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E879B0", Offset = "0x3E86DB0", VA = "0x183E879B0")]
	public PNKPENPEALM(EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E87400", Offset = "0x3E86800", VA = "0x183E87400", Slot = "4")]
	public void CPFGPHOPDBA(Entity AHNNJNFIHFM, object IBLOMPOENGH, TValue LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E87260", Offset = "0x3E86660", VA = "0x183E87260", Slot = "5")]
	public bool BOFEABPBCHB(Entity AHNNJNFIHFM, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E877F0", Offset = "0x3E86BF0", VA = "0x183E877F0", Slot = "6")]
	public bool LLMJNALFGOB(Entity AHNNJNFIHFM, [Out] TValue LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E87540", Offset = "0x3E86940", VA = "0x183E87540", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E87670", Offset = "0x3E86A70", VA = "0x183E87670")]
	private void FIKDJABDCBI(DHDHHEMOJJD LHHDKLOMKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E878F0", Offset = "0x3E86CF0", VA = "0x183E878F0")]
	private bool PDAAFEIEMDJ(Entity AHNNJNFIHFM, [Out] MPCGNBAKMOK EKHBDCNGFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E87700", Offset = "0x3E86B00", VA = "0x183E87700")]
	private void KFIKCJHDLGJ(Entity AHNNJNFIHFM, MPCGNBAKMOK EKHBDCNGFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E87650", Offset = "0x3E86A50", VA = "0x183E87650")]
	private bool FDLCKGFOLEP(MPCGNBAKMOK EKHBDCNGFLP, [Out] DHDHHEMOJJD LHHDKLOMKJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E87560", Offset = "0x3E86960", VA = "0x183E87560")]
	private DHDHHEMOJJD EOGIKPKECIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BJBKJIMPOKB<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPFGPHOPDBA(Entity AHNNJNFIHFM, object IBLOMPOENGH, TValue LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BOFEABPBCHB(Entity AHNNJNFIHFM, object IBLOMPOENGH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLMJNALFGOB(Entity AHNNJNFIHFM, [Out] TValue LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MPCGNBAKMOK : CEILLBLPNIE, IEquatable<MPCGNBAKMOK>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly MPCGNBAKMOK AJNJPGPIKEO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int ICOODGEKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int CIBDPGBBMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5220E10", Offset = "0x5220210", VA = "0x185220E10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E910", Offset = "0x5D9DD10", VA = "0x185D9E910", Slot = "8")]
	public bool Equals(MPCGNBAKMOK KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E960", Offset = "0x5D9DD60", VA = "0x185D9E960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FHDCGHPCKOL<THasTokensTag> : CCPHPPNFFDG, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, MPCGNBAKMOK> GEEGAAGDMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> BEGGMAKMIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BMOENLKLHFA<MPCGNBAKMOK, HashSet<object>> AMMKANDKIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem FLDGJNGPMOE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x33B2A80", Offset = "0x33B1E80", VA = "0x1833B2A80")]
	public FHDCGHPCKOL(EntityManager OKNGAOGEIDO, EntityCommandBufferSystem FLDGJNGPMOE, FJOGIBEAJHF NILNFNNKBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33B02E0", Offset = "0x33AF6E0", VA = "0x1833B02E0", Slot = "4")]
	public bool CPFGPHOPDBA(Entity AHNNJNFIHFM, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x33AFD20", Offset = "0x33AF120", VA = "0x1833AFD20", Slot = "5")]
	public bool BOFEABPBCHB(Entity AHNNJNFIHFM, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33B2080", Offset = "0x33B1480", VA = "0x1833B2080", Slot = "6")]
	public bool OJPBEAOHLFI(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33B1E70", Offset = "0x33B1270", VA = "0x1833B1E70", Slot = "9")]
	public bool OJPBEAOHLFI(MPCGNBAKMOK EKHBDCNGFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x33B1C70", Offset = "0x33B1070", VA = "0x1833B1C70", Slot = "7")]
	public bool LIBDNOBBFLF(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x33B05C0", Offset = "0x33AF9C0", VA = "0x1833B05C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x33B0A90", Offset = "0x33AFE90", VA = "0x1833B0A90")]
	private void FIKDJABDCBI(HashSet<object> LHHDKLOMKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x33B2830", Offset = "0x33B1C30", VA = "0x1833B2830")]
	private bool PDAAFEIEMDJ(Entity AHNNJNFIHFM, [Out] MPCGNBAKMOK EKHBDCNGFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x33B0E90", Offset = "0x33B0290", VA = "0x1833B0E90")]
	private bool IAPLIMLPHLB(Entity AHNNJNFIHFM, [Out] MPCGNBAKMOK EKHBDCNGFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x33AF540", Offset = "0x33AE940", VA = "0x1833AF540")]
	private void BEADJOFIMFP(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x33B1640", Offset = "0x33B0A40", VA = "0x1833B1640")]
	private void KJNJAHFCLKJ(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x33B2470", Offset = "0x33B1870", VA = "0x1833B2470")]
	private void OKEDEMLOMAB(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x33B1260", Offset = "0x33B0660", VA = "0x1833B1260")]
	private void KFIKCJHDLGJ(Entity AHNNJNFIHFM, MPCGNBAKMOK EKHBDCNGFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33B1070", Offset = "0x33B0470", VA = "0x1833B1070")]
	private bool IEIGPKFADNJ(MPCGNBAKMOK EKHBDCNGFLP, [Out] HashSet<object> LHHDKLOMKJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x33B07A0", Offset = "0x33AFBA0", VA = "0x1833B07A0")]
	private HashSet<object> EOGIKPKECIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FJHBAKCKDPP
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void HKOKBHNBDOF(this FJOGIBEAJHF AABDFOONPNL, NativeArray<Entity> JIBDNODJOAB, [Optional][CallerFilePath] string HNPFJFOCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void HKOKBHNBDOF(this FJOGIBEAJHF AABDFOONPNL, string DKFEAPHKBMP, NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void HKOKBHNBDOF(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, NativeArray<Entity> JIBDNODJOAB, bool HHDAKDCIPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void PEIOHONILOL(this FJOGIBEAJHF AABDFOONPNL, NativeArray<Entity> JIBDNODJOAB, EntityManager OKNGAOGEIDO, [Optional][CallerFilePath] string HNPFJFOCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void PEIOHONILOL(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, NativeArray<Entity> JIBDNODJOAB, EntityManager OKNGAOGEIDO, bool HHDAKDCIPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void ADBAOGNEBEA(this FJOGIBEAJHF AABDFOONPNL, NativeArray<Entity> JIBDNODJOAB, NativeArray<Entity> NMABGJCEKFC, [Optional][CallerFilePath] string HNPFJFOCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void ADBAOGNEBEA(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, NativeArray<Entity> JIBDNODJOAB, NativeArray<Entity> NMABGJCEKFC, bool HHDAKDCIPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x239A160", Offset = "0x2399560", VA = "0x18239A160")]
	public static void LBFPDELPHGK<T>(this FJOGIBEAJHF AABDFOONPNL, string DKFEAPHKBMP, NativeArray<Entity> JIBDNODJOAB, NativeList<T> OOIBMCBCEPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x239A1F0", Offset = "0x23995F0", VA = "0x18239A1F0")]
	public static void LBFPDELPHGK<T>(this FJOGIBEAJHF AABDFOONPNL, NativeArray<Entity> JIBDNODJOAB, NativeArray<T> OOIBMCBCEPD, [Optional][CallerFilePath] string HNPFJFOCKFB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x239A110", Offset = "0x2399510", VA = "0x18239A110")]
	public static void LBFPDELPHGK<T>(this FJOGIBEAJHF AABDFOONPNL, string DKFEAPHKBMP, NativeArray<Entity> JIBDNODJOAB, NativeArray<T> OOIBMCBCEPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void LBFPDELPHGK<T>(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, NativeArray<Entity> JIBDNODJOAB, NativeArray<T> OOIBMCBCEPD, bool HHDAKDCIPBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x239A270", Offset = "0x2399670", VA = "0x18239A270")]
	public static void OCOKIGGLPNL<T>(this FJOGIBEAJHF AABDFOONPNL, NativeList<T> OOIBMCBCEPD, [Optional][CallerFilePath] string HNPFJFOCKFB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x239A240", Offset = "0x2399640", VA = "0x18239A240")]
	public static void OCOKIGGLPNL<T>(this FJOGIBEAJHF AABDFOONPNL, NativeArray<T> OOIBMCBCEPD, [Optional][CallerFilePath] string HNPFJFOCKFB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void OCOKIGGLPNL<T>(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, NativeArray<T> OOIBMCBCEPD, bool HHDAKDCIPBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void PEJAPJFHJOK(this FJOGIBEAJHF AABDFOONPNL, EntityQuery OGHCNPNLAEN, [Optional][CallerFilePath] string HNPFJFOCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void PEJAPJFHJOK(this FJOGIBEAJHF AABDFOONPNL, string DKFEAPHKBMP, EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void PEJAPJFHJOK(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, EntityQuery OGHCNPNLAEN, bool HHDAKDCIPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x239A0E0", Offset = "0x23994E0", VA = "0x18239A0E0")]
	public static void FJAMFOGFHGB<T, T2>(this FJOGIBEAJHF AABDFOONPNL, string DKFEAPHKBMP, EntityQuery OGHCNPNLAEN) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void FJAMFOGFHGB<T, T2>(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, EntityQuery OGHCNPNLAEN, bool HHDAKDCIPBD) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x239A0E0", Offset = "0x23994E0", VA = "0x18239A0E0")]
	public static void GLIKGHADFII<T>(this FJOGIBEAJHF AABDFOONPNL, string DKFEAPHKBMP, NativeList<T> FOAJABBKLPB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void GLIKGHADFII<T>(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, NativeList<T> FOAJABBKLPB, bool HHDAKDCIPBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x239A0E0", Offset = "0x23994E0", VA = "0x18239A0E0")]
	public static void EAGFPCOJCLH<T>(this FJOGIBEAJHF AABDFOONPNL, string DKFEAPHKBMP, NativeArray<T> FOAJABBKLPB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public static void EAGFPCOJCLH<T>(this FJOGIBEAJHF AABDFOONPNL, string HNPFJFOCKFB, NativeArray<T> FOAJABBKLPB, bool HHDAKDCIPBD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OMGHOAKAFHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int POBHOBNPPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int CHEGLPEPHED;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MICBGPINKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5220E10", Offset = "0x5220210", VA = "0x185220E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int POAMGGPPBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DBBNOGJCDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D9ED10", Offset = "0x5D9E110", VA = "0x185D9ED10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5D9ECF0", Offset = "0x5D9E0F0", VA = "0x185D9ECF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x962380", Offset = "0x961780", VA = "0x180962380")]
	private OMGHOAKAFHB(int POBHOBNPPIN, int CHEGLPEPHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1C35D90", Offset = "0x1C35190", VA = "0x181C35D90")]
	public static OMGHOAKAFHB ANOKFEOJBKO(int POBHOBNPPIN, int CHEGLPEPHED)
	{
		return default(OMGHOAKAFHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D9ED00", Offset = "0x5D9E100", VA = "0x185D9ED00")]
	public static OMGHOAKAFHB KGNGPFBGJJB(int CJJOHOENBLA, int KAABKEFBBLK)
	{
		return default(OMGHOAKAFHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D9ED20", Offset = "0x5D9E120", VA = "0x185D9ED20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CHOELILCGFI : MDKNBLGBOFF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D81340", Offset = "0x5D80740", VA = "0x185D81340")]
	public float LEFOCAFCCCD([In] float3 LPCGJALKADL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D81340", Offset = "0x5D80740", VA = "0x185D81340", Slot = "4")]
	private float OJLADKKPJJA([In] float3 LPCGJALKADL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BLDKNMLMIEI : MDKNBLGBOFF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D81BC0", Offset = "0x5D80FC0", VA = "0x185D81BC0")]
	public float LEFOCAFCCCD([In] float3 LPCGJALKADL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D81BC0", Offset = "0x5D80FC0", VA = "0x185D81BC0", Slot = "4")]
	private float OJLADKKPJJA([In] float3 LPCGJALKADL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MPMIFCEMNKL : MDKNBLGBOFF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x187E6C0", Offset = "0x187DAC0", VA = "0x18187E6C0")]
	public float LEFOCAFCCCD([In] float3 LPCGJALKADL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x187E6C0", Offset = "0x187DAC0", VA = "0x18187E6C0", Slot = "4")]
	private float OJLADKKPJJA([In] float3 LPCGJALKADL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ACPKADOIBPL : MDKNBLGBOFF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670")]
	public int LEFOCAFCCCD([In] int3 LPCGJALKADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x11E3670", Offset = "0x11E2A70", VA = "0x1811E3670", Slot = "4")]
	private int JOBJAKEGBJI([In] int3 LPCGJALKADL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LCOHCHJCBBA : MDKNBLGBOFF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D82340", Offset = "0x5D81740", VA = "0x185D82340")]
	public int LEFOCAFCCCD([In] int3 LPCGJALKADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D82340", Offset = "0x5D81740", VA = "0x185D82340", Slot = "4")]
	private int JOBJAKEGBJI([In] int3 LPCGJALKADL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HNANIKBGLCO : MDKNBLGBOFF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1490560", Offset = "0x148F960", VA = "0x181490560")]
	public int LEFOCAFCCCD([In] int3 LPCGJALKADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1490560", Offset = "0x148F960", VA = "0x181490560", Slot = "4")]
	private int JOBJAKEGBJI([In] int3 LPCGJALKADL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DJJOOGKACPH : IHEAACHMMDM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type FFFNGJKOCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type FDCNPECEBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D980", Offset = "0x5D9CD80", VA = "0x185D9D980")]
	public DJJOOGKACPH(Type DFKPFPLGLOA, Type DAIDKOCCFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EAPLCJEALLA : IHEAACHMMDM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type FDCNPECEBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CBDA20", Offset = "0x5CBCE20", VA = "0x185CBDA20")]
	public EAPLCJEALLA(Type DAIDKOCCFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BAHPFKKFPEH : IHEAACHMMDM
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public BAHPFKKFPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class DGLKLGJMLLI<Data> : GEECJLGCMBE where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data DFAIJMEJABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3600", Offset = "0x4CF2A00", VA = "0x184CF3600", Slot = "8")]
	protected virtual bool MMFHAPLPAMF(ReadOnlySpan<Data> PGHBEEJMEAP, ILNADNNCEJM JHHKBGNPJPD, [Out] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "9")]
	protected virtual bool NFCGGKJMNAI(int KAHINILDCOI, Span<Data> PGHBEEJMEAP, [In] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3540", Offset = "0x4CF2940", VA = "0x184CF3540", Slot = "5")]
	internal sealed override bool MMFHAPLPAMF(Unity.Entities.Chunk LPPKICFIEJM, int APJMAILHMLG, ILNADNNCEJM JHHKBGNPJPD, [Out] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4CF3B10", Offset = "0x4CF2F10", VA = "0x184CF3B10", Slot = "6")]
	internal sealed override bool NFCGGKJMNAI(int KAHINILDCOI, Unity.Entities.Chunk LPPKICFIEJM, int APJMAILHMLG, [In] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2990", Offset = "0x1FF1D90", VA = "0x181FF2990")]
	protected GMKKHBDJGDA<Protobuf> BOBFLNINCAE<Protobuf>(ReadOnlySpan<Data> PGHBEEJMEAP) where Protobuf : IMessage, new()
	{
		return default(GMKKHBDJGDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FF29E0", Offset = "0x1FF1DE0", VA = "0x181FF29E0")]
	protected GGBCJGGIJPJ<Protobuf> IMBCCPBOALN<Protobuf>(ReadOnlySpan<byte> KHPJJNGKJGC, ReadOnlySpan<Data> PGHBEEJMEAP, Action<Protobuf> OMPDHIBEFHG) where Protobuf : IMessage, new()
	{
		return default(GGBCJGGIJPJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	protected DGLKLGJMLLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GEECJLGCMBE
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int CIBDPGBBMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E230", Offset = "0x5D9D630", VA = "0x185D9E230", Slot = "5")]
	internal virtual bool MMFHAPLPAMF(Unity.Entities.Chunk LPPKICFIEJM, int APJMAILHMLG, ILNADNNCEJM JHHKBGNPJPD, [Out] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "6")]
	internal virtual bool NFCGGKJMNAI(int KAHINILDCOI, Unity.Entities.Chunk LPPKICFIEJM, int APJMAILHMLG, [In] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected GEECJLGCMBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OPNAGNLBFOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class FILNMLJOIDH : SystemBase, OPNAGNLBFOL
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DBF0", Offset = "0x5D9CFF0", VA = "0x185D9DBF0")]
	public ComponentDataFromEntity FMMKLOICFIA(int CEOOILAHGGI, bool ACHJCHKHOEH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DBD0", Offset = "0x5D9CFD0", VA = "0x185D9DBD0")]
	public EntityExistenceLookupByEntity DJAEEOCOKPN()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DCB0", Offset = "0x5D9D0B0", VA = "0x185D9DCB0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	protected FILNMLJOIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class NEKPFIPDOIF : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E9B0", Offset = "0x5D9DDB0", VA = "0x185D9E9B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	protected NEKPFIPDOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class MMIEFEMCNFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class EBJOJOKGOLF : CFPNJCFEKNO
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DA70", Offset = "0x5D9CE70", VA = "0x185D9DA70", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase KNBJJOMOIJN();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D9D0", Offset = "0x5D9CDD0", VA = "0x185D9D9D0")]
	protected ComponentSystemBase BLGBEPJIDFL(params ComponentSystemBase[] MCIPOELAAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x224D250", Offset = "0x224C650", VA = "0x18224D250")]
	protected ComponentSystemBase BLGBEPJIDFL<T>(params ComponentSystemBase[] MCIPOELAAMA) where T : CFPNJCFEKNO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x224D210", Offset = "0x224C610", VA = "0x18224D210")]
	protected ComponentSystemBase BFBCBGNGFPP<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x224D210", Offset = "0x224C610", VA = "0x18224D210")]
	protected ComponentSystemBase EKNHMEPMMGB<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DA20", Offset = "0x5D9CE20", VA = "0x185D9DA20")]
	protected ComponentSystemBase MOFBPJAFHJM(params SystemHandleUntyped[] MCIPOELAAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x224D340", Offset = "0x224C740", VA = "0x18224D340")]
	protected ComponentSystemBase MOFBPJAFHJM<T>(params SystemHandleUntyped[] MCIPOELAAMA) where T : CFPNJCFEKNO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x224D2E0", Offset = "0x224C6E0", VA = "0x18224D2E0")]
	protected SystemHandleUntyped CCLFEBJJEMJ<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D930", Offset = "0x5D9CD30", VA = "0x185D9D930")]
	protected EBJOJOKGOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CFPNJCFEKNO : GJIBNPODALO
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D900", Offset = "0x5D9CD00", VA = "0x185D9D900", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D930", Offset = "0x5D9CD30", VA = "0x185D9D930")]
	public CFPNJCFEKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class GJIBNPODALO : ComponentSystemGroup, OPNAGNLBFOL
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D930", Offset = "0x5D9CD30", VA = "0x185D9D930")]
	protected GJIBNPODALO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class MEMILACELCP : EntityCommandBufferSystem, OPNAGNLBFOL
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	protected MEMILACELCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MDKNBLGBOFF<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LEFOCAFCCCD([In] TFrom LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DDJMNOHICJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ENCCMEAEGLN(T LPCGJALKADL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct BGEGEEHMCAP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes GABAJGJIIBJ;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D360", Offset = "0x5D9C760", VA = "0x185D9D360", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IDPAPBJCOFM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E410", Offset = "0x5D9D810", VA = "0x185D9E410", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct PDPMKJMCMHL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType BCNHGHNJOMA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D9EDB0", Offset = "0x5D9E1B0", VA = "0x185D9EDB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct PNJHALNIACH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3E86F90", Offset = "0x3E86390", VA = "0x183E86F90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct NJGDOMPDBPI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> FDELOOBEEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct DFCNDHMGDOO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T LPCGJALKADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEA40", Offset = "0x4CEDE40", VA = "0x184CEEA40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct GAJBLJLPAIA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MDKNBLGBOFF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> BDMBBMMDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> GMPFLDDBDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap PAFFKHOCLGN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct AMHHLBNPHMC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity JNIDHDEJGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> BDMBBMMDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> GMPFLDDBDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int NHFBKBBPJCL;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D260", Offset = "0x5D9C660", VA = "0x185D9D260", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct IPMKKPBFCPD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OLHHAFDGLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> BDMBBMMDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> NCOJEDEANPB;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct JPBFFFAJJIH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MDKNBLGBOFF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> PJHHMOOAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> GMPFLDDBDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap PAFFKHOCLGN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct OKOMMLDFJCG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DAIDKOCCFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> BNEGPODEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> AJGIJBGEPBP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct BJFPFNEFOKA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DAIDKOCCFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> BNEGPODEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> AJGIJBGEPBP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x44A5B40", Offset = "0x44A4F40", VA = "0x1844A5B40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct LADLNDICACA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> BDMBBMMDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> NCOJEDEANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> EGLHFCPNJBK;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x38B2010", Offset = "0x38B1410", VA = "0x1838B2010", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct JEPJIOHIEBK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : MDKNBLGBOFF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> BDMBBMMDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> NCOJEDEANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> EGLHFCPNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap PAFFKHOCLGN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct EEAJBEFHHDM<T, TPredicate> : IJob where T : struct where TPredicate : struct, DDJMNOHICJD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> BDMBBMMDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PGPHLMGJNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> MPGHBAPFPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate PAFFKHOCLGN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x301FA10", Offset = "0x301EE10", VA = "0x18301FA10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct OPGIGPDOMAE<T, TPredicate> : IJob where T : struct where TPredicate : struct, DDJMNOHICJD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> BDMBBMMDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> NCOJEDEANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate PAFFKHOCLGN;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct LHNDPKHEHNG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity DAIDKOCCFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> BNEGPODEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> JMNCECBPPNH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E880", Offset = "0x5D9DC80", VA = "0x185D9E880", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct BGPAMEGKMFO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity DAIDKOCCFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> BNEGPODEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> JMNCECBPPNH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D9D450", Offset = "0x5D9C850", VA = "0x185D9D450", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OOECCIKNNAN
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MHCGIOJHGFI
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x247EE70", Offset = "0x247E270", VA = "0x18247EE70")]
	public static bool MJMOEKOPMIL<T>(this NativeArray<Entity> BNEGPODEIJO, EntityManager OKNGAOGEIDO, Allocator JIIMEDFKEME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class HPNCIACAMGJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MPDPNGMFBPD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		public MPDPNGMFBPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KEFJKHMEFEM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		public KEFJKHMEFEM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> KEDMNMMPBAC;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E380", Offset = "0x5D9D780", VA = "0x185D9E380")]
	public HPNCIACAMGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JJDDMBGGBJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HKFHPIJHAJL
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct BGGJLPBACAP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct HEAEGLOCAFA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal BGGJLPBACAP<TFrom> DCLCDDGJKIC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> KECAMMIJJDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct FOEKDBMFGNI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct MHIELIBBMPL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal FOEKDBMFGNI<TFrom> DCLCDDGJKIC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> KECAMMIJJDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct CMDCKONLKFK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct CODHJLAICOG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal CMDCKONLKFK<TFrom> DCLCDDGJKIC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> KECAMMIJJDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct HIKLNOPJACO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct BDPLKDFNIEK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal HIKLNOPJACO<TFrom> DCLCDDGJKIC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> KECAMMIJJDM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class GGBNNNBMAIA
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IDFKCFAGBFO
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x23F57F0", Offset = "0x23F4BF0", VA = "0x1823F57F0")]
	public static NativeList<T> NKEKNPNKHFE<T>(this NativeList<T> CGIMECNBFCC, Allocator JIIMEDFKEME = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x23F5670", Offset = "0x23F4A70", VA = "0x1823F5670")]
	public static NativeList<T> NKEKNPNKHFE<T>(this NativeArray<T> CGIMECNBFCC, Allocator JIIMEDFKEME = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GFPFKMBCBKD
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NKBBDAOAEPG
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x24E5CF0", Offset = "0x24E50F0", VA = "0x1824E5CF0")]
	[OKGPICAPHLC]
	public static JobHandle OFNAKOCNOPM<T>(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArrayAsync<Entity> JIBDNODJOAB, NativeArrayAsync<T> OOIBMCBCEPD, [Optional] JobHandle INOHAEAJFAP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x24E5E50", Offset = "0x24E5250", VA = "0x1824E5E50")]
	[OKGPICAPHLC]
	public static JobHandle OFNAKOCNOPM<T>(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArrayAsync<Entity> JIBDNODJOAB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24E5BD0", Offset = "0x24E4FD0", VA = "0x1824E5BD0")]
	[OKGPICAPHLC]
	public static JobHandle OFNAKOCNOPM<T>(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArray<Entity> JIBDNODJOAB, [Optional] JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D9EB30", Offset = "0x5D9DF30", VA = "0x185D9EB30")]
	[OKGPICAPHLC]
	public static JobHandle OFNAKOCNOPM(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArray<Entity> JIBDNODJOAB, ComponentTypes GABAJGJIIBJ, [Optional] JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E9E0", Offset = "0x5D9DDE0", VA = "0x185D9E9E0")]
	[OKGPICAPHLC]
	public static JobHandle OFNAKOCNOPM(this EntityCommandBufferSystem FLDGJNGPMOE, EntityCommandBuffer DBMEKMBMPIL, NativeArray<Entity> JIBDNODJOAB, ComponentTypes GABAJGJIIBJ, [Optional] JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FFHEIEMOCJM
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x23975E0", Offset = "0x23969E0", VA = "0x1823975E0")]
	[OKGPICAPHLC]
	public static JobHandle PFBKIMBCGGI<T>(this EntityCommandBufferSystem FLDGJNGPMOE, EntityCommandBuffer DBMEKMBMPIL, EntityQuery OGHCNPNLAEN, T LPCGJALKADL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IKFPIAKHEDN
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E4B0", Offset = "0x5D9D8B0", VA = "0x185D9E4B0")]
	[OKGPICAPHLC]
	public static JobHandle GBOEMCGGKLF(this EntityCommandBufferSystem FLDGJNGPMOE, NativeList<Entity> JIBDNODJOAB, [Optional] JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E640", Offset = "0x5D9DA40", VA = "0x185D9E640")]
	[OKGPICAPHLC]
	public static JobHandle GBOEMCGGKLF(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArrayAsync<Entity> JIBDNODJOAB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OEJJFGJDCIM
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2506E60", Offset = "0x2506260", VA = "0x182506E60")]
	public static void OJEAMNBOHFM<T>(this EntityCommandBufferSystem FLDGJNGPMOE, EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2506DA0", Offset = "0x25061A0", VA = "0x182506DA0")]
	[OKGPICAPHLC]
	public static JobHandle IGIAMCKABBL<T>(this EntityCommandBufferSystem FLDGJNGPMOE, NativeListAsync<Entity> JIBDNODJOAB, [Optional] JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2506C10", Offset = "0x2506010", VA = "0x182506C10")]
	[OKGPICAPHLC]
	public static JobHandle IGIAMCKABBL<T>(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArrayAsync<Entity> JIBDNODJOAB, [Optional] JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class PMCLKMCOMDH
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2550D60", Offset = "0x2550160", VA = "0x182550D60")]
	[OKGPICAPHLC]
	public static JobHandle DEHGLBKPKLH<T>(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArray<Entity> JIBDNODJOAB, NativeArray<T> OOIBMCBCEPD, JobHandle INOHAEAJFAP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class DMHCLJJDFGF
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x222AA50", Offset = "0x2229E50", VA = "0x18222AA50")]
	[OKGPICAPHLC]
	public static JobHandle FBHLJLPAMDG<T>(this EntityCommandBufferSystem FLDGJNGPMOE, NativeArray<Entity> JIBDNODJOAB, T LPCGJALKADL, [Optional] JobHandle INOHAEAJFAP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x222A980", Offset = "0x2229D80", VA = "0x18222A980")]
	[OKGPICAPHLC]
	public static JobHandle FBHLJLPAMDG<T>(this EntityCommandBufferSystem FLDGJNGPMOE, EntityCommandBuffer DBMEKMBMPIL, NativeArray<Entity> JIBDNODJOAB, T LPCGJALKADL, [Optional] JobHandle INOHAEAJFAP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class ACGGHBLBGGL
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x29E63D0", Offset = "0x29E57D0", VA = "0x1829E63D0")]
	public static NativeList<T> NKEKNPNKHFE<T>(NativeList<T> CGIMECNBFCC, Allocator JIIMEDFKEME) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FNPKPCMFBLI
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x23BC1C0", Offset = "0x23BB5C0", VA = "0x1823BC1C0")]
	public static NativeArray<T> MBDNGMAGMEL<T>(this NativeList<Entity> CGIMECNBFCC, EntityManager OKNGAOGEIDO, Allocator JIIMEDFKEME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x23BBC80", Offset = "0x23BB080", VA = "0x1823BBC80")]
	public static NativeArray<T> MBDNGMAGMEL<T>(this NativeArray<Entity> CGIMECNBFCC, EntityManager OKNGAOGEIDO, Allocator JIIMEDFKEME = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FCGHBHLFHDM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct MHPIDBBHLAF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct MEAGJHMLKAG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public MHPIDBBHLAF<TFrom> KECAMMIJJDM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> BDMBBMMDFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct GGNNKIGHNME<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct LKDOPHHHIOG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public GGNNKIGHNME<TFrom> KECAMMIJJDM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> BDMBBMMDFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct JPGJIIMPHCE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct GHIIFHLEKKJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public JPGJIIMPHCE<TFrom> KECAMMIJJDM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> BDMBBMMDFNN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ICEFGIPABAK
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EDGMMKDHAMH
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct OHECKMLNFNH : MDKNBLGBOFF<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DHFEIPHEJJD;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D9ECE0", Offset = "0x5D9E0E0", VA = "0x185D9ECE0")]
		[BurstCompatible]
		public Entity LEFOCAFCCCD([In] Entity LPCGJALKADL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D9ECE0", Offset = "0x5D9E0E0", VA = "0x185D9ECE0", Slot = "4")]
		private Entity EGFCJALIMPJ([In] Entity LPCGJALKADL)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class EBAAOAPCMAA
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct AIMONGLKNFJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> PGPHLMGJNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> BDMBBMMDFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct IDGBBCCDOKP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> PGPHLMGJNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> BDMBBMMDFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct HFAGDPIDOFL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> PGPHLMGJNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> BDMBBMMDFNN;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x21490A0", Offset = "0x21484A0", VA = "0x1821490A0")]
		public NativeListAsync<Entity> ENCCMEAEGLN<TPredicate>() where TPredicate : struct, DDJMNOHICJD<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x224D090", Offset = "0x224C490", VA = "0x18224D090")]
	public static HFAGDPIDOFL<T> JLJOHPJCEBM<T>(this NativeArrayAsync<Entity> BNEGPODEIJO, NativeArrayAsync<T> CGIMECNBFCC, Allocator JIIMEDFKEME = Allocator.TempJob) where T : struct
	{
		return default(HFAGDPIDOFL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class KKPELIJPFIC
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2431AC0", Offset = "0x2430EC0", VA = "0x182431AC0")]
	public static NativeListAsync<Entity> OPEGGLGIDBJ<T, TPredicate>(this NativeArrayAsync<T> CGIMECNBFCC, NativeArrayAsync<Entity> BNEGPODEIJO, Allocator JIIMEDFKEME = Allocator.TempJob) where T : struct where TPredicate : struct, DDJMNOHICJD<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2431920", Offset = "0x2430D20", VA = "0x182431920")]
	private static NativeListAsync<Entity> MHNCLJFJEDM<T, TPredicate>(NativeArrayAsync<T> BNDDDLHBIPH, NativeArrayAsync<Entity> BNEGPODEIJO, int FADEBHLHEEP, Allocator JIIMEDFKEME) where T : struct where TPredicate : struct, DDJMNOHICJD<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class NEKJFNDGEAF
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct CIEJGEOJPHE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> BDMBBMMDFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct IFOFMBNIBAC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> BDMBBMMDFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct ENFIALAGPOI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> BDMBBMMDFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct MJNJEHMLELA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator JIIMEDFKEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> BDMBBMMDFNN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class FKAAFCKNLHI
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class KODLJBIEMPN
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x24322B0", Offset = "0x24316B0", VA = "0x1824322B0")]
	public static NativeList<Entity> MANNIKBKMBD<T>(this NativeArray<Entity> BNEGPODEIJO, EntityManager OKNGAOGEIDO, Allocator JIIMEDFKEME = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class GNNEPLGKAGD
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class ALPJPMKFEPI
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct FFPBDKJMJNB<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> FOAJABBKLPB;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
		public FFPBDKJMJNB(NativeArray<TSrc> FOAJABBKLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
		public LMBKOPJLBIP<TSrc, TValue> ALFCFEPOJHB<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LMBKOPJLBIP<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct LMBKOPJLBIP<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> FOAJABBKLPB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
		public LMBKOPJLBIP(NativeArray<TSrc> FOAJABBKLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
		public CAEHDJCJEEL<TSrc, TValue, TSelector> KKCGBDJCCPA<TSelector>() where TSelector : struct, MDKNBLGBOFF<TSrc, TValue>
		{
			return default(CAEHDJCJEEL<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct CAEHDJCJEEL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MDKNBLGBOFF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> FOAJABBKLPB;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
		public CAEHDJCJEEL(NativeArray<TSrc> FOAJABBKLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x48C0030", Offset = "0x48BF430", VA = "0x1848C0030")]
		public DCDCLOLNKGG<TSrc, TValue, TSelector> BLGBEPJIDFL()
		{
			return default(DCDCLOLNKGG<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct DDFNDEDECMC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, MDKNBLGBOFF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> FOAJABBKLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector GFCABHABNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int JPEMHHILGGG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4CE35E0", Offset = "0x4CE29E0", VA = "0x184CE35E0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int ICOODGEKGMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8AE1F0", Offset = "0x8AD5F0", VA = "0x1808AE1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int JBNGEMMLBJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1C39B10", Offset = "0x1C38F10", VA = "0x181C39B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3670", Offset = "0x4CE2A70", VA = "0x184CE3670")]
		public DDFNDEDECMC(NativeArray<TSrc> FOAJABBKLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4CE35D0", Offset = "0x4CE29D0", VA = "0x184CE35D0")]
		public bool OCCNJIGHPJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4CE34F0", Offset = "0x4CE28F0", VA = "0x184CE34F0")]
		private TSrc NKMOOBDOOIC(int PBOOCHALMNO)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct DCDCLOLNKGG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MDKNBLGBOFF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DDFNDEDECMC<TSrc, TValue, TSelector> MLKCGGMDNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue CGGAJFOGIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int IPFIDMBBIMG;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public OMGHOAKAFHB KMIOMKGOBKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x4CDB8A0", Offset = "0x4CDACA0", VA = "0x184CDB8A0")]
			get
			{
				return default(OMGHOAKAFHB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue KACCDGFMJLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, OMGHOAKAFHB range) KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4CDB7C0", Offset = "0x4CDABC0", VA = "0x184CDB7C0")]
			get
			{
				return default((TValue, OMGHOAKAFHB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4CDB8E0", Offset = "0x4CDACE0", VA = "0x184CDB8E0")]
		public DCDCLOLNKGG(NativeArray<TSrc> FOAJABBKLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x35C2420", Offset = "0x35C1820", VA = "0x1835C2420")]
		public DCDCLOLNKGG<TSrc, TValue, TSelector> DDJBJFDOGGC()
		{
			return default(DCDCLOLNKGG<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4CDB6A0", Offset = "0x4CDAAA0", VA = "0x184CDB6A0")]
		public bool OCCNJIGHPJL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29F2F50", Offset = "0x29F2350", VA = "0x1829F2F50")]
	public static FFPBDKJMJNB<T> FEODBGPNOIA<T>(this NativeList<T> NMLNNLIOHNF) where T : struct
	{
		return default(FFPBDKJMJNB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
	public static FFPBDKJMJNB<T> FEODBGPNOIA<T>(this NativeArray<T> FOAJABBKLPB) where T : struct
	{
		return default(FFPBDKJMJNB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class MJLNBOHDIGD
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct MNNGHLNMKFL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly FOAJABBKLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int IPFIDMBBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int HCKAJLMADPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T CGGAJFOGIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T FLPEKKAACDI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public OMGHOAKAFHB KMIOMKGOBKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x3432AE0", Offset = "0x3431EE0", VA = "0x183432AE0")]
			get
			{
				return default(OMGHOAKAFHB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T KACCDGFMJLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x30A23F0", Offset = "0x30A17F0", VA = "0x1830A23F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, OMGHOAKAFHB) KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3B8DBA0", Offset = "0x3B8CFA0", VA = "0x183B8DBA0")]
			get
			{
				return default((T, OMGHOAKAFHB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3B8DC70", Offset = "0x3B8D070", VA = "0x183B8DC70")]
		public MNNGHLNMKFL(NativeArray<T> FOAJABBKLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D700", Offset = "0x3B8CB00", VA = "0x183B8D700")]
		public MNNGHLNMKFL<T> DDJBJFDOGGC()
		{
			return default(MNNGHLNMKFL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D740", Offset = "0x3B8CB40", VA = "0x183B8D740")]
		public bool OCCNJIGHPJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2154F10", Offset = "0x2154310", VA = "0x182154F10")]
		public ABECBNAFFOM<T, TComparer> CMBJDHIENKB<TComparer>([Optional] TComparer HOMKJKGBFAE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(ABECBNAFFOM<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct ABECBNAFFOM<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly FOAJABBKLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int IPFIDMBBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int HCKAJLMADPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T CGGAJFOGIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T FLPEKKAACDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer HOMKJKGBFAE;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public OMGHOAKAFHB KMIOMKGOBKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3432AE0", Offset = "0x3431EE0", VA = "0x183432AE0")]
			get
			{
				return default(OMGHOAKAFHB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T KACCDGFMJLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x30A23F0", Offset = "0x30A17F0", VA = "0x1830A23F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, OMGHOAKAFHB range) KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3432A10", Offset = "0x3431E10", VA = "0x183432A10")]
			get
			{
				return default((T, OMGHOAKAFHB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3432AF0", Offset = "0x3431EF0", VA = "0x183432AF0")]
		public ABECBNAFFOM(NativeArray<T>.ReadOnly FOAJABBKLPB, TComparer HOMKJKGBFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x34327F0", Offset = "0x3431BF0", VA = "0x1834327F0")]
		public ABECBNAFFOM<T, TComparer> DDJBJFDOGGC()
		{
			return default(ABECBNAFFOM<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3432830", Offset = "0x3431C30", VA = "0x183432830")]
		public bool OCCNJIGHPJL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2480430", Offset = "0x247F830", VA = "0x182480430")]
	public static MNNGHLNMKFL<T> BLGBEPJIDFL<T>(this NativeArray<T> FOAJABBKLPB) where T : struct
	{
		return default(MNNGHLNMKFL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface JJOAJNIIFMJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class DEKPGLODHNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GGBCJGGIJPJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class DAMAAIEJDOE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GGBCJGGIJPJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x93E0D0", Offset = "0x93D4D0", VA = "0x18093E0D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x33F7390", Offset = "0x33F6790", VA = "0x1833F7390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public DAMAAIEJDOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4CD9290", Offset = "0x4CD8690", VA = "0x184CD9290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4CD9440", Offset = "0x4CD8840", VA = "0x184CD9440", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> OMPDHIBEFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream BKMMHPCMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream LPBDEMNPOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf NNFECLLJHFI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int JBNGEMMLBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3482170", Offset = "0x3481570", VA = "0x183482170")]
	private GGBCJGGIJPJ(byte[] DOGIBAMCGBK, Action<Protobuf> OMPDHIBEFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD5B0", Offset = "0x1FFC9B0", VA = "0x181FFD5B0")]
	public static GGBCJGGIJPJ<Protobuf> PJBIIEEDKDI<Data>(ReadOnlySpan<byte> KHPJJNGKJGC, ReadOnlySpan<Data> PGHBEEJMEAP, Action<Protobuf> OMPDHIBEFHG)
	{
		return default(GGBCJGGIJPJ<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3481FE0", Offset = "0x34813E0", VA = "0x183481FE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3482020", Offset = "0x3481420", VA = "0x183482020", Slot = "4")]
	[IteratorStateMachine(typeof(GGBCJGGIJPJ<>.DAMAAIEJDOE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3482110", Offset = "0x3481510", VA = "0x183482110", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct GMKKHBDJGDA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DOGIBAMCGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf NNFECLLJHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream BKMMHPCMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream LHABKPOEKOI;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x34A1940", Offset = "0x34A0D40", VA = "0x1834A1940")]
	private GMKKHBDJGDA(byte[] DOGIBAMCGBK, [In] Protobuf NNFECLLJHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2142EA0", Offset = "0x21422A0", VA = "0x182142EA0")]
	public static GMKKHBDJGDA<Protobuf> PJBIIEEDKDI<T>(ReadOnlySpan<T> PGHBEEJMEAP)
	{
		return default(GMKKHBDJGDA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x34A1910", Offset = "0x34A0D10", VA = "0x1834A1910")]
	public void PDOMKLFMFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x34A1880", Offset = "0x34A0C80", VA = "0x1834A1880")]
	public ByteString IEBDGLIPLJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x34A1750", Offset = "0x34A0B50", VA = "0x1834A1750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OBCNKKMMNCL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream BKMMHPCMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream LPBDEMNPOHC;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D9ECA0", Offset = "0x5D9E0A0", VA = "0x185D9ECA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct KHJMDPAGIII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] DOGIBAMCGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream BKMMHPCMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream LHABKPOEKOI;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E750", Offset = "0x5D9DB50", VA = "0x185D9E750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class FKELHJJAICO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void GGIIMIHJOPF<From, To>(From KECAMMIJJDM, To PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class PJMCNDKPLJI<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static GGIIMIHJOPF<From, To> LKAONPEHEJI;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public PJMCNDKPLJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DF60", Offset = "0x5D9D360", VA = "0x185D9DF60")]
	static FKELHJJAICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x23A2B40", Offset = "0x23A1F40", VA = "0x1823A2B40")]
	public static void CIPHKHELICI<T>(GGIIMIHJOPF<T, T> JPBJLJDFNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x23B4600", Offset = "0x23B3A00", VA = "0x1823B4600")]
	public static void CIPHKHELICI<From, To>(GGIIMIHJOPF<From, To> JPBJLJDFNGK, GGIIMIHJOPF<To, From> DFPAGHDAGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x23A2AD0", Offset = "0x23A1ED0", VA = "0x1823A2AD0")]
	public static void CIPHKHELICI<From, To>(GGIIMIHJOPF<From, To> LKAONPEHEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x239C860", Offset = "0x239BC60", VA = "0x18239C860")]
	public static GGIIMIHJOPF<From, To> BINLJBNDKNB<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x23B6700", Offset = "0x23B5B00", VA = "0x1823B6700")]
	public static void KJKAJKCKHNK<From, To>(From KECAMMIJJDM, To PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class ILNADNNCEJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> MHHLKPHBNAH;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1C001A0", Offset = "0x1BFF5A0", VA = "0x181C001A0")]
	public ILNADNNCEJM(NativeArray<EntityRemapUtility.EntityRemapInfo> MHHLKPHBNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D9E740", Offset = "0x5D9DB40", VA = "0x185D9E740")]
	public Entity EPMKJIEDJNL(Entity OFAFLOECBGM)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class ELPPPEHJPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DAC0", Offset = "0x5D9CEC0", VA = "0x185D9DAC0")]
	public static ulong PEMIHJHLNGM(Type DJMKKNDNCBM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DB50", Offset = "0x5D9CF50", VA = "0x185D9DB50")]
	public static ulong PEMIHJHLNGM(string AMEDHLODEJF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum NBFMNJCODMI
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
public class JNKGEHLNOAI : IHEAACHMMDM
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public JNKGEHLNOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class FKDHHAFDHMH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DCC0", Offset = "0x5D9D0C0", VA = "0x185D9DCC0")]
	private unsafe static Span<byte> GLDKGJLIMDA(Unity.Entities.Chunk* LPPKICFIEJM, int APJMAILHMLG)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x239A740", Offset = "0x2399B40", VA = "0x18239A740")]
	public unsafe static Span<T> LFCKHFFIFFM<T>(Unity.Entities.Chunk* LPPKICFIEJM, int APJMAILHMLG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x222AF10", Offset = "0x222A310", VA = "0x18222AF10")]
	public static Span<T> LFCKHFFIFFM<T>(this Unity.Entities.Chunk LPPKICFIEJM, int APJMAILHMLG)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DD90", Offset = "0x5D9D190", VA = "0x185D9DD90")]
	public unsafe static Span<Entity> KBAEONAAAHC(Unity.Entities.Chunk* LPPKICFIEJM)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9DDF0", Offset = "0x5D9D1F0", VA = "0x185D9DDF0")]
	public unsafe static void OOAOJFKKMLN(Unity.Entities.Chunk* LPPKICFIEJM, int APJMAILHMLG)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class FCJMKIHNMJN
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FCJMKIHNMJN()
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
