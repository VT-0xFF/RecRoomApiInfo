using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class HNBMJFDNMED<TContainer, TField> : HLOKIFKMANP<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3EA8E60", Offset = "0x3EA8060", VA = "0x183EA8E60")]
	public HNBMJFDNMED(string EPPPGDEIJCI, DHMPIDJKBID LCANHDHOBOG, FieldInfo HDCMMCJLMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x404A4E0", Offset = "0x40496E0", VA = "0x18404A4E0", Slot = "26")]
	public override bool HPDIHAPBFNP(Entity NCLCOHLPCDH, JELELNEKHOA JJOJMFAMEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x404A650", Offset = "0x4049850", VA = "0x18404A650", Slot = "32")]
	public override ELOOCMANCHK OOBJJHBBCGI(EntityManager OLBIDLKJHHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class MGCDBOGJHPF<T> : HLOKIFKMANP<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3EA8E60", Offset = "0x3EA8060", VA = "0x183EA8E60")]
	public MGCDBOGJHPF(string EPPPGDEIJCI, DHMPIDJKBID LCANHDHOBOG, FieldInfo HDCMMCJLMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x47830E0", Offset = "0x47822E0", VA = "0x1847830E0", Slot = "32")]
	public override ELOOCMANCHK OOBJJHBBCGI(EntityManager OLBIDLKJHHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class HLOKIFKMANP<T> : DOMINGHOMPM, HCOBLBALNNF<T>, CDGENBKLJAE<Entity, T>, BFAKDFNEKAJ<Entity>, KCMLBNHJMDN, IDisposable, ELOOCMANCHK, ANOOHCFOHPB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool CKGIOHMPPBP(Entity NCLCOHLPCDH, [In] T JJOJMFAMEML);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void IMANNAKICBA(Entity NCLCOHLPCDH, [In] T CFCDKDPHAPF, [In] T JJOJMFAMEML);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DHMPIDJKBID LCANHDHOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo HDCMMCJLMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int MJFABBCHFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int ECDKJELMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int JAICOMOJIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CKGIOHMPPBP IEOCINBJNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IMANNAKICBA OOHADKCOJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IMANNAKICBA DLPFDHEFOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World GGCFMDDNMDJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type DGMPJMIJKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4040DA0", Offset = "0x403FFA0", VA = "0x184040DA0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override DHMPIDJKBID MDPLMJJBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override ANOOHCFOHPB ALJJMJDHJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo HCPAHNFMHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int PKBMOGCANOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B35B0", Offset = "0x8B27B0", VA = "0x1808B35B0", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int MDIIOOHJDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A5090", Offset = "0x8A4290", VA = "0x1808A5090", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager FAJPJDIBIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4040EC0", Offset = "0x40400C0", VA = "0x184040EC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4048600", Offset = "0x4047800", VA = "0x184048600")]
	internal HLOKIFKMANP(string EPPPGDEIJCI, DHMPIDJKBID LCANHDHOBOG, FieldInfo HDCMMCJLMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4041180", Offset = "0x4040380", VA = "0x184041180", Slot = "30")]
	public override void DDNLIMMJHCH(EntityManager FFFGHCELNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x40415C0", Offset = "0x40407C0", VA = "0x1840415C0")]
	public HLOKIFKMANP<T> FFEIDHHMNDB(CKGIOHMPPBP IEOCINBJNKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x40415A0", Offset = "0x40407A0", VA = "0x1840415A0")]
	public HLOKIFKMANP<T> EEPPEGPFFML(IMANNAKICBA OOHADKCOJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x40415E0", Offset = "0x40407E0", VA = "0x1840415E0")]
	public HLOKIFKMANP<T> GELOFGMPCLI(IMANNAKICBA DLPFDHEFOMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4047B90", Offset = "0x4046D90", VA = "0x184047B90", Slot = "33")]
	public T PLOCNKMCLIO(Entity NCLCOHLPCDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x40449E0", Offset = "0x4043BE0", VA = "0x1840449E0")]
	public bool HPDIHAPBFNP(Entity NCLCOHLPCDH, [In] T JJOJMFAMEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4041600", Offset = "0x4040800", VA = "0x184041600")]
	public bool GGFHJJBFKAG(Entity NCLCOHLPCDH, [In] T JJOJMFAMEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4040250", Offset = "0x403F450", VA = "0x184040250", Slot = "24")]
	public override bool BBGJCOKFMOM(Entity NCLCOHLPCDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40467D0", Offset = "0x40459D0", VA = "0x1840467D0", Slot = "25")]
	public override void PLOCNKMCLIO(Entity NCLCOHLPCDH, CBGBNPKGPME JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40419E0", Offset = "0x4040BE0", VA = "0x1840419E0", Slot = "26")]
	public override bool HPDIHAPBFNP(Entity NCLCOHLPCDH, JELELNEKHOA JJOJMFAMEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40407D0", Offset = "0x403F9D0", VA = "0x1840407D0", Slot = "27")]
	public override void BCBFDCELEDO(FGKMFIAJOMC LJIOGDGABDM, [Optional] object GFIAFOEJCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4045D80", Offset = "0x4044F80", VA = "0x184045D80", Slot = "28")]
	public override bool JDGMIEOCEEP(Entity OPBMEKKEPKH, Entity MMPBCCIBPMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x403F5F0", Offset = "0x403E7F0", VA = "0x18403F5F0", Slot = "31")]
	public override string AFLDAJCBHED([In] JELELNEKHOA DPPEPBFBBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4045D10", Offset = "0x4044F10", VA = "0x184045D10")]
	private bool IPNBNJOGLJK(T CFCDKDPHAPF, T JJOJMFAMEML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DOMINGHOMPM : HEGMDADOIFL, ELOOCMANCHK, BFAKDFNEKAJ<Entity>, KCMLBNHJMDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type DGMPJMIJKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract DHMPIDJKBID MDPLMJJBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract ANOOHCFOHPB ALJJMJDHJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AHCEFENLALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA22AE0", Offset = "0xA21CE0", VA = "0x180A22AE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PGEJMCOHFEG<Entity> OJFLGHMBABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CA70", Offset = "0x6C7BC70", VA = "0x186C7CA70", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C9C0", Offset = "0x6C7BBC0", VA = "0x186C7C9C0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool BBGJCOKFMOM(Entity NCLCOHLPCDH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void PLOCNKMCLIO(Entity NCLCOHLPCDH, CBGBNPKGPME JECHHBGMFLN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool HPDIHAPBFNP(Entity NCLCOHLPCDH, JELELNEKHOA JJOJMFAMEML);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void BCBFDCELEDO(FGKMFIAJOMC LJIOGDGABDM, [Optional] object GFIAFOEJCDD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool JDGMIEOCEEP(Entity OPBMEKKEPKH, Entity MMPBCCIBPMB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void DDNLIMMJHCH(EntityManager FFFGHCELNHC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C930", Offset = "0x2C6BB30", VA = "0x182C6C930")]
	protected void DDIOCOGCIEF<T>(Entity NCLCOHLPCDH, [In] T CFCDKDPHAPF, [In] T JJOJMFAMEML) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string AFLDAJCBHED([In] JELELNEKHOA DPPEPBFBBHI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract ELOOCMANCHK OOBJJHBBCGI(EntityManager OLBIDLKJHHB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected DOMINGHOMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ELOOCMANCHK : BFAKDFNEKAJ<Entity>, KCMLBNHJMDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELOOCMANCHK OOBJJHBBCGI(EntityManager OLBIDLKJHHB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HCOBLBALNNF<T> : CDGENBKLJAE<Entity, T>, BFAKDFNEKAJ<Entity>, KCMLBNHJMDN, IDisposable, ELOOCMANCHK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface HEGMDADOIFL : ELOOCMANCHK, BFAKDFNEKAJ<Entity>, KCMLBNHJMDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int AHCEFENLALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EBKFADNFFGF
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C81850", Offset = "0x2C80A50", VA = "0x182C81850")]
	public static T AHMDFLFJFKL<T>(this HCOBLBALNNF<T> BAEKDMBADGA, Entity NCLCOHLPCDH, [Optional] T IIGPKDCCLGH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C81C30", Offset = "0x2C80E30", VA = "0x182C81C30")]
	public static T IKLGAEEKKLK<T>(this BFAKDFNEKAJ<Entity> BAEKDMBADGA, Entity NCLCOHLPCDH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C81A70", Offset = "0x2C80C70", VA = "0x182C81A70")]
	public static bool CHLIJLINCNL<T>(this BFAKDFNEKAJ<Entity> BAEKDMBADGA, Entity NCLCOHLPCDH, [In] T JJOJMFAMEML) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C819D0", Offset = "0x2C80BD0", VA = "0x182C819D0")]
	public static bool CHLIJLINCNL<T>(this BFAKDFNEKAJ<Entity> BAEKDMBADGA, Entity NCLCOHLPCDH, NativeArray<T> JJOJMFAMEML) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PGEJMCOHFEG<TKey>(TKey JMJAOKJJFGJ, [In] JELELNEKHOA CFCDKDPHAPF, [In] JELELNEKHOA JJOJMFAMEML);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KIJIJHGPHOM
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2EE1540", Offset = "0x2EE0740", VA = "0x182EE1540")]
	public static void BAPLBLGGGFM<TKey, T>(this PGEJMCOHFEG<TKey> KIDABJIPBMH, TKey JMJAOKJJFGJ, T CFCDKDPHAPF, T JJOJMFAMEML) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FGKMFIAJOMC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNLFLEMDJEE<TKey, T>(CDGENBKLJAE<TKey, T> BAEKDMBADGA, [Optional] object GFIAFOEJCDD) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BBLKKBHIMPN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ANOOHCFOHPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo KLDKMHJHCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int AMCDMMKKGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NCANLJNAAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KCMLBNHJMDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string HPIOEFIINLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type DGMPJMIJKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ANOOHCFOHPB ALJJMJDHJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DHMPIDJKBID MDPLMJJBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int AHCEFENLALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BCBFDCELEDO(FGKMFIAJOMC LJIOGDGABDM, [Optional] object GFIAFOEJCDD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BFAKDFNEKAJ<TKey> : KCMLBNHJMDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PGEJMCOHFEG<TKey> OJFLGHMBABI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BBGJCOKFMOM(TKey CPBLLDDDHEE);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLOCNKMCLIO(TKey CPBLLDDDHEE, CBGBNPKGPME JECHHBGMFLN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HPDIHAPBFNP(TKey CPBLLDDDHEE, JELELNEKHOA JJOJMFAMEML);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JDGMIEOCEEP(TKey OPBMEKKEPKH, TKey MMPBCCIBPMB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string AFLDAJCBHED([In] JELELNEKHOA JECHHBGMFLN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface CDGENBKLJAE<TKey, T> : BFAKDFNEKAJ<TKey>, KCMLBNHJMDN, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T PLOCNKMCLIO(TKey CPBLLDDDHEE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JGADHCFGGOO
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E74310", Offset = "0x2E73510", VA = "0x182E74310")]
	public static bool HJCFEIDEHAE<TKey, T>(this BFAKDFNEKAJ<TKey> BAEKDMBADGA, TKey CPBLLDDDHEE, [Out] T JECHHBGMFLN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2E74F80", Offset = "0x2E74180", VA = "0x182E74F80")]
	public static T PLOCNKMCLIO<T, TKey>(this BFAKDFNEKAJ<TKey> BAEKDMBADGA, TKey CPBLLDDDHEE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E74860", Offset = "0x2E73A60", VA = "0x182E74860")]
	public static bool HPDIHAPBFNP<TKey, T>(this BFAKDFNEKAJ<TKey> BAEKDMBADGA, TKey CPBLLDDDHEE, T JJOJMFAMEML) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E744D0", Offset = "0x2E736D0", VA = "0x182E744D0")]
	public static bool HPDIHAPBFNP<TKey, T>(this BFAKDFNEKAJ<TKey> BAEKDMBADGA, TKey CPBLLDDDHEE, NativeArray<T> JJOJMFAMEML) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface KFPPKMEOEEE : IEnumerable<ELOOCMANCHK>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DHMPIDJKBID
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int KOFDGDNHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int GDNIMDMEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type DFPKAIHAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	ELOOCMANCHK[] PPHPDHHNAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LLFBGIAJHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) KLLJEELKBHM(Entity NCLCOHLPCDH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class DDDCLKKDAAH : KFPPKMEOEEE, IEnumerable<ELOOCMANCHK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<ELOOCMANCHK> OFNGBBKPODL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C8E0", Offset = "0x6C7BAE0", VA = "0x186C7C8E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ELOOCMANCHK MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C920", Offset = "0x6C7BB20", VA = "0x186C7C920", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C980", Offset = "0x6C7BB80", VA = "0x186C7C980")]
	public DDDCLKKDAAH(IEnumerable<DHMPIDJKBID> NADGMGKPFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C3E0", Offset = "0x6C7B5E0", VA = "0x186C7C3E0")]
	private List<ELOOCMANCHK> DJIHGOPGIHM(IEnumerable<DHMPIDJKBID> NADGMGKPFKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C860", Offset = "0x6C7BA60", VA = "0x186C7C860", Slot = "4")]
	public IEnumerator<ELOOCMANCHK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C860", Offset = "0x6C7BA60", VA = "0x186C7C860", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NGBIPIPMCFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type IPKBEOKHLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string EPPPGDEIJCI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	public NGBIPIPMCFJ(Type IPKBEOKHLIJ, string EPPPGDEIJCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KEAIGPEDJNC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type IPKBEOKHLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string EPPPGDEIJCI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	public KEAIGPEDJNC(Type IPKBEOKHLIJ, string EPPPGDEIJCI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4492AB0", Offset = "0x4491CB0", VA = "0x184492AB0")]
	public static NGBIPIPMCFJ NAHPPBNIJBL(KEAIGPEDJNC<T> GIAODHPPLJH)
	{
		return default(NGBIPIPMCFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum JAENKJJHGLL
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	External = -6
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AMHLBKDNBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public AMHLBKDNBBM()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
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
