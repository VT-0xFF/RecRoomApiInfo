using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BDINMNHMMPI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BAGKHHPJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Camera CDEDFJNNGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KBJOPGEOOCH FJFEFCLDGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JEPHPFEOHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KBJOPGEOOCH EDCDOIGJAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Transform ICLADFINGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DADOMFMGNGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private GBAHALBBEFO FAFCDNENBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private GBAHALBBEFO LDBGNHOKNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<object, GBAHALBBEFO> FDFDJEOGGNH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BABEIMNAAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FADDB0", Offset = "0x6FAC5B0", VA = "0x186FADDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GBAHALBBEFO FDMJOHNAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70")]
		get
		{
			return default(GBAHALBBEFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GBAHALBBEFO AGIOHNAEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80D490", VA = "0x18080EC90")]
		get
		{
			return default(GBAHALBBEFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FADBC0", Offset = "0x6FAC3C0", VA = "0x186FADBC0")]
	public bool JKMEINBJGBN(object FLDJLPKNKKO, GBAHALBBEFO ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FADB60", Offset = "0x6FAC360", VA = "0x186FADB60")]
	public bool CBLDDCBDCPG(object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FADC30", Offset = "0x6FAC430", VA = "0x186FADC30")]
	private bool MMDGNIKHGIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FADE00", Offset = "0x6FAC600", VA = "0x186FADE00")]
	public DADOMFMGNGH()
	{
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, CAMANOLKPPF
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class JCEKEENPNDD<T> : OCAIFGBJNDL, global::CBKGIODANAL<T>, FDLOOMEBFFN where T : class, ADEMDHOELEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x32E7780", Offset = "0x32E5F80", VA = "0x1832E7780")]
			internal JCEKEENPNDD(int KEMJDLPMKJC, float[] APLBAOKCJMH, JIFBNEHBIHE DFNLACDGCJP = JIFBNEHBIHE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x32E7680", Offset = "0x32E5E80", VA = "0x1832E7680", Slot = "15")]
			public void CAILCKFFJIK(T HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x32E76B0", Offset = "0x32E5EB0", VA = "0x1832E76B0", Slot = "16")]
			public void CAILCKFFJIK(T HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x32E7740", Offset = "0x32E5F40", VA = "0x1832E7740", Slot = "17")]
			public void JJOACBAGNIC(T HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x32E76E0", Offset = "0x32E5EE0", VA = "0x1832E76E0", Slot = "18")]
			public void CPPHPNNFPKL(T CIHBNKECJOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x32E7760", Offset = "0x32E5F60", VA = "0x1832E7760", Slot = "19")]
			public GBAHALBBEFO NBABKLLOPPO(T HHNPCHNMLMA)
			{
				return default(GBAHALBBEFO);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x32E7700", Offset = "0x32E5F00", VA = "0x1832E7700", Slot = "20")]
			public bool DAOMDHGCLOP(T HHNPCHNMLMA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x32E7720", Offset = "0x32E5F20", VA = "0x1832E7720", Slot = "21")]
			public void FBMNDAIKFCN(T HHNPCHNMLMA, FFFAJCBJCHK CCLDMBAFDJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class OCAIFGBJNDL : IDisposable, FDLOOMEBFFN
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public enum JIFBNEHBIHE : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private class AEGLGEINBFM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public ADEMDHOELEN CKAFNFFOKJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public FFFAJCBJCHK CCPHLOJANCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public Action PLILALLBCEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public bool FNGNBNPEONF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public int OJOINFOLDPA;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
				public AEGLGEINBFM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class GJMMNINNFNN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public OCAIFGBJNDL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public AEGLGEINBFM trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
				public GJMMNINNFNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x6FADE80", Offset = "0x6FAC680", VA = "0x186FADE80")]
				internal void CLFEGKDLFKL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int FHOLCGDDJFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int KEMJDLPMKJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly int MOFHMKEEEFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private bool GHKACLCDPMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly CullingGroup IBJOKKJDEIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private BoundingSphere[] PPJONFBCMEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private Transform[] AFDPEGBOHMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly BDINMNHMMPI FGOMHOJPKFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly Dictionary<ADEMDHOELEN, int> DFDPMIOJNKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly Dictionary<int, AEGLGEINBFM> MFLFEKBFNIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly JIFBNEHBIHE DFNLACDGCJP;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public int JJNJBIEPOAJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80D270", VA = "0x18080EA70", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public int HCHMCBDKMMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80D490", VA = "0x18080EC90", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFEC0", Offset = "0x6FAE6C0", VA = "0x186FAFEC0")]
			internal OCAIFGBJNDL(int KEMJDLPMKJC, float[] APLBAOKCJMH, JIFBNEHBIHE DFNLACDGCJP = JIFBNEHBIHE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFA70", Offset = "0x6FAE270", VA = "0x186FAFA70")]
			public void JCDABPGNIJJ(bool ALPKOFENEIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFB30", Offset = "0x6FAE330", VA = "0x186FAFB30", Slot = "7")]
			public GBAHALBBEFO MGLHCGNDNOG(float CIKEFFDMPDJ)
			{
				return default(GBAHALBBEFO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FAE490", Offset = "0x6FACC90", VA = "0x186FAE490", Slot = "8")]
			public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FAE040", Offset = "0x6FAC840", VA = "0x186FAE040", Slot = "9")]
			public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6FADEC0", Offset = "0x6FAC6C0", VA = "0x186FADEC0")]
			public void ABEIJEDIJPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFAB0", Offset = "0x6FAE2B0", VA = "0x186FAFAB0", Slot = "10")]
			public void JJOACBAGNIC(ADEMDHOELEN HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6FAF910", Offset = "0x6FAE110", VA = "0x186FAF910")]
			private void IKLGEFACJDA(int NHHNPPKPBIA, [Optional] float? EAHPLIAGBOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6FAE590", Offset = "0x6FACD90", VA = "0x186FAE590", Slot = "11")]
			public void CPPHPNNFPKL(ADEMDHOELEN CIHBNKECJOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFD00", Offset = "0x6FAE500", VA = "0x186FAFD00", Slot = "12")]
			public GBAHALBBEFO NBABKLLOPPO(ADEMDHOELEN HHNPCHNMLMA)
			{
				return default(GBAHALBBEFO);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6FAE9C0", Offset = "0x6FAD1C0", VA = "0x186FAE9C0", Slot = "13")]
			public bool DAOMDHGCLOP(ADEMDHOELEN HHNPCHNMLMA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6FAF0A0", Offset = "0x6FAD8A0", VA = "0x186FAF0A0", Slot = "14")]
			public void FBMNDAIKFCN(ADEMDHOELEN HHNPCHNMLMA, FFFAJCBJCHK DEPKDIMCDDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6FAEAC0", Offset = "0x6FAD2C0", VA = "0x186FAEAC0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6FAF310", Offset = "0x6FADB10", VA = "0x186FAF310")]
			private void HGOFOMHMFCC(AEGLGEINBFM EHGPFANFPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6FAF680", Offset = "0x6FADE80", VA = "0x186FAF680")]
			private void IJGKLAPKKEB(AEGLGEINBFM EHGPFANFPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6FAE520", Offset = "0x6FACD20", VA = "0x186FAE520")]
			private void CBCEBKCKLEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFE20", Offset = "0x6FAE620", VA = "0x186FAFE20")]
			private void OIECEBAHPIH(float CMDEAIELDHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFE90", Offset = "0x6FAE690", VA = "0x186FAFE90")]
			private void PHJIKAFDHIC(AEGLGEINBFM EHGPFANFPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFE10", Offset = "0x6FAE610", VA = "0x186FAFE10")]
			private void NMACOHDKOBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6FAFAA0", Offset = "0x6FAE2A0", VA = "0x186FAFAA0")]
			private void JFHEDJABJLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6FAED60", Offset = "0x6FAD560", VA = "0x186FAED60")]
			private void EJAGMPOFPMB(CullingGroupEvent IBMACKPBMJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FAF190", Offset = "0x6FAD990", VA = "0x186FAF190")]
			private void FBOIEADDMKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct CNEKBJDLEEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ushort FICJFBKHCLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Type OHIKCJLCDJB;
		}

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NBPAPOPNFGM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JNDGGJIHPAI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OACKLFNCJPM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float HBMILPADBGI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float JGDMFFOIHEM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float EGCNAGNEOBI = 100f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float IGOLMIIGOFH = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly Dictionary<CNEKBJDLEEA, OCAIFGBJNDL> MKHDONALEIO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable FACPECFPLJP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static IDisposable NHFAIOCAFIN;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static KBJOPGEOOCH IMMBOAPGPFP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static KBJOPGEOOCH IPILOCKHPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KBJOPGEOOCH ONPKIGGOHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly KBJOPGEOOCH BIJEJIOCEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KBJOPGEOOCH OHPIJIMGOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CMHJCDCDCHH COOMMCKMGPN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool ALPKOFENEIP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KBJOPGEOOCH ANIKGJPLMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KBJOPGEOOCH GALNLBOKHLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KBJOPGEOOCH AJKBNFAOPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BDFENNMIFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1BD0BA0", Offset = "0x1BCF3A0", VA = "0x181BD0BA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JGOGHINMICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE60", Offset = "0x8AA660", VA = "0x1808ABE60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDA40B0", Offset = "0xDA28B0", VA = "0x180DA40B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC990", Offset = "0x6FAB190", VA = "0x186FAC990", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x24CBE80", Offset = "0x24CA680", VA = "0x1824CBE80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD400", Offset = "0x6FABC00", VA = "0x186FAD400")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FACF60", Offset = "0x6FAB760", VA = "0x186FACF60")]
		private void ICNKPPHFAAB(Scene IKOPIEMNEKF, LoadSceneMode JBENBACJFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD320", Offset = "0x6FABB20", VA = "0x186FAD320", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD650", Offset = "0x6FABE50", VA = "0x186FAD650")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD160", Offset = "0x6FAB960", VA = "0x186FAD160")]
		private void LNDEKPKFHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD420", Offset = "0x6FABC20", VA = "0x186FAD420")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FACBF0", Offset = "0x6FAB3F0", VA = "0x186FACBF0")]
		private void GNOBDPJODPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FACD70", Offset = "0x6FAB570", VA = "0x186FACD70")]
		public FDLOOMEBFFN GetOrCreateCullingGroup(Type BCNGABPNCFE, int GBOBCCMGKMG, ushort LNLGJPKGMHI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2E96850", Offset = "0x2E95050", VA = "0x182E96850")]
		public global::CBKGIODANAL<T> GetOrCreateCullingGroup<T>(int GBOBCCMGKMG, ushort LNLGJPKGMHI = 0) where T : class, ADEMDHOELEN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FACFC0", Offset = "0x6FAB7C0", VA = "0x186FACFC0")]
		private FDLOOMEBFFN KKBIDAPGBJC(Type BCNGABPNCFE, int GBOBCCMGKMG, float[] APLBAOKCJMH, ushort LNLGJPKGMHI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2E96900", Offset = "0x2E95100", VA = "0x182E96900")]
		private global::CBKGIODANAL<T> KKBIDAPGBJC<T>(int GBOBCCMGKMG, float[] APLBAOKCJMH, ushort LNLGJPKGMHI = 0) where T : class, ADEMDHOELEN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6FACA60", Offset = "0x6FAB260", VA = "0x186FACA60")]
		public static GBAHALBBEFO FindClosestDefaultUpdateLod(float LLDNMBECCLP)
		{
			return default(GBAHALBBEFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD310", Offset = "0x6FABB10", VA = "0x186FAD310")]
		public static GBAHALBBEFO MinUpdateLod(GBAHALBBEFO IKBCIDJFGAO, GBAHALBBEFO IGPHBEAGLGF)
		{
			return default(GBAHALBBEFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD300", Offset = "0x6FABB00", VA = "0x186FAD300")]
		public static GBAHALBBEFO MaxUpdateLod(GBAHALBBEFO IKBCIDJFGAO, GBAHALBBEFO IGPHBEAGLGF)
		{
			return default(GBAHALBBEFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FADA80", Offset = "0x6FAC280", VA = "0x186FADA80")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum GBAHALBBEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Transform HGGDDBMAHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GBAHALBBEFO FIIFHFDPPBC, GBAHALBBEFO DPHBMFBPJLA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool HGLINGKMEAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FDLOOMEBFFN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int JJNJBIEPOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int HCHMCBDKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GBAHALBBEFO MGLHCGNDNOG(float CIKEFFDMPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JJOACBAGNIC(ADEMDHOELEN HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CPPHPNNFPKL(ADEMDHOELEN CIHBNKECJOF);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GBAHALBBEFO NBABKLLOPPO(ADEMDHOELEN HHNPCHNMLMA);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DAOMDHGCLOP(ADEMDHOELEN HHNPCHNMLMA);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FBMNDAIKFCN(ADEMDHOELEN HHNPCHNMLMA, FFFAJCBJCHK CCLDMBAFDJM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CBKGIODANAL<T> : FDLOOMEBFFN where T : class, ADEMDHOELEN
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(T HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAILCKFFJIK(T HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJOACBAGNIC(T HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPPHPNNFPKL(T CIHBNKECJOF);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GBAHALBBEFO NBABKLLOPPO(T HHNPCHNMLMA);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DAOMDHGCLOP(T HHNPCHNMLMA);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBMNDAIKFCN(T HHNPCHNMLMA, FFFAJCBJCHK CCLDMBAFDJM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum FFFAJCBJCHK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Full
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
