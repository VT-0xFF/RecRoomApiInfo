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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E47B0", Offset = "0x27E39B0", VA = "0x1827E47B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HAFNAOKDMPB : BHGOBKJBFOA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27E46F0", Offset = "0x27E38F0", VA = "0x1827E46F0", Slot = "7")]
	public override string JOOGKGIFDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27E4770", Offset = "0x27E3970", VA = "0x1827E4770")]
	private HAFNAOKDMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27E4720", Offset = "0x27E3920", VA = "0x1827E4720")]
	public static HAFNAOKDMPB OIKMHICCLEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ADBDBPDGGAO<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, EGDACDPHPND.FFBAPIAAFNG<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HBEPJNBAKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] FOELLNCFCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int MAHMHFKENMG;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8070", Offset = "0x11C7270", VA = "0x1811C8070")]
		private HBEPJNBAKGC(TPartialAction[] KMBHCHANJMD, int CAKKBJKKFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4AF5010", Offset = "0x4AF4210", VA = "0x184AF5010")]
		public static ADBDBPDGGAO<TPartialAction, TPartialActionId, TFullAction, TDeps>.HBEPJNBAKGC OIKMHICCLEP(int AGOLIHNICEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4AF4ED0", Offset = "0x4AF40D0", VA = "0x184AF4ED0")]
		public CJILJFGJKPL<TFullAction> FBPPCPAHNJO(TPartialAction JAPMIPHFGGE, TDeps POLANHDJCNH)
		{
			return default(CJILJFGJKPL<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, HBEPJNBAKGC>? GLHLAKAMIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps MPDDJFAHINH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, HBEPJNBAKGC> COJOJIBFECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4A34060", Offset = "0x4A33260", VA = "0x184A34060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A342C0", Offset = "0x4A334C0", VA = "0x184A342C0")]
	private ADBDBPDGGAO(Dictionary<TPartialActionId, HBEPJNBAKGC>? BCAMGALKPAF, TDeps POLANHDJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A34210", Offset = "0x4A33410", VA = "0x184A34210")]
	public static ADBDBPDGGAO<TPartialAction, TPartialActionId, TFullAction, TDeps> OIKMHICCLEP(TDeps POLANHDJCNH)
	{
		return default(ADBDBPDGGAO<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A331A0", Offset = "0x4A323A0", VA = "0x184A331A0")]
	public LOAMJJJEMNF<CJILJFGJKPL<TFullAction>, PLLHOMFPAAM> FBPPCPAHNJO(TPartialAction JAPMIPHFGGE)
	{
		return default(LOAMJJJEMNF<CJILJFGJKPL<TFullAction>, PLLHOMFPAAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A34150", Offset = "0x4A33350", VA = "0x184A34150")]
	public void OBPMJMDGEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EGDACDPHPND
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FFBAPIAAFNG<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NCIHBEEIPKI([In] TPartialAction JAPMIPHFGGE);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int MDLCHLAGGPJ([In] TPartialAction JAPMIPHFGGE);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId MBCKPJKENEH([In] TPartialAction JAPMIPHFGGE);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction CPCHNAGAJFD(TPartialAction[] GAKNKDKLDHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IKBOIGGOEHK<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : DNPENKDAEAN.NPLFIDNFGDA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] INNPLBIBMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int LDANJJIEMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps MPDDJFAHINH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F010", Offset = "0x4C9E210", VA = "0x184C9F010")]
	internal IKBOIGGOEHK(TPartialSnapshot[] AOICDEJBLIN, int IAEPONILEFN, TDeps POLANHDJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C9EEF0", Offset = "0x4C9E0F0", VA = "0x184C9EEF0")]
	public static IKBOIGGOEHK<TPartialSnapshot, TFullSnapshot, TDeps> OIKMHICCLEP(TDeps POLANHDJCNH)
	{
		return default(IKBOIGGOEHK<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DNPENKDAEAN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface NPLFIDNFGDA<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DGCELPJNIFJ([In] TPartialSnapshot KFFAIFBIBNO);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot BDFJAOPBPMG(TPartialSnapshot[] JOALGJPIDHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3673DE0", Offset = "0x3672FE0", VA = "0x183673DE0")]
	public static CJILJFGJKPL<TFullSnapshot> FBPPCPAHNJO<TFullSnapshot, TPartialSnapshot, TDeps>(this IKBOIGGOEHK<TPartialSnapshot, TFullSnapshot, TDeps> CEENCLMGJAM, TPartialSnapshot KFFAIFBIBNO) where TDeps : NPLFIDNFGDA<TPartialSnapshot, TFullSnapshot>
	{
		return default(CJILJFGJKPL<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3673CA0", Offset = "0x3672EA0", VA = "0x183673CA0")]
	public static bool CEPBECIADOJ<TPartialSnapshot, TFullSnapshot, TDeps>(this IKBOIGGOEHK<TPartialSnapshot, TFullSnapshot, TDeps> CEENCLMGJAM, TPartialSnapshot KFFAIFBIBNO) where TDeps : NPLFIDNFGDA<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class LFAFEALJKOD : BHGOBKJBFOA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27E4780", Offset = "0x27E3980", VA = "0x1827E4780", Slot = "7")]
	public override string JOOGKGIFDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27E4770", Offset = "0x27E3970", VA = "0x1827E4770")]
	public LFAFEALJKOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HBDKECLCAAL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : AMPKJOMLEIF.CDIHPBHLCKH<TAction, TNetSys> where TReceiverDeps : AMPKJOMLEIF.CAOPBFGGNPI<TAction, TReceiver> where TRootDeps : AMPKJOMLEIF.BPPIPJJOBKG<TMRequest, TAction, TRoot> where TDeps : AMPKJOMLEIF.PCPOEDNHOEP<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface HJMLKLELDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FJGBDJBJLPO([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DDODJBNMEOF();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LOAMJJJEMNF<object, PLLHOMFPAAM> NFGLEHEBBPC();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MFHPFLKEFCD(Exception MJPFDOAJBLF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class BHIDIMDMDKC : HJMLKLELDPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>> GCHMIADOJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<LOAMJJJEMNF<object, GEFBDEPLDON>> DIDCNEGHBFI;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D5B0", Offset = "0x5E8C7B0", VA = "0x185E8D5B0")]
		private BHIDIMDMDKC(TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>> JDJHNJLLIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4C7DFD0", Offset = "0x4C7D1D0", VA = "0x184C7DFD0")]
		public static BHIDIMDMDKC OIKMHICCLEP(TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>> JDJHNJLLIGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D040", Offset = "0x5E8C240", VA = "0x185E8D040")]
		public void FJGBDJBJLPO([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CD60", Offset = "0x5E8BF60", VA = "0x185E8CD60", Slot = "5")]
		public void DDODJBNMEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D500", Offset = "0x5E8C700", VA = "0x185E8D500", Slot = "6")]
		public LOAMJJJEMNF<object, PLLHOMFPAAM> NFGLEHEBBPC()
		{
			return default(LOAMJJJEMNF<object, PLLHOMFPAAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D280", Offset = "0x5E8C480", VA = "0x185E8D280", Slot = "7")]
		public void MFHPFLKEFCD(Exception MJPFDOAJBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x49AD630", Offset = "0x49AC830", VA = "0x1849AD630", Slot = "4")]
		private void OCFAMKOLJGD([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class IPCOHGCDGGI : HJMLKLELDPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>> GCHMIADOJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LOAMJJJEMNF<object, PLLHOMFPAAM> DLACKHMAAFK;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
		private IPCOHGCDGGI(TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>> JDJHNJLLIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4C7DFD0", Offset = "0x4C7D1D0", VA = "0x184C7DFD0")]
		public static IPCOHGCDGGI OIKMHICCLEP(TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>> JDJHNJLLIGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xDC4290", Offset = "0xDC3490", VA = "0x180DC4290")]
		public void FJGBDJBJLPO([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4CB2AF0", Offset = "0x4CB1CF0", VA = "0x184CB2AF0", Slot = "5")]
		public void DDODJBNMEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0", Slot = "6")]
		public LOAMJJJEMNF<object, PLLHOMFPAAM> NFGLEHEBBPC()
		{
			return default(LOAMJJJEMNF<object, PLLHOMFPAAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4CB2C10", Offset = "0x4CB1E10", VA = "0x184CB2C10", Slot = "7")]
		public void MFHPFLKEFCD(Exception MJPFDOAJBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x49AD630", Offset = "0x49AC830", VA = "0x1849AD630", Slot = "4")]
		private void OCFAMKOLJGD([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class FPNIGEMLKAA : HJMLKLELDPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<LOAMJJJEMNF<object, PLLHOMFPAAM>> DIDCNEGHBFI;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x49B5B40", Offset = "0x49B4D40", VA = "0x1849B5B40")]
		private FPNIGEMLKAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x49AD670", Offset = "0x49AC870", VA = "0x1849AD670")]
		public static FPNIGEMLKAA OIKMHICCLEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x49B5600", Offset = "0x49B4800", VA = "0x1849B5600")]
		public void FJGBDJBJLPO([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void DDODJBNMEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49B59F0", Offset = "0x49B4BF0", VA = "0x1849B59F0", Slot = "6")]
		public LOAMJJJEMNF<object, PLLHOMFPAAM> NFGLEHEBBPC()
		{
			return default(LOAMJJJEMNF<object, PLLHOMFPAAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x49B5940", Offset = "0x49B4B40", VA = "0x1849B5940", Slot = "7")]
		[CGDAAOOHDFB("This may be terminal and should probably do more than discarding the exception.")]
		public void MFHPFLKEFCD(Exception MJPFDOAJBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x49AD630", Offset = "0x49AC830", VA = "0x1849AD630", Slot = "4")]
		private void OCFAMKOLJGD([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class FKEHOFAGDCD : HJMLKLELDPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private LOAMJJJEMNF<object, PLLHOMFPAAM> DLACKHMAAFK;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		private FKEHOFAGDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x49AD670", Offset = "0x49AC870", VA = "0x1849AD670")]
		public static FKEHOFAGDCD OIKMHICCLEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x234AEB0", Offset = "0x234A0B0", VA = "0x18234AEB0")]
		public void FJGBDJBJLPO([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void DDODJBNMEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0", Slot = "6")]
		public LOAMJJJEMNF<object, PLLHOMFPAAM> NFGLEHEBBPC()
		{
			return default(LOAMJJJEMNF<object, PLLHOMFPAAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x49AD540", Offset = "0x49AC740", VA = "0x1849AD540", Slot = "7")]
		[CGDAAOOHDFB("This may be terminal and should probably do more than discarding the exception.")]
		public void MFHPFLKEFCD(Exception MJPFDOAJBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x49AD630", Offset = "0x49AC830", VA = "0x1849AD630", Slot = "4")]
		private void OCFAMKOLJGD([In] LOAMJJJEMNF<object, PLLHOMFPAAM> IGGKBIDIAJL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct IKMOEHJGHJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HBDKECLCAAL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JFIBBLJIDCN<MCGHCCOIFPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4C9FEB0", Offset = "0x4C9F0B0", VA = "0x184C9FEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4CA0400", Offset = "0x4C9F600", VA = "0x184CA0400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct JGACOOFHJNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HBDKECLCAAL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JFIBBLJIDCN<MCGHCCOIFPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9090", Offset = "0x4EB8290", VA = "0x184EB9090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4EB95D0", Offset = "0x4EB87D0", VA = "0x184EB95D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FGILPFHDHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public HBDKECLCAAL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JFIBBLJIDCN<MCGHCCOIFPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JFIBBLJIDCN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x499FB70", Offset = "0x499ED70", VA = "0x18499FB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x49A0690", Offset = "0x499F890", VA = "0x1849A0690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KFCIDJELDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public HBDKECLCAAL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JFIBBLJIDCN<MCGHCCOIFPD> senderId;

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
		public JFIBBLJIDCN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private HJMLKLELDPC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50032C0", Offset = "0x50024C0", VA = "0x1850032C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5003F80", Offset = "0x5003180", VA = "0x185003F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PAOMECAONLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public HBDKECLCAAL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public HJMLKLELDPC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HJMLKLELDPC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x55FB9A0", Offset = "0x55FABA0", VA = "0x1855FB9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x55FD940", Offset = "0x55FCB40", VA = "0x1855FD940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct OIMMHPCPHHK : IAsyncStateMachine
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
		public HBDKECLCAAL<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JFIBBLJIDCN<MCGHCCOIFPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5536690", Offset = "0x5535890", VA = "0x185536690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5536D90", Offset = "0x5535F90", VA = "0x185536D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps MPDDJFAHINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<JFIBBLJIDCN<TMRequest>, TaskCompletionSource<LOAMJJJEMNF<object, PLLHOMFPAAM>>> JHIIHEEKBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NJKLHPCLCNM<TMRequest> BDHAFKBLKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool LEHCOLPCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int BFIIPOJIDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task DBLBIIKCOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int HAGHBNFOKFM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps FFMGMHJHBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4AF3900", Offset = "0x4AF2B00", VA = "0x184AF3900")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps CMEJFFPONGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4AF3980", Offset = "0x4AF2B80", VA = "0x184AF3980")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps NGMLHJKCJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4AF1530", Offset = "0x4AF0730", VA = "0x184AF1530")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IGKKEJCMPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD224B0", Offset = "0xD216B0", VA = "0x180D224B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD22350", Offset = "0xD21550", VA = "0x180D22350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MPELDFMFBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GKMMHLHIKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4B40", Offset = "0x4AF3D40", VA = "0x184AF4B40")]
	public HBDKECLCAAL(TDeps POLANHDJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4AF20D0", Offset = "0x4AF12D0", VA = "0x184AF20D0")]
	public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> CAKBFEHCGDJ(TRoot FHPKLENNKKO, TNetSys NAAGCCJCKHP, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, TAction HDKINMMJOHF, bool LKDKFJKIIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1A00", Offset = "0x4AF0C00", VA = "0x184AF1A00")]
	[AsyncStateMachine(typeof(HBDKECLCAAL<, , , , , , , , >.IKMOEHJGHJN))]
	private Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> CAKBFEHCGDJ(TRoot FHPKLENNKKO, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, TAction HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4AF3750", Offset = "0x4AF2950", VA = "0x184AF3750")]
	[AsyncStateMachine(typeof(HBDKECLCAAL<, , , , , , , , >.JGACOOFHJNN))]
	private Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> GPHDGHHHPGL(TRoot FHPKLENNKKO, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, TAction[] EPMMAHCPFOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1720", Offset = "0x4AF0920", VA = "0x184AF1720")]
	[AsyncStateMachine(typeof(HBDKECLCAAL<, , , , , , , , >.FGILPFHDHGP))]
	public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> BHMCMMFFJBJ(TRoot FHPKLENNKKO, TNetSys MLNADCBAOPC, TReceiver IJKONPKDHEA, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, JFIBBLJIDCN<TMRequest> ECNLOCBECHF, TAction HDKINMMJOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4AF3310", Offset = "0x4AF2510", VA = "0x184AF3310")]
	[AsyncStateMachine(typeof(HBDKECLCAAL<, , , , , , , , >.KFCIDJELDEF))]
	private Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> EMBAKJEOBPH(TRoot FHPKLENNKKO, TNetSys MLNADCBAOPC, TReceiver IJKONPKDHEA, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, JFIBBLJIDCN<TMRequest> ECNLOCBECHF, TAction HDKINMMJOHF, Task LPAGBLPIOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2EB0", Offset = "0x4AF20B0", VA = "0x184AF2EB0")]
	[AsyncStateMachine(typeof(HBDKECLCAAL<, , , , , , , , >.PAOMECAONLH))]
	private Task EEHPMPAFNJL(TRoot FHPKLENNKKO, TNetSys MLNADCBAOPC, TReceiver IJKONPKDHEA, TAction HDKINMMJOHF, HJMLKLELDPC CGFFJKIKCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4AF47D0", Offset = "0x4AF39D0", VA = "0x184AF47D0")]
	private void OMGIOBNIINK(TReceiver IJKONPKDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4090", Offset = "0x4AF3290", VA = "0x184AF4090")]
	private void NPNAKKKGCEL(TRoot FHPKLENNKKO, TNetSys MLNADCBAOPC, TReceiver IJKONPKDHEA, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, TAction HDKINMMJOHF, bool BFOMCLIHKHN, bool HJOGMFEPBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4490", Offset = "0x4AF3690", VA = "0x184AF4490")]
	[AsyncStateMachine(typeof(HBDKECLCAAL<, , , , , , , , >.OIMMHPCPHHK))]
	public Task OGEAJEDILBO(TRoot FHPKLENNKKO, TNetSys MLNADCBAOPC, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, TAction[] KJKFGKMDCPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AMPKJOMLEIF
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface CDIHPBHLCKH<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JKGIJJGDLEP(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction MCINDOLEKLH(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction FGPAMGJNIJN(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> NFMFENBPPBF(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] LOMOMDPJAMH(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF, int BJCGAPGLCHH);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BEGLGOPEHIP(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LJPPCBOGMFI(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool JLKFEPMKOPJ(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool KFENKEJCDKI(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool JPHFHHCBECI(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool DJDOFKOCLCL(TNetSys MKDJNMDODDK, TAction HDKINMMJOHF);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface PCPOEDNHOEP<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps FFMGMHJHBEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps NGMLHJKCJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps CMEJFFPONGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface CAOPBFGGNPI<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JFIBBLJIDCN<MCGHCCOIFPD> GDBLCAEKMIG(TReceiver IJKONPKDHEA);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LMBCJFLDDBG(TReceiver IJKONPKDHEA);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> BHMCMMFFJBJ(TReceiver IJKONPKDHEA, TAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] KLDJJKBOMIH(TReceiver IJKONPKDHEA);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface BPPIPJJOBKG<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EMBPDGJLGIM(TRoot FHPKLENNKKO);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int EEFMNGGDLMC(TRoot FHPKLENNKKO);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int PMBODPHGLGM(TRoot FHPKLENNKKO);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int OAILBODOBJJ(TRoot FHPKLENNKKO);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JAJPHOKINBE(TRoot FHPKLENNKKO);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OKFOEMJHGGJ(TRoot FHPKLENNKKO, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, TAction[] EPMMAHCPFOI);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task CAKBFEHCGDJ(TRoot FHPKLENNKKO, JFIBBLJIDCN<MCGHCCOIFPD> IFJLLOBDJLG, JFIBBLJIDCN<TMRequest> ECNLOCBECHF, TAction HDKINMMJOHF, bool KNGCJOBOMIJ = true);
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
