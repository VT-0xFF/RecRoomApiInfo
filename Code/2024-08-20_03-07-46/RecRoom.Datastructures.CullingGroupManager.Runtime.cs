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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PMEANFDAKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class MKENBEMBAGF<T> : NMKLGMFBJAG, DKHDDPCHFLD<T>, MMAMIIEJECJ where T : class, HEJCMDHONJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x44FFCC0", Offset = "0x44FECC0", VA = "0x1844FFCC0")]
			internal MKENBEMBAGF(int EALLDKHHMFK, float[] INGHFKFGCKL, IGIPIGNMAGM NICANMDIJKA = IGIPIGNMAGM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x44FFC90", Offset = "0x44FEC90", VA = "0x1844FFC90", Slot = "10")]
			public void GKAGDNHKNII(T NOPFNIKINJA, float EGNBICILIGE, OIAPKHBMKCC OLMDPNHNNPK = OIAPKHBMKCC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x44FFC60", Offset = "0x44FEC60", VA = "0x1844FFC60", Slot = "11")]
			public void GKAGDNHKNII(T NOPFNIKINJA, Transform BHIAPGCJADN, float EGNBICILIGE, OIAPKHBMKCC OLMDPNHNNPK = OIAPKHBMKCC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x44FFC40", Offset = "0x44FEC40", VA = "0x1844FFC40", Slot = "12")]
			public void FFDBNDOHLIO(T PJAKFDDBJBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NMKLGMFBJAG : IDisposable, MMAMIIEJECJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum IGIPIGNMAGM : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class DPKEBHFHELK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public HEJCMDHONJD HLIPLMDLIEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public OIAPKHBMKCC ABONENEIIBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action IOKBILDINKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool CAOHGKEBLLI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int LCNJIFOOGIB;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
				public DPKEBHFHELK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class PFEPEBIIHBO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public NMKLGMFBJAG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public DPKEBHFHELK trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
				public PFEPEBIIHBO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6949990", Offset = "0x6948990", VA = "0x186949990")]
				internal void MHKOHOIJOFL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int BCHIKPGKJNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int EALLDKHHMFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int DJEFMBABFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool IHDIIKNEDCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup EILCBBCKPFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] NJNNFLDBFKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] MONMKFKBBDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly NHECMLPNNKF LCGMLIBOFMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<HEJCMDHONJD, int> ELBIJKDGAOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, DPKEBHFHELK> NHFJICAMELE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly IGIPIGNMAGM NICANMDIJKA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool COKPMKJDOPG
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x95D920", Offset = "0x95C920", VA = "0x18095D920")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x45BAA10", Offset = "0x45B9A10", VA = "0x1845BAA10", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x69495A0", Offset = "0x69485A0", VA = "0x1869495A0")]
			internal NMKLGMFBJAG(int EALLDKHHMFK, float[] INGHFKFGCKL, IGIPIGNMAGM NICANMDIJKA = IGIPIGNMAGM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6948500", Offset = "0x6947500", VA = "0x186948500")]
			public void FPOAMNJNPHI(bool CLACCHGMAEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6948C50", Offset = "0x6947C50", VA = "0x186948C50", Slot = "6")]
			public void GKAGDNHKNII(HEJCMDHONJD NOPFNIKINJA, float EGNBICILIGE, OIAPKHBMKCC OLMDPNHNNPK = OIAPKHBMKCC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6948850", Offset = "0x6947850", VA = "0x186948850", Slot = "9")]
			public void GKAGDNHKNII(HEJCMDHONJD NOPFNIKINJA, Transform BHIAPGCJADN, float EGNBICILIGE, OIAPKHBMKCC OLMDPNHNNPK = OIAPKHBMKCC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6947FB0", Offset = "0x6946FB0", VA = "0x186947FB0")]
			public void EAAGOLHJGKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69479E0", Offset = "0x69469E0", VA = "0x1869479E0")]
			private void AOAPENCIANM(int HCALFJOJKJO, [Optional] float? EGNBICILIGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6948110", Offset = "0x6947110", VA = "0x186948110", Slot = "7")]
			public void FFDBNDOHLIO(HEJCMDHONJD PJAKFDDBJBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6948D40", Offset = "0x6947D40", VA = "0x186948D40", Slot = "8")]
			public void IEDCAKMMMPN(HEJCMDHONJD NOPFNIKINJA, OIAPKHBMKCC PJNGKBJLDNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6947CF0", Offset = "0x6946CF0", VA = "0x186947CF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6948E30", Offset = "0x6947E30", VA = "0x186948E30")]
			private void KOHFABPHGJC(DPKEBHFHELK PLJAABJMPPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6949300", Offset = "0x6948300", VA = "0x186949300")]
			private void OOGJMIPLBJB(DPKEBHFHELK PLJAABJMPPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6948CE0", Offset = "0x6947CE0", VA = "0x186948CE0")]
			private void HKGOFKAGNGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6947C80", Offset = "0x6946C80", VA = "0x186947C80")]
			private void CHANFAOBMDG(float HEGNCBOIFLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69491C0", Offset = "0x69481C0", VA = "0x1869491C0")]
			private void LMDBLOMBBPP(DPKEBHFHELK PLJAABJMPPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6948100", Offset = "0x6947100", VA = "0x186948100")]
			private void FDOBPIEOJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6947CE0", Offset = "0x6946CE0", VA = "0x186947CE0")]
			private void DJNOOKJHFIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6948530", Offset = "0x6947530", VA = "0x186948530")]
			private void GEFAMKKJNPH(CullingGroupEvent CFIOBDEFOCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6947B10", Offset = "0x6946B10", VA = "0x186947B10")]
			private void BHJNEDJPNFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JCENDKLAKLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort LEELAGMLEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type IGJMIGHPLJL;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float JHJKNIODNEO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MDKFIEGIINN = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IBGKMNDPNGL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float KIJAIABFINN = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float IPKMOENNJCO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float EAOOHKIODNF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float HIFMDEBHGLK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JCENDKLAKLI, NMKLGMFBJAG> KLJFDMCCAPG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable MHNJGGAKJEJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable JJLHJNHHHOH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static PEHINEDJEEO ADALMPLABPL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static PEHINEDJEEO PPKMGBOMAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly PEHINEDJEEO CILJLOLDEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly PEHINEDJEEO DMPAFBPAMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PEHINEDJEEO IIHDGHGANKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HDBNHMIPDLF LPMJAMNPPFF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool CLACCHGMAEE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public PEHINEDJEEO GAHOAEMDPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PEHINEDJEEO AGOMNOGDBKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public PEHINEDJEEO GMNGAJIPGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JHJHJJHFEDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xFCD500", Offset = "0xFCC500", VA = "0x180FCD500", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CFFIKLOINIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA68730", Offset = "0xA67730", VA = "0x180A68730", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA68570", Offset = "0xA67570", VA = "0x180A68570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6946760", Offset = "0x6945760", VA = "0x186946760", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6947090", Offset = "0x6946090", VA = "0x186947090")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6947070", Offset = "0x6946070", VA = "0x186947070")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6946820", Offset = "0x6945820", VA = "0x186946820")]
		private void EMFMOCDLFNI(Scene FEGAALCJPNO, LoadSceneMode HIJBNPKNLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6946F90", Offset = "0x6945F90", VA = "0x186946F90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6947470", Offset = "0x6946470", VA = "0x186947470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6946DF0", Offset = "0x6945DF0", VA = "0x186946DF0")]
		private void NECBMHGBNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6947230", Offset = "0x6946230", VA = "0x186947230")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69470B0", Offset = "0x69460B0", VA = "0x1869470B0")]
		private void PKJGIPDENFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69469E0", Offset = "0x69459E0", VA = "0x1869469E0")]
		public MMAMIIEJECJ GetOrCreateCullingGroup(Type LBMEPLELADD, int JCJAGBOLMKI, ushort ILCHGFJKELF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29FAB40", Offset = "0x29F9B40", VA = "0x1829FAB40")]
		public DKHDDPCHFLD<T> GetOrCreateCullingGroup<T>(int JCJAGBOLMKI, ushort ILCHGFJKELF = 0) where T : class, HEJCMDHONJD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6946C00", Offset = "0x6945C00", VA = "0x186946C00")]
		private MMAMIIEJECJ HKJDNJHOLFN(Type LBMEPLELADD, int JCJAGBOLMKI, float[] INGHFKFGCKL, ushort ILCHGFJKELF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29FABF0", Offset = "0x29F9BF0", VA = "0x1829FABF0")]
		private DKHDDPCHFLD<T> HKJDNJHOLFN<T>(int JCJAGBOLMKI, float[] INGHFKFGCKL, ushort ILCHGFJKELF = 0) where T : class, HEJCMDHONJD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6946880", Offset = "0x6945880", VA = "0x186946880")]
		public static OOGOAJCGPNN FindClosestDefaultUpdateLod(float LPIDBACNJOL)
		{
			return default(OOGOAJCGPNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87F050", Offset = "0x87E050", VA = "0x18087F050")]
		public static OOGOAJCGPNN MinUpdateLod(OOGOAJCGPNN BDOBLFCMHGK, OOGOAJCGPNN EEFFJNLLGGJ)
		{
			return default(OOGOAJCGPNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6946DE0", Offset = "0x6945DE0", VA = "0x186946DE0")]
		public static OOGOAJCGPNN MaxUpdateLod(OOGOAJCGPNN BDOBLFCMHGK, OOGOAJCGPNN EEFFJNLLGGJ)
		{
			return default(OOGOAJCGPNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69478E0", Offset = "0x69468E0", VA = "0x1869478E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NHECMLPNNKF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AKDHILHCCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera BNAMAALPKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PEHINEDJEEO JELFLKHCMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GINKPJMOAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PEHINEDJEEO HFKAPHBHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform MOALHAHMGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MMAMIIEJECJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool COKPMKJDOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKAGDNHKNII(HEJCMDHONJD NOPFNIKINJA, float EGNBICILIGE, OIAPKHBMKCC OLMDPNHNNPK = OIAPKHBMKCC.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFDBNDOHLIO(HEJCMDHONJD PJAKFDDBJBK);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IEDCAKMMMPN(HEJCMDHONJD NOPFNIKINJA, OIAPKHBMKCC FGGBELHDHLA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DKHDDPCHFLD<T> : MMAMIIEJECJ where T : class, HEJCMDHONJD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKAGDNHKNII(T NOPFNIKINJA, float EGNBICILIGE, OIAPKHBMKCC OLMDPNHNNPK = OIAPKHBMKCC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKAGDNHKNII(T NOPFNIKINJA, Transform BHIAPGCJADN, float EGNBICILIGE, OIAPKHBMKCC OLMDPNHNNPK = OIAPKHBMKCC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFDBNDOHLIO(T PJAKFDDBJBK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HEJCMDHONJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DBCCBLKNBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(OOGOAJCGPNN AADNFIHEBGF, OOGOAJCGPNN GEBBLEELDAA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool OJHGBAANJLF);
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
