using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x266C300", Offset = "0x266B700", VA = "0x18266C300")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IEPFOBMFPDO : ABNNHKJOOMD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x266C290", Offset = "0x266B690", VA = "0x18266C290", Slot = "7")]
	public override string CHDHFHDBOKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x266C2C0", Offset = "0x266B6C0", VA = "0x18266C2C0")]
	private IEPFOBMFPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x266C240", Offset = "0x266B640", VA = "0x18266C240")]
	public static IEPFOBMFPDO AFLKMMODJAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OAIKKOAJMCI<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, PNGBDFKALLO.PCJCJPKDOCL<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BIMGBAAECOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] NPCJNFEDEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int IHEKHJKDJKI;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x107D470", Offset = "0x107C870", VA = "0x18107D470")]
		private BIMGBAAECOD(TPartialAction[] JPHIAKJIMKA, int GLAIMHFGLBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D616E0", Offset = "0x5D60AE0", VA = "0x185D616E0")]
		public static OAIKKOAJMCI<TPartialAction, TPartialActionId, TFullAction, TDeps>.BIMGBAAECOD AFLKMMODJAC(int GMNCKANHIOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D61A30", Offset = "0x5D60E30", VA = "0x185D61A30")]
		public DGLIKEIKEPL<TFullAction> DCEMCEFFLNK(TPartialAction DHKEIGKPJAB, TDeps EIHGNKDHDGF)
		{
			return default(DGLIKEIKEPL<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, BIMGBAAECOD>? GLCKCGNPOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps EGDADDGFBOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, BIMGBAAECOD> LKHJFLHEDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51389B0", Offset = "0x5137DB0", VA = "0x1851389B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5138B60", Offset = "0x5137F60", VA = "0x185138B60")]
	private OAIKKOAJMCI(Dictionary<TPartialActionId, BIMGBAAECOD>? LBBEHFBDFDK, TDeps EIHGNKDHDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5137AA0", Offset = "0x5136EA0", VA = "0x185137AA0")]
	public static OAIKKOAJMCI<TPartialAction, TPartialActionId, TFullAction, TDeps> AFLKMMODJAC(TDeps EIHGNKDHDGF)
	{
		return default(OAIKKOAJMCI<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5138310", Offset = "0x5137710", VA = "0x185138310")]
	public AEAAIINGJNL<DGLIKEIKEPL<TFullAction>, GJDNFLPCNNP> DCEMCEFFLNK(TPartialAction DHKEIGKPJAB)
	{
		return default(AEAAIINGJNL<DGLIKEIKEPL<TFullAction>, GJDNFLPCNNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5138AA0", Offset = "0x5137EA0", VA = "0x185138AA0")]
	public void JHPPNCHCEPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PNGBDFKALLO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface PCJCJPKDOCL<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ACMKDDBNFMK([In] TPartialAction DHKEIGKPJAB);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FNPBHKPAGAA([In] TPartialAction DHKEIGKPJAB);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId BIDBJKDANKN([In] TPartialAction DHKEIGKPJAB);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction ACFLKOEAMLG(TPartialAction[] IKFCGNFJFIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FBGAHKBIKDM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : OCPNJIPBJJE.FMCEOOOKOIB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] OINLPFOMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int EAOOJCEPLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps EGDADDGFBOH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x46BC000", Offset = "0x46BB400", VA = "0x1846BC000")]
	internal FBGAHKBIKDM(TPartialSnapshot[] PFLBBIBBOOC, int NOPIMHKCBBJ, TDeps EIHGNKDHDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46BBFA0", Offset = "0x46BB3A0", VA = "0x1846BBFA0")]
	public static FBGAHKBIKDM<TPartialSnapshot, TFullSnapshot, TDeps> AFLKMMODJAC(TDeps EIHGNKDHDGF)
	{
		return default(FBGAHKBIKDM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OCPNJIPBJJE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FMCEOOOKOIB<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DGNHLMGGNCG([In] TPartialSnapshot IHENEGANNAN);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot FELPJFNAGEB(TPartialSnapshot[] BPLPFPPIJOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37C8A30", Offset = "0x37C7E30", VA = "0x1837C8A30")]
	public static DGLIKEIKEPL<TFullSnapshot> DCEMCEFFLNK<TFullSnapshot, TPartialSnapshot, TDeps>(this FBGAHKBIKDM<TPartialSnapshot, TFullSnapshot, TDeps> CAMFIHKHJNG, TPartialSnapshot IHENEGANNAN) where TDeps : FMCEOOOKOIB<TPartialSnapshot, TFullSnapshot>
	{
		return default(DGLIKEIKEPL<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37C8E30", Offset = "0x37C8230", VA = "0x1837C8E30")]
	public static bool DIJAIINJNKM<TPartialSnapshot, TFullSnapshot, TDeps>(this FBGAHKBIKDM<TPartialSnapshot, TFullSnapshot, TDeps> CAMFIHKHJNG, TPartialSnapshot IHENEGANNAN) where TDeps : FMCEOOOKOIB<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NPNALKPFDBC : ABNNHKJOOMD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x266C2D0", Offset = "0x266B6D0", VA = "0x18266C2D0", Slot = "7")]
	public override string CHDHFHDBOKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x266C2C0", Offset = "0x266B6C0", VA = "0x18266C2C0")]
	public NPNALKPFDBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NPAAODGKCDA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : ODFAMDDBIDD.CPBKMGBPIMA<TAction, TNetSys> where TReceiverDeps : ODFAMDDBIDD.LBCCDLCNGDI<TAction, TReceiver> where TRootDeps : ODFAMDDBIDD.EKMCLFOAEBN<TMRequest, TAction, TRoot> where TDeps : ODFAMDDBIDD.FAEPFOJAMGI<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface JCOMIDKKMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GIKDPPODPJO([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DLOKIFHNFLJ();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AEAAIINGJNL<object, GJDNFLPCNNP> OGHDBICLONM();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FKMJHIJNEGG(Exception GEEGJFAONEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class OBOBJGMHFGJ : JCOMIDKKMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>> HACEMIIOLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<AEAAIINGJNL<object, EPFFDEGDAEO>> MNLEJGILHLM;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x513DA20", Offset = "0x513CE20", VA = "0x18513DA20")]
		private OBOBJGMHFGJ(TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>> BAIELHIPCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4F83BB0", Offset = "0x4F82FB0", VA = "0x184F83BB0")]
		public static OBOBJGMHFGJ AFLKMMODJAC(TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>> BAIELHIPCKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x513D700", Offset = "0x513CB00", VA = "0x18513D700")]
		public void GIKDPPODPJO([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x513D360", Offset = "0x513C760", VA = "0x18513D360", Slot = "5")]
		public void DLOKIFHNFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x513D820", Offset = "0x513CC20", VA = "0x18513D820", Slot = "6")]
		public AEAAIINGJNL<object, GJDNFLPCNNP> OGHDBICLONM()
		{
			return default(AEAAIINGJNL<object, GJDNFLPCNNP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x513D580", Offset = "0x513C980", VA = "0x18513D580", Slot = "7")]
		public void FKMJHIJNEGG(Exception GEEGJFAONEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4280010", Offset = "0x427F410", VA = "0x184280010", Slot = "4")]
		private void DDFJHMAMEDI([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class OPHFNKPGPHK : JCOMIDKKMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>> HACEMIIOLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private AEAAIINGJNL<object, GJDNFLPCNNP> JMMKJBNAKKF;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
		private OPHFNKPGPHK(TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>> BAIELHIPCKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4F83BB0", Offset = "0x4F82FB0", VA = "0x184F83BB0")]
		public static OPHFNKPGPHK AFLKMMODJAC(TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>> BAIELHIPCKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD131B0", Offset = "0xD125B0", VA = "0x180D131B0")]
		public void GIKDPPODPJO([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51EC270", Offset = "0x51EB670", VA = "0x1851EC270", Slot = "5")]
		public void DLOKIFHNFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB47C60", Offset = "0xB47060", VA = "0x180B47C60", Slot = "6")]
		public AEAAIINGJNL<object, GJDNFLPCNNP> OGHDBICLONM()
		{
			return default(AEAAIINGJNL<object, GJDNFLPCNNP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x51EC330", Offset = "0x51EB730", VA = "0x1851EC330", Slot = "7")]
		public void FKMJHIJNEGG(Exception GEEGJFAONEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4280010", Offset = "0x427F410", VA = "0x184280010", Slot = "4")]
		private void DDFJHMAMEDI([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class EMNMPOEDMIH : JCOMIDKKMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<AEAAIINGJNL<object, GJDNFLPCNNP>> MNLEJGILHLM;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x429F490", Offset = "0x429E890", VA = "0x18429F490")]
		private EMNMPOEDMIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x429F020", Offset = "0x429E420", VA = "0x18429F020")]
		public static EMNMPOEDMIH AFLKMMODJAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x429F180", Offset = "0x429E580", VA = "0x18429F180")]
		public void GIKDPPODPJO([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void DLOKIFHNFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x429F3A0", Offset = "0x429E7A0", VA = "0x18429F3A0", Slot = "6")]
		public AEAAIINGJNL<object, GJDNFLPCNNP> OGHDBICLONM()
		{
			return default(AEAAIINGJNL<object, GJDNFLPCNNP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x429F0E0", Offset = "0x429E4E0", VA = "0x18429F0E0", Slot = "7")]
		[FCLLJJAPAHC("This may be terminal and should probably do more than discarding the exception.")]
		public void FKMJHIJNEGG(Exception GEEGJFAONEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4280010", Offset = "0x427F410", VA = "0x184280010", Slot = "4")]
		private void DDFJHMAMEDI([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CKMEGDGAEPJ : JCOMIDKKMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private AEAAIINGJNL<object, GJDNFLPCNNP> JMMKJBNAKKF;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		private CKMEGDGAEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x429F020", Offset = "0x429E420", VA = "0x18429F020")]
		public static CKMEGDGAEPJ AFLKMMODJAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x21D3DA0", Offset = "0x21D31A0", VA = "0x1821D3DA0")]
		public void GIKDPPODPJO([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void DLOKIFHNFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB9A2C0", Offset = "0xB996C0", VA = "0x180B9A2C0", Slot = "6")]
		public AEAAIINGJNL<object, GJDNFLPCNNP> OGHDBICLONM()
		{
			return default(AEAAIINGJNL<object, GJDNFLPCNNP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x620FF80", Offset = "0x620F380", VA = "0x18620FF80", Slot = "7")]
		[FCLLJJAPAHC("This may be terminal and should probably do more than discarding the exception.")]
		public void FKMJHIJNEGG(Exception GEEGJFAONEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4280010", Offset = "0x427F410", VA = "0x184280010", Slot = "4")]
		private void DDFJHMAMEDI([In] AEAAIINGJNL<object, GJDNFLPCNNP> KGODHHBLJOE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct DKOLCCJLHHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NPAAODGKCDA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EECNAGIPCBM<PAHGPENHMCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x65F1300", Offset = "0x65F0700", VA = "0x1865F1300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x65F1850", Offset = "0x65F0C50", VA = "0x1865F1850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BKNEHHPHABN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NPAAODGKCDA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public EECNAGIPCBM<PAHGPENHMCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D67FC0", Offset = "0x5D673C0", VA = "0x185D67FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D68880", Offset = "0x5D67C80", VA = "0x185D68880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct GFKKMKCIGLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NPAAODGKCDA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EECNAGIPCBM<PAHGPENHMCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public EECNAGIPCBM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x481DDB0", Offset = "0x481D1B0", VA = "0x18481DDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x481E4F0", Offset = "0x481D8F0", VA = "0x18481E4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KNHOCFEJKNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NPAAODGKCDA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EECNAGIPCBM<PAHGPENHMCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public EECNAGIPCBM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JCOMIDKKMHN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4170", Offset = "0x4CE3570", VA = "0x184CE4170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4DC0", Offset = "0x4CE41C0", VA = "0x184CE4DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NNJMDHMLHDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NPAAODGKCDA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public JCOMIDKKMHN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JCOMIDKKMHN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5039200", Offset = "0x5038600", VA = "0x185039200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x503D080", Offset = "0x503C480", VA = "0x18503D080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct AJEIOGMCNCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NPAAODGKCDA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public EECNAGIPCBM<PAHGPENHMCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x48E7010", Offset = "0x48E6410", VA = "0x1848E7010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x48E7750", Offset = "0x48E6B50", VA = "0x1848E7750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps EGDADDGFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<EECNAGIPCBM<TMRequest>, TaskCompletionSource<AEAAIINGJNL<object, GJDNFLPCNNP>>> DJOPCPHDELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BLOLPDDKKDO<TMRequest> ILFGPKJIDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool ONJIMNDMHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int JEMHOGJHJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task ABCHNHFBIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int NBJJNJCGAHA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps CPMNCHDDDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x504EFF0", Offset = "0x504E3F0", VA = "0x18504EFF0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps MCPMJFDPBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x504EF70", Offset = "0x504E370", VA = "0x18504EF70")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps OPNKILLFIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x504EEF0", Offset = "0x504E2F0", VA = "0x18504EEF0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MHGIIBDOACC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC6C770", Offset = "0xC6BB70", VA = "0x180C6C770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC6C150", Offset = "0xC6B550", VA = "0x180C6C150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ANEKMHBNLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x992560", Offset = "0x991960", VA = "0x180992560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GMLJMMOIKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9AF910", Offset = "0x9AED10", VA = "0x1809AF910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x504FF70", Offset = "0x504F370", VA = "0x18504FF70")]
	public NPAAODGKCDA(TDeps EIHGNKDHDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x504DFD0", Offset = "0x504D3D0", VA = "0x18504DFD0")]
	public Task<AEAAIINGJNL<object, GJDNFLPCNNP>> DAHELHCEKCJ(TRoot FDNIDHBNFHE, TNetSys IIIEKKDPGJJ, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, TAction AKLHLNJOCEK, bool LECKBHBGKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x504DE70", Offset = "0x504D270", VA = "0x18504DE70")]
	[AsyncStateMachine(typeof(NPAAODGKCDA<, , , , , , , , >.DKOLCCJLHHO))]
	private Task<AEAAIINGJNL<object, GJDNFLPCNNP>> DAHELHCEKCJ(TRoot FDNIDHBNFHE, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, TAction AKLHLNJOCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x504EC60", Offset = "0x504E060", VA = "0x18504EC60")]
	[AsyncStateMachine(typeof(NPAAODGKCDA<, , , , , , , , >.BKNEHHPHABN))]
	private Task<AEAAIINGJNL<object, GJDNFLPCNNP>> DLBGPDBPIDA(TRoot FDNIDHBNFHE, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, TAction[] NLNFFLCOOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x504FB70", Offset = "0x504EF70", VA = "0x18504FB70")]
	[AsyncStateMachine(typeof(NPAAODGKCDA<, , , , , , , , >.GFKKMKCIGLC))]
	public Task<AEAAIINGJNL<object, GJDNFLPCNNP>> NLPECAPDGKH(TRoot FDNIDHBNFHE, TNetSys MKMAAHHLGDP, TReceiver LPKAAAAGEAF, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, EECNAGIPCBM<TMRequest> LEHDLLJHLDN, TAction AKLHLNJOCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x504DCF0", Offset = "0x504D0F0", VA = "0x18504DCF0")]
	[AsyncStateMachine(typeof(NPAAODGKCDA<, , , , , , , , >.KNHOCFEJKNF))]
	private Task<AEAAIINGJNL<object, GJDNFLPCNNP>> AFOEJALBLBB(TRoot FDNIDHBNFHE, TNetSys MKMAAHHLGDP, TReceiver LPKAAAAGEAF, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, EECNAGIPCBM<TMRequest> LEHDLLJHLDN, TAction AKLHLNJOCEK, Task GOMIJNNGIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x504F8B0", Offset = "0x504ECB0", VA = "0x18504F8B0")]
	[AsyncStateMachine(typeof(NPAAODGKCDA<, , , , , , , , >.NNJMDHMLHDC))]
	private Task MLLLHFKNDDF(TRoot FDNIDHBNFHE, TNetSys MKMAAHHLGDP, TReceiver LPKAAAAGEAF, TAction AKLHLNJOCEK, JCOMIDKKMHN ENHBONJAJAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x504EE70", Offset = "0x504E270", VA = "0x18504EE70")]
	private void EPIHGEKKIIM(TReceiver LPKAAAAGEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x504F070", Offset = "0x504E470", VA = "0x18504F070")]
	private void MINNBGPCDEB(TRoot FDNIDHBNFHE, TNetSys MKMAAHHLGDP, TReceiver LPKAAAAGEAF, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, TAction AKLHLNJOCEK, bool FNFCJPKCNKP, bool IMKMPLKJAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x504FCE0", Offset = "0x504F0E0", VA = "0x18504FCE0")]
	[AsyncStateMachine(typeof(NPAAODGKCDA<, , , , , , , , >.AJEIOGMCNCM))]
	public Task NPMCMDNNEDO(TRoot FDNIDHBNFHE, TNetSys MKMAAHHLGDP, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, TAction[] BLMOCOLLMGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ODFAMDDBIDD
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface CPBKMGBPIMA<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FEIOLAOPGEJ(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction MFFMODHHNHK(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction PKHFFPILMFJ(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> NKECJJIFCHE(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] INPKDMMBENC(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK, int HDJHFCIAFFI);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HLGNJMKPNBI(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OBPABOMJLCI(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CBBJBAEIFDB(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CIPMJEFJCHB(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool IAEFFIGLAHD(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KADBKNGNMMG(TNetSys ECFGOPEGNEO, TAction AKLHLNJOCEK);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface FAEPFOJAMGI<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps CPMNCHDDDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps OPNKILLFIEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps MCPMJFDPBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LBCCDLCNGDI<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EECNAGIPCBM<PAHGPENHMCA> GKBJDHFGGHJ(TReceiver LPKAAAAGEAF);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KCDOMNOHINF(TReceiver LPKAAAAGEAF);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<AEAAIINGJNL<object, GJDNFLPCNNP>> NLPECAPDGKH(TReceiver LPKAAAAGEAF, TAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] ECCJLJFJFIP(TReceiver LPKAAAAGEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface EKMCLFOAEBN<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ONMEEIHBKEG(TRoot FDNIDHBNFHE);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GANKONHPAOB(TRoot FDNIDHBNFHE);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LMBIKANEMJH(TRoot FDNIDHBNFHE);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BCHGCINNACE(TRoot FDNIDHBNFHE);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EJHBDOJIDOP(TRoot FDNIDHBNFHE);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool DBBFMCHAMKK(TRoot FDNIDHBNFHE, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, TAction[] NLNFFLCOOFE);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task DAHELHCEKCJ(TRoot FDNIDHBNFHE, EECNAGIPCBM<PAHGPENHMCA> LEKKPMMKFMI, EECNAGIPCBM<TMRequest> LEHDLLJHLDN, TAction AKLHLNJOCEK, bool PLNJAIOIALC = true);
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
