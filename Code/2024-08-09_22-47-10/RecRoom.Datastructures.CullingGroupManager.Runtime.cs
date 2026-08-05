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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OEKPGCKAHJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class GNNPFKBKFCP<T> : JGLLMNNKOAC, MMIMALOPFNF<T>, LLLKKOLPLLJ where T : class, KPLOEMKEKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3D285B0", Offset = "0x3D279B0", VA = "0x183D285B0")]
			internal GNNPFKBKFCP(int CJGDPBAFEPG, float[] CLCAJNCMMDA, LFELBJNJIMF IFHLEAGMLPG = LFELBJNJIMF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3D28530", Offset = "0x3D27930", VA = "0x183D28530", Slot = "10")]
			public void HINMMBAADBG(T LALIGKIKEBM, float JHKMHGJCHGK, BCGHGEBOGGJ ACONONMKMKN = BCGHGEBOGGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3D28560", Offset = "0x3D27960", VA = "0x183D28560", Slot = "11")]
			public void HINMMBAADBG(T LALIGKIKEBM, Transform CBBHEEJGDJF, float JHKMHGJCHGK, BCGHGEBOGGJ ACONONMKMKN = BCGHGEBOGGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D28590", Offset = "0x3D27990", VA = "0x183D28590", Slot = "12")]
			public void LHAIFCNDDDC(T FFKDNCEJODA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class JGLLMNNKOAC : IDisposable, LLLKKOLPLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum LFELBJNJIMF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class FAHFPKEJJHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public KPLOEMKEKII EAGKEKNFHLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public BCGHGEBOGGJ JGGKKGNNOAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action LCHBLALBCCH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool OLHJFBONEHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int KCOEJCJFNCN;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
				public FAHFPKEJJHH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class CJJDKCGEOOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public JGLLMNNKOAC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public FAHFPKEJJHH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
				public CJJDKCGEOOI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x68C2380", Offset = "0x68C1780", VA = "0x1868C2380")]
				internal void ACKFFNAEOIC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int DBLDKPFNJLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int CJGDPBAFEPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GELNCKGOOGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool OFBHCPGMGBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup JMHIOJNHGCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OPDFLCIHFJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] HDDOPEFPPFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly EKJOKEFEKGF PKEMJFONHGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<KPLOEMKEKII, int> IPFFOGBFEBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, FAHFPKEJJHH> KDLOENNAMFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly LFELBJNJIMF IFHLEAGMLPG;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool OFIKIDPBLAK
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x95D490", Offset = "0x95C890", VA = "0x18095D490")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x44BFAD0", Offset = "0x44BEED0", VA = "0x1844BFAD0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x68C52F0", Offset = "0x68C46F0", VA = "0x1868C52F0")]
			internal JGLLMNNKOAC(int CJGDPBAFEPG, float[] CLCAJNCMMDA, LFELBJNJIMF IFHLEAGMLPG = LFELBJNJIMF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x68C3B40", Offset = "0x68C2F40", VA = "0x1868C3B40")]
			public void DMONNECNGCN(bool BOICOKDGJLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x68C4760", Offset = "0x68C3B60", VA = "0x1868C4760", Slot = "6")]
			public void HINMMBAADBG(KPLOEMKEKII LALIGKIKEBM, float JHKMHGJCHGK, BCGHGEBOGGJ ACONONMKMKN = BCGHGEBOGGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x68C4370", Offset = "0x68C3770", VA = "0x1868C4370", Slot = "9")]
			public void HINMMBAADBG(KPLOEMKEKII LALIGKIKEBM, Transform CBBHEEJGDJF, float JHKMHGJCHGK, BCGHGEBOGGJ ACONONMKMKN = BCGHGEBOGGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68C4E60", Offset = "0x68C4260", VA = "0x1868C4E60")]
			public void LJECMKKCKOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68C4240", Offset = "0x68C3640", VA = "0x1868C4240")]
			private void HCJBFAFHDJN(int AGAGKNBDCIG, [Optional] float? JHKMHGJCHGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x68C4A20", Offset = "0x68C3E20", VA = "0x1868C4A20", Slot = "7")]
			public void LHAIFCNDDDC(KPLOEMKEKII FFKDNCEJODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68C47F0", Offset = "0x68C3BF0", VA = "0x1868C47F0", Slot = "8")]
			public void KANMMHBPIHF(KPLOEMKEKII LALIGKIKEBM, BCGHGEBOGGJ MOMKPEIBAAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68C3B70", Offset = "0x68C2F70", VA = "0x1868C3B70", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68C3750", Offset = "0x68C2B50", VA = "0x1868C3750")]
			private void AJPELIBIDCN(FAHFPKEJJHH GABPFBOCNDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x68C3FA0", Offset = "0x68C33A0", VA = "0x1868C3FA0")]
			private void FFFKCNMCKLK(FAHFPKEJJHH GABPFBOCNDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68C3AE0", Offset = "0x68C2EE0", VA = "0x1868C3AE0")]
			private void BNJBBDBIBBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68C4E00", Offset = "0x68C4200", VA = "0x1868C4E00")]
			private void LHANFOHFEON(float OBMBAKPLLKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x68C48E0", Offset = "0x68C3CE0", VA = "0x1868C48E0")]
			private void KJBCEDOCGNF(FAHFPKEJJHH GABPFBOCNDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68C52E0", Offset = "0x68C46E0", VA = "0x1868C52E0")]
			private void PAMIBGBDANG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x68C4FB0", Offset = "0x68C43B0", VA = "0x1868C4FB0")]
			private void NBDJGENAGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68C4FC0", Offset = "0x68C43C0", VA = "0x1868C4FC0")]
			private void OONPDODHHJF(CullingGroupEvent POPFOIJPGNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x68C3E30", Offset = "0x68C3230", VA = "0x1868C3E30")]
			private void ENFIDNCOOKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct GNKLHIFFMNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort LENLFEHOLCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type DBBPOBEAFHO;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PHNDIHNIHNN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MJMHNNBIJHK = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HPFIEODHHEA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HLNOEJAMPHG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HNAPMMIHEII = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GNIHNAJPHPG = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JALFDLNCPDB = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GNKLHIFFMNJ, JGLLMNNKOAC> OPFKLPCCPHF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IHAENKEFLMD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FMNPNDCDLIH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDDBOOGKPOH PLCBDCGHCFI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDDBOOGKPOH DHIBMHEDHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IDDBOOGKPOH NCCALGCJIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly IDDBOOGKPOH CNKMDCDJCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDDBOOGKPOH JFMGLOOPOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DAODDLKDJDG MNFHBKBGMBJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool BOICOKDGJLC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IDDBOOGKPOH HDMIPMEDMNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IDDBOOGKPOH CIDFBJOIFCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IDDBOOGKPOH CFFOOKPLAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NNPBFLGPGNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xFBF9A0", Offset = "0xFBEDA0", VA = "0x180FBF9A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DIKMIIPIGLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA5F680", Offset = "0xA5EA80", VA = "0x180A5F680", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA5F990", Offset = "0xA5ED90", VA = "0x180A5F990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68C2650", Offset = "0x68C1A50", VA = "0x1868C2650", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68C2F80", Offset = "0x68C2380", VA = "0x1868C2F80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68C2F60", Offset = "0x68C2360", VA = "0x1868C2F60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68C2A90", Offset = "0x68C1E90", VA = "0x1868C2A90")]
		private void EIMDILNFKHM(Scene GPFPAOCGNND, LoadSceneMode KBNNEODEGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68C2E80", Offset = "0x68C2280", VA = "0x1868C2E80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68C31E0", Offset = "0x68C25E0", VA = "0x1868C31E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68C2710", Offset = "0x68C1B10", VA = "0x1868C2710")]
		private void BEJGLLOGFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68C2FA0", Offset = "0x68C23A0", VA = "0x1868C2FA0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68C24D0", Offset = "0x68C18D0", VA = "0x1868C24D0")]
		private void AHDFIFLOOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68C2C50", Offset = "0x68C2050", VA = "0x1868C2C50")]
		public LLLKKOLPLLJ GetOrCreateCullingGroup(Type EBKNNBHKGPG, int KGBLKNOBPFB, ushort HMMEEPFJMIL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2991720", Offset = "0x2990B20", VA = "0x182991720")]
		public MMIMALOPFNF<T> GetOrCreateCullingGroup<T>(int KGBLKNOBPFB, ushort HMMEEPFJMIL = 0) where T : class, KPLOEMKEKII
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68C28B0", Offset = "0x68C1CB0", VA = "0x1868C28B0")]
		private LLLKKOLPLLJ CDEGNFCMDHJ(Type EBKNNBHKGPG, int KGBLKNOBPFB, float[] CLCAJNCMMDA, ushort HMMEEPFJMIL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2991490", Offset = "0x2990890", VA = "0x182991490")]
		private MMIMALOPFNF<T> CDEGNFCMDHJ<T>(int KGBLKNOBPFB, float[] CLCAJNCMMDA, ushort HMMEEPFJMIL = 0) where T : class, KPLOEMKEKII
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68C2AF0", Offset = "0x68C1EF0", VA = "0x1868C2AF0")]
		public static DHNIPGENADJ FindClosestDefaultUpdateLod(float PDKIEIAHPGD)
		{
			return default(DHNIPGENADJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8790F0", Offset = "0x8784F0", VA = "0x1808790F0")]
		public static DHNIPGENADJ MinUpdateLod(DHNIPGENADJ ODFNJHLOPDC, DHNIPGENADJ GIGDFEFOOHL)
		{
			return default(DHNIPGENADJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68C2E70", Offset = "0x68C2270", VA = "0x1868C2E70")]
		public static DHNIPGENADJ MaxUpdateLod(DHNIPGENADJ ODFNJHLOPDC, DHNIPGENADJ GIGDFEFOOHL)
		{
			return default(DHNIPGENADJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68C3650", Offset = "0x68C2A50", VA = "0x1868C3650")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EKJOKEFEKGF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CMCPFEIACOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera LBBDFCMCOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IDDBOOGKPOH COAPMFCGPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LCOKNGNJPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IDDBOOGKPOH JGBGEIPKOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform MJJMLMJFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LLLKKOLPLLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool OFIKIDPBLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HINMMBAADBG(KPLOEMKEKII LALIGKIKEBM, float JHKMHGJCHGK, BCGHGEBOGGJ ACONONMKMKN = BCGHGEBOGGJ.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHAIFCNDDDC(KPLOEMKEKII FFKDNCEJODA);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KANMMHBPIHF(KPLOEMKEKII LALIGKIKEBM, BCGHGEBOGGJ MFJIBOKJMFL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MMIMALOPFNF<T> : LLLKKOLPLLJ where T : class, KPLOEMKEKII
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HINMMBAADBG(T LALIGKIKEBM, float JHKMHGJCHGK, BCGHGEBOGGJ ACONONMKMKN = BCGHGEBOGGJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HINMMBAADBG(T LALIGKIKEBM, Transform CBBHEEJGDJF, float JHKMHGJCHGK, BCGHGEBOGGJ ACONONMKMKN = BCGHGEBOGGJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHAIFCNDDDC(T FFKDNCEJODA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KPLOEMKEKII
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform HDODENDDMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DHNIPGENADJ BBABLGEFKBA, DHNIPGENADJ FEKCAFDBIHM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NBKOGIEJDBJ);
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
