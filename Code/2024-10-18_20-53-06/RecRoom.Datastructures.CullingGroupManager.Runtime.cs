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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, HNMADAJPBON
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class BMNIBOOBKPD<T> : EHKPAEPFHBO, AFCLKBCMKNI<T>, MIIBBEHCOHE where T : class, HAMADHEGBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5285670", Offset = "0x5284A70", VA = "0x185285670")]
			internal BMNIBOOBKPD(int FMHHEGAIOIC, float[] PNOPBEMEJLA, DALOAIDGODA BJCKGELPAND = DALOAIDGODA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5285620", Offset = "0x5284A20", VA = "0x185285620", Slot = "11")]
			public void LEFBGNCKNFL(T FMAFBHGACNM, float CBOFEOAGGML, MLNLAOAECFA LLDHPDHBMFL = MLNLAOAECFA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x52855F0", Offset = "0x52849F0", VA = "0x1852855F0", Slot = "12")]
			public void LEFBGNCKNFL(T FMAFBHGACNM, Transform GJEJFPACPJK, float CBOFEOAGGML, MLNLAOAECFA LLDHPDHBMFL = MLNLAOAECFA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x52855D0", Offset = "0x52849D0", VA = "0x1852855D0", Slot = "13")]
			public void BJFEGIDGDBE(T PGCBCKPANDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5285650", Offset = "0x5284A50", VA = "0x185285650", Slot = "14")]
			public bool MNKNKDBFPNF(T FMAFBHGACNM)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class EHKPAEPFHBO : IDisposable, MIIBBEHCOHE
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum DALOAIDGODA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class CNNCHCBJLMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public HAMADHEGBGJ BAPHJCKPNHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public MLNLAOAECFA EKELBCJFBLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action EJLJHEGJKMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool JBAPBAEOGPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int KMIIBMECGKI;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
				public CNNCHCBJLMO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DDHPOKLEKHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EHKPAEPFHBO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public CNNCHCBJLMO trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
				public DDHPOKLEKHB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6D99C10", Offset = "0x6D99010", VA = "0x186D99C10")]
				internal void MNOFEFGGBBH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int CHAPBGDPDFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int FMHHEGAIOIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GGAMCBCCCPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool NLOIKEFMMEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup PGNHFFOEINB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] IAHHMAPPKMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] IMEAODBCINP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly OOACOKOBIOL BLDEOEOIGBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<HAMADHEGBGJ, int> CEMGEAEMEHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, CNNCHCBJLMO> HPEDNGGFIOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly DALOAIDGODA BJCKGELPAND;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool ONEGPGPGCEL
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0xB47430", Offset = "0xB46830", VA = "0x180B47430")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x488D0E0", Offset = "0x488C4E0", VA = "0x18488D0E0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B9C0", Offset = "0x6D9ADC0", VA = "0x186D9B9C0")]
			internal EHKPAEPFHBO(int FMHHEGAIOIC, float[] PNOPBEMEJLA, DALOAIDGODA BJCKGELPAND = DALOAIDGODA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B600", Offset = "0x6D9AA00", VA = "0x186D9B600")]
			public void NDBMIOHJPKM(bool HGMONEPLJDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6D9AF90", Offset = "0x6D9A390", VA = "0x186D9AF90", Slot = "6")]
			public void LEFBGNCKNFL(HAMADHEGBGJ FMAFBHGACNM, float CBOFEOAGGML, MLNLAOAECFA LLDHPDHBMFL = MLNLAOAECFA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B020", Offset = "0x6D9A420", VA = "0x186D9B020", Slot = "9")]
			public void LEFBGNCKNFL(HAMADHEGBGJ FMAFBHGACNM, Transform GJEJFPACPJK, float CBOFEOAGGML, MLNLAOAECFA LLDHPDHBMFL = MLNLAOAECFA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A920", Offset = "0x6D99D20", VA = "0x186D9A920")]
			public void KBOICGBNAEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A150", Offset = "0x6D99550", VA = "0x186D9A150")]
			private void CFBNOMDANNH(int HAJICDLBEKC, [Optional] float? CBOFEOAGGML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D99D60", Offset = "0x6D99160", VA = "0x186D99D60", Slot = "7")]
			public void BJFEGIDGDBE(HAMADHEGBGJ PGCBCKPANDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B420", Offset = "0x6D9A820", VA = "0x186D9B420", Slot = "10")]
			public bool MNKNKDBFPNF(HAMADHEGBGJ FMAFBHGACNM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B510", Offset = "0x6D9A910", VA = "0x186D9B510", Slot = "8")]
			public void NAKAEHFGJLF(HAMADHEGBGJ FMAFBHGACNM, MLNLAOAECFA BJAFGMFANBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A2E0", Offset = "0x6D996E0", VA = "0x186D9A2E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A5B0", Offset = "0x6D999B0", VA = "0x186D9A5B0")]
			private void IIAPMNGPGDD(CNNCHCBJLMO FKNCELPAAGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D9AA70", Offset = "0x6D99E70", VA = "0x186D9AA70")]
			private void KDBIFGOPBPP(CNNCHCBJLMO FKNCELPAAGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B630", Offset = "0x6D9AA30", VA = "0x186D9B630")]
			private void OAPHOGEBONF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A280", Offset = "0x6D99680", VA = "0x186D9A280")]
			private void CJMBAMBOIPC(float KDDKBBMEFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9AE50", Offset = "0x6D9A250", VA = "0x186D9AE50")]
			private void LAPAOOEMOKP(CNNCHCBJLMO FKNCELPAAGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A910", Offset = "0x6D99D10", VA = "0x186D9A910")]
			private void IJEFBOIJEJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D9A5A0", Offset = "0x6D999A0", VA = "0x186D9A5A0")]
			private void EHLPNNKAGNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B690", Offset = "0x6D9AA90", VA = "0x186D9B690")]
			private void OPICAEONNHH(CullingGroupEvent FJACJGDAKHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6D9ACE0", Offset = "0x6D9A0E0", VA = "0x186D9ACE0")]
			private void KDCJMAIHCAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FFKCGGLEKGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort EEFLGAGFNAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type HPIPDBKFAIM;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HHHEOKEEJHJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float FFHKGMHKJMC = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LMMIOLJOJLH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NGEICDKMPJL = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FNDNKBKFALO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float KGKIFLBANED = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float PCJKMIHAEJE = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FFKCGGLEKGD, EHKPAEPFHBO> CPNDHOJLLFD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DOCPFEIJCEM;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EOPPKIOAHEN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static LDNMACGBDLI NMNAPDAEHEM;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LDNMACGBDLI PLJKBLJFENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LDNMACGBDLI MDOHAMEJAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LDNMACGBDLI FAOAGKDPONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LDNMACGBDLI LMNBABGEKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NFIGMHBJPEE KEPFOHCFAHA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool HGMONEPLJDM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LDNMACGBDLI MLNDPKEIHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LDNMACGBDLI MFDFGGNBJLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LDNMACGBDLI DLPAIGNDELN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool FADEAEJCEJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x92DD90", Offset = "0x92D190", VA = "0x18092DD90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MFAJGJGKLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCAB850", Offset = "0xCAAC50", VA = "0x180CAB850", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDB0010", Offset = "0xDAF410", VA = "0x180DB0010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D989D0", Offset = "0x6D97DD0", VA = "0x186D989D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D99470", Offset = "0x6D98870", VA = "0x186D99470")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D99450", Offset = "0x6D98850", VA = "0x186D99450")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D98A90", Offset = "0x6D97E90", VA = "0x186D98A90")]
		private void EJPLBIEOGOG(Scene AMLGJOJEOEP, LoadSceneMode GJELEMMNCEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D99370", Offset = "0x6D98770", VA = "0x186D99370", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D996C0", Offset = "0x6D98AC0", VA = "0x186D996C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D98FE0", Offset = "0x6D983E0", VA = "0x186D98FE0")]
		private void IIFOLIONIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D99490", Offset = "0x6D98890", VA = "0x186D99490")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D98C50", Offset = "0x6D98050", VA = "0x186D98C50")]
		private void GODDPGBDPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D98DC0", Offset = "0x6D981C0", VA = "0x186D98DC0")]
		public MIIBBEHCOHE GetOrCreateCullingGroup(Type LJHJIDKEHMA, int DMCEMEIAEJP, ushort CLONHFIMJKP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BFF0", Offset = "0x2C9B3F0", VA = "0x182C9BFF0")]
		public AFCLKBCMKNI<T> GetOrCreateCullingGroup<T>(int DMCEMEIAEJP, ushort CLONHFIMJKP = 0) where T : class, HAMADHEGBGJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D99190", Offset = "0x6D98590", VA = "0x186D99190")]
		private MIIBBEHCOHE OKPNFGBEIGM(Type LJHJIDKEHMA, int DMCEMEIAEJP, float[] PNOPBEMEJLA, ushort CLONHFIMJKP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C0A0", Offset = "0x2C9B4A0", VA = "0x182C9C0A0")]
		private AFCLKBCMKNI<T> OKPNFGBEIGM<T>(int DMCEMEIAEJP, float[] PNOPBEMEJLA, ushort CLONHFIMJKP = 0) where T : class, HAMADHEGBGJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6D98AF0", Offset = "0x6D97EF0", VA = "0x186D98AF0")]
		public static JHPLKFFCHDF FindClosestDefaultUpdateLod(float IJAHOJCCNAO)
		{
			return default(JHPLKFFCHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D7330", Offset = "0x8D6730", VA = "0x1808D7330")]
		public static JHPLKFFCHDF MinUpdateLod(JHPLKFFCHDF JKOFDJGJJLF, JHPLKFFCHDF DBFJAIDNIAC)
		{
			return default(JHPLKFFCHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D99180", Offset = "0x6D98580", VA = "0x186D99180")]
		public static JHPLKFFCHDF MaxUpdateLod(JHPLKFFCHDF JKOFDJGJJLF, JHPLKFFCHDF DBFJAIDNIAC)
		{
			return default(JHPLKFFCHDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D99B10", Offset = "0x6D98F10", VA = "0x186D99B10")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OOACOKOBIOL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LMGGGHFCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera GMONNEIKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LDNMACGBDLI EPMEEHODJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KIJCAJMFAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LDNMACGBDLI CHKNPNNNJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform GKOLLNDIGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MIIBBEHCOHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ONEGPGPGCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEFBGNCKNFL(HAMADHEGBGJ FMAFBHGACNM, float CBOFEOAGGML, MLNLAOAECFA LLDHPDHBMFL = MLNLAOAECFA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJFEGIDGDBE(HAMADHEGBGJ PGCBCKPANDP);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NAKAEHFGJLF(HAMADHEGBGJ FMAFBHGACNM, MLNLAOAECFA BBNKFPFJIPF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AFCLKBCMKNI<T> : MIIBBEHCOHE where T : class, HAMADHEGBGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEFBGNCKNFL(T FMAFBHGACNM, float CBOFEOAGGML, MLNLAOAECFA LLDHPDHBMFL = MLNLAOAECFA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEFBGNCKNFL(T FMAFBHGACNM, Transform GJEJFPACPJK, float CBOFEOAGGML, MLNLAOAECFA LLDHPDHBMFL = MLNLAOAECFA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJFEGIDGDBE(T PGCBCKPANDP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MNKNKDBFPNF(T FMAFBHGACNM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HAMADHEGBGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform HGENDDPKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(JHPLKFFCHDF NJKDGCIALCM, JHPLKFFCHDF KGBIGAKOKLE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NEEIAEKHOHG);
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
