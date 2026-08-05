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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, KMEJPHPLGLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class JPBNKJNIMIL<T> : MLMLHLKMMGN, global::HMPGOAAADDE<T>, EIJNDDCMLGM where T : class, KPFJBIMGOOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x37568D0", Offset = "0x37552D0", VA = "0x1837568D0")]
			internal JPBNKJNIMIL(int BMJCGABKLDA, float[] APNDLKGMNHO, KKOPMGNBOKN FILNLNDFNKC = KKOPMGNBOKN.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3756830", Offset = "0x3755230", VA = "0x183756830", Slot = "15")]
			public void IFPOOIAJHAI(T OMHIFHKMIMJ, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3756860", Offset = "0x3755260", VA = "0x183756860", Slot = "16")]
			public void IFPOOIAJHAI(T OMHIFHKMIMJ, Transform AHIIIGNBKLC, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3756890", Offset = "0x3755290", VA = "0x183756890", Slot = "17")]
			public void LAOLLLDEKLP(T OMHIFHKMIMJ, [Optional] float? KCGKLFGFACE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3756810", Offset = "0x3755210", VA = "0x183756810", Slot = "18")]
			public void HEOHJOBENDL(T PGKPMAELFMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x37568B0", Offset = "0x37552B0", VA = "0x1837568B0", Slot = "19")]
			public IJJPEDCHMLC MMMOMAIKHGL(T OMHIFHKMIMJ)
			{
				return default(IJJPEDCHMLC);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x37567F0", Offset = "0x37551F0", VA = "0x1837567F0", Slot = "20")]
			public bool ELEOMEKFNDG(T OMHIFHKMIMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x37567D0", Offset = "0x37551D0", VA = "0x1837567D0", Slot = "21")]
			public void CNHJBJOLBFD(T OMHIFHKMIMJ, EFJPJGLGGEC ICKKJNLFBAG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MLMLHLKMMGN : IDisposable, EIJNDDCMLGM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum KKOPMGNBOKN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class MPAFDNOFEKB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public KPFJBIMGOOA HMIBJCBNLDB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EFJPJGLGGEC FJKKECHDABH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action DPLBIMACKBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool HKBGHCHPKLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int EOGKCECFNOA;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
				public MPAFDNOFEKB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class NKADOAFFMAH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public MLMLHLKMMGN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public MPAFDNOFEKB trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
				public NKADOAFFMAH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int DBJLKBKMDBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int BMJCGABKLDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BAOPFEOAANG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool FNOJIFMFPJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup MMHMBGCGCNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] ENNCIMPBNJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] HBGIKHAIEBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly NBMEPCIMAOG FAMLIKPHPAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<KPFJBIMGOOA, int> KBAGEFCECDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, MPAFDNOFEKB> BDDPBHKJMIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly KKOPMGNBOKN FILNLNDFNKC;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int OMPAIHNDLPF
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int LHKCIIMHDBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x80B660", Offset = "0x80A060", VA = "0x18080B660", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1DFFD10", Offset = "0x1DFE710", VA = "0x181DFFD10")]
			internal MLMLHLKMMGN(int BMJCGABKLDA, float[] APNDLKGMNHO, KKOPMGNBOKN FILNLNDFNKC = KKOPMGNBOKN.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE480", Offset = "0x1DFCE80", VA = "0x181DFE480")]
			public void BKOLODHPHFP(bool LGEKOMMHEKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF8C0", Offset = "0x1DFE2C0", VA = "0x181DFF8C0", Slot = "7")]
			public IJJPEDCHMLC MGJNKCINCNF(float FFOCLOKDMIA)
			{
				return default(IJJPEDCHMLC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF1B0", Offset = "0x1DFDBB0", VA = "0x181DFF1B0", Slot = "8")]
			public void IFPOOIAJHAI(KPFJBIMGOOA OMHIFHKMIMJ, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF240", Offset = "0x1DFDC40", VA = "0x181DFF240", Slot = "9")]
			public void IFPOOIAJHAI(KPFJBIMGOOA OMHIFHKMIMJ, Transform AHIIIGNBKLC, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1DFDF40", Offset = "0x1DFC940", VA = "0x181DFDF40")]
			public void BIENLCPDDJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF840", Offset = "0x1DFE240", VA = "0x181DFF840", Slot = "10")]
			public void LAOLLLDEKLP(KPFJBIMGOOA OMHIFHKMIMJ, [Optional] float? KCGKLFGFACE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1DFFBB0", Offset = "0x1DFE5B0", VA = "0x181DFFBB0")]
			private void ODPBEOFJOEL(int ALJOMNDNEBM, [Optional] float? KCGKLFGFACE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1DFED10", Offset = "0x1DFD710", VA = "0x181DFED10", Slot = "11")]
			public void HEOHJOBENDL(KPFJBIMGOOA PGKPMAELFMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1DFFAA0", Offset = "0x1DFE4A0", VA = "0x181DFFAA0", Slot = "12")]
			public IJJPEDCHMLC MMMOMAIKHGL(KPFJBIMGOOA OMHIFHKMIMJ)
			{
				return default(IJJPEDCHMLC);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1DFEC00", Offset = "0x1DFD600", VA = "0x181DFEC00", Slot = "13")]
			public bool ELEOMEKFNDG(KPFJBIMGOOA OMHIFHKMIMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE7F0", Offset = "0x1DFD1F0", VA = "0x181DFE7F0", Slot = "14")]
			public void CNHJBJOLBFD(KPFJBIMGOOA OMHIFHKMIMJ, EFJPJGLGGEC CNOIBABOBJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE960", Offset = "0x1DFD360", VA = "0x181DFE960", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE0C0", Offset = "0x1DFCAC0", VA = "0x181DFE0C0")]
			private void BJGOFFCMGLC(MPAFDNOFEKB INGIFKICPEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1DFDCB0", Offset = "0x1DFC6B0", VA = "0x181DFDCB0")]
			private void BBOBHGKKCPC(MPAFDNOFEKB INGIFKICPEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE8E0", Offset = "0x1DFD2E0", VA = "0x181DFE8E0")]
			private void DHEPEPKBKJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF140", Offset = "0x1DFDB40", VA = "0x181DFF140")]
			private void IEOAMCGFDFN(float KLAJFDPNJJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF690", Offset = "0x1DFE090", VA = "0x181DFF690")]
			private void IKDIABNDFCH(MPAFDNOFEKB INGIFKICPEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE950", Offset = "0x1DFD350", VA = "0x181DFE950")]
			private void DPKAGMICHLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1DFED00", Offset = "0x1DFD700", VA = "0x181DFED00")]
			private void HEJBEGJEGGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE4B0", Offset = "0x1DFCEB0", VA = "0x181DFE4B0")]
			private void CEGKJNNDCFK(CullingGroupEvent MOLOPDHOEEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF6C0", Offset = "0x1DFE0C0", VA = "0x181DFF6C0")]
			private void JAPPKMAAIEG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JMOMDHFHLGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort PKIBOLEFPFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type DHCPMDJMBDN;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float KCDIIOBIBMD = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DOGJNOOKIOF = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LDIIPBNEHLP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HLPFNKGOACL = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float DAKAIMGPDFE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float DLHMJDDECCA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JBHOPOOHOMB = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JMOMDHFHLGF, MLMLHLKMMGN> LJEBLCMNBBK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CMINKIICGNG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable BLIAMELNPEE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static JAENCPCNABI GANKIDJKPHL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static JAENCPCNABI FEEEGMBIEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly JAENCPCNABI AJCEIFIGLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly JAENCPCNABI IOBMACMCNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JAENCPCNABI EJCHHLCBCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LLDNPBCCADD BLKFJFDAFCB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LGEKOMMHEKE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JAENCPCNABI LLPNKHFDMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JAENCPCNABI HBPPNFPCFOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JAENCPCNABI JLKKIAKHMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MDEHKJLEMHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xDEEB20", Offset = "0xDED520", VA = "0x180DEEB20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MOCCFKODCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x83BFA0", Offset = "0x83A9A0", VA = "0x18083BFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DFC960", Offset = "0x1DFB360", VA = "0x181DFC960", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DFD080", Offset = "0x1DFBA80", VA = "0x181DFD080")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DFD060", Offset = "0x1DFBA60", VA = "0x181DFD060")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DFC900", Offset = "0x1DFB300", VA = "0x181DFC900")]
		private void AONKLFDFMBP(Scene OPCKNOAJELE, LoadSceneMode DPFIFMCONAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCF80", Offset = "0x1DFB980", VA = "0x181DFCF80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1DFD470", Offset = "0x1DFBE70", VA = "0x181DFD470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1DFD0A0", Offset = "0x1DFBAA0", VA = "0x181DFD0A0")]
		private void PICLJFIAOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1DFD240", Offset = "0x1DFBC40", VA = "0x181DFD240")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1DFC780", Offset = "0x1DFB180", VA = "0x181DFC780")]
		private void AIINDHHAOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCBD0", Offset = "0x1DFB5D0", VA = "0x181DFCBD0")]
		public EIJNDDCMLGM GetOrCreateCullingGroup(Type BBLGGPJALPE, int PEEIJEIEINF, ushort ONGGHOLNODF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2924700", Offset = "0x2923100", VA = "0x182924700")]
		public global::HMPGOAAADDE<T> GetOrCreateCullingGroup<T>(int PEEIJEIEINF, ushort ONGGHOLNODF = 0) where T : class, KPFJBIMGOOA
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCDC0", Offset = "0x1DFB7C0", VA = "0x181DFCDC0")]
		private EIJNDDCMLGM LJPHINKBKDJ(Type BBLGGPJALPE, int PEEIJEIEINF, float[] APNDLKGMNHO, ushort ONGGHOLNODF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29247B0", Offset = "0x29231B0", VA = "0x1829247B0")]
		private global::HMPGOAAADDE<T> LJPHINKBKDJ<T>(int PEEIJEIEINF, float[] APNDLKGMNHO, ushort ONGGHOLNODF = 0) where T : class, KPFJBIMGOOA
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCA30", Offset = "0x1DFB430", VA = "0x181DFCA30")]
		public static IJJPEDCHMLC FindClosestDefaultUpdateLod(float PFMKLIAAHAF)
		{
			return default(IJJPEDCHMLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCF70", Offset = "0x1DFB970", VA = "0x181DFCF70")]
		public static IJJPEDCHMLC MinUpdateLod(IJJPEDCHMLC PPALJMDEPBJ, IJJPEDCHMLC HINFFGMPPHL)
		{
			return default(IJJPEDCHMLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCF60", Offset = "0x1DFB960", VA = "0x181DFCF60")]
		public static IJJPEDCHMLC MaxUpdateLod(IJJPEDCHMLC PPALJMDEPBJ, IJJPEDCHMLC HINFFGMPPHL)
		{
			return default(IJJPEDCHMLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1DFD8A0", Offset = "0x1DFC2A0", VA = "0x181DFD8A0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NBMEPCIMAOG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DINDLAFOBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera BJOLDCKLHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JAENCPCNABI FGNCLCECCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JFJAALPJHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JAENCPCNABI JAGKBNJBBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform MFBLKEJLIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EIJNDDCMLGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int OMPAIHNDLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int LHKCIIMHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJJPEDCHMLC MGJNKCINCNF(float FFOCLOKDMIA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IFPOOIAJHAI(KPFJBIMGOOA OMHIFHKMIMJ, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFPOOIAJHAI(KPFJBIMGOOA OMHIFHKMIMJ, Transform AHIIIGNBKLC, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAOLLLDEKLP(KPFJBIMGOOA OMHIFHKMIMJ, [Optional] float? KCGKLFGFACE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HEOHJOBENDL(KPFJBIMGOOA PGKPMAELFMF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IJJPEDCHMLC MMMOMAIKHGL(KPFJBIMGOOA OMHIFHKMIMJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ELEOMEKFNDG(KPFJBIMGOOA OMHIFHKMIMJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CNHJBJOLBFD(KPFJBIMGOOA OMHIFHKMIMJ, EFJPJGLGGEC ICKKJNLFBAG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HMPGOAAADDE<T> : EIJNDDCMLGM where T : class, KPFJBIMGOOA
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFPOOIAJHAI(T OMHIFHKMIMJ, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFPOOIAJHAI(T OMHIFHKMIMJ, Transform AHIIIGNBKLC, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAOLLLDEKLP(T OMHIFHKMIMJ, [Optional] float? KCGKLFGFACE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEOHJOBENDL(T PGKPMAELFMF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IJJPEDCHMLC MMMOMAIKHGL(T OMHIFHKMIMJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ELEOMEKFNDG(T OMHIFHKMIMJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNHJBJOLBFD(T OMHIFHKMIMJ, EFJPJGLGGEC ICKKJNLFBAG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KPFJBIMGOOA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform DBMMOFPNJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(IJJPEDCHMLC MFNDIHIAOHD, IJJPEDCHMLC BHIMKEHCCPG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool OIIJGABMEKG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum EFJPJGLGGEC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum IJJPEDCHMLC
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
public class MJBJMFELHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IJJPEDCHMLC IPPOHHHCAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IJJPEDCHMLC JJNBFMOBAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, IJJPEDCHMLC> MPNEMKCBLMJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool AODGJLFDBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1DFD9B0", Offset = "0x1DFC3B0", VA = "0x181DFD9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IJJPEDCHMLC DEECNCDAOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00")]
		get
		{
			return default(IJJPEDCHMLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IJJPEDCHMLC AFHBOOEIFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x80B660", Offset = "0x80A060", VA = "0x18080B660")]
		get
		{
			return default(IJJPEDCHMLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1DFDA00", Offset = "0x1DFC400", VA = "0x181DFDA00")]
	public bool FMHGDPNPEHP(object HMAOAMDKNDD, IJJPEDCHMLC MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1DFDA70", Offset = "0x1DFC470", VA = "0x181DFDA70")]
	public bool NHIFDNAHCNB(object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1DFDAD0", Offset = "0x1DFC4D0", VA = "0x181DFDAD0")]
	private bool PPGHPJNOHNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1DFDC30", Offset = "0x1DFC630", VA = "0x181DFDC30")]
	public MJBJMFELHGP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E00110", Offset = "0x1DFEB10", VA = "0x181E00110")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E00220", Offset = "0x1DFEC20", VA = "0x181E00220")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
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
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
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
