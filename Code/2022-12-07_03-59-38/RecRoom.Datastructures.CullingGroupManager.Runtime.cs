using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JPAFKFIHEAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class NMBJLBDAJFC<T> : IKAEIDHLOKG, global::EFHGMNLOMOD<T>, NLGLCLPIJIK where T : class, LKFMGNANIOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x45E0660", Offset = "0x45DF260", VA = "0x1845E0660")]
			internal NMBJLBDAJFC(int DNJHPJJMPFN, float[] OCBBPJHNKDK, GDLCLIFJHFL DBPPCBLAAHD = GDLCLIFJHFL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x45E0560", Offset = "0x45DF160", VA = "0x1845E0560", Slot = "15")]
			public void AABPNGPFBPJ(T AOEMDAGAALP, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x45E0590", Offset = "0x45DF190", VA = "0x1845E0590", Slot = "16")]
			public void AABPNGPFBPJ(T AOEMDAGAALP, Transform MALFFFICOOA, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x45E05C0", Offset = "0x45DF1C0", VA = "0x1845E05C0", Slot = "17")]
			public void DJBPNBOHKAE(T AOEMDAGAALP, [Optional] float? LFPCAKAPFIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x45E0600", Offset = "0x45DF200", VA = "0x1845E0600", Slot = "18")]
			public void KFPKFODPJHB(T DOHIJKMCFFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x45E0640", Offset = "0x45DF240", VA = "0x1845E0640", Slot = "19")]
			public GHLCICDFCDN PIKDJHGOOLL(T AOEMDAGAALP)
			{
				return default(GHLCICDFCDN);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x45E0620", Offset = "0x45DF220", VA = "0x1845E0620", Slot = "20")]
			public bool ODGFMMBKPPD(T AOEMDAGAALP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x45E05E0", Offset = "0x45DF1E0", VA = "0x1845E05E0", Slot = "21")]
			public void IBHPBBBBBFK(T AOEMDAGAALP, JJPHDIFHPPP HKMOPALDHCK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class IKAEIDHLOKG : IDisposable, NLGLCLPIJIK
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum GDLCLIFJHFL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JHDDMAECFOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public LKFMGNANIOI GLBNKDGCEAC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public JJPHDIFHPPP DLCKPNJFFBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action NHCCNGEJKMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool ANELHHELCID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int KLCIKJBGNKJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
				public JHDDMAECFOH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class IJFKJICPJFL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public IKAEIDHLOKG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public JHDDMAECFOH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
				public IJFKJICPJFL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OMDJEGDJFCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int DNJHPJJMPFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int ABEGDLHOKEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool LNPINMMGACJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup BGEPLAGOGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] NPBEDCLMNIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] PBHMMEFJOLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly MBHAAPCLIBA OPBBALMJDDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<LKFMGNANIOI, int> LOAGHNJPAPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, JHDDMAECFOH> BLLODKCBNEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly GDLCLIFJHFL DBPPCBLAAHD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int KJONDIDGPFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int LBDHCEPALBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x7072A0", Offset = "0x705EA0", VA = "0x1807072A0", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6060830", Offset = "0x605F430", VA = "0x186060830")]
			internal IKAEIDHLOKG(int DNJHPJJMPFN, float[] OCBBPJHNKDK, GDLCLIFJHFL DBPPCBLAAHD = GDLCLIFJHFL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6060800", Offset = "0x605F400", VA = "0x186060800")]
			public void PJJMDJMHBGA(bool EDMGPHLGIGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x605F230", Offset = "0x605DE30", VA = "0x18605F230", Slot = "7")]
			public GHLCICDFCDN DLJFGDNDINF(float NODDCECEJBM)
			{
				return default(GHLCICDFCDN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x605E7D0", Offset = "0x605D3D0", VA = "0x18605E7D0", Slot = "8")]
			public void AABPNGPFBPJ(LKFMGNANIOI AOEMDAGAALP, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x605E860", Offset = "0x605D460", VA = "0x18605E860", Slot = "9")]
			public void AABPNGPFBPJ(LKFMGNANIOI AOEMDAGAALP, Transform MALFFFICOOA, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x605ECE0", Offset = "0x605D8E0", VA = "0x18605ECE0")]
			public void AJEBFFOGBBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x605F1B0", Offset = "0x605DDB0", VA = "0x18605F1B0", Slot = "10")]
			public void DJBPNBOHKAE(LKFMGNANIOI AOEMDAGAALP, [Optional] float? LFPCAKAPFIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6060590", Offset = "0x605F190", VA = "0x186060590")]
			private void PIGNCAGEIPJ(int KLEGICPDLIF, [Optional] float? LFPCAKAPFIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x605FE70", Offset = "0x605EA70", VA = "0x18605FE70", Slot = "11")]
			public void KFPKFODPJHB(LKFMGNANIOI DOHIJKMCFFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x60606F0", Offset = "0x605F2F0", VA = "0x1860606F0", Slot = "12")]
			public GHLCICDFCDN PIKDJHGOOLL(LKFMGNANIOI AOEMDAGAALP)
			{
				return default(GHLCICDFCDN);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60602A0", Offset = "0x605EEA0", VA = "0x1860602A0", Slot = "13")]
			public bool ODGFMMBKPPD(LKFMGNANIOI AOEMDAGAALP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x605F720", Offset = "0x605E320", VA = "0x18605F720", Slot = "14")]
			public void IBHPBBBBBFK(LKFMGNANIOI AOEMDAGAALP, JJPHDIFHPPP PHGFNMDCGOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x605F480", Offset = "0x605E080", VA = "0x18605F480", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x605FAB0", Offset = "0x605E6B0", VA = "0x18605FAB0")]
			private void JLDLKGGKKIK(JHDDMAECFOH FPEMBBHODOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x605F810", Offset = "0x605E410", VA = "0x18605F810")]
			private void IMCKIHBFFPD(JHDDMAECFOH FPEMBBHODOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6060520", Offset = "0x605F120", VA = "0x186060520")]
			private void PHBENLCFICP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x605F410", Offset = "0x605E010", VA = "0x18605F410")]
			private void DNIDCJPPFJO(float GECPIBGNKGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x605ECB0", Offset = "0x605D8B0", VA = "0x18605ECB0")]
			private void AFGIJPLINFG(JHDDMAECFOH FPEMBBHODOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x605F1A0", Offset = "0x605DDA0", VA = "0x18605F1A0")]
			private void DFHHEONFMGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x605FAA0", Offset = "0x605E6A0", VA = "0x18605FAA0")]
			private void IPFDGPKJOFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x605EE60", Offset = "0x605DA60", VA = "0x18605EE60")]
			private void CKDCNDGMCFP(CullingGroupEvent BGAMAPJGMAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x60603A0", Offset = "0x605EFA0", VA = "0x1860603A0")]
			private void PFBKANBPPJE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct MBNMMDLFAIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort CFJACFCHACB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type NMHDLMPDCKK;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float MPKNNAMMGEO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NKEOBEAIMEH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float EHPKMAJHEHE = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MHCCCFMCANC = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float GKGDFLCLJJM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float ADHHMCLGDOB = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float FKDBMONFELF = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<MBNMMDLFAIG, IKAEIDHLOKG> EGNMMEIKPDD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DPNPGGJIKLA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EFNNNBIHNKL;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IOJAEKNEPPN GGIKIJIKHNB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IOJAEKNEPPN JKBLMIMBGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IOJAEKNEPPN EHFKCDMGKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly IOJAEKNEPPN NEJIFKCIFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IOJAEKNEPPN AOAOFOOLBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GMBEEMHKFHH PKHJGOGFDBF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool EDMGPHLGIGP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IOJAEKNEPPN OEBODCIKOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IOJAEKNEPPN LEKJIIGCEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IOJAEKNEPPN PHPMGJOFOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6982D0", Offset = "0x696ED0", VA = "0x1806982D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DOBODOKJDLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1304480", Offset = "0x1303080", VA = "0x181304480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GLAPKGJCPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x733530", Offset = "0x732130", VA = "0x180733530", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x92F060", Offset = "0x92DC60", VA = "0x18092F060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x605D580", Offset = "0x605C180", VA = "0x18605D580", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1777350", Offset = "0x1775F50", VA = "0x181777350")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x605E000", Offset = "0x605CC00", VA = "0x18605E000")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x605DD00", Offset = "0x605C900", VA = "0x18605DD00")]
		private void HPFJELEHIIK(Scene IPMKKEICEKI, LoadSceneMode NGMKMMBHLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x605DF20", Offset = "0x605CB20", VA = "0x18605DF20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x605E250", Offset = "0x605CE50", VA = "0x18605E250")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x605D650", Offset = "0x605C250", VA = "0x18605D650")]
		private void BPMAEPOBENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x605E020", Offset = "0x605CC20", VA = "0x18605E020")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x605D7F0", Offset = "0x605C3F0", VA = "0x18605D7F0")]
		private void FGJCMHELIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x605DB10", Offset = "0x605C710", VA = "0x18605DB10")]
		public NLGLCLPIJIK GetOrCreateCullingGroup(Type MJFHPHNOCCA, int LDFDFPONNFM, ushort NNFCDFMNILA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x254DE30", Offset = "0x254CA30", VA = "0x18254DE30")]
		public global::EFHGMNLOMOD<T> GetOrCreateCullingGroup<T>(int LDFDFPONNFM, ushort NNFCDFMNILA = 0) where T : class, LKFMGNANIOI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x605DD80", Offset = "0x605C980", VA = "0x18605DD80")]
		private NLGLCLPIJIK NHADBEDEBNG(Type MJFHPHNOCCA, int LDFDFPONNFM, float[] OCBBPJHNKDK, ushort NNFCDFMNILA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x254DEE0", Offset = "0x254CAE0", VA = "0x18254DEE0")]
		private global::EFHGMNLOMOD<T> NHADBEDEBNG<T>(int LDFDFPONNFM, float[] OCBBPJHNKDK, ushort NNFCDFMNILA = 0) where T : class, LKFMGNANIOI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x605D970", Offset = "0x605C570", VA = "0x18605D970")]
		public static GHLCICDFCDN FindClosestDefaultUpdateLod(float INOBKCHGMCA)
		{
			return default(GHLCICDFCDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x605DD70", Offset = "0x605C970", VA = "0x18605DD70")]
		public static GHLCICDFCDN MinUpdateLod(GHLCICDFCDN KIKHMNIEDGC, GHLCICDFCDN KMBPECKAOKC)
		{
			return default(GHLCICDFCDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x605DD60", Offset = "0x605C960", VA = "0x18605DD60")]
		public static GHLCICDFCDN MaxUpdateLod(GHLCICDFCDN KIKHMNIEDGC, GHLCICDFCDN KMBPECKAOKC)
		{
			return default(GHLCICDFCDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x605E680", Offset = "0x605D280", VA = "0x18605E680")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MBHAAPCLIBA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FDALCINPCMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera FJNIEFKCCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IOJAEKNEPPN NMDOMCNIIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MLMAODHOKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IOJAEKNEPPN KOBCHPKKLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform PODBCOFELKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NLGLCLPIJIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int KJONDIDGPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int LBDHCEPALBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GHLCICDFCDN DLJFGDNDINF(float NODDCECEJBM);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AABPNGPFBPJ(LKFMGNANIOI AOEMDAGAALP, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AABPNGPFBPJ(LKFMGNANIOI AOEMDAGAALP, Transform MALFFFICOOA, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJBPNBOHKAE(LKFMGNANIOI AOEMDAGAALP, [Optional] float? LFPCAKAPFIG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KFPKFODPJHB(LKFMGNANIOI DOHIJKMCFFF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GHLCICDFCDN PIKDJHGOOLL(LKFMGNANIOI AOEMDAGAALP);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ODGFMMBKPPD(LKFMGNANIOI AOEMDAGAALP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IBHPBBBBBFK(LKFMGNANIOI AOEMDAGAALP, JJPHDIFHPPP HKMOPALDHCK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EFHGMNLOMOD<T> : NLGLCLPIJIK where T : class, LKFMGNANIOI
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABPNGPFBPJ(T AOEMDAGAALP, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AABPNGPFBPJ(T AOEMDAGAALP, Transform MALFFFICOOA, float LFPCAKAPFIG, JJPHDIFHPPP MOIFJIGKIDH = JJPHDIFHPPP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJBPNBOHKAE(T AOEMDAGAALP, [Optional] float? LFPCAKAPFIG);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFPKFODPJHB(T DOHIJKMCFFF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHLCICDFCDN PIKDJHGOOLL(T AOEMDAGAALP);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ODGFMMBKPPD(T AOEMDAGAALP);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IBHPBBBBBFK(T AOEMDAGAALP, JJPHDIFHPPP HKMOPALDHCK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LKFMGNANIOI
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform IGPPDIMEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GHLCICDFCDN OBPADJGJDJJ, GHLCICDFCDN COGJLEKBBLK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JNHCKFCDHIM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum JJPHDIFHPPP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GHLCICDFCDN
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JMJEIACJJCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GHLCICDFCDN OMNMFNNFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private GHLCICDFCDN CCAKNLFDCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, GHLCICDFCDN> IEEEHMFHDLP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool APKBPPNGJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60613E0", Offset = "0x605FFE0", VA = "0x1860613E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GHLCICDFCDN MOCCOFGEJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060")]
		get
		{
			return default(GHLCICDFCDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GHLCICDFCDN MLKGHCEOOON
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7072A0", Offset = "0x705EA0", VA = "0x1807072A0")]
		get
		{
			return default(GHLCICDFCDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6061430", Offset = "0x6060030", VA = "0x186061430")]
	public bool KMNMLABECCC(object GIHOLCNOBIB, GHLCICDFCDN NENFOEKGNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6061220", Offset = "0x605FE20", VA = "0x186061220")]
	public bool EIDHPLNDEKK(object GIHOLCNOBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6061280", Offset = "0x605FE80", VA = "0x186061280")]
	private bool HMKDIFALGEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60614A0", Offset = "0x60600A0", VA = "0x1860614A0")]
	public JMJEIACJJCN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6060BF0", Offset = "0x605F7F0", VA = "0x186060BF0")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6060D00", Offset = "0x605F900", VA = "0x186060D00")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
