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
internal abstract class DDBDBPPMGII : global::DDLKFKCIIJI<Enum>, EHJBCEKFFPI, FLIKPNBDIGP, DDPMEECMGCK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool MJPEFJOMEMD(Type BIEGICDMJCM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC420", Offset = "0x5FBB020", VA = "0x185FBC420")]
	protected DDBDBPPMGII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class DDLKFKCIIJI<T> : FLIKPNBDIGP, DDPMEECMGCK where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void BINJFJMJLMH(Func<T> DEDOOGMBIEF, Action<T> GJJAOAGKAFC, string NLCIGFDKGEE, HLPDKNGJOIH GCEENFOFNFL, Func<bool> NMOAOECJGBC);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void FJEEEGLMCJG(Func<int> DEDOOGMBIEF, Action<int> GJJAOAGKAFC, string NLCIGFDKGEE, HLPDKNGJOIH GCEENFOFNFL, Func<bool> NMOAOECJGBC);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PHKHCGPPFML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public CDDJMIAEBFF targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HLPDKNGJOIH property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public PHKHCGPPFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B576D0", Offset = "0x2B562D0", VA = "0x182B576D0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B57770", Offset = "0x2B56370", VA = "0x182B57770")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GJHNLAEFOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::DDLKFKCIIJI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public FNEEMGJGBIP ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public GJHNLAEFOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x339D5E0", Offset = "0x339C1E0", VA = "0x18339D5E0")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, HLPDKNGJOIH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EMKNEOJFFOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public EMKNEOJFFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x48EA130", Offset = "0x48E8D30", VA = "0x1848EA130")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x48EA280", Offset = "0x48E8E80", VA = "0x1848EA280")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BC90", Offset = "0x2F1A890", VA = "0x182F1BC90")]
	protected DDLKFKCIIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B370", Offset = "0x2F19F70", VA = "0x182F1B370", Slot = "5")]
	public virtual void ALBHDHLPLHF(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL, FNEEMGJGBIP ALJGAHKJLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BA90", Offset = "0x2F1A690", VA = "0x182F1BA90", Slot = "6")]
	protected virtual BINJFJMJLMH NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BA40", Offset = "0x2F1A640", VA = "0x182F1BA40", Slot = "7")]
	protected virtual FJEEEGLMCJG KHIMJEEAHGO(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2F1BC10", Offset = "0x2F1A810", VA = "0x182F1BC10")]
	private static Enum OKCIBKMMIHP(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B900", Offset = "0x2F1A500", VA = "0x182F1B900")]
	private static void EGCFCNPNONO(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL, Enum GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class DNGPIIPNBME : FDIBBBBCOGL, DDPMEECMGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private HLPDKNGJOIH[] HLPIFIANEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HLPDKNGJOIH[] GGCLAKIHGHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HLPDKNGJOIH[] AHCHFDGPHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public HLPDKNGJOIH[] EHKBDAHEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract PMBKKKKDOIF[] KOFGAEEPHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract PMBKKKKDOIF[] MEKNJHMKNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD3C0", Offset = "0x5FBBFC0", VA = "0x185FBD3C0", Slot = "6")]
	public void BLNLPEOGOOG(OFDPPBHBKCF PEJHFLIFILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ALBHDHLPLHF(CDDJMIAEBFF EDKGADOKJCD, FNEEMGJGBIP ALJGAHKJLEJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1AB8810", Offset = "0x1AB7410", VA = "0x181AB8810")]
	protected static T OABMKJAIHJA<T>(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1AB8740", Offset = "0x1AB7340", VA = "0x181AB8740")]
	protected static void NFMEJPNMIDM<T>(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL, T GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected DNGPIIPNBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class PIHJIDEDIOC<T> : FLIKPNBDIGP, DDPMEECMGCK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void JCICHFFMLJB(Func<T> DEDOOGMBIEF, Action<T> GJJAOAGKAFC, string NLCIGFDKGEE, HLPDKNGJOIH GCEENFOFNFL, Func<bool> NMOAOECJGBC);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PCCHAKMNEPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CDDJMIAEBFF targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HLPDKNGJOIH property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public PCCHAKMNEPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B45560", Offset = "0x2B44160", VA = "0x182B45560")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B45810", Offset = "0x2B44410", VA = "0x182B45810")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B5CF10", Offset = "0x2B5BB10", VA = "0x182B5CF10")]
	protected PIHJIDEDIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B5CB40", Offset = "0x2B5B740", VA = "0x182B5CB40", Slot = "4")]
	public void ALBHDHLPLHF(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL, FNEEMGJGBIP ALJGAHKJLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B1C3B0", Offset = "0x2B1AFB0", VA = "0x182B1C3B0")]
	private static T OABMKJAIHJA(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B5CE00", Offset = "0x2B5BA00", VA = "0x182B5CE00")]
	private static void NFMEJPNMIDM(CDDJMIAEBFF EDKGADOKJCD, HLPDKNGJOIH GCEENFOFNFL, T GKFICKKHACC)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[HFIGNCEGOKM(DDEOJCINOPG.ConfigUI)]
	[DAMCBGMFJNJ(typeof(OOCICALAFNB), new string[] { })]
	internal class ConfigUIService : OOCICALAFNB, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[NHBEJKCIJLO]
		private OFDPPBHBKCF PEJHFLIFILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[NHBEJKCIJLO]
		private OFEOFFEAPKN OKPEEPHPGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[NHBEJKCIJLO]
		private FNEEMGJGBIP IPIALJGHPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GMDKDFAIIMG EDAPMMPMMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CDDJMIAEBFF EDKGADOKJCD;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC460", Offset = "0x5FBB060", VA = "0x185FBC460", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCE90", Offset = "0x5FBBA90", VA = "0x185FBCE90", Slot = "6")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC770", Offset = "0x5FBB370", VA = "0x185FBC770", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC920", Offset = "0x5FBB520", VA = "0x185FBC920", Slot = "4")]
		public void KOKHGPPDKHO(CDDJMIAEBFF PMEBHLMMGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC890", Offset = "0x5FBB490", VA = "0x185FBC890")]
		private void IGEHOBLFILO(CDDJMIAEBFF PMEBHLMMGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC860", Offset = "0x5FBB460", VA = "0x185FBC860")]
		private void GCMJGMNHPHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC4F0", Offset = "0x5FBB0F0", VA = "0x185FBC4F0")]
		private void ALBHDHLPLHF(GCKMGHMJGLC CHBJLDALBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JLEKLNIBANP(0)]
internal class CECNDBJDJBH : DDBDBPPMGII
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC280", Offset = "0x5FBAE80", VA = "0x185FBC280", Slot = "9")]
	public override bool MJPEFJOMEMD(Type BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC330", Offset = "0x5FBAF30", VA = "0x185FBC330", Slot = "6")]
	protected override BINJFJMJLMH NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC420", Offset = "0x5FBB020", VA = "0x185FBC420")]
	public CECNDBJDJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[JLEKLNIBANP(0)]
internal class MNDJDBBFHDE : DDBDBPPMGII
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC10E0", Offset = "0x5FBFCE0", VA = "0x185FC10E0", Slot = "9")]
	public override bool MJPEFJOMEMD(Type BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1190", Offset = "0x5FBFD90", VA = "0x185FC1190", Slot = "6")]
	protected override BINJFJMJLMH NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC420", Offset = "0x5FBB020", VA = "0x185FBC420")]
	public MNDJDBBFHDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[EEDBJDGCGAI(typeof(MOACHHOMOBI), 1)]
internal class PFKGFPILFJA : global::DDLKFKCIIJI<MOACHHOMOBI>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1D00", Offset = "0x5FC0900", VA = "0x185FC1D00", Slot = "7")]
	protected override FJEEEGLMCJG KHIMJEEAHGO(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1DF0", Offset = "0x5FC09F0", VA = "0x185FC1DF0")]
	public PFKGFPILFJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JLNDMFMCMEG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFCE0", Offset = "0x5FBE8E0", VA = "0x185FBFCE0")]
	public static bool CJHNFIEFCMN(this HLPDKNGJOIH GCEENFOFNFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[NMFJIEJLKCG(2)]
internal class INJEAFOMODC : DNGPIIPNBME
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LJLCLNJAKKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CDDJMIAEBFF targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public INJEAFOMODC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public LJLCLNJAKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0A60", Offset = "0x5FBF660", VA = "0x185FC0A60")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0B90", Offset = "0x5FBF790", VA = "0x185FC0B90")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override PMBKKKKDOIF[] MEKNJHMKNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FBFA20", Offset = "0x5FBE620", VA = "0x185FBFA20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override PMBKKKKDOIF[] KOFGAEEPHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF940", Offset = "0x5FBE540", VA = "0x185FBF940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF580", Offset = "0x5FBE180", VA = "0x185FBF580", Slot = "10")]
	public override void ALBHDHLPLHF(CDDJMIAEBFF EDKGADOKJCD, FNEEMGJGBIP ALJGAHKJLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public INJEAFOMODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[EEDBJDGCGAI(typeof(bool))]
internal class IFKEPMDHKAA : global::PIHJIDEDIOC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF450", Offset = "0x5FBE050", VA = "0x185FBF450", Slot = "5")]
	protected override JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF540", Offset = "0x5FBE140", VA = "0x185FBF540")]
	public IFKEPMDHKAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[EEDBJDGCGAI(typeof(FixedString32))]
internal class LGKAHEGNMEA : global::PIHJIDEDIOC<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class OIGHCHDCDDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FNEEMGJGBIP ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OIGHCHDCDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1760", Offset = "0x5FC0360", VA = "0x185FC1760")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, HLPDKNGJOIH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MCKDEPKLKKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public MCKDEPKLKKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0D20", Offset = "0x5FBF920", VA = "0x185FC0D20")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0D90", Offset = "0x5FBF990", VA = "0x185FC0D90")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0960", Offset = "0x5FBF560", VA = "0x185FC0960", Slot = "5")]
	protected override JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0A20", Offset = "0x5FBF620", VA = "0x185FC0A20")]
	public LGKAHEGNMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[EEDBJDGCGAI(typeof(FixedString64))]
internal class DHNDIDELJIO : global::PIHJIDEDIOC<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HDMPEMOMJOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FNEEMGJGBIP ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public HDMPEMOMJOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5FBEF00", Offset = "0x5FBDB00", VA = "0x185FBEF00")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, HLPDKNGJOIH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PNBKAHKHIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public PNBKAHKHIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2580", Offset = "0x5FC1180", VA = "0x185FC2580")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2610", Offset = "0x5FC1210", VA = "0x185FC2610")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD1E0", Offset = "0x5FBBDE0", VA = "0x185FBD1E0", Slot = "5")]
	protected override JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD2A0", Offset = "0x5FBBEA0", VA = "0x185FBD2A0")]
	public DHNDIDELJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[EEDBJDGCGAI(typeof(float))]
internal class OIEFJJJEGLN : global::PIHJIDEDIOC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1630", Offset = "0x5FC0230", VA = "0x185FC1630", Slot = "5")]
	protected override JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1720", Offset = "0x5FC0320", VA = "0x185FC1720")]
	public OIEFJJJEGLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EEDBJDGCGAI(typeof(int))]
internal class GNODJFNAGMF : global::PIHJIDEDIOC<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEDD0", Offset = "0x5FBD9D0", VA = "0x185FBEDD0", Slot = "5")]
	protected override JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEEC0", Offset = "0x5FBDAC0", VA = "0x185FBEEC0")]
	public GNODJFNAGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[EEDBJDGCGAI(typeof(uint))]
internal class LMGBPJPMMJA : global::PIHJIDEDIOC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JBOMENECOEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FNEEMGJGBIP ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public JBOMENECOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5FBFB00", Offset = "0x5FBE700", VA = "0x185FBFB00")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, HLPDKNGJOIH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MLHPLKIPPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public MLHPLKIPPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0E10", Offset = "0x5FBFA10", VA = "0x185FC0E10")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0E60", Offset = "0x5FBFA60", VA = "0x185FC0E60")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0C20", Offset = "0x5FBF820", VA = "0x185FC0C20", Slot = "5")]
	protected override JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0CE0", Offset = "0x5FBF8E0", VA = "0x185FC0CE0")]
	public LMGBPJPMMJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[EEDBJDGCGAI(typeof(Vector3))]
internal class GNDNLMEOKHK : global::PIHJIDEDIOC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OIBPPALLJKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FNEEMGJGBIP ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OIBPPALLJKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5FC12E0", Offset = "0x5FBFEE0", VA = "0x185FC12E0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, HLPDKNGJOIH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MLILCNPFPJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public MLILCNPFPJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0EC0", Offset = "0x5FBFAC0", VA = "0x185FC0EC0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0F20", Offset = "0x5FBFB20", VA = "0x185FC0F20")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0F30", Offset = "0x5FBFB30", VA = "0x185FC0F30")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0F90", Offset = "0x5FBFB90", VA = "0x185FC0F90")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0FA0", Offset = "0x5FBFBA0", VA = "0x185FC0FA0")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1000", Offset = "0x5FBFC00", VA = "0x185FC1000")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FBECD0", Offset = "0x5FBD8D0", VA = "0x185FBECD0", Slot = "5")]
	protected override JCICHFFMLJB NNHGCGPALCL(FNEEMGJGBIP ALJGAHKJLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FBED90", Offset = "0x5FBD990", VA = "0x185FBED90")]
	public GNDNLMEOKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct GCKMGHMJGLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int ADFKPCCGNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int IAPAANMMGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int KFNPPICHBLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class DLFBMGEPAFO
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD2E0", Offset = "0x5FBBEE0", VA = "0x185FBD2E0")]
	public static void GHFKFJFGJME(Type DIKMGJJNFPI, Type FIFJIHHKPEH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct HMGOOKIPGAA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF270", Offset = "0x5FBDE70", VA = "0x185FBF270")]
	public static NativeList<int> BOAABNPPBBD(CDDJMIAEBFF EDKGADOKJCD, OFEOFFEAPKN OKPEEPHPGOB)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF090", Offset = "0x5FBDC90", VA = "0x185FBF090")]
	private static bool ALLKDFMAFDH(HLPDKNGJOIH GCEENFOFNFL, CDDJMIAEBFF EDKGADOKJCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class LFCKFACCILH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly OFEOFFEAPKN OKPEEPHPGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly OFDPPBHBKCF PEJHFLIFILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly FNEEMGJGBIP ALJGAHKJLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<GCKMGHMJGLC> HFBMMGGIJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<OFBDBNCAANB> PGKGMGJGHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<OFBDBNCAANB, List<GCKMGHMJGLC>> KFBOMFIKGKF;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0840", Offset = "0x5FBF440", VA = "0x185FC0840")]
	public LFCKFACCILH(OFEOFFEAPKN OKPEEPHPGOB, OFDPPBHBKCF PEJHFLIFILH, FNEEMGJGBIP ALJGAHKJLEJ, Action<GCKMGHMJGLC> HFBMMGGIJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFEC0", Offset = "0x5FBEAC0", VA = "0x185FBFEC0")]
	public void GBDAFEHDILE(NativeList<GCKMGHMJGLC> BDPDBEIPEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FC06C0", Offset = "0x5FBF2C0", VA = "0x185FC06C0")]
	private void KIHCLBPEIHD(OFBDBNCAANB MKEBBFCGOHI, GCKMGHMJGLC CHBJLDALBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FC07E0", Offset = "0x5FBF3E0", VA = "0x185FC07E0")]
	public void PGIDCKBJNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0240", Offset = "0x5FBEE40", VA = "0x185FC0240")]
	private void IKHBHIJCPNI(OFBDBNCAANB MKEBBFCGOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFE20", Offset = "0x5FBEA20", VA = "0x185FBFE20")]
	private void ALGHNKCNBMN(OFBDBNCAANB MKEBBFCGOHI)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[HFIGNCEGOKM(DDEOJCINOPG.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class PFFNIGONDEB : IEnumerable<HLPDKNGJOIH>, IEnumerable, IEnumerator<HLPDKNGJOIH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private HLPDKNGJOIH <>2__current;

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
			private HLPDKNGJOIH System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
			[DebuggerHidden]
			public PFFNIGONDEB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5FC1C30", Offset = "0x5FC0830", VA = "0x185FC1C30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5FC18F0", Offset = "0x5FC04F0", VA = "0x185FC18F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5FC1CB0", Offset = "0x5FC08B0", VA = "0x185FC1CB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5FC1BF0", Offset = "0x5FC07F0", VA = "0x185FC1BF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5FC1B40", Offset = "0x5FC0740", VA = "0x185FC1B40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HLPDKNGJOIH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5FC1B40", Offset = "0x5FC0740", VA = "0x185FC1B40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly OFDPPBHBKCF PEJHFLIFILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> JHMMNAPAFIN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2890", Offset = "0x5FC1490", VA = "0x185FC2890")]
		public PropertiesByType(OFDPPBHBKCF PEJHFLIFILH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC27B0", Offset = "0x5FC13B0", VA = "0x185FC27B0")]
		[IteratorStateMachine(typeof(PFFNIGONDEB))]
		public IEnumerable<HLPDKNGJOIH> HJEEFHBLGAF(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC26B0", Offset = "0x5FC12B0", VA = "0x185FC26B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2730", Offset = "0x5FC1330", VA = "0x185FC2730")]
		private long EDLMDKNCCNP(HLPDKNGJOIH GCEENFOFNFL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC26F0", Offset = "0x5FC12F0", VA = "0x185FC26F0")]
		private long EDLMDKNCCNP(Type BIEGICDMJCM)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct FBJLNBADCLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray LFCAICMELHF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDAD0", Offset = "0x5FBC6D0", VA = "0x185FBDAD0")]
	public FBJLNBADCLK(int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD960", Offset = "0x5FBC560", VA = "0x185FBD960")]
	public static FBJLNBADCLK HCIICKBGJHK(int BPGPHKEJPBF, NativeArray<int> HFDCOKODHFK)
	{
		return default(FBJLNBADCLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDAB0", Offset = "0x5FBC6B0", VA = "0x185FBDAB0")]
	public bool IICJGCDBNOO(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDAC0", Offset = "0x5FBC6C0", VA = "0x185FBDAC0")]
	public void NMFBOCJEJOB(int BNNEENLPEFO, bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD7D0", Offset = "0x5FBC3D0", VA = "0x185FBD7D0")]
	public bool AMJMDJNJKBH(HLPDKNGJOIH[] HFDCOKODHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD890", Offset = "0x5FBC490", VA = "0x185FBD890")]
	public bool BAKEIMKJNGK(HLPDKNGJOIH[] HFDCOKODHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD950", Offset = "0x5FBC550", VA = "0x185FBD950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class GMDKDFAIIMG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FNIDFMEJGMB CBDAGBGGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly OFEOFFEAPKN OKPEEPHPGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OFDPPBHBKCF PEJHFLIFILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<DDPMEECMGCK> OODDHHPLCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType JHMMNAPAFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> NNOEOHDJELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> MOMPEPDBNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<DDPMEECMGCK> CMGPLHBJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEB80", Offset = "0x5FBD780", VA = "0x185FBEB80")]
	public GMDKDFAIIMG(OFEOFFEAPKN OKPEEPHPGOB, OFDPPBHBKCF PEJHFLIFILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE340", Offset = "0x5FBCF40", VA = "0x185FBE340")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDB10", Offset = "0x5FBC710", VA = "0x185FBDB10")]
	public void DJJJBFMKDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE410", Offset = "0x5FBD010", VA = "0x185FBE410")]
	public NativeList<GCKMGHMJGLC> OMKNHNCJMFD(NativeArray<int> HFDCOKODHFK)
	{
		return default(NativeList<GCKMGHMJGLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDEF0", Offset = "0x5FBCAF0", VA = "0x185FBDEF0")]
	private bool JFBKKCPAOEC(DDPMEECMGCK LOEMLLNPMLI, FBJLNBADCLK GHGHFDLPMCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x35227C0", Offset = "0x35213C0", VA = "0x1835227C0")]
	private void CMPDHHJECNH<TInterface, TAttribute>(Action<TInterface, TAttribute> OONKNMNHLIM) where TInterface : DDPMEECMGCK where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE310", Offset = "0x5FBCF10", VA = "0x185FBE310")]
	private void LKMGJHOPGBI(Type BIEGICDMJCM, Type JDCEEFPGBHD, Type BAMGGOMPEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35229F0", Offset = "0x35215F0", VA = "0x1835229F0")]
	private TInterface JKGOHAFHEHF<TInterface>(Type BIEGICDMJCM)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDC80", Offset = "0x5FBC880", VA = "0x185FBDC80")]
	private void FOAOOILKJOO(DDPMEECMGCK LOEMLLNPMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE270", Offset = "0x5FBCE70", VA = "0x185FBE270")]
	private int KLNDNNLEDKI(DDPMEECMGCK DENGEJMDIND, int KFNPPICHBLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDFC0", Offset = "0x5FBCBC0", VA = "0x185FBDFC0")]
	private void KFJNHEKNNCJ(FLIKPNBDIGP LOEMLLNPMLI, EEDBJDGCGAI OJMLJAHGJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE870", Offset = "0x5FBD470", VA = "0x185FBE870")]
	private void OMKONPKMHIC(EHJBCEKFFPI LOEMLLNPMLI, JLEKLNIBANP OJMLJAHGJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDD50", Offset = "0x5FBC950", VA = "0x185FBDD50")]
	private void HCCEKAGBKOK(FDIBBBBCOGL LOEMLLNPMLI, NMFJIEJLKCG OJMLJAHGJGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct PHJIMOFLAKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OFDPPBHBKCF PEJHFLIFILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<DDPMEECMGCK> OODDHHPLCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<GCKMGHMJGLC> PHKGKHKIOPL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<GCKMGHMJGLC> NPOGNOBNBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xDA4D10", Offset = "0xDA3910", VA = "0x180DA4D10")]
		get
		{
			return default(NativeList<GCKMGHMJGLC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2500", Offset = "0x5FC1100", VA = "0x185FC2500")]
	public PHJIMOFLAKI(OFDPPBHBKCF PEJHFLIFILH, List<DDPMEECMGCK> OODDHHPLCMG, NativeArray<GCKMGHMJGLC> BDPDBEIPEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1FF0", Offset = "0x5FC0BF0", VA = "0x185FC1FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2100", Offset = "0x5FC0D00", VA = "0x185FC2100")]
	private NativeList<GCKMGHMJGLC> JNINJMAMDGI(NativeArray<GCKMGHMJGLC> IPOLPNCDNNE)
	{
		return default(NativeList<GCKMGHMJGLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2030", Offset = "0x5FC0C30", VA = "0x185FC2030")]
	private bool GDPDPOAPMOE(DDPMEECMGCK LOEMLLNPMLI, FBJLNBADCLK EMMKOADDNHN, int IAPAANMMGIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1E30", Offset = "0x5FC0A30", VA = "0x185FC1E30")]
	private void CBDLGMAFONK(DDPMEECMGCK LOEMLLNPMLI, FBJLNBADCLK LFCAICMELHF, int IAPAANMMGIC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct NGMDMAGBPPB : IComparer<GCKMGHMJGLC>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1280", Offset = "0x5FBFE80", VA = "0x185FC1280", Slot = "4")]
	public int Compare(GCKMGHMJGLC LEOEMBMBFBC, GCKMGHMJGLC GHDGKPNPOBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1290", Offset = "0x5FBFE90", VA = "0x185FC1290")]
	public static void HAACIBKFDHB(NativeList<GCKMGHMJGLC> BDPDBEIPEAE)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : OJPIMOLMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2B90", Offset = "0x5FC1790", VA = "0x185FC2B90", Slot = "6")]
		public sealed override void FEOLDJENCJJ(OFPBJBCBPFJ PKPGAEOFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2C90", Offset = "0x5FC1890", VA = "0x185FC2C90", Slot = "4")]
		public sealed override void LHIOLPAIHGM()
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
