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
internal abstract class DGKNKMFDGCI : global::FHGPODALPKD<Enum>, ONHBNOEKCHO, MNKLAHEDEFC, IOOPNCLDJMK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool HBNEONCBNHC(Type EMKINACMDLO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D4A0", Offset = "0x6A7BEA0", VA = "0x186A7D4A0")]
	protected DGKNKMFDGCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class FHGPODALPKD<T> : MNKLAHEDEFC, IOOPNCLDJMK where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void FMKADLIIPAG(Func<T> HBIBAMJCHGF, Action<T> POGHGGJFFJI, string KMEGKECOLPJ, KHBNAMDANEI EELLPGLCOLL, Func<bool> FPDDGAGJOGL);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void OPIHAGLCFML(Func<int> HBIBAMJCHGF, Action<int> POGHGGJFFJI, string KMEGKECOLPJ, KHBNAMDANEI EELLPGLCOLL, Func<bool> FPDDGAGJOGL);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KFIILMEJNMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public ACDEDGBHHIP targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KHBNAMDANEI property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public KFIILMEJNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x46494B0", Offset = "0x4647EB0", VA = "0x1846494B0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4649590", Offset = "0x4647F90", VA = "0x184649590")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LGELKCFPLDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::FHGPODALPKD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public FOMOFGEHMFK ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public LGELKCFPLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2A0D820", Offset = "0x2A0C220", VA = "0x182A0D820")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, KHBNAMDANEI property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FIKKOLGLBFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public FIKKOLGLBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4E49C50", Offset = "0x4E48650", VA = "0x184E49C50")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E49DA0", Offset = "0x4E487A0", VA = "0x184E49DA0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EFB0", Offset = "0x4E2D9B0", VA = "0x184E2EFB0")]
	protected FHGPODALPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E690", Offset = "0x4E2D090", VA = "0x184E2E690", Slot = "5")]
	public virtual void AIICKILIPEJ(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL, FOMOFGEHMFK CDCPEDOIOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E2ECD0", Offset = "0x4E2D6D0", VA = "0x184E2ECD0", Slot = "6")]
	protected virtual FMKADLIIPAG ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EB30", Offset = "0x4E2D530", VA = "0x184E2EB30", Slot = "7")]
	protected virtual OPIHAGLCFML EKHJNMNCHNI(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EBD0", Offset = "0x4E2D5D0", VA = "0x184E2EBD0")]
	private static Enum HEMLNJFKKEB(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EDD0", Offset = "0x4E2D7D0", VA = "0x184E2EDD0")]
	private static void NGELKOOMBLH(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL, Enum MFBGAMJDOKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class NBMDJLICGNP : KFGGNABFHAH, IOOPNCLDJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private KHBNAMDANEI[] IPMOHDMJABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KHBNAMDANEI[] KEPBKNDKBAC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KHBNAMDANEI[] MFCLFNKLJME
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public KHBNAMDANEI[] ELCMIBJGCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract ELPOGHCFKOG[] BOMIKAPKCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract ELPOGHCFKOG[] BKJCBPCBADD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A807D0", Offset = "0x6A7F1D0", VA = "0x186A807D0", Slot = "6")]
	public void LFPDFEJCFOP(IADMOPFMJCJ OCNJOCPCLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void AIICKILIPEJ(ACDEDGBHHIP EBADNMAAKAL, FOMOFGEHMFK CDCPEDOIOOD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C7AF30", Offset = "0x3C79930", VA = "0x183C7AF30")]
	protected static T PAFEBKHJKEN<T>(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C7AE60", Offset = "0x3C79860", VA = "0x183C7AE60")]
	protected static void AIMCNDPKEMM<T>(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL, T MFBGAMJDOKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected NBMDJLICGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class JDJDMJLGFPG<T> : MNKLAHEDEFC, IOOPNCLDJMK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void NDPMIDGCNAA(Func<T> HBIBAMJCHGF, Action<T> POGHGGJFFJI, string KMEGKECOLPJ, KHBNAMDANEI EELLPGLCOLL, Func<bool> FPDDGAGJOGL);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GPGEKACNEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ACDEDGBHHIP targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KHBNAMDANEI property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public GPGEKACNEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x494D770", Offset = "0x494C170", VA = "0x18494D770")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x494D930", Offset = "0x494C330", VA = "0x18494D930")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x407B600", Offset = "0x407A000", VA = "0x18407B600")]
	protected JDJDMJLGFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x407A3F0", Offset = "0x4078DF0", VA = "0x18407A3F0", Slot = "4")]
	public void AIICKILIPEJ(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL, FOMOFGEHMFK CDCPEDOIOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3FBA330", Offset = "0x3FB8D30", VA = "0x183FBA330")]
	private static T PAFEBKHJKEN(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x407AF80", Offset = "0x4079980", VA = "0x18407AF80")]
	private static void AIMCNDPKEMM(ACDEDGBHHIP EBADNMAAKAL, KHBNAMDANEI EELLPGLCOLL, T MFBGAMJDOKA)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ConfigUI)]
	[LHOECCIDBFM(typeof(MAOOMPMLEIO), new string[] { })]
	internal class ConfigUIService : MAOOMPMLEIO, HNADMPPHDEF, BCGODABHHDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[JLCJNHHCBDK]
		private IADMOPFMJCJ OCNJOCPCLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[JLCJNHHCBDK]
		private FJMMLNOOMII MANHCCPKHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[JLCJNHHCBDK]
		private FOMOFGEHMFK BNIMEHMHOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NAALGCPJMKJ IGLBLAPJDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ACDEDGBHHIP EBADNMAAKAL;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D3C0", Offset = "0x6A7BDC0", VA = "0x186A7D3C0", Slot = "5")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D030", Offset = "0x6A7BA30", VA = "0x186A7D030", Slot = "6")]
		public void IEKFIHLPDKC(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CF10", Offset = "0x6A7B910", VA = "0x186A7CF10", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A7C9A0", Offset = "0x6A7B3A0", VA = "0x186A7C9A0", Slot = "4")]
		public void CLNIOLFIFPG(ACDEDGBHHIP ENDNMLCFFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D330", Offset = "0x6A7BD30", VA = "0x186A7D330")]
		private void KPKBLHCIADO(ACDEDGBHHIP ENDNMLCFFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D000", Offset = "0x6A7BA00", VA = "0x186A7D000")]
		private void GIJOMECCNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A7C720", Offset = "0x6A7B120", VA = "0x186A7C720")]
		private void AIICKILIPEJ(OAONBAIDACH PMLELGOHGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[MGKDAJHNHFN(0)]
internal class EGLOJJBKONI : DGKNKMFDGCI
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D610", Offset = "0x6A7C010", VA = "0x186A7D610", Slot = "9")]
	public override bool HBNEONCBNHC(Type EMKINACMDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D6C0", Offset = "0x6A7C0C0", VA = "0x186A7D6C0", Slot = "6")]
	protected override FMKADLIIPAG ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D4A0", Offset = "0x6A7BEA0", VA = "0x186A7D4A0")]
	public EGLOJJBKONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[MGKDAJHNHFN(0)]
internal class NAJBGPDLOBI : DGKNKMFDGCI
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A80630", Offset = "0x6A7F030", VA = "0x186A80630", Slot = "9")]
	public override bool HBNEONCBNHC(Type EMKINACMDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A806E0", Offset = "0x6A7F0E0", VA = "0x186A806E0", Slot = "6")]
	protected override FMKADLIIPAG ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D4A0", Offset = "0x6A7BEA0", VA = "0x186A7D4A0")]
	public NAJBGPDLOBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[OHPKPHNLHHF(typeof(ONBGHJMOMNI), 1)]
internal class LLGLPHAONKC : global::FHGPODALPKD<ONBGHJMOMNI>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F120", Offset = "0x6A7DB20", VA = "0x186A7F120", Slot = "7")]
	protected override OPIHAGLCFML EKHJNMNCHNI(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F210", Offset = "0x6A7DC10", VA = "0x186A7F210")]
	public LLGLPHAONKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PCHDEPGOCCD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A81850", Offset = "0x6A80250", VA = "0x186A81850")]
	public static bool AOJLLMEAAMJ(this KHBNAMDANEI EELLPGLCOLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[JPKFDLIKGGC(2)]
internal class KJOFKMGMMPE : NBMDJLICGNP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HNJMBLLKMEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public ACDEDGBHHIP targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KJOFKMGMMPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public HNJMBLLKMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E240", Offset = "0x6A7CC40", VA = "0x186A7E240")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E370", Offset = "0x6A7CD70", VA = "0x186A7E370")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override ELPOGHCFKOG[] BKJCBPCBADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EE10", Offset = "0x6A7D810", VA = "0x186A7EE10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override ELPOGHCFKOG[] BOMIKAPKCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A7ED30", Offset = "0x6A7D730", VA = "0x186A7ED30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E970", Offset = "0x6A7D370", VA = "0x186A7E970", Slot = "10")]
	public override void AIICKILIPEJ(ACDEDGBHHIP EBADNMAAKAL, FOMOFGEHMFK CDCPEDOIOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KJOFKMGMMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OHPKPHNLHHF(typeof(bool))]
internal class KCDBAEKKPMB : global::JDJDMJLGFPG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E840", Offset = "0x6A7D240", VA = "0x186A7E840", Slot = "5")]
	protected override NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E930", Offset = "0x6A7D330", VA = "0x186A7E930")]
	public KCDBAEKKPMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[OHPKPHNLHHF(typeof(FixedString32))]
internal class AFGCLAMAOJA : global::JDJDMJLGFPG<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BBJELLFAOEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FOMOFGEHMFK ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public BBJELLFAOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7BDB0", Offset = "0x6A7A7B0", VA = "0x186A7BDB0")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, KHBNAMDANEI property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IMFNGFFMKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public IMFNGFFMKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E400", Offset = "0x6A7CE00", VA = "0x186A7E400")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E470", Offset = "0x6A7CE70", VA = "0x186A7E470")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B6C0", Offset = "0x6A7A0C0", VA = "0x186A7B6C0", Slot = "5")]
	protected override NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B780", Offset = "0x6A7A180", VA = "0x186A7B780")]
	public AFGCLAMAOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OHPKPHNLHHF(typeof(FixedString64))]
internal class GPHJKDLJKPI : global::JDJDMJLGFPG<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FPALGNBIAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FOMOFGEHMFK ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public FPALGNBIAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D860", Offset = "0x6A7C260", VA = "0x186A7D860")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, KHBNAMDANEI property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LADHDIALCAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public LADHDIALCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A7EFF0", Offset = "0x6A7D9F0", VA = "0x186A7EFF0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F080", Offset = "0x6A7DA80", VA = "0x186A7F080")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E140", Offset = "0x6A7CB40", VA = "0x186A7E140", Slot = "5")]
	protected override NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E200", Offset = "0x6A7CC00", VA = "0x186A7E200")]
	public GPHJKDLJKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OHPKPHNLHHF(typeof(float))]
internal class NPJGCCNLLKE : global::JDJDMJLGFPG<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A80BE0", Offset = "0x6A7F5E0", VA = "0x186A80BE0", Slot = "5")]
	protected override NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A80CD0", Offset = "0x6A7F6D0", VA = "0x186A80CD0")]
	public NPJGCCNLLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OHPKPHNLHHF(typeof(int))]
internal class DKPCJIJAGLI : global::JDJDMJLGFPG<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D4E0", Offset = "0x6A7BEE0", VA = "0x186A7D4E0", Slot = "5")]
	protected override NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D5D0", Offset = "0x6A7BFD0", VA = "0x186A7D5D0")]
	public DKPCJIJAGLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[OHPKPHNLHHF(typeof(uint))]
internal class KNJEKNADFLK : global::JDJDMJLGFPG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AFJOLPHKDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FOMOFGEHMFK ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public AFJOLPHKDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A7BBD0", Offset = "0x6A7A5D0", VA = "0x186A7BBD0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, KHBNAMDANEI property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EIGNHKIDDNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public EIGNHKIDDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D7B0", Offset = "0x6A7C1B0", VA = "0x186A7D7B0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D800", Offset = "0x6A7C200", VA = "0x186A7D800")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EEF0", Offset = "0x6A7D8F0", VA = "0x186A7EEF0", Slot = "5")]
	protected override NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EFB0", Offset = "0x6A7D9B0", VA = "0x186A7EFB0")]
	public KNJEKNADFLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[OHPKPHNLHHF(typeof(Vector3))]
internal class PEONHNDMADE : global::JDJDMJLGFPG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JNEPAHFHNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FOMOFGEHMFK ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public JNEPAHFHNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E4F0", Offset = "0x6A7CEF0", VA = "0x186A7E4F0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, KHBNAMDANEI property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MPKMCDNCMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public MPKMCDNCMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F250", Offset = "0x6A7DC50", VA = "0x186A7F250")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F2B0", Offset = "0x6A7DCB0", VA = "0x186A7F2B0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F2C0", Offset = "0x6A7DCC0", VA = "0x186A7F2C0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F320", Offset = "0x6A7DD20", VA = "0x186A7F320")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F330", Offset = "0x6A7DD30", VA = "0x186A7F330")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F390", Offset = "0x6A7DD90", VA = "0x186A7F390")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A81990", Offset = "0x6A80390", VA = "0x186A81990", Slot = "5")]
	protected override NDPMIDGCNAA ILGNNKCPBPE(FOMOFGEHMFK CDCPEDOIOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A81A50", Offset = "0x6A80450", VA = "0x186A81A50")]
	public PEONHNDMADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct OAONBAIDACH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int IFMFOBEKBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int EEBMEHBPFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int ALIOAOHFFLI;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class BLPNFGHKHFK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BF40", Offset = "0x6A7A940", VA = "0x186A7BF40")]
	public static void EJHGKAEJCPM(Type OKLMOIDBNFD, Type COBLMCPPHHF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct CEOMLCOEEBP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C020", Offset = "0x6A7AA20", VA = "0x186A7C020")]
	public static NativeList<int> NJHGBBGHLIB(ACDEDGBHHIP EBADNMAAKAL, FJMMLNOOMII MANHCCPKHNP)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C200", Offset = "0x6A7AC00", VA = "0x186A7C200")]
	private static bool OFAPMOOEJAN(KHBNAMDANEI EELLPGLCOLL, ACDEDGBHHIP EBADNMAAKAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OCPLFDGLNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FJMMLNOOMII MANHCCPKHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly IADMOPFMJCJ OCNJOCPCLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FOMOFGEHMFK CDCPEDOIOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<OAONBAIDACH> AGEANPAHMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<BEFPJHEDGEB> CENFGLCOGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<BEFPJHEDGEB, List<OAONBAIDACH>> FNGKMIPFMGI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A81730", Offset = "0x6A80130", VA = "0x186A81730")]
	public OCPLFDGLNOC(FJMMLNOOMII MANHCCPKHNP, IADMOPFMJCJ OCNJOCPCLED, FOMOFGEHMFK CDCPEDOIOOD, Action<OAONBAIDACH> AGEANPAHMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A813B0", Offset = "0x6A7FDB0", VA = "0x186A813B0")]
	public void OFMEBFEKNMB(NativeList<OAONBAIDACH> JEIKDNBBDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A80D10", Offset = "0x6A7F710", VA = "0x186A80D10")]
	private void CAMKFALBGMJ(BEFPJHEDGEB HGPMMCNKFAN, OAONBAIDACH PMLELGOHGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A80E30", Offset = "0x6A7F830", VA = "0x186A80E30")]
	public void DDFMHAAPPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A80F30", Offset = "0x6A7F930", VA = "0x186A80F30")]
	private void LABKNLEDEJN(BEFPJHEDGEB HGPMMCNKFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A80E90", Offset = "0x6A7F890", VA = "0x186A80E90")]
	private void GEAMOIFDNDP(BEFPJHEDGEB HGPMMCNKFAN)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[KEFMDJAGLBH(IGKCNDFEDMC.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class AFHHFIGNPEO : IEnumerable<KHBNAMDANEI>, IEnumerable, IEnumerator<KHBNAMDANEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private KHBNAMDANEI <>2__current;

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
			private KHBNAMDANEI System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
			[DebuggerHidden]
			public AFHHFIGNPEO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6A7BB00", Offset = "0x6A7A500", VA = "0x186A7BB00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6A7B7C0", Offset = "0x6A7A1C0", VA = "0x186A7B7C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A7BB80", Offset = "0x6A7A580", VA = "0x186A7BB80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6A7BAC0", Offset = "0x6A7A4C0", VA = "0x186A7BAC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6A7BA10", Offset = "0x6A7A410", VA = "0x186A7BA10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KHBNAMDANEI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6A7BA10", Offset = "0x6A7A410", VA = "0x186A7BA10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly IADMOPFMJCJ OCNJOCPCLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> GADDNGDPMME;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A81C70", Offset = "0x6A80670", VA = "0x186A81C70")]
		public PropertiesByType(IADMOPFMJCJ OCNJOCPCLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A81AD0", Offset = "0x6A804D0", VA = "0x186A81AD0")]
		[IteratorStateMachine(typeof(AFHHFIGNPEO))]
		public IEnumerable<KHBNAMDANEI> GMFOMOEIIMD(Type EMKINACMDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A81A90", Offset = "0x6A80490", VA = "0x186A81A90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A81B60", Offset = "0x6A80560", VA = "0x186A81B60")]
		private long NGFNHOCHPLN(KHBNAMDANEI EELLPGLCOLL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A81BE0", Offset = "0x6A805E0", VA = "0x186A81BE0")]
		private long NGFNHOCHPLN(Type EMKINACMDLO)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct CMOGBICCGFH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray IIMOELAIGLB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C6E0", Offset = "0x6A7B0E0", VA = "0x186A7C6E0")]
	public CMOGBICCGFH(int HGMGPFAJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C580", Offset = "0x6A7AF80", VA = "0x186A7C580")]
	public static CMOGBICCGFH MMDLMPMDNPF(int ICKPJJPJOOC, NativeArray<int> PILEKMCPEGL)
	{
		return default(CMOGBICCGFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C6D0", Offset = "0x6A7B0D0", VA = "0x186A7C6D0")]
	public bool PLGNHPCLDMP(int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C4A0", Offset = "0x6A7AEA0", VA = "0x186A7C4A0")]
	public void CKIEIOOCMAM(int ALJOMNDNEBM, bool MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C4C0", Offset = "0x6A7AEC0", VA = "0x186A7C4C0")]
	public bool LBNOPLEOHLD(KHBNAMDANEI[] PILEKMCPEGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C3E0", Offset = "0x6A7ADE0", VA = "0x186A7C3E0")]
	public bool BGMLMDJMAJP(KHBNAMDANEI[] PILEKMCPEGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C4B0", Offset = "0x6A7AEB0", VA = "0x186A7C4B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class NAALGCPJMKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly NNLEPLPFODN DPMCBMJDHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FJMMLNOOMII MANHCCPKHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IADMOPFMJCJ OCNJOCPCLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<IOOPNCLDJMK> CFKOGNLPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType GADDNGDPMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> PCBHMGPPHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> JJMKELPNJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<IOOPNCLDJMK> OHCFKIGDGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A804E0", Offset = "0x6A7EEE0", VA = "0x186A804E0")]
	public NAALGCPJMKJ(FJMMLNOOMII MANHCCPKHNP, IADMOPFMJCJ OCNJOCPCLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A802C0", Offset = "0x6A7ECC0", VA = "0x186A802C0")]
	public void NOOJKGDANLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FEE0", Offset = "0x6A7E8E0", VA = "0x186A7FEE0")]
	public void LNJKCCEHCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F730", Offset = "0x6A7E130", VA = "0x186A7F730")]
	public NativeList<OAONBAIDACH> EADHGLCPGAG(NativeArray<int> PILEKMCPEGL)
	{
		return default(NativeList<OAONBAIDACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A803C0", Offset = "0x6A7EDC0", VA = "0x186A803C0")]
	private bool ODIDAILPNIC(IOOPNCLDJMK OPCAPHFLKMG, CMOGBICCGFH JEFOMPJPFOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C717E0", Offset = "0x3C701E0", VA = "0x183C717E0")]
	private void EDCIHCBPIEK<TInterface, TAttribute>(Action<TInterface, TAttribute> KGDFIPGCODL) where TInterface : IOOPNCLDJMK where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6A80390", Offset = "0x6A7ED90", VA = "0x186A80390")]
	private void OAFEOPHIHKC(Type EMKINACMDLO, Type EMCKONAKOGC, Type AHIJPEFJDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C71A80", Offset = "0x3C70480", VA = "0x183C71A80")]
	private TInterface OIHAEBEILPP<TInterface>(Type EMKINACMDLO)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A80050", Offset = "0x6A7EA50", VA = "0x186A80050")]
	private void NKLHOBBBKAJ(IOOPNCLDJMK OPCAPHFLKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FB90", Offset = "0x6A7E590", VA = "0x186A7FB90")]
	private int EAIMBPHNDDD(IOOPNCLDJMK BKIHNFJIPMM, int ALIOAOHFFLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FC30", Offset = "0x6A7E630", VA = "0x186A7FC30")]
	private void HIBABCJONOD(MNKLAHEDEFC OPCAPHFLKMG, OHPKPHNLHHF KGJMBLJKCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F470", Offset = "0x6A7DE70", VA = "0x186A7F470")]
	private void CINCEHKLMPL(ONHBNOEKCHO OPCAPHFLKMG, MGKDAJHNHFN KGJMBLJKCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A80120", Offset = "0x6A7EB20", VA = "0x186A80120")]
	private void NNCFJJNBIIM(KFGGNABFHAH OPCAPHFLKMG, JPKFDLIKGGC KGJMBLJKCJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct GMLKLNELOJB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IADMOPFMJCJ OCNJOCPCLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IOOPNCLDJMK> CFKOGNLPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<OAONBAIDACH> FJKFDMLFEKN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<OAONBAIDACH> LDAMPFFDKED
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9650", Offset = "0x8B8050", VA = "0x1808B9650")]
		get
		{
			return default(NativeList<OAONBAIDACH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E0C0", Offset = "0x6A7CAC0", VA = "0x186A7E0C0")]
	public GMLKLNELOJB(IADMOPFMJCJ OCNJOCPCLED, List<IOOPNCLDJMK> CFKOGNLPMDL, NativeArray<OAONBAIDACH> JEIKDNBBDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DFB0", Offset = "0x6A7C9B0", VA = "0x186A7DFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D9F0", Offset = "0x6A7C3F0", VA = "0x186A7D9F0")]
	private NativeList<OAONBAIDACH> APPIGJHLIOB(NativeArray<OAONBAIDACH> PKEJIFLJBCP)
	{
		return default(NativeList<OAONBAIDACH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DFF0", Offset = "0x6A7C9F0", VA = "0x186A7DFF0")]
	private bool IPCFLGKCOKC(IOOPNCLDJMK OPCAPHFLKMG, CMOGBICCGFH LAMPEPAHLGL, int EEBMEHBPFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DDF0", Offset = "0x6A7C7F0", VA = "0x186A7DDF0")]
	private void DGIMHBLGIBH(IOOPNCLDJMK OPCAPHFLKMG, CMOGBICCGFH IIMOELAIGLB, int EEBMEHBPFPJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct ADPACNIDKPL : IComparer<OAONBAIDACH>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B660", Offset = "0x6A7A060", VA = "0x186A7B660", Slot = "4")]
	public int Compare(OAONBAIDACH MGFKDMJBGAK, OAONBAIDACH LPDJCHOFJLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B670", Offset = "0x6A7A070", VA = "0x186A7B670")]
	public static void JNECJFMIGPJ(NativeList<OAONBAIDACH> JEIKDNBBDEO)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : IAAKGJNKLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A820F0", Offset = "0x6A80AF0", VA = "0x186A820F0", Slot = "6")]
		public sealed override void DCGFCAGLEEJ(FOBODKDCELK KFICNKMCGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A81F70", Offset = "0x6A80970", VA = "0x186A81F70", Slot = "4")]
		public sealed override void BGMNFOJPGJK()
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
