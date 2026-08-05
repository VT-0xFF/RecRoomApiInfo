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
internal abstract class MFNMODCGDCL : global::LALPMGALDMA<Enum>, PDIGEMKEHNO, NKEKCKHIMFB, PGKELPJMKED
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool BPMOKHHLLGD(Type FPPBLNEEHBP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FD77A0", Offset = "0x5FD6BA0", VA = "0x185FD77A0")]
	protected MFNMODCGDCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class LALPMGALDMA<T> : NKEKCKHIMFB, PGKELPJMKED where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void PHDACJEABPO(Func<T> CKAFPEKFOKO, Action<T> GKDAJBJDGBP, string DHKKANIEGMN, MCLHOLCKNPA PDLHECKEFMN, Func<bool> OLBFHBGDKIN);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void GLLPKKNOAEH(Func<int> CKAFPEKFOKO, Action<int> GKDAJBJDGBP, string DHKKANIEGMN, MCLHOLCKNPA PDLHECKEFMN, Func<bool> OLBFHBGDKIN);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HDPLIIJFKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public PMKCJIGDPOI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MCLHOLCKNPA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public HDPLIIJFKBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8070", Offset = "0x2FC7470", VA = "0x182FC8070")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2FC81A0", Offset = "0x2FC75A0", VA = "0x182FC81A0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EIDELPECPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::LALPMGALDMA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public MNKDDLKPCKM ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public EIDELPECPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2441C50", Offset = "0x2441050", VA = "0x182441C50")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, MCLHOLCKNPA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LEEOAMIIKJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public LEEOAMIIKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4339990", Offset = "0x4338D90", VA = "0x184339990")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4339C10", Offset = "0x4339010", VA = "0x184339C10")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4337CF0", Offset = "0x43370F0", VA = "0x184337CF0")]
	protected LALPMGALDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x43373D0", Offset = "0x43367D0", VA = "0x1843373D0", Slot = "5")]
	public virtual void CGHNAEKMKKP(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN, MNKDDLKPCKM OLNHBOCBHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4337A10", Offset = "0x4336E10", VA = "0x184337A10", Slot = "6")]
	protected virtual PHDACJEABPO GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43378C0", Offset = "0x4336CC0", VA = "0x1843378C0", Slot = "7")]
	protected virtual GLLPKKNOAEH DKGJGDOONAA(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4337910", Offset = "0x4336D10", VA = "0x184337910")]
	private static Enum FDOJIPNJHOG(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4337B10", Offset = "0x4336F10", VA = "0x184337B10")]
	private static void HCIGNFIALAP(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN, Enum IGDJJEECDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class HPGDPCNPDCP : GMPBFJIAIHA, PGKELPJMKED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MCLHOLCKNPA[] CLOJAGNFDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MCLHOLCKNPA[] HKGDFGAHMMH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MCLHOLCKNPA[] LBCGOMGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MCLHOLCKNPA[] EDIBIFNDMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract PCCBFFGCINK[] MLJIIAFLAON
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract PCCBFFGCINK[] OFJIFHBLCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9460", Offset = "0x5FD8860", VA = "0x185FD9460", Slot = "6")]
	public void KELJHIKJDOE(DNDLCINBGLP BPJKLBMMFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void CGHNAEKMKKP(PMKCJIGDPOI GCPNGOLBJLK, MNKDDLKPCKM OLNHBOCBHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A460", Offset = "0x1F79860", VA = "0x181F7A460")]
	protected static T HMOLEOJFBJH<T>(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A4B0", Offset = "0x1F798B0", VA = "0x181F7A4B0")]
	protected static void MPCIPOIBKFA<T>(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN, T IGDJJEECDAF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected HPGDPCNPDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class NFGCFODAECG<T> : NKEKCKHIMFB, PGKELPJMKED where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void HHJKKABKPJI(Func<T> CKAFPEKFOKO, Action<T> GKDAJBJDGBP, string DHKKANIEGMN, MCLHOLCKNPA PDLHECKEFMN, Func<bool> OLBFHBGDKIN);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NMKAAGJLFFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public PMKCJIGDPOI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MCLHOLCKNPA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public NMKAAGJLFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39CE4F0", Offset = "0x39CD8F0", VA = "0x1839CE4F0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39CE7F0", Offset = "0x39CDBF0", VA = "0x1839CE7F0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3432D70", Offset = "0x3432170", VA = "0x183432D70")]
	protected NFGCFODAECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x34314D0", Offset = "0x34308D0", VA = "0x1834314D0", Slot = "4")]
	public void CGHNAEKMKKP(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN, MNKDDLKPCKM OLNHBOCBHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34322B0", Offset = "0x34316B0", VA = "0x1834322B0")]
	private static T HMOLEOJFBJH(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34328F0", Offset = "0x3431CF0", VA = "0x1834328F0")]
	private static void MPCIPOIBKFA(PMKCJIGDPOI GCPNGOLBJLK, MCLHOLCKNPA PDLHECKEFMN, T IGDJJEECDAF)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ConfigUI)]
	[NDGJMMLBLBO(typeof(PMIFBIMNLHP), new string[] { })]
	internal class ConfigUIService : PMIFBIMNLHP, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[HIGIANBBMBE]
		private DNDLCINBGLP BPJKLBMMFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[HIGIANBBMBE]
		private BJKLIKDFIPA CGKEOLEHFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[HIGIANBBMBE]
		private MNKDDLKPCKM CJCHKJEADFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BHCDLCLEPFM EHJKDGIOJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private PMKCJIGDPOI GCPNGOLBJLK;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FD87F0", Offset = "0x5FD7BF0", VA = "0x185FD87F0", Slot = "5")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7DD0", Offset = "0x5FD71D0", VA = "0x185FD7DD0", Slot = "6")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FD80D0", Offset = "0x5FD74D0", VA = "0x185FD80D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FD81F0", Offset = "0x5FD75F0", VA = "0x185FD81F0", Slot = "4")]
		public void JHLLHHHKLGB(PMKCJIGDPOI IEBNBBJLHMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8760", Offset = "0x5FD7B60", VA = "0x185FD8760")]
		private void KCIKOCIFIBD(PMKCJIGDPOI IEBNBBJLHMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FD81C0", Offset = "0x5FD75C0", VA = "0x185FD81C0")]
		private void JBMHBGLMGND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7B50", Offset = "0x5FD6F50", VA = "0x185FD7B50")]
		private void CGHNAEKMKKP(IHGMCBGBHHN AKOHMLMOANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[GKCHIJCFFGK(0)]
internal class JJFOGMBKJMJ : MFNMODCGDCL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA480", Offset = "0x5FD9880", VA = "0x185FDA480", Slot = "9")]
	public override bool BPMOKHHLLGD(Type FPPBLNEEHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA530", Offset = "0x5FD9930", VA = "0x185FDA530", Slot = "6")]
	protected override PHDACJEABPO GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD77A0", Offset = "0x5FD6BA0", VA = "0x185FD77A0")]
	public JJFOGMBKJMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GKCHIJCFFGK(0)]
internal class CENMMEMPOPI : MFNMODCGDCL
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7600", Offset = "0x5FD6A00", VA = "0x185FD7600", Slot = "9")]
	public override bool BPMOKHHLLGD(Type FPPBLNEEHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD76B0", Offset = "0x5FD6AB0", VA = "0x185FD76B0", Slot = "6")]
	protected override PHDACJEABPO GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD77A0", Offset = "0x5FD6BA0", VA = "0x185FD77A0")]
	public CENMMEMPOPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[OOAKOPPDBKE(typeof(GGJMEDAMMEO), 1)]
internal class BGFDAMIDBML : global::LALPMGALDMA<GGJMEDAMMEO>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6230", Offset = "0x5FD5630", VA = "0x185FD6230", Slot = "7")]
	protected override GLLPKKNOAEH DKGJGDOONAA(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6320", Offset = "0x5FD5720", VA = "0x185FD6320")]
	public BGFDAMIDBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CKOJDAINNOO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FD77E0", Offset = "0x5FD6BE0", VA = "0x185FD77E0")]
	public static bool PKEPLEDHCEM(this MCLHOLCKNPA PDLHECKEFMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[OEMLNKPMDLF(2)]
internal class JEPOBNPPDCB : HPGDPCNPDCP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LGLLGKIABLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public PMKCJIGDPOI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public JEPOBNPPDCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LGLLGKIABLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB4E0", Offset = "0x5FDA8E0", VA = "0x185FDB4E0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB610", Offset = "0x5FDAA10", VA = "0x185FDB610")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override PCCBFFGCINK[] OFJIFHBLCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA1C0", Offset = "0x5FD95C0", VA = "0x185FDA1C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override PCCBFFGCINK[] MLJIIAFLAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA0E0", Offset = "0x5FD94E0", VA = "0x185FDA0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9D20", Offset = "0x5FD9120", VA = "0x185FD9D20", Slot = "10")]
	public override void CGHNAEKMKKP(PMKCJIGDPOI GCPNGOLBJLK, MNKDDLKPCKM OLNHBOCBHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JEPOBNPPDCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OOAKOPPDBKE(typeof(bool))]
internal class CLIMMKNAMEP : global::NFGCFODAECG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7920", Offset = "0x5FD6D20", VA = "0x185FD7920", Slot = "5")]
	protected override HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7A10", Offset = "0x5FD6E10", VA = "0x185FD7A10")]
	public CLIMMKNAMEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[OOAKOPPDBKE(typeof(FixedString32))]
internal class KJPAEEIANFP : global::NFGCFODAECG<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JDHJHIKBCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MNKDDLKPCKM ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public JDHJHIKBCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9B90", Offset = "0x5FD8F90", VA = "0x185FD9B90")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, MCLHOLCKNPA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KEBJFPIAIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KEBJFPIAIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FDADD0", Offset = "0x5FDA1D0", VA = "0x185FDADD0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FDAE40", Offset = "0x5FDA240", VA = "0x185FDAE40")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAEC0", Offset = "0x5FDA2C0", VA = "0x185FDAEC0", Slot = "5")]
	protected override HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAF80", Offset = "0x5FDA380", VA = "0x185FDAF80")]
	public KJPAEEIANFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OOAKOPPDBKE(typeof(FixedString64))]
internal class CPMHFBKCMEL : global::NFGCFODAECG<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EAMKCBGPEDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MNKDDLKPCKM ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EAMKCBGPEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8A00", Offset = "0x5FD7E00", VA = "0x185FD8A00")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, MCLHOLCKNPA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DIIFDCOFCJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DIIFDCOFCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5FD88D0", Offset = "0x5FD7CD0", VA = "0x185FD88D0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8960", Offset = "0x5FD7D60", VA = "0x185FD8960")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7A50", Offset = "0x5FD6E50", VA = "0x185FD7A50", Slot = "5")]
	protected override HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7B10", Offset = "0x5FD6F10", VA = "0x185FD7B10")]
	public CPMHFBKCMEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OOAKOPPDBKE(typeof(float))]
internal class PLEEGKPIEAG : global::NFGCFODAECG<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB9F0", Offset = "0x5FDADF0", VA = "0x185FDB9F0", Slot = "5")]
	protected override HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FDBAE0", Offset = "0x5FDAEE0", VA = "0x185FDBAE0")]
	public PLEEGKPIEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OOAKOPPDBKE(typeof(int))]
internal class LBEFLLACFDP : global::NFGCFODAECG<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB070", Offset = "0x5FDA470", VA = "0x185FDB070", Slot = "5")]
	protected override HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB160", Offset = "0x5FDA560", VA = "0x185FDB160")]
	public LBEFLLACFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[OOAKOPPDBKE(typeof(uint))]
internal class FFGEGNOIKOH : global::NFGCFODAECG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JGMMOGPMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MNKDDLKPCKM ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public JGMMOGPMLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA2A0", Offset = "0x5FD96A0", VA = "0x185FDA2A0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, MCLHOLCKNPA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KMFJMOJKCGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KMFJMOJKCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FDAFC0", Offset = "0x5FDA3C0", VA = "0x185FDAFC0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB010", Offset = "0x5FDA410", VA = "0x185FDB010")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD8B90", Offset = "0x5FD7F90", VA = "0x185FD8B90", Slot = "5")]
	protected override HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD8C50", Offset = "0x5FD8050", VA = "0x185FD8C50")]
	public FFGEGNOIKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[OOAKOPPDBKE(typeof(Vector3))]
internal class JCDCKEPMHLC : global::NFGCFODAECG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MCPKCGMHHIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MNKDDLKPCKM ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MCPKCGMHHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB6A0", Offset = "0x5FDAAA0", VA = "0x185FDB6A0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, MCLHOLCKNPA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IAGEBKMGDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IAGEBKMGDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9870", Offset = "0x5FD8C70", VA = "0x185FD9870")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD98D0", Offset = "0x5FD8CD0", VA = "0x185FD98D0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD98E0", Offset = "0x5FD8CE0", VA = "0x185FD98E0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9940", Offset = "0x5FD8D40", VA = "0x185FD9940")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9950", Offset = "0x5FD8D50", VA = "0x185FD9950")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD99B0", Offset = "0x5FD8DB0", VA = "0x185FD99B0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9A90", Offset = "0x5FD8E90", VA = "0x185FD9A90", Slot = "5")]
	protected override HHJKKABKPJI GNDAGOPIEOI(MNKDDLKPCKM OLNHBOCBHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9B50", Offset = "0x5FD8F50", VA = "0x185FD9B50")]
	public JCDCKEPMHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct IHGMCBGBHHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int PNBCLJPDJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int MLCJBLENBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int HFEAKOCKPHO;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class BKOLBPCAEIE
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7520", Offset = "0x5FD6920", VA = "0x185FD7520")]
	public static void JNBKJMIBMOF(Type OKFALABLAEC, Type JHJDMHLIIBP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct GDGNADBCBLG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FD8C90", Offset = "0x5FD8090", VA = "0x185FD8C90")]
	public static NativeList<int> ELOEEJBHHNC(PMKCJIGDPOI GCPNGOLBJLK, BJKLIKDFIPA CGKEOLEHFKI)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FD8E70", Offset = "0x5FD8270", VA = "0x185FD8E70")]
	private static bool OKOKKOOAPIC(MCLHOLCKNPA PDLHECKEFMN, PMKCJIGDPOI GCPNGOLBJLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class BFJKNABPHBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly BJKLIKDFIPA CGKEOLEHFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DNDLCINBGLP BPJKLBMMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly MNKDDLKPCKM OLNHBOCBHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<IHGMCBGBHHN> CBKMLMEDNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<DNCGINCJMGE> JLFOPFAKJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<DNCGINCJMGE, List<IHGMCBGBHHN>> JIPDJHMNBBD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6110", Offset = "0x5FD5510", VA = "0x185FD6110")]
	public BFJKNABPHBJ(BJKLIKDFIPA CGKEOLEHFKI, DNDLCINBGLP BPJKLBMMFFM, MNKDDLKPCKM OLNHBOCBHJJ, Action<IHGMCBGBHHN> CBKMLMEDNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5D90", Offset = "0x5FD5190", VA = "0x185FD5D90")]
	public void OEGBMNKPFEM(NativeList<IHGMCBGBHHN> DAKIGKEPOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FD56F0", Offset = "0x5FD4AF0", VA = "0x185FD56F0")]
	private void ECABLIBBKKB(DNCGINCJMGE EOONLHGBECH, IHGMCBGBHHN AKOHMLMOANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5810", Offset = "0x5FD4C10", VA = "0x185FD5810")]
	public void ILKNEKCOBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5870", Offset = "0x5FD4C70", VA = "0x185FD5870")]
	private void JBKGNDCMAGD(DNCGINCJMGE EOONLHGBECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5CF0", Offset = "0x5FD50F0", VA = "0x185FD5CF0")]
	private void LOIENDEMOJB(DNCGINCJMGE EOONLHGBECH)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class HNPLILOHDCE : IEnumerable<MCLHOLCKNPA>, IEnumerable, IEnumerator<MCLHOLCKNPA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private MCLHOLCKNPA <>2__current;

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
			private MCLHOLCKNPA System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
			[DebuggerHidden]
			public HNPLILOHDCE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9390", Offset = "0x5FD8790", VA = "0x185FD9390", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9050", Offset = "0x5FD8450", VA = "0x185FD9050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9410", Offset = "0x5FD8810", VA = "0x185FD9410")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9350", Offset = "0x5FD8750", VA = "0x185FD9350", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5FD92A0", Offset = "0x5FD86A0", VA = "0x185FD92A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MCLHOLCKNPA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5FD92A0", Offset = "0x5FD86A0", VA = "0x185FD92A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly DNDLCINBGLP BPJKLBMMFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> IJLOIFBEKKG;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBD00", Offset = "0x5FDB100", VA = "0x185FDBD00")]
		public PropertiesByType(DNDLCINBGLP BPJKLBMMFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBC20", Offset = "0x5FDB020", VA = "0x185FDBC20")]
		[IteratorStateMachine(typeof(HNPLILOHDCE))]
		public IEnumerable<MCLHOLCKNPA> NFHCFKKIGNC(Type FPPBLNEEHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBBE0", Offset = "0x5FDAFE0", VA = "0x185FDBBE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBB60", Offset = "0x5FDAF60", VA = "0x185FDBB60")]
		private long CGJIPEFBAHP(MCLHOLCKNPA PDLHECKEFMN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDBB20", Offset = "0x5FDAF20", VA = "0x185FDBB20")]
		private long CGJIPEFBAHP(Type FPPBLNEEHBP)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct LFBJLOKFEPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray NFOBIAMCGII;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB4A0", Offset = "0x5FDA8A0", VA = "0x185FDB4A0")]
	public LFBJLOKFEPK(int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB350", Offset = "0x5FDA750", VA = "0x185FDB350")]
	public static LFBJLOKFEPK PIIFFLHAJDI(int OAKAJHNNELN, NativeArray<int> OEKBACMEEFA)
	{
		return default(LFBJLOKFEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB270", Offset = "0x5FDA670", VA = "0x185FDB270")]
	public bool GPPJMNDNEDJ(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB280", Offset = "0x5FDA680", VA = "0x185FDB280")]
	public void KNBGLHDOKIA(int HMJKJGLHFKE, bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB1B0", Offset = "0x5FDA5B0", VA = "0x185FDB1B0")]
	public bool GDNNCPKEBIP(MCLHOLCKNPA[] OEKBACMEEFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB290", Offset = "0x5FDA690", VA = "0x185FDB290")]
	public bool MCHLLHKMHAK(MCLHOLCKNPA[] OEKBACMEEFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB1A0", Offset = "0x5FDA5A0", VA = "0x185FDB1A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class BHCDLCLEPFM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly DLHDGHMPCLG HCDIHNPPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BJKLIKDFIPA CGKEOLEHFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DNDLCINBGLP BPJKLBMMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<PGKELPJMKED> CJHMPDODNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType IJLOIFBEKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> GJJMJJHPIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> OKALEIKBJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<PGKELPJMKED> NPJPHKDMJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FD73D0", Offset = "0x5FD67D0", VA = "0x185FD73D0")]
	public BHCDLCLEPFM(BJKLIKDFIPA CGKEOLEHFKI, DNDLCINBGLP BPJKLBMMFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7110", Offset = "0x5FD6510", VA = "0x185FD7110")]
	public void NPNFNKBABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6F70", Offset = "0x5FD6370", VA = "0x185FD6F70")]
	public void HOGBOEJCAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6620", Offset = "0x5FD5A20", VA = "0x185FD6620")]
	public NativeList<IHGMCBGBHHN> BECCFHKFMMF(NativeArray<int> OEKBACMEEFA)
	{
		return default(NativeList<IHGMCBGBHHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6B20", Offset = "0x5FD5F20", VA = "0x185FD6B20")]
	private bool EOOPICDBGGM(PGKELPJMKED BBLHOFFFAEJ, LFBJLOKFEPK ELNBIGDEJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A1FF70", Offset = "0x2A1F370", VA = "0x182A1FF70")]
	private void HMAPHILEMOE<TInterface, TAttribute>(Action<TInterface, TAttribute> PKPLICOECHN) where TInterface : PGKELPJMKED where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FD70E0", Offset = "0x5FD64E0", VA = "0x185FD70E0")]
	private void IKELGFIDFIB(Type FPPBLNEEHBP, Type ENIPEOINEKK, Type DBIJLJEFFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A20210", Offset = "0x2A1F610", VA = "0x182A20210")]
	private TInterface PPHFIJDJJKB<TInterface>(Type FPPBLNEEHBP)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6BF0", Offset = "0x5FD5FF0", VA = "0x185FD6BF0")]
	private void FCBEGMGEOPJ(PGKELPJMKED BBLHOFFFAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6A80", Offset = "0x5FD5E80", VA = "0x185FD6A80")]
	private int CBMEIPAGGDB(PGKELPJMKED IKEAIGGPMPA, int HFEAKOCKPHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6CC0", Offset = "0x5FD60C0", VA = "0x185FD6CC0")]
	private void FOPMNDLAFNC(NKEKCKHIMFB BBLHOFFFAEJ, OOAKOPPDBKE INJAOABMBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6360", Offset = "0x5FD5760", VA = "0x185FD6360")]
	private void AAPANJPJANF(PDIGEMKEHNO BBLHOFFFAEJ, GKCHIJCFFGK INJAOABMBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD71E0", Offset = "0x5FD65E0", VA = "0x185FD71E0")]
	private void PGDANCONCDA(GMPBFJIAIHA BBLHOFFFAEJ, OEMLNKPMDLF INJAOABMBNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct KBDOELPCOLA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DNDLCINBGLP BPJKLBMMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<PGKELPJMKED> CJHMPDODNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<IHGMCBGBHHN> BCJKIPEHPAH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<IHGMCBGBHHN> EEAHJJOLEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD85780", Offset = "0xD84B80", VA = "0x180D85780")]
		get
		{
			return default(NativeList<IHGMCBGBHHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAD50", Offset = "0x5FDA150", VA = "0x185FDAD50")]
	public KBDOELPCOLA(DNDLCINBGLP BPJKLBMMFFM, List<PGKELPJMKED> CJHMPDODNIL, NativeArray<IHGMCBGBHHN> DAKIGKEPOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAA80", Offset = "0x5FD9E80", VA = "0x185FDAA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA680", Offset = "0x5FD9A80", VA = "0x185FDA680")]
	private NativeList<IHGMCBGBHHN> BLCIJNELFIL(NativeArray<IHGMCBGBHHN> EMBHCKBJIII)
	{
		return default(NativeList<IHGMCBGBHHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAC80", Offset = "0x5FDA080", VA = "0x185FDAC80")]
	private bool LOAGLJLLPKO(PGKELPJMKED BBLHOFFFAEJ, LFBJLOKFEPK MGIHBKPHFNA, int MLCJBLENBKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAAC0", Offset = "0x5FD9EC0", VA = "0x185FDAAC0")]
	private void GJFMHCEOGML(PGKELPJMKED BBLHOFFFAEJ, LFBJLOKFEPK NFOBIAMCGII, int MLCJBLENBKE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct JOFJNLIEHCJ : IComparer<IHGMCBGBHHN>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA620", Offset = "0x5FD9A20", VA = "0x185FDA620", Slot = "4")]
	public int Compare(IHGMCBGBHHN GHJDMBPGMHF, IHGMCBGBHHN IKDBBHHKFLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA630", Offset = "0x5FD9A30", VA = "0x185FDA630")]
	public static void FPPNDNHICGI(NativeList<IHGMCBGBHHN> DAKIGKEPOEI)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : JAMCEJDIEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC000", Offset = "0x5FDB400", VA = "0x185FDC000", Slot = "6")]
		public sealed override void FOLCGPFLFII(JPJOAJAPKJJ MCFINHLOBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC100", Offset = "0x5FDB500", VA = "0x185FDC100", Slot = "4")]
		public sealed override void PJNICPDDEAL()
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
