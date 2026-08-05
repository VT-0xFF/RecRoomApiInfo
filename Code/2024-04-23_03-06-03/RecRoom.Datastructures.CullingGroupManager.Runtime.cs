using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, FGEMNFOIAEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class PPGICJLDJHF<T> : KPFEBOIJODE, ICFHKFCPKDI<T>, NKHDPGBKMGF where T : class, DCPODHBBNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x429F4C0", Offset = "0x429E4C0", VA = "0x18429F4C0")]
			internal PPGICJLDJHF(int LOAEMHONPJA, float[] MBEDMDEODKH, AEFCKNFDAMB EJFAOILBDHE = AEFCKNFDAMB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x429F440", Offset = "0x429E440", VA = "0x18429F440", Slot = "10")]
			public void BGLDHBEBEIE(T KDEEPMDJGFD, float LIIEEBDEIFN, HLEHOHIHLOC LCAINKPOPLP = HLEHOHIHLOC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x429F470", Offset = "0x429E470", VA = "0x18429F470", Slot = "11")]
			public void BGLDHBEBEIE(T KDEEPMDJGFD, Transform EAOLBKAJBKE, float LIIEEBDEIFN, HLEHOHIHLOC LCAINKPOPLP = HLEHOHIHLOC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x429F4A0", Offset = "0x429E4A0", VA = "0x18429F4A0", Slot = "12")]
			public void NCLCGNJGAKA(T JDLIAOJAKKF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class KPFEBOIJODE : IDisposable, NKHDPGBKMGF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum AEFCKNFDAMB : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BGHKMOJHOGF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public DCPODHBBNDM PNEGOLACHLC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public HLEHOHIHLOC JLHGGKLCGCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action BJMECOICMPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool LIJEAJPFLJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int CBOGBOOIKCP;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
				public BGHKMOJHOGF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BMNDANDADAA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public KPFEBOIJODE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public BGHKMOJHOGF trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
				public BMNDANDADAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x627DC90", Offset = "0x627CC90", VA = "0x18627DC90")]
				internal void DCKCHEOGFNC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LADALILPNOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int LOAEMHONPJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int HAMFJGMCCNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool OBBFCMJHMOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup CEDPKJDFCKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] GICCAMGHFHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] ACPAODHOFMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly GEIHGKOJGIM AKJKFGAFELN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<DCPODHBBNDM, int> JMCELAODFHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, BGHKMOJHOGF> BEEELMKNJMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly AEFCKNFDAMB EJFAOILBDHE;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool BEMAJCJCBAP
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xE02640", Offset = "0xE01640", VA = "0x180E02640")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4098750", Offset = "0x4097750", VA = "0x184098750", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6280C30", Offset = "0x627FC30", VA = "0x186280C30")]
			internal KPFEBOIJODE(int LOAEMHONPJA, float[] MBEDMDEODKH, AEFCKNFDAMB EJFAOILBDHE = AEFCKNFDAMB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6280070", Offset = "0x627F070", VA = "0x186280070")]
			public void KDCKCGGAMJO(bool LBDMBLELILN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x627F4E0", Offset = "0x627E4E0", VA = "0x18627F4E0", Slot = "6")]
			public void BGLDHBEBEIE(DCPODHBBNDM KDEEPMDJGFD, float LIIEEBDEIFN, HLEHOHIHLOC LCAINKPOPLP = HLEHOHIHLOC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x627F570", Offset = "0x627E570", VA = "0x18627F570", Slot = "9")]
			public void BGLDHBEBEIE(DCPODHBBNDM KDEEPMDJGFD, Transform EAOLBKAJBKE, float LIIEEBDEIFN, HLEHOHIHLOC LCAINKPOPLP = HLEHOHIHLOC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62800A0", Offset = "0x627F0A0", VA = "0x1862800A0")]
			public void KJBBEEAEIBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x627F970", Offset = "0x627E970", VA = "0x18627F970")]
			private void DOKHJHFMPFP(int GPEHCABDGEJ, [Optional] float? LIIEEBDEIFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6280840", Offset = "0x627F840", VA = "0x186280840", Slot = "7")]
			public void NCLCGNJGAKA(DCPODHBBNDM JDLIAOJAKKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x627F3F0", Offset = "0x627E3F0", VA = "0x18627F3F0", Slot = "8")]
			public void BFPDLHIPNBF(DCPODHBBNDM KDEEPMDJGFD, HLEHOHIHLOC KKDPDHGIHAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x627FAA0", Offset = "0x627EAA0", VA = "0x18627FAA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x627F060", Offset = "0x627E060", VA = "0x18627F060")]
			private void AMODAMIBJFO(BGHKMOJHOGF CCPOHNEBOCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x627FDD0", Offset = "0x627EDD0", VA = "0x18627FDD0")]
			private void IHDDMMKPIID(BGHKMOJHOGF CCPOHNEBOCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x627FD60", Offset = "0x627ED60", VA = "0x18627FD60")]
			private void EBAJGIKELBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62807E0", Offset = "0x627F7E0", VA = "0x1862807E0")]
			private void MHCCMDDCOJI(float EFPELNMKHCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x62801F0", Offset = "0x627F1F0", VA = "0x1862801F0")]
			private void LCBFBNMJOAI(BGHKMOJHOGF CCPOHNEBOCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x627FDC0", Offset = "0x627EDC0", VA = "0x18627FDC0")]
			private void GFEOMKINGJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6280660", Offset = "0x627F660", VA = "0x186280660")]
			private void MELMNAMMDFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6280330", Offset = "0x627F330", VA = "0x186280330")]
			private void LNLCAFMDGKO(CullingGroupEvent KINDMLHDLOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6280670", Offset = "0x627F670", VA = "0x186280670")]
			private void MGBNCBLLMNJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct MHOMDICOBGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort KPEKLCPKPJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type DGOGDLEDBOA;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float MKLNCFALJIN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ICFECGAPPBI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float AFOKDOJDEOM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AKMCPMKJPHM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float EEPOCKDNPGB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FJNPMNNEJBD = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GEHLAHDCPAK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<MHOMDICOBGJ, KPFEBOIJODE> OKCGAIIDCAO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable EGGNGNNFPOD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable JPFCGPBLHBG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static ONDMBBPPJJI AJCADKHDIPP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static ONDMBBPPJJI GKEONEIPAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ONDMBBPPJJI IONKOEIDDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly ONDMBBPPJJI PMBOMNPNCLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ONDMBBPPJJI IPBHJDOJBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EOCGEKKEBMP NOEINFPIKCC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LBDMBLELILN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ONDMBBPPJJI JDGONHOONPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ONDMBBPPJJI CJBGCCDNAMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ONDMBBPPJJI ILNLAHLAAFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EPBMFDOOIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD77110", Offset = "0xD76110", VA = "0x180D77110", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LDAFMNFFDBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88AC60", Offset = "0x889C60", VA = "0x18088AC60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x96ECD0", Offset = "0x96DCD0", VA = "0x18096ECD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x627DDE0", Offset = "0x627CDE0", VA = "0x18627DDE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x627E6F0", Offset = "0x627D6F0", VA = "0x18627E6F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x627E6D0", Offset = "0x627D6D0", VA = "0x18627E6D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x627DEA0", Offset = "0x627CEA0", VA = "0x18627DEA0")]
		private void FKJMGEMEGAK(Scene HOOFDCHFFMO, LoadSceneMode FGOIHKAPIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x627E5F0", Offset = "0x627D5F0", VA = "0x18627E5F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x627EAF0", Offset = "0x627DAF0", VA = "0x18627EAF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x627E710", Offset = "0x627D710", VA = "0x18627E710")]
		private void PDEDOHMJNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x627E8B0", Offset = "0x627D8B0", VA = "0x18627E8B0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x627E280", Offset = "0x627D280", VA = "0x18627E280")]
		private void HOKMDLJMHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x627E060", Offset = "0x627D060", VA = "0x18627E060")]
		public NKHDPGBKMGF GetOrCreateCullingGroup(Type MJONGLDINPI, int DBOMCPDJHPG, ushort NELPCLEGMBH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x273DBC0", Offset = "0x273CBC0", VA = "0x18273DBC0")]
		public ICFHKFCPKDI<T> GetOrCreateCullingGroup<T>(int DBOMCPDJHPG, ushort NELPCLEGMBH = 0) where T : class, DCPODHBBNDM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x627E400", Offset = "0x627D400", VA = "0x18627E400")]
		private NKHDPGBKMGF IPGNOLMCNJL(Type MJONGLDINPI, int DBOMCPDJHPG, float[] MBEDMDEODKH, ushort NELPCLEGMBH = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x273DC60", Offset = "0x273CC60", VA = "0x18273DC60")]
		private ICFHKFCPKDI<T> IPGNOLMCNJL<T>(int DBOMCPDJHPG, float[] MBEDMDEODKH, ushort NELPCLEGMBH = 0) where T : class, DCPODHBBNDM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x627DF00", Offset = "0x627CF00", VA = "0x18627DF00")]
		public static DCFIIAFEJOH FindClosestDefaultUpdateLod(float BJJODNOANKI)
		{
			return default(DCFIIAFEJOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7EDF90", Offset = "0x7ECF90", VA = "0x1807EDF90")]
		public static DCFIIAFEJOH MinUpdateLod(DCFIIAFEJOH LEKOGNNOAEN, DCFIIAFEJOH HOMKEGEMOJL)
		{
			return default(DCFIIAFEJOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x627E5E0", Offset = "0x627D5E0", VA = "0x18627E5E0")]
		public static DCFIIAFEJOH MaxUpdateLod(DCFIIAFEJOH LEKOGNNOAEN, DCFIIAFEJOH HOMKEGEMOJL)
		{
			return default(DCFIIAFEJOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x627EF60", Offset = "0x627DF60", VA = "0x18627EF60")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GEIHGKOJGIM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PGNLHPEKMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera JJANEFPPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ONDMBBPPJJI ILLLAEHFNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BIFOLDBGFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ONDMBBPPJJI KHBAHGGCEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform BBNMKACJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NKHDPGBKMGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BEMAJCJCBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGLDHBEBEIE(DCPODHBBNDM KDEEPMDJGFD, float LIIEEBDEIFN, HLEHOHIHLOC LCAINKPOPLP = HLEHOHIHLOC.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCLCGNJGAKA(DCPODHBBNDM JDLIAOJAKKF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFPDLHIPNBF(DCPODHBBNDM KDEEPMDJGFD, HLEHOHIHLOC NDFFJNGBCDH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ICFHKFCPKDI<T> : NKHDPGBKMGF where T : class, DCPODHBBNDM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGLDHBEBEIE(T KDEEPMDJGFD, float LIIEEBDEIFN, HLEHOHIHLOC LCAINKPOPLP = HLEHOHIHLOC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGLDHBEBEIE(T KDEEPMDJGFD, Transform EAOLBKAJBKE, float LIIEEBDEIFN, HLEHOHIHLOC LCAINKPOPLP = HLEHOHIHLOC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCLCGNJGAKA(T JDLIAOJAKKF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DCPODHBBNDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform JKAOMNONHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DCFIIAFEJOH DLKCHFLMBPI, DCFIIAFEJOH MDINEFDHNJH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool DMOGIMEKMMF);
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
