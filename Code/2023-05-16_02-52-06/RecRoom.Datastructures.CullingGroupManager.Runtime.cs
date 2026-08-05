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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, FMLFHMDEAFL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class OAGLKJBPCCI<T> : IPELGHDPEAK, global::DNMBKGBFNLL<T>, GEPGAPOHCJM where T : class, HJNDPAEFNLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E9F0", Offset = "0x2C4D7F0", VA = "0x182C4E9F0")]
			internal OAGLKJBPCCI(int AHOIOBMCGPB, float[] AJNJGOMPMKP, PHDJCKIOGJP EOGAEHHKAIC = PHDJCKIOGJP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E990", Offset = "0x2C4D790", VA = "0x182C4E990", Slot = "15")]
			public void OEECIDDHIAM(T OJGAEOFIMPK, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E9C0", Offset = "0x2C4D7C0", VA = "0x182C4E9C0", Slot = "16")]
			public void OEECIDDHIAM(T OJGAEOFIMPK, Transform LHAPNEJMPAE, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E930", Offset = "0x2C4D730", VA = "0x182C4E930", Slot = "17")]
			public void JPIOMOECAJJ(T OJGAEOFIMPK, [Optional] float? JONJPBNIFLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E8F0", Offset = "0x2C4D6F0", VA = "0x182C4E8F0", Slot = "18")]
			public void CJGLMEKHGBL(T BGBIOFHJINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E910", Offset = "0x2C4D710", VA = "0x182C4E910", Slot = "19")]
			public FLDAKNOJEGK ILAAGOPACGL(T OJGAEOFIMPK)
			{
				return default(FLDAKNOJEGK);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E950", Offset = "0x2C4D750", VA = "0x182C4E950", Slot = "20")]
			public bool MJEIGOEHMNP(T OJGAEOFIMPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2C4E970", Offset = "0x2C4D770", VA = "0x182C4E970", Slot = "21")]
			public void NNBOLGDCBAL(T OJGAEOFIMPK, NBGHNIKHPAF PJNPKDBGHDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class IPELGHDPEAK : IDisposable, GEPGAPOHCJM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum PHDJCKIOGJP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KIAJMHMDBCG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public HJNDPAEFNLO CFDPJBBJBKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public NBGHNIKHPAF PJFBMJODAMJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action NNBBMEBNCOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool HKDOEBFGNPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int CEEBBJGGBDE;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
				public KIAJMHMDBCG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class OOCNKGDENCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public IPELGHDPEAK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public KIAJMHMDBCG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
				public OOCNKGDENCB()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int PHOECKAOFHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int AHOIOBMCGPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BNMNOFALCDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool OCJGGEPKHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup FFNONGPMCPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] NDGGPDCHBDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] PBFDMCINOMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly EHPEGFJGAGE BGEMPOFCNMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<HJNDPAEFNLO, int> NNGBBNLENJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, KIAJMHMDBCG> GNOPIIOPBAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly PHDJCKIOGJP EOGAEHHKAIC;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int OFAOKJALCNC
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int DBMHOPJDEIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x757920", Offset = "0x756720", VA = "0x180757920", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0900", Offset = "0x6ACF700", VA = "0x186AD0900")]
			internal IPELGHDPEAK(int AHOIOBMCGPB, float[] AJNJGOMPMKP, PHDJCKIOGJP EOGAEHHKAIC = PHDJCKIOGJP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF9E0", Offset = "0x6ACE7E0", VA = "0x186ACF9E0")]
			public void JPLACPOLOLI(bool OHPEFNFODEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6ACFFB0", Offset = "0x6ACEDB0", VA = "0x186ACFFB0", Slot = "7")]
			public FLDAKNOJEGK NNCEKGOGMDE(float MKLANFPGMGC)
			{
				return default(FLDAKNOJEGK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0190", Offset = "0x6ACEF90", VA = "0x186AD0190", Slot = "8")]
			public void OEECIDDHIAM(HJNDPAEFNLO OJGAEOFIMPK, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0220", Offset = "0x6ACF020", VA = "0x186AD0220", Slot = "9")]
			public void OEECIDDHIAM(HJNDPAEFNLO OJGAEOFIMPK, Transform LHAPNEJMPAE, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6ACE8A0", Offset = "0x6ACD6A0", VA = "0x186ACE8A0")]
			public void ADFDDJOIEPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF960", Offset = "0x6ACE760", VA = "0x186ACF960", Slot = "10")]
			public void JPIOMOECAJJ(HJNDPAEFNLO OJGAEOFIMPK, [Optional] float? JONJPBNIFLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF1B0", Offset = "0x6ACDFB0", VA = "0x186ACF1B0")]
			private void FAONBJFEGMK(int NNHNOIMLALG, [Optional] float? JONJPBNIFLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6ACEAE0", Offset = "0x6ACD8E0", VA = "0x186ACEAE0", Slot = "11")]
			public void CJGLMEKHGBL(HJNDPAEFNLO BGBIOFHJINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF850", Offset = "0x6ACE650", VA = "0x186ACF850", Slot = "12")]
			public FLDAKNOJEGK ILAAGOPACGL(HJNDPAEFNLO OJGAEOFIMPK)
			{
				return default(FLDAKNOJEGK);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6ACFD50", Offset = "0x6ACEB50", VA = "0x186ACFD50", Slot = "13")]
			public bool MJEIGOEHMNP(HJNDPAEFNLO OJGAEOFIMPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6ACFEC0", Offset = "0x6ACECC0", VA = "0x186ACFEC0", Slot = "14")]
			public void NNBOLGDCBAL(HJNDPAEFNLO OJGAEOFIMPK, NBGHNIKHPAF HKDJIOKCPGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6ACEF10", Offset = "0x6ACDD10", VA = "0x186ACEF10", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF490", Offset = "0x6ACE290", VA = "0x186ACF490")]
			private void HBNGLMGMGOA(KIAJMHMDBCG KNEFNECIIGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0670", Offset = "0x6ACF470", VA = "0x186AD0670")]
			private void OLACPFJMGCL(KIAJMHMDBCG KNEFNECIIGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6ACEA70", Offset = "0x6ACD870", VA = "0x186ACEA70")]
			private void CFFEIDHGDDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6ACFE50", Offset = "0x6ACEC50", VA = "0x186ACFE50")]
			private void MLADDIHEBMC(float MCDLNHCIIJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6ACEA20", Offset = "0x6ACD820", VA = "0x186ACEA20")]
			private void AHLMFBPIBLL(KIAJMHMDBCG KNEFNECIIGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6ACEA60", Offset = "0x6ACD860", VA = "0x186ACEA60")]
			private void BOGKDMIIHNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6ACEA50", Offset = "0x6ACD850", VA = "0x186ACEA50")]
			private void BGNDIPBFLGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6ACFA10", Offset = "0x6ACE810", VA = "0x186ACFA10")]
			private void LJJLEFGPAPF(CullingGroupEvent BODCKHPIGPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF310", Offset = "0x6ACE110", VA = "0x186ACF310")]
			private void GOGDDLOAFJE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct CEMBHOKAEJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort EHCLIBOFEIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type EBHILHHBNEP;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float AHEMGKBAFMM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HEKINNDGJED = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GIPGFLALMDC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NLIOILHICHE = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float ICKIKBKINDJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float LKMLIBHKPCF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float OMHMFKIKOBE = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<CEMBHOKAEJF, IPELGHDPEAK> JNHHEHMFBFC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable BADKCDDOLBC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable OPPJEONHICM;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CJIPBGMKILF JEGPEEBBLNB;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CJIPBGMKILF GEKLNFOCEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CJIPBGMKILF IALCFGJAPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CJIPBGMKILF NLEJKPMDGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CJIPBGMKILF FIIOFIFOKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LGJHLMJKIJM APOIFDOJCDN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OHPEFNFODEK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CJIPBGMKILF FBDNLOAOJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CJIPBGMKILF IOCECPLIABB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CJIPBGMKILF AEGEPELEBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NCDCHINIGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x19DD750", Offset = "0x19DC550", VA = "0x1819DD750", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BHEGDCDHOIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA94EC0", Offset = "0xA93CC0", VA = "0x180A94EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD810", Offset = "0x6ACC610", VA = "0x186ACD810", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x123F520", Offset = "0x123E320", VA = "0x18123F520")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE110", Offset = "0x6ACCF10", VA = "0x186ACE110")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDE10", Offset = "0x6ACCC10", VA = "0x186ACDE10")]
		private void HDJIEOJALCO(Scene OAALIIEEAME, LoadSceneMode LHDFDDPEACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE030", Offset = "0x6ACCE30", VA = "0x186ACE030", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE360", Offset = "0x6ACD160", VA = "0x186ACE360")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDE90", Offset = "0x6ACCC90", VA = "0x186ACDE90")]
		private void OOKCMNHIANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE130", Offset = "0x6ACCF30", VA = "0x186ACE130")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD690", Offset = "0x6ACC490", VA = "0x186ACD690")]
		private void AJOOBAGKNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDC20", Offset = "0x6ACCA20", VA = "0x186ACDC20")]
		public GEPGAPOHCJM GetOrCreateCullingGroup(Type LDHJPKBBNBI, int BNBJOEJPJJN, ushort FJJPBMPEKLF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x22C0410", Offset = "0x22BF210", VA = "0x1822C0410")]
		public global::DNMBKGBFNLL<T> GetOrCreateCullingGroup<T>(int BNBJOEJPJJN, ushort FJJPBMPEKLF = 0) where T : class, HJNDPAEFNLO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD8E0", Offset = "0x6ACC6E0", VA = "0x186ACD8E0")]
		private GEPGAPOHCJM CBGBECGJCMP(Type LDHJPKBBNBI, int BNBJOEJPJJN, float[] AJNJGOMPMKP, ushort FJJPBMPEKLF = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22C01E0", Offset = "0x22BEFE0", VA = "0x1822C01E0")]
		private global::DNMBKGBFNLL<T> CBGBECGJCMP<T>(int BNBJOEJPJJN, float[] AJNJGOMPMKP, ushort FJJPBMPEKLF = 0) where T : class, HJNDPAEFNLO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDA80", Offset = "0x6ACC880", VA = "0x186ACDA80")]
		public static FLDAKNOJEGK FindClosestDefaultUpdateLod(float EKLKPLFPFEF)
		{
			return default(FLDAKNOJEGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDE80", Offset = "0x6ACCC80", VA = "0x186ACDE80")]
		public static FLDAKNOJEGK MinUpdateLod(FLDAKNOJEGK LBLFFNJMLGP, FLDAKNOJEGK HOEMLBONDIE)
		{
			return default(FLDAKNOJEGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDE70", Offset = "0x6ACCC70", VA = "0x186ACDE70")]
		public static FLDAKNOJEGK MaxUpdateLod(FLDAKNOJEGK LBLFFNJMLGP, FLDAKNOJEGK HOEMLBONDIE)
		{
			return default(FLDAKNOJEGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6ACE790", Offset = "0x6ACD590", VA = "0x186ACE790")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EHPEGFJGAGE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PHKKKPAEEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera LMPCMLBDHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CJIPBGMKILF PECAJODKNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ACEBLECIFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CJIPBGMKILF AHJAIAGOEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform LKFGAJBHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GEPGAPOHCJM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int OFAOKJALCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int DBMHOPJDEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FLDAKNOJEGK NNCEKGOGMDE(float MKLANFPGMGC);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEECIDDHIAM(HJNDPAEFNLO OJGAEOFIMPK, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEECIDDHIAM(HJNDPAEFNLO OJGAEOFIMPK, Transform LHAPNEJMPAE, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPIOMOECAJJ(HJNDPAEFNLO OJGAEOFIMPK, [Optional] float? JONJPBNIFLM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJGLMEKHGBL(HJNDPAEFNLO BGBIOFHJINL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FLDAKNOJEGK ILAAGOPACGL(HJNDPAEFNLO OJGAEOFIMPK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MJEIGOEHMNP(HJNDPAEFNLO OJGAEOFIMPK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NNBOLGDCBAL(HJNDPAEFNLO OJGAEOFIMPK, NBGHNIKHPAF PJNPKDBGHDB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DNMBKGBFNLL<T> : GEPGAPOHCJM where T : class, HJNDPAEFNLO
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(T OJGAEOFIMPK, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEECIDDHIAM(T OJGAEOFIMPK, Transform LHAPNEJMPAE, float JONJPBNIFLM, NBGHNIKHPAF ODEIBBNFAHF = NBGHNIKHPAF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPIOMOECAJJ(T OJGAEOFIMPK, [Optional] float? JONJPBNIFLM);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJGLMEKHGBL(T BGBIOFHJINL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FLDAKNOJEGK ILAAGOPACGL(T OJGAEOFIMPK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MJEIGOEHMNP(T OJGAEOFIMPK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNBOLGDCBAL(T OJGAEOFIMPK, NBGHNIKHPAF PJNPKDBGHDB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HJNDPAEFNLO
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform KGHIPKNMKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FLDAKNOJEGK POMOHGIONKG, FLDAKNOJEGK FIDABFEFJEB);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IICGJGKEPDM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum NBGHNIKHPAF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FLDAKNOJEGK
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
public class KDLBEFIDJNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FLDAKNOJEGK NFEDIMPGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private FLDAKNOJEGK JEAHNGLGEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, FLDAKNOJEGK> DBMEEAMFKMG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EMMNAOBCCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6AD12F0", Offset = "0x6AD00F0", VA = "0x186AD12F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FLDAKNOJEGK KBBHHIIFEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
		get
		{
			return default(FLDAKNOJEGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FLDAKNOJEGK EIANHIIHOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x757920", Offset = "0x756720", VA = "0x180757920")]
		get
		{
			return default(FLDAKNOJEGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1500", Offset = "0x6AD0300", VA = "0x186AD1500")]
	public bool NMBLHBILMPM(object AMBDKIOJFBL, FLDAKNOJEGK MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD14A0", Offset = "0x6AD02A0", VA = "0x186AD14A0")]
	public bool MNMLNGCEBNN(object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1340", Offset = "0x6AD0140", VA = "0x186AD1340")]
	private bool GHFIJCNJFEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1570", Offset = "0x6AD0370", VA = "0x186AD1570")]
	public KDLBEFIDJNF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1010", Offset = "0x6ACFE10", VA = "0x186AD1010")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0CC0", Offset = "0x6ACFAC0", VA = "0x186AD0CC0")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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
