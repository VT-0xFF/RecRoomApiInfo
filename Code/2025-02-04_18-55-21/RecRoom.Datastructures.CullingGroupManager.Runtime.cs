using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, IHFJNNFFJFE, HECGOLGDACB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct PGMCMCOHPHG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NativeArray<BoundingSphere> JOAPLPPIFPC;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x72456E0", Offset = "0x72444E0", VA = "0x1872456E0", Slot = "4")]
			public void Execute(int KNCPCNBMDNF, TransformAccess KAEMFHJNGPI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct EDHGMOLEMLN : IEquatable<EDHGMOLEMLN>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ushort DFPDNEOJFPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type GJBEPEIEJJJ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7242830", Offset = "0x7241630", VA = "0x187242830", Slot = "4")]
			public bool Equals(EDHGMOLEMLN LHMPMCLNOPG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x72428B0", Offset = "0x72416B0", VA = "0x1872428B0", Slot = "0")]
			public override bool Equals(object JOOHPPHJKMI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x72429A0", Offset = "0x72417A0", VA = "0x1872429A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class GCIJPOPOFAE<T> : HNPIOCPBAEL, FBILHJFEJLD<T>, HHOAEHJDIIK where T : class, ILELCPFIBBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x44A4B30", Offset = "0x44A3930", VA = "0x1844A4B30")]
			internal GCIJPOPOFAE(int BLDONGOLMLA, float[] MMHCDPOCLOD, FKCGEIALLGP EFHMEGFBHFA = FKCGEIALLGP.PlayerHead, bool CINPKFJAIOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x44A4AD0", Offset = "0x44A38D0", VA = "0x1844A4AD0", Slot = "12")]
			public void MDGAONDGEMG(T JOOHPPHJKMI, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO = CDPBBJLFOGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x44A4B00", Offset = "0x44A3900", VA = "0x1844A4B00", Slot = "13")]
			public void MDGAONDGEMG(T JOOHPPHJKMI, Transform CJNGOIHNFNB, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO = CDPBBJLFOGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x44A4AB0", Offset = "0x44A38B0", VA = "0x1844A4AB0", Slot = "14")]
			public void IEINLEAGPOE(T CFAPIKCNBCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x44A4A90", Offset = "0x44A3890", VA = "0x1844A4A90", Slot = "15")]
			public bool AJMAANAGKHE(T JOOHPPHJKMI)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class HNPIOCPBAEL : IDisposable, HHOAEHJDIIK
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct GJDMHIJKGFD
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum CGCCBNKKBLD : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public ILELCPFIBBF DACMFKEKGIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public Transform HHEFOFLOCNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public float LGDFBOABPBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public CDPBBJLFOGJ MBJIHHIGGGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public CGCCBNKKBLD LPNEJLDPBGO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum FKCGEIALLGP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class GBHNIIGAAEE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public ILELCPFIBBF DACMFKEKGIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public CDPBBJLFOGJ INMKNCMNMKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public Action NKLGAELKMHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public bool DMJIKCMENIH;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
				public GBHNIIGAAEE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class EGILPJGDFGL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public HNPIOCPBAEL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public GBHNIIGAAEE trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
				public EGILPJGDFGL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x7242A10", Offset = "0x7241810", VA = "0x187242A10")]
				internal void HMOJGFONGDC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly int JODNHNBMFGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool CINPKFJAIOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool EICHBLDJPCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly CullingGroup JPFDJFLJPKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private BoundingSphere[] MCEKOEKJLKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly IPKNENBJFGG BPGIOHMMDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly FKCGEIALLGP EFHMEGFBHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<ILELCPFIBBF, int> OAFMMFENDDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly Dictionary<int, GBHNIIGAAEE> BAHGGNJCIDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TransformAccessArray IEGFKCPJFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private NativeList<BoundingSphere> NJHOPEGOBJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<GJDMHIJKGFD> OPIDEJJFBJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private bool FGAHKKIAFLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private JobHandle JELKNJKJNOO;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int HPAIICBBKBG
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8F8F80", Offset = "0x8F7D80", VA = "0x1808F8F80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int HIHEBCFAFGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA5E990", Offset = "0xA5D790", VA = "0x180A5E990", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB4CBC0", Offset = "0xB4B9C0", VA = "0x180B4CBC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7245200", Offset = "0x7244000", VA = "0x187245200")]
			internal HNPIOCPBAEL(int BLDONGOLMLA, float[] MMHCDPOCLOD, FKCGEIALLGP EFHMEGFBHFA = FKCGEIALLGP.PlayerHead, bool CINPKFJAIOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7243B60", Offset = "0x7242960", VA = "0x187243B60")]
			public void GFDMGFOGMMD(bool FKNLOMIJIDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x72448B0", Offset = "0x72436B0", VA = "0x1872448B0", Slot = "5")]
			public void MDGAONDGEMG(ILELCPFIBBF JOOHPPHJKMI, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO = CDPBBJLFOGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x72449B0", Offset = "0x72437B0", VA = "0x1872449B0", Slot = "10")]
			public void MDGAONDGEMG(ILELCPFIBBF JOOHPPHJKMI, Transform CJNGOIHNFNB, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO = CDPBBJLFOGJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7244BC0", Offset = "0x72439C0", VA = "0x187244BC0")]
			private void NEJICJOCOCF(ILELCPFIBBF JOOHPPHJKMI, Transform CJNGOIHNFNB, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7243DB0", Offset = "0x7242BB0", VA = "0x187243DB0", Slot = "6")]
			public void IEINLEAGPOE(ILELCPFIBBF CFAPIKCNBCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7244460", Offset = "0x7243260", VA = "0x187244460")]
			private void LGGDBEBHNJA(ILELCPFIBBF CFAPIKCNBCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7244FC0", Offset = "0x7243DC0", VA = "0x187244FC0")]
			private void POHGNCDBEJA(ILELCPFIBBF JOOHPPHJKMI, [Optional] float? HCPBBIGLAFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7242AF0", Offset = "0x72418F0", VA = "0x187242AF0", Slot = "11")]
			public bool AJMAANAGKHE(ILELCPFIBBF JOOHPPHJKMI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7244240", Offset = "0x7243040", VA = "0x187244240", Slot = "7")]
			public void LCKMMEEGHCD(ILELCPFIBBF JOOHPPHJKMI, CDPBBJLFOGJ CEHHJBBENLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7243A90", Offset = "0x7242890", VA = "0x187243A90")]
			private void FIIDIGFPOMI(ILELCPFIBBF JOOHPPHJKMI, CDPBBJLFOGJ CEHHJBBENLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7243B90", Offset = "0x7242990", VA = "0x187243B90")]
			public void GNPOENOLBFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7242E80", Offset = "0x7241C80", VA = "0x187242E80")]
			public void DEIMCLMPCLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7243090", Offset = "0x7241E90", VA = "0x187243090")]
			private void DHNKNPFPKLH(GJDMHIJKGFD MKIHPGLMNDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7244310", Offset = "0x7243110", VA = "0x187244310")]
			private void LDJJBKMIABA(int KGMNAGKDPBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x72433C0", Offset = "0x72421C0", VA = "0x1872433C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7243E70", Offset = "0x7242C70", VA = "0x187243E70")]
			private void JMLIMOPMEKB(GBHNIIGAAEE AGCLMICCKBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7242BC0", Offset = "0x72419C0", VA = "0x187242BC0")]
			private static void CNCIIPFBBPL(GBHNIIGAAEE AGCLMICCKBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x72436F0", Offset = "0x72424F0", VA = "0x1872436F0")]
			private void FAJONLHKCKC(GBHNIIGAAEE AGCLMICCKBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7242A90", Offset = "0x7241890", VA = "0x187242A90")]
			private static void AIGBHGBEIGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7243E10", Offset = "0x7242C10", VA = "0x187243E10")]
			private static void IHOOIMCJODF(float GLDLKCMKFON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7244230", Offset = "0x7243030", VA = "0x187244230")]
			private void KLEEKAGKODH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7242BB0", Offset = "0x72419B0", VA = "0x187242BB0")]
			private void CMFHONBJJHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7243760", Offset = "0x7242560", VA = "0x187243760")]
			private void FDKIHBCOBBA(CullingGroupEvent GEAAAFACEAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7244A50", Offset = "0x7243850", VA = "0x187244A50")]
			private void MDPCCEGMELH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float FJBNPHGAJIL = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ELGBOLKHBOI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FJJKBCCKODO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NFHFIDLMFLO = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BAMEBJICHBE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GLCGDNJKIKD = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float FLAPNCKFEJC = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<EDHGMOLEMLN, HNPIOCPBAEL> FDNGBGHKMJH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable AONKPPMIHAI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LDPACOJBCPF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GAMKKEJCIBM BDPAINCKDNJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static GAMKKEJCIBM PGDJALFHHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GAMKKEJCIBM IIOFIDEPODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GAMKKEJCIBM PCMOPAMGKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly GAMKKEJCIBM MJAEAJAGEPK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker KFLPKALDLLA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ProfilerMarker BFEECPOPKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private CPMKHKOAIIG BCPAMCMHKEK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static bool FKNLOMIJIDB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JHOHEJMLBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8F4420", Offset = "0x8F3220", VA = "0x1808F4420", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8F43F0", Offset = "0x8F31F0", VA = "0x1808F43F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GAMKKEJCIBM IGDGMGFIBDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GAMKKEJCIBM NKEMOGAEJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GAMKKEJCIBM HOJECFHLLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HOAOKGDMEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9226D0", Offset = "0x9214D0", VA = "0x1809226D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ALHEBAIGAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xADD5B0", Offset = "0xADC3B0", VA = "0x180ADD5B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB56580", Offset = "0xB55380", VA = "0x180B56580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7241510", Offset = "0x7240310", VA = "0x187241510", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72420C0", Offset = "0x7240EC0", VA = "0x1872420C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1BF24C0", Offset = "0x1BF12C0", VA = "0x181BF24C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6030", Offset = "0xAA4E30", VA = "0x180AA6030")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72415D0", Offset = "0x72403D0", VA = "0x1872415D0")]
		private void BDPPLDFLHEI(Scene BIPFCCJFNGE, LoadSceneMode NAIDLLHPHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7241FE0", Offset = "0x7240DE0", VA = "0x187241FE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7242310", Offset = "0x7241110", VA = "0x187242310")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7241C40", Offset = "0x7240A40", VA = "0x187241C40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7241970", Offset = "0x7240770", VA = "0x187241970")]
		private void HJCKOGMBMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72420E0", Offset = "0x7240EE0", VA = "0x1872420E0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7241AD0", Offset = "0x72408D0", VA = "0x187241AD0")]
		private void IIAMOBLPDBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7241790", Offset = "0x7240590", VA = "0x187241790")]
		public HHOAEHJDIIK GetOrCreateCullingGroup(Type AJKMONLFBBD, int OCNLJCDHNEF, ushort FDEKDJHGOAK = 0, bool CINPKFJAIOC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x313F280", Offset = "0x313E080", VA = "0x18313F280")]
		public FBILHJFEJLD<T> GetOrCreateCullingGroup<T>(int OCNLJCDHNEF, ushort FDEKDJHGOAK = 0, bool CINPKFJAIOC = false) where T : class, ILELCPFIBBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7241E40", Offset = "0x7240C40", VA = "0x187241E40")]
		private HHOAEHJDIIK MCNFBHELNEP(Type AJKMONLFBBD, int OCNLJCDHNEF, float[] MMHCDPOCLOD, ushort FDEKDJHGOAK = 0, bool CINPKFJAIOC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x313F340", Offset = "0x313E140", VA = "0x18313F340")]
		private FBILHJFEJLD<T> MCNFBHELNEP<T>(int OCNLJCDHNEF, float[] MMHCDPOCLOD, ushort FDEKDJHGOAK = 0, bool CINPKFJAIOC = false) where T : class, ILELCPFIBBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7241630", Offset = "0x7240430", VA = "0x187241630")]
		public static FMMANLJJECN FindClosestDefaultUpdateLod(float JEJIOHCLNHD)
		{
			return default(FMMANLJJECN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x922FD0", Offset = "0x921DD0", VA = "0x180922FD0")]
		public static FMMANLJJECN MinUpdateLod(FMMANLJJECN LBCBJABBHGG, FMMANLJJECN HKCOHJCOJDE)
		{
			return default(FMMANLJJECN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7241FD0", Offset = "0x7240DD0", VA = "0x187241FD0")]
		public static FMMANLJJECN MaxUpdateLod(FMMANLJJECN LBCBJABBHGG, FMMANLJJECN HKCOHJCOJDE)
		{
			return default(FMMANLJJECN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72426E0", Offset = "0x72414E0", VA = "0x1872426E0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9226D0", Offset = "0x9214D0", VA = "0x1809226D0", Slot = "11")]
		private bool DDBKHOBDKBO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IPKNENBJFGG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ELJPAPMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera IDFLLEAEKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GAMKKEJCIBM LPOLDJGLIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JBPKCFOIIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GAMKKEJCIBM PMIAEILBJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FHEGIIGHEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HHOAEHJDIIK
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDGAONDGEMG(ILELCPFIBBF JOOHPPHJKMI, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO = CDPBBJLFOGJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEINLEAGPOE(ILELCPFIBBF CFAPIKCNBCM);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCKMMEEGHCD(ILELCPFIBBF JOOHPPHJKMI, CDPBBJLFOGJ KKBFLEJBEBP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FBILHJFEJLD<T> : HHOAEHJDIIK where T : class, ILELCPFIBBF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDGAONDGEMG(T JOOHPPHJKMI, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO = CDPBBJLFOGJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDGAONDGEMG(T JOOHPPHJKMI, Transform CJNGOIHNFNB, float HCPBBIGLAFG, CDPBBJLFOGJ EJKAEBOOBEO = CDPBBJLFOGJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEINLEAGPOE(T CFAPIKCNBCM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AJMAANAGKHE(T JOOHPPHJKMI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ILELCPFIBBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KAEMFHJNGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FMMANLJJECN IBCJICNHOPJ, FMMANLJJECN DLLFCMLKHPF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GDCAFGBKNFM);
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
