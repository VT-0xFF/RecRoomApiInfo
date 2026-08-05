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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PKCMENKCIKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KBDBILKKOEM<T> : LBEGLKLLDPP, ABFJHOFCALM<T>, MLODEPOBAIH where T : class, NDCKNADOPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3A97650", Offset = "0x3A96050", VA = "0x183A97650")]
			internal KBDBILKKOEM(int KNIMENDBJCJ, float[] MLDPIIPLLOC, DDHHNLEFDEA PFCCDGKNIBM = DDHHNLEFDEA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3A975F0", Offset = "0x3A95FF0", VA = "0x183A975F0", Slot = "10")]
			public void DGLLAPEBOKO(T GKNPKJAGNGH, float HDEDKDLDKGD, CKAPAPIDKKF COMCHHHEGEF = CKAPAPIDKKF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3A97620", Offset = "0x3A96020", VA = "0x183A97620", Slot = "11")]
			public void DGLLAPEBOKO(T GKNPKJAGNGH, Transform FMCDDMGKDKO, float HDEDKDLDKGD, CKAPAPIDKKF COMCHHHEGEF = CKAPAPIDKKF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3A975D0", Offset = "0x3A95FD0", VA = "0x183A975D0", Slot = "12")]
			public void BPOFHEGLDCM(T BIEPDBDEOBD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class LBEGLKLLDPP : IDisposable, MLODEPOBAIH
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum DDHHNLEFDEA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OOKOGAALEHG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public NDCKNADOPHE HFHDDOHCJIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public CKAPAPIDKKF LIFJPHFKBEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action OJGBKLLMIMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool HDACOCEIEBN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int AMPNEGOJBEN;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
				public OOKOGAALEHG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class KJLADIBINFL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public LBEGLKLLDPP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public OOKOGAALEHG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
				public KJLADIBINFL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5F9E490", Offset = "0x5F9CE90", VA = "0x185F9E490")]
				internal void JAGONBLOLAJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int EBONPPGOALL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int KNIMENDBJCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int DKJNPDECMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KFPLPOJFILA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup GMHJDCNCCEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] JPKKKJHEJME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] NBCEDDKAJFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly ACCDOBAJEBG OHKJJALONEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<NDCKNADOPHE, int> OMGDIEMLKPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, OOKOGAALEHG> IIMKMDJJFFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly DDHHNLEFDEA PFCCDGKNIBM;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool CJMGCPBODCN
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1B0BBE0", Offset = "0x1B0A5E0", VA = "0x181B0BBE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3E2EB30", Offset = "0x3E2D530", VA = "0x183E2EB30", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0180", Offset = "0x5F9EB80", VA = "0x185FA0180")]
			internal LBEGLKLLDPP(int KNIMENDBJCJ, float[] MLDPIIPLLOC, DDHHNLEFDEA PFCCDGKNIBM = DDHHNLEFDEA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0130", Offset = "0x5F9EB30", VA = "0x185FA0130")]
			public void NDBJNFGFHHB(bool OFPOMEHEGEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DA70", VA = "0x185F9F070", Slot = "6")]
			public void DGLLAPEBOKO(NDCKNADOPHE GKNPKJAGNGH, float HDEDKDLDKGD, CKAPAPIDKKF COMCHHHEGEF = CKAPAPIDKKF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5F9EC80", Offset = "0x5F9D680", VA = "0x185F9EC80", Slot = "9")]
			public void DGLLAPEBOKO(NDCKNADOPHE GKNPKJAGNGH, Transform FMCDDMGKDKO, float HDEDKDLDKGD, CKAPAPIDKKF COMCHHHEGEF = CKAPAPIDKKF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5F9EB30", Offset = "0x5F9D530", VA = "0x185F9EB30")]
			public void DEPBDPMKLDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F7B0", Offset = "0x5F9E1B0", VA = "0x185F9F7B0")]
			private void GBLBKCFMNDC(int BNALCEABILL, [Optional] float? HDEDKDLDKGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5F9E750", Offset = "0x5F9D150", VA = "0x185F9E750", Slot = "7")]
			public void BPOFHEGLDCM(NDCKNADOPHE BIEPDBDEOBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0040", Offset = "0x5F9EA40", VA = "0x185FA0040", Slot = "8")]
			public void JJJIMIKPDIM(NDCKNADOPHE GKNPKJAGNGH, CKAPAPIDKKF GMCEBCDDAPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F490", Offset = "0x5F9DE90", VA = "0x185F9F490", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F100", Offset = "0x5F9DB00", VA = "0x185F9F100")]
			private void DLGCEMJMPHA(OOKOGAALEHG JHOFDHGAJOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5F9FD40", Offset = "0x5F9E740", VA = "0x185F9FD40")]
			private void IGFNCJDALFN(OOKOGAALEHG JHOFDHGAJOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F750", Offset = "0x5F9E150", VA = "0x185F9F750")]
			private void FKKLHNENIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5F9FFE0", Offset = "0x5F9E9E0", VA = "0x185F9FFE0")]
			private void JIGKCMKPOFD(float HNNKCGDCJIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5F9FC00", Offset = "0x5F9E600", VA = "0x185F9FC00")]
			private void HPDOKMACDLG(OOKOGAALEHG JHOFDHGAJOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0170", Offset = "0x5F9EB70", VA = "0x185FA0170")]
			private void PBAMHDGAANP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0160", Offset = "0x5F9EB60", VA = "0x185FA0160")]
			private void ONAAFHMFFEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5F9F8E0", Offset = "0x5F9E2E0", VA = "0x185F9F8E0")]
			private void GJAIAHOIIHM(CullingGroupEvent OJEGOKIBNJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5F9E5E0", Offset = "0x5F9CFE0", VA = "0x185F9E5E0")]
			private void ACBALNCNPMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct NAMAKBKDFIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort LBOOHIOGPFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type LDLOCFKKPKG;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float IJEGGOMCCND = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float EOJNGGNGFAO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float CIGKKFMPMEB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AOFIGPAANBM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float ADLCFJFBICP = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float AEMFADGOFKC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BLLOPFNOALL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<NAMAKBKDFIL, LBEGLKLLDPP> OGOHHFHAKBC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable KFOLDHPDJIA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable JEAJICIHBAB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static BCNLEBGHOIF EIPBCIBIAMJ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static BCNLEBGHOIF GPHPBLEPPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BCNLEBGHOIF FMNDNPIOMJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BCNLEBGHOIF NDFCFCFHNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BCNLEBGHOIF JGJCJPNCDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NEMGCHFJFIH KDJCFOFEGAI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OFPOMEHEGEL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BCNLEBGHOIF LHECAPIFGHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BCNLEBGHOIF GLMBHGDHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BCNLEBGHOIF GENINFAGEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CIPDMMGBJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBFB1A0", Offset = "0xBF9BA0", VA = "0x180BFB1A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MFFKOGJGPLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7E32F0", Offset = "0x7E1CF0", VA = "0x1807E32F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7E2D80", Offset = "0x7E1780", VA = "0x1807E2D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D210", Offset = "0x5F9BC10", VA = "0x185F9D210", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DCC0", Offset = "0x5F9C6C0", VA = "0x185F9DCC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DCA0", Offset = "0x5F9C6A0", VA = "0x185F9DCA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D9D0", Offset = "0x5F9C3D0", VA = "0x185F9D9D0")]
		private void JLPKNJIFNNL(Scene CNGLJAGLGEC, LoadSceneMode GMLCEBAHCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DBC0", Offset = "0x5F9C5C0", VA = "0x185F9DBC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DF20", Offset = "0x5F9C920", VA = "0x185F9DF20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D610", Offset = "0x5F9C010", VA = "0x185F9D610")]
		private void GNDPKCNGIHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DCE0", Offset = "0x5F9C6E0", VA = "0x185F9DCE0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DA40", Offset = "0x5F9C440", VA = "0x185F9DA40")]
		private void NBIHJADMLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D7B0", Offset = "0x5F9C1B0", VA = "0x185F9D7B0")]
		public MLODEPOBAIH GetOrCreateCullingGroup(Type BAMFGLAOOOK, int JLHCAHAOADL, ushort LGNBLOMKOKC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2471290", Offset = "0x246FC90", VA = "0x182471290")]
		public ABFJHOFCALM<T> GetOrCreateCullingGroup<T>(int JLHCAHAOADL, ushort LGNBLOMKOKC = 0) where T : class, NDCKNADOPHE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D2D0", Offset = "0x5F9BCD0", VA = "0x185F9D2D0")]
		private MLODEPOBAIH FIIBHKDEGBJ(Type BAMFGLAOOOK, int JLHCAHAOADL, float[] MLDPIIPLLOC, ushort LGNBLOMKOKC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2471020", Offset = "0x246FA20", VA = "0x182471020")]
		private ABFJHOFCALM<T> FIIBHKDEGBJ<T>(int JLHCAHAOADL, float[] MLDPIIPLLOC, ushort LGNBLOMKOKC = 0) where T : class, NDCKNADOPHE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D4B0", Offset = "0x5F9BEB0", VA = "0x185F9D4B0")]
		public static CPDDDNECHFB FindClosestDefaultUpdateLod(float GMCDIDFLCGC)
		{
			return default(CPDDDNECHFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BCFB0", Offset = "0x7BB9B0", VA = "0x1807BCFB0")]
		public static CPDDDNECHFB MinUpdateLod(CPDDDNECHFB JOFIIEIPJJP, CPDDDNECHFB GMFPFCBIHPJ)
		{
			return default(CPDDDNECHFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DA30", Offset = "0x5F9C430", VA = "0x185F9DA30")]
		public static CPDDDNECHFB MaxUpdateLod(CPDDDNECHFB JOFIIEIPJJP, CPDDDNECHFB GMFPFCBIHPJ)
		{
			return default(CPDDDNECHFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E390", Offset = "0x5F9CD90", VA = "0x185F9E390")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ACCDOBAJEBG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LGKKKEIDHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera HFEDHEEFGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BCNLEBGHOIF AEPOHKDDENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NCPHEJAEKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BCNLEBGHOIF DNBINCMCHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform DCMGPPMHPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MLODEPOBAIH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CJMGCPBODCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGLLAPEBOKO(NDCKNADOPHE GKNPKJAGNGH, float HDEDKDLDKGD, CKAPAPIDKKF COMCHHHEGEF = CKAPAPIDKKF.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPOFHEGLDCM(NDCKNADOPHE BIEPDBDEOBD);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJJIMIKPDIM(NDCKNADOPHE GKNPKJAGNGH, CKAPAPIDKKF DMOKLFIMOOC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ABFJHOFCALM<T> : MLODEPOBAIH where T : class, NDCKNADOPHE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGLLAPEBOKO(T GKNPKJAGNGH, float HDEDKDLDKGD, CKAPAPIDKKF COMCHHHEGEF = CKAPAPIDKKF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGLLAPEBOKO(T GKNPKJAGNGH, Transform FMCDDMGKDKO, float HDEDKDLDKGD, CKAPAPIDKKF COMCHHHEGEF = CKAPAPIDKKF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPOFHEGLDCM(T BIEPDBDEOBD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NDCKNADOPHE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform BDCAJJAMFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CPDDDNECHFB BGBCAFIGCEH, CPDDDNECHFB KOFBLEFJMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CKILIKCPEIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CKAPAPIDKKF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum CPDDDNECHFB
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
