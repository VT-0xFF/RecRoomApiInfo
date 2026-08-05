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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JIAECHDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class MIAPBNIGIBF<T> : NKLAFHOLCMN, EOKDBKMEOAB<T>, PIPECKGFBCF where T : class, FKONIPBKDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x44FEC20", Offset = "0x44FD220", VA = "0x1844FEC20")]
			internal MIAPBNIGIBF(int NDDABEKKADC, float[] LBCJEFGPLJP, KOGBMDNBPIA LGAIIDKLCJF = KOGBMDNBPIA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x44FEBD0", Offset = "0x44FD1D0", VA = "0x1844FEBD0", Slot = "10")]
			public void AGMNBECNIJC(T CDBNFNMIHPK, float PIBBFIKNNCO, MDEPBKMBPJG MCAIIIKAKAB = MDEPBKMBPJG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x44FEBA0", Offset = "0x44FD1A0", VA = "0x1844FEBA0", Slot = "11")]
			public void AGMNBECNIJC(T CDBNFNMIHPK, Transform HGGOJFLGPEA, float PIBBFIKNNCO, MDEPBKMBPJG MCAIIIKAKAB = MDEPBKMBPJG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x44FEC00", Offset = "0x44FD200", VA = "0x1844FEC00", Slot = "12")]
			public void PJEMHMBEIPM(T NBDHCHJCIJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NKLAFHOLCMN : IDisposable, PIPECKGFBCF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum KOGBMDNBPIA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class HOAHKPALPAC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FKONIPBKDNE PMAJHHKCEPH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public MDEPBKMBPJG FNMIOJIALFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action BPINIAJGCMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool ECFMODOMCFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int JPOHIBGABMB;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
				public HOAHKPALPAC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class LINDGOIIIMG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public NKLAFHOLCMN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public HOAHKPALPAC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
				public LINDGOIIIMG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x697D120", Offset = "0x697B720", VA = "0x18697D120")]
				internal void IJHLJLAPLKF()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HEOMGPNOAKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NDDABEKKADC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int HMGCDCANKDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool PCNGABNNECG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup JLIJBGJKIKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] PCNPLBOFAPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] HNMAGGPKINK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly LLMEBNIMFMB FGMBCEGOCBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FKONIPBKDNE, int> PIOBGCFPPIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, HOAHKPALPAC> FHLLHGCIEPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly KOGBMDNBPIA LGAIIDKLCJF;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool LPMLPNOFPJM
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x96BE40", Offset = "0x96A440", VA = "0x18096BE40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x455E9C0", Offset = "0x455CFC0", VA = "0x18455E9C0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x697EDB0", Offset = "0x697D3B0", VA = "0x18697EDB0")]
			internal NKLAFHOLCMN(int NDDABEKKADC, float[] LBCJEFGPLJP, KOGBMDNBPIA LGAIIDKLCJF = KOGBMDNBPIA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x697D6F0", Offset = "0x697BCF0", VA = "0x18697D6F0")]
			public void CFGGEPEJCMP(bool JOMLCPJCKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x697D270", Offset = "0x697B870", VA = "0x18697D270", Slot = "6")]
			public void AGMNBECNIJC(FKONIPBKDNE CDBNFNMIHPK, float PIBBFIKNNCO, MDEPBKMBPJG MCAIIIKAKAB = MDEPBKMBPJG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x697D300", Offset = "0x697B900", VA = "0x18697D300", Slot = "9")]
			public void AGMNBECNIJC(FKONIPBKDNE CDBNFNMIHPK, Transform HGGOJFLGPEA, float PIBBFIKNNCO, MDEPBKMBPJG MCAIIIKAKAB = MDEPBKMBPJG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x697E6E0", Offset = "0x697CCE0", VA = "0x18697E6E0")]
			public void MGLGEDOFBPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x697DCC0", Offset = "0x697C2C0", VA = "0x18697DCC0")]
			private void DDGFJDLBICH(int EBDMAJMOJLN, [Optional] float? PIBBFIKNNCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x697E9D0", Offset = "0x697CFD0", VA = "0x18697E9D0", Slot = "7")]
			public void PJEMHMBEIPM(FKONIPBKDNE NBDHCHJCIJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x697E220", Offset = "0x697C820", VA = "0x18697E220", Slot = "8")]
			public void FHNBIPLGLCB(FKONIPBKDNE CDBNFNMIHPK, MDEPBKMBPJG JABEAOHNKPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x697DF60", Offset = "0x697C560", VA = "0x18697DF60", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x697E310", Offset = "0x697C910", VA = "0x18697E310")]
			private void HOFKCLGMHJH(HOAHKPALPAC HAPIEIKEMCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x697D720", Offset = "0x697BD20", VA = "0x18697D720")]
			private void CGGELFFJCAD(HOAHKPALPAC HAPIEIKEMCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x697E970", Offset = "0x697CF70", VA = "0x18697E970")]
			private void NHDDFMEACJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x697E680", Offset = "0x697CC80", VA = "0x18697E680")]
			private void JANKPPHEAJF(float KNACCMPDNHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x697E830", Offset = "0x697CE30", VA = "0x18697E830")]
			private void NAJHILKKHCK(HOAHKPALPAC HAPIEIKEMCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x697D990", Offset = "0x697BF90", VA = "0x18697D990")]
			private void CIBOBBGKLDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x697E670", Offset = "0x697CC70", VA = "0x18697E670")]
			private void IFLAGOLPEBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x697D9A0", Offset = "0x697BFA0", VA = "0x18697D9A0")]
			private void CJCJMGOGFAN(CullingGroupEvent JGBALABJEBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x697DDF0", Offset = "0x697C3F0", VA = "0x18697DDF0")]
			private void DMAFKLAOHOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct MOGMGKFMKIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort IPBFAPHHGHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type PFCACOHDNCJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float BPDPJCGPECE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OBLEHEKKHJD = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float DHJMLADJHBK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float KBHIPAFDBIM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float EJCOCADBMJL = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NEKODJBIPDM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NOGOOGKFGNC = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<MOGMGKFMKIA, NKLAFHOLCMN> AAHINEBBNIC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable LDFIFPBMPFE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FOLCIOBOIGD;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CLOBMDANPDK KMOFHHPNMDG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CLOBMDANPDK PLHPFJEOPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CLOBMDANPDK MDHIIGEIDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CLOBMDANPDK MOKDKIGIHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CLOBMDANPDK NHAANEJDCNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MCOHGCAFPBM HEGPJBCJDMG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool JOMLCPJCKCK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CLOBMDANPDK HAEFOOHPMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CLOBMDANPDK OMGBKJHAAEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CLOBMDANPDK FFCMCLNLLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OBJGMHOEKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xFC6ED0", Offset = "0xFC54D0", VA = "0x180FC6ED0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool AOGNBCAIPGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA7A3C0", Offset = "0xA789C0", VA = "0x180A7A3C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA7A400", Offset = "0xA78A00", VA = "0x180A7A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x697BEE0", Offset = "0x697A4E0", VA = "0x18697BEE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x697C7A0", Offset = "0x697ADA0", VA = "0x18697C7A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x697C780", Offset = "0x697AD80", VA = "0x18697C780")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x697C630", Offset = "0x697AC30", VA = "0x18697C630")]
		private void JBDDPKAFGCG(Scene COCIKBKCNFK, LoadSceneMode EPPOJBGBBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x697C6A0", Offset = "0x697ACA0", VA = "0x18697C6A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x697CBD0", Offset = "0x697B1D0", VA = "0x18697CBD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x697C110", Offset = "0x697A710", VA = "0x18697C110")]
		private void FHCHKGFFFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x697C9A0", Offset = "0x697AFA0", VA = "0x18697C9A0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x697BFA0", Offset = "0x697A5A0", VA = "0x18697BFA0")]
		private void BMMMNLDJGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x697C410", Offset = "0x697AA10", VA = "0x18697C410")]
		public PIPECKGFBCF GetOrCreateCullingGroup(Type FIEKPPJNHPO, int KDFNKILHJAC, ushort GAGCOJCPHGG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2999DE0", Offset = "0x29983E0", VA = "0x182999DE0")]
		public EOKDBKMEOAB<T> GetOrCreateCullingGroup<T>(int KDFNKILHJAC, ushort GAGCOJCPHGG = 0) where T : class, FKONIPBKDNE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x697C7C0", Offset = "0x697ADC0", VA = "0x18697C7C0")]
		private PIPECKGFBCF PGJHJLLIPID(Type FIEKPPJNHPO, int KDFNKILHJAC, float[] LBCJEFGPLJP, ushort GAGCOJCPHGG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2999E90", Offset = "0x2998490", VA = "0x182999E90")]
		private EOKDBKMEOAB<T> PGJHJLLIPID<T>(int KDFNKILHJAC, float[] LBCJEFGPLJP, ushort GAGCOJCPHGG = 0) where T : class, FKONIPBKDNE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x697C2B0", Offset = "0x697A8B0", VA = "0x18697C2B0")]
		public static GHLGGPNNOMD FindClosestDefaultUpdateLod(float BEONDBJJOBI)
		{
			return default(GHLGGPNNOMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88B240", Offset = "0x889840", VA = "0x18088B240")]
		public static GHLGGPNNOMD MinUpdateLod(GHLGGPNNOMD AGDGMGKOFFL, GHLGGPNNOMD CEIIOAHLJDD)
		{
			return default(GHLGGPNNOMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x697C690", Offset = "0x697AC90", VA = "0x18697C690")]
		public static GHLGGPNNOMD MaxUpdateLod(GHLGGPNNOMD AGDGMGKOFFL, GHLGGPNNOMD CEIIOAHLJDD)
		{
			return default(GHLGGPNNOMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x697D020", Offset = "0x697B620", VA = "0x18697D020")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LLMEBNIMFMB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EGMCJCJKHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera DNDCCOMDDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CLOBMDANPDK CMDEJPPGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CMEEAIBEMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CLOBMDANPDK ECCGECFIOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform EJHJBBJOLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PIPECKGFBCF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool LPMLPNOFPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGMNBECNIJC(FKONIPBKDNE CDBNFNMIHPK, float PIBBFIKNNCO, MDEPBKMBPJG MCAIIIKAKAB = MDEPBKMBPJG.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJEMHMBEIPM(FKONIPBKDNE NBDHCHJCIJH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHNBIPLGLCB(FKONIPBKDNE CDBNFNMIHPK, MDEPBKMBPJG ECELFKPAKDK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EOKDBKMEOAB<T> : PIPECKGFBCF where T : class, FKONIPBKDNE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMNBECNIJC(T CDBNFNMIHPK, float PIBBFIKNNCO, MDEPBKMBPJG MCAIIIKAKAB = MDEPBKMBPJG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGMNBECNIJC(T CDBNFNMIHPK, Transform HGGOJFLGPEA, float PIBBFIKNNCO, MDEPBKMBPJG MCAIIIKAKAB = MDEPBKMBPJG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJEMHMBEIPM(T NBDHCHJCIJH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FKONIPBKDNE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform OGKACMCCFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GHLGGPNNOMD GFMIJGOEIBC, GHLGGPNNOMD LMCCPICICCC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool LCHODMNLLCG);
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
