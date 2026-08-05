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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, CFDFEHDBCMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class AINJJPICNBP<T> : MBHBDMNGAOB, KPNCNEKHEJB<T>, AHOONNCGJKF where T : class, MGLBENKAKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x392FD90", Offset = "0x392F190", VA = "0x18392FD90")]
			internal AINJJPICNBP(int IBMFFAOIDMN, float[] PHKHANKKFBC, CDJFENCCHPG LFAOOJKCLIH = CDJFENCCHPG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x392FD10", Offset = "0x392F110", VA = "0x18392FD10", Slot = "10")]
			public void FFIECPFJEFG(T LIKEKIACGIL, float BOGELENJKDJ, ELAPLOIAPPA PDAEJGJDBOG = ELAPLOIAPPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x392FD40", Offset = "0x392F140", VA = "0x18392FD40", Slot = "11")]
			public void FFIECPFJEFG(T LIKEKIACGIL, Transform BOPBIFIOADB, float BOGELENJKDJ, ELAPLOIAPPA PDAEJGJDBOG = ELAPLOIAPPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x392FD70", Offset = "0x392F170", VA = "0x18392FD70", Slot = "12")]
			public void PIABDNKCBCD(T MKHNOALGMAG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MBHBDMNGAOB : IDisposable, AHOONNCGJKF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum CDJFENCCHPG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class IBENIELCNAF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public MGLBENKAKCI HPPINACKADM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public ELAPLOIAPPA DOCJAFDPOJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action PKDNHBHHDFJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool DBMLIMBOMKL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int LCMFLKBKPPA;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
				public IBENIELCNAF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DPFMAIBEDHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public MBHBDMNGAOB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public IBENIELCNAF trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
				public DPFMAIBEDHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6187F30", Offset = "0x6187330", VA = "0x186187F30")]
				internal void GBMEPFODKIJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int IBNLEKINAIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int IBMFFAOIDMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FNLKBKJHEBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KFEECCNBOJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup NPEJNHLMGCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] JGAPENOGGGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] ECDLMALNLBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly FECBFMPALLP ACAIKIGINDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<MGLBENKAKCI, int> PLPFFPBJEIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, IBENIELCNAF> HEEKHKNBHPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CDJFENCCHPG LFAOOJKCLIH;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool JGHAIECMNKA
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xDF1880", Offset = "0xDF0C80", VA = "0x180DF1880")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3F61730", Offset = "0x3F60B30", VA = "0x183F61730", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6189C20", Offset = "0x6189020", VA = "0x186189C20")]
			internal MBHBDMNGAOB(int IBMFFAOIDMN, float[] PHKHANKKFBC, CDJFENCCHPG LFAOOJKCLIH = CDJFENCCHPG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6189810", Offset = "0x6188C10", VA = "0x186189810")]
			public void OKCFBPGDCLF(bool HFFHJCKPPOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6189230", Offset = "0x6188630", VA = "0x186189230", Slot = "6")]
			public void FFIECPFJEFG(MGLBENKAKCI LIKEKIACGIL, float BOGELENJKDJ, ELAPLOIAPPA PDAEJGJDBOG = ELAPLOIAPPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x61892C0", Offset = "0x61886C0", VA = "0x1861892C0", Slot = "9")]
			public void FFIECPFJEFG(MGLBENKAKCI LIKEKIACGIL, Transform BOPBIFIOADB, float BOGELENJKDJ, ELAPLOIAPPA PDAEJGJDBOG = ELAPLOIAPPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6188330", Offset = "0x6187730", VA = "0x186188330")]
			public void DHMGHGJNEEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6188200", Offset = "0x6187600", VA = "0x186188200")]
			private void CPNJLGMMECG(int PMLKPJNGBAD, [Optional] float? BOGELENJKDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6189840", Offset = "0x6188C40", VA = "0x186189840", Slot = "7")]
			public void PIABDNKCBCD(MGLBENKAKCI MKHNOALGMAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6189710", Offset = "0x6188B10", VA = "0x186189710", Slot = "8")]
			public void GNENPBBDJMJ(MGLBENKAKCI LIKEKIACGIL, ELAPLOIAPPA MEKEOHDDJCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6188480", Offset = "0x6187880", VA = "0x186188480", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6188D60", Offset = "0x6188160", VA = "0x186188D60")]
			private void ENIDCBMDDIC(IBENIELCNAF HOKJLBEBDNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6188A60", Offset = "0x6187E60", VA = "0x186188A60")]
			private void ELCLBHPPOJG(IBENIELCNAF HOKJLBEBDNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6188D00", Offset = "0x6188100", VA = "0x186188D00")]
			private void ELGKFFMPGCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61896B0", Offset = "0x6188AB0", VA = "0x1861896B0")]
			private void FLJOGBIPJBI(float MEOLIKAEACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x61890F0", Offset = "0x61884F0", VA = "0x1861890F0")]
			private void EPFIGCKGMOC(IBENIELCNAF HOKJLBEBDNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6189800", Offset = "0x6188C00", VA = "0x186189800")]
			private void JDNMLKGNLDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x61881F0", Offset = "0x61875F0", VA = "0x1861881F0")]
			private void BEDKMMGJHBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6188740", Offset = "0x6187B40", VA = "0x186188740")]
			private void ECGBFKPPCIM(CullingGroupEvent FGMKFICMPCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6188080", Offset = "0x6187480", VA = "0x186188080")]
			private void AKKODJPIKEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct BMAOCKJFAJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort HMFOIKNAMGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type ANNLCNJKGDD;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float ACBONMKEGEJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float CAIIDMNGGKM = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FFEFKFNHMGE = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float OPFGACHFFBF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float IDOJKEPFJID = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float DCLPBCNFKPD = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float HJNDEOLKEMA = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<BMAOCKJFAJB, MBHBDMNGAOB> EBBNDLAFFAB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PBJBHNLHKMP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable GEAGHAJBECB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DGHHAMKHKGM BLODIBDLFLD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DGHHAMKHKGM PMGPMAKODNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DGHHAMKHKGM LHMHFCOHGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DGHHAMKHKGM GAOJBDCMEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DGHHAMKHKGM AMIIKBGHPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ELCBICMGPAO ECHCJEMKDIK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool HFFHJCKPPOB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DGHHAMKHKGM BBFMIGCKEBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DGHHAMKHKGM NNDCFHHEHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DGHHAMKHKGM HOJBBLPAKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KBPOOLOPDAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD82620", Offset = "0xD81A20", VA = "0x180D82620", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MOFCIAAAGLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8854D0", Offset = "0x8848D0", VA = "0x1808854D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x968FE0", Offset = "0x9683E0", VA = "0x180968FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6186CB0", Offset = "0x61860B0", VA = "0x186186CB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6187760", Offset = "0x6186B60", VA = "0x186187760")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6187740", Offset = "0x6186B40", VA = "0x186187740")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6187600", Offset = "0x6186A00", VA = "0x186187600")]
		private void ONOLHHGFCML(Scene NKLOKBNKNAB, LoadSceneMode LFOBHMCPMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6187660", Offset = "0x6186A60", VA = "0x186187660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61879C0", Offset = "0x6186DC0", VA = "0x1861879C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6187460", Offset = "0x6186860", VA = "0x186187460")]
		private void NOAGKOFBJFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6187780", Offset = "0x6186B80", VA = "0x186187780")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61870F0", Offset = "0x61864F0", VA = "0x1861870F0")]
		private void HOLHKPJGPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6186ED0", Offset = "0x61862D0", VA = "0x186186ED0")]
		public AHOONNCGJKF GetOrCreateCullingGroup(Type JKOPOGCHNEN, int NAJLMIPLMMF, ushort BOKPKPOOPDM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x26479E0", Offset = "0x2646DE0", VA = "0x1826479E0")]
		public KPNCNEKHEJB<T> GetOrCreateCullingGroup<T>(int NAJLMIPLMMF, ushort BOKPKPOOPDM = 0) where T : class, MGLBENKAKCI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6187270", Offset = "0x6186670", VA = "0x186187270")]
		private AHOONNCGJKF MHJOGAFPIBJ(Type JKOPOGCHNEN, int NAJLMIPLMMF, float[] PHKHANKKFBC, ushort BOKPKPOOPDM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2647A80", Offset = "0x2646E80", VA = "0x182647A80")]
		private KPNCNEKHEJB<T> MHJOGAFPIBJ<T>(int NAJLMIPLMMF, float[] PHKHANKKFBC, ushort BOKPKPOOPDM = 0) where T : class, MGLBENKAKCI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6186D70", Offset = "0x6186170", VA = "0x186186D70")]
		public static NBPFHEAGOPH FindClosestDefaultUpdateLod(float KIGEDBIJOON)
		{
			return default(NBPFHEAGOPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7EAFF0", Offset = "0x7EA3F0", VA = "0x1807EAFF0")]
		public static NBPFHEAGOPH MinUpdateLod(NBPFHEAGOPH DMFNPDKLCDE, NBPFHEAGOPH HNEBCBOOPLP)
		{
			return default(NBPFHEAGOPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6187450", Offset = "0x6186850", VA = "0x186187450")]
		public static NBPFHEAGOPH MaxUpdateLod(NBPFHEAGOPH DMFNPDKLCDE, NBPFHEAGOPH HNEBCBOOPLP)
		{
			return default(NBPFHEAGOPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6187E30", Offset = "0x6187230", VA = "0x186187E30")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FECBFMPALLP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IOMMLOHJBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PGPJNNFAJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DGHHAMKHKGM LMGNNGBMJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FCELJOJOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DGHHAMKHKGM IAAGBIJDCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform OJHCCCFEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AHOONNCGJKF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JGHAIECMNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFIECPFJEFG(MGLBENKAKCI LIKEKIACGIL, float BOGELENJKDJ, ELAPLOIAPPA PDAEJGJDBOG = ELAPLOIAPPA.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIABDNKCBCD(MGLBENKAKCI MKHNOALGMAG);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNENPBBDJMJ(MGLBENKAKCI LIKEKIACGIL, ELAPLOIAPPA LLNDIPFJIGL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KPNCNEKHEJB<T> : AHOONNCGJKF where T : class, MGLBENKAKCI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFIECPFJEFG(T LIKEKIACGIL, float BOGELENJKDJ, ELAPLOIAPPA PDAEJGJDBOG = ELAPLOIAPPA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFIECPFJEFG(T LIKEKIACGIL, Transform BOPBIFIOADB, float BOGELENJKDJ, ELAPLOIAPPA PDAEJGJDBOG = ELAPLOIAPPA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIABDNKCBCD(T MKHNOALGMAG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MGLBENKAKCI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform KDNNBEIJOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(NBPFHEAGOPH EHCILKPBPDE, NBPFHEAGOPH IBPDPPGDMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NHBIJGNKDPH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum ELAPLOIAPPA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NBPFHEAGOPH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
