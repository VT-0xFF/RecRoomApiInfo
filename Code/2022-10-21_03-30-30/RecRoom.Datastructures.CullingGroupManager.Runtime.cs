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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, ONLKLFEPPAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class ENFHLKHEJNM : IDisposable, GGCGKFMNIIK
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int FAANEPEFLPA
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int HOCKEHANDDA
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void JPDMKACMDDL();

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void MDJBLHBICIC(bool ILDKLPIPLLP);

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			protected ENFHLKHEJNM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class CJDBFMCODAC<T> : ENFHLKHEJNM, global::NOHIECCJKJN<T>, GGCGKFMNIIK where T : OGAEICAKKEN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum PLMNHOFBNOP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class EAGOJKHFEEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T MDKCEMLOLDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public OLNAAACCIFA FCCJKJMCJNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action OAJPHNBLLMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool ICKFEDELLAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int KIJOKCLKDIN;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
				public EAGOJKHFEEH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class LJHOHCDKGOF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public CJDBFMCODAC<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EAGOJKHFEEH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
				public LJHOHCDKGOF()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NAHBJBFDGJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int HBBLFBBEPEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BOCABLLJGMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool DGKCCECAGMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup FKDLNJAIIPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] MMFGDDNCPEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] JFLFAHJGAFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly EAPGMGKLPLA NFACINHMFIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> HLEOJKNCNOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, EAGOJKHFEEH> EBOCLGLOCIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly PLMNHOFBNOP KEJDFAAFKFF;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int FAANEPEFLPA
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int HOCKEHANDDA
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x6570E0", Offset = "0x655EE0", VA = "0x1806570E0", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x24BEE80", Offset = "0x24BDC80", VA = "0x1824BEE80")]
			internal CJDBFMCODAC(int HBBLFBBEPEO, float[] EIPMHMEDIAI, PLMNHOFBNOP KEJDFAAFKFF = PLMNHOFBNOP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x24BECF0", Offset = "0x24BDAF0", VA = "0x1824BECF0", Slot = "11")]
			public override void MDJBLHBICIC(bool ILDKLPIPLLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x24BE830", Offset = "0x24BD630", VA = "0x1824BE830", Slot = "12")]
			public PEBHBGGGBMC LBCAOPNAODF(float MPFDNHLDONB)
			{
				return default(PEBHBGGGBMC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x24BE4D0", Offset = "0x24BD2D0", VA = "0x1824BE4D0", Slot = "13")]
			public void HEFJCCLOLGO(T CCPIHKCBGHF, float LOENLJKDLIO, OLNAAACCIFA MAADCODEECA = OLNAAACCIFA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x24BE040", Offset = "0x24BCE40", VA = "0x1824BE040", Slot = "14")]
			public void HEFJCCLOLGO(T CCPIHKCBGHF, Transform LJFLANECHAD, float LOENLJKDLIO, OLNAAACCIFA MAADCODEECA = OLNAAACCIFA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x24BE690", Offset = "0x24BD490", VA = "0x1824BE690", Slot = "8")]
			public override void JPDMKACMDDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x24BE900", Offset = "0x24BD700", VA = "0x1824BE900", Slot = "15")]
			public void LOEKCFBHDGL(T CCPIHKCBGHF, [Optional] float? LOENLJKDLIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x24BED20", Offset = "0x24BDB20", VA = "0x1824BED20")]
			private void PEGPAGIJEAP(int AIPHGHFENPJ, [Optional] float? LOENLJKDLIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x24BCE40", Offset = "0x24BBC40", VA = "0x1824BCE40", Slot = "16")]
			public void AKJLIPOIGHF(T CPGIGOMJNFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x24BE570", Offset = "0x24BD370", VA = "0x1824BE570", Slot = "17")]
			public PEBHBGGGBMC HKFICACKMNM(T CCPIHKCBGHF)
			{
				return default(PEBHBGGGBMC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x24BD270", Offset = "0x24BC070", VA = "0x1824BD270", Slot = "18")]
			public bool CECJMGLFBME(T CCPIHKCBGHF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x24BD7A0", Offset = "0x24BC5A0", VA = "0x1824BD7A0", Slot = "19")]
			public void DFDCFHIEIBP(T CCPIHKCBGHF, OLNAAACCIFA KBMDKJCCILK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x24BD8B0", Offset = "0x24BC6B0", VA = "0x1824BD8B0", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x24BD380", Offset = "0x24BC180", VA = "0x1824BD380")]
			private void CPOPFNCDEON(EAGOJKHFEEH NAGANIPBPOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x24BDC30", Offset = "0x24BCA30", VA = "0x1824BDC30")]
			private void FFJPOGKNEFP(EAGOJKHFEEH NAGANIPBPOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x24BE890", Offset = "0x24BD690", VA = "0x1824BE890")]
			private void LEMFHOBBLEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x24BDBC0", Offset = "0x24BC9C0", VA = "0x1824BDBC0")]
			private void EBEPFIACFFE(float BBCCLHDKIDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x24BD760", Offset = "0x24BC560", VA = "0x1824BD760")]
			private void DCDAEONNJPL(EAGOJKHFEEH NAGANIPBPOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x24BE810", Offset = "0x24BD610", VA = "0x1824BE810")]
			private void KJMGJGDHMNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x24BE980", Offset = "0x24BD780", VA = "0x1824BE980")]
			private void LPLNGPCPKEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x24BE9B0", Offset = "0x24BD7B0", VA = "0x1824BE9B0")]
			private void MADCLMCKMEI(CullingGroupEvent KABKNBFAFFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x24BDEC0", Offset = "0x24BCCC0", VA = "0x1824BDEC0")]
			private void FJNILDKJLMG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct HJOAGBFIMDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort PMIJJGAIPCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type KPNLPEFLPEB;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float AGEDMPPCPBL = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float PKAIHMIDKKA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float MGGCDHLBKIF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NEAKMHHKAMP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float EGKMJAKNENC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float DMGKFEOCJMA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float IHIPOAIBFNA = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<HJOAGBFIMDG, ENFHLKHEJNM> CHKFLJKCCKB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CMHLLDFLOBJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable JDBKBKFGMCK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static HOPKEKFNJGO MOLOGPHNMIN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static HOPKEKFNJGO MEGFNBPAPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HOPKEKFNJGO HNMGHOMBOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HOPKEKFNJGO NLMDBNCGBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HOPKEKFNJGO CMHNGLKBIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FCEDOONPEIE BJDBJHCKNCJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ILDKLPIPLLP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HOPKEKFNJGO IPFEFGCKPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HOPKEKFNJGO CJJJJDJPIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HOPKEKFNJGO PALMHKLFPNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EKDOBOBEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x12BB6B0", Offset = "0x12BA4B0", VA = "0x1812BB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HDILLNCPIJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x84A9A0", Offset = "0x8497A0", VA = "0x18084A9A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x897D00", Offset = "0x896B00", VA = "0x180897D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C620", Offset = "0x5E7B420", VA = "0x185E7C620", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD3CAC0", Offset = "0xD3B8C0", VA = "0x180D3CAC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CB60", Offset = "0x5E7B960", VA = "0x185E7CB60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C890", Offset = "0x5E7B690", VA = "0x185E7C890")]
		private void JKFDMFIKOMH(Scene DBCGBCALMLO, LoadSceneMode CIJCIMPGNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CA80", Offset = "0x5E7B880", VA = "0x185E7CA80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CE20", Offset = "0x5E7BC20", VA = "0x185E7CE20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C470", Offset = "0x5E7B270", VA = "0x185E7C470")]
		private void APPPOPPBLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CB80", Offset = "0x5E7B980", VA = "0x185E7CB80")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C8F0", Offset = "0x5E7B6F0", VA = "0x185E7C8F0")]
		private void KKAOCKBFEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x235B2B0", Offset = "0x235A0B0", VA = "0x18235B2B0")]
		public global::NOHIECCJKJN<T> GetOrCreateCullingGroup<T>(int NECMAJJFOED, ushort GLCBOOCGILE = 0) where T : OGAEICAKKEN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x235B360", Offset = "0x235A160", VA = "0x18235B360")]
		private global::NOHIECCJKJN<T> IJPIOCHFNOF<T>(int NECMAJJFOED, float[] EIPMHMEDIAI, ushort GLCBOOCGILE = 0) where T : OGAEICAKKEN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C6F0", Offset = "0x5E7B4F0", VA = "0x185E7C6F0")]
		public static PEBHBGGGBMC FindClosestDefaultUpdateLod(float KMPFGPMOJMH)
		{
			return default(PEBHBGGGBMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CA70", Offset = "0x5E7B870", VA = "0x185E7CA70")]
		public static PEBHBGGGBMC MinUpdateLod(PEBHBGGGBMC KKGGLDGNFJC, PEBHBGGGBMC HNGNAEFGNIB)
		{
			return default(PEBHBGGGBMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CA60", Offset = "0x5E7B860", VA = "0x185E7CA60")]
		public static PEBHBGGGBMC MaxUpdateLod(PEBHBGGGBMC KKGGLDGNFJC, PEBHBGGGBMC HNGNAEFGNIB)
		{
			return default(PEBHBGGGBMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D0F0", Offset = "0x5E7BEF0", VA = "0x185E7D0F0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EAPGMGKLPLA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GKOIBJDECEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera MLAKDKNOOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HOPKEKFNJGO LKDFOGAJPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KHOFLGAIHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HOPKEKFNJGO HFMKEMGAMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform OIFBHEKGKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GGCGKFMNIIK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int FAANEPEFLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int HOCKEHANDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NOHIECCJKJN<T> : GGCGKFMNIIK where T : OGAEICAKKEN
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEBHBGGGBMC LBCAOPNAODF(float MPFDNHLDONB);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEFJCCLOLGO(T CCPIHKCBGHF, float LOENLJKDLIO, OLNAAACCIFA MAADCODEECA = OLNAAACCIFA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEFJCCLOLGO(T CCPIHKCBGHF, Transform LJFLANECHAD, float LOENLJKDLIO, OLNAAACCIFA MAADCODEECA = OLNAAACCIFA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LOEKCFBHDGL(T CCPIHKCBGHF, [Optional] float? LOENLJKDLIO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKJLIPOIGHF(T CPGIGOMJNFF);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PEBHBGGGBMC HKFICACKMNM(T CCPIHKCBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CECJMGLFBME(T CCPIHKCBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DFDCFHIEIBP(T CCPIHKCBGHF, OLNAAACCIFA CHHKODPGGFN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OGAEICAKKEN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform BCHADNCHEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(PEBHBGGGBMC ANLJHNJAGIC, PEBHBGGGBMC FIIFHECAMPK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JBGFCLGGLPD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum OLNAAACCIFA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PEBHBGGGBMC
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
public class JCLAIODIIPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private PEBHBGGGBMC OCIAEJCLHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private PEBHBGGGBMC GEOHKIDILGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, PEBHBGGGBMC> EMKNLEFJGEC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MGBIGNFKMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D200", Offset = "0x5E7C000", VA = "0x185E7D200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public PEBHBGGGBMC KMPFDJKHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
		get
		{
			return default(PEBHBGGGBMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PEBHBGGGBMC KIFKPDJEFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6570E0", Offset = "0x655EE0", VA = "0x1806570E0")]
		get
		{
			return default(PEBHBGGGBMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D250", Offset = "0x5E7C050", VA = "0x185E7D250")]
	public bool FEJCNECMMHF(object MKDOEIGPNGM, PEBHBGGGBMC IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D2C0", Offset = "0x5E7C0C0", VA = "0x185E7D2C0")]
	public bool GFIDHGBMMBC(object MKDOEIGPNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D320", Offset = "0x5E7C120", VA = "0x185E7D320")]
	private bool JFKNAEBPANH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D480", Offset = "0x5E7C280", VA = "0x185E7D480")]
	public JCLAIODIIPA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BE40", Offset = "0x5E7AC40", VA = "0x185E7BE40")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BF50", Offset = "0x5E7AD50", VA = "0x185E7BF50")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
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

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
