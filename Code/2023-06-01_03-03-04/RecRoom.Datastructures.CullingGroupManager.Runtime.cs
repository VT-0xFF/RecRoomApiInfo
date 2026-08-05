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
		[Cpp2IlInjected.Address(RVA = "0x6F7E800", Offset = "0x6F7D400", VA = "0x186F7E800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GBAHALBBEFO FDMJOHNAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
		get
		{
			return default(GBAHALBBEFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GBAHALBBEFO AGIOHNAEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F1E20", VA = "0x1807F3220")]
		get
		{
			return default(GBAHALBBEFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E610", Offset = "0x6F7D210", VA = "0x186F7E610")]
	public bool JKMEINBJGBN(object FLDJLPKNKKO, GBAHALBBEFO ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E5B0", Offset = "0x6F7D1B0", VA = "0x186F7E5B0")]
	public bool CBLDDCBDCPG(object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E680", Offset = "0x6F7D280", VA = "0x186F7E680")]
	private bool MMDGNIKHGIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E850", Offset = "0x6F7D450", VA = "0x186F7E850")]
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
		private class JCEKEENPNDD<T> : OCAIFGBJNDL, CBKGIODANAL<T>, FDLOOMEBFFN where T : class, ADEMDHOELEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF6C0", Offset = "0x3EAE2C0", VA = "0x183EAF6C0")]
			internal JCEKEENPNDD(int KEMJDLPMKJC, float[] APLBAOKCJMH, JIFBNEHBIHE DFNLACDGCJP = JIFBNEHBIHE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF5C0", Offset = "0x3EAE1C0", VA = "0x183EAF5C0", Slot = "15")]
			public void CAILCKFFJIK(T HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF5F0", Offset = "0x3EAE1F0", VA = "0x183EAF5F0", Slot = "16")]
			public void CAILCKFFJIK(T HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF680", Offset = "0x3EAE280", VA = "0x183EAF680", Slot = "17")]
			public void JJOACBAGNIC(T HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF620", Offset = "0x3EAE220", VA = "0x183EAF620", Slot = "18")]
			public void CPPHPNNFPKL(T CIHBNKECJOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF6A0", Offset = "0x3EAE2A0", VA = "0x183EAF6A0", Slot = "19")]
			public GBAHALBBEFO NBABKLLOPPO(T HHNPCHNMLMA)
			{
				return default(GBAHALBBEFO);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF640", Offset = "0x3EAE240", VA = "0x183EAF640", Slot = "20")]
			public bool DAOMDHGCLOP(T HHNPCHNMLMA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF660", Offset = "0x3EAE260", VA = "0x183EAF660", Slot = "21")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
				public GJMMNINNFNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x6F7E8D0", Offset = "0x6F7D4D0", VA = "0x186F7E8D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public int HCHMCBDKMMD
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F1E20", VA = "0x1807F3220", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F80910", Offset = "0x6F7F510", VA = "0x186F80910")]
			internal OCAIFGBJNDL(int KEMJDLPMKJC, float[] APLBAOKCJMH, JIFBNEHBIHE DFNLACDGCJP = JIFBNEHBIHE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F804C0", Offset = "0x6F7F0C0", VA = "0x186F804C0")]
			public void JCDABPGNIJJ(bool ALPKOFENEIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F80580", Offset = "0x6F7F180", VA = "0x186F80580", Slot = "7")]
			public GBAHALBBEFO MGLHCGNDNOG(float CIKEFFDMPDJ)
			{
				return default(GBAHALBBEFO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F7EEE0", Offset = "0x6F7DAE0", VA = "0x186F7EEE0", Slot = "8")]
			public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F7EA90", Offset = "0x6F7D690", VA = "0x186F7EA90", Slot = "9")]
			public void CAILCKFFJIK(ADEMDHOELEN HHNPCHNMLMA, Transform ECEOKHAMMGI, float EAHPLIAGBOI, FFFAJCBJCHK HFGAPBKILNB = FFFAJCBJCHK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F7E910", Offset = "0x6F7D510", VA = "0x186F7E910")]
			public void ABEIJEDIJPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F80500", Offset = "0x6F7F100", VA = "0x186F80500", Slot = "10")]
			public void JJOACBAGNIC(ADEMDHOELEN HHNPCHNMLMA, [Optional] float? EAHPLIAGBOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F80360", Offset = "0x6F7EF60", VA = "0x186F80360")]
			private void IKLGEFACJDA(int NHHNPPKPBIA, [Optional] float? EAHPLIAGBOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F7EFE0", Offset = "0x6F7DBE0", VA = "0x186F7EFE0", Slot = "11")]
			public void CPPHPNNFPKL(ADEMDHOELEN CIHBNKECJOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F80750", Offset = "0x6F7F350", VA = "0x186F80750", Slot = "12")]
			public GBAHALBBEFO NBABKLLOPPO(ADEMDHOELEN HHNPCHNMLMA)
			{
				return default(GBAHALBBEFO);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7F410", Offset = "0x6F7E010", VA = "0x186F7F410", Slot = "13")]
			public bool DAOMDHGCLOP(ADEMDHOELEN HHNPCHNMLMA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7FAF0", Offset = "0x6F7E6F0", VA = "0x186F7FAF0", Slot = "14")]
			public void FBMNDAIKFCN(ADEMDHOELEN HHNPCHNMLMA, FFFAJCBJCHK DEPKDIMCDDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F7F510", Offset = "0x6F7E110", VA = "0x186F7F510", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F7FD60", Offset = "0x6F7E960", VA = "0x186F7FD60")]
			private void HGOFOMHMFCC(AEGLGEINBFM EHGPFANFPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F800D0", Offset = "0x6F7ECD0", VA = "0x186F800D0")]
			private void IJGKLAPKKEB(AEGLGEINBFM EHGPFANFPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F7EF70", Offset = "0x6F7DB70", VA = "0x186F7EF70")]
			private void CBCEBKCKLEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F80870", Offset = "0x6F7F470", VA = "0x186F80870")]
			private void OIECEBAHPIH(float CMDEAIELDHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F808E0", Offset = "0x6F7F4E0", VA = "0x186F808E0")]
			private void PHJIKAFDHIC(AEGLGEINBFM EHGPFANFPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F80860", Offset = "0x6F7F460", VA = "0x186F80860")]
			private void NMACOHDKOBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F804F0", Offset = "0x6F7F0F0", VA = "0x186F804F0")]
			private void JFHEDJABJLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F7F7B0", Offset = "0x6F7E3B0", VA = "0x186F7F7B0")]
			private void EJAGMPOFPMB(CullingGroupEvent IBMACKPBMJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F7FBE0", Offset = "0x6F7E7E0", VA = "0x186F7FBE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KBJOPGEOOCH GALNLBOKHLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KBJOPGEOOCH AJKBNFAOPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BDFENNMIFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x16F3FC0", Offset = "0x16F2BC0", VA = "0x1816F3FC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JGOGHINMICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC214A0", Offset = "0xC200A0", VA = "0x180C214A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC21520", Offset = "0xC20120", VA = "0x180C21520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D3E0", Offset = "0x6F7BFE0", VA = "0x186F7D3E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2122AE0", Offset = "0x21216E0", VA = "0x182122AE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DE50", Offset = "0x6F7CA50", VA = "0x186F7DE50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D9B0", Offset = "0x6F7C5B0", VA = "0x186F7D9B0")]
		private void ICNKPPHFAAB(Scene IKOPIEMNEKF, LoadSceneMode JBENBACJFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DD70", Offset = "0x6F7C970", VA = "0x186F7DD70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E0A0", Offset = "0x6F7CCA0", VA = "0x186F7E0A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DBB0", Offset = "0x6F7C7B0", VA = "0x186F7DBB0")]
		private void LNDEKPKFHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DE70", Offset = "0x6F7CA70", VA = "0x186F7DE70")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D640", Offset = "0x6F7C240", VA = "0x186F7D640")]
		private void GNOBDPJODPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D7C0", Offset = "0x6F7C3C0", VA = "0x186F7D7C0")]
		public FDLOOMEBFFN GetOrCreateCullingGroup(Type BCNGABPNCFE, int GBOBCCMGKMG, ushort LNLGJPKGMHI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2800920", Offset = "0x27FF520", VA = "0x182800920")]
		public CBKGIODANAL<T> GetOrCreateCullingGroup<T>(int GBOBCCMGKMG, ushort LNLGJPKGMHI = 0) where T : class, ADEMDHOELEN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DA10", Offset = "0x6F7C610", VA = "0x186F7DA10")]
		private FDLOOMEBFFN KKBIDAPGBJC(Type BCNGABPNCFE, int GBOBCCMGKMG, float[] APLBAOKCJMH, ushort LNLGJPKGMHI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28009D0", Offset = "0x27FF5D0", VA = "0x1828009D0")]
		private CBKGIODANAL<T> KKBIDAPGBJC<T>(int GBOBCCMGKMG, float[] APLBAOKCJMH, ushort LNLGJPKGMHI = 0) where T : class, ADEMDHOELEN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D4B0", Offset = "0x6F7C0B0", VA = "0x186F7D4B0")]
		public static GBAHALBBEFO FindClosestDefaultUpdateLod(float LLDNMBECCLP)
		{
			return default(GBAHALBBEFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DD60", Offset = "0x6F7C960", VA = "0x186F7DD60")]
		public static GBAHALBBEFO MinUpdateLod(GBAHALBBEFO IKBCIDJFGAO, GBAHALBBEFO IGPHBEAGLGF)
		{
			return default(GBAHALBBEFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DD50", Offset = "0x6F7C950", VA = "0x186F7DD50")]
		public static GBAHALBBEFO MaxUpdateLod(GBAHALBBEFO IKBCIDJFGAO, GBAHALBBEFO IGPHBEAGLGF)
		{
			return default(GBAHALBBEFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E4D0", Offset = "0x6F7D0D0", VA = "0x186F7E4D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
