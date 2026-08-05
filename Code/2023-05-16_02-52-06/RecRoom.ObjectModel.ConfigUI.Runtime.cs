using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.ObjectModel.ConfigUI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal abstract class APGCBBCDCPB : global::DBPFLEDMPLD<Enum>, EFBGKPJIIIO, FBNAELENGBJ, NDJOIPMMMHP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool PBPKHAIEGMJ(Type LEDIIMFEFLP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D6A0", Offset = "0x6A3C4A0", VA = "0x186A3D6A0")]
	protected APGCBBCDCPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class DBPFLEDMPLD<T> : FBNAELENGBJ, NDJOIPMMMHP where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void KEAHFKNFEEI(Func<T> PDBAEEHCOGN, Action<T> EGKBGLGDJLL, string ICIEGOLHGJN, AFJNBCJHANB FHINIKPHPFG, Func<bool> EJEFNGDJAGA);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void FAFAOCLACGH(Func<int> PDBAEEHCOGN, Action<int> EGKBGLGDJLL, string ICIEGOLHGJN, AFJNBCJHANB FHINIKPHPFG, Func<bool> EJEFNGDJAGA);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KPHLNKFCJNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public DFFGCDANCCG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AFJNBCJHANB property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public KPHLNKFCJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x46621A0", Offset = "0x4660FA0", VA = "0x1846621A0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4662240", Offset = "0x4661040", VA = "0x184662240")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LKCCAGJCIAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::DBPFLEDMPLD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public EGEEJDDGDBH ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public LKCCAGJCIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3A954B0", Offset = "0x3A942B0", VA = "0x183A954B0")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, AFJNBCJHANB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LPGAMFKPJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public LPGAMFKPJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D490", Offset = "0x3A9C290", VA = "0x183A9D490")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D550", Offset = "0x3A9C350", VA = "0x183A9D550")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x36D1080", Offset = "0x36CFE80", VA = "0x1836D1080")]
	protected DBPFLEDMPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36D0800", Offset = "0x36CF600", VA = "0x1836D0800", Slot = "5")]
	public virtual void CLINEHIMLGF(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG, EGEEJDDGDBH IGPBFEAKIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x36D0F80", Offset = "0x36CFD80", VA = "0x1836D0F80", Slot = "6")]
	protected virtual KEAHFKNFEEI PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36D07B0", Offset = "0x36CF5B0", VA = "0x1836D07B0", Slot = "7")]
	protected virtual FAFAOCLACGH BBPNODPHDMP(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36D0CA0", Offset = "0x36CFAA0", VA = "0x1836D0CA0")]
	private static Enum JAGHFKCLBAE(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36D0DA0", Offset = "0x36CFBA0", VA = "0x1836D0DA0")]
	private static void NGHICNDGLCL(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG, Enum MGFMONLLLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class CALMNBIKFCL : JACONLLCPIG, NDJOIPMMMHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private AFJNBCJHANB[] CEKMMBEIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private AFJNBCJHANB[] GNJJFAIPIKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AFJNBCJHANB[] HCIHEKDOGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public AFJNBCJHANB[] MJCDKHPOBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract NMPGGHIBJDP[] KENIAKPGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract NMPGGHIBJDP[] KOBCPDMNJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D970", Offset = "0x6A3C770", VA = "0x186A3D970", Slot = "6")]
	public void OLEPBNNLDDG(ENDOBGIHNAA EOGAOOPCPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void CLINEHIMLGF(DFFGCDANCCG JLCKEKEMPNL, EGEEJDDGDBH IGPBFEAKIJL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2606810", Offset = "0x2605610", VA = "0x182606810")]
	protected static T CKFBCLOMJFB<T>(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2606860", Offset = "0x2605660", VA = "0x182606860")]
	protected static void KMGLCOFHKPD<T>(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG, T MGFMONLLLPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected CALMNBIKFCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class DCKBIAAIBKB<T> : FBNAELENGBJ, NDJOIPMMMHP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void OBJACBGBBBF(Func<T> PDBAEEHCOGN, Action<T> EGKBGLGDJLL, string ICIEGOLHGJN, AFJNBCJHANB FHINIKPHPFG, Func<bool> EJEFNGDJAGA);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LGFJNDOHKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public DFFGCDANCCG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AFJNBCJHANB property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public LGFJNDOHKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0C60", Offset = "0x2BEFA60", VA = "0x182BF0C60")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF0F60", Offset = "0x2BEFD60", VA = "0x182BF0F60")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2F898E0", Offset = "0x2F886E0", VA = "0x182F898E0")]
	protected DCKBIAAIBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2F88970", Offset = "0x2F87770", VA = "0x182F88970", Slot = "4")]
	public void CLINEHIMLGF(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG, EGEEJDDGDBH IGPBFEAKIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2F87D40", Offset = "0x2F86B40", VA = "0x182F87D40")]
	private static T CKFBCLOMJFB(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2F893B0", Offset = "0x2F881B0", VA = "0x182F893B0")]
	private static void KMGLCOFHKPD(DFFGCDANCCG JLCKEKEMPNL, AFJNBCJHANB FHINIKPHPFG, T MGFMONLLLPD)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DKGMECGHCPI(OJBFOICGDOF.ConfigUI)]
	[GDFKOGKEDCG(typeof(NCLNNMLONGG), new string[] { })]
	internal class ConfigUIService : NCLNNMLONGG, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[DNEBGGIIGBA]
		private ENDOBGIHNAA EOGAOOPCPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[DNEBGGIIGBA]
		private JDPMGELIKJO KBHBIMKFALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[DNEBGGIIGBA]
		private EGEEJDDGDBH JLCDFGFODEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private IDMHJLLJABO CLECBANNEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private DFFGCDANCCG JLCKEKEMPNL;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E3A0", Offset = "0x6A3D1A0", VA = "0x186A3E3A0", Slot = "5")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E430", Offset = "0x6A3D230", VA = "0x186A3E430", Slot = "6")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E2B0", Offset = "0x6A3D0B0", VA = "0x186A3E2B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E760", Offset = "0x6A3D560", VA = "0x186A3E760", Slot = "4")]
		public void OOLHOCBDKAP(DFFGCDANCCG ILNCLJENEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DFA0", Offset = "0x6A3CDA0", VA = "0x186A3DFA0")]
		private void BFNJDIHCFFJ(DFFGCDANCCG ILNCLJENEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E730", Offset = "0x6A3D530", VA = "0x186A3E730")]
		private void KEPFCMMEIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E030", Offset = "0x6A3CE30", VA = "0x186A3E030")]
		private void CLINEHIMLGF(JOHDMPOCOFJ CHGNKIOLBEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[OKGGIPPFFAJ(0)]
internal class JPFNGIPKHBP : APGCBBCDCPB
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A40F90", Offset = "0x6A3FD90", VA = "0x186A40F90", Slot = "9")]
	public override bool PBPKHAIEGMJ(Type LEDIIMFEFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A41040", Offset = "0x6A3FE40", VA = "0x186A41040", Slot = "6")]
	protected override KEAHFKNFEEI PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D6A0", Offset = "0x6A3C4A0", VA = "0x186A3D6A0")]
	public JPFNGIPKHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[OKGGIPPFFAJ(0)]
internal class NMPEJOKHBMF : APGCBBCDCPB
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A42C20", Offset = "0x6A41A20", VA = "0x186A42C20", Slot = "9")]
	public override bool PBPKHAIEGMJ(Type LEDIIMFEFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A42CD0", Offset = "0x6A41AD0", VA = "0x186A42CD0", Slot = "6")]
	protected override KEAHFKNFEEI PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D6A0", Offset = "0x6A3C4A0", VA = "0x186A3D6A0")]
	public NMPEJOKHBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CLCBCBEONGO(typeof(ILPOIGODDEM), 1)]
internal class MGIFPMNKPHD : global::DBPFLEDMPLD<ILPOIGODDEM>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A415F0", Offset = "0x6A403F0", VA = "0x186A415F0", Slot = "7")]
	protected override FAFAOCLACGH BBPNODPHDMP(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A416E0", Offset = "0x6A404E0", VA = "0x186A416E0")]
	public MGIFPMNKPHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MCONAEFHPPD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A41450", Offset = "0x6A40250", VA = "0x186A41450")]
	public static bool JEFDDDBGBGF(this AFJNBCJHANB FHINIKPHPFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[PKIBONCIFLD(2)]
internal class NIIOCELKGNH : CALMNBIKFCL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NOCNFAKPILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DFFGCDANCCG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NIIOCELKGNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NOCNFAKPILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A42DC0", Offset = "0x6A41BC0", VA = "0x186A42DC0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A42EF0", Offset = "0x6A41CF0", VA = "0x186A42EF0")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override NMPGGHIBJDP[] KOBCPDMNJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A42B40", Offset = "0x6A41940", VA = "0x186A42B40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override NMPGGHIBJDP[] KENIAKPGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A42A60", Offset = "0x6A41860", VA = "0x186A42A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A426A0", Offset = "0x6A414A0", VA = "0x186A426A0", Slot = "10")]
	public override void CLINEHIMLGF(DFFGCDANCCG JLCKEKEMPNL, EGEEJDDGDBH IGPBFEAKIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public NIIOCELKGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CLCBCBEONGO(typeof(bool))]
internal class KPHPHEELPHC : global::DCKBIAAIBKB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A41320", Offset = "0x6A40120", VA = "0x186A41320", Slot = "5")]
	protected override OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A41410", Offset = "0x6A40210", VA = "0x186A41410")]
	public KPHPHEELPHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CLCBCBEONGO(typeof(FixedString32))]
internal class MPMFCPJEEMC : global::DCKBIAAIBKB<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BNILLLINJHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EGEEJDDGDBH ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BNILLLINJHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D7E0", Offset = "0x6A3C5E0", VA = "0x186A3D7E0")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, AFJNBCJHANB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KINJOFKEJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public KINJOFKEJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A41130", Offset = "0x6A3FF30", VA = "0x186A41130")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A411A0", Offset = "0x6A3FFA0", VA = "0x186A411A0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A42260", Offset = "0x6A41060", VA = "0x186A42260", Slot = "5")]
	protected override OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A42320", Offset = "0x6A41120", VA = "0x186A42320")]
	public MPMFCPJEEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CLCBCBEONGO(typeof(FixedString64))]
internal class BFALBLNPDHG : global::DCKBIAAIBKB<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JGNFGHLDPGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EGEEJDDGDBH ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JGNFGHLDPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A40E00", Offset = "0x6A3FC00", VA = "0x186A40E00")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, AFJNBCJHANB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OENCDIDNIDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OENCDIDNIDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A42F80", Offset = "0x6A41D80", VA = "0x186A42F80")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A43010", Offset = "0x6A41E10", VA = "0x186A43010")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D6E0", Offset = "0x6A3C4E0", VA = "0x186A3D6E0", Slot = "5")]
	protected override OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D7A0", Offset = "0x6A3C5A0", VA = "0x186A3D7A0")]
	public BFALBLNPDHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CLCBCBEONGO(typeof(float))]
internal class OIIOOPBANPN : global::DCKBIAAIBKB<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A430B0", Offset = "0x6A41EB0", VA = "0x186A430B0", Slot = "5")]
	protected override OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A431A0", Offset = "0x6A41FA0", VA = "0x186A431A0")]
	public OIIOOPBANPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CLCBCBEONGO(typeof(int))]
internal class PMBIJANMMPH : global::DCKBIAAIBKB<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A435A0", Offset = "0x6A423A0", VA = "0x186A435A0", Slot = "5")]
	protected override OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A43690", Offset = "0x6A42490", VA = "0x186A43690")]
	public PMBIJANMMPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[CLCBCBEONGO(typeof(uint))]
internal class KJBNJGPFPAO : global::DCKBIAAIBKB<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HGNPNFMGDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EGEEJDDGDBH ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HGNPNFMGDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F650", Offset = "0x6A3E450", VA = "0x186A3F650")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, AFJNBCJHANB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AEDKKLCHALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public AEDKKLCHALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D5F0", Offset = "0x6A3C3F0", VA = "0x186A3D5F0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D640", Offset = "0x6A3C440", VA = "0x186A3D640")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A41220", Offset = "0x6A40020", VA = "0x186A41220", Slot = "5")]
	protected override OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A412E0", Offset = "0x6A400E0", VA = "0x186A412E0")]
	public KJBNJGPFPAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CLCBCBEONGO(typeof(Vector3))]
internal class DMFBMJOLMGA : global::DCKBIAAIBKB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PNJDBCFJPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public EGEEJDDGDBH ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PNJDBCFJPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A436D0", Offset = "0x6A424D0", VA = "0x186A436D0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, AFJNBCJHANB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CIDBPMMBBKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CIDBPMMBBKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DD80", Offset = "0x6A3CB80", VA = "0x186A3DD80")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DDE0", Offset = "0x6A3CBE0", VA = "0x186A3DDE0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DDF0", Offset = "0x6A3CBF0", VA = "0x186A3DDF0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DE50", Offset = "0x6A3CC50", VA = "0x186A3DE50")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DE60", Offset = "0x6A3CC60", VA = "0x186A3DE60")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DEC0", Offset = "0x6A3CCC0", VA = "0x186A3DEC0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ED20", Offset = "0x6A3DB20", VA = "0x186A3ED20", Slot = "5")]
	protected override OBJACBGBBBF PEKDLFNNPDB(EGEEJDDGDBH IGPBFEAKIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EDE0", Offset = "0x6A3DBE0", VA = "0x186A3EDE0")]
	public DMFBMJOLMGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct JOHDMPOCOFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int HGJGEMGMDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int LEAHPALFDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int OBAOEICHDDL;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class FDJLAFAOAFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EE20", Offset = "0x6A3DC20", VA = "0x186A3EE20")]
	public static void FABLAKADOEL(Type MJOBDIFFACL, Type NKIMLIHAJAL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct PIJIHLCPIKK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A433C0", Offset = "0x6A421C0", VA = "0x186A433C0")]
	public static NativeList<int> HGIBFIDGMMC(DFFGCDANCCG JLCKEKEMPNL, JDPMGELIKJO KBHBIMKFALK)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A431E0", Offset = "0x6A41FE0", VA = "0x186A431E0")]
	private static bool GLNMMCNCLHD(AFJNBCJHANB FHINIKPHPFG, DFFGCDANCCG JLCKEKEMPNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class MHOGLFGIIPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly JDPMGELIKJO KBHBIMKFALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ENDOBGIHNAA EOGAOOPCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EGEEJDDGDBH IGPBFEAKIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<JOHDMPOCOFJ> PFIIOGIAALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<DIPMPDBMMIB> KCBDFLAFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<DIPMPDBMMIB, List<JOHDMPOCOFJ>> BAIAHEJKOKG;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A42140", Offset = "0x6A40F40", VA = "0x186A42140")]
	public MHOGLFGIIPJ(JDPMGELIKJO KBHBIMKFALK, ENDOBGIHNAA EOGAOOPCPLC, EGEEJDDGDBH IGPBFEAKIJL, Action<JOHDMPOCOFJ> PFIIOGIAALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A41720", Offset = "0x6A40520", VA = "0x186A41720")]
	public void FDLCHDMDOHD(NativeList<JOHDMPOCOFJ> BMAOHLJPJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A41BA0", Offset = "0x6A409A0", VA = "0x186A41BA0")]
	private void ODFEBCAJJDB(DIPMPDBMMIB HCBJJHBALOA, JOHDMPOCOFJ CHGNKIOLBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A41AA0", Offset = "0x6A408A0", VA = "0x186A41AA0")]
	public void HPGFGAJPDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A41CC0", Offset = "0x6A40AC0", VA = "0x186A41CC0")]
	private void PCEIDJNGFDL(DIPMPDBMMIB HCBJJHBALOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A41B00", Offset = "0x6A40900", VA = "0x186A41B00")]
	private void JPANLBEPFCH(DIPMPDBMMIB HCBJJHBALOA)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[DKGMECGHCPI(OJBFOICGDOF.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IJCBMGNHGEC : IEnumerable<AFJNBCJHANB>, IEnumerable, IEnumerator<AFJNBCJHANB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private AFJNBCJHANB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public PropertiesByType <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Type <>3__type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private NativeMultiHashMap<long, int>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private AFJNBCJHANB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
			[DebuggerHidden]
			public IJCBMGNHGEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6A40D30", Offset = "0x6A3FB30", VA = "0x186A40D30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6A409F0", Offset = "0x6A3F7F0", VA = "0x186A409F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A40DB0", Offset = "0x6A3FBB0", VA = "0x186A40DB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6A40CF0", Offset = "0x6A3FAF0", VA = "0x186A40CF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6A40C40", Offset = "0x6A3FA40", VA = "0x186A40C40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AFJNBCJHANB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6A40C40", Offset = "0x6A3FA40", VA = "0x186A40C40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly ENDOBGIHNAA EOGAOOPCPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> KAINHIANPFG;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A43C00", Offset = "0x6A42A00", VA = "0x186A43C00")]
		public PropertiesByType(ENDOBGIHNAA EOGAOOPCPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A43B20", Offset = "0x6A42920", VA = "0x186A43B20")]
		[IteratorStateMachine(typeof(IJCBMGNHGEC))]
		public IEnumerable<AFJNBCJHANB> MKODELADIEJ(Type LEDIIMFEFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A20", Offset = "0x6A42820", VA = "0x186A43A20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A60", Offset = "0x6A42860", VA = "0x186A43A60")]
		private long ECNDPBFDCOL(AFJNBCJHANB FHINIKPHPFG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A43AE0", Offset = "0x6A428E0", VA = "0x186A43AE0")]
		private long ECNDPBFDCOL(Type LEDIIMFEFLP)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct NGAPKOAEOLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray DIHNOIMEPOD;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A42660", Offset = "0x6A41460", VA = "0x186A42660")]
	public NGAPKOAEOLG(int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A42430", Offset = "0x6A41230", VA = "0x186A42430")]
	public static NGAPKOAEOLG EABPDADEABG(int JNGKGNOBDKI, NativeArray<int> PGPGHEAKODE)
	{
		return default(NGAPKOAEOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A42650", Offset = "0x6A41450", VA = "0x186A42650")]
	public bool LLIHFOFDBAK(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A42640", Offset = "0x6A41440", VA = "0x186A42640")]
	public void KKNDJJJFEOO(int NNHNOIMLALG, bool MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A42580", Offset = "0x6A41380", VA = "0x186A42580")]
	public bool HHOEPGKIPHC(AFJNBCJHANB[] PGPGHEAKODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A42360", Offset = "0x6A41160", VA = "0x186A42360")]
	public bool BPJBBAJCAEM(AFJNBCJHANB[] PGPGHEAKODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A42420", Offset = "0x6A41220", VA = "0x186A42420", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class IDMHJLLJABO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FGEMECIGOCC EKOKIILLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JDPMGELIKJO KBHBIMKFALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ENDOBGIHNAA EOGAOOPCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<NDJOIPMMMHP> HNOGDPMGFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType KAINHIANPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> BHAKGCPHOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> GJMFEKGKPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<NDJOIPMMMHP> DMOFICCJJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A408A0", Offset = "0x6A3F6A0", VA = "0x186A408A0")]
	public IDMHJLLJABO(JDPMGELIKJO KBHBIMKFALK, ENDOBGIHNAA EOGAOOPCPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A40320", Offset = "0x6A3F120", VA = "0x186A40320")]
	public void NFGECJODELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FA00", Offset = "0x6A3E800", VA = "0x186A3FA00")]
	public void DLDOAPMDCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A403F0", Offset = "0x6A3F1F0", VA = "0x186A403F0")]
	public NativeList<JOHDMPOCOFJ> OFONOIBHOGD(NativeArray<int> PGPGHEAKODE)
	{
		return default(NativeList<JOHDMPOCOFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A40180", Offset = "0x6A3EF80", VA = "0x186A40180")]
	private bool IEFAKPDMOIF(NDJOIPMMMHP JLJJAJLHEKD, NGAPKOAEOLG FKKPCNFGPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2921330", Offset = "0x2920130", VA = "0x182921330")]
	private void AFHJEAHKICE<TInterface, TAttribute>(Action<TInterface, TAttribute> PKDEAGINFGJ) where TInterface : NDJOIPMMMHP where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F830", Offset = "0x6A3E630", VA = "0x186A3F830")]
	private void ABNOFHIJAPH(Type LEDIIMFEFLP, Type IEFHFJHIGFP, Type AKOKIGIPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x29215D0", Offset = "0x29203D0", VA = "0x1829215D0")]
	private TInterface BJHIINNCLKD<TInterface>(Type LEDIIMFEFLP)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A40250", Offset = "0x6A3F050", VA = "0x186A40250")]
	private void MMBMILHPKCI(NDJOIPMMMHP JLJJAJLHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FE20", Offset = "0x6A3EC20", VA = "0x186A3FE20")]
	private int FIGODKLFCLE(NDJOIPMMMHP FLAOLFPMFAI, int OBAOEICHDDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FB70", Offset = "0x6A3E970", VA = "0x186A3FB70")]
	private void FBAOABHNLCA(FBNAELENGBJ JLJJAJLHEKD, CLCBCBEONGO PGLBDHMCIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FEC0", Offset = "0x6A3ECC0", VA = "0x186A3FEC0")]
	private void HPMKDJLKHHB(EFBGKPJIIIO JLJJAJLHEKD, OKGGIPPFFAJ PGLBDHMCIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F860", Offset = "0x6A3E660", VA = "0x186A3F860")]
	private void DFJDJLNEIJF(JACONLLCPIG JLJJAJLHEKD, PKIBONCIFLD PGLBDHMCIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct FJNDHNFCGBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ENDOBGIHNAA EOGAOOPCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<NDJOIPMMMHP> HNOGDPMGFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<JOHDMPOCOFJ> EODEODHPFBG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<JOHDMPOCOFJ> KOJCOIAMHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD5A960", Offset = "0xD59760", VA = "0x180D5A960")]
		get
		{
			return default(NativeList<JOHDMPOCOFJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F5D0", Offset = "0x6A3E3D0", VA = "0x186A3F5D0")]
	public FJNDHNFCGBM(ENDOBGIHNAA EOGAOOPCPLC, List<NDJOIPMMMHP> HNOGDPMGFLH, NativeArray<JOHDMPOCOFJ> BMAOHLJPJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EF00", Offset = "0x6A3DD00", VA = "0x186A3EF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F010", Offset = "0x6A3DE10", VA = "0x186A3F010")]
	private NativeList<JOHDMPOCOFJ> HMKKPGDKIMG(NativeArray<JOHDMPOCOFJ> ELEJJAAOBBE)
	{
		return default(NativeList<JOHDMPOCOFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EF40", Offset = "0x6A3DD40", VA = "0x186A3EF40")]
	private bool GJNLAKKKEGG(NDJOIPMMMHP JLJJAJLHEKD, NGAPKOAEOLG NANAIHEIMML, int LEAHPALFDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F410", Offset = "0x6A3E210", VA = "0x186A3F410")]
	private void LJHODFICAKC(NDJOIPMMMHP JLJJAJLHEKD, NGAPKOAEOLG DIHNOIMEPOD, int LEAHPALFDGB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct MFGHFMIFHIA : IComparer<JOHDMPOCOFJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A41590", Offset = "0x6A40390", VA = "0x186A41590", Slot = "4")]
	public int Compare(JOHDMPOCOFJ GCKGDDMIIDO, JOHDMPOCOFJ EJKHFJILHAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A415A0", Offset = "0x6A403A0", VA = "0x186A415A0")]
	public static void NCJICEPHCBO(NativeList<JOHDMPOCOFJ> BMAOHLJPJMK)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : JHKNIKIBBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A43F00", Offset = "0x6A42D00", VA = "0x186A43F00", Slot = "6")]
		public sealed override void BBOGNFJPIAG(KOGMDLCFDAH FNIOCOFMFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A44000", Offset = "0x6A42E00", VA = "0x186A44000", Slot = "4")]
		public sealed override void FODOGCDFONM()
		{
		}
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
