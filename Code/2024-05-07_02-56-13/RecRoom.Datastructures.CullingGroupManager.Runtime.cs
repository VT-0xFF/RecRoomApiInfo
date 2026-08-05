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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, FLGFBEMAKLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class ECHDODNKBGC<T> : MDOPIAEMKIP, GKJDGBJFAOF<T>, EOMKGELPLCG where T : class, EKCFFCDIJFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x345E6F0", Offset = "0x345D8F0", VA = "0x18345E6F0")]
			internal ECHDODNKBGC(int MMEKLPCCEOF, float[] COJGDOHIAJD, MGPMIAGGBOB PFMCCECLDED = MGPMIAGGBOB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x345E690", Offset = "0x345D890", VA = "0x18345E690", Slot = "10")]
			public void OEOPOJPHCNL(T JFJMICPDNDH, float LJCANJNBLMD, GPHAHJNAAFN DILPKLOPCJO = GPHAHJNAAFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x345E6C0", Offset = "0x345D8C0", VA = "0x18345E6C0", Slot = "11")]
			public void OEOPOJPHCNL(T JFJMICPDNDH, Transform HCDCDAHMCIB, float LJCANJNBLMD, GPHAHJNAAFN DILPKLOPCJO = GPHAHJNAAFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x345E670", Offset = "0x345D870", VA = "0x18345E670", Slot = "12")]
			public void MFEEKLGJAPH(T LAGNJPBGJHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MDOPIAEMKIP : IDisposable, EOMKGELPLCG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MGPMIAGGBOB : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OOHKMGNBIGI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EKCFFCDIJFL HGMDLMKNDIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public GPHAHJNAAFN DKEDKNKGNMB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action GPOIBJGJJFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool CNIOOCBNKGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int JPDBMMOIFEO;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
				public OOHKMGNBIGI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BDBKECECAIN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public MDOPIAEMKIP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public OOHKMGNBIGI trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
				public BDBKECECAIN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x61BA1A0", Offset = "0x61B93A0", VA = "0x1861BA1A0")]
				internal void BPLBLBKCLIA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int GHJDJMLGOAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int MMEKLPCCEOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GKLCOJCLEIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool HBNMNOFGLDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup DMKFOPKPEMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OOOGBBIBMFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] KGDLNJNLEBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly LPKPBDKNDKM KIGDILPPPPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<EKCFFCDIJFL, int> GHLFDEMJEGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, OOHKMGNBIGI> HMNCPONJKKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly MGPMIAGGBOB PFMCCECLDED;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IOLHIPJLEPI
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xE061F0", Offset = "0xE053F0", VA = "0x180E061F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3FD9E50", Offset = "0x3FD9050", VA = "0x183FD9E50", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x61BD070", Offset = "0x61BC270", VA = "0x1861BD070")]
			internal MDOPIAEMKIP(int MMEKLPCCEOF, float[] COJGDOHIAJD, MGPMIAGGBOB PFMCCECLDED = MGPMIAGGBOB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x61BB530", Offset = "0x61BA730", VA = "0x1861BB530")]
			public void CEELBJFACDJ(bool GKNNBHKDIDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x61BCF80", Offset = "0x61BC180", VA = "0x1861BCF80", Slot = "6")]
			public void OEOPOJPHCNL(EKCFFCDIJFL JFJMICPDNDH, float LJCANJNBLMD, GPHAHJNAAFN DILPKLOPCJO = GPHAHJNAAFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x61BCB90", Offset = "0x61BBD90", VA = "0x1861BCB90", Slot = "9")]
			public void OEOPOJPHCNL(EKCFFCDIJFL JFJMICPDNDH, Transform HCDCDAHMCIB, float LJCANJNBLMD, GPHAHJNAAFN DILPKLOPCJO = GPHAHJNAAFN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x61BC7A0", Offset = "0x61BB9A0", VA = "0x1861BC7A0")]
			public void MGJKKCLANMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61BC8F0", Offset = "0x61BBAF0", VA = "0x1861BC8F0")]
			private void NDJFOOFOMOI(int HMFNCGHECPG, [Optional] float? LJCANJNBLMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x61BC3C0", Offset = "0x61BB5C0", VA = "0x1861BC3C0", Slot = "7")]
			public void MFEEKLGJAPH(EKCFFCDIJFL LAGNJPBGJHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x61BBF20", Offset = "0x61BB120", VA = "0x1861BBF20", Slot = "8")]
			public void JCLLHMEOADA(EKCFFCDIJFL JFJMICPDNDH, GPHAHJNAAFN BOJBPAHEEPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x61BB920", Offset = "0x61BAB20", VA = "0x1861BB920", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x61BB5C0", Offset = "0x61BA7C0", VA = "0x1861BB5C0")]
			private void COFKHKDABMM(OOHKMGNBIGI OPAKGDNBKGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x61BC010", Offset = "0x61BB210", VA = "0x1861BC010")]
			private void JDEGLJPPNCL(OOHKMGNBIGI OPAKGDNBKGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x61BB560", Offset = "0x61BA760", VA = "0x1861BB560")]
			private void CHDIFMDHLAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x61BD010", Offset = "0x61BC210", VA = "0x1861BD010")]
			private void PBIDDBFFPPF(float NJLEMDJHIOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x61BC280", Offset = "0x61BB480", VA = "0x1861BC280")]
			private void KPCMHJMKDME(OOHKMGNBIGI OPAKGDNBKGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x61BBF00", Offset = "0x61BB100", VA = "0x1861BBF00")]
			private void GDHOKGBAHIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x61BBF10", Offset = "0x61BB110", VA = "0x1861BBF10")]
			private void GJIOFGPLFPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x61BBBE0", Offset = "0x61BADE0", VA = "0x1861BBBE0")]
			private void EHBAFOOIOPA(CullingGroupEvent HKPECLCLHBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x61BCA20", Offset = "0x61BBC20", VA = "0x1861BCA20")]
			private void OAILINFAEGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct DKCEBJNLDPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort DPDMOLEOGBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NIIBCOLEPEB;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CAKFDMBHCGP = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float CCHFNGKCDEL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float JCPOJNPANCO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float PJDLCDLAEKD = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LKMOEDCLGPG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float LJBDPPPJIPM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float OKKJIGDLCMG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DKCEBJNLDPG, MDOPIAEMKIP> DNABDNAPILP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable BKBNMAEGALF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable COHEBNDANJG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static AGKHEGBIBIG PMEBOOLKNBF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static AGKHEGBIBIG EAFFCEINNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly AGKHEGBIBIG JMNCJPKNPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly AGKHEGBIBIG FBHAJCAGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AGKHEGBIBIG DBPEKMCJJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HDONKFMMCKJ PKGHGFDIMDN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool GKNNBHKDIDG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AGKHEGBIBIG OPABDIKBGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AGKHEGBIBIG OPDKAJKHJEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AGKHEGBIBIG MFKIFFNKHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MFELJPJEBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD5BA60", Offset = "0xD5AC60", VA = "0x180D5BA60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JPJIGBJBIJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8772A0", Offset = "0x8764A0", VA = "0x1808772A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x96F200", Offset = "0x96E400", VA = "0x18096F200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61BA490", Offset = "0x61B9690", VA = "0x1861BA490", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61BAD90", Offset = "0x61B9F90", VA = "0x1861BAD90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61BAD70", Offset = "0x61B9F70", VA = "0x1861BAD70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61BAC30", Offset = "0x61B9E30", VA = "0x1861BAC30")]
		private void OEBHMABCIBI(Scene MHMLGKPICFI, LoadSceneMode MAGPNICKDGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61BAC90", Offset = "0x61B9E90", VA = "0x1861BAC90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61BAFE0", Offset = "0x61BA1E0", VA = "0x1861BAFE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61BA2F0", Offset = "0x61B94F0", VA = "0x1861BA2F0")]
		private void ACHFFEEBJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61BADB0", Offset = "0x61B9FB0", VA = "0x1861BADB0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61BAAC0", Offset = "0x61B9CC0", VA = "0x1861BAAC0")]
		private void NEJEFHIJDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61BA890", Offset = "0x61B9A90", VA = "0x1861BA890")]
		public EOMKGELPLCG GetOrCreateCullingGroup(Type OECJOBKFNGH, int MPCOKEIDHIN, ushort EAPDNDPKMFK = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2748A80", Offset = "0x2747C80", VA = "0x182748A80")]
		public GKJDGBJFAOF<T> GetOrCreateCullingGroup<T>(int MPCOKEIDHIN, ushort EAPDNDPKMFK = 0) where T : class, EKCFFCDIJFL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61BA550", Offset = "0x61B9750", VA = "0x1861BA550")]
		private EOMKGELPLCG DAJDHJDICAD(Type OECJOBKFNGH, int MPCOKEIDHIN, float[] COJGDOHIAJD, ushort EAPDNDPKMFK = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2748810", Offset = "0x2747A10", VA = "0x182748810")]
		private GKJDGBJFAOF<T> DAJDHJDICAD<T>(int MPCOKEIDHIN, float[] COJGDOHIAJD, ushort EAPDNDPKMFK = 0) where T : class, EKCFFCDIJFL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61BA730", Offset = "0x61B9930", VA = "0x1861BA730")]
		public static PGDHFLLAIAB FindClosestDefaultUpdateLod(float KKLOKDGFGAE)
		{
			return default(PGDHFLLAIAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E22B0", Offset = "0x7E14B0", VA = "0x1807E22B0")]
		public static PGDHFLLAIAB MinUpdateLod(PGDHFLLAIAB LOHGEFDBKGP, PGDHFLLAIAB NBGMEOHOIKP)
		{
			return default(PGDHFLLAIAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61BAAB0", Offset = "0x61B9CB0", VA = "0x1861BAAB0")]
		public static PGDHFLLAIAB MaxUpdateLod(PGDHFLLAIAB LOHGEFDBKGP, PGDHFLLAIAB NBGMEOHOIKP)
		{
			return default(PGDHFLLAIAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61BB430", Offset = "0x61BA630", VA = "0x1861BB430")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LPKPBDKNDKM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DPJIELMKHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera GJDDGPLMBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AGKHEGBIBIG PBLENABIJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JAGGPBIONDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AGKHEGBIBIG JEGONKJAFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform MHBEPMDCFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EOMKGELPLCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IOLHIPJLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEOPOJPHCNL(EKCFFCDIJFL JFJMICPDNDH, float LJCANJNBLMD, GPHAHJNAAFN DILPKLOPCJO = GPHAHJNAAFN.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFEEKLGJAPH(EKCFFCDIJFL LAGNJPBGJHL);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCLLHMEOADA(EKCFFCDIJFL JFJMICPDNDH, GPHAHJNAAFN BGCAEIFFPCI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GKJDGBJFAOF<T> : EOMKGELPLCG where T : class, EKCFFCDIJFL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEOPOJPHCNL(T JFJMICPDNDH, float LJCANJNBLMD, GPHAHJNAAFN DILPKLOPCJO = GPHAHJNAAFN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEOPOJPHCNL(T JFJMICPDNDH, Transform HCDCDAHMCIB, float LJCANJNBLMD, GPHAHJNAAFN DILPKLOPCJO = GPHAHJNAAFN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFEEKLGJAPH(T LAGNJPBGJHL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EKCFFCDIJFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform GCDMIBEHAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(PGDHFLLAIAB OILNEMBFDML, PGDHFLLAIAB KOADIGAEKJK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BIHAIGGADAK);
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
