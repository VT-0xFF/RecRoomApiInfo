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
public interface MCDOJODDMGK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HIJDIAIOGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Camera EJAGAPNGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NHBIDAMCDOH BLEIJODADBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DNECPEKKOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NHBIDAMCDOH GBNPHKPOHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Transform EPHOMPPFBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MAPCKOPIMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private CDHDCBBOJLO LMBLJACJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CDHDCBBOJLO KHIOAKAGFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<object, CDHDCBBOJLO> GDPBNDIGKPL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OHNJIHPCMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7261810", Offset = "0x7260810", VA = "0x187261810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CDHDCBBOJLO KHNIFNFHBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
		get
		{
			return default(CDHDCBBOJLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CDHDCBBOJLO MMMGHLMJHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x91B190", Offset = "0x91A190", VA = "0x18091B190")]
		get
		{
			return default(CDHDCBBOJLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72618C0", Offset = "0x72608C0", VA = "0x1872618C0")]
	public bool EMJBIEFIIMD(object FFKJLIDBALM, CDHDCBBOJLO CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7261860", Offset = "0x7260860", VA = "0x187261860")]
	public bool EGPLDBHNAGL(object FFKJLIDBALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7261930", Offset = "0x7260930", VA = "0x187261930")]
	private bool ODGBBDBOADA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7261AC0", Offset = "0x7260AC0", VA = "0x187261AC0")]
	public MAPCKOPIMKC()
	{
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, GCMGPIABEJC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class FPIDDMGMJFN<T> : HJKLKDKCFFB, KLCOOLGANEG<T>, JLAJANPMJBM where T : class, ELBCOIDLJBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x31B9BB0", Offset = "0x31B8BB0", VA = "0x1831B9BB0")]
			internal FPIDDMGMJFN(int GEDMHPPMLFN, float[] MOIALNEOGLA, MPJPHGMABGK OLNKLDANOEP = MPJPHGMABGK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x31B9AB0", Offset = "0x31B8AB0", VA = "0x1831B9AB0", Slot = "15")]
			public void AMLBOIMHPGF(T EOHGDDIECBJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x31B9AE0", Offset = "0x31B8AE0", VA = "0x1831B9AE0", Slot = "16")]
			public void AMLBOIMHPGF(T EOHGDDIECBJ, Transform IKIJKLIBPKJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x31B9B70", Offset = "0x31B8B70", VA = "0x1831B9B70", Slot = "17")]
			public void KFHJNPIOOAN(T EOHGDDIECBJ, [Optional] float? MFIGFOJHONE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x31B9B10", Offset = "0x31B8B10", VA = "0x1831B9B10", Slot = "18")]
			public void DNDEJFPIDIA(T APLLNPMBLDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x31B9B90", Offset = "0x31B8B90", VA = "0x1831B9B90", Slot = "19")]
			public CDHDCBBOJLO LBDKKLEBDDO(T EOHGDDIECBJ)
			{
				return default(CDHDCBBOJLO);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x31B9B50", Offset = "0x31B8B50", VA = "0x1831B9B50", Slot = "20")]
			public bool KCGLJKBEJCM(T EOHGDDIECBJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x31B9B30", Offset = "0x31B8B30", VA = "0x1831B9B30", Slot = "21")]
			public void IADJCOBAEBO(T EOHGDDIECBJ, EAAMOAHJJCP PPFNFAHPOGJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class HJKLKDKCFFB : IDisposable, JLAJANPMJBM
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public enum MPJPHGMABGK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private class KCDNJNLEALK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public ELBCOIDLJBC LBOKNIDGHAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public EAAMOAHJJCP LKDIOFPLCNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public Action ELEBJAJJKFH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public bool MAAGENCMPKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public int EODOJNLPHFB;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
				public KCDNJNLEALK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class EDIFNHMNFDI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public HJKLKDKCFFB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public KCDNJNLEALK trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
				public EDIFNHMNFDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x725F3D0", Offset = "0x725E3D0", VA = "0x18725F3D0")]
				internal void KDBAPBLMFCC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int EFEEGBKFIDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int GEDMHPPMLFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly int GOFDJFEHHAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private bool NBJIGGJMNPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly CullingGroup BGCLKJIBDHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private BoundingSphere[] OAFCLHJBPFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private Transform[] DABLOEDEGLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly MCDOJODDMGK IFMMICNCAOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly Dictionary<ELBCOIDLJBC, int> OJJFHDPEEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly Dictionary<int, KCDNJNLEALK> JJCPDKDNPPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly MPJPHGMABGK OLNKLDANOEP;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public int OIJDDAJNGKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public int IGMLPEJMDEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x91B190", Offset = "0x91A190", VA = "0x18091B190", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7261440", Offset = "0x7260440", VA = "0x187261440")]
			internal HJKLKDKCFFB(int GEDMHPPMLFN, float[] MOIALNEOGLA, MPJPHGMABGK OLNKLDANOEP = MPJPHGMABGK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7260C40", Offset = "0x725FC40", VA = "0x187260C40")]
			public void HEOBHIAIMBO(bool OEILNLDPJCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7261240", Offset = "0x7260240", VA = "0x187261240", Slot = "7")]
			public CDHDCBBOJLO MOIHBHKFPDH(float JCGCOMMMLOD)
			{
				return default(CDHDCBBOJLO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x725F880", Offset = "0x725E880", VA = "0x18725F880", Slot = "8")]
			public void AMLBOIMHPGF(ELBCOIDLJBC EOHGDDIECBJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x725F410", Offset = "0x725E410", VA = "0x18725F410", Slot = "9")]
			public void AMLBOIMHPGF(ELBCOIDLJBC EOHGDDIECBJ, Transform IKIJKLIBPKJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7260360", Offset = "0x725F360", VA = "0x187260360")]
			public void FFEMBGINDBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72610B0", Offset = "0x72600B0", VA = "0x1872610B0", Slot = "10")]
			public void KFHJNPIOOAN(ELBCOIDLJBC EOHGDDIECBJ, [Optional] float? MFIGFOJHONE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7260DD0", Offset = "0x725FDD0", VA = "0x187260DD0")]
			private void IJEFPKOBIFJ(int CCELBNKPBGB, [Optional] float? MFIGFOJHONE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x725FC80", Offset = "0x725EC80", VA = "0x18725FC80", Slot = "11")]
			public void DNDEJFPIDIA(ELBCOIDLJBC APLLNPMBLDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7261130", Offset = "0x7260130", VA = "0x187261130", Slot = "12")]
			public CDHDCBBOJLO LBDKKLEBDDO(ELBCOIDLJBC EOHGDDIECBJ)
			{
				return default(CDHDCBBOJLO);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7260FB0", Offset = "0x725FFB0", VA = "0x187260FB0", Slot = "13")]
			public bool KCGLJKBEJCM(ELBCOIDLJBC EOHGDDIECBJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7260CE0", Offset = "0x725FCE0", VA = "0x187260CE0", Slot = "14")]
			public void IADJCOBAEBO(ELBCOIDLJBC EOHGDDIECBJ, EAAMOAHJJCP GIIKCDHCIIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72600B0", Offset = "0x725F0B0", VA = "0x1872600B0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x725F910", Offset = "0x725E910", VA = "0x18725F910")]
			private void DLBCFLDAIJP(KCDNJNLEALK IENANHCODCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x72604F0", Offset = "0x725F4F0", VA = "0x1872604F0")]
			private void GDPGBOICPNF(KCDNJNLEALK IENANHCODCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7260C70", Offset = "0x725FC70", VA = "0x187260C70")]
			private void HIGHHFCLNCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7260F40", Offset = "0x725FF40", VA = "0x187260F40")]
			private void JMIJMFOAAHH(float ICKIFAGNODH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7261410", Offset = "0x7260410", VA = "0x187261410")]
			private void NCPAEOEGEDI(KCDNJNLEALK IENANHCODCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x72604E0", Offset = "0x725F4E0", VA = "0x1872604E0")]
			private void GDHIJDANHBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7260F30", Offset = "0x725FF30", VA = "0x187260F30")]
			private void IJOIGNFEPAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7260780", Offset = "0x725F780", VA = "0x187260780")]
			private void GLEEAFLOFGE(CullingGroupEvent HHGAGJPMDAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7260AC0", Offset = "0x725FAC0", VA = "0x187260AC0")]
			private void GMAEOAKNLFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct NNJDFKBFDGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ushort LPHGFGBOAFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Type NGNCAGDBBCP;
		}

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LDPNHNEOEGF = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float PDDLLCMCMIN = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float AOMFDPDGKAJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KLJJANJBMJG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float NFBNOMLCKGC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float AONEBCBKOIE = 100f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float PNLIJLNBPNK = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly Dictionary<NNJDFKBFDGL, HJKLKDKCFFB> KJOMHIKJIAM;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable MPOHAFMCCFM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static IDisposable KNGBDBBGELF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static NHBIDAMCDOH NNKPMMGLHNF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static NHBIDAMCDOH FPEIOBNJFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly NHBIDAMCDOH IDPDAKPIGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly NHBIDAMCDOH KDPDBKDPMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly NHBIDAMCDOH JHEHOIBBCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HKMCLDHFALI MMOLDOBDEDN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool OEILNLDPJCN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NHBIDAMCDOH ICLABNAIEHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NHBIDAMCDOH KLKDDOOPIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NHBIDAMCDOH MLEDDBEGECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EPJGFGNBMBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x124FB60", Offset = "0x124EB60", VA = "0x18124FB60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KBEHDNEHMDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x90AA90", Offset = "0x909A90", VA = "0x18090AA90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x90AAA0", Offset = "0x909AA0", VA = "0x18090AAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x725E200", Offset = "0x725D200", VA = "0x18725E200", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B02A50", Offset = "0x1B01A50", VA = "0x181B02A50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x725EAF0", Offset = "0x725DAF0", VA = "0x18725EAF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x725E990", Offset = "0x725D990", VA = "0x18725E990")]
		private void JIJNPCGJNII(Scene DONBOKOKLIL, LoadSceneMode LPLFJNECDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x725EA10", Offset = "0x725DA10", VA = "0x18725EA10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x725EEC0", Offset = "0x725DEC0", VA = "0x18725EEC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x725E2D0", Offset = "0x725D2D0", VA = "0x18725E2D0")]
		private void FGPDKNEKKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x725EC90", Offset = "0x725DC90", VA = "0x18725EC90")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x725EB10", Offset = "0x725DB10", VA = "0x18725EB10")]
		private void PNLMHELPNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x725E600", Offset = "0x725D600", VA = "0x18725E600")]
		public JLAJANPMJBM GetOrCreateCullingGroup(Type FHOFJAAFCIK, int KCEALPPMCIE, ushort AMCEAKKLPHJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x23D8C50", Offset = "0x23D7C50", VA = "0x1823D8C50")]
		public KLCOOLGANEG<T> GetOrCreateCullingGroup<T>(int KCEALPPMCIE, ushort AMCEAKKLPHJ = 0) where T : class, ELBCOIDLJBC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x725E7F0", Offset = "0x725D7F0", VA = "0x18725E7F0")]
		private JLAJANPMJBM HLOCOIGEKAP(Type FHOFJAAFCIK, int KCEALPPMCIE, float[] MOIALNEOGLA, ushort AMCEAKKLPHJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x23D8D00", Offset = "0x23D7D00", VA = "0x1823D8D00")]
		private KLCOOLGANEG<T> HLOCOIGEKAP<T>(int KCEALPPMCIE, float[] MOIALNEOGLA, ushort AMCEAKKLPHJ = 0) where T : class, ELBCOIDLJBC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x725E470", Offset = "0x725D470", VA = "0x18725E470")]
		public static CDHDCBBOJLO FindClosestDefaultUpdateLod(float KPBHPLHEGJJ)
		{
			return default(CDHDCBBOJLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x725EA00", Offset = "0x725DA00", VA = "0x18725EA00")]
		public static CDHDCBBOJLO MinUpdateLod(CDHDCBBOJLO NFLOEOLEMPC, CDHDCBBOJLO GOIGJGBPGCN)
		{
			return default(CDHDCBBOJLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x725E9F0", Offset = "0x725D9F0", VA = "0x18725E9F0")]
		public static CDHDCBBOJLO MaxUpdateLod(CDHDCBBOJLO NFLOEOLEMPC, CDHDCBBOJLO GOIGJGBPGCN)
		{
			return default(CDHDCBBOJLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x725F2F0", Offset = "0x725E2F0", VA = "0x18725F2F0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum CDHDCBBOJLO
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
public interface ELBCOIDLJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Transform IJKOODCAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CDHDCBBOJLO GMDACNKJDGE, CDHDCBBOJLO NAMHKAOMNNK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GAOJOOJGIPC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JLAJANPMJBM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int OIJDDAJNGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int IGMLPEJMDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CDHDCBBOJLO MOIHBHKFPDH(float JCGCOMMMLOD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMLBOIMHPGF(ELBCOIDLJBC EOHGDDIECBJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMLBOIMHPGF(ELBCOIDLJBC EOHGDDIECBJ, Transform IKIJKLIBPKJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFHJNPIOOAN(ELBCOIDLJBC EOHGDDIECBJ, [Optional] float? MFIGFOJHONE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNDEJFPIDIA(ELBCOIDLJBC APLLNPMBLDC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CDHDCBBOJLO LBDKKLEBDDO(ELBCOIDLJBC EOHGDDIECBJ);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KCGLJKBEJCM(ELBCOIDLJBC EOHGDDIECBJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IADJCOBAEBO(ELBCOIDLJBC EOHGDDIECBJ, EAAMOAHJJCP PPFNFAHPOGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KLCOOLGANEG<T> : JLAJANPMJBM where T : class, ELBCOIDLJBC
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(T EOHGDDIECBJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMLBOIMHPGF(T EOHGDDIECBJ, Transform IKIJKLIBPKJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFHJNPIOOAN(T EOHGDDIECBJ, [Optional] float? MFIGFOJHONE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNDEJFPIDIA(T APLLNPMBLDC);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CDHDCBBOJLO LBDKKLEBDDO(T EOHGDDIECBJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KCGLJKBEJCM(T EOHGDDIECBJ);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IADJCOBAEBO(T EOHGDDIECBJ, EAAMOAHJJCP PPFNFAHPOGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum EAAMOAHJJCP : byte
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
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
