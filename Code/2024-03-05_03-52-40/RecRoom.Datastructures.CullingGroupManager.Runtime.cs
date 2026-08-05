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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, CBGJPCILEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class HAAMKIOEAKA<T> : EMHBLBECBGL, HJHNEBPDCHJ<T>, JLAGBLLOIFH where T : class, EMNKEBKLFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x377A240", Offset = "0x3779040", VA = "0x18377A240")]
			internal HAAMKIOEAKA(int GBLIGBOGPDL, float[] KPIMMFIAEBG, JFOJEMNMLMD EOJFAJBLAAL = JFOJEMNMLMD.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x377A210", Offset = "0x3779010", VA = "0x18377A210", Slot = "10")]
			public void GALNLGNAACN(T KDHDNCADFDJ, float NOBKBEIDCKI, GKNACHBKKDC LAIGHOGEKFG = GKNACHBKKDC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x377A1E0", Offset = "0x3778FE0", VA = "0x18377A1E0", Slot = "11")]
			public void GALNLGNAACN(T KDHDNCADFDJ, Transform PNDPDDMDEOO, float NOBKBEIDCKI, GKNACHBKKDC LAIGHOGEKFG = GKNACHBKKDC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x377A1C0", Offset = "0x3778FC0", VA = "0x18377A1C0", Slot = "12")]
			public void FIJOKOAGLFM(T JLLDDBCBADI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class EMHBLBECBGL : IDisposable, JLAGBLLOIFH
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum JFOJEMNMLMD : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GKEECGIOEFC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EMNKEBKLFCH JHNIBLNCHHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public GKNACHBKKDC MICBCFBLIGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action DBBLNPOCDOP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool PIDALHPEMLA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int LNBHMBDGGMM;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
				public GKEECGIOEFC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DJKHNBLLEIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public EMHBLBECBGL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public GKEECGIOEFC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
				public DJKHNBLLEIE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x60AF1E0", Offset = "0x60ADFE0", VA = "0x1860AF1E0")]
				internal void HKAOBFIBLNN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int AJHAFBLFMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GBLIGBOGPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int NCDEKMLOLDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool JGKIPPNJKKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup MHILOKNBBLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] BDNPLOPGCEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] AFHMINHKGCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly MILBHECFPIG GKPFGLIAHLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<EMNKEBKLFCH, int> JEGFIELIKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, GKEECGIOEFC> MOBGPELLJBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly JFOJEMNMLMD EOJFAJBLAAL;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool GINNHHKIOPM
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xDB7640", Offset = "0xDB6440", VA = "0x180DB7640")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3E74F40", Offset = "0x3E73D40", VA = "0x183E74F40", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x60B0ED0", Offset = "0x60AFCD0", VA = "0x1860B0ED0")]
			internal EMHBLBECBGL(int GBLIGBOGPDL, float[] KPIMMFIAEBG, JFOJEMNMLMD EOJFAJBLAAL = JFOJEMNMLMD.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60AF330", Offset = "0x60AE130", VA = "0x1860AF330")]
			public void CFILHODCPMO(bool MNOEKFANECC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x60B05D0", Offset = "0x60AF3D0", VA = "0x1860B05D0", Slot = "6")]
			public void GALNLGNAACN(EMNKEBKLFCH KDHDNCADFDJ, float NOBKBEIDCKI, GKNACHBKKDC LAIGHOGEKFG = GKNACHBKKDC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60B01E0", Offset = "0x60AEFE0", VA = "0x1860B01E0", Slot = "9")]
			public void GALNLGNAACN(EMNKEBKLFCH KDHDNCADFDJ, Transform PNDPDDMDEOO, float NOBKBEIDCKI, GKNACHBKKDC LAIGHOGEKFG = GKNACHBKKDC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x60B0A70", Offset = "0x60AF870", VA = "0x1860B0A70")]
			public void KFIEEJBOBMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x60AFCD0", Offset = "0x60AEAD0", VA = "0x1860AFCD0")]
			private void FCAAIODBMML(int OHINPGIGDNE, [Optional] float? NOBKBEIDCKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60AFE00", Offset = "0x60AEC00", VA = "0x1860AFE00", Slot = "7")]
			public void FIJOKOAGLFM(EMNKEBKLFCH JLLDDBCBADI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60B0980", Offset = "0x60AF780", VA = "0x1860B0980", Slot = "8")]
			public void IAEMHIKGECC(EMNKEBKLFCH KDHDNCADFDJ, GKNACHBKKDC EHDMIIHHDAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x60AF770", Offset = "0x60AE570", VA = "0x1860AF770", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x60AF370", Offset = "0x60AE170", VA = "0x1860AF370")]
			private void DDMCGIBLKOD(GKEECGIOEFC LFIMGBOPKAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x60AFA30", Offset = "0x60AE830", VA = "0x1860AFA30")]
			private void EECPMGPPOLC(GKEECGIOEFC LFIMGBOPKAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60AF710", Offset = "0x60AE510", VA = "0x1860AF710")]
			private void DJFPNIGKPON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x60B0E70", Offset = "0x60AFC70", VA = "0x1860B0E70")]
			private void OHLKALAIHMK(float LDLIGJLNGPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x60B0BC0", Offset = "0x60AF9C0", VA = "0x1860B0BC0")]
			private void LALPCHBIKEE(GKEECGIOEFC LFIMGBOPKAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60AF700", Offset = "0x60AE500", VA = "0x1860AF700")]
			private void DGBCLMNPOBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x60AF360", Offset = "0x60AE160", VA = "0x1860AF360")]
			private void CLJALHNMGBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x60B0660", Offset = "0x60AF460", VA = "0x1860B0660")]
			private void GGBLMJBKDHP(CullingGroupEvent JCAJKHAGMDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60B0D00", Offset = "0x60AFB00", VA = "0x1860B0D00")]
			private void NHCKOOBODAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct MBDPJKPBPIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort MOLAJDIEKGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NCIEKPLMFBM;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float AMEPPLFIEKF = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HIODNOLMLCM = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NCEAGKIILHC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GFKEKJEJLLM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HAFIBKBICAB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HHGCEDJCBAB = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GEDIHCJOLNC = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<MBDPJKPBPIL, EMHBLBECBGL> HFMFIMKMJAE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DCJAPDPOPJI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable MJGLLPAFDDJ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CGNODMPJOCB OCAOGENOOBE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CGNODMPJOCB ECINPKNFKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CGNODMPJOCB DNHHFMFOCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CGNODMPJOCB EIOLFOOFLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CGNODMPJOCB HELAAFMFJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DIALOMEDIJI CGCMKBBBILB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool MNOEKFANECC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CGNODMPJOCB CBALALBPPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CGNODMPJOCB LLEPNFFKJOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CGNODMPJOCB FLHOPODICNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CLEBBNEHMEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xC2F8B0", Offset = "0xC2E6B0", VA = "0x180C2F8B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NKNEKNLNGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x864240", Offset = "0x863040", VA = "0x180864240", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x91FAF0", Offset = "0x91E8F0", VA = "0x18091FAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60ADFC0", Offset = "0x60ACDC0", VA = "0x1860ADFC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60AEA10", Offset = "0x60AD810", VA = "0x1860AEA10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60AE9F0", Offset = "0x60AD7F0", VA = "0x1860AE9F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60ADF60", Offset = "0x60ACD60", VA = "0x1860ADF60")]
		private void AKDGABAGAEJ(Scene KFDCKLAIOIG, LoadSceneMode DEFFIHPLIBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60AE910", Offset = "0x60AD710", VA = "0x1860AE910", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60AEC70", Offset = "0x60ADA70", VA = "0x1860AEC70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60AE3E0", Offset = "0x60AD1E0", VA = "0x1860AE3E0")]
		private void DKMEKLDNNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60AEA30", Offset = "0x60AD830", VA = "0x1860AEA30")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60AE260", Offset = "0x60AD060", VA = "0x1860AE260")]
		private void DIMFCKPCNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60AE6E0", Offset = "0x60AD4E0", VA = "0x1860AE6E0")]
		public JLAGBLLOIFH GetOrCreateCullingGroup(Type FODNMEPCADA, int FCDNEBMFGDN, ushort CFPAHFDDCPC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x25B7A10", Offset = "0x25B6810", VA = "0x1825B7A10")]
		public HJHNEBPDCHJ<T> GetOrCreateCullingGroup<T>(int FCDNEBMFGDN, ushort CFPAHFDDCPC = 0) where T : class, EMNKEBKLFCH
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60AE080", Offset = "0x60ACE80", VA = "0x1860AE080")]
		private JLAGBLLOIFH BIHFOKBKKPG(Type FODNMEPCADA, int FCDNEBMFGDN, float[] KPIMMFIAEBG, ushort CFPAHFDDCPC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x25B77A0", Offset = "0x25B65A0", VA = "0x1825B77A0")]
		private HJHNEBPDCHJ<T> BIHFOKBKKPG<T>(int FCDNEBMFGDN, float[] KPIMMFIAEBG, ushort CFPAHFDDCPC = 0) where T : class, EMNKEBKLFCH
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60AE580", Offset = "0x60AD380", VA = "0x1860AE580")]
		public static IMIGBJOIFIN FindClosestDefaultUpdateLod(float IJJDNHLNGKJ)
		{
			return default(IMIGBJOIFIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E6F60", Offset = "0x7E5D60", VA = "0x1807E6F60")]
		public static IMIGBJOIFIN MinUpdateLod(IMIGBJOIFIN DALANCEENOM, IMIGBJOIFIN PHINOHCPJBA)
		{
			return default(IMIGBJOIFIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60AE900", Offset = "0x60AD700", VA = "0x1860AE900")]
		public static IMIGBJOIFIN MaxUpdateLod(IMIGBJOIFIN DALANCEENOM, IMIGBJOIFIN PHINOHCPJBA)
		{
			return default(IMIGBJOIFIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60AF0E0", Offset = "0x60ADEE0", VA = "0x1860AF0E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MILBHECFPIG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OBNHNHBKBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera DNGGIFPCAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CGNODMPJOCB PCECLHIPCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BLCDECBKAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CGNODMPJOCB MHMPGHCCILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform BJOIACJFCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JLAGBLLOIFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GINNHHKIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GALNLGNAACN(EMNKEBKLFCH KDHDNCADFDJ, float NOBKBEIDCKI, GKNACHBKKDC LAIGHOGEKFG = GKNACHBKKDC.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIJOKOAGLFM(EMNKEBKLFCH JLLDDBCBADI);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IAEMHIKGECC(EMNKEBKLFCH KDHDNCADFDJ, GKNACHBKKDC KLHFNEAKJNA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HJHNEBPDCHJ<T> : JLAGBLLOIFH where T : class, EMNKEBKLFCH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GALNLGNAACN(T KDHDNCADFDJ, float NOBKBEIDCKI, GKNACHBKKDC LAIGHOGEKFG = GKNACHBKKDC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GALNLGNAACN(T KDHDNCADFDJ, Transform PNDPDDMDEOO, float NOBKBEIDCKI, GKNACHBKKDC LAIGHOGEKFG = GKNACHBKKDC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIJOKOAGLFM(T JLLDDBCBADI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EMNKEBKLFCH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform NBCGMJPEDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(IMIGBJOIFIN JCCAIAGCGGH, IMIGBJOIFIN MGHFFGCLDLJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EEPDJDHMPJL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GKNACHBKKDC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum IMIGBJOIFIN
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
