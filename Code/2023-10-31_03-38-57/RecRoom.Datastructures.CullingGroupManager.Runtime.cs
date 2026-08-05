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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, ACBFFOFLNMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class JPHLBIOPDDG<T> : LONIEMEIMGL, BKMEFOJFOEP<T>, ADPDPCABPGF where T : class, AOCMGNBNDFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3866880", Offset = "0x3865C80", VA = "0x183866880")]
			internal JPHLBIOPDDG(int FHIOBCGAHLF, float[] NNELCJHOMAJ, EEFDPPOJCIE HMJBECEJFFC = EEFDPPOJCIE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3866850", Offset = "0x3865C50", VA = "0x183866850", Slot = "10")]
			public void INMJBKGEACO(T BAFDGKKJJJD, float NOEHIDPEPEC, BFDBALLDKAM FHMOIIHOCOK = BFDBALLDKAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3866820", Offset = "0x3865C20", VA = "0x183866820", Slot = "11")]
			public void INMJBKGEACO(T BAFDGKKJJJD, Transform PCNEMKFBHGP, float NOEHIDPEPEC, BFDBALLDKAM FHMOIIHOCOK = BFDBALLDKAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3866800", Offset = "0x3865C00", VA = "0x183866800", Slot = "12")]
			public void BLFHNKIOGCM(T AEIGJOPGPKF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class LONIEMEIMGL : IDisposable, ADPDPCABPGF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum EEFDPPOJCIE : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class IDOEOKFANCK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public AOCMGNBNDFN LOMBCMGOCKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public BFDBALLDKAM NAAGIKMLPAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action INEOBIGPGGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool FCCECCBGFEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int CBNNNKAIBOB;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
				public IDOEOKFANCK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class GDEPJIMNLIP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public LONIEMEIMGL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public IDOEOKFANCK trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
				public GDEPJIMNLIP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5C4C140", Offset = "0x5C4B540", VA = "0x185C4C140")]
				internal void MCIGJGOJPIN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int JFMDPOJECDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int FHIOBCGAHLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int MICJFFNMGAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool GIAGFMCPJPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup HJFNEMJECHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] JGOKLEFHFAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] MBKIANPEIBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly GBKJGJKJICE LFANGALDMHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<AOCMGNBNDFN, int> MIOCJLIGFIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, IDOEOKFANCK> HCMHKNBBJBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly EEFDPPOJCIE HMJBECEJFFC;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IPBJOPBIFAF
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x19D11F0", Offset = "0x19D05F0", VA = "0x1819D11F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3BED780", Offset = "0x3BECB80", VA = "0x183BED780", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5C4DE30", Offset = "0x5C4D230", VA = "0x185C4DE30")]
			internal LONIEMEIMGL(int FHIOBCGAHLF, float[] NNELCJHOMAJ, EEFDPPOJCIE HMJBECEJFFC = EEFDPPOJCIE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5C4C5B0", Offset = "0x5C4B9B0", VA = "0x185C4C5B0")]
			public void AFNOFIHGHEN(bool JLDINMBJPKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5C4D740", Offset = "0x5C4CB40", VA = "0x185C4D740", Slot = "6")]
			public void INMJBKGEACO(AOCMGNBNDFN BAFDGKKJJJD, float NOEHIDPEPEC, BFDBALLDKAM FHMOIIHOCOK = BFDBALLDKAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5C4D7D0", Offset = "0x5C4CBD0", VA = "0x185C4D7D0", Slot = "9")]
			public void INMJBKGEACO(AOCMGNBNDFN BAFDGKKJJJD, Transform PCNEMKFBHGP, float NOEHIDPEPEC, BFDBALLDKAM FHMOIIHOCOK = BFDBALLDKAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5C4C8E0", Offset = "0x5C4BCE0", VA = "0x185C4C8E0")]
			public void BGBNAOFNICK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C4D0D0", Offset = "0x5C4C4D0", VA = "0x185C4D0D0")]
			private void FFHMHBMKDCA(int APOENOPNHBG, [Optional] float? NOEHIDPEPEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5C4CA30", Offset = "0x5C4BE30", VA = "0x185C4CA30", Slot = "7")]
			public void BLFHNKIOGCM(AOCMGNBNDFN AEIGJOPGPKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5C4DBC0", Offset = "0x5C4CFC0", VA = "0x185C4DBC0", Slot = "8")]
			public void JGKNEAPGCIN(AOCMGNBNDFN BAFDGKKJJJD, BFDBALLDKAM AIJBOBAPENN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5C4CE10", Offset = "0x5C4C210", VA = "0x185C4CE10", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5C4D3A0", Offset = "0x5C4C7A0", VA = "0x185C4D3A0")]
			private void HOOOHKKIKKM(IDOEOKFANCK BJDEJHEGDDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5C4C640", Offset = "0x5C4BA40", VA = "0x185C4C640")]
			private void AIFPAJPLOIN(IDOEOKFANCK BJDEJHEGDDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5C4D200", Offset = "0x5C4C600", VA = "0x185C4D200")]
			private void FIOHMGNBNNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5C4C5E0", Offset = "0x5C4B9E0", VA = "0x185C4C5E0")]
			private void AHFKHANANBA(float HGGDOAEFCDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5C4D260", Offset = "0x5C4C660", VA = "0x185C4D260")]
			private void HNMABHLPBDG(IDOEOKFANCK BJDEJHEGDDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5C4D730", Offset = "0x5C4CB30", VA = "0x185C4D730")]
			private void HPCEPJFDILP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5C4DCB0", Offset = "0x5C4D0B0", VA = "0x185C4DCB0")]
			private void LJKOJCLLNNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5C4C290", Offset = "0x5C4B690", VA = "0x185C4C290")]
			private void AEGMKDMICBG(CullingGroupEvent IKOIKEJEPHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5C4DCC0", Offset = "0x5C4D0C0", VA = "0x185C4DCC0")]
			private void NJKBCMOCEEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct BIEMAIAKIME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort PCPPPJHEHFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type PIBEJCFCBJO;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HJEBNPNJOMM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float PKKJBLLPJLL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IOOPPGMBDNL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MKFAFHOMMMG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FBHIHDFEDMA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HDDMIDHJPIA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float DFJALNBBHNK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<BIEMAIAKIME, LONIEMEIMGL> DIODDLOPGEA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable LDMPHBEEJFO;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable BNKHJIPONLC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static OAELJMFAJKM EDKELDFPHLC;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static OAELJMFAJKM APDPFIGLEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly OAELJMFAJKM KPFAANOIMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OAELJMFAJKM NIGKNOPENHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OAELJMFAJKM DHKLPBGMKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MICMLGMLJFD JKPKKPKJMJM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool JLDINMBJPKG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public OAELJMFAJKM LMEGLJFCDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OAELJMFAJKM IOOCFAKIHDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OAELJMFAJKM PALEFEBGHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EJIGLIHEMKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBC0270", Offset = "0xBBF670", VA = "0x180BC0270", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DFMDIDOMHHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C80", Offset = "0x7B1080", VA = "0x1807B1C80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B10B0", VA = "0x1807B1CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C4AEC0", Offset = "0x5C4A2C0", VA = "0x185C4AEC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B970", Offset = "0x5C4AD70", VA = "0x185C4B970")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B950", Offset = "0x5C4AD50", VA = "0x185C4B950")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C4AF80", Offset = "0x5C4A380", VA = "0x185C4AF80")]
		private void DCOAHOCPEAL(Scene PMDINEBDLOA, LoadSceneMode DGDIMEGBJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B870", Offset = "0x5C4AC70", VA = "0x185C4B870", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4BBD0", Offset = "0x5C4AFD0", VA = "0x185C4BBD0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C4AFE0", Offset = "0x5C4A3E0", VA = "0x185C4AFE0")]
		private void DLBEEJACANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B990", Offset = "0x5C4AD90", VA = "0x185C4B990")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B2E0", Offset = "0x5C4A6E0", VA = "0x185C4B2E0")]
		private void GELDLANIGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B460", Offset = "0x5C4A860", VA = "0x185C4B460")]
		public ADPDPCABPGF GetOrCreateCullingGroup(Type FCCKIIBEOID, int JOCEMJCCGAP, ushort GMINMOIKFLM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x222C180", Offset = "0x222B580", VA = "0x18222C180")]
		public BKMEFOJFOEP<T> GetOrCreateCullingGroup<T>(int JOCEMJCCGAP, ushort GMINMOIKFLM = 0) where T : class, AOCMGNBNDFN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B690", Offset = "0x5C4AA90", VA = "0x185C4B690")]
		private ADPDPCABPGF NMAAJKCJHCO(Type FCCKIIBEOID, int JOCEMJCCGAP, float[] NNELCJHOMAJ, ushort GMINMOIKFLM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x222C220", Offset = "0x222B620", VA = "0x18222C220")]
		private BKMEFOJFOEP<T> NMAAJKCJHCO<T>(int JOCEMJCCGAP, float[] NNELCJHOMAJ, ushort GMINMOIKFLM = 0) where T : class, AOCMGNBNDFN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B180", Offset = "0x5C4A580", VA = "0x185C4B180")]
		public static ADKLLFONPNJ FindClosestDefaultUpdateLod(float JFKAPDBMBDD)
		{
			return default(ADKLLFONPNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78B000", Offset = "0x78A400", VA = "0x18078B000")]
		public static ADKLLFONPNJ MinUpdateLod(ADKLLFONPNJ AHCMIFENEBG, ADKLLFONPNJ LBMPBIHIMBI)
		{
			return default(ADKLLFONPNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C4B680", Offset = "0x5C4AA80", VA = "0x185C4B680")]
		public static ADKLLFONPNJ MaxUpdateLod(ADKLLFONPNJ AHCMIFENEBG, ADKLLFONPNJ LBMPBIHIMBI)
		{
			return default(ADKLLFONPNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C4C040", Offset = "0x5C4B440", VA = "0x185C4C040")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GBKJGJKJICE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DMDAFCGBDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera COEAECLGIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OAELJMFAJKM MMDCNKBGOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MMMHKBNLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OAELJMFAJKM APJOGEBAEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform LLMDFPEAPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ADPDPCABPGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IPBJOPBIFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INMJBKGEACO(AOCMGNBNDFN BAFDGKKJJJD, float NOEHIDPEPEC, BFDBALLDKAM FHMOIIHOCOK = BFDBALLDKAM.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLFHNKIOGCM(AOCMGNBNDFN AEIGJOPGPKF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGKNEAPGCIN(AOCMGNBNDFN BAFDGKKJJJD, BFDBALLDKAM OFNNAFIHJFK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BKMEFOJFOEP<T> : ADPDPCABPGF where T : class, AOCMGNBNDFN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INMJBKGEACO(T BAFDGKKJJJD, float NOEHIDPEPEC, BFDBALLDKAM FHMOIIHOCOK = BFDBALLDKAM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INMJBKGEACO(T BAFDGKKJJJD, Transform PCNEMKFBHGP, float NOEHIDPEPEC, BFDBALLDKAM FHMOIIHOCOK = BFDBALLDKAM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLFHNKIOGCM(T AEIGJOPGPKF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AOCMGNBNDFN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform OLPLDGDFGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(ADKLLFONPNJ MMFHEIEDPEL, ADKLLFONPNJ FIFGGNDENCP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IGHHIFPBDLK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BFDBALLDKAM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ADKLLFONPNJ
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
